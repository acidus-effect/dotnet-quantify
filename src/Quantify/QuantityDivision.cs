using System;

namespace Quantify
{
    public partial class Quantity<TValue, TUnit, TQuantity>
    {
        /// <summary>
        /// Divide the value of the current quantity with a given value.
        /// </summary>
        /// <param name="divisor">The divisor part in the calculation.</param>
        /// <returns>A <see cref="TQuantity"/> with the result in the calculation.</returns>
        public virtual TQuantity DivideBy(short divisor)
        {
            var quotient = _valueCalculator.Divide(Value, divisor);
            return CreateInstance(quotient);
        }

        /// <summary>
        /// Divide the value of the current quantity with a given value.
        /// </summary>
        /// <param name="divisor">The divisor part in the calculation.</param>
        /// <returns>A <see cref="TQuantity"/> with the result in the calculation.</returns>
        public virtual TQuantity DivideBy(ushort divisor)
        {
            var quotient = _valueCalculator.Divide(Value, divisor);
            return CreateInstance(quotient);
        }

        /// <summary>
        /// Divide the value of the current quantity with a given value.
        /// </summary>
        /// <param name="divisor">The divisor part in the calculation.</param>
        /// <returns>A <see cref="TQuantity"/> with the result in the calculation.</returns>
        public virtual TQuantity DivideBy(int divisor)
        {
            var quotient = _valueCalculator.Divide(Value, divisor);
            return CreateInstance(quotient);
        }

        /// <summary>
        /// Divide the value of the current quantity with a given value.
        /// </summary>
        /// <param name="divisor">The divisor part in the calculation.</param>
        /// <returns>A <see cref="TQuantity"/> with the result in the calculation.</returns>
        public virtual TQuantity DivideBy(uint divisor)
        {
            var quotient = _valueCalculator.Divide(Value, divisor);
            return CreateInstance(quotient);
        }

        /// <summary>
        /// Divide the value of the current quantity with a given value.
        /// </summary>
        /// <param name="divisor">The divisor part in the calculation.</param>
        /// <returns>A <see cref="TQuantity"/> with the result in the calculation.</returns>
        public virtual TQuantity DivideBy(long divisor)
        {
            var quotient = _valueCalculator.Divide(Value, divisor);
            return CreateInstance(quotient);
        }

        /// <summary>
        /// Divide the value of the current quantity with a given value.
        /// </summary>
        /// <param name="divisor">The divisor part in the calculation.</param>
        /// <returns>A <see cref="TQuantity"/> with the result in the calculation.</returns>
        public virtual TQuantity DivideBy(ulong divisor)
        {
            var quotient = _valueCalculator.Divide(Value, divisor);
            return CreateInstance(quotient);
        }

        /// <summary>
        /// Divide the value of the current quantity with a given value.
        /// </summary>
        /// <param name="divisor">The divisor part in the calculation.</param>
        /// <returns>A <see cref="TQuantity"/> with the result in the calculation.</returns>
        public virtual TQuantity DivideBy(double divisor)
        {
            var quotient = _valueCalculator.Divide(Value, divisor);
            return CreateInstance(quotient);
        }

        /// <summary>
        /// Divide the value of the current quantity with a given value.
        /// </summary>
        /// <param name="divisor">The divisor part in the calculation.</param>
        /// <returns>A <see cref="TQuantity"/> with the result in the calculation.</returns>
        public virtual TQuantity DivideBy(decimal divisor)
        {
            var quotient = _valueCalculator.Divide(Value, divisor);
            return CreateInstance(quotient);
        }

        /// <summary>
        /// Divide the value of the current quantity with a given value.
        /// </summary>
        /// <param name="divisor">The divisor part in the calculation.</param>
        /// <returns>A <see cref="TQuantity"/> with the result in the calculation.</returns>
        public virtual TQuantity DivideBy(float divisor)
        {
            var quotient = _valueCalculator.Divide(Value, divisor);
            return CreateInstance(quotient);
        }

        /// <summary>
        /// Divide the value of the left hand side quantity with a given value.
        /// </summary>
        /// <param name="dividendQuantity">The quantity of which the value will act as the dividend part in the calculation.</param>
        /// <param name="divisor">The divisor part in the calculation.</param>
        /// <returns>A <see cref="TQuantity"/> with the result in the calculation.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="dividendQuantity"/> is <code>null</code>.</exception>
        public static TQuantity operator /(Quantity<TValue, TUnit, TQuantity> dividendQuantity, short divisor)
        {
            if (dividendQuantity == null)
                throw new ArgumentNullException(nameof(dividendQuantity));

            return dividendQuantity.DivideBy(divisor);
        }

        /// <summary>
        /// Divide the value of the left hand side quantity with a given value.
        /// </summary>
        /// <param name="dividendQuantity">The quantity of which the value will act as the dividend part in the calculation.</param>
        /// <param name="divisor">The divisor part in the calculation.</param>
        /// <returns>A <see cref="TQuantity"/> with the result in the calculation.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="dividendQuantity"/> is <code>null</code>.</exception>
        public static TQuantity operator /(Quantity<TValue, TUnit, TQuantity> dividendQuantity, ushort divisor)
        {
            if (dividendQuantity == null)
                throw new ArgumentNullException(nameof(dividendQuantity));

            return dividendQuantity.DivideBy(divisor);
        }

        /// <summary>
        /// Divide the value of the left hand side quantity with a given value.
        /// </summary>
        /// <param name="dividendQuantity">The quantity of which the value will act as the dividend part in the calculation.</param>
        /// <param name="divisor">The divisor part in the calculation.</param>
        /// <returns>A <see cref="TQuantity"/> with the result in the calculation.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="dividendQuantity"/> is <code>null</code>.</exception>
        public static TQuantity operator /(Quantity<TValue, TUnit, TQuantity> dividendQuantity, int divisor)
        {
            if (dividendQuantity == null)
                throw new ArgumentNullException(nameof(dividendQuantity));

            return dividendQuantity.DivideBy(divisor);
        }

        /// <summary>
        /// Divide the value of the left hand side quantity with a given value.
        /// </summary>
        /// <param name="dividendQuantity">The quantity of which the value will act as the dividend part in the calculation.</param>
        /// <param name="divisor">The divisor part in the calculation.</param>
        /// <returns>A <see cref="TQuantity"/> with the result in the calculation.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="dividendQuantity"/> is <code>null</code>.</exception>
        public static TQuantity operator /(Quantity<TValue, TUnit, TQuantity> dividendQuantity, uint divisor)
        {
            if (dividendQuantity == null)
                throw new ArgumentNullException(nameof(dividendQuantity));

            return dividendQuantity.DivideBy(divisor);
        }

        /// <summary>
        /// Divide the value of the left hand side quantity with a given value.
        /// </summary>
        /// <param name="dividendQuantity">The quantity of which the value will act as the dividend part in the calculation.</param>
        /// <param name="divisor">The divisor part in the calculation.</param>
        /// <returns>A <see cref="TQuantity"/> with the result in the calculation.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="dividendQuantity"/> is <code>null</code>.</exception>
        public static TQuantity operator /(Quantity<TValue, TUnit, TQuantity> dividendQuantity, long divisor)
        {
            if (dividendQuantity == null)
                throw new ArgumentNullException(nameof(dividendQuantity));

            return dividendQuantity.DivideBy(divisor);
        }

        /// <summary>
        /// Divide the value of the left hand side quantity with a given value.
        /// </summary>
        /// <param name="dividendQuantity">The quantity of which the value will act as the dividend part in the calculation.</param>
        /// <param name="divisor">The divisor part in the calculation.</param>
        /// <returns>A <see cref="TQuantity"/> with the result in the calculation.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="dividendQuantity"/> is <code>null</code>.</exception>
        public static TQuantity operator /(Quantity<TValue, TUnit, TQuantity> dividendQuantity, ulong divisor)
        {
            if (dividendQuantity == null)
                throw new ArgumentNullException(nameof(dividendQuantity));

            return dividendQuantity.DivideBy(divisor);
        }

        /// <summary>
        /// Divide the value of the left hand side quantity with a given value.
        /// </summary>
        /// <param name="dividendQuantity">The quantity of which the value will act as the dividend part in the calculation.</param>
        /// <param name="divisor">The divisor part in the calculation.</param>
        /// <returns>A <see cref="TQuantity"/> with the result in the calculation.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="dividendQuantity"/> is <code>null</code>.</exception>
        public static TQuantity operator /(Quantity<TValue, TUnit, TQuantity> dividendQuantity, double divisor)
        {
            if (dividendQuantity == null)
                throw new ArgumentNullException(nameof(dividendQuantity));

            return dividendQuantity.DivideBy(divisor);
        }

        /// <summary>
        /// Divide the value of the left hand side quantity with a given value.
        /// </summary>
        /// <param name="dividendQuantity">The quantity of which the value will act as the dividend part in the calculation.</param>
        /// <param name="divisor">The divisor part in the calculation.</param>
        /// <returns>A <see cref="TQuantity"/> with the result in the calculation.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="dividendQuantity"/> is <code>null</code>.</exception>
        public static TQuantity operator /(Quantity<TValue, TUnit, TQuantity> dividendQuantity, decimal divisor)
        {
            if (dividendQuantity == null)
                throw new ArgumentNullException(nameof(dividendQuantity));

            return dividendQuantity.DivideBy(divisor);
        }

        /// <summary>
        /// Divide the value of the left hand side quantity with a given value.
        /// </summary>
        /// <param name="dividendQuantity">The quantity of which the value will act as the dividend part in the calculation.</param>
        /// <param name="divisor">The divisor part in the calculation.</param>
        /// <returns>A <see cref="TQuantity"/> with the result in the calculation.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="dividendQuantity"/> is <code>null</code>.</exception>
        public static TQuantity operator /(Quantity<TValue, TUnit, TQuantity> dividendQuantity, float divisor)
        {
            if (dividendQuantity == null)
                throw new ArgumentNullException(nameof(dividendQuantity));

            return dividendQuantity.DivideBy(divisor);
        }
    }
}