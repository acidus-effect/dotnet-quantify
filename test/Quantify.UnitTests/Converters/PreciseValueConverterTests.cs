﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Quantify.Test.Assets;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quantify.UnitTests.Converters
{
    [TestClass]
    public class PreciseValueConverterTests
    {
        [TestMethod]
        public void WEHN_Instantiating_WHILE_ArgumentsAreValid_THEN_CreateInstance()
        {
            // Arrange
            var unitRepository = new Mock<UnitRepository<string>>().Object;
            var valueCalculator = new Mock<ValueCalculator<string>>().Object;

            // Act & Assert
            ExceptionHelpers.ExpectNoException(() => new PreciseValueConverter<string, string>(unitRepository, valueCalculator));
        }

        [TestMethod]
        public void WEHN_Instantiating_WHILE_ArgumentIsNull_THEN_ThrowException()
        {
            // Arrange
            var unitRepository = new Mock<UnitRepository<string>>().Object;
            var valueCalculator = new Mock<ValueCalculator<string>>().Object;

            // Act & Assert
            ExceptionHelpers.ExpectArgumentNullException("unitRepository", () => new PreciseValueConverter<string, string>(null, valueCalculator));
            ExceptionHelpers.ExpectArgumentNullException("valueCalculator", () => new PreciseValueConverter<string, string>(unitRepository, null));
        }

        [TestMethod]
        public void WHEN_ConvertingValue_WHILE_ArgumentIsNull_THEN_ThrowException()
        {
            // Arrange
            var value = "Some value";
            var sourceUnit = "Source unit";
            var targetUnit = "Target unit";

            var unitRepository = new Mock<UnitRepository<string>>().Object;
            var valueCalculator = new Mock<ValueCalculator<string>>().Object;

            var valueConverter = new PreciseValueConverter<string, string>(unitRepository, valueCalculator);

            // Act & Assert
            ExceptionHelpers.ExpectArgumentNullException("value", () => valueConverter.ConvertValueToUnit(null, sourceUnit, targetUnit));
            ExceptionHelpers.ExpectArgumentNullException("sourceUnit", () => valueConverter.ConvertValueToUnit(value, null, targetUnit));
            ExceptionHelpers.ExpectArgumentNullException("targetUnit", () => valueConverter.ConvertValueToUnit(value, sourceUnit, null));
        }

        [TestMethod]
        public void WHEN_ConvertingValue_WHILE_SourceAndTargetUnitIsTheSame_THEN_ReturnSaveValueInstance()
        {
            // Arrange
            var sourceValue = new Object();
            const string sourceUnit = "Some unit";
            const string targetUnit = sourceUnit;

            var unitRepository = new Mock<UnitRepository<string>>().Object;
            var valueCalculator = new Mock<ValueCalculator<object>>().Object;

            var valueConverter = new PreciseValueConverter<object, string>(unitRepository, valueCalculator);

            // Act
            var targetValue = valueConverter.ConvertValueToUnit(sourceValue, sourceUnit, targetUnit);

            // Assert
            Assert.AreEqual(sourceValue, targetValue);
        }

        [TestMethod]
        public void WHEN_ConvertingValue_WHILE_SourceAndTargetUnitIsDifferent_THEN_ReturnCalculatedValue()
        {
            // Arrange
            const decimal sourceValue = 123;
            const string sourceUnit = "Source unit";
            const decimal expectedTargetValue = 456;
            const string targetUnit = "Target unit";

            const decimal sourceUnitConversionValue = 1337;
            const decimal targetUnitConversionValue = 42;

            const decimal divisionResult = sourceUnitConversionValue / targetUnitConversionValue;

            var unitRepositoryMock = new Mock<UnitRepository<string>>();
            unitRepositoryMock.Setup(repository => repository.GetPreciseUnitConversionValue(It.Is<string>(unit => unit == sourceUnit))).Returns(sourceUnitConversionValue);
            unitRepositoryMock.Setup(repository => repository.GetPreciseUnitConversionValue(It.Is<string>(unit => unit == targetUnit))).Returns(targetUnitConversionValue);

            var valueCalculatorMock = new Mock<ValueCalculator<decimal>>();
            valueCalculatorMock.Setup(calculator => calculator.Multiply(It.Is<decimal>(value => value == sourceValue), It.Is<decimal>(value => value == divisionResult))).Returns(expectedTargetValue);

            var valueConverter = new PreciseValueConverter<decimal, string>(unitRepositoryMock.Object, valueCalculatorMock.Object);

            // Act
            var actualTargetValue = valueConverter.ConvertValueToUnit(sourceValue, sourceUnit, targetUnit);

            // Assert
            Assert.AreEqual(expectedTargetValue, actualTargetValue);

            unitRepositoryMock.Verify(repository => repository.GetPreciseUnitConversionValue(It.Is<string>(unit => unit == sourceUnit)), Times.Once);
            unitRepositoryMock.Verify(repository => repository.GetPreciseUnitConversionValue(It.Is<string>(unit => unit == targetUnit)), Times.Once);

            valueCalculatorMock.Verify(calculator => calculator.Multiply(It.Is<decimal>(value => value == sourceValue), It.Is<decimal>(value => value == divisionResult)), Times.Once);
        }

        [TestMethod]
        public void WHEN_ConvertingValue_WHILE_SourceUnitDoesNotExist_THEN_ThrowException()
        {
            const decimal sourceValue = 123;
            const string sourceUnit = "Source unit";
            const string targetUnit = "Target unit";

            // Arrange
            var unitRepositoryMock = new Mock<UnitRepository<string>>();
            unitRepositoryMock.Setup(repository => repository.GetPreciseUnitConversionValue(It.Is<string>(unit => unit == sourceUnit))).Returns((decimal?) null);

            var valueCalculatorMock = new Mock<ValueCalculator<decimal>>();

            var valueConverter = new PreciseValueConverter<decimal, string>(unitRepositoryMock.Object, valueCalculatorMock.Object);

            // Act & Assert
            ExceptionHelpers.ExpectException<UnitNotFoundException<string>>(
                () => valueConverter.ConvertValueToUnit(sourceValue, sourceUnit, targetUnit),
                exception => Assert.AreEqual(sourceUnit, exception.Unit)
            );
        }

        [TestMethod]
        public void WHEN_ConvertingValue_WHILE_TargetUnitDoesNotExist_THEN_ThrowException()
        {
            const decimal sourceValue = 123;
            const string sourceUnit = "Source unit";
            const string targetUnit = "Target unit";

            // Arrange
            var unitRepositoryMock = new Mock<UnitRepository<string>>();
            unitRepositoryMock.Setup(repository => repository.GetPreciseUnitConversionValue(It.Is<string>(unit => unit == sourceUnit))).Returns(0);
            unitRepositoryMock.Setup(repository => repository.GetPreciseUnitConversionValue(It.Is<string>(unit => unit == targetUnit))).Returns((decimal?)null);

            var valueCalculatorMock = new Mock<ValueCalculator<decimal>>();

            var valueConverter = new PreciseValueConverter<decimal, string>(unitRepositoryMock.Object, valueCalculatorMock.Object);

            // Act & Assert
            ExceptionHelpers.ExpectException<UnitNotFoundException<string>>(
                () => valueConverter.ConvertValueToUnit(sourceValue, sourceUnit, targetUnit),
                exception => Assert.AreEqual(targetUnit, exception.Unit)
            );
        }
    }
}