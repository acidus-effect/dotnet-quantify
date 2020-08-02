using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Quantify.UnitTests.Calculator
{
    [TestClass]
    public class SubtractionTests
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
        public void WHEN_Subtracting_WHILE_MinuendIsDecimal_SubtrahendIsDecimal_THEN_ReturnDifference(string minuendString, string subtrahendString)
        {
            // Arrange
            var valueCalculator = new DecimalValueCalculator();

            decimal minuend = decimal.Parse(minuendString);
            decimal subtrahend = decimal.Parse(subtrahendString);

            var expectedDifference = minuend - subtrahend;

            // Act
            var actualDifference = valueCalculator.Subtract(minuend, subtrahend);

            // Assert
            Assert.AreEqual(expectedDifference, actualDifference);
        }

        [DataTestMethod]
        [DataRow("25.458", 8)]
        [DataRow("13.131313", -31)]
        [DataRow("25.458", 0)]
        [DataRow("-57.123456789", 16)]
        [DataRow("-77.777", -28)]
        [DataRow("-26.456", 0)]
        [DataRow("0", 2)]
        [DataRow("0", -5)]
        [DataRow("0", 0)]
        public void WHEN_Subtracting_WHILE_MinuendIsDecimal_SubtrahendIsInteger_THEN_ReturnDifference(string minuendString, int subtrahend)
        {
            // Arrange
            var valueCalculator = new DecimalValueCalculator();

            decimal minuend = decimal.Parse(minuendString);

            var expectedDifference = minuend - subtrahend;

            // Act
            var actualDifference = valueCalculator.Subtract(minuend, subtrahend);

            // Assert
            Assert.AreEqual(expectedDifference, actualDifference);
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
        public void WHEN_Subtracting_WHILE_MinuendIsDouble_SubtrahendIsDouble_THEN_ReturnDifference(double minuend, double subtrahend)
        {
            // Arrange
            var valueCalculator = new DoubleValueCalculator();

            var expectedDifference = minuend - subtrahend;

            // Act
            var actualDifference = valueCalculator.Subtract(minuend, subtrahend);

            // Assert
            Assert.AreEqual(expectedDifference, actualDifference);
        }

        [DataTestMethod]
        [DataRow(25.458, 8)]
        [DataRow(13.131313, -31)]
        [DataRow(25.458, 0)]
        [DataRow(-57.123456789, 16)]
        [DataRow(-77.777, -28)]
        [DataRow(-26.456, 0)]
        [DataRow(0, 2)]
        [DataRow(0, -5)]
        [DataRow(0, 0)]
        public void WHEN_Subtracting_WHILE_MinuendIsDouble_SubtrahendIsInteger_THEN_ReturnDifference(double minuend, int subtrahend)
        {
            // Arrange
            var valueCalculator = new DoubleValueCalculator();

            var expectedDifference = minuend - subtrahend;

            // Act
            var actualDifference = valueCalculator.Subtract(minuend, subtrahend);

            // Assert
            Assert.AreEqual(expectedDifference, actualDifference);
        }
    }
}