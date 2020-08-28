namespace Quantify
{
    /// <summary>
    /// Interface defining the contract for repositories used to get quantity unit data.
    /// </summary>
    /// <typeparam name="TUnit">The type of the unit.</typeparam>
    public interface UnitRepository<TUnit>
    {
        /// <summary>
        /// Get the performance optimized conversion rate for a unit.
        /// </summary>
        /// <remarks>
        /// This conversion rate is optimized towards greater performance, since the return rate is of the type <see cref="double"/>.
        /// </remarks>
        /// <param name="unit">The unit to get the conversion rate for.</param>
        /// <returns>The conversion rate for the given unit. Returns <code>null</code> if no data was found for the unit.</returns>
        double? GetUnitConversionRate(TUnit unit);

        /// <summary>
        /// Get the precision optimized conversion rate for a unit.
        /// </summary>
        /// <remarks>
        /// This conversion rate is optimized towards greater precision, since the return rate is of the type <see cref="decimal"/>.
        /// </remarks>
        /// <param name="unit">The unit to get the conversion rate for.</param>
        /// <returns>The conversion rate for the given unit. Returns <code>null</code> if no data was found for the unit.</returns>
        decimal? GetPreciseUnitConversionRate(TUnit unit);
    }
}