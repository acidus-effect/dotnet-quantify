using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quantify.Test.Assets;

namespace Quantify.UnitTests.Calculator
{
    [TestClass]
    public class ValueCalculatorFactoryTests
    {
        [TestMethod]
        public void WHEN_Instantiating_WHILE_ArgumentTypeIsDouble_THEN_ReturnDoubleValueCalculatorInstance()
        {
            // Act
            var valueCalculator = ValueCalculatorFactory.Create<double>();

            // Assert
            Assert.IsInstanceOfType(valueCalculator, typeof(DoubleValueCalculator));
        }

        [TestMethod]
        public void WHEN_Instantiating_WHILE_ArgumentTypeIsDecimal_THEN_ReturnDecimalValueCalculatorInstance()
        {
            // Act
            var valueCalculator = ValueCalculatorFactory.Create<decimal>();

            // Assert
            Assert.IsInstanceOfType(valueCalculator, typeof(DecimalValueCalculator));
        }

        [TestMethod]
        public void WHEN_Instantiating_WHILE_ArgumentTypeIsInvalid_THEN_ThrowException()
        {
            // Act & Assert
            ExceptionHelpers.ExpectException<GenericArgumentException>(() => ValueCalculatorFactory.Create<string>(), exception => Assert.AreEqual("TValue", exception.ArgumentName));
        }
    }
}