using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Quantify.Test.Assets;

namespace Quantify.UnitTests.Quantity
{
    [TestClass]
    public class QuantityTests
    {
        [TestMethod]
        public void WHILE_ArgumentsAreValid_WHEN_Instantiating_THEN_CreateInstance()
        {
            // Arrange
            const double expectedValue = 1.547;
            const string expectedUnit = "Hello";
            var quantityFactory = new Mock<QuantityFactory<double, string, DoubleValueStringUnitQuantity>>().Object;
            var unitRepository = new Mock<UnitRepository<double, string>>().Object;
            var valueCalculator = new Mock<ValueCalculator<double>>().Object;
            var valueConverter = new Mock<ValueConverter<double, string>>().Object;

            // Act
            var quantity = new DoubleValueStringUnitQuantity(expectedValue, expectedUnit, quantityFactory, unitRepository, valueCalculator, valueConverter);

            // Assert
            Assert.AreEqual(expectedValue, quantity.Value);
            Assert.AreEqual(expectedUnit, quantity.Unit);
        }

        [TestMethod]
        public void WHILE_ArgumentIsNull_WHEN_Instantiating_THEN_ThrowException()
        {
            // Arrange
            const string value = "Hello";
            const string unit = "World";
            var quantityFactory = new Mock<QuantityFactory<string, string, StringValueStringUnitQuantity>>().Object;
            var unitRepository = new Mock<UnitRepository<string, string>>().Object;
            var valueCalculator = new Mock<ValueCalculator<string>>().Object;
            var valueConverter = new Mock<ValueConverter<string, string>>().Object;

            // Act & Assert
            ExceptionHelpers.ExpectArgumentNullException("value", () => new StringValueStringUnitQuantity(null, unit, quantityFactory, unitRepository, valueCalculator, valueConverter));
            ExceptionHelpers.ExpectArgumentNullException("unit", () => new StringValueStringUnitQuantity(value, null, quantityFactory, unitRepository, valueCalculator, valueConverter));
            ExceptionHelpers.ExpectArgumentNullException("quantityFactory", () => new StringValueStringUnitQuantity(value, unit, null, unitRepository, valueCalculator, valueConverter));
            ExceptionHelpers.ExpectArgumentNullException("unitRepository", () => new StringValueStringUnitQuantity(value, unit, quantityFactory, null, valueCalculator, valueConverter));
            ExceptionHelpers.ExpectArgumentNullException("valueCalculator", () => new StringValueStringUnitQuantity(value, unit, quantityFactory, unitRepository, null, valueConverter));
            ExceptionHelpers.ExpectArgumentNullException("valueConverter", () => new StringValueStringUnitQuantity(value, unit, quantityFactory, unitRepository, valueCalculator, null));
        }

        //[TestMethod]
        //public void WHEN_Constructing_Quantity_WHILE_GiveInput_THEN_ObjectCreated()
        //{
        //    // Act
        //    new Assets.EnumTestQuantity(22, TestUnit.Centimetre);

        //    Assert.IsTrue(false);
        //}

        //[TestMethod]
        //public void WHEN_ComparingQuantities_StronglyTyped_WHILE_QuantitiesAreEquivalent_THEN_ReturnTrue()
        //{
        //    // Arrange
        //    var quantity1 = new Assets.EnumTestQuantity(52, TestUnit.Centimetre);
        //    var quantity2 = new Assets.EnumTestQuantity(52, TestUnit.Centimetre);

        //    var expectedResult = true;

        //    // Act
        //    var actualResult = quantity1.Equals(quantity2);

        //    // Assert
        //    Assert.AreEqual(expectedResult, actualResult);
        //}

        //[TestMethod]
        //public void WHEN_ComparingQuantities_StronglyTyped_WHILE_QuantitiesAreSameObject_THEN_ReturnTrue()
        //{
        //    // Arrange
        //    var quantity1 = new Assets.EnumTestQuantity(52, TestUnit.Centimetre);
        //    var quantity2 = quantity1;

        //    var expectedResult = true;

        //    // Act
        //    var actualResult = quantity1.Equals(quantity2);

        //    // Assert
        //    Assert.AreEqual(expectedResult, actualResult);
        //}

        //[TestMethod]
        //public void WHEN_ComparingQuantities_StronglyTyped_WHILE_SameValueDifferentUnit_THEN_ReturnFalse()
        //{
        //    // Arrange
        //    var quantity1 = new Assets.EnumTestQuantity(52, TestUnit.Centimetre);
        //    var quantity2 = new Assets.EnumTestQuantity(52, TestUnit.Metre);

        //    var expectedResult = false;

        //    // Act
        //    var actualResult = quantity1.Equals(quantity2);

        //    // Assert
        //    Assert.AreEqual(expectedResult, actualResult);
        //}

        //[TestMethod]
        //public void WHEN_ComparingQuantities_StronglyTyped_WHILE_SameUnitDifferentValue_THEN_ReturnFalse()
        //{
        //    // Arrange
        //    var quantity1 = new Assets.EnumTestQuantity(52, TestUnit.Centimetre);
        //    var quantity2 = new Assets.EnumTestQuantity(21, TestUnit.Centimetre);

        //    var expectedResult = false;

        //    // Act
        //    var actualResult = quantity1.Equals(quantity2);

        //    // Assert
        //    Assert.AreEqual(expectedResult, actualResult);
        //}

        //[TestMethod]
        //public void WHEN_ComparingQuantities_StronglyTyped_WHILE_DifferentUnitDifferentValue_THEN_ReturnFalse()
        //{
        //    // Arrange
        //    var quantity1 = new Assets.EnumTestQuantity(52, TestUnit.Metre);
        //    var quantity2 = new Assets.EnumTestQuantity(21, TestUnit.Centimetre);

        //    var expectedResult = false;

        //    // Act
        //    var actualResult = quantity1.Equals(quantity2);

        //    // Assert
        //    Assert.AreEqual(expectedResult, actualResult);
        //}

        //[TestMethod]
        //public void WHEN_ComparingQuantities_ObjectType_WHILE_QuantitiesAreEquivalent_THEN_ReturnTrue()
        //{
        //    // Arrange
        //    var quantity1 = new Assets.EnumTestQuantity(36, TestUnit.Metre);
        //    var quantity2 = new Assets.EnumTestQuantity(36, TestUnit.Metre) as object;

        //    var expectedResult = true;

        //    // Act
        //    var actualResult = quantity1.Equals(quantity2);

        //    // Assert
        //    Assert.AreEqual(expectedResult, actualResult);
        //}

        //[TestMethod]
        //public void WHEN_ComparingQuantities_ObjectType_WHILE_QuantitiesAreSameObject_THEN_ReturnTrue()
        //{
        //    // Arrange
        //    var quantity1 = new Assets.EnumTestQuantity(52, TestUnit.Centimetre);
        //    var quantity2 = quantity1 as object;

        //    var expectedResult = true;

        //    // Act
        //    var actualResult = quantity1.Equals(quantity2);

        //    // Assert
        //    Assert.AreEqual(expectedResult, actualResult);
        //}

        //[TestMethod]
        //public void WHEN_ComparingQuantities_ObjectType_WHILE_SameValueDifferentUnit_THEN_ReturnFalse()
        //{
        //    // Arrange
        //    var quantity1 = new Assets.EnumTestQuantity(25, TestUnit.Decimetre);
        //    var quantity2 = new Assets.EnumTestQuantity(25, TestUnit.Hectometre) as object;

        //    var expectedResult = false;

        //    // Act
        //    var actualResult = quantity1.Equals(quantity2);

        //    // Assert
        //    Assert.AreEqual(expectedResult, actualResult);
        //}

        //[TestMethod]
        //public void WHEN_ComparingQuantities_ObjectType_WHILE_SameUnitDifferentValue_THEN_ReturnFalse()
        //{
        //    // Arrange
        //    var quantity1 = new Assets.EnumTestQuantity(77, TestUnit.Decametre);
        //    var quantity2 = new Assets.EnumTestQuantity(563, TestUnit.Decametre) as object;

        //    var expectedResult = false;

        //    // Act
        //    var actualResult = quantity1.Equals(quantity2);

        //    // Assert
        //    Assert.AreEqual(expectedResult, actualResult);
        //}

        //[TestMethod]
        //public void WHEN_ComparingQuantities_ObjectType_WHILE_DifferentUnitDifferentValue_THEN_ReturnFalse()
        //{
        //    // Arrange
        //    var quantity1 = new Assets.EnumTestQuantity(75, TestUnit.Hectometre);
        //    var quantity2 = new Assets.EnumTestQuantity(11, TestUnit.Kilometre) as object;

        //    var expectedResult = false;

        //    // Act
        //    var actualResult = quantity1.Equals(quantity2);

        //    // Assert
        //    Assert.AreEqual(expectedResult, actualResult);
        //}

        //public void WHEN_ConvertingUnit_GIVEN_TargetUnit_THEN_ConvertToUnitAndReturn()
        //{
        //    // Arrange
        //    //var startQuantity = EnumTestQuantityBuilder.Instance().mo

        //    //
        //}
    }
}