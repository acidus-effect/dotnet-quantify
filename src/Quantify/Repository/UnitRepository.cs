namespace Quantify
{
    /// <summary>
    /// Interface defining the contract for repositories used to get quantity unit conversion data.
    /// </summary>
    /// <typeparam name="TValue">The type of the conversion rate.</typeparam>
    /// <typeparam name="TUnit">The type of the unit.</typeparam>
    public interface UnitRepository<TValue, TUnit>
    {
        /// <summary>
        /// Get unit conversion data for a given <paramref name="unit"/>.
        /// </summary>
        /// <param name="unit">The unit to get unit data for.</param>
        /// <returns>Conversion data about the given unit. Returns <code>null</code> if no data was found.</returns>
        UnitData<TValue, TUnit> GetUnitData(TUnit unit);
    }
}