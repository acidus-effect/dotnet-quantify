using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Quantify.UnitTests.Calculator
{
    [TestClass]
    public class DecimalMultiplicationTests
    {
        [DataTestMethod]
        [DataRow("254.1478", "32767")]
        [DataRow("25.458", "4")]
        [DataRow("25.458", "0")]
        [DataRow("22.69841", "-52")]
        [DataRow("254.1478", "-32768")]
        [DataRow("0", "32767")]
        [DataRow("0", "2")]
        [DataRow("0", "0")]
        [DataRow("0", "-5")]
        [DataRow("0", "-32768")]
        [DataRow("-571.123", "32767")]
        [DataRow("-32.9284", "88")]
        [DataRow("-26.456", "0")]
        [DataRow("-11.112", "-2")]
        [DataRow("-12.3456", "-32768")]
        public void WHEN_Multiplying_WHILE_Multiplier_Short_THEN_ReturnProduct(string multiplicandString, string multiplierString)
        {
            // Arrange
            var valueCalculator = new DecimalValueCalculator();

            decimal multiplicand = decimal.Parse(multiplicandString);
            short multiplier = short.Parse(multiplierString);

            var expectedProduct = multiplicand * multiplier;

            // Act
            var actualProduct = valueCalculator.Multiply(multiplicand, multiplier);

            // Assert
            Assert.AreEqual(expectedProduct, actualProduct);
        }

        [DataTestMethod]
        [DataRow("254.1478", "32767")]
        [DataRow("25.458", "4")]
        [DataRow("25.458", "0")]
        [DataRow("0", "32767")]
        [DataRow("0", "2")]
        [DataRow("0", "0")]
        [DataRow("-571.123", "32767")]
        [DataRow("-32.9284", "88")]
        [DataRow("-26.456", "0")]
        public void WHEN_Multiplying_WHILE_Multiplier_UnsignedShort_THEN_ReturnProduct(string multiplicandString, string multiplierString)
        {
            // Arrange
            var valueCalculator = new DecimalValueCalculator();

            decimal multiplicand = decimal.Parse(multiplicandString);
            ushort multiplier = ushort.Parse(multiplierString);

            var expectedProduct = multiplicand * multiplier;

            // Act
            var actualProduct = valueCalculator.Multiply(multiplicand, multiplier);

            // Assert
            Assert.AreEqual(expectedProduct, actualProduct);
        }

        [DataTestMethod]
        [DataRow("147.258", int.MaxValue)]
        [DataRow("25.458", 8)]
        [DataRow("25.458", 0)]
        [DataRow("13.131313", -31)]
        [DataRow("147.258", int.MinValue)]
        [DataRow("0", int.MaxValue)]
        [DataRow("0", 2)]
        [DataRow("0", 0)]
        [DataRow("0", -5)]
        [DataRow("0", int.MinValue)]
        [DataRow("-587.23654", int.MaxValue)]
        [DataRow("-57.123456789", 16)]
        [DataRow("-26.456", 0)]
        [DataRow("-77.777", -28)]
        [DataRow("-1.578", int.MinValue)]
        public void WHEN_Multiplying_WHILE_Multiplier_Integer_THEN_ReturnProduct(string multiplicandString, int multiplier)
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
        [DataRow("147.258", uint.MaxValue)]
        [DataRow("25.458", 8U)]
        [DataRow("25.458", 0U)]
        [DataRow("0", uint.MaxValue)]
        [DataRow("0", 2U)]
        [DataRow("0", 0U)]
        [DataRow("-587.23654", uint.MaxValue)]
        [DataRow("-57.123456789", 16U)]
        [DataRow("-26.456", 0U)]
        public void WHEN_Multiplying_WHILE_Multiplier_UnsignedInteger_THEN_ReturnProduct(string multiplicandString, uint multiplier)
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
        [DataRow("147.258", long.MaxValue)]
        [DataRow("25.458", 8L)]
        [DataRow("25.458", 0L)]
        [DataRow("13.131313", -31L)]
        [DataRow("147.258", long.MinValue)]
        [DataRow("0", long.MaxValue)]
        [DataRow("0", 2L)]
        [DataRow("0", 0L)]
        [DataRow("0", -5L)]
        [DataRow("0", long.MinValue)]
        [DataRow("-587.23654", long.MaxValue)]
        [DataRow("-57.123456789", 16L)]
        [DataRow("-26.456", 0L)]
        [DataRow("-77.777", -28L)]
        [DataRow("-1.578", long.MinValue)]
        public void WHEN_Multiplying_WHILE_Multiplier_Long_THEN_ReturnProduct(string multiplicandString, long multiplier)
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
        [DataRow("147.258", ulong.MaxValue)]
        [DataRow("25.458", 8UL)]
        [DataRow("25.458", 0UL)]
        [DataRow("0", ulong.MaxValue)]
        [DataRow("0", 2UL)]
        [DataRow("0", 0UL)]
        [DataRow("-587.23654", ulong.MaxValue)]
        [DataRow("-57.123456789", 16UL)]
        [DataRow("-26.456", 0UL)]
        public void WHEN_Multiplying_WHILE_Multiplier_UnsignedLong_THEN_ReturnProduct(string multiplicandString, ulong multiplier)
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
        [DataRow("25.458", 4.8753)]
        [DataRow("25.458", 0)]
        [DataRow("22.69841", -52.435724)]
        [DataRow("0", 2.321)]
        [DataRow("0", 0)]
        [DataRow("-32.9284", 88.93754)]
        [DataRow("-26.456", 0)]
        [DataRow("-11.112", -2.365444)]
        public void WHEN_Multiplying_WHILE_Multiplier_Double_THEN_ReturnProduct(string multiplicandString, double multiplier)
        {
            // Arrange
            var valueCalculator = new DecimalValueCalculator();

            decimal multiplicand = decimal.Parse(multiplicandString);

            var expectedProduct = multiplicand * Convert.ToDecimal(multiplier);

            // Act
            var actualProduct = valueCalculator.Multiply(multiplicand, multiplier);

            // Assert
            Assert.AreEqual(expectedProduct, actualProduct);
        }

        [DataTestMethod]
        [DataRow("25.458", "4.8753")]
        [DataRow("25.458", "0")]
        [DataRow("22.69841", "-52.435724")]
        [DataRow("0", "2.321")]
        [DataRow("0", "0")]
        [DataRow("0", "-5.68749")]
        [DataRow("-32.9284", "88.93754")]
        [DataRow("-26.456", "0")]
        [DataRow("-11.112", "-2.365444")]
        public void WHEN_Multiplying_WHILE_Multiplier_Decimal_THEN_ReturnProduct(string multiplicandString, string multiplierString)
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
        [DataRow("25.458", 4.8753f)]
        [DataRow("25.458", 0f)]
        [DataRow("22.69841", -52.435724f)]
        [DataRow("0", 2.321f)]
        [DataRow("0", 0f)]
        [DataRow("0", -5.68749f)]
        [DataRow("-32.9284", 88.93754f)]
        [DataRow("-26.456", 0f)]
        [DataRow("-11.112", -2.365444f)]
        public void WHEN_Multiplying_WHILE_Multiplier_Float_THEN_ReturnProduct(string multiplicandString, float multiplier)
        {
            // Arrange
            var valueCalculator = new DecimalValueCalculator();

            decimal multiplicand = decimal.Parse(multiplicandString);

            var expectedProduct = multiplicand * Convert.ToDecimal(multiplier);

            // Act
            var actualProduct = valueCalculator.Multiply(multiplicand, multiplier);

            // Assert
            Assert.AreEqual(expectedProduct, actualProduct);
        }
    }
}