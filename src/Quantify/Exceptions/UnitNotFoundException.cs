using System;
using System.Runtime.Serialization;

namespace Quantify
{
    /// <summary>
    /// Exception thrown to indicate that a quantity unit was not found.
    /// </summary>
    /// <typeparam name="TUnit">The type of the unit that was not found.</typeparam>
    [Serializable]
    public class UnitNotFoundException<TUnit> : Exception
    {
        private const string DefaultMessage = "No data was found for the unit.";

        /// <summary>
        /// The unit that was not found.
        /// </summary>
        public TUnit Unit { get; }

        /// <summary>
        /// Constructs a new instance of <see cref="UnitNotFoundException"/> with a unit.
        /// </summary>
        /// <param name="unit">The unit that was not found.</param>
        public UnitNotFoundException(TUnit unit) : base(DefaultMessage)
        {
            Unit = unit;
        }

        /// <summary>
        /// Constructor provided for serialization purposes.
        /// </summary>
        /// <param name="info">Serialization information</param>
        /// <param name="context">Context</param>
        protected UnitNotFoundException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}