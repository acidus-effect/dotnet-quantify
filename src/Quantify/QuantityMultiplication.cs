namespace Quantify
{
    public partial class Quantity<TValue, TUnit, TQuantity>
    {
        public TQuantity MultiplyWith(TValue factor)
        {
            var newValue = valueCalculator.Multiply(Value, factor);
            return CreateInstance(newValue);
        }

        public TQuantity MultiplyWith(int factor)
        {
            var newValue = valueCalculator.Multiply(Value, factor);
            return CreateInstance(newValue);
        }

        public static TQuantity operator *(Quantity<TValue, TUnit, TQuantity> quantity, TValue factor)
        {
            return quantity.MultiplyWith(factor);
        }

        public static TQuantity operator *(Quantity<TValue, TUnit, TQuantity> quantity, int factor)
        {
            return quantity.MultiplyWith(factor);
        }
    }
}