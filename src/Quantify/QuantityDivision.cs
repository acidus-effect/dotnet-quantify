using System;

namespace Quantify
{
    public partial class Quantity<TValue, TUnit, TQuantity>
    {
        /// <summary>
        /// Returns a new <see cref="QuantityBase"/> with the current <see cref="Value"/> divided by a given divisor.
        /// The <see cref="Unit"/> will remain the same.
        /// </summary>
        /// <param name="divisor">The divisor to divide the current <see cref="Value"/> by.</param>
        /// <returns>A new <see cref="QuantityBase"/> with the current <see cref="Value"/> divided by <paramref name="divisor"/>.</returns>
        /// <exception cref="DivideByZeroException">Is thrown when there is an attempt to divide the <see cref="Value"/> by zero.</exception>
        public virtual TQuantity DivideBy(TValue divisor)
        {
            if (divisor == null)
                throw new ArgumentNullException(nameof(divisor));

            var quotient = valueCalculator.Divide(Value, divisor);
            return CreateInstance(quotient);
        }

        public virtual TQuantity DivideBy(short divisor)
        {
            var quotient = valueCalculator.Divide(Value, divisor);
            return CreateInstance(quotient);
        }

        public virtual TQuantity DivideBy(ushort divisor)
        {
            var quotient = valueCalculator.Divide(Value, divisor);
            return CreateInstance(quotient);
        }

        public virtual TQuantity DivideBy(int divisor)
        {
            var quotient = valueCalculator.Divide(Value, divisor);
            return CreateInstance(quotient);
        }

        public virtual TQuantity DivideBy(uint divisor)
        {
            var quotient = valueCalculator.Divide(Value, divisor);
            return CreateInstance(quotient);
        }

        public virtual TQuantity DivideBy(long divisor)
        {
            var quotient = valueCalculator.Divide(Value, divisor);
            return CreateInstance(quotient);
        }

        public virtual TQuantity DivideBy(ulong divisor)
        {
            var quotient = valueCalculator.Divide(Value, divisor);
            return CreateInstance(quotient);
        }

        public virtual TQuantity DivideBy(double divisor)
        {
            var quotient = valueCalculator.Divide(Value, divisor);
            return CreateInstance(quotient);
        }

        public virtual TQuantity DivideBy(decimal divisor)
        {
            var quotient = valueCalculator.Divide(Value, divisor);
            return CreateInstance(quotient);
        }

        public virtual TQuantity DivideBy(float divisor)
        {
            var quotient = valueCalculator.Divide(Value, divisor);
            return CreateInstance(quotient);
        }

        public static TQuantity operator /(Quantity<TValue, TUnit, TQuantity> dividendQuantity, short divisor)
        {
            if (dividendQuantity == null)
                throw new ArgumentNullException(nameof(dividendQuantity));

            return dividendQuantity.DivideBy(divisor);
        }

        public static TQuantity operator /(Quantity<TValue, TUnit, TQuantity> dividendQuantity, ushort divisor)
        {
            if (dividendQuantity == null)
                throw new ArgumentNullException(nameof(dividendQuantity));

            return dividendQuantity.DivideBy(divisor);
        }

        public static TQuantity operator /(Quantity<TValue, TUnit, TQuantity> dividendQuantity, int divisor)
        {
            if (dividendQuantity == null)
                throw new ArgumentNullException(nameof(dividendQuantity));

            return dividendQuantity.DivideBy(divisor);
        }

        public static TQuantity operator /(Quantity<TValue, TUnit, TQuantity> dividendQuantity, uint divisor)
        {
            if (dividendQuantity == null)
                throw new ArgumentNullException(nameof(dividendQuantity));

            return dividendQuantity.DivideBy(divisor);
        }

        public static TQuantity operator /(Quantity<TValue, TUnit, TQuantity> dividendQuantity, long divisor)
        {
            if (dividendQuantity == null)
                throw new ArgumentNullException(nameof(dividendQuantity));

            return dividendQuantity.DivideBy(divisor);
        }

        public static TQuantity operator /(Quantity<TValue, TUnit, TQuantity> dividendQuantity, ulong divisor)
        {
            if (dividendQuantity == null)
                throw new ArgumentNullException(nameof(dividendQuantity));

            return dividendQuantity.DivideBy(divisor);
        }

        public static TQuantity operator /(Quantity<TValue, TUnit, TQuantity> dividendQuantity, double divisor)
        {
            if (dividendQuantity == null)
                throw new ArgumentNullException(nameof(dividendQuantity));

            return dividendQuantity.DivideBy(divisor);
        }

        public static TQuantity operator /(Quantity<TValue, TUnit, TQuantity> dividendQuantity, decimal divisor)
        {
            if (dividendQuantity == null)
                throw new ArgumentNullException(nameof(dividendQuantity));

            return dividendQuantity.DivideBy(divisor);
        }

        public static TQuantity operator /(Quantity<TValue, TUnit, TQuantity> dividendQuantity, float divisor)
        {
            if (dividendQuantity == null)
                throw new ArgumentNullException(nameof(dividendQuantity));

            return dividendQuantity.DivideBy(divisor);
        }
    }
}