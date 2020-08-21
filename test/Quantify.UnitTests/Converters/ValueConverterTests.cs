using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Quantify.Test.Assets;

namespace Quantify.UnitTests.Converters
{
    [TestClass]
    public class ValueConverterTests
    {
        [TestMethod]
        public void WHEN_Instantiating_WHILE_ArgumentIsNull_THEN_ThrowException()
        {
            // Arrange
            UnitConversionDataRepository<string> unitRepository = new Mock<UnitConversionDataRepository<string>>().Object;
            ValueCalculator<double> valueCalculator = new Mock<ValueCalculator<double>>().Object;

            // Act and Assert
            ExceptionHelpers.ExpectArgumentNullException("unitRepository", () => new ValueConverter<double, string>(null, valueCalculator));
            ExceptionHelpers.ExpectArgumentNullException("valueCalculator", () => new ValueConverter<double, string>(unitRepository, null));
        }

        [TestMethod]
        public void WHEN_ConvertingValue_WHILE_SourceAndTargetUnitsAreEqual_THEN_ReturnSameValue()
        {
            // Arrange
            const double sourceValue = 42.52;
            const string sourceUnit = "Hello";
            const string targetUnit = sourceUnit;

            var valueConverter = ValueConverterBuilder<double, string>.NewInstance().Build();

            // Act
            var targetValue = valueConverter.ConvertValueToUnit(sourceValue, sourceUnit, targetUnit);

            // Assert
            Assert.AreEqual(sourceValue, targetValue);
        }

        [TestMethod]
        public void WHEN_ConvertingValue_WHILE_SourceAndTargetUnitsAreDifferent_THEN_ReturnConvertedValue()
        {
            // Arrange
            const double sourceValue = 12.3456789;
            const double targetValue = 12345.6789;

            const string sourceUnit = "Hello";
            const string targetUnit = "World";

            const double sourceUnitRate = 1000;
            const double targetUnitRate = 1;

            const double divisionResult = 1337;

            var sourceUnitRateDataMock = new Mock<UnitConversionData<double, string>>();
            sourceUnitRateDataMock.Setup(unitData => unitData.ConversionRate).Returns(sourceUnitRate);

            var targetUnitRateDataMock = new Mock<UnitConversionData<double, string>>();
            targetUnitRateDataMock.Setup(unitData => unitData.ConversionRate).Returns(targetUnitRate);

            var valueConverterBuilder = ValueConverterBuilder<double, string>.NewInstance()
                .MockUnitRepository(mock => mock.Setup(unitRepository => unitRepository.GetUnitConversionData(It.Is<string>(unit => unit == sourceUnit))).Returns(sourceUnitRateDataMock.Object))
                .MockUnitRepository(mock => mock.Setup(unitRepository => unitRepository.GetUnitConversionData(It.Is<string>(unit => unit == targetUnit))).Returns(targetUnitRateDataMock.Object))
                .MockValueCalculator(mock => mock.Setup(valueCalculator => valueCalculator.Divide(It.Is<double>(sourceRate => sourceRate == sourceUnitRate), It.Is<double>(targetRate => targetRate == targetUnitRate))).Returns(divisionResult))
                .MockValueCalculator(mock => mock.Setup(valueCalculator => valueCalculator.Multiply(It.Is<double>(value => value == sourceValue), It.Is<double>(value => value == divisionResult))).Returns(targetValue));

            var valueConverter = valueConverterBuilder.Build();

            // Act
            var convertedValue = valueConverter.ConvertValueToUnit(sourceValue, sourceUnit, targetUnit);

            // Assert
            Assert.AreEqual(targetValue, convertedValue);
            valueConverterBuilder.UnitRepositoryMock.Verify(unitRepository => unitRepository.GetUnitConversionData(It.Is<string>(unit => unit == sourceUnit)), Times.Once);
            valueConverterBuilder.UnitRepositoryMock.Verify(unitRepository => unitRepository.GetUnitConversionData(It.Is<string>(unit => unit == targetUnit)), Times.Once);
            valueConverterBuilder.ValueCalculatorMock.Verify(verifyCalculator => verifyCalculator.Divide(It.Is<double>(sourceRate => sourceRate == sourceUnitRate), It.Is<double>(targetRate => targetRate == targetUnitRate)), Times.Once);
            valueConverterBuilder.ValueCalculatorMock.Verify(verifyCalculator => verifyCalculator.Multiply(It.Is<double>(value => value == sourceValue), It.Is<double>(value => value == divisionResult)), Times.Once);
        }
    }
}