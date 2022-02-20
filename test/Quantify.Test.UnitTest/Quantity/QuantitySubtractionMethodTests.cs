using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Quantify.Test.Assets;
using Quantify.Test.UnitTest.TestQuantities;

namespace Quantify.Test.UnitTest.Quantity
{
    [TestClass]
    public class QuantitySubtractionMethodTests
    {
        [TestMethod]
        public void WHEN_Subtracting_Quantity_WHILE_Quantity_Null_THEN_ThrowException()
        {
            // Arrange
            var quantity = DoubleValueStringUnitQuantityBuilder.NewInstance().Build();

            // Act & Assert
            ExceptionHelpers.ExpectArgumentNullException("subtrahendQuantity", () => quantity.Subtract(null as DoubleValueStringUnitQuantity));
        }

        [TestMethod]
        public void WHEN_Subtracting_Value_WHILE_Value_Null_THEN_ThrowException()
        {
            // Arrange
            var quantity = StringValueStringUnitQuantityBuilder.NewInstance().Build();

            // Act & Assert
            ExceptionHelpers.ExpectArgumentNullException("subtrahend", () => quantity.Subtract(null as string));
        }

        [TestMethod]
        public void WHEN_Subtracting_WHILE_Input_Quantity_THEN_ReturnNewQuantityWithDifference_LhsUnit()
        {
            // Arrange
            var quantityLhsValue = 254.47;
            var quantityLhsUnit = "TheUnit1";

            var quantityRhsValue = 63.7412;
            var quantityRhsConvertedValue = 123;
            var quantityRhsUnit = "TheUnit2";

            var calculatedDifference = 111;

            var quantityLhsBuilder = DoubleValueStringUnitQuantityBuilder.NewInstance();
            var quantityLhs = quantityLhsBuilder
                .WithValue(quantityLhsValue)
                .WithUnit(quantityLhsUnit)
                .MockValueConverter(mock => mock.Setup(valueConverter => valueConverter.ConvertValueToUnit(It.Is<double>(value => value == quantityRhsValue), It.Is<string>(sourceUnit => sourceUnit == quantityRhsUnit), It.Is<string>(targetUnit => targetUnit == quantityLhsUnit))).Returns(quantityRhsConvertedValue))
                .MockValueCalculator(mock => mock.Setup(valueCalculator => valueCalculator.Subtract(It.Is<double>(value => value == quantityLhsValue), It.Is<double>(value => value == quantityRhsConvertedValue))).Returns(calculatedDifference))
                .Build();

            var quantityRhsBuilder = DoubleValueStringUnitQuantityBuilder.NewInstance();
            var quantityRhsMock = quantityRhsBuilder
                .WithValue(quantityRhsValue)
                .WithUnit(quantityRhsUnit)
                .BuildMock();

            // Act
            var resultQuantity = quantityLhs.Subtract(quantityRhsMock.Object);

            // Assert
            Assert.AreEqual(quantityLhsUnit, resultQuantity.Unit);
            Assert.AreEqual(calculatedDifference, resultQuantity.Value);

            quantityLhsBuilder.ValueConverterMock.Verify(valueConverter => valueConverter.ConvertValueToUnit(It.Is<double>(value => value == quantityRhsValue), It.Is<string>(sourceUnit => sourceUnit == quantityRhsUnit), It.Is<string>(targetUnit => targetUnit == quantityLhsUnit)), Times.Once);
            quantityLhsBuilder.ValueCalculatorMock.Verify(valueCalculator => valueCalculator.Subtract(It.Is<double>(value => value == quantityLhsValue), It.Is<double>(value => value == quantityRhsConvertedValue)), Times.Once);
        }

        [TestMethod]
        public void WHEN_Subtracting_WHILE_Input_Short_THEN_ReturnNewQuantityWithDifference()
        {
            // Arrange
            var quantityUnit = "TheUnit";
            const double quantityValue = 42.548;
            const short valueToAdd = 1337;

            var calculatedDifference = 4242.547;

            var quantityBuilder = DoubleValueStringUnitQuantityBuilder.NewInstance();
            var quantity = quantityBuilder
                .WithValue(quantityValue)
                .WithUnit(quantityUnit)
                .MockValueCalculator(mock => mock.Setup(valueCalculator => valueCalculator.Subtract(It.Is<double>(value => value == quantityValue), It.Is<short>(value => value == valueToAdd))).Returns(calculatedDifference))
                .Build();

            // Act
            var resultQuantity = quantity.Subtract(valueToAdd);

            // Assert
            Assert.AreNotSame(quantity, resultQuantity);
            Assert.AreEqual(quantity.Unit, resultQuantity.Unit);
            Assert.AreEqual(calculatedDifference, resultQuantity.Value);

            quantityBuilder.ValueCalculatorMock.Verify(valueCalculator => valueCalculator.Subtract(It.Is<double>(value => value == quantityValue), It.Is<short>(value => value == valueToAdd)), Times.Once);
        }

        [TestMethod]
        public void WHEN_Subtracting_WHILE_Input_UnsignedShort_THEN_ReturnNewQuantityWithDifference()
        {
            // Arrange
            var quantityUnit = "TheUnit";
            const double quantityValue = 42.548;
            const ushort valueToAdd = 1337;

            var calculatedDifference = 4242.547;

            var quantityBuilder = DoubleValueStringUnitQuantityBuilder.NewInstance();
            var quantity = quantityBuilder
                .WithValue(quantityValue)
                .WithUnit(quantityUnit)
                .MockValueCalculator(mock => mock.Setup(valueCalculator => valueCalculator.Subtract(It.Is<double>(value => value == quantityValue), It.Is<ushort>(value => value == valueToAdd))).Returns(calculatedDifference))
                .Build();

            // Act
            var resultQuantity = quantity.Subtract(valueToAdd);

            // Assert
            Assert.AreNotSame(quantity, resultQuantity);
            Assert.AreEqual(quantity.Unit, resultQuantity.Unit);
            Assert.AreEqual(calculatedDifference, resultQuantity.Value);

            quantityBuilder.ValueCalculatorMock.Verify(valueCalculator => valueCalculator.Subtract(It.Is<double>(value => value == quantityValue), It.Is<ushort>(value => value == valueToAdd)), Times.Once);
        }

        [TestMethod]
        public void WHEN_Subtracting_WHILE_Input_Integer_THEN_ReturnNewQuantityWithDifference()
        {
            // Arrange
            var quantityUnit = "TheUnit";
            const double quantityValue = 42.547;
            const int valueToAdd = 1337;

            var calculatedDifference = 4242.547;

            var quantityBuilder = DoubleValueStringUnitQuantityBuilder.NewInstance();
            var quantity = quantityBuilder
                .WithValue(quantityValue)
                .WithUnit(quantityUnit)
                .MockValueCalculator(mock => mock.Setup(valueCalculator => valueCalculator.Subtract(It.Is<double>(value => value == quantityValue), It.Is<int>(value => value == valueToAdd))).Returns(calculatedDifference))
                .Build();

            // Act
            var resultQuantity = quantity.Subtract(valueToAdd);

            // Assert
            Assert.AreNotSame(quantity, resultQuantity);
            Assert.AreEqual(quantity.Unit, resultQuantity.Unit);
            Assert.AreEqual(calculatedDifference, resultQuantity.Value);

            quantityBuilder.ValueCalculatorMock.Verify(valueCalculator => valueCalculator.Subtract(It.Is<double>(value => value == quantityValue), It.Is<int>(value => value == valueToAdd)), Times.Once);
        }

        [TestMethod]
        public void WHEN_Subtracting_WHILE_Input_UnsignedInteger_THEN_ReturnNewQuantityWithDifference()
        {
            // Arrange
            var quantityUnit = "TheUnit";
            const double quantityValue = 42.547;
            const uint valueToAdd = 1337;

            var calculatedDifference = 4242.547;

            var quantityBuilder = DoubleValueStringUnitQuantityBuilder.NewInstance();
            var quantity = quantityBuilder
                .WithValue(quantityValue)
                .WithUnit(quantityUnit)
                .MockValueCalculator(mock => mock.Setup(valueCalculator => valueCalculator.Subtract(It.Is<double>(value => value == quantityValue), It.Is<uint>(value => value == valueToAdd))).Returns(calculatedDifference))
                .Build();

            // Act
            var resultQuantity = quantity.Subtract(valueToAdd);

            // Assert
            Assert.AreNotSame(quantity, resultQuantity);
            Assert.AreEqual(quantity.Unit, resultQuantity.Unit);
            Assert.AreEqual(calculatedDifference, resultQuantity.Value);

            quantityBuilder.ValueCalculatorMock.Verify(valueCalculator => valueCalculator.Subtract(It.Is<double>(value => value == quantityValue), It.Is<uint>(value => value == valueToAdd)), Times.Once);
        }

        [TestMethod]
        public void WHEN_Subtracting_WHILE_Input_Long_THEN_ReturnNewQuantityWithDifference()
        {
            // Arrange
            var quantityUnit = "TheUnit";
            const double quantityValue = 42.547;
            const long valueToAdd = 1337;

            var calculatedDifference = 4242.547;

            var quantityBuilder = DoubleValueStringUnitQuantityBuilder.NewInstance();
            var quantity = quantityBuilder
                .WithValue(quantityValue)
                .WithUnit(quantityUnit)
                .MockValueCalculator(mock => mock.Setup(valueCalculator => valueCalculator.Subtract(It.Is<double>(value => value == quantityValue), It.Is<long>(value => value == valueToAdd))).Returns(calculatedDifference))
                .Build();

            // Act
            var resultQuantity = quantity.Subtract(valueToAdd);

            // Assert
            Assert.AreNotSame(quantity, resultQuantity);
            Assert.AreEqual(quantity.Unit, resultQuantity.Unit);
            Assert.AreEqual(calculatedDifference, resultQuantity.Value);

            quantityBuilder.ValueCalculatorMock.Verify(valueCalculator => valueCalculator.Subtract(It.Is<double>(value => value == quantityValue), It.Is<long>(value => value == valueToAdd)), Times.Once);
        }

        [TestMethod]
        public void WHEN_Subtracting_WHILE_Input_UnsignedLong_THEN_ReturnNewQuantityWithDifference()
        {
            // Arrange
            var quantityUnit = "TheUnit";
            const double quantityValue = 42.547;
            const ulong valueToAdd = 1337;

            var calculatedDifference = 4242.547;

            var quantityBuilder = DoubleValueStringUnitQuantityBuilder.NewInstance();
            var quantity = quantityBuilder
                .WithValue(quantityValue)
                .WithUnit(quantityUnit)
                .MockValueCalculator(mock => mock.Setup(valueCalculator => valueCalculator.Subtract(It.Is<double>(value => value == quantityValue), It.Is<ulong>(value => value == valueToAdd))).Returns(calculatedDifference))
                .Build();

            // Act
            var resultQuantity = quantity.Subtract(valueToAdd);

            // Assert
            Assert.AreNotSame(quantity, resultQuantity);
            Assert.AreEqual(quantity.Unit, resultQuantity.Unit);
            Assert.AreEqual(calculatedDifference, resultQuantity.Value);

            quantityBuilder.ValueCalculatorMock.Verify(valueCalculator => valueCalculator.Subtract(It.Is<double>(value => value == quantityValue), It.Is<ulong>(value => value == valueToAdd)), Times.Once);
        }

        [TestMethod]
        public void WHEN_Subtracting_WHILE_Input_Double_THEN_ReturnNewQuantityWithDifference()
        {
            // Arrange
            var quantityUnit = "TheUnit";
            const double quantityValue = 254.478952;
            const double valueToAdd = 5241.5;

            var calculatedDifference = 123;

            var quantityBuilder = DoubleValueStringUnitQuantityBuilder.NewInstance();
            var quantity = quantityBuilder
                .WithValue(quantityValue)
                .WithUnit(quantityUnit)
                .MockValueCalculator(mock => mock.Setup(valueCalculator => valueCalculator.Subtract(It.Is<double>(value => value == quantityValue), It.Is<double>(value => value == valueToAdd))).Returns(calculatedDifference))
                .Build();

            // Act
            var resultQuantity = quantity.Subtract(valueToAdd);

            // Assert
            Assert.AreNotSame(quantity, resultQuantity);
            Assert.AreEqual(quantity.Unit, resultQuantity.Unit);
            Assert.AreEqual(calculatedDifference, resultQuantity.Value);

            quantityBuilder.ValueCalculatorMock.Verify(valueCalculator => valueCalculator.Subtract(It.Is<double>(value => value == quantityValue), It.Is<double>(value => value == valueToAdd)), Times.Once);
        }

        [TestMethod]
        public void WHEN_Subtracting_WHILE_Input_Decimal_THEN_ReturnNewQuantityWithDifference()
        {
            // Arrange
            var quantityUnit = "TheUnit";
            const double quantityValue = 254.478952;
            const decimal valueToAdd = 5241.5m;

            var calculatedDifference = 123;

            var quantityBuilder = DoubleValueStringUnitQuantityBuilder.NewInstance();
            var quantity = quantityBuilder
                .WithValue(quantityValue)
                .WithUnit(quantityUnit)
                .MockValueCalculator(mock => mock.Setup(valueCalculator => valueCalculator.Subtract(It.Is<double>(value => value == quantityValue), It.Is<decimal>(value => value == valueToAdd))).Returns(calculatedDifference))
                .Build();

            // Act
            var resultQuantity = quantity.Subtract(valueToAdd);

            // Assert
            Assert.AreNotSame(quantity, resultQuantity);
            Assert.AreEqual(quantity.Unit, resultQuantity.Unit);
            Assert.AreEqual(calculatedDifference, resultQuantity.Value);

            quantityBuilder.ValueCalculatorMock.Verify(valueCalculator => valueCalculator.Subtract(It.Is<double>(value => value == quantityValue), It.Is<decimal>(value => value == valueToAdd)), Times.Once);
        }

        [TestMethod]
        public void WHEN_Subtracting_WHILE_Input_Float_THEN_ReturnNewQuantityWithDifference()
        {
            // Arrange
            var quantityUnit = "TheUnit";
            const double quantityValue = 254.478952;
            const float valueToAdd = 5241.5f;

            var calculatedDifference = 123;

            var quantityBuilder = DoubleValueStringUnitQuantityBuilder.NewInstance();
            var quantity = quantityBuilder
                .WithValue(quantityValue)
                .WithUnit(quantityUnit)
                .MockValueCalculator(mock => mock.Setup(valueCalculator => valueCalculator.Subtract(It.Is<double>(value => value == quantityValue), It.Is<float>(value => value == valueToAdd))).Returns(calculatedDifference))
                .Build();

            // Act
            var resultQuantity = quantity.Subtract(valueToAdd);

            // Assert
            Assert.AreNotSame(quantity, resultQuantity);
            Assert.AreEqual(quantity.Unit, resultQuantity.Unit);
            Assert.AreEqual(calculatedDifference, resultQuantity.Value);

            quantityBuilder.ValueCalculatorMock.Verify(valueCalculator => valueCalculator.Subtract(It.Is<double>(value => value == quantityValue), It.Is<float>(value => value == valueToAdd)), Times.Once);
        }
    }
}