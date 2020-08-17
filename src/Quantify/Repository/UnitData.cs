namespace Quantify
{
    public interface UnitData<TValue, TUnit>
    {
        TValue Value { get; }
        TUnit Unit { get; }
    }
}