using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Quantify.Test.Assets;
using Quantify.Test.UnitTest.TestQuantities;

namespace Quantify.Test.UnitTest.Quantity
{
    [TestClass]
    public partial class QuantityConvertingTests
    {
        [TestMethod]
        public void WHEN_ConvertingToAnotherUnit_WHILE_TargetUnitSameAsSourceUnit_THEN_ReturnSameInstance()
        {
            // Arrange
            const double value = 12;
            const string unit = "Some Unit";

            var unitRepository = new Mock<UnitRepository<string>>().Object;
            var valueCalculator = new Mock<ValueCalculator<double>>().Object;
            var valueConverter = new Mock<ValueConverter<double, string>>().Object;

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

            var quantityBuilder = DoubleValueStringUnitQuantityBuilder.NewInstance();
            var quantity = quantityBuilder
                .WithUnit(sourceUnit)
                .WithValue(sourceValue)
                .MockValueConverter(valueConverterMock => valueConverterMock.Setup(valueConverter => valueConverter.ConvertValueToUnit(It.Is<double>(value => value == sourceValue), It.Is<string>(unit => unit == sourceUnit), It.Is<string>(unit => unit == targetUnit))).Returns(targetValue))
                .Build();

            // Act
            var convertedQuantity = quantity.ToUnit(targetUnit);

            // Assert
            quantityBuilder.ValueConverterMock.Verify(valueConverter => valueConverter.ConvertValueToUnit(It.Is<double>(value => value == sourceValue), It.Is<string>(unit => unit == sourceUnit), It.Is<string>(unit => unit == targetUnit)), Times.Once);

            Assert.AreNotSame(quantity, convertedQuantity);
            Assert.AreEqual(targetUnit, convertedQuantity.Unit);
            Assert.AreEqual(targetValue, convertedQuantity.Value);
        }

        [TestMethod]
        public void WHEN_ConvertingToAnotherUnit_WHILE_TargetUnitIsNull_THEN_ThrowExeption()
        {
            // Arrange
            const double value = 12;
            const string unit = "Some Unit";

            var unitRepository = new Mock<UnitRepository<string>>().Object;
            var valueCalculator = new Mock<ValueCalculator<double>>().Object;
            var valueConverter = new Mock<ValueConverter<double, string>>().Object;

            var quantity = new DoubleValueStringUnitQuantity(value, unit, unitRepository, valueCalculator, valueConverter);

            // Act & Assert
            ExceptionHelpers.ExpectArgumentNullException("targetUnit", () => quantity.ToUnit(null));
        }
    }
}