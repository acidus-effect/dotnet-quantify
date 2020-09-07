using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Quantify.UnitTests.TestQuantities;

namespace Quantify.UnitTests.Quantity
{
    [TestClass]
    public class QuantityMultiplicationMethodTests
    {
        [TestMethod]
        public void WHEN_Multiplying_WHILE_Input_Short_THEN_ReturnNewQuantityWithProduct()
        {
            // Arrange
            var quantityUnit = "TheUnit";
            const double quantityValue = 42.548;
            const short expectedMultiplier = 1337;

            var expectedProduct = 4242.547;

            var quantityBuilder = DoubleValueStringUnitQuantityBuilder.NewInstance();
            var quantity = quantityBuilder
                .WithValue(quantityValue)
                .WithUnit(quantityUnit)
                .MockValueCalculator(mock => mock.Setup(valueCalculator => valueCalculator.Multiply(It.Is<double>(multiplier => multiplier == quantityValue), It.Is<short>(multiplier => multiplier == expectedMultiplier))).Returns(expectedProduct))
                .Build();

            // Act
            var resultQuantity = quantity.MultiplyWith(expectedMultiplier);

            // Assert
            Assert.AreNotSame(quantity, resultQuantity);
            Assert.AreEqual(quantity.Unit, resultQuantity.Unit);
            Assert.AreEqual(expectedProduct, resultQuantity.Value);

            quantityBuilder.ValueCalculatorMock.Verify(valueCalculator => valueCalculator.Multiply(It.Is<double>(multiplier => multiplier == quantityValue), It.Is<short>(multiplier => multiplier == expectedMultiplier)), Times.Once);
        }

        [TestMethod]
        public void WHEN_Multiplying_WHILE_Input_UnsignedShort_THEN_ReturnNewQuantityWithProduct()
        {
            // Arrange
            var quantityUnit = "TheUnit";
            const double quantityValue = 42.548;
            const ushort expectedMultiplier = 1337;

            var expectedProduct = 4242.547;

            var quantityBuilder = DoubleValueStringUnitQuantityBuilder.NewInstance();
            var quantity = quantityBuilder
                .WithValue(quantityValue)
                .WithUnit(quantityUnit)
                .MockValueCalculator(mock => mock.Setup(valueCalculator => valueCalculator.Multiply(It.Is<double>(multiplier => multiplier == quantityValue), It.Is<ushort>(multiplier => multiplier == expectedMultiplier))).Returns(expectedProduct))
                .Build();

            // Act
            var resultQuantity = quantity.MultiplyWith(expectedMultiplier);

            // Assert
            Assert.AreNotSame(quantity, resultQuantity);
            Assert.AreEqual(quantity.Unit, resultQuantity.Unit);
            Assert.AreEqual(expectedProduct, resultQuantity.Value);

            quantityBuilder.ValueCalculatorMock.Verify(valueCalculator => valueCalculator.Multiply(It.Is<double>(multiplier => multiplier == quantityValue), It.Is<ushort>(multiplier => multiplier == expectedMultiplier)), Times.Once);
        }

        [TestMethod]
        public void WHEN_Multiplying_WHILE_Input_Integer_THEN_ReturnNewQuantityWithProduct()
        {
            // Arrange
            var quantityUnit = "TheUnit";
            const double quantityValue = 42.547;
            const int expectedMultiplier = 1337;

            var expectedProduct = 4242.547;

            var quantityBuilder = DoubleValueStringUnitQuantityBuilder.NewInstance();
            var quantity = quantityBuilder
                .WithValue(quantityValue)
                .WithUnit(quantityUnit)
                .MockValueCalculator(mock => mock.Setup(valueCalculator => valueCalculator.Multiply(It.Is<double>(multiplier => multiplier == quantityValue), It.Is<int>(multiplier => multiplier == expectedMultiplier))).Returns(expectedProduct))
                .Build();

            // Act
            var resultQuantity = quantity.MultiplyWith(expectedMultiplier);

            // Assert
            Assert.AreNotSame(quantity, resultQuantity);
            Assert.AreEqual(quantity.Unit, resultQuantity.Unit);
            Assert.AreEqual(expectedProduct, resultQuantity.Value);

            quantityBuilder.ValueCalculatorMock.Verify(valueCalculator => valueCalculator.Multiply(It.Is<double>(multiplier => multiplier == quantityValue), It.Is<int>(multiplier => multiplier == expectedMultiplier)), Times.Once);
        }

        [TestMethod]
        public void WHEN_Multiplying_WHILE_Input_UnsignedInteger_THEN_ReturnNewQuantityWithProduct()
        {
            // Arrange
            var quantityUnit = "TheUnit";
            const double quantityValue = 42.547;
            const uint expectedMultiplier = 1337;

            var expectedProduct = 4242.547;

            var quantityBuilder = DoubleValueStringUnitQuantityBuilder.NewInstance();
            var quantity = quantityBuilder
                .WithValue(quantityValue)
                .WithUnit(quantityUnit)
                .MockValueCalculator(mock => mock.Setup(valueCalculator => valueCalculator.Multiply(It.Is<double>(multiplier => multiplier == quantityValue), It.Is<uint>(multiplier => multiplier == expectedMultiplier))).Returns(expectedProduct))
                .Build();

            // Act
            var resultQuantity = quantity.MultiplyWith(expectedMultiplier);

            // Assert
            Assert.AreNotSame(quantity, resultQuantity);
            Assert.AreEqual(quantity.Unit, resultQuantity.Unit);
            Assert.AreEqual(expectedProduct, resultQuantity.Value);

            quantityBuilder.ValueCalculatorMock.Verify(valueCalculator => valueCalculator.Multiply(It.Is<double>(multiplier => multiplier == quantityValue), It.Is<uint>(multiplier => multiplier == expectedMultiplier)), Times.Once);
        }

        [TestMethod]
        public void WHEN_Multiplying_WHILE_Input_Long_THEN_ReturnNewQuantityWithProduct()
        {
            // Arrange
            var quantityUnit = "TheUnit";
            const double quantityValue = 42.547;
            const long expectedMultiplier = 1337;

            var expectedProduct = 4242.547;

            var quantityBuilder = DoubleValueStringUnitQuantityBuilder.NewInstance();
            var quantity = quantityBuilder
                .WithValue(quantityValue)
                .WithUnit(quantityUnit)
                .MockValueCalculator(mock => mock.Setup(valueCalculator => valueCalculator.Multiply(It.Is<double>(multiplier => multiplier == quantityValue), It.Is<long>(multiplier => multiplier == expectedMultiplier))).Returns(expectedProduct))
                .Build();

            // Act
            var resultQuantity = quantity.MultiplyWith(expectedMultiplier);

            // Assert
            Assert.AreNotSame(quantity, resultQuantity);
            Assert.AreEqual(quantity.Unit, resultQuantity.Unit);
            Assert.AreEqual(expectedProduct, resultQuantity.Value);

            quantityBuilder.ValueCalculatorMock.Verify(valueCalculator => valueCalculator.Multiply(It.Is<double>(multiplier => multiplier == quantityValue), It.Is<long>(multiplier => multiplier == expectedMultiplier)), Times.Once);
        }

        [TestMethod]
        public void WHEN_Multiplying_WHILE_Input_UnsignedLong_THEN_ReturnNewQuantityWithProduct()
        {
            // Arrange
            var quantityUnit = "TheUnit";
            const double quantityValue = 42.547;
            const ulong expectedMultiplier = 1337;

            var expectedProduct = 4242.547;

            var quantityBuilder = DoubleValueStringUnitQuantityBuilder.NewInstance();
            var quantity = quantityBuilder
                .WithValue(quantityValue)
                .WithUnit(quantityUnit)
                .MockValueCalculator(mock => mock.Setup(valueCalculator => valueCalculator.Multiply(It.Is<double>(multiplier => multiplier == quantityValue), It.Is<ulong>(multiplier => multiplier == expectedMultiplier))).Returns(expectedProduct))
                .Build();

            // Act
            var resultQuantity = quantity.MultiplyWith(expectedMultiplier);

            // Assert
            Assert.AreNotSame(quantity, resultQuantity);
            Assert.AreEqual(quantity.Unit, resultQuantity.Unit);
            Assert.AreEqual(expectedProduct, resultQuantity.Value);

            quantityBuilder.ValueCalculatorMock.Verify(valueCalculator => valueCalculator.Multiply(It.Is<double>(multiplier => multiplier == quantityValue), It.Is<ulong>(multiplier => multiplier == expectedMultiplier)), Times.Once);
        }

        [TestMethod]
        public void WHEN_Multiplying_WHILE_Input_Double_THEN_ReturnNewQuantityWithProduct()
        {
            // Arrange
            var quantityUnit = "TheUnit";
            const double quantityValue = 254.478952;
            const double expectedMultiplier = 5241.5;

            var expectedProduct = 123;

            var quantityBuilder = DoubleValueStringUnitQuantityBuilder.NewInstance();
            var quantity = quantityBuilder
                .WithValue(quantityValue)
                .WithUnit(quantityUnit)
                .MockValueCalculator(mock => mock.Setup(valueCalculator => valueCalculator.Multiply(It.Is<double>(multiplier => multiplier == quantityValue), It.Is<double>(multiplier => multiplier == expectedMultiplier))).Returns(expectedProduct))
                .Build();

            // Act
            var resultQuantity = quantity.MultiplyWith(expectedMultiplier);

            // Assert
            Assert.AreNotSame(quantity, resultQuantity);
            Assert.AreEqual(quantity.Unit, resultQuantity.Unit);
            Assert.AreEqual(expectedProduct, resultQuantity.Value);

            quantityBuilder.ValueCalculatorMock.Verify(valueCalculator => valueCalculator.Multiply(It.Is<double>(multiplier => multiplier == quantityValue), It.Is<double>(multiplier => multiplier == expectedMultiplier)), Times.Once);
        }

        [TestMethod]
        public void WHEN_Multiplying_WHILE_Input_Decimal_THEN_ReturnNewQuantityWithProduct()
        {
            // Arrange
            var quantityUnit = "TheUnit";
            const double quantityValue = 254.478952;
            const decimal expectedMultiplier = 5241.5m;

            var expectedProduct = 123;

            var quantityBuilder = DoubleValueStringUnitQuantityBuilder.NewInstance();
            var quantity = quantityBuilder
                .WithValue(quantityValue)
                .WithUnit(quantityUnit)
                .MockValueCalculator(mock => mock.Setup(valueCalculator => valueCalculator.Multiply(It.Is<double>(multiplier => multiplier == quantityValue), It.Is<decimal>(multiplier => multiplier == expectedMultiplier))).Returns(expectedProduct))
                .Build();

            // Act
            var resultQuantity = quantity.MultiplyWith(expectedMultiplier);

            // Assert
            Assert.AreNotSame(quantity, resultQuantity);
            Assert.AreEqual(quantity.Unit, resultQuantity.Unit);
            Assert.AreEqual(expectedProduct, resultQuantity.Value);

            quantityBuilder.ValueCalculatorMock.Verify(valueCalculator => valueCalculator.Multiply(It.Is<double>(multiplier => multiplier == quantityValue), It.Is<decimal>(multiplier => multiplier == expectedMultiplier)), Times.Once);
        }

        [TestMethod]
        public void WHEN_Multiplying_WHILE_Input_Float_THEN_ReturnNewQuantityWithProduct()
        {
            // Arrange
            var quantityUnit = "TheUnit";
            const double quantityValue = 254.478952;
            const float expectedMultiplier = 5241.5f;

            var expectedProduct = 123;

            var quantityBuilder = DoubleValueStringUnitQuantityBuilder.NewInstance();
            var quantity = quantityBuilder
                .WithValue(quantityValue)
                .WithUnit(quantityUnit)
                .MockValueCalculator(mock => mock.Setup(valueCalculator => valueCalculator.Multiply(It.Is<double>(multiplier => multiplier == quantityValue), It.Is<float>(multiplier => multiplier == expectedMultiplier))).Returns(expectedProduct))
                .Build();

            // Act
            var resultQuantity = quantity.MultiplyWith(expectedMultiplier);

            // Assert
            Assert.AreNotSame(quantity, resultQuantity);
            Assert.AreEqual(quantity.Unit, resultQuantity.Unit);
            Assert.AreEqual(expectedProduct, resultQuantity.Value);

            quantityBuilder.ValueCalculatorMock.Verify(valueCalculator => valueCalculator.Multiply(It.Is<double>(multiplier => multiplier == quantityValue), It.Is<float>(multiplier => multiplier == expectedMultiplier)), Times.Once);
        }
    }
}