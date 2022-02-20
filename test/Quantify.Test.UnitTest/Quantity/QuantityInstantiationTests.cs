using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Quantify.Test.Assets;
using Quantify.Test.UnitTest.TestQuantities;

namespace Quantify.Test.UnitTest.Quantity
{
    [TestClass]
    public partial class QuantityInstantiationTests
    {
        [TestMethod]
        public void WHEN_Instantiating_Constructor1_WHILE_ArgumentsAreValid_THEN_CreateInstance()
        {
            // Arrange
            const double expectedValue = 1.547;
            const string expectedUnit = "Hello";
            var unitRepository = new Mock<UnitRepository<string>>().Object;

            // Act
            var quantity = new DoubleValueStringUnitQuantity(expectedValue, expectedUnit, unitRepository);

            // Assert
            Assert.AreEqual(expectedValue, quantity.Value);
            Assert.AreEqual(expectedUnit, quantity.Unit);
        }

        [TestMethod]
        public void WHEN_Instantiating_Constructor2_WHILE_ArgumentsAreValid_THEN_CreateInstance()
        {
            // Arrange
            const double expectedValue = 1.547;
            const string expectedUnit = "Hello";
            var unitRepository = new Mock<UnitRepository<string>>().Object;
            var valueCalculator = new Mock<ValueCalculator<double>>().Object;
            var valueConverter = new Mock<ValueConverter<double, string>>().Object;

            // Act
            var quantity = new DoubleValueStringUnitQuantity(expectedValue, expectedUnit, unitRepository, valueCalculator, valueConverter);

            // Assert
            Assert.AreEqual(expectedValue, quantity.Value);
            Assert.AreEqual(expectedUnit, quantity.Unit);
        }

        [TestMethod]
        public void WHEN_Instantiating_Constructor1_WHILE_ArgumentIsNull_THEN_ThrowException()
        {
            // Arrange
            const string value = "Hello";
            const string unit = "World";
            var unitRepository = new Mock<UnitRepository<string>>().Object;

            // Act & Assert
            ExceptionHelpers.ExpectArgumentNullException("value", () => new StringValueStringUnitQuantity(null, unit, unitRepository));
            ExceptionHelpers.ExpectArgumentNullException("unit", () => new StringValueStringUnitQuantity(value, null, unitRepository));
            ExceptionHelpers.ExpectArgumentNullException("unitRepository", () => new StringValueStringUnitQuantity(value, unit, null));
        }

        [TestMethod]
        public void WHEN_Instantiating_Constructor2_WHILE_ArgumentIsNull_THEN_ThrowException()
        {
            // Arrange
            const string value = "Hello";
            const string unit = "World";
            var unitRepository = new Mock<UnitRepository<string>>().Object;
            var valueCalculator = new Mock<ValueCalculator<string>>().Object;
            var valueConverter = new Mock<ValueConverter<string, string>>().Object;

            // Act & Assert
            ExceptionHelpers.ExpectArgumentNullException("value", () => new StringValueStringUnitQuantity(null, unit, unitRepository, valueCalculator, valueConverter));
            ExceptionHelpers.ExpectArgumentNullException("unit", () => new StringValueStringUnitQuantity(value, null, unitRepository, valueCalculator, valueConverter));
            ExceptionHelpers.ExpectArgumentNullException("unitRepository", () => new StringValueStringUnitQuantity(value, unit, null, valueCalculator, valueConverter));
            ExceptionHelpers.ExpectArgumentNullException("valueCalculator", () => new StringValueStringUnitQuantity(value, unit, unitRepository, null, valueConverter));
            ExceptionHelpers.ExpectArgumentNullException("valueConverter", () => new StringValueStringUnitQuantity(value, unit, unitRepository, valueCalculator, null));
        }
    }
}