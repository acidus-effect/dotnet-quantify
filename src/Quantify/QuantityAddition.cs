using System;

namespace Quantify
{
    public partial class Quantity<TValue, TUnit, TQuantity>
    {
        public TQuantity Add(TQuantity quantity)
        {
            if (quantity == null)
                throw new ArgumentNullException(nameof(quantity));

            var convertedQuantity = quantity.ToUnit(Unit);
            return Add(convertedQuantity.Value);
        }

        public TQuantity Add(TValue value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            var newValue = valueCalculator.Add(Value, value);
            return CreateInstance(newValue);
        }

        public TQuantity Add(int value)
        {
            var newValue = valueCalculator.Add(Value, value);
            return CreateInstance(newValue);
        }

        public static TQuantity operator +(Quantity<TValue, TUnit, TQuantity> lhs, TQuantity rhs)
        {
            if (lhs == null)
                throw new ArgumentNullException(nameof(lhs));

            if (rhs == null)
                throw new ArgumentNullException(nameof(rhs));

            return lhs.Add(rhs);
        }

        public static TQuantity operator +(Quantity<TValue, TUnit, TQuantity> quantity, TValue value)
        {
            if (quantity == null)
                throw new ArgumentNullException(nameof(quantity));

            if (value == null)
                throw new ArgumentNullException(nameof(value));

            return quantity.Add(value);
        }

        public static TQuantity operator +(Quantity<TValue, TUnit, TQuantity> quantity, int value)
        {
            if (quantity == null)
                throw new ArgumentNullException(nameof(quantity));

            return quantity.Add(value);
        }
    }
}