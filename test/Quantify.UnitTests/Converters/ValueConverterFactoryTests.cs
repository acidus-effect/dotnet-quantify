using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Quantify.Test.Assets;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quantify.UnitTests.Converters
{
    [TestClass]
    public class ValueConverterFactoryTests
    {
        [TestMethod]
        public void WHEN_Instantiating_WHILE_ArgumentsAreValid_THEN_CreateInstance()
        {
            // Arrange
            var unitRepositoryMock = new Mock<UnitRepository<string>>();
            var valueCalculatorMock = new Mock<ValueCalculator<double>>();

            // Act
            new ValueConverterFactory<double, string>(unitRepositoryMock.Object, valueCalculatorMock.Object);
        }

        [TestMethod]
        public void WHEN_Instantiating_WHILE_ArgumentIsNull_THEN_ThrowException()
        {
            // Arrange
            var unitRepositoryMock = new Mock<UnitRepository<string>>();
            var valueCalculatorMock = new Mock<ValueCalculator<double>>();

            // Act
            ExceptionHelpers.ExpectArgumentNullException("unitRepository", () => new ValueConverterFactory<double, string>(null, valueCalculatorMock.Object));
            ExceptionHelpers.ExpectArgumentNullException("valueCalculator", () => new ValueConverterFactory<double, string>(unitRepositoryMock.Object, null));
        }

        [TestMethod]
        public void WHEN_CreatingConverter_WHILE_TypeArgumentIsDecimal_THEN_ReturnDecimalBasedConverter()
        {
            // Arrange
            var unitRepositoryMock = new Mock<UnitRepository<string>>();
            var valueCalculatorMock = new Mock<ValueCalculator<decimal>>();

            var valueConverterFactory = new ValueConverterFactory<decimal, string>(unitRepositoryMock.Object, valueCalculatorMock.Object);

            // Act
            var converter = valueConverterFactory.Create();

            // Assert
            Assert.IsTrue(converter.GetType() == typeof(PreciseValueConverter<decimal, string>));
        }

        [TestMethod]
        public void WHEN_CreatingConverter_WHILE_TypeArgumentIsInt_THEN_ReturnDoubleBasedConverter()
        {
            // Arrange
            var unitRepositoryMock = new Mock<UnitRepository<string>>();
            var valueCalculatorMock = new Mock<ValueCalculator<int>>();

            var valueConverterFactory = new ValueConverterFactory<int, string>(unitRepositoryMock.Object, valueCalculatorMock.Object);

            // Act
            var converter = valueConverterFactory.Create();

            // Assert
            Assert.IsTrue(converter.GetType() == typeof(RegularValueConverter<int, string>));
        }

        [TestMethod]
        public void WHEN_CreatingConverter_WHILE_TypeArgumentIsDouble_THEN_ReturnDoubleBasedConverter()
        {
            // Arrange
            var unitRepositoryMock = new Mock<UnitRepository<string>>();
            var valueCalculatorMock = new Mock<ValueCalculator<double>>();

            var valueConverterFactory = new ValueConverterFactory<double, string>(unitRepositoryMock.Object, valueCalculatorMock.Object);

            // Act
            var converter = valueConverterFactory.Create();

            // Assert
            Assert.IsTrue(converter.GetType() == typeof(RegularValueConverter<double, string>));
        }
    }
}