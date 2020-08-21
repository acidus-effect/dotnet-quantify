﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quantify.Test.Assets;

namespace Quantify.UnitTests.Repository
{
    [TestClass]
    public class UnitDataTests
    {
        [TestMethod]
        public void WHEN_Instantiating_WHILE_ArgumentsAreValid_THEN_CreateInstance()
        {
            // Arrange
            const double expectedValue = 12.254;
            const string expectedUnit = "SomeUnit";

            // Act
            var unitData = new BasicUnitConversionData<double, string>(expectedValue, expectedUnit);

            // Assert
            Assert.AreEqual(expectedValue, unitData.ConversionRate);
            Assert.AreEqual(expectedUnit, unitData.Unit);
        }

        [TestMethod]
        public void WHEN_Instantiating_WHILE_ArgumentIsNull_THEN_ThrowException()
        {
            // Arrange
            const string expectedValue = "SomeValue";
            const string expectedUnit = "SomeUnit";

            // Act & Assert
            ExceptionHelpers.ExpectArgumentNullException("conversionRate", () => new BasicUnitConversionData<string, string>(null, expectedUnit));
            ExceptionHelpers.ExpectArgumentNullException("unit", () => new BasicUnitConversionData<string, string>(expectedValue, null));
        }
    }
}