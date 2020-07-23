using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Quantify.UnitTests.Calculator
{
    [TestClass]
    public class MultiplicationTests
    {
        [DataTestMethod]
        [DataRow("25.458", "4.8753")]
        [DataRow("22.69841", "-52.435724")]
        [DataRow("25.458", "0")]
        [DataRow("-32.9284", "88.93754")]
        [DataRow("-11.112", "-2.365444")]
        [DataRow("-26.456", "0")]
        [DataRow("0", "2.321")]
        [DataRow("0", "-5.68749")]
        [DataRow("0", "0")]
        public void WHILE_MultiplicandIsDecimal_MultiplierIsDecimal_WHEN_Multiplying_THEN_ReturnProduct(string multiplicandString, string multiplierString)
        {
            // Arrange
            var valueCalculator = new DecimalValueCalculator();

            decimal multiplicand = decimal.Parse(multiplicandString);
            decimal multiplier = decimal.Parse(multiplierString);

            var expectedProduct = multiplicand * multiplier;

            // Act
            var actualProduct = valueCalculator.Multiply(multiplicand, multiplier);

            // Assert
            Assert.AreEqual(expectedProduct, actualProduct);
        }

        [DataTestMethod]
        [DataRow("25.458", 4)]
        [DataRow("22.69841", -52)]
        [DataRow("25.458", 0)]
        [DataRow("-32.9284", 88)]
        [DataRow("-11.112", -2)]
        [DataRow("-26.456", 0)]
        [DataRow("0", 2)]
        [DataRow("0", -5)]
        [DataRow("0", 0)]
        public void WHILE_MultiplicandIsDecimal_MultiplierIsInteger_WHEN_Multiplying_THEN_ReturnProduct(string multiplicandString, int multiplier)
        {
            // Arrange
            var valueCalculator = new DecimalValueCalculator();

            decimal multiplicand = decimal.Parse(multiplicandString);

            var expectedProduct = multiplicand * multiplier;

            // Act
            var actualProduct = valueCalculator.Multiply(multiplicand, multiplier);

            // Assert
            Assert.AreEqual(expectedProduct, actualProduct);
        }

        [DataTestMethod]
        [DataRow(25.458, 4.8753)]
        [DataRow(22.69841, -52.435724)]
        [DataRow(25.458, 0)]
        [DataRow(-32.9284, 88.93754)]
        [DataRow(-11.112, -2.365444)]
        [DataRow(-26.456, 0)]
        [DataRow(0, 2.321)]
        [DataRow(0, -5.68749)]
        [DataRow(0, 0)]
        public void WHILE_MultiplicandIsDouble_MultiplierIsDouble_WHEN_Multiplying_THEN_ReturnProduct(double multiplicand, double multiplier)
        {
            // Arrange
            var valueCalculator = new DoubleValueCalculator();

            var expectedProduct = multiplicand * multiplier;

            // Act
            var actualProduct = valueCalculator.Multiply(multiplicand, multiplier);

            // Assert
            Assert.AreEqual(expectedProduct, actualProduct);
        }

        [DataTestMethod]
        [DataRow(25.458, 4)]
        [DataRow(22.69841, -52)]
        [DataRow(25.458, 0)]
        [DataRow(-32.9284, 88)]
        [DataRow(-11.112, -2)]
        [DataRow(-26.456, 0)]
        [DataRow(0, 2)]
        [DataRow(0, -5)]
        [DataRow(0, 0)]
        public void WHILE_MultiplicandIsDouble_MultiplierIsInteger_WHEN_Multiplying_THEN_ReturnProduct(double multiplicand, int multiplier)
        {
            // Arrange
            var valueCalculator = new DoubleValueCalculator();

            var expectedProduct = multiplicand * multiplier;

            // Act
            var actualProduct = valueCalculator.Multiply(multiplicand, multiplier);

            // Assert
            Assert.AreEqual(expectedProduct, actualProduct);
        }
    }
}