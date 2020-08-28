using System;
using System.Runtime.Serialization;

namespace Quantify
{
    /// <summary>
    /// Exception thrown to indicate that an inappropriate type argument was used for a type parameter to a generic type or method.
    /// </summary>
    [Serializable]
    public class GenericArgumentException : Exception
    {
        private const string DefaultMessage = "A generic argument is invalid.";

        /// <summary>
        /// The name of the argument.
        /// </summary>
        public virtual string ArgumentName { get; }

        /// <summary>
        /// The type of the provided argument.
        /// </summary>
        public virtual Type ArgumentType { get; }

        /// <summary>
        /// Constructs a new instance of <see cref="GenericArgumentException"/> with the given message.
        /// </summary>
        /// <param name="message">Message for the exception.</param>
        /// <param name="argumentName">The name of the argument.</param>
        /// <param name="argumentType">The type of the provided argument.</param>
        public GenericArgumentException(string message, string argumentName, Type argumentType)
            : base(message ?? DefaultMessage)
        {
            ArgumentName = argumentName;
            ArgumentType = argumentType;
        }

        /// <summary>
        /// Constructs a new instance of <see cref="GenericArgumentException"/> with the given message and inner exception.
        /// </summary>
        /// <param name="message">Message for the exception.</param>
        /// <param name="argumentName">The name of the argument.</param>
        /// <param name="argumentType">The type of the provided argument.</param>
        /// <param name="innerException">Inner exception.</param>
        public GenericArgumentException(string message, string argumentName, Type argumentType, Exception innerException)
            : base(message ?? DefaultMessage, innerException)
        {
            ArgumentName = argumentName;
            ArgumentType = argumentType;
        }

        /// <summary>
        /// Constructor provided for serialization purposes.
        /// </summary>
        /// <param name="info">Serialization information</param>
        /// <param name="context">Context</param>
        protected GenericArgumentException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}