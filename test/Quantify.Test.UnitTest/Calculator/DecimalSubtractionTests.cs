using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Quantify.Test.UnitTest.Calculator;

[TestClass]
public class DecimalSubtractionTests
{
    private readonly DecimalValueCalculator _valueCalculator = new();
    
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
    public void WHEN_SubtrahendIsShort_THEN_ReturnDifference(string minuendString, string subtrahendString)
    {
        // Arrange
        var minuend = decimal.Parse(minuendString);
        var subtrahend = short.Parse(subtrahendString);

        var expectedDifference = minuend - subtrahend;

        // Act
        var actualDifference = _valueCalculator.Subtract(minuend, subtrahend);

        // Assert
        Assert.AreEqual(expectedDifference, actualDifference);
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
    public void WHEN_SubtrahendIsUnsignedShort_THEN_ReturnDifference(string minuendString, string subtrahendString)
    {
        // Arrange
        var minuend = decimal.Parse(minuendString);
        var subtrahend = ushort.Parse(subtrahendString);

        var expectedDifference = minuend - subtrahend;

        // Act
        var actualDifference = _valueCalculator.Subtract(minuend, subtrahend);

        // Assert
        Assert.AreEqual(expectedDifference, actualDifference);
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
    public void WHEN_SubtrahendIsInteger_THEN_ReturnDifference(string minuendString, int subtrahend)
    {
        // Arrange
        var minuend = decimal.Parse(minuendString);

        var expectedDifference = minuend - subtrahend;

        // Act
        var actualDifference = _valueCalculator.Subtract(minuend, subtrahend);

        // Assert
        Assert.AreEqual(expectedDifference, actualDifference);
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
    public void WHEN_SubtrahendIsUnsignedInteger_THEN_ReturnDifference(string minuendString, uint subtrahend)
    {
        // Arrange
        var minuend = decimal.Parse(minuendString);

        var expectedDifference = minuend - subtrahend;

        // Act
        var actualDifference = _valueCalculator.Subtract(minuend, subtrahend);

        // Assert
        Assert.AreEqual(expectedDifference, actualDifference);
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
    public void WHEN_SubtrahendIsLong_THEN_ReturnDifference(string minuendString, long subtrahend)
    {
        // Arrange
        var minuend = decimal.Parse(minuendString);

        var expectedDifference = minuend - subtrahend;

        // Act
        var actualDifference = _valueCalculator.Subtract(minuend, subtrahend);

        // Assert
        Assert.AreEqual(expectedDifference, actualDifference);
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
    public void WHEN_SubtrahendIsUnsignedLong_THEN_ReturnDifference(string minuendString, ulong subtrahend)
    {
        // Arrange
        var minuend = decimal.Parse(minuendString);

        var expectedDifference = minuend - subtrahend;

        // Act
        var actualDifference = _valueCalculator.Subtract(minuend, subtrahend);

        // Assert
        Assert.AreEqual(expectedDifference, actualDifference);
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
    public void WHEN_SubtrahendIsDouble_THEN_ReturnDifference(string minuendString, double subtrahend)
    {
        // Arrange
        var minuend = decimal.Parse(minuendString);

        var expectedDifference = minuend - Convert.ToDecimal(subtrahend);

        // Act
        var actualDifference = _valueCalculator.Subtract(minuend, subtrahend);

        // Assert
        Assert.AreEqual(expectedDifference, actualDifference);
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
    public void WHEN_SubtrahendIsDecimal_THEN_ReturnDifference(string minuendString, string subtrahendString)
    {
        // Arrange
        var minuend = decimal.Parse(minuendString);
        var subtrahend = decimal.Parse(subtrahendString);

        var expectedDifference = minuend - subtrahend;

        // Act
        var actualDifference = _valueCalculator.Subtract(minuend, subtrahend);

        // Assert
        Assert.AreEqual(expectedDifference, actualDifference);
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
    public void WHEN_SubtrahendIsFloat_THEN_ReturnDifference(string minuendString, float subtrahend)
    {
        // Arrange
        var minuend = decimal.Parse(minuendString);

        var expectedDifference = minuend - Convert.ToDecimal(subtrahend);

        // Act
        var actualDifference = _valueCalculator.Subtract(minuend, subtrahend);

        // Assert
        Assert.AreEqual(expectedDifference, actualDifference);
    }
}