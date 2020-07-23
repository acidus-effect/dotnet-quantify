namespace Quantify
{
    public interface UnitData<TValue, TUnit>
    {
        TUnit Unit { get; }
        TValue Value { get; }
    }
}