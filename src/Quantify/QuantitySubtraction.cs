using System;

namespace Quantify
{
    public partial class Quantity<TValue, TUnit, TQuantity>
    {
        public TQuantity Subtract(TQuantity quantity)
        {
            var convertedQuantity = ToUnit(quantity.Unit);
            return Subtract(convertedQuantity.Value);
        }

        public TQuantity Subtract(TValue value)
        {
            var newValue = valueCalculator.Subtract(Value, value);
            return CreateInstance(newValue);
        }

        public TQuantity Subtract(int value)
        {
            var newValue = valueCalculator.Subtract(Value, value);
            return CreateInstance(newValue);
        }

        public static TQuantity operator -(Quantity<TValue, TUnit, TQuantity> lhs, TQuantity rhs)
        {
            if (lhs == null)
                throw new ArgumentNullException(nameof(lhs));

            if (rhs == null)
                throw new ArgumentNullException(nameof(rhs));

            return lhs.Subtract(rhs);
        }

        public static TQuantity operator -(Quantity<TValue, TUnit, TQuantity> quantity, TValue value)
        {
            return quantity.Subtract(value);
        }

        public static TQuantity operator -(Quantity<TValue, TUnit, TQuantity> quantity, int value)
        {
            return quantity.Subtract(value);
        }
    }
}