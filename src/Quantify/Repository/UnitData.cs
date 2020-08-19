namespace Quantify
{
    /// <summary>
    /// Interface defining the contract for classes containing conversion data for a given <see cref="Unit"/>.
    /// </summary>
    /// <typeparam name="TValue">The type of the conversion rate.</typeparam>
    /// <typeparam name="TUnit">The type of the unit.</typeparam>
    public interface UnitData<TValue, TUnit>
    {
        /// <summary>
        /// The conversion rate compared to the base unit.
        /// </summary>
        TValue ConversionRate { get; }

        /// <summary>
        /// The unit that represents the conversion rate value defined in <see cref="ConversionRate"/>.
        /// </summary>
        TUnit Unit { get; }
    }
}