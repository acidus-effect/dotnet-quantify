using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Quantify.Test.Assets;
using Quantify.UnitTests.TestQuantities;

namespace Quantify.UnitTests.Quantity
{
    [TestClass]
    public class QuantityDivisionOperatorTests
    {
        [TestMethod]
        public void WHEN_Dividing_Value_WHILE_RightHandSide_Null_THEN_ThrowException()
        {
            // Arrange
            var quantity = DoubleValueStringUnitQuantityBuilder.NewInstance().Build();

            // Act & Assert
            ExceptionHelpers.ExpectArgumentNullException("dividendQuantity", () => { var test = (null as DoubleValueStringUnitQuantity) / (short)42; });
            ExceptionHelpers.ExpectArgumentNullException("dividendQuantity", () => { var test = (null as DoubleValueStringUnitQuantity) / (ushort)42; });
            ExceptionHelpers.ExpectArgumentNullException("dividendQuantity", () => { var test = (null as DoubleValueStringUnitQuantity) / (int)42; });
            ExceptionHelpers.ExpectArgumentNullException("dividendQuantity", () => { var test = (null as DoubleValueStringUnitQuantity) / (uint)42; });
            ExceptionHelpers.ExpectArgumentNullException("dividendQuantity", () => { var test = (null as DoubleValueStringUnitQuantity) / (long)42; });
            ExceptionHelpers.ExpectArgumentNullException("dividendQuantity", () => { var test = (null as DoubleValueStringUnitQuantity) / (ulong)42; });
            ExceptionHelpers.ExpectArgumentNullException("dividendQuantity", () => { var test = (null as DoubleValueStringUnitQuantity) / (double)42; });
            ExceptionHelpers.ExpectArgumentNullException("dividendQuantity", () => { var test = (null as DoubleValueStringUnitQuantity) / (decimal)42; });
            ExceptionHelpers.ExpectArgumentNullException("dividendQuantity", () => { var test = (null as DoubleValueStringUnitQuantity) / (float)42; });
        }

        [TestMethod]
        public void WHEN_Dividing_WHILE_RightHandSide_Short_THEN_DelegateToMethod()
        {
            // Arrange
            const short expectedDivisor = 21;
            var expectedResultQuantity = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock().Object;

            var quantityMock = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock(true);
            quantityMock.Setup(quantity => quantity.DivideBy(It.Is<short>(divisor => divisor == expectedDivisor))).Returns(expectedResultQuantity);

            // Act
            var actualResultQuantity = quantityMock.Object / expectedDivisor;

            // Assert
            quantityMock.Verify(quantity => quantity.DivideBy(It.Is<short>(divisor => divisor == expectedDivisor)), Times.Once);

            Assert.AreSame(expectedResultQuantity, actualResultQuantity);
        }

        [TestMethod]
        public void WHEN_Dividing_WHILE_RightHandSide_UnsignedShort_THEN_DelegateToMethod()
        {
            // Arrange
            const ushort expectedDivisor = 21;
            var expectedResultQuantity = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock().Object;

            var quantityMock = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock(true);
            quantityMock.Setup(quantity => quantity.DivideBy(It.Is<ushort>(divisor => divisor == expectedDivisor))).Returns(expectedResultQuantity);

            // Act
            var actualResultQuantity = quantityMock.Object / expectedDivisor;

            // Assert
            quantityMock.Verify(quantity => quantity.DivideBy(It.Is<ushort>(divisor => divisor == expectedDivisor)), Times.Once);

            Assert.AreSame(expectedResultQuantity, actualResultQuantity);
        }

        [TestMethod]
        public void WHEN_Dividing_WHILE_RightHandSide_Integer_THEN_DelegateToMethod()
        {
            // Arrange
            const int expectedDivisor = 21;
            var expectedResultQuantity = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock().Object;

            var quantityMock = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock(true);
            quantityMock.Setup(quantity => quantity.DivideBy(It.Is<int>(divisor => divisor == expectedDivisor))).Returns(expectedResultQuantity);

            // Act
            var actualResultQuantity = quantityMock.Object / expectedDivisor;

            // Assert
            quantityMock.Verify(quantity => quantity.DivideBy(It.Is<int>(divisor => divisor == expectedDivisor)), Times.Once);

            Assert.AreSame(expectedResultQuantity, actualResultQuantity);
        }

        [TestMethod]
        public void WHEN_Dividing_WHILE_RightHandSide_UnsignedInteger_THEN_DelegateToMethod()
        {
            // Arrange
            const uint expectedDivisor = 21;
            var expectedResultQuantity = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock().Object;

            var quantityMock = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock(true);
            quantityMock.Setup(quantity => quantity.DivideBy(It.Is<uint>(divisor => divisor == expectedDivisor))).Returns(expectedResultQuantity);

            // Act
            var actualResultQuantity = quantityMock.Object / expectedDivisor;

            // Assert
            quantityMock.Verify(quantity => quantity.DivideBy(It.Is<uint>(divisor => divisor == expectedDivisor)), Times.Once);

            Assert.AreSame(expectedResultQuantity, actualResultQuantity);
        }

        [TestMethod]
        public void WHEN_Dividing_WHILE_RightHandSide_Long_THEN_DelegateToMethod()
        {
            // Arrange
            const long expectedDivisor = 21;
            var expectedResultQuantity = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock().Object;

            var quantityMock = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock(true);
            quantityMock.Setup(quantity => quantity.DivideBy(It.Is<long>(divisor => divisor == expectedDivisor))).Returns(expectedResultQuantity);

            // Act
            var actualResultQuantity = quantityMock.Object / expectedDivisor;

            // Assert
            quantityMock.Verify(quantity => quantity.DivideBy(It.Is<long>(divisor => divisor == expectedDivisor)), Times.Once);

            Assert.AreSame(expectedResultQuantity, actualResultQuantity);
        }

        [TestMethod]
        public void WHEN_Dividing_WHILE_RightHandSide_UnsignedLong_THEN_DelegateToMethod()
        {
            // Arrange
            const ulong expectedDivisor = 21;
            var expectedResultQuantity = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock().Object;

            var quantityMock = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock(true);
            quantityMock.Setup(quantity => quantity.DivideBy(It.Is<ulong>(divisor => divisor == expectedDivisor))).Returns(expectedResultQuantity);

            // Act
            var actualResultQuantity = quantityMock.Object / expectedDivisor;

            // Assert
            quantityMock.Verify(quantity => quantity.DivideBy(It.Is<ulong>(divisor => divisor == expectedDivisor)), Times.Once);

            Assert.AreSame(expectedResultQuantity, actualResultQuantity);
        }

        [TestMethod]
        public void WHEN_Dividing_WHILE_RightHandSide_Double_THEN_DelegateToMethod()
        {
            // Arrange
            const double expectedDivisor = 21.587;
            var expectedResultQuantity = StringValueStringUnitQuantityBuilder.NewInstance().BuildMock().Object;

            var quantityMock = StringValueStringUnitQuantityBuilder.NewInstance().BuildMock(true);
            quantityMock.Setup(quantity => quantity.DivideBy(It.Is<double>(divisor => divisor == expectedDivisor))).Returns(expectedResultQuantity);

            // Act
            var actualResultQuantity = quantityMock.Object / expectedDivisor;

            // Assert
            quantityMock.Verify(quantity => quantity.DivideBy(It.Is<double>(divisor => divisor == expectedDivisor)), Times.Once);

            Assert.AreSame(expectedResultQuantity, actualResultQuantity);
        }

        [TestMethod]
        public void WHEN_Dividing_WHILE_RightHandSide_Decimal_THEN_DelegateToMethod()
        {
            // Arrange
            const decimal expectedDivisor = 21.5874m;
            var expectedResultQuantity = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock().Object;

            var quantityMock = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock(true);
            quantityMock.Setup(quantity => quantity.DivideBy(It.Is<decimal>(divisor => divisor == expectedDivisor))).Returns(expectedResultQuantity);

            // Act
            var actualResultQuantity = quantityMock.Object / expectedDivisor;

            // Assert
            quantityMock.Verify(quantity => quantity.DivideBy(It.Is<decimal>(divisor => divisor == expectedDivisor)), Times.Once);

            Assert.AreSame(expectedResultQuantity, actualResultQuantity);
        }

        [TestMethod]
        public void WHEN_Dividing_WHILE_RightHandSide_Float_THEN_DelegateToMethod()
        {
            // Arrange
            const float expectedDivisor = 21.5874f;
            var expectedResultQuantity = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock().Object;

            var quantityMock = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock(true);
            quantityMock.Setup(quantity => quantity.DivideBy(It.Is<float>(divisor => divisor == expectedDivisor))).Returns(expectedResultQuantity);

            // Act
            var actualResultQuantity = quantityMock.Object / expectedDivisor;

            // Assert
            quantityMock.Verify(quantity => quantity.DivideBy(It.Is<float>(divisor => divisor == expectedDivisor)), Times.Once);

            Assert.AreSame(expectedResultQuantity, actualResultQuantity);
        }
    }
}