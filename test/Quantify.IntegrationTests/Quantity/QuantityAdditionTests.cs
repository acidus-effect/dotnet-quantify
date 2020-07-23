using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quantify.IntegrationTest.Quantity.Assets;
using Quantify.UnitTest.Shared;
using System;

namespace Quantify.IntegrationTest.Quantity
{
    [TestClass]
    public class QuantityAdditionTests
    {
        [TestMethod]
        public void WHEN_Adding_QuantityToQuantity_GIVEN_BothQuantitiesPositive_THEN_ReturnSum()
        {
            // Arrange
            var quantity1 = EnumTestQuantity.Create(22, TestUnit.Decimetre);
            var quantity2 = EnumTestQuantity.Create(12, TestUnit.Metre);

            var expectedQuantity = EnumTestQuantity.Create(142, TestUnit.Decimetre);

            // Act
            var actualQuantity = quantity1.Add(quantity2);

            // Assert
            Assert.AreEqual(expectedQuantity, actualQuantity);
        }

        [TestMethod]
        public void WHEN_Adding_QuantityToQuantity_GIVEN_BothQuantitiesNegative_THEN_ReturnSum()
        {
            // Arrange
            var quantity1 = EnumTestQuantity.Create(-52, TestUnit.Millimetre);
            var quantity2 = EnumTestQuantity.Create(-523, TestUnit.Centimetre);

            var expectedQuantity = EnumTestQuantity.Create(-5282, TestUnit.Millimetre);

            // Act
            var actualQuantity = quantity1.Add(quantity2);

            // Assert
            Assert.AreEqual(expectedQuantity, actualQuantity);
        }

        [TestMethod]
        public void WHEN_Adding_QuantityToQuantity_GIVEN_PositiveAndNegativeQuntity_THEN_ReturnSum()
        {
            // Arrange
            var quantity1 = EnumTestQuantity.Create(84, TestUnit.Kilometre);
            var quantity2 = EnumTestQuantity.Create(-852, TestUnit.Metre);

            var expectedQuantity = EnumTestQuantity.Create(83.148, TestUnit.Kilometre);

            // Act
            var actualQuantity = quantity1.Add(quantity2);

            // Assert
            Assert.AreEqual(expectedQuantity, actualQuantity);
        }

        [TestMethod]
        public void WHEN_Adding_QuantityToQuantity_GIVEN_NegativeAndPositiveQuntity_THEN_ReturnSum()
        {
            // Arrange
            var quantity1 = EnumTestQuantity.Create(-36, TestUnit.Metre);
            var quantity2 = EnumTestQuantity.Create(3700, TestUnit.Centimetre);

            var expectedQuantity = EnumTestQuantity.Create(1, TestUnit.Metre);

            // Act
            var actualQuantity = quantity1.Add(quantity2);

            // Assert
            Assert.AreEqual(expectedQuantity, actualQuantity);
        }

        [TestMethod]
        public void WHEN_Adding_QuantityToQuantity_GIVEN_Null_THEN_ThrowArgumentNullException()
        {
            // Arrange
            var quantity1 = EnumTestQuantity.Create(22, TestUnit.Decimetre);
            EnumTestQuantity quantity2 = null;

            try
            {
                // Act
                var actualQuantity = quantity1.Add(quantity2);

                //Assert
                Assert.IsTrue(false, $"Expected exception of type '{typeof(ArgumentNullException).FullName}' to be thrown.");
            }
            catch (ArgumentNullException exception)
            {
                //Assert
                Assert.IsTrue(true);
            }
            catch (Exception exception)
            {
                //Assert
                Assert.IsTrue(false, $"Unexpected exception of type '{exception.GetType().FullName}' was thrown. Expected exception of type '{typeof(ArgumentNullException).FullName}'.");
            }
        }
    }
}