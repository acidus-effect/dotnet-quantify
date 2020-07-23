using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Quantify.UnitTests.Exceptions
{
    [TestClass]
    public class GenericArgumentExceptionTests
    {
        [TestMethod]
        public void WHILE_MessageIsNull_WHEN_Instantiating_Message_ArgumentName_ArgumentType_THEN_HasDefaultMessage()
        {
            // Arrange
            const string message = null;
            const string expectedMessage = "A generic argument is invalid.";
            const string expectedArgumentName = "Some argument name";
            Type expectedArgumentType = typeof(GenericArgumentException);

            // Act
            var exception = new GenericArgumentException(message, expectedArgumentName, expectedArgumentType);

            // Assert
            Assert.AreEqual(expectedMessage, exception.Message);
            Assert.AreEqual(expectedArgumentName, exception.ArgumentName);
            Assert.AreSame(expectedArgumentType, exception.ArgumentType);
        }

        [TestMethod]
        public void WHILE_ArgumentNameIsNull_WHEN_Instantiating_Message_ArgumentName_ArgumentType_THEN_ArgumentNameIsNull()
        {
            // Arrange
            const string expectedMessage = "Some exception message";
            const string argumentName = null;
            Type expectedArgumentType = typeof(GenericArgumentException);

            // Act
            var exception = new GenericArgumentException(expectedMessage, argumentName, expectedArgumentType);

            // Assert
            Assert.AreEqual(expectedMessage, exception.Message);
            Assert.IsNull(exception.ArgumentName);
            Assert.AreSame(expectedArgumentType, exception.ArgumentType);
        }

        [TestMethod]
        public void WHILE_ArgumentTypeIsNull_WHEN_Instantiating_Message_ArgumentName_ArgumentType_THEN_ArgumentTypeIsNull()
        {
            // Arrange
            const string expectedMessage = "Some exception message";
            const string expectedArgumentName = "Some argument name";
            Type argumentType = null;

            // Act
            var exception = new GenericArgumentException(expectedMessage, expectedArgumentName, argumentType);

            // Assert
            Assert.AreEqual(expectedMessage, exception.Message);
            Assert.AreEqual(expectedArgumentName, exception.ArgumentName);
            Assert.IsNull(exception.ArgumentType);
        }

        [TestMethod]
        public void WHILE_MessageIsNull_WHEN_Instantiating_Message_ArgumentName_ArgumentType_InnerException_THEN_HasDefaultMessage()
        {
            // Arrange
            const string message = null;
            const string expectedMessage = "A generic argument is invalid.";
            const string expectedArgumentName = "Some argument name";
            Type expectedArgumentType = typeof(GenericArgumentException);
            Exception expectedInnerException = new ArgumentException();

            // Act
            var exception = new GenericArgumentException(message, expectedArgumentName, expectedArgumentType, expectedInnerException);

            // Assert
            Assert.AreEqual(expectedMessage, exception.Message);
            Assert.AreEqual(expectedArgumentName, exception.ArgumentName);
            Assert.AreSame(expectedArgumentType, exception.ArgumentType);
            Assert.AreSame(expectedInnerException, exception.InnerException);
        }

        [TestMethod]
        public void WHILE_ArgumentNameIsNull_WHEN_Instantiating_Message_ArgumentName_ArgumentType_InnerException_THEN_ArgumentNameIsNull()
        {
            // Arrange
            const string expectedMessage = "Some exception message";
            const string argumentName = null;
            Type expectedArgumentType = typeof(GenericArgumentException);
            Exception expectedInnerException = new ArgumentException();

            // Act
            var exception = new GenericArgumentException(expectedMessage, argumentName, expectedArgumentType, expectedInnerException);

            // Assert
            Assert.AreEqual(expectedMessage, exception.Message);
            Assert.IsNull(exception.ArgumentName);
            Assert.AreSame(expectedArgumentType, exception.ArgumentType);
            Assert.AreSame(expectedInnerException, exception.InnerException);
        }

        [TestMethod]
        public void WHILE_ArgumentTypeIsNull_WHEN_Instantiating_Message_ArgumentName_ArgumentType_InnerException_THEN_ArgumentTypeIsNull()
        {
            // Arrange
            const string expectedMessage = "Some exception message";
            const string expectedArgumentName = "Some argument name";
            Type argumentType = null;
            Exception expectedInnerException = new ArgumentException();

            // Act
            var exception = new GenericArgumentException(expectedMessage, expectedArgumentName, argumentType, expectedInnerException);

            // Assert
            Assert.AreEqual(expectedMessage, exception.Message);
            Assert.AreEqual(expectedArgumentName, exception.ArgumentName);
            Assert.IsNull(exception.ArgumentType);
            Assert.AreSame(expectedInnerException, exception.InnerException);
        }

        [TestMethod]
        public void WHILE_InnerExceptionIsNull_WHEN_Instantiating_Message_ArgumentName_ArgumentType_InnerException_THEN_InnerExceptionIsNull()
        {
            // Arrange
            const string expectedMessage = "Some exception message";
            const string expectedArgumentName = "Some argument name";
            Type expectedArgumentType = typeof(GenericArgumentException);
            Exception innerException = null;

            // Act
            var exception = new GenericArgumentException(expectedMessage, expectedArgumentName, expectedArgumentType, innerException);

            // Assert
            Assert.AreEqual(expectedMessage, exception.Message);
            Assert.AreEqual(expectedArgumentName, exception.ArgumentName);
            Assert.AreSame(expectedArgumentType, exception.ArgumentType);
            Assert.IsNull(exception.InnerException);
        }
    }
}