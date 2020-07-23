namespace Quantify
{
    public interface IValueConverter<TValue, TUnit>
    {
        TValue ConvertValueToUnit(TValue value, TUnit sourceUnit, TUnit targetUnit);
    }
}