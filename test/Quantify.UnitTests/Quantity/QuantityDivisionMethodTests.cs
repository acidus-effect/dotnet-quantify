using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Quantify.Test.Assets;
using Quantify.UnitTests.TestQuantities;

namespace Quantify.UnitTests.Quantity
{
    [TestClass]
    public class QuantityDivisionMethodTests
    {
        [TestMethod]
        public void WHEN_Dividing_Value_WHILE_Value_Null_THEN_ThrowException()
        {
            // Arrange
            var quantity = StringValueStringUnitQuantityBuilder.NewInstance().Build();

            // Act & Assert
            ExceptionHelpers.ExpectArgumentNullException("divisor", () => quantity.DivideBy(null as string));
        }

        [TestMethod]
        public void WHEN_Dividing_WHILE_Input_Short_THEN_ReturnNewQuantityWithSum()
        {
            // Arrange
            var quantityUnit = "TheUnit";
            const double quantityValue = 42.548;
            const short expectedDivisor = 1337;

            var expectedQuotient = 4242.547;

            var quantityBuilder = DoubleValueStringUnitQuantityBuilder.NewInstance();
            var quantity = quantityBuilder
                .WithValue(quantityValue)
                .WithUnit(quantityUnit)
                .MockValueCalculator(mock => mock.Setup(valueCalculator => valueCalculator.Divide(It.Is<double>(divisor => divisor == quantityValue), It.Is<short>(divisor => divisor == expectedDivisor))).Returns(expectedQuotient))
                .Build();

            // Act
            var resultQuantity = quantity.DivideBy(expectedDivisor);

            // Assert
            Assert.AreNotSame(quantity, resultQuantity);
            Assert.AreEqual(quantity.Unit, resultQuantity.Unit);
            Assert.AreEqual(expectedQuotient, resultQuantity.Value);

            quantityBuilder.ValueCalculatorMock.Verify(valueCalculator => valueCalculator.Divide(It.Is<double>(divisor => divisor == quantityValue), It.Is<short>(divisor => divisor == expectedDivisor)), Times.Once);
        }

        [TestMethod]
        public void WHEN_Dividing_WHILE_Input_UnsignedShort_THEN_ReturnNewQuantityWithSum()
        {
            // Arrange
            var quantityUnit = "TheUnit";
            const double quantityValue = 42.548;
            const ushort expectedDivisor = 1337;

            var expectedQuotient = 4242.547;

            var quantityBuilder = DoubleValueStringUnitQuantityBuilder.NewInstance();
            var quantity = quantityBuilder
                .WithValue(quantityValue)
                .WithUnit(quantityUnit)
                .MockValueCalculator(mock => mock.Setup(valueCalculator => valueCalculator.Divide(It.Is<double>(divisor => divisor == quantityValue), It.Is<ushort>(divisor => divisor == expectedDivisor))).Returns(expectedQuotient))
                .Build();

            // Act
            var resultQuantity = quantity.DivideBy(expectedDivisor);

            // Assert
            Assert.AreNotSame(quantity, resultQuantity);
            Assert.AreEqual(quantity.Unit, resultQuantity.Unit);
            Assert.AreEqual(expectedQuotient, resultQuantity.Value);

            quantityBuilder.ValueCalculatorMock.Verify(valueCalculator => valueCalculator.Divide(It.Is<double>(divisor => divisor == quantityValue), It.Is<ushort>(divisor => divisor == expectedDivisor)), Times.Once);
        }

        [TestMethod]
        public void WHEN_Dividing_WHILE_Input_Integer_THEN_ReturnNewQuantityWithSum()
        {
            // Arrange
            var quantityUnit = "TheUnit";
            const double quantityValue = 42.547;
            const int expectedDivisor = 1337;

            var expectedQuotient = 4242.547;

            var quantityBuilder = DoubleValueStringUnitQuantityBuilder.NewInstance();
            var quantity = quantityBuilder
                .WithValue(quantityValue)
                .WithUnit(quantityUnit)
                .MockValueCalculator(mock => mock.Setup(valueCalculator => valueCalculator.Divide(It.Is<double>(divisor => divisor == quantityValue), It.Is<int>(divisor => divisor == expectedDivisor))).Returns(expectedQuotient))
                .Build();

            // Act
            var resultQuantity = quantity.DivideBy(expectedDivisor);

            // Assert
            Assert.AreNotSame(quantity, resultQuantity);
            Assert.AreEqual(quantity.Unit, resultQuantity.Unit);
            Assert.AreEqual(expectedQuotient, resultQuantity.Value);

            quantityBuilder.ValueCalculatorMock.Verify(valueCalculator => valueCalculator.Divide(It.Is<double>(divisor => divisor == quantityValue), It.Is<int>(divisor => divisor == expectedDivisor)), Times.Once);
        }

        [TestMethod]
        public void WHEN_Dividing_WHILE_Input_UnsignedInteger_THEN_ReturnNewQuantityWithSum()
        {
            // Arrange
            var quantityUnit = "TheUnit";
            const double quantityValue = 42.547;
            const uint expectedDivisor = 1337;

            var expectedQuotient = 4242.547;

            var quantityBuilder = DoubleValueStringUnitQuantityBuilder.NewInstance();
            var quantity = quantityBuilder
                .WithValue(quantityValue)
                .WithUnit(quantityUnit)
                .MockValueCalculator(mock => mock.Setup(valueCalculator => valueCalculator.Divide(It.Is<double>(divisor => divisor == quantityValue), It.Is<uint>(divisor => divisor == expectedDivisor))).Returns(expectedQuotient))
                .Build();

            // Act
            var resultQuantity = quantity.DivideBy(expectedDivisor);

            // Assert
            Assert.AreNotSame(quantity, resultQuantity);
            Assert.AreEqual(quantity.Unit, resultQuantity.Unit);
            Assert.AreEqual(expectedQuotient, resultQuantity.Value);

            quantityBuilder.ValueCalculatorMock.Verify(valueCalculator => valueCalculator.Divide(It.Is<double>(divisor => divisor == quantityValue), It.Is<uint>(divisor => divisor == expectedDivisor)), Times.Once);
        }

        [TestMethod]
        public void WHEN_Dividing_WHILE_Input_Long_THEN_ReturnNewQuantityWithSum()
        {
            // Arrange
            var quantityUnit = "TheUnit";
            const double quantityValue = 42.547;
            const long expectedDivisor = 1337;

            var expectedQuotient = 4242.547;

            var quantityBuilder = DoubleValueStringUnitQuantityBuilder.NewInstance();
            var quantity = quantityBuilder
                .WithValue(quantityValue)
                .WithUnit(quantityUnit)
                .MockValueCalculator(mock => mock.Setup(valueCalculator => valueCalculator.Divide(It.Is<double>(divisor => divisor == quantityValue), It.Is<long>(divisor => divisor == expectedDivisor))).Returns(expectedQuotient))
                .Build();

            // Act
            var resultQuantity = quantity.DivideBy(expectedDivisor);

            // Assert
            Assert.AreNotSame(quantity, resultQuantity);
            Assert.AreEqual(quantity.Unit, resultQuantity.Unit);
            Assert.AreEqual(expectedQuotient, resultQuantity.Value);

            quantityBuilder.ValueCalculatorMock.Verify(valueCalculator => valueCalculator.Divide(It.Is<double>(divisor => divisor == quantityValue), It.Is<long>(divisor => divisor == expectedDivisor)), Times.Once);
        }

        [TestMethod]
        public void WHEN_Dividing_WHILE_Input_UnsignedLong_THEN_ReturnNewQuantityWithSum()
        {
            // Arrange
            var quantityUnit = "TheUnit";
            const double quantityValue = 42.547;
            const ulong expectedDivisor = 1337;

            var expectedQuotient = 4242.547;

            var quantityBuilder = DoubleValueStringUnitQuantityBuilder.NewInstance();
            var quantity = quantityBuilder
                .WithValue(quantityValue)
                .WithUnit(quantityUnit)
                .MockValueCalculator(mock => mock.Setup(valueCalculator => valueCalculator.Divide(It.Is<double>(divisor => divisor == quantityValue), It.Is<ulong>(divisor => divisor == expectedDivisor))).Returns(expectedQuotient))
                .Build();

            // Act
            var resultQuantity = quantity.DivideBy(expectedDivisor);

            // Assert
            Assert.AreNotSame(quantity, resultQuantity);
            Assert.AreEqual(quantity.Unit, resultQuantity.Unit);
            Assert.AreEqual(expectedQuotient, resultQuantity.Value);

            quantityBuilder.ValueCalculatorMock.Verify(valueCalculator => valueCalculator.Divide(It.Is<double>(divisor => divisor == quantityValue), It.Is<ulong>(divisor => divisor == expectedDivisor)), Times.Once);
        }

        [TestMethod]
        public void WHEN_Dividing_WHILE_Input_Double_THEN_ReturnNewQuantityWithSum()
        {
            // Arrange
            var quantityUnit = "TheUnit";
            const double quantityValue = 254.478952;
            const double expectedDivisor = 5241.5;

            var expectedQuotient = 123;

            var quantityBuilder = DoubleValueStringUnitQuantityBuilder.NewInstance();
            var quantity = quantityBuilder
                .WithValue(quantityValue)
                .WithUnit(quantityUnit)
                .MockValueCalculator(mock => mock.Setup(valueCalculator => valueCalculator.Divide(It.Is<double>(divisor => divisor == quantityValue), It.Is<double>(divisor => divisor == expectedDivisor))).Returns(expectedQuotient))
                .Build();

            // Act
            var resultQuantity = quantity.DivideBy(expectedDivisor);

            // Assert
            Assert.AreNotSame(quantity, resultQuantity);
            Assert.AreEqual(quantity.Unit, resultQuantity.Unit);
            Assert.AreEqual(expectedQuotient, resultQuantity.Value);

            quantityBuilder.ValueCalculatorMock.Verify(valueCalculator => valueCalculator.Divide(It.Is<double>(divisor => divisor == quantityValue), It.Is<double>(divisor => divisor == expectedDivisor)), Times.Once);
        }

        [TestMethod]
        public void WHEN_Dividing_WHILE_Input_Decimal_THEN_ReturnNewQuantityWithSum()
        {
            // Arrange
            var quantityUnit = "TheUnit";
            const double quantityValue = 254.478952;
            const decimal expectedDivisor = 5241.5m;

            var expectedQuotient = 123;

            var quantityBuilder = DoubleValueStringUnitQuantityBuilder.NewInstance();
            var quantity = quantityBuilder
                .WithValue(quantityValue)
                .WithUnit(quantityUnit)
                .MockValueCalculator(mock => mock.Setup(valueCalculator => valueCalculator.Divide(It.Is<double>(divisor => divisor == quantityValue), It.Is<decimal>(divisor => divisor == expectedDivisor))).Returns(expectedQuotient))
                .Build();

            // Act
            var resultQuantity = quantity.DivideBy(expectedDivisor);

            // Assert
            Assert.AreNotSame(quantity, resultQuantity);
            Assert.AreEqual(quantity.Unit, resultQuantity.Unit);
            Assert.AreEqual(expectedQuotient, resultQuantity.Value);

            quantityBuilder.ValueCalculatorMock.Verify(valueCalculator => valueCalculator.Divide(It.Is<double>(divisor => divisor == quantityValue), It.Is<decimal>(divisor => divisor == expectedDivisor)), Times.Once);
        }

        [TestMethod]
        public void WHEN_Dividing_WHILE_Input_Float_THEN_ReturnNewQuantityWithSum()
        {
            // Arrange
            var quantityUnit = "TheUnit";
            const double quantityValue = 254.478952;
            const float expectedDivisor = 5241.5f;

            var expectedQuotient = 123;

            var quantityBuilder = DoubleValueStringUnitQuantityBuilder.NewInstance();
            var quantity = quantityBuilder
                .WithValue(quantityValue)
                .WithUnit(quantityUnit)
                .MockValueCalculator(mock => mock.Setup(valueCalculator => valueCalculator.Divide(It.Is<double>(divisor => divisor == quantityValue), It.Is<float>(divisor => divisor == expectedDivisor))).Returns(expectedQuotient))
                .Build();

            // Act
            var resultQuantity = quantity.DivideBy(expectedDivisor);

            // Assert
            Assert.AreNotSame(quantity, resultQuantity);
            Assert.AreEqual(quantity.Unit, resultQuantity.Unit);
            Assert.AreEqual(expectedQuotient, resultQuantity.Value);

            quantityBuilder.ValueCalculatorMock.Verify(valueCalculator => valueCalculator.Divide(It.Is<double>(divisor => divisor == quantityValue), It.Is<float>(divisor => divisor == expectedDivisor)), Times.Once);
        }
    }
}