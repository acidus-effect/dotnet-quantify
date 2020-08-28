using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quantify.UnitTests.Exceptions
{
    [TestClass]
    public class UnitNotFoundExceptionTests
    {
        [TestMethod]
        public void WHEN_Instantiating_WHILE_ArgumentsSet_THEN_CreateInstance()
        {
            // Arrange
            var expectedUnit = new object();

            // Act
            var exception = new UnitNotFoundException<object>(expectedUnit);

            // Assert
            Assert.AreSame(expectedUnit, exception.Unit);
        }

        [TestMethod]
        public void WHEN_Instantiating_WHILE_ArgumentsAreNull_THEN_CreateInstance()
        {
            // Act
            var exception = new UnitNotFoundException<object>(null);

            // Assert
            Assert.IsNull(exception.Unit);
        }
    }
}