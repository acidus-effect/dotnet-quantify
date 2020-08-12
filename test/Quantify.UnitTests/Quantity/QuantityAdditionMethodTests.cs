using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Quantify.Test.Assets;
using Quantify.UnitTests.TestQuantities;

namespace Quantify.UnitTests.Quantity
{
    [TestClass]
    public class QuantityAdditionMethodTests
    {
        [TestMethod]
        public void WHEN_Adding_WHILE_Input_Quantity_Null_THEN_ThrowException()
        {
            // Arrange
            var quantity = DoubleValueStringUnitQuantityBuilder.NewInstance().Build();

            // Act & Assert
            ExceptionHelpers.ExpectArgumentNullException("termQuantity", () => quantity.Add(null as DoubleValueStringUnitQuantity));
        }

        [TestMethod]
        public void WHEN_Adding_WHILE_Input_Value_Null_THEN_ThrowException()
        {
            // Arrange
            var quantity = StringValueStringUnitQuantityBuilder.NewInstance().Build();

            // Act & Assert
            ExceptionHelpers.ExpectArgumentNullException("term", () => quantity.Add(null as string));
        } 

        [TestMethod]
        public void WHEN_Adding_WHILE_Input_Quantity_THEN_ReturnNewQuantityWithSum_LhsUnit()
        {
            // Arrange
            var quantityLhsValue = 254.47;
            var quantityLhsUnit = "TheUnit1";

            var quantityRhsValue = 63.7412;
            var quantityRhsConvertedValue = 123;
            var quantityRhsUnit = "TheUnit2";

            var expectedSum = 111;

            var quantityLhsBuilder = DoubleValueStringUnitQuantityBuilder.NewInstance();
            var quantityLhs = quantityLhsBuilder
                .WithValue(quantityLhsValue)
                .WithUnit(quantityLhsUnit)
                .MockValueConverter(mock => mock.Setup(valueConverter => valueConverter.ConvertValueToUnit(It.Is<double>(term => term == quantityRhsValue), It.Is<string>(sourceUnit => sourceUnit == quantityRhsUnit), It.Is<string>(targetUnit => targetUnit == quantityLhsUnit))).Returns(quantityRhsConvertedValue))
                .MockValueCalculator(mock => mock.Setup(valueCalculator => valueCalculator.Add(It.Is<double>(term => term == quantityLhsValue), It.Is<double>(term => term == quantityRhsConvertedValue))).Returns(expectedSum))
                .Build();

            var quantityRhsBuilder = DoubleValueStringUnitQuantityBuilder.NewInstance();
            var quantityRhsMock = quantityRhsBuilder
                .WithValue(quantityRhsValue)
                .WithUnit(quantityRhsUnit)
                .BuildMock();

            // Act
            var resultQuantity = quantityLhs.Add(quantityRhsMock.Object);

            // Assert
            Assert.AreEqual(quantityLhsUnit, resultQuantity.Unit);
            Assert.AreEqual(expectedSum, resultQuantity.Value);

            quantityLhsBuilder.ValueConverterMock.Verify(valueConverter => valueConverter.ConvertValueToUnit(It.Is<double>(term => term == quantityRhsValue), It.Is<string>(sourceUnit => sourceUnit == quantityRhsUnit), It.Is<string>(targetUnit => targetUnit == quantityLhsUnit)), Times.Once);
            quantityLhsBuilder.ValueCalculatorMock.Verify(valueCalculator => valueCalculator.Add(It.Is<double>(term => term == quantityLhsValue), It.Is<double>(term => term == quantityRhsConvertedValue)), Times.Once);
        }

        [TestMethod]
        public void WHEN_Adding_WHILE_Input_Short_THEN_ReturnNewQuantityWithSum()
        {
            // Arrange
            var quantityUnit = "TheUnit";
            const double quantityValue = 42.548;
            const short valueToAdd = 1337;

            var expectedSum = 4242.547;

            var quantityBuilder = DoubleValueStringUnitQuantityBuilder.NewInstance();
            var quantity = quantityBuilder
                .WithValue(quantityValue)
                .WithUnit(quantityUnit)
                .MockValueCalculator(mock => mock.Setup(valueCalculator => valueCalculator.Add(It.Is<double>(term => term == quantityValue), It.Is<short>(term => term == valueToAdd))).Returns(expectedSum))
                .Build();

            // Act
            var resultQuantity = quantity.Add(valueToAdd);

            // Assert
            Assert.AreNotSame(quantity, resultQuantity);
            Assert.AreEqual(quantity.Unit, resultQuantity.Unit);
            Assert.AreEqual(expectedSum, resultQuantity.Value);

            quantityBuilder.ValueCalculatorMock.Verify(valueCalculator => valueCalculator.Add(It.Is<double>(term => term == quantityValue), It.Is<short>(term => term == valueToAdd)), Times.Once);
        }

        [TestMethod]
        public void WHEN_Adding_WHILE_Input_UnsignedShort_THEN_ReturnNewQuantityWithSum()
        {
            // Arrange
            var quantityUnit = "TheUnit";
            const double quantityValue = 42.548;
            const ushort valueToAdd = 1337;

            var expectedSum = 4242.547;

            var quantityBuilder = DoubleValueStringUnitQuantityBuilder.NewInstance();
            var quantity = quantityBuilder
                .WithValue(quantityValue)
                .WithUnit(quantityUnit)
                .MockValueCalculator(mock => mock.Setup(valueCalculator => valueCalculator.Add(It.Is<double>(term => term == quantityValue), It.Is<ushort>(term => term == valueToAdd))).Returns(expectedSum))
                .Build();

            // Act
            var resultQuantity = quantity.Add(valueToAdd);

            // Assert
            Assert.AreNotSame(quantity, resultQuantity);
            Assert.AreEqual(quantity.Unit, resultQuantity.Unit);
            Assert.AreEqual(expectedSum, resultQuantity.Value);

            quantityBuilder.ValueCalculatorMock.Verify(valueCalculator => valueCalculator.Add(It.Is<double>(term => term == quantityValue), It.Is<ushort>(term => term == valueToAdd)), Times.Once);
        }

        [TestMethod]
        public void WHEN_Adding_WHILE_Input_Integer_THEN_ReturnNewQuantityWithSum()
        {
            // Arrange
            var quantityUnit = "TheUnit";
            const double quantityValue = 42.547;
            const int valueToAdd = 1337;

            var expectedSum = 4242.547;

            var quantityBuilder = DoubleValueStringUnitQuantityBuilder.NewInstance();
            var quantity = quantityBuilder
                .WithValue(quantityValue)
                .WithUnit(quantityUnit)
                .MockValueCalculator(mock => mock.Setup(valueCalculator => valueCalculator.Add(It.Is<double>(term => term == quantityValue), It.Is<int>(term => term == valueToAdd))).Returns(expectedSum))
                .Build();

            // Act
            var resultQuantity = quantity.Add(valueToAdd);

            // Assert
            Assert.AreNotSame(quantity, resultQuantity);
            Assert.AreEqual(quantity.Unit, resultQuantity.Unit);
            Assert.AreEqual(expectedSum, resultQuantity.Value);

            quantityBuilder.ValueCalculatorMock.Verify(valueCalculator => valueCalculator.Add(It.Is<double>(term => term == quantityValue), It.Is<int>(term => term == valueToAdd)), Times.Once);
        }

        [TestMethod]
        public void WHEN_Adding_WHILE_Input_UnsignedInteger_THEN_ReturnNewQuantityWithSum()
        {
            // Arrange
            var quantityUnit = "TheUnit";
            const double quantityValue = 42.547;
            const uint valueToAdd = 1337;

            var expectedSum = 4242.547;

            var quantityBuilder = DoubleValueStringUnitQuantityBuilder.NewInstance();
            var quantity = quantityBuilder
                .WithValue(quantityValue)
                .WithUnit(quantityUnit)
                .MockValueCalculator(mock => mock.Setup(valueCalculator => valueCalculator.Add(It.Is<double>(term => term == quantityValue), It.Is<uint>(term => term == valueToAdd))).Returns(expectedSum))
                .Build();

            // Act
            var resultQuantity = quantity.Add(valueToAdd);

            // Assert
            Assert.AreNotSame(quantity, resultQuantity);
            Assert.AreEqual(quantity.Unit, resultQuantity.Unit);
            Assert.AreEqual(expectedSum, resultQuantity.Value);

            quantityBuilder.ValueCalculatorMock.Verify(valueCalculator => valueCalculator.Add(It.Is<double>(term => term == quantityValue), It.Is<uint>(term => term == valueToAdd)), Times.Once);
        }

        [TestMethod]
        public void WHEN_Adding_WHILE_Input_Long_THEN_ReturnNewQuantityWithSum()
        {
            // Arrange
            var quantityUnit = "TheUnit";
            const double quantityValue = 42.547;
            const long valueToAdd = 1337;

            var expectedSum = 4242.547;

            var quantityBuilder = DoubleValueStringUnitQuantityBuilder.NewInstance();
            var quantity = quantityBuilder
                .WithValue(quantityValue)
                .WithUnit(quantityUnit)
                .MockValueCalculator(mock => mock.Setup(valueCalculator => valueCalculator.Add(It.Is<double>(term => term == quantityValue), It.Is<long>(term => term == valueToAdd))).Returns(expectedSum))
                .Build();

            // Act
            var resultQuantity = quantity.Add(valueToAdd);

            // Assert
            Assert.AreNotSame(quantity, resultQuantity);
            Assert.AreEqual(quantity.Unit, resultQuantity.Unit);
            Assert.AreEqual(expectedSum, resultQuantity.Value);

            quantityBuilder.ValueCalculatorMock.Verify(valueCalculator => valueCalculator.Add(It.Is<double>(term => term == quantityValue), It.Is<long>(term => term == valueToAdd)), Times.Once);
        }

        [TestMethod]
        public void WHEN_Adding_WHILE_Input_UnsignedLong_THEN_ReturnNewQuantityWithSum()
        {
            // Arrange
            var quantityUnit = "TheUnit";
            const double quantityValue = 42.547;
            const ulong valueToAdd = 1337;

            var expectedSum = 4242.547;

            var quantityBuilder = DoubleValueStringUnitQuantityBuilder.NewInstance();
            var quantity = quantityBuilder
                .WithValue(quantityValue)
                .WithUnit(quantityUnit)
                .MockValueCalculator(mock => mock.Setup(valueCalculator => valueCalculator.Add(It.Is<double>(term => term == quantityValue), It.Is<ulong>(term => term == valueToAdd))).Returns(expectedSum))
                .Build();

            // Act
            var resultQuantity = quantity.Add(valueToAdd);

            // Assert
            Assert.AreNotSame(quantity, resultQuantity);
            Assert.AreEqual(quantity.Unit, resultQuantity.Unit);
            Assert.AreEqual(expectedSum, resultQuantity.Value);

            quantityBuilder.ValueCalculatorMock.Verify(valueCalculator => valueCalculator.Add(It.Is<double>(term => term == quantityValue), It.Is<ulong>(term => term == valueToAdd)), Times.Once);
        }

        [TestMethod]
        public void WHEN_Adding_WHILE_Input_Double_THEN_ReturnNewQuantityWithSum()
        {
            // Arrange
            var quantityUnit = "TheUnit";
            const double quantityValue = 254.478952;
            const double valueToAdd = 5241.5;

            var expectedSum = 123;

            var quantityBuilder = DoubleValueStringUnitQuantityBuilder.NewInstance();
            var quantity = quantityBuilder
                .WithValue(quantityValue)
                .WithUnit(quantityUnit)
                .MockValueCalculator(mock => mock.Setup(valueCalculator => valueCalculator.Add(It.Is<double>(term => term == quantityValue), It.Is<double>(term => term == valueToAdd))).Returns(expectedSum))
                .Build();

            // Act
            var resultQuantity = quantity.Add(valueToAdd);

            // Assert
            Assert.AreNotSame(quantity, resultQuantity);
            Assert.AreEqual(quantity.Unit, resultQuantity.Unit);
            Assert.AreEqual(expectedSum, resultQuantity.Value);

            quantityBuilder.ValueCalculatorMock.Verify(valueCalculator => valueCalculator.Add(It.Is<double>(term => term == quantityValue), It.Is<double>(term => term == valueToAdd)), Times.Once);
        }

        [TestMethod]
        public void WHEN_Adding_WHILE_Input_Decimal_THEN_ReturnNewQuantityWithSum()
        {
            // Arrange
            var quantityUnit = "TheUnit";
            const double quantityValue = 254.478952;
            const decimal valueToAdd = 5241.5m;

            var expectedSum = 123;

            var quantityBuilder = DoubleValueStringUnitQuantityBuilder.NewInstance();
            var quantity = quantityBuilder
                .WithValue(quantityValue)
                .WithUnit(quantityUnit)
                .MockValueCalculator(mock => mock.Setup(valueCalculator => valueCalculator.Add(It.Is<double>(term => term == quantityValue), It.Is<decimal>(term => term == valueToAdd))).Returns(expectedSum))
                .Build();

            // Act
            var resultQuantity = quantity.Add(valueToAdd);

            // Assert
            Assert.AreNotSame(quantity, resultQuantity);
            Assert.AreEqual(quantity.Unit, resultQuantity.Unit);
            Assert.AreEqual(expectedSum, resultQuantity.Value);

            quantityBuilder.ValueCalculatorMock.Verify(valueCalculator => valueCalculator.Add(It.Is<double>(term => term == quantityValue), It.Is<decimal>(term => term == valueToAdd)), Times.Once);
        }

        [TestMethod]
        public void WHEN_Adding_WHILE_Input_Float_THEN_ReturnNewQuantityWithSum()
        {
            // Arrange
            var quantityUnit = "TheUnit";
            const double quantityValue = 254.478952;
            const float valueToAdd = 5241.5f;

            var expectedSum = 123;

            var quantityBuilder = DoubleValueStringUnitQuantityBuilder.NewInstance();
            var quantity = quantityBuilder
                .WithValue(quantityValue)
                .WithUnit(quantityUnit)
                .MockValueCalculator(mock => mock.Setup(valueCalculator => valueCalculator.Add(It.Is<double>(term => term == quantityValue), It.Is<float>(term => term == valueToAdd))).Returns(expectedSum))
                .Build();

            // Act
            var resultQuantity = quantity.Add(valueToAdd);

            // Assert
            Assert.AreNotSame(quantity, resultQuantity);
            Assert.AreEqual(quantity.Unit, resultQuantity.Unit);
            Assert.AreEqual(expectedSum, resultQuantity.Value);

            quantityBuilder.ValueCalculatorMock.Verify(valueCalculator => valueCalculator.Add(It.Is<double>(term => term == quantityValue), It.Is<float>(term => term == valueToAdd)), Times.Once);
        }
    }
}