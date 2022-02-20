using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Quantify.Test.IntegrationTest.Converters
{
    [TestClass]
    public class RegularValueConverterTests
    {
        [TestMethod]
        public void WHEN_ConvertingValue_WHILE_SourceAndTargetUnitIsDifferent_THEN_ReturnCalculatedValue()
        {
            // Arrange
            const string sourceUnit = "Source unit";
            const string targetUnit = "Target unit";

            var sourceUnitValueInBaseUnits = 10d;
            var targetUnitValueInBaseUnits = 0.01d;

            var sourceValue = 10;
            var expectedConvertedValue = 10000;

            var unitRepositoryMock = new Mock<UnitRepository<string>>();
            unitRepositoryMock.Setup(repository => repository.GetUnitValueInBaseUnits(It.Is<string>(unit => unit == sourceUnit))).Returns(sourceUnitValueInBaseUnits);
            unitRepositoryMock.Setup(repository => repository.GetUnitValueInBaseUnits(It.Is<string>(unit => unit == targetUnit))).Returns(targetUnitValueInBaseUnits);

            var valueConverter = new RegularValueConverter<decimal, string>(unitRepositoryMock.Object, new DecimalValueCalculator());

            // Act
            var actualConvertedValue = valueConverter.ConvertValueToUnit(sourceValue, sourceUnit, targetUnit);

            // Assert
            Assert.AreEqual(expectedConvertedValue, actualConvertedValue);
        }
    }
}