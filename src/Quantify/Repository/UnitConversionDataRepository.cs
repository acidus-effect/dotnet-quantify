namespace Quantify
{
    /// <summary>
    /// Interface defining the contract for repositories used to get quantity unit conversion data.
    /// </summary>
    /// <typeparam name="TUnit">The type of the unit.</typeparam>
    public interface UnitConversionDataRepository<TUnit>
    {
        /// <summary>
        /// Get unit conversion data for a given <paramref name="unit"/>.
        /// </summary>
        /// <remarks>
        /// This unit data is optimized towards greater performance, since the return unit conversion rate is of the type <see cref="double"/>.
        /// </remarks>
        /// <param name="unit">The unit to get unit data for.</param>
        /// <returns>Conversion data about the given unit. Returns <code>null</code> if no data was found.</returns>
        UnitConversionData<double, TUnit> GetUnitConversionData(TUnit unit);

        /// <summary>
        /// Get unit conversion data for a given <paramref name="unit"/>.
        /// </summary>
        /// <remarks>
        /// This unit data is optimized towards greater precision, since the return unit conversion rate is of the type <see cref="decimal"/>.
        /// </remarks>
        /// <param name="unit">The unit to get unit data for.</param>
        /// <returns>Conversion data about the given unit. Returns <code>null</code> if no data was found.</returns>
        UnitConversionData<decimal, TUnit> GetPreciseUnitConversionData(TUnit unit);
    }
}