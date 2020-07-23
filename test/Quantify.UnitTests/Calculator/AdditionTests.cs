using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Quantify.UnitTests.Calculator
{
    [TestClass]
    public class AdditionTests
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
        public void WHILE_FirstTermIsDecimal_SecondTermIsDecimal_WHEN_Adding_THEN_ReturnSum(string term1String, string term2String)
        {
            // Arrange
            var valueCalculator = new DecimalValueCalculator();

            decimal term1 = decimal.Parse(term1String);
            decimal term2 = decimal.Parse(term2String);

            var expectedSum = term1 + term2;

            // Act
            var actualSum = valueCalculator.Add(term1, term2);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
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
        public void WHILE_FirstTermIsDecimal_SecondTermIsInteger_WHEN_Adding_THEN_ReturnSum(string term1String, int term2)
        {
            // Arrange
            var valueCalculator = new DecimalValueCalculator();

            decimal term1 = decimal.Parse(term1String);

            var expectedSum = term1 + term2;

            // Act
            var actualSum = valueCalculator.Add(term1, term2);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
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
        public void WHILE_FirstTermIsDouble_SecondTermIsDouble_WHEN_Adding_THEN_ReturnSum(double term1, double term2)
        {
            // Arrange
            var valueCalculator = new DoubleValueCalculator();

            var expectedSum = term1 + term2;

            // Act
            var actualSum = valueCalculator.Add(term1, term2);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
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
        public void WHILE_FirstTermIsDouble_SecondTermIsInteger_WHEN_Adding_THEN_ReturnSum(double term1, int term2)
        {
            // Arrange
            var valueCalculator = new DoubleValueCalculator();

            var expectedSum = term1 + term2;

            // Act
            var actualSum = valueCalculator.Add(term1, term2);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }
    }
}