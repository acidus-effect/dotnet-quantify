using System;

namespace Quantify
{
    /// <summary>
    /// Basic data container class for data related to a unit. 
    /// </summary>
    /// <typeparam name="TValue">The type of the conversion rate.</typeparam>
    /// <typeparam name="TUnit">The type of the unit.</typeparam>
    public class BasicUnitConversionData<TValue, TUnit> : UnitConversionData<TValue, TUnit>
    {
        /// <inheritdoc/>
        public virtual TValue ConversionRate { get; }
        /// <inheritdoc/>
        public virtual TUnit Unit { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BasicUnitData"/> class with a conversion rate and a unit.
        /// </summary>
        /// <param name="conversionRate">The conversion rate of the unit.</param>
        /// <param name="unit">The unit.</param>
        /// <exception cref="ArgumentNullException"><paramref name="conversionRate"/> is <code>null</code> -or- <paramref name="unit"/> is <code>null</code>.</exception>
        public BasicUnitConversionData(TValue conversionRate, TUnit unit)
        {
            if (conversionRate == null)
                throw new ArgumentNullException(nameof(conversionRate));

            if (unit == null)
                throw new ArgumentNullException(nameof(unit));

            ConversionRate = conversionRate;
            Unit = unit;
        }
    }
}