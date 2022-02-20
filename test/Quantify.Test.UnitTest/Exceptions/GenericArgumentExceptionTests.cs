using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quantify.Test.Assets;
using System;

namespace Quantify.Test.UnitTest.Exceptions
{
    [TestClass]
    public class GenericArgumentExceptionTests
    {
        [TestMethod]
        public void WHEN_Instantiating_Message_ArgumentName_ArgumentType_WHILE_ArgumentsAreSet_THEN_CreateInstance()
        {
            // Arrange
            const string expectedMessage = "Some exception message";
            const string expectedArgumentName = "Some argument name";
            Type expectedArgumentType = typeof(GenericArgumentException);

            // Act
            var exception = new GenericArgumentException(expectedMessage, expectedArgumentName, expectedArgumentType);

            // Assert
            Assert.AreEqual(expectedMessage, exception.Message);
            Assert.AreEqual(expectedArgumentName, exception.ArgumentName);
            Assert.AreSame(expectedArgumentType, exception.ArgumentType);
            Assert.IsNull(exception.InnerException);
        }

        [TestMethod]
        public void WHEN_Instantiating_Message_ArgumentName_ArgumentType_WHILE_MessageIsNull_THEN_HasDefaultMessage()
        {
            // Arrange
            const string expectedMessage = "A generic argument is invalid.";
            const string expectedArgumentName = "Some argument name";
            Type expectedArgumentType = typeof(GenericArgumentException);

            // Act
            var exception = new GenericArgumentException(null, expectedArgumentName, expectedArgumentType);

            // Assert
            Assert.AreEqual(expectedMessage, exception.Message);
            Assert.AreEqual(expectedArgumentName, exception.ArgumentName);
            Assert.AreSame(expectedArgumentType, exception.ArgumentType);
            Assert.IsNull(exception.InnerException);
        }

        [TestMethod]
        public void WHEN_Instantiating_Message_ArgumentName_ArgumentType_WHILE_AllArgumentAreNull_THEN_ThrowNoException()
        {
            // Act & Assert
            ExceptionHelpers.ExpectNoException(() => new GenericArgumentException(null, null, null));
        }

        [TestMethod]
        public void WHEN_Instantiating_Message_ArgumentName_ArgumentType_InnerException_WHILE_ArgumentsAreSet_THEN_CreateInstance()
        {
            // Arrange
            const string expectedMessage = "Some exception message";
            const string expectedArgumentName = "Some argument name";
            Type expectedArgumentType = typeof(GenericArgumentException);
            Exception expectedInnerException = new ArgumentException();

            // Act
            var exception = new GenericArgumentException(expectedMessage, expectedArgumentName, expectedArgumentType, expectedInnerException);

            // Assert
            Assert.AreEqual(expectedMessage, exception.Message);
            Assert.AreEqual(expectedArgumentName, exception.ArgumentName);
            Assert.AreSame(expectedArgumentType, exception.ArgumentType);
            Assert.AreSame(expectedInnerException, exception.InnerException);
        }

        [TestMethod]
        public void WHEN_Instantiating_Message_ArgumentName_ArgumentType_InnerException_WHILE_MessageIsNull_THEN_HasDefaultMessage()
        {
            // Arrange
            const string expectedMessage = "A generic argument is invalid.";
            const string expectedArgumentName = "Some argument name";
            Type expectedArgumentType = typeof(GenericArgumentException);
            Exception expectedInnerException = new ArgumentException();

            // Act
            var exception = new GenericArgumentException(null, expectedArgumentName, expectedArgumentType, expectedInnerException);

            // Assert
            Assert.AreEqual(expectedMessage, exception.Message);
            Assert.AreEqual(expectedArgumentName, exception.ArgumentName);
            Assert.AreSame(expectedArgumentType, exception.ArgumentType);
            Assert.AreSame(expectedInnerException, exception.InnerException);
        }

        [TestMethod]
        public void WHEN_Instantiating_Message_ArgumentName_ArgumentType_InnerException_WHILE_AllArgumentAreNull_THEN_ThrowNoException()
        {
            // Act & Assert
            ExceptionHelpers.ExpectNoException(() => new GenericArgumentException(null, null, null, null));
        }
    }
}