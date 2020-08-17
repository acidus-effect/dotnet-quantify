using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quantify.Test.Assets;
using System;

namespace Quantify.UnitTests.Calculator
{
    [TestClass]
    public class DecimalDivisionTests
    {
        [TestMethod]
        public void WHEN_Dividing_WHILE_Divisor_Zero_THEN_ThrowException()
        {
            // Arrange
            var valueCalculator = new DecimalValueCalculator();
            var dividend = 1;

            // Act & Assert
            ExceptionHelpers.ExpectException<DivideByZeroException>(() => valueCalculator.Divide(dividend, (short)0));
            ExceptionHelpers.ExpectException<DivideByZeroException>(() => valueCalculator.Divide(dividend, (ushort)0));
            ExceptionHelpers.ExpectException<DivideByZeroException>(() => valueCalculator.Divide(dividend, (int)0));
            ExceptionHelpers.ExpectException<DivideByZeroException>(() => valueCalculator.Divide(dividend, (uint)0));
            ExceptionHelpers.ExpectException<DivideByZeroException>(() => valueCalculator.Divide(dividend, (long)0));
            ExceptionHelpers.ExpectException<DivideByZeroException>(() => valueCalculator.Divide(dividend, (ulong)0));
            ExceptionHelpers.ExpectException<DivideByZeroException>(() => valueCalculator.Divide(dividend, (double)0));
            ExceptionHelpers.ExpectException<DivideByZeroException>(() => valueCalculator.Divide(dividend, (decimal)0));
            ExceptionHelpers.ExpectException<DivideByZeroException>(() => valueCalculator.Divide(dividend, (float)0));
        }

        [DataTestMethod]
        [DataRow("254.1478", "32767")]
        [DataRow("25.458", "4")]
        [DataRow("22.69841", "-52")]
        [DataRow("254.1478", "-32768")]
        [DataRow("0", "32767")]
        [DataRow("0", "2")]
        [DataRow("0", "-5")]
        [DataRow("0", "-32768")]
        [DataRow("-571.123", "32767")]
        [DataRow("-32.9284", "88")]
        [DataRow("-11.112", "-2")]
        [DataRow("-12.3456", "-32768")]
        public void WHEN_Dividing_WHILE_Divisor_Short_THEN_ReturnQuotient(string dividendString, string divisorString)
        {
            // Arrange
            var valueCalculator = new DecimalValueCalculator();

            decimal dividend = decimal.Parse(dividendString);
            short divisor = short.Parse(divisorString);

            var expectedQuotient = dividend / divisor;

            // Act
            var actualQuotient = valueCalculator.Divide(dividend, divisor);

            // Assert
            Assert.AreEqual(expectedQuotient, actualQuotient);
        }

        [DataTestMethod]
        [DataRow("254.1478", "32767")]
        [DataRow("25.458", "4")]
        [DataRow("0", "32767")]
        [DataRow("0", "2")]
        [DataRow("-571.123", "32767")]
        [DataRow("-32.9284", "88")]
        public void WHEN_Dividing_WHILE_Divisor_UnsignedShort_THEN_ReturnQuotient(string dividendString, string divisorString)
        {
            // Arrange
            var valueCalculator = new DecimalValueCalculator();

            decimal dividend = decimal.Parse(dividendString);
            ushort divisor = ushort.Parse(divisorString);

            var expectedQuotient = dividend / divisor;

            // Act
            var actualQuotient = valueCalculator.Divide(dividend, divisor);

            // Assert
            Assert.AreEqual(expectedQuotient, actualQuotient);
        }

        [DataTestMethod]
        [DataRow("147.258", int.MaxValue)]
        [DataRow("25.458", 8)]
        [DataRow("13.131313", -31)]
        [DataRow("147.258", int.MinValue)]
        [DataRow("0", int.MaxValue)]
        [DataRow("0", 2)]
        [DataRow("0", -5)]
        [DataRow("0", int.MinValue)]
        [DataRow("-587.23654", int.MaxValue)]
        [DataRow("-57.123456789", 16)]
        [DataRow("-77.777", -28)]
        [DataRow("-1.578", int.MinValue)]
        public void WHEN_Dividing_WHILE_Divisor_Integer_THEN_ReturnQuotient(string dividendString, int divisor)
        {
            // Arrange
            var valueCalculator = new DecimalValueCalculator();

            decimal dividend = decimal.Parse(dividendString);

            var expectedQuotient = dividend / divisor;

            // Act
            var actualQuotient = valueCalculator.Divide(dividend, divisor);

            // Assert
            Assert.AreEqual(expectedQuotient, actualQuotient);
        }

        [DataTestMethod]
        [DataRow("147.258", uint.MaxValue)]
        [DataRow("25.458", 8U)]
        [DataRow("0", uint.MaxValue)]
        [DataRow("0", 2U)]
        [DataRow("-587.23654", uint.MaxValue)]
        [DataRow("-57.123456789", 16U)]
        public void WHEN_Dividing_WHILE_Divisor_UnsignedInteger_THEN_ReturnQuotient(string dividendString, uint divisor)
        {
            // Arrange
            var valueCalculator = new DecimalValueCalculator();

            decimal dividend = decimal.Parse(dividendString);

            var expectedQuotient = dividend / divisor;

            // Act
            var actualQuotient = valueCalculator.Divide(dividend, divisor);

            // Assert
            Assert.AreEqual(expectedQuotient, actualQuotient);
        }

        [DataTestMethod]
        [DataRow("147.258", long.MaxValue)]
        [DataRow("25.458", 8L)]
        [DataRow("13.131313", -31L)]
        [DataRow("147.258", long.MinValue)]
        [DataRow("0", long.MaxValue)]
        [DataRow("0", 2L)]
        [DataRow("0", -5L)]
        [DataRow("0", long.MinValue)]
        [DataRow("-587.23654", long.MaxValue)]
        [DataRow("-57.123456789", 16L)]
        [DataRow("-77.777", -28L)]
        [DataRow("-1.578", long.MinValue)]
        public void WHEN_Dividing_WHILE_Divisor_Long_THEN_ReturnQuotient(string dividendString, long divisor)
        {
            // Arrange
            var valueCalculator = new DecimalValueCalculator();

            decimal dividend = decimal.Parse(dividendString);

            var expectedQuotient = dividend / divisor;

            // Act
            var actualQuotient = valueCalculator.Divide(dividend, divisor);

            // Assert
            Assert.AreEqual(expectedQuotient, actualQuotient);
        }

        [DataTestMethod]
        [DataRow("147.258", ulong.MaxValue)]
        [DataRow("25.458", 8UL)]
        [DataRow("0", ulong.MaxValue)]
        [DataRow("0", 2UL)]
        [DataRow("-587.23654", ulong.MaxValue)]
        [DataRow("-57.123456789", 16UL)]
        public void WHEN_Dividing_WHILE_Divisor_UnsignedLong_THEN_ReturnQuotient(string dividendString, ulong divisor)
        {
            // Arrange
            var valueCalculator = new DecimalValueCalculator();

            decimal dividend = decimal.Parse(dividendString);

            var expectedQuotient = dividend / divisor;

            // Act
            var actualQuotient = valueCalculator.Divide(dividend, divisor);

            // Assert
            Assert.AreEqual(expectedQuotient, actualQuotient);
        }

        [DataTestMethod]
        [DataRow("25.458", 4.8753)]
        [DataRow("22.69841", -52.435724)]
        [DataRow("0", 2.321)]
        [DataRow("-32.9284", 88.93754)]
        [DataRow("-11.112", -2.365444)]
        public void WHEN_Dividing_WHILE_Divisor_Double_THEN_ReturnQuotient(string dividendString, double divisor)
        {
            // Arrange
            var valueCalculator = new DecimalValueCalculator();

            decimal dividend = decimal.Parse(dividendString);

            var expectedQuotient = dividend / Convert.ToDecimal(divisor);

            // Act
            var actualQuotient = valueCalculator.Divide(dividend, divisor);

            // Assert
            Assert.AreEqual(expectedQuotient, actualQuotient);
        }

        [DataTestMethod]
        [DataRow("25.458", "4.8753")]
        [DataRow("22.69841", "-52.435724")]
        [DataRow("0", "2.321")]
        [DataRow("0", "-5.68749")]
        [DataRow("-32.9284", "88.93754")]
        [DataRow("-11.112", "-2.365444")]
        public void WHEN_Dividing_WHILE_Divisor_Decimal_THEN_ReturnQuotient(string dividendString, string divisorString)
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
        [DataRow("25.458", 4.8753f)]
        [DataRow("22.69841", -52.435724f)]
        [DataRow("0", 2.321f)]
        [DataRow("0", -5.68749f)]
        [DataRow("-32.9284", 88.93754f)]
        [DataRow("-11.112", -2.365444f)]
        public void WHEN_Dividing_WHILE_Divisor_Float_THEN_ReturnQuotient(string dividendString, float divisor)
        {
            // Arrange
            var valueCalculator = new DecimalValueCalculator();

            decimal dividend = decimal.Parse(dividendString);

            var expectedQuotient = dividend / Convert.ToDecimal(divisor);

            // Act
            var actualQuotient = valueCalculator.Divide(dividend, divisor);

            // Assert
            Assert.AreEqual(expectedQuotient, actualQuotient);
        }
    }
}