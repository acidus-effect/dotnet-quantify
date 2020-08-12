using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Quantify.Test.Assets;
using Quantify.UnitTests.TestQuantities;

namespace Quantify.UnitTests.Quantity
{
    [TestClass]
    public class QuantityMultiplicationOperatorTests
    {
        [TestMethod]
        public void WHEN_Multiplying_Value_WHILE_RightHandSide_Null_THEN_ThrowException()
        {
            // Arrange
            var quantity = DoubleValueStringUnitQuantityBuilder.NewInstance().Build();

            // Act & Assert
            ExceptionHelpers.ExpectArgumentNullException("multiplicandQuantity", () => { var test = (null as DoubleValueStringUnitQuantity) * (short)42; });
            ExceptionHelpers.ExpectArgumentNullException("multiplicandQuantity", () => { var test = (null as DoubleValueStringUnitQuantity) * (ushort)42; });
            ExceptionHelpers.ExpectArgumentNullException("multiplicandQuantity", () => { var test = (null as DoubleValueStringUnitQuantity) * (int)42; });
            ExceptionHelpers.ExpectArgumentNullException("multiplicandQuantity", () => { var test = (null as DoubleValueStringUnitQuantity) * (uint)42; });
            ExceptionHelpers.ExpectArgumentNullException("multiplicandQuantity", () => { var test = (null as DoubleValueStringUnitQuantity) * (long)42; });
            ExceptionHelpers.ExpectArgumentNullException("multiplicandQuantity", () => { var test = (null as DoubleValueStringUnitQuantity) * (ulong)42; });
            ExceptionHelpers.ExpectArgumentNullException("multiplicandQuantity", () => { var test = (null as DoubleValueStringUnitQuantity) * (double)42; });
            ExceptionHelpers.ExpectArgumentNullException("multiplicandQuantity", () => { var test = (null as DoubleValueStringUnitQuantity) * (decimal)42; });
            ExceptionHelpers.ExpectArgumentNullException("multiplicandQuantity", () => { var test = (null as DoubleValueStringUnitQuantity) * (float)42; });
        }

        [TestMethod]
        public void WHEN_Multiplying_WHILE_RightHandSide_Short_THEN_DelegateToMethod()
        {
            // Arrange
            const short expectedMultiplier = 21;
            var expectedResultQuantity = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock().Object;

            var quantityMock = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock(true);
            quantityMock.Setup(quantity => quantity.MultiplyWith(It.Is<short>(multiplier => multiplier == expectedMultiplier))).Returns(expectedResultQuantity);

            // Act
            var actualResultQuantity = quantityMock.Object * expectedMultiplier;

            // Assert
            quantityMock.Verify(quantity => quantity.MultiplyWith(It.Is<short>(multiplier => multiplier == expectedMultiplier)), Times.Once);

            Assert.AreSame(expectedResultQuantity, actualResultQuantity);
        }

        [TestMethod]
        public void WHEN_Multiplying_WHILE_RightHandSide_UnsignedShort_THEN_DelegateToMethod()
        {
            // Arrange
            const ushort expectedMultiplier = 21;
            var expectedResultQuantity = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock().Object;

            var quantityMock = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock(true);
            quantityMock.Setup(quantity => quantity.MultiplyWith(It.Is<ushort>(multiplier => multiplier == expectedMultiplier))).Returns(expectedResultQuantity);

            // Act
            var actualResultQuantity = quantityMock.Object * expectedMultiplier;

            // Assert
            quantityMock.Verify(quantity => quantity.MultiplyWith(It.Is<ushort>(multiplier => multiplier == expectedMultiplier)), Times.Once);

            Assert.AreSame(expectedResultQuantity, actualResultQuantity);
        }

        [TestMethod]
        public void WHEN_Multiplying_WHILE_RightHandSide_Integer_THEN_DelegateToMethod()
        {
            // Arrange
            const int expectedMultiplier = 21;
            var expectedResultQuantity = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock().Object;

            var quantityMock = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock(true);
            quantityMock.Setup(quantity => quantity.MultiplyWith(It.Is<int>(multiplier => multiplier == expectedMultiplier))).Returns(expectedResultQuantity);

            // Act
            var actualResultQuantity = quantityMock.Object * expectedMultiplier;

            // Assert
            quantityMock.Verify(quantity => quantity.MultiplyWith(It.Is<int>(multiplier => multiplier == expectedMultiplier)), Times.Once);

            Assert.AreSame(expectedResultQuantity, actualResultQuantity);
        }

        [TestMethod]
        public void WHEN_Multiplying_WHILE_RightHandSide_UnsignedInteger_THEN_DelegateToMethod()
        {
            // Arrange
            const uint expectedMultiplier = 21;
            var expectedResultQuantity = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock().Object;

            var quantityMock = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock(true);
            quantityMock.Setup(quantity => quantity.MultiplyWith(It.Is<uint>(multiplier => multiplier == expectedMultiplier))).Returns(expectedResultQuantity);

            // Act
            var actualResultQuantity = quantityMock.Object * expectedMultiplier;

            // Assert
            quantityMock.Verify(quantity => quantity.MultiplyWith(It.Is<uint>(multiplier => multiplier == expectedMultiplier)), Times.Once);

            Assert.AreSame(expectedResultQuantity, actualResultQuantity);
        }

        [TestMethod]
        public void WHEN_Multiplying_WHILE_RightHandSide_Long_THEN_DelegateToMethod()
        {
            // Arrange
            const long expectedMultiplier = 21;
            var expectedResultQuantity = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock().Object;

            var quantityMock = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock(true);
            quantityMock.Setup(quantity => quantity.MultiplyWith(It.Is<long>(multiplier => multiplier == expectedMultiplier))).Returns(expectedResultQuantity);

            // Act
            var actualResultQuantity = quantityMock.Object * expectedMultiplier;

            // Assert
            quantityMock.Verify(quantity => quantity.MultiplyWith(It.Is<long>(multiplier => multiplier == expectedMultiplier)), Times.Once);

            Assert.AreSame(expectedResultQuantity, actualResultQuantity);
        }

        [TestMethod]
        public void WHEN_Multiplying_WHILE_RightHandSide_UnsignedLong_THEN_DelegateToMethod()
        {
            // Arrange
            const ulong expectedMultiplier = 21;
            var expectedResultQuantity = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock().Object;

            var quantityMock = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock(true);
            quantityMock.Setup(quantity => quantity.MultiplyWith(It.Is<ulong>(multiplier => multiplier == expectedMultiplier))).Returns(expectedResultQuantity);

            // Act
            var actualResultQuantity = quantityMock.Object * expectedMultiplier;

            // Assert
            quantityMock.Verify(quantity => quantity.MultiplyWith(It.Is<ulong>(multiplier => multiplier == expectedMultiplier)), Times.Once);

            Assert.AreSame(expectedResultQuantity, actualResultQuantity);
        }

        [TestMethod]
        public void WHEN_Multiplying_WHILE_RightHandSide_Double_THEN_DelegateToMethod()
        {
            // Arrange
            const double expectedMultiplier = 21.587;
            var expectedResultQuantity = StringValueStringUnitQuantityBuilder.NewInstance().BuildMock().Object;

            var quantityMock = StringValueStringUnitQuantityBuilder.NewInstance().BuildMock(true);
            quantityMock.Setup(quantity => quantity.MultiplyWith(It.Is<double>(multiplier => multiplier == expectedMultiplier))).Returns(expectedResultQuantity);

            // Act
            var actualResultQuantity = quantityMock.Object * expectedMultiplier;

            // Assert
            quantityMock.Verify(quantity => quantity.MultiplyWith(It.Is<double>(multiplier => multiplier == expectedMultiplier)), Times.Once);

            Assert.AreSame(expectedResultQuantity, actualResultQuantity);
        }

        [TestMethod]
        public void WHEN_Multiplying_WHILE_RightHandSide_Decimal_THEN_DelegateToMethod()
        {
            // Arrange
            const decimal expectedMultiplier = 21.5874m;
            var expectedResultQuantity = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock().Object;

            var quantityMock = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock(true);
            quantityMock.Setup(quantity => quantity.MultiplyWith(It.Is<decimal>(multiplier => multiplier == expectedMultiplier))).Returns(expectedResultQuantity);

            // Act
            var actualResultQuantity = quantityMock.Object * expectedMultiplier;

            // Assert
            quantityMock.Verify(quantity => quantity.MultiplyWith(It.Is<decimal>(multiplier => multiplier == expectedMultiplier)), Times.Once);

            Assert.AreSame(expectedResultQuantity, actualResultQuantity);
        }

        [TestMethod]
        public void WHEN_Multiplying_WHILE_RightHandSide_Float_THEN_DelegateToMethod()
        {
            // Arrange
            const float expectedMultiplier = 21.5874f;
            var expectedResultQuantity = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock().Object;

            var quantityMock = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock(true);
            quantityMock.Setup(quantity => quantity.MultiplyWith(It.Is<float>(multiplier => multiplier == expectedMultiplier))).Returns(expectedResultQuantity);

            // Act
            var actualResultQuantity = quantityMock.Object * expectedMultiplier;

            // Assert
            quantityMock.Verify(quantity => quantity.MultiplyWith(It.Is<float>(multiplier => multiplier == expectedMultiplier)), Times.Once);

            Assert.AreSame(expectedResultQuantity, actualResultQuantity);
        }
    }
}