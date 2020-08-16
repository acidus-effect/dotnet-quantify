using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quantify.IntegrationTests.Quantity.Assets;
using System;

namespace Quantify.IntegrationTests.Quantity
{
    [TestClass]
    public class QuantitySubtractionTests
    {
        [DataTestMethod]
        [DataRow(double.MaxValue, double.MaxValue)]
        [DataRow(double.MaxValue, 365.4754)]
        [DataRow(double.MaxValue, 0)]
        [DataRow(double.MaxValue, -487.147)]
        [DataRow(double.MaxValue, double.MinValue)]
        [DataRow(25.458, double.MaxValue)]
        [DataRow(25.458, 365.4754)]
        [DataRow(25.458, 0)]
        [DataRow(25.458, -487.147)]
        [DataRow(25.458, double.MinValue)]
        [DataRow(0, double.MaxValue)]
        [DataRow(0, 365.4754)]
        [DataRow(0, 0)]
        [DataRow(0, -487.147)]
        [DataRow(0, double.MinValue)]
        [DataRow(-451.444, double.MaxValue)]
        [DataRow(-451.444, 365.4754)]
        [DataRow(-451.444, 0)]
        [DataRow(-451.444, -487.147)]
        [DataRow(-451.444, double.MinValue)]
        [DataRow(double.MinValue, double.MaxValue)]
        [DataRow(double.MinValue, 365.4754)]
        [DataRow(double.MinValue, 0)]
        [DataRow(double.MinValue, -487.147)]
        [DataRow(double.MinValue, double.MinValue)]
        public void WHEN_Subtracting_WHILE_BothSidesAreQuantities_UnitsAreTheSame_THEN_ReturnQuantityWithDifferenceValue(double term1Value, double term2Value)
        {
            // Arrange
            var unit = TestData.Kilometre;

            var quantityLhs = TestQuantity.Create(term1Value, unit);
            var quantityRhs = TestQuantity.Create(term2Value, unit);

            var expectedQuantityValue = term1Value - term2Value;
            var expectedQuantityUnit = unit;

            // Act
            var calculatedQuantity = quantityLhs.Subtract(quantityRhs);

            // Assert
            Assert.AreEqual(expectedQuantityValue, calculatedQuantity.Value);
            Assert.AreEqual(expectedQuantityUnit, calculatedQuantity.Unit);
        }

        [DataTestMethod]
        [DataRow(double.MaxValue, double.MaxValue)]
        [DataRow(double.MaxValue, 365.4754)]
        [DataRow(double.MaxValue, 0)]
        [DataRow(double.MaxValue, -487.147)]
        [DataRow(double.MaxValue, double.MinValue)]
        [DataRow(25.458, double.MaxValue)]
        [DataRow(25.458, 365.4754)]
        [DataRow(25.458, 0)]
        [DataRow(25.458, -487.147)]
        [DataRow(25.458, double.MinValue)]
        [DataRow(0, double.MaxValue)]
        [DataRow(0, 365.4754)]
        [DataRow(0, 0)]
        [DataRow(0, -487.147)]
        [DataRow(0, double.MinValue)]
        [DataRow(-451.444, double.MaxValue)]
        [DataRow(-451.444, 365.4754)]
        [DataRow(-451.444, 0)]
        [DataRow(-451.444, -487.147)]
        [DataRow(-451.444, double.MinValue)]
        [DataRow(double.MinValue, double.MaxValue)]
        [DataRow(double.MinValue, 365.4754)]
        [DataRow(double.MinValue, 0)]
        [DataRow(double.MinValue, -487.147)]
        [DataRow(double.MinValue, double.MinValue)]
        public void WHEN_Subtracting_WHILE_BothSidesAreQuantities_UnitsAreDifferent_THEN_ReturnQuantity_DifferenceValue_LhsUnit(double term1Value, double term2Value)
        {
            // Arrange
            var term1Unit = TestData.Kilometre;
            var term2Unit = TestData.Metre;

            var expectedUnit = term1Unit;
            var expectedValue = term1Value - (term2Value / TestData.KilometreUnitValue);

            var term1Quantity = TestQuantity.Create(term1Value, term1Unit);
            var term2Quantity = TestQuantity.Create(term2Value, term2Unit);

            // Act
            var calculatedQuantity = term1Quantity.Subtract(term2Quantity);

            // Assert
            Assert.AreEqual(expectedValue, calculatedQuantity.Value);
            Assert.AreEqual(expectedUnit, calculatedQuantity.Unit);
        }

        [DataTestMethod]
        [DataRow(double.MaxValue, "32767")]
        [DataRow(double.MaxValue, "365")]
        [DataRow(double.MaxValue, "0")]
        [DataRow(double.MaxValue, "-487")]
        [DataRow(double.MaxValue, "-32768")]
        [DataRow(25.458, "32767")]
        [DataRow(25.458, "365")]
        [DataRow(25.458, "0")]
        [DataRow(25.458, "-487")]
        [DataRow(25.458, "-32768")]
        [DataRow(0, "32767")]
        [DataRow(0, "365")]
        [DataRow(0, "0")]
        [DataRow(0, "-487")]
        [DataRow(0, "-32768")]
        [DataRow(-451.444, "32767")]
        [DataRow(-451.444, "365")]
        [DataRow(-451.444, "0")]
        [DataRow(-451.444, "-487")]
        [DataRow(-451.444, "-32768")]
        [DataRow(double.MinValue, "32767")]
        [DataRow(double.MinValue, "365")]
        [DataRow(double.MinValue, "0")]
        [DataRow(double.MinValue, "-487")]
        [DataRow(double.MinValue, "-32768")]
        public void WHEN_Subtracting_WHILE_SecondTerm_Short_THEN_ReturnQuantityWithDifferenceValue(double term1Value, string term2ValueString)
        {
            // Arrange
            var unit = TestData.Hectometre;

            var quantity = TestQuantity.Create(term1Value, unit);
            var term2Value = short.Parse(term2ValueString);

            var expectedUnit = unit;
            var expectedValue = term1Value - term2Value;

            // Act
            var calculatedQuantity = quantity.Subtract(term2Value);

            // Assert
            Assert.AreEqual(expectedValue, calculatedQuantity.Value);
            Assert.AreEqual(expectedUnit, calculatedQuantity.Unit);
        }

        [DataTestMethod]
        [DataRow(double.MaxValue, "32767")]
        [DataRow(double.MaxValue, "365")]
        [DataRow(double.MaxValue, "0")]
        [DataRow(25.458, "32767")]
        [DataRow(25.458, "365")]
        [DataRow(25.458, "0")]
        [DataRow(0, "32767")]
        [DataRow(0, "365")]
        [DataRow(0, "0")]
        [DataRow(-451.444, "32767")]
        [DataRow(-451.444, "365")]
        [DataRow(-451.444, "0")]
        [DataRow(double.MinValue, "32767")]
        [DataRow(double.MinValue, "365")]
        [DataRow(double.MinValue, "0")]
        public void WHEN_Subtracting_WHILE_SecondTerm_UnsignedShort_THEN_ReturnQuantityWithDifferenceValue(double term1Value, string term2ValueString)
        {
            // Arrange
            var unit = TestData.Hectometre;

            var quantity = TestQuantity.Create(term1Value, unit);
            var term2Value = ushort.Parse(term2ValueString);

            var expectedUnit = unit;
            var expectedValue = term1Value - term2Value;

            // Act
            var calculatedQuantity = quantity.Subtract(term2Value);

            // Assert
            Assert.AreEqual(expectedValue, calculatedQuantity.Value);
            Assert.AreEqual(expectedUnit, calculatedQuantity.Unit);
        }

        [DataTestMethod]
        [DataRow(double.MaxValue, int.MaxValue)]
        [DataRow(double.MaxValue, 365)]
        [DataRow(double.MaxValue, 0)]
        [DataRow(double.MaxValue, -487)]
        [DataRow(double.MaxValue, int.MinValue)]
        [DataRow(25.458, int.MaxValue)]
        [DataRow(25.458, 365)]
        [DataRow(25.458, 0)]
        [DataRow(25.458, -487)]
        [DataRow(25.458, int.MinValue)]
        [DataRow(0, int.MaxValue)]
        [DataRow(0, 365)]
        [DataRow(0, 0)]
        [DataRow(0, -487)]
        [DataRow(0, int.MinValue)]
        [DataRow(-451.444, int.MaxValue)]
        [DataRow(-451.444, 365)]
        [DataRow(-451.444, 0)]
        [DataRow(-451.444, -487)]
        [DataRow(-451.444, int.MinValue)]
        [DataRow(double.MinValue, int.MaxValue)]
        [DataRow(double.MinValue, 365)]
        [DataRow(double.MinValue, 0)]
        [DataRow(double.MinValue, -487)]
        [DataRow(double.MinValue, int.MinValue)]
        public void WHEN_Subtracting_WHILE_SecondTerm_Integer_THEN_ReturnQuantityWithDifferenceValue(double term1Value, int term2Value)
        {
            // Arrange
            var unit = TestData.Hectometre;

            var quantity = TestQuantity.Create(term1Value, unit);

            var expectedUnit = unit;
            var expectedValue = term1Value - term2Value;

            // Act
            var calculatedQuantity = quantity.Subtract(term2Value);

            // Assert
            Assert.AreEqual(expectedValue, calculatedQuantity.Value);
            Assert.AreEqual(expectedUnit, calculatedQuantity.Unit);
        }

        [DataTestMethod]
        [DataRow(double.MaxValue, long.MaxValue)]
        [DataRow(double.MaxValue, 365L)]
        [DataRow(double.MaxValue, 0L)]
        [DataRow(double.MaxValue, -487L)]
        [DataRow(double.MaxValue, long.MinValue)]
        [DataRow(25.458, long.MaxValue)]
        [DataRow(25.458, 365L)]
        [DataRow(25.458, 0L)]
        [DataRow(25.458, -487L)]
        [DataRow(25.458, long.MinValue)]
        [DataRow(0, long.MaxValue)]
        [DataRow(0, 365L)]
        [DataRow(0, 0L)]
        [DataRow(0, -487L)]
        [DataRow(0, long.MinValue)]
        [DataRow(-451.444, long.MaxValue)]
        [DataRow(-451.444, 365L)]
        [DataRow(-451.444, 0L)]
        [DataRow(-451.444, -487L)]
        [DataRow(-451.444, long.MinValue)]
        [DataRow(double.MinValue, long.MaxValue)]
        [DataRow(double.MinValue, 365L)]
        [DataRow(double.MinValue, 0L)]
        [DataRow(double.MinValue, -487L)]
        [DataRow(double.MinValue, long.MinValue)]
        public void WHEN_Subtracting_WHILE_SecondTerm_Long_THEN_ReturnQuantityWithDifferenceValue(double term1Value, long term2Value)
        {
            // Arrange
            var unit = TestData.Hectometre;

            var quantity = TestQuantity.Create(term1Value, unit);

            var expectedUnit = unit;
            var expectedValue = term1Value - term2Value;

            // Act
            var calculatedQuantity = quantity.Subtract(term2Value);

            // Assert
            Assert.AreEqual(expectedValue, calculatedQuantity.Value);
            Assert.AreEqual(expectedUnit, calculatedQuantity.Unit);
        }

        [DataTestMethod]
        [DataRow(double.MaxValue, double.MaxValue)]
        [DataRow(double.MaxValue, 365.4754)]
        [DataRow(double.MaxValue, 0)]
        [DataRow(double.MaxValue, -487.147)]
        [DataRow(double.MaxValue, double.MinValue)]
        [DataRow(25.458, double.MaxValue)]
        [DataRow(25.458, 365.4754)]
        [DataRow(25.458, 0)]
        [DataRow(25.458, -487.147)]
        [DataRow(25.458, double.MinValue)]
        [DataRow(0, double.MaxValue)]
        [DataRow(0, 365.4754)]
        [DataRow(0, 0)]
        [DataRow(0, -487.147)]
        [DataRow(0, double.MinValue)]
        [DataRow(-451.444, double.MaxValue)]
        [DataRow(-451.444, 365.4754)]
        [DataRow(-451.444, 0)]
        [DataRow(-451.444, -487.147)]
        [DataRow(-451.444, double.MinValue)]
        [DataRow(double.MinValue, double.MaxValue)]
        [DataRow(double.MinValue, 365.4754)]
        [DataRow(double.MinValue, 0)]
        [DataRow(double.MinValue, -487.147)]
        [DataRow(double.MinValue, double.MinValue)]
        public void WHEN_Subtracting_WHILE_SecondTerm_Double_THEN_ReturnQuantityWithDifferenceValue(double term1Value, double term2Value)
        {
            // Arrange
            var unit = TestData.Hectometre;

            var quantity = TestQuantity.Create(term1Value, unit);

            var expectedUnit = unit;
            var expectedValue = term1Value - term2Value;

            // Act
            var calculatedQuantity = quantity.Subtract(term2Value);

            // Assert
            Assert.AreEqual(expectedValue, calculatedQuantity.Value);
            Assert.AreEqual(expectedUnit, calculatedQuantity.Unit);
        }

        [DataTestMethod]
        [DataRow(double.MaxValue, "365.4754")]
        [DataRow(double.MaxValue, "0")]
        [DataRow(double.MaxValue, "-487.147")]
        [DataRow(25.458, "365.4754")]
        [DataRow(25.458, "0")]
        [DataRow(25.458, "-487.147")]
        [DataRow(0, "365.4754")]
        [DataRow(0, "0")]
        [DataRow(0, "-487.147")]
        [DataRow(-451.444, "365.4754")]
        [DataRow(-451.444, "0")]
        [DataRow(-451.444, "-487.147")]
        [DataRow(double.MinValue, "365.4754")]
        [DataRow(double.MinValue, "0")]
        [DataRow(double.MinValue, "-487.147")]
        public void WHEN_Subtracting_WHILE_SecondTerm_Decimal_THEN_ReturnQuantityWithDifferenceValue(double term1Value, string term2ValueString)
        {
            // Arrange
            var unit = TestData.Hectometre;
            var term2Value = decimal.Parse(term2ValueString);

            var quantity = TestQuantity.Create(term1Value, unit);

            var expectedUnit = unit;
            var expectedValue = term1Value - Convert.ToDouble(term2Value);

            // Act
            var calculatedQuantity = quantity.Subtract(term2Value);

            // Assert
            Assert.AreEqual(expectedValue, calculatedQuantity.Value);
            Assert.AreEqual(expectedUnit, calculatedQuantity.Unit);
        }

        [DataTestMethod]
        [DataRow(double.MaxValue, float.MaxValue)]
        [DataRow(double.MaxValue, 365.4754f)]
        [DataRow(double.MaxValue, 0f)]
        [DataRow(double.MaxValue, -487.147f)]
        [DataRow(double.MaxValue, float.MinValue)]
        [DataRow(25.458, float.MaxValue)]
        [DataRow(25.458, 365.4754f)]
        [DataRow(25.458, 0f)]
        [DataRow(25.458, -487.147f)]
        [DataRow(25.458, float.MinValue)]
        [DataRow(0, float.MaxValue)]
        [DataRow(0, 365.4754f)]
        [DataRow(0, 0f)]
        [DataRow(0, -487.147f)]
        [DataRow(0, float.MinValue)]
        [DataRow(-451.444, float.MaxValue)]
        [DataRow(-451.444, 365.4754f)]
        [DataRow(-451.444, 0f)]
        [DataRow(-451.444, -487.147f)]
        [DataRow(-451.444, float.MinValue)]
        [DataRow(double.MinValue, float.MaxValue)]
        [DataRow(double.MinValue, 365.4754f)]
        [DataRow(double.MinValue, 0f)]
        [DataRow(double.MinValue, -487.147f)]
        [DataRow(double.MinValue, float.MinValue)]
        public void WHEN_Subtracting_WHILE_SecondTerm_Float_THEN_ReturnQuantityWithDifferenceValue(double term1Value, float term2Value)
        {
            // Arrange
            var unit = TestData.Hectometre;

            var quantity = TestQuantity.Create(term1Value, unit);

            var expectedUnit = unit;
            var expectedValue = term1Value - Convert.ToDouble(term2Value);

            // Act
            var calculatedQuantity = quantity.Subtract(term2Value);

            // Assert
            Assert.AreEqual(expectedValue, calculatedQuantity.Value);
            Assert.AreEqual(expectedUnit, calculatedQuantity.Unit);
        }
    }
}