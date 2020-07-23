namespace Quantify
{
    public interface IQuantity<TValue, TUnit>
    {
        TValue Value { get; }
        TUnit Unit { get; }
    }
}