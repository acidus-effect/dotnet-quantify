using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quantify.Test.UnitTest.TestQuantities;

namespace Quantify.Test.UnitTest.Quantity
{
    public partial class QuantityInstantiationTests
    {
        [DataTestMethod]
        // No changes
        [DataRow(22.458, "Unit1", 22.458, "Unit1", true)]
        // One change
        [DataRow(22.457, "Unit1", 22.458, "Unit1", false)]
        [DataRow(22.458, "Unit2", 22.458, "Unit1", false)]
        [DataRow(22.458, "Unit1", 22.457, "Unit1", false)]
        [DataRow(22.458, "Unit1", 22.458, "Unit2", false)]
        // Two changes
        [DataRow(22.457, "Unit2", 22.458, "Unit1", false)]
        [DataRow(22.457, "Unit1", 22.457, "Unit1", true)]
        [DataRow(22.457, "Unit1", 22.458, "Unit2", false)]
        [DataRow(22.458, "Unit2", 22.457, "Unit1", false)]
        [DataRow(22.458, "Unit2", 22.458, "Unit2", true)]
        [DataRow(22.458, "Unit1", 22.457, "Unit2", false)]
        // Three changes
        [DataRow(22.457, "Unit2", 22.457, "Unit1", false)]
        [DataRow(22.457, "Unit2", 22.458, "Unit2", false)]
        [DataRow(22.457, "Unit1", 22.457, "Unit2", false)]
        [DataRow(22.458, "Unit2", 22.457, "Unit2", false)]
        // Four changes
        [DataRow(22.457, "Unit2", 22.457, "Unit2", true)]
        public void WHEN_CheckingEquality_StronglyTyped_WHILE_QuantitiesAreDifferentInstances_THEN_ReturnTrueIfEqual(double value1, string unit1, double value2, string unit2, bool expectedIsEqual)
        {
            // Arrange
            var quantity1 = DoubleValueStringUnitQuantityBuilder.NewInstance().WithValue(value1).WithUnit(unit1).Build();
            var qualtity2 = DoubleValueStringUnitQuantityBuilder.NewInstance().WithValue(value2).WithUnit(unit2).Build();

            // Act
            var actualIsEqual = quantity1.Equals(qualtity2);

            // Assert
            Assert.AreEqual(expectedIsEqual, actualIsEqual);
        }

        [DataTestMethod]
        // No changes
        [DataRow(22.458, "Unit1", 22.458, "Unit1", true)]
        // One change
        [DataRow(22.457, "Unit1", 22.458, "Unit1", false)]
        [DataRow(22.458, "Unit2", 22.458, "Unit1", false)]
        [DataRow(22.458, "Unit1", 22.457, "Unit1", false)]
        [DataRow(22.458, "Unit1", 22.458, "Unit2", false)]
        // Two changes
        [DataRow(22.457, "Unit2", 22.458, "Unit1", false)]
        [DataRow(22.457, "Unit1", 22.457, "Unit1", true)]
        [DataRow(22.457, "Unit1", 22.458, "Unit2", false)]
        [DataRow(22.458, "Unit2", 22.457, "Unit1", false)]
        [DataRow(22.458, "Unit2", 22.458, "Unit2", true)]
        [DataRow(22.458, "Unit1", 22.457, "Unit2", false)]
        // Three changes
        [DataRow(22.457, "Unit2", 22.457, "Unit1", false)]
        [DataRow(22.457, "Unit2", 22.458, "Unit2", false)]
        [DataRow(22.457, "Unit1", 22.457, "Unit2", false)]
        [DataRow(22.458, "Unit2", 22.457, "Unit2", false)]
        // Four changes
        [DataRow(22.457, "Unit2", 22.457, "Unit2", true)]
        public void WHEN_CheckingEquality_ObjectType_WHILE_QuantitiesAreDifferentInstances_THEN_ReturnTrueIfEqual(double value1, string unit1, double value2, string unit2, bool expectedIsEqual)
        {
            // Arrange
            var quantity1 = DoubleValueStringUnitQuantityBuilder.NewInstance().WithValue(value1).WithUnit(unit1).Build();
            var qualtity2 = DoubleValueStringUnitQuantityBuilder.NewInstance().WithValue(value2).WithUnit(unit2).Build() as object;

            // Act
            var actualIsEqual = quantity1.Equals(qualtity2);

            // Assert
            Assert.AreEqual(expectedIsEqual, actualIsEqual);
        }

        [TestMethod]
        public void WHEN_CheckingEquality_StronglyTyped_WHILE_InputIsNull_THEN_ReturnFalse()
        {
            // Arrange
            var quantity = DoubleValueStringUnitQuantityBuilder.NewInstance().WithValue(123).WithUnit("Some Unit").Build();

            // Act
            var areEqual = quantity.Equals(null);

            // Assert
            Assert.IsFalse(areEqual);
        }

        [TestMethod]
        public void WHEN_CheckingEquality_ObjectType_WHILE_InputIsNull_THEN_ReturnFalse()
        {
            // Arrange
            var quantity = DoubleValueStringUnitQuantityBuilder.NewInstance().WithValue(123).WithUnit("Some Unit").Build();

            // Act
            var areEqual = quantity.Equals(null as object);

            // Assert
            Assert.IsFalse(areEqual);
        }

        [TestMethod]
        public void WHEN_CheckingEquality_StronglyTyped_WHILE_InputIsTheSameInstance_THEN_ReturnTrue()
        {
            // Arrange
            var quantity = DoubleValueStringUnitQuantityBuilder.NewInstance().WithValue(123).WithUnit("Some Unit").Build();

            // Act
            var areEqual = quantity.Equals(quantity);

            // Assert
            Assert.IsTrue(areEqual);
        }

        [TestMethod]
        public void WHEN_CheckingEquality_ObjectType_WHILE_InputIsTheSameInstance_THEN_ReturnTrue()
        {
            // Arrange
            var quantity = DoubleValueStringUnitQuantityBuilder.NewInstance().WithValue(123).WithUnit("Some Unit").Build();

            // Act
            var areEqual = quantity.Equals(quantity as object);

            // Assert
            Assert.IsTrue(areEqual);
        }
    }
}