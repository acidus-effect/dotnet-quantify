﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Quantify.Test.Assets;
using System;

namespace Quantify.Test.UnitTest.Converters
{
    [TestClass]
    public class RegularValueConverterTests
    {
        [TestMethod]
        public void WEHN_Instantiating_WHILE_ArgumentsAreValid_THEN_CreateInstance()
        {
            // Arrange
            var unitRepository = new Mock<UnitRepository<string>>().Object;
            var valueCalculator = new Mock<ValueCalculator<string>>().Object;

            // Act & Assert
            ExceptionHelpers.ExpectNoException(() => new RegularValueConverter<string, string>(unitRepository, valueCalculator));
        }

        [TestMethod]
        public void WEHN_Instantiating_WHILE_ArgumentIsNull_THEN_ThrowException()
        {
            // Arrange
            var unitRepository = new Mock<UnitRepository<string>>().Object;
            var valueCalculator = new Mock<ValueCalculator<string>>().Object;

            // Act & Assert
            ExceptionHelpers.ExpectArgumentNullException("unitRepository", () => new RegularValueConverter<string, string>(null, valueCalculator));
            ExceptionHelpers.ExpectArgumentNullException("valueCalculator", () => new RegularValueConverter<string, string>(unitRepository, null));
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

            var valueConverter = new RegularValueConverter<string, string>(unitRepository, valueCalculator);

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

            var valueConverter = new RegularValueConverter<object, string>(unitRepository, valueCalculator);

            // Act
            var targetValue = valueConverter.ConvertValueToUnit(sourceValue, sourceUnit, targetUnit);

            // Assert
            Assert.AreSame(sourceValue, targetValue);
        }

        [TestMethod]
        public void WHEN_ConvertingValue_WHILE_SourceUnitDoesNotExist_THEN_ThrowException()
        {
            const double sourceValue = 123;
            const string sourceUnit = "Source unit";
            const string targetUnit = "Target unit";

            // Arrange
            var unitRepositoryMock = new Mock<UnitRepository<string>>();
            unitRepositoryMock.Setup(repository => repository.GetUnitValueInBaseUnits(It.Is<string>(unit => unit == sourceUnit))).Returns((double?)null);

            var valueCalculatorMock = new Mock<ValueCalculator<double>>();

            var valueConverter = new RegularValueConverter<double, string>(unitRepositoryMock.Object, valueCalculatorMock.Object);

            // Act & Assert
            ExceptionHelpers.ExpectException<UnitNotFoundException<string>>(
                () => valueConverter.ConvertValueToUnit(sourceValue, sourceUnit, targetUnit),
                exception => Assert.AreEqual(sourceUnit, exception.Unit)
            );
        }

        [TestMethod]
        public void WHEN_ConvertingValue_WHILE_TargetUnitDoesNotExist_THEN_ThrowException()
        {
            const double sourceValue = 123;
            const string sourceUnit = "Source unit";
            const string targetUnit = "Target unit";

            // Arrange
            var unitRepositoryMock = new Mock<UnitRepository<string>>();
            unitRepositoryMock.Setup(repository => repository.GetUnitValueInBaseUnits(It.Is<string>(unit => unit == sourceUnit))).Returns(0);
            unitRepositoryMock.Setup(repository => repository.GetUnitValueInBaseUnits(It.Is<string>(unit => unit == targetUnit))).Returns((double?)null);

            var valueCalculatorMock = new Mock<ValueCalculator<double>>();

            var valueConverter = new RegularValueConverter<double, string>(unitRepositoryMock.Object, valueCalculatorMock.Object);

            // Act & Assert
            ExceptionHelpers.ExpectException<UnitNotFoundException<string>>(
                () => valueConverter.ConvertValueToUnit(sourceValue, sourceUnit, targetUnit),
                exception => Assert.AreEqual(targetUnit, exception.Unit)
            );
        }
    }
}