using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quantify.Test.Assets;
using System;

namespace Quantify.UnitTests.Calculator
{
    [TestClass]
    public class DivisionTests
    {
        [DataTestMethod]
        [DataRow("25.458", "4.8753")]
        [DataRow("22.69841", "-52.435724")]
        [DataRow("-32.9284", "88.93754")]
        [DataRow("-11.112", "-2.365444")]
        [DataRow("0", "2.321")]
        [DataRow("0", "-5.68749")]
        public void WHEN_Dividing_WHILE_DividendIsDecimal_DivisorIsDecimal_THEN_ReturnQuotient(string dividendString, string divisorString)
        {
            // Arrange
            var valueCalculator = new DecimalValueCalculator();

            decimal dividend = decimal.Parse(dividendString);
            decimal divisor = decimal.Parse(divisorString);

            var expectedQuotient = dividend / divisor;

            // Act
            var actualQuotient = valueCalculator.Divide(dividend, divisor);

            // Assert
            Assert.AreEqual(expectedQuotient, actualQuotient);
        }

        [DataTestMethod]
        [DataRow("25.458")]
        [DataRow("-26.456")]
        [DataRow("0")]
        public void WHEN_Dividing_WHILE_DividendIsDecimal_DivisorIsDecimal_DivisorIsZero_THEN_ThrowException(string dividendString)
        {
            // Arrange
            var valueCalculator = new DecimalValueCalculator();

            decimal dividend = decimal.Parse(dividendString);
            const decimal divisor = 0;

            // Act
            ExceptionHelpers.ExpectException<DivideByZeroException>(() => valueCalculator.Divide(dividend, divisor));
        }

        [DataTestMethod]
        [DataRow("25.458", 4)]
        [DataRow("22.69841", -52)]
        [DataRow("-32.9284", 88)]
        [DataRow("-11.112", -2)]
        [DataRow("0", 2)]
        [DataRow("0", -5)]
        public void WHEN_Dividing_WHILE_DividendIsDecimal_DivisorIsInteger_THEN_ReturnQuotient(string dividendString, int divisor)
        {
            // Arrange
            var valueCalculator = new DecimalValueCalculator();

            var dividend = decimal.Parse(dividendString);

            var expectedQuotient = dividend / divisor;

            // Act
            var actualQuotient = valueCalculator.Divide(dividend, divisor);

            // Assert
            Assert.AreEqual(expectedQuotient, actualQuotient);
        }

        [DataTestMethod]
        [DataRow("25.458")]
        [DataRow("-26.456")]
        [DataRow("0")]
        public void WHEN_Dividing_WHILE_DividendIsDecimal_DivisorIsInteger_DivisorIsZero_THEN_ThrowException(string dividendString)
        {
            // Arrange
            var valueCalculator = new DecimalValueCalculator();

            decimal dividend = decimal.Parse(dividendString);
            const int divisor = 0;

            // Act
            ExceptionHelpers.ExpectException<DivideByZeroException>(() => valueCalculator.Divide(dividend, divisor));
        }

        [DataTestMethod]
        [DataRow(25.458, 4.8753)]
        [DataRow(22.69841, -52.435724)]
        [DataRow(-32.9284, 88.93754)]
        [DataRow(-11.112, -2.365444)]
        [DataRow(0, 2.321)]
        [DataRow(0, -5.68749)]
        public void WHEN_Dividing_WHILE_DividendIsDouble_DivisorIsDouble_THEN_ReturnQuotient(double dividend, double divisor)
        {
            // Arrange
            var valueCalculator = new DoubleValueCalculator();

            var expectedQuotient = dividend / divisor;

            // Act
            var actualQuotient = valueCalculator.Divide(dividend, divisor);

            // Assert
            Assert.AreEqual(expectedQuotient, actualQuotient);
        }

        [DataTestMethod]
        [DataRow(25.458)]
        [DataRow(-26.456)]
        [DataRow(0)]
        public void WHEN_Dividing_WHILE_DividendIsDecimal_DivisorIsDecimal_DivisorIsZero_THEN_ThrowException(double dividend)
        {
            // Arrange
            var valueCalculator = new DoubleValueCalculator();

            const double divisor = 0;

            // Act
            ExceptionHelpers.ExpectException<DivideByZeroException>(() => valueCalculator.Divide(dividend, divisor));
        }

        [DataTestMethod]
        [DataRow(25.458, 4)]
        [DataRow(22.69841, -52)]
        [DataRow(-32.9284, 88)]
        [DataRow(-11.112, -2)]
        [DataRow(0, 2)]
        [DataRow(0, -5)]
        public void WHEN_Dividing_WHILE_DividendIsDouble_DivisorIsInteger_THEN_ReturnQuotient(double dividend, int divisor)
        {
            // Arrange
            var valueCalculator = new DoubleValueCalculator();

            var expectedQuotient = dividend / divisor;

            // Act
            var actualQuotient = valueCalculator.Divide(dividend, divisor);

            // Assert
            Assert.AreEqual(expectedQuotient, actualQuotient);
        }

        [DataTestMethod]
        [DataRow(25.458)]
        [DataRow(-26.456)]
        [DataRow(0)]
        public void WHEN_Dividing_WHILE_DividendIsDecimal_DivisorIsInteger_DivisorIsZero_THEN_ThrowException(double dividend)
        {
            // Arrange
            var valueCalculator = new DoubleValueCalculator();

            const int divisor = 0;

            // Act
            ExceptionHelpers.ExpectException<DivideByZeroException>(() => valueCalculator.Divide(dividend, divisor));
        }
    }
}