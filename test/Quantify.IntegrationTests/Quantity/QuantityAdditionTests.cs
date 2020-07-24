using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quantify.IntegrationTests.Quantity.Assets;
using Quantify.Test.Assets;

namespace Quantify.IntegrationTests.Quantity
{
    [TestClass]
    public class QuantityAdditionTests
    {
        [TestMethod]
        public void WHILE_BothQuantitiesArePositive_WHEN_Adding_QuantityToQuantity_THEN_ReturnSum()
        {
            // Arrange
            var quantity1 = TestQuantity.Create(22, TestData.Decimetre);
            var quantity2 = TestQuantity.Create(12, TestData.Metre);

            var expectedQuantity = TestQuantity.Create(142, TestData.Decimetre);

            // Act
            var actualQuantity = quantity1.Add(quantity2);

            // Assert
            Assert.AreEqual(expectedQuantity, actualQuantity);
        }

        [TestMethod]
        public void WHILE_BothQuantitiesAreNegative_WHEN_Adding_QuantityToQuantity_THEN_ReturnSum()
        {
            // Arrange
            var quantity1 = TestQuantity.Create(-52, TestData.Millimetre);
            var quantity2 = TestQuantity.Create(-523, TestData.Centimetre);

            var expectedQuantity = TestQuantity.Create(-5282, TestData.Millimetre);

            // Act
            var actualQuantity = quantity1.Add(quantity2);

            // Assert
            Assert.AreEqual(expectedQuantity, actualQuantity);
        }

        [TestMethod]
        public void WHILE_FirstQuantityIsPositive_SecondQuantityIsNegative_WHEN_Adding_QuantityToQuantity_THEN_ReturnSum()
        {
            // Arrange
            var quantity1 = TestQuantity.Create(84, TestData.Kilometre);
            var quantity2 = TestQuantity.Create(-852, TestData.Metre);

            var expectedQuantity = TestQuantity.Create(83.148, TestData.Kilometre);

            // Act
            var actualQuantity = quantity1.Add(quantity2);

            // Assert
            Assert.AreEqual(expectedQuantity, actualQuantity);
        }

        [TestMethod]
        public void WHILE_FirstQuantityIsNegative_SecondQuantityIsPositive_WHEN_Adding_QuantityToQuantity_THEN_ReturnSum()
        {
            // Arrange
            var quantity1 = TestQuantity.Create(-36, TestData.Metre);
            var quantity2 = TestQuantity.Create(3700, TestData.Centimetre);

            var expectedQuantity = TestQuantity.Create(1, TestData.Metre);

            // Act
            var actualQuantity = quantity1.Add(quantity2);

            // Assert
            Assert.AreEqual(expectedQuantity, actualQuantity);
        }

        [TestMethod]
        public void WHILE_ArgumentIsNull_WHEN_Adding_QuantityToQuantity_THEN_ThrowException()
        {
            // Arrange
            var quantity = TestQuantity.Create(22, TestData.Decimetre);

            // Act & Assert
            ExceptionHelpers.ExpectArgumentNullException("quantity", () => quantity.Add(null));
        }
    }
}