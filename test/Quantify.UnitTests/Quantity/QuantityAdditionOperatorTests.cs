using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Quantify.Test.Assets;
using Quantify.UnitTests.TestQuantities;

namespace Quantify.UnitTests.Quantity
{
    [TestClass]
    public class QuantityAdditionOperatorTests
    {
        [TestMethod]
        public void WHEN_Adding_Quantity_WHILE_Parameter_Null_THEN_ThrowException()
        {
            // Arrange
            var quantity = DoubleValueStringUnitQuantityBuilder.NewInstance().Build();

            // Act & Assert
            ExceptionHelpers.ExpectArgumentNullException("term2Quantity", () => { var test = quantity + (null as DoubleValueStringUnitQuantity); });
            ExceptionHelpers.ExpectArgumentNullException("term1Quantity", () => { var test = (null as DoubleValueStringUnitQuantity) + quantity; });
            ExceptionHelpers.ExpectArgumentNullException("term1Quantity", () => { var test = (null as DoubleValueStringUnitQuantity) + (null as DoubleValueStringUnitQuantity); });
        }

        [TestMethod]
        public void WHEN_Adding_Value_WHILE_RightHandSide_Null_THEN_ThrowException()
        {
            // Arrange
            var quantity = DoubleValueStringUnitQuantityBuilder.NewInstance().Build();

            // Act & Assert
            ExceptionHelpers.ExpectArgumentNullException("termQuantity", () => { var test = (null as DoubleValueStringUnitQuantity) + (short)42; });
            ExceptionHelpers.ExpectArgumentNullException("termQuantity", () => { var test = (null as DoubleValueStringUnitQuantity) + (ushort)42; });
            ExceptionHelpers.ExpectArgumentNullException("termQuantity", () => { var test = (null as DoubleValueStringUnitQuantity) + (int)42; });
            ExceptionHelpers.ExpectArgumentNullException("termQuantity", () => { var test = (null as DoubleValueStringUnitQuantity) + (uint)42; });
            ExceptionHelpers.ExpectArgumentNullException("termQuantity", () => { var test = (null as DoubleValueStringUnitQuantity) + (long)42; });
            ExceptionHelpers.ExpectArgumentNullException("termQuantity", () => { var test = (null as DoubleValueStringUnitQuantity) + (ulong)42; });
            ExceptionHelpers.ExpectArgumentNullException("termQuantity", () => { var test = (null as DoubleValueStringUnitQuantity) + (double)42; });
            ExceptionHelpers.ExpectArgumentNullException("termQuantity", () => { var test = (null as DoubleValueStringUnitQuantity) + (decimal)42; });
            ExceptionHelpers.ExpectArgumentNullException("termQuantity", () => { var test = (null as DoubleValueStringUnitQuantity) + (float)42; });
        }

        [TestMethod]
        public void WHEN_Adding_WHILE_RightHandSide_Short_THEN_DelegateToMethod()
        {
            // Arrange
            const short valueToAdd = 21;
            var expectedResultQuantity = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock().Object;

            var quantityMock = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock(true);
            quantityMock.Setup(quantity => quantity.Add(It.Is<short>(value => value == valueToAdd))).Returns(expectedResultQuantity);

            // Act
            var actualResultQuantity = quantityMock.Object + valueToAdd;

            // Assert
            quantityMock.Verify(quantity => quantity.Add(It.Is<short>(value => value == valueToAdd)), Times.Once);

            Assert.AreSame(expectedResultQuantity, actualResultQuantity);
        }

        [TestMethod]
        public void WHEN_Adding_WHILE_RightHandSide_UnsignedShort_THEN_DelegateToMethod()
        {
            // Arrange
            const ushort valueToAdd = 21;
            var expectedResultQuantity = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock().Object;

            var quantityMock = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock(true);
            quantityMock.Setup(quantity => quantity.Add(It.Is<ushort>(value => value == valueToAdd))).Returns(expectedResultQuantity);

            // Act
            var actualResultQuantity = quantityMock.Object + valueToAdd;

            // Assert
            quantityMock.Verify(quantity => quantity.Add(It.Is<ushort>(value => value == valueToAdd)), Times.Once);

            Assert.AreSame(expectedResultQuantity, actualResultQuantity);
        }

        [TestMethod]
        public void WHEN_Adding_WHILE_RightHandSide_Integer_THEN_DelegateToMethod()
        {
            // Arrange
            const int valueToAdd = 21;
            var expectedResultQuantity = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock().Object;

            var quantityMock = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock(true);
            quantityMock.Setup(quantity => quantity.Add(It.Is<int>(value => value == valueToAdd))).Returns(expectedResultQuantity);

            // Act
            var actualResultQuantity = quantityMock.Object + valueToAdd;

            // Assert
            quantityMock.Verify(quantity => quantity.Add(It.Is<int>(value => value == valueToAdd)), Times.Once);

            Assert.AreSame(expectedResultQuantity, actualResultQuantity);
        }

        [TestMethod]
        public void WHEN_Adding_WHILE_RightHandSide_UnsignedInteger_THEN_DelegateToMethod()
        {
            // Arrange
            const uint valueToAdd = 21;
            var expectedResultQuantity = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock().Object;

            var quantityMock = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock(true);
            quantityMock.Setup(quantity => quantity.Add(It.Is<uint>(value => value == valueToAdd))).Returns(expectedResultQuantity);

            // Act
            var actualResultQuantity = quantityMock.Object + valueToAdd;

            // Assert
            quantityMock.Verify(quantity => quantity.Add(It.Is<uint>(value => value == valueToAdd)), Times.Once);

            Assert.AreSame(expectedResultQuantity, actualResultQuantity);
        }

        [TestMethod]
        public void WHEN_Adding_WHILE_RightHandSide_Long_THEN_DelegateToMethod()
        {
            // Arrange
            const long valueToAdd = 21;
            var expectedResultQuantity = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock().Object;

            var quantityMock = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock(true);
            quantityMock.Setup(quantity => quantity.Add(It.Is<long>(value => value == valueToAdd))).Returns(expectedResultQuantity);

            // Act
            var actualResultQuantity = quantityMock.Object + valueToAdd;

            // Assert
            quantityMock.Verify(quantity => quantity.Add(It.Is<long>(value => value == valueToAdd)), Times.Once);

            Assert.AreSame(expectedResultQuantity, actualResultQuantity);
        }

        [TestMethod]
        public void WHEN_Adding_WHILE_RightHandSide_UnsignedLong_THEN_DelegateToMethod()
        {
            // Arrange
            const ulong valueToAdd = 21;
            var expectedResultQuantity = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock().Object;

            var quantityMock = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock(true);
            quantityMock.Setup(quantity => quantity.Add(It.Is<ulong>(value => value == valueToAdd))).Returns(expectedResultQuantity);

            // Act
            var actualResultQuantity = quantityMock.Object + valueToAdd;

            // Assert
            quantityMock.Verify(quantity => quantity.Add(It.Is<ulong>(value => value == valueToAdd)), Times.Once);

            Assert.AreSame(expectedResultQuantity, actualResultQuantity);
        }

        [TestMethod]
        public void WHEN_Adding_WHILE_RightHandSide_Quantity_THEN_DelegateToMethod()
        {
            // Arrange
            var expectedResultQuantity = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock().Object;

            var quantityRhsMock = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock();

            var quantityLhsMock = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock(true);
            quantityLhsMock.Setup(quantity => quantity.Add(It.Is<DoubleValueStringUnitQuantity>(value => ReferenceEquals(value, quantityRhsMock.Object)))).Returns(expectedResultQuantity);

            // Act
            var actualResultQuantity = quantityLhsMock.Object + quantityRhsMock.Object;

            // Assert
            quantityLhsMock.Verify(quantity => quantity.Add(It.Is<DoubleValueStringUnitQuantity>(value => ReferenceEquals(value, quantityRhsMock.Object))), Times.Once);

            Assert.AreSame(expectedResultQuantity, actualResultQuantity);
        }

        [TestMethod]
        public void WHEN_Adding_WHILE_RightHandSide_Double_THEN_DelegateToMethod()
        {
            // Arrange
            const double valueToAdd = 21.587;
            var expectedResultQuantity = StringValueStringUnitQuantityBuilder.NewInstance().BuildMock().Object;

            var quantityMock = StringValueStringUnitQuantityBuilder.NewInstance().BuildMock(true);
            quantityMock.Setup(quantity => quantity.Add(It.Is<double>(value => value == valueToAdd))).Returns(expectedResultQuantity);

            // Act
            var actualResultQuantity = quantityMock.Object + valueToAdd;

            // Assert
            quantityMock.Verify(quantity => quantity.Add(It.Is<double>(value => value == valueToAdd)), Times.Once);

            Assert.AreSame(expectedResultQuantity, actualResultQuantity);
        }

        [TestMethod]
        public void WHEN_Adding_WHILE_RightHandSide_Decimal_THEN_DelegateToMethod()
        {
            // Arrange
            const decimal valueToAdd = 21.5874m;
            var expectedResultQuantity = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock().Object;

            var quantityMock = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock(true);
            quantityMock.Setup(quantity => quantity.Add(It.Is<decimal>(value => value == valueToAdd))).Returns(expectedResultQuantity);

            // Act
            var actualResultQuantity = quantityMock.Object + valueToAdd;

            // Assert
            quantityMock.Verify(quantity => quantity.Add(It.Is<decimal>(value => value == valueToAdd)), Times.Once);

            Assert.AreSame(expectedResultQuantity, actualResultQuantity);
        }

        [TestMethod]
        public void WHEN_Adding_WHILE_RightHandSide_Float_THEN_DelegateToMethod()
        {
            // Arrange
            const float valueToAdd = 21.5874f;
            var expectedResultQuantity = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock().Object;

            var quantityMock = DoubleValueStringUnitQuantityBuilder.NewInstance().BuildMock(true);
            quantityMock.Setup(quantity => quantity.Add(It.Is<float>(value => value == valueToAdd))).Returns(expectedResultQuantity);

            // Act
            var actualResultQuantity = quantityMock.Object + valueToAdd;

            // Assert
            quantityMock.Verify(quantity => quantity.Add(It.Is<float>(value => value == valueToAdd)), Times.Once);

            Assert.AreSame(expectedResultQuantity, actualResultQuantity);
        }
    }
}