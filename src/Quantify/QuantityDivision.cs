using System;

namespace Quantify
{
    public partial class Quantity<TValue, TUnit, TQuantity>
    {
        /// <summary>
        /// Returns a new <see cref="QuantityBase"/> with the current <see cref="Value"/> divided by a given denominator.
        /// The <see cref="Unit"/> will remain the same.
        /// </summary>
        /// <param name="denominator">The denominator to divide the current <see cref="Value"/> by.</param>
        /// <returns>A new <see cref="QuantityBase"/> with the current <see cref="Value"/> divided by <paramref name="denominator"/>.</returns>
        /// <exception cref="DivideByZeroException">Is thrown when there is an attempt to divide the <see cref="Value"/> by zero.</exception>
        public TQuantity DivideBy(TValue denominator)
        {
            var newValue = valueCalculator.Divide(Value, denominator);
            return CreateInstance(newValue);
        }

        public TQuantity DivideBy(int denominator)
        {
            var newValue = valueCalculator.Divide(Value, denominator);
            return CreateInstance(newValue);
        }

        public static TQuantity operator /(Quantity<TValue, TUnit, TQuantity> quantity, TValue denominator)
        {
            return quantity.DivideBy(denominator);
        }

        public static TQuantity operator /(Quantity<TValue, TUnit, TQuantity> quantity, int denominator)
        {
            return quantity.DivideBy(denominator);
        }
    }
}