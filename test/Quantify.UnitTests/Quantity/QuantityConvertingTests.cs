using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Quantify.Test.Assets;

namespace Quantify.UnitTests.Quantity
{
    public partial class QuantityConvertingTests
    {
        [TestMethod]
        public void WHEN_ConvertingToAnotherUnit_WHILE_TargetUnitSameAsSourceUnit_THEN_ReturnSameInstance()
        {
            // Arrange
            const double value = 12;
            const string unit = "Some Unit";

            var unitRepository = new Mock<UnitRepository<double, string>>().Object;
            var valueCalculator = new Mock<ValueCalculator<double>>().Object;
            var valueConverter = new Mock<ValueConverter<double, string>>(unitRepository, valueCalculator).Object;

            var quantity = new DoubleValueStringUnitQuantity(value, unit, unitRepository, valueCalculator, valueConverter);

            // Act
            var convertedQuantity = quantity.ToUnit(unit);

            // Assert
            Assert.AreSame(quantity, convertedQuantity);
        }

        [TestMethod]
        public void WHEN_ConvertingToAnotherUnit_WHILE_TargetUnitDifferentFromSourceUnit_THEN_ReturnNewInstance()
        {
            // Arrange
            const double sourceValue = 12;
            const string sourceUnit = "Some Unit";

            const double targetValue = 21;
            const string targetUnit = "Another Unit";

            var unitRepository = new Mock<UnitRepository<double, string>>().Object;
            var valueCalculator = new Mock<ValueCalculator<double>>().Object;
            var valueConverterMock = new Mock<ValueConverter<double, string>>(unitRepository, valueCalculator);

            valueConverterMock.Setup(valueConverter => valueConverter.ConvertValueToUnit(sourceValue, sourceUnit, targetUnit)).Returns(targetValue);

            var quantity = new DoubleValueStringUnitQuantity(sourceValue, sourceUnit, unitRepository, valueCalculator, valueConverterMock.Object);

            // Act
            var convertedQuantity = quantity.ToUnit(targetUnit);

            // Assert
            Assert.AreNotSame(quantity, convertedQuantity);
            Assert.AreEqual(targetUnit, convertedQuantity.Unit);
            Assert.AreEqual(targetValue, convertedQuantity.Value);

            valueConverterMock.Verify(valueConverter => valueConverter.ConvertValueToUnit(sourceValue, sourceUnit, targetUnit), Times.Once);
        }

        [TestMethod]
        public void WHEN_ConvertingToAnotherUnit_WHILE_TargetUnitIsNull_THEN_ThrowExeption()
        {
            // Arrange
            const double value = 12;
            const string unit = "Some Unit";

            var unitRepository = new Mock<UnitRepository<double, string>>().Object;
            var valueCalculator = new Mock<ValueCalculator<double>>().Object;
            var valueConverter = new Mock<ValueConverter<double, string>>(unitRepository, valueCalculator).Object;

            var quantity = new DoubleValueStringUnitQuantity(value, unit, unitRepository, valueCalculator, valueConverter);

            // Act & Assert
            ExceptionHelpers.ExpectArgumentNullException("targetUnit", () => quantity.ToUnit(null));
        }
    }
}