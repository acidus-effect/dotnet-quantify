using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quantify.Test.Assets;

namespace Quantify.Test.UnitTest.Calculator
{
    [TestClass]
    public class ValueCalculatorFactoryTests
    {
        [TestMethod]
        public void WHEN_Instantiating_WHILE_ArgumentType_Double_THEN_ReturnCorrectInstance()
        {
            // Act
            var valueCalculator = ValueCalculatorFactory.Create<double>();

            // Assert
            Assert.IsInstanceOfType(valueCalculator, typeof(DoubleValueCalculator));
        }

        [TestMethod]
        public void WHEN_Instantiating_WHILE_ArgumentType_Decimal_THEN_ReturnCorrectInstance()
        {
            // Act
            var valueCalculator = ValueCalculatorFactory.Create<decimal>();

            // Assert
            Assert.IsInstanceOfType(valueCalculator, typeof(DecimalValueCalculator));
        }

        [TestMethod]
        public void WHEN_Instantiating_WHILE_ArgumentType_Invalid_THEN_ThrowException()
        {
            // Act & Assert
            ExceptionHelpers.ExpectException<GenericArgumentException>(() => ValueCalculatorFactory.Create<string>(), exception => Assert.AreEqual("TValue", exception.ArgumentName));
        }
    }
}