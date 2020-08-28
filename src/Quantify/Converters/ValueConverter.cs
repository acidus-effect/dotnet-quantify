namespace Quantify
{
    public interface ValueConverter<TValue, TUnit>
    {
        TValue ConvertValueToUnit(TValue value, TUnit sourceUnit, TUnit targetUnit);
    }
}