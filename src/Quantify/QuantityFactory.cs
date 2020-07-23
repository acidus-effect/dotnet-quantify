namespace Quantify
{
    public interface QuantityFactory<TValue, TUnit, TQuantity>
    {
        TQuantity CreateInstance(TValue value, TUnit unit, QuantityFactory<TValue, TUnit, TQuantity> quantityFactory, UnitRepository<TValue, TUnit> unitRepository, ValueCalculator<TValue> valueCalculator, IValueConverter<TValue, TUnit> valueConverter);
    }
}