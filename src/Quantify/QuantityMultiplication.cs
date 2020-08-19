using System;

namespace Quantify
{
    public partial class Quantity<TValue, TUnit, TQuantity>
    {
        /// <summary>
        /// Multiply the value of this quantity with a given value.
        /// </summary>
        /// <param name="multiplier">The multiplier part in the calculation.</param>
        /// <returns>A new <see cref="TQuantity"/> with the result in the calculation.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="multiplier"/> is <code>null</code>.</exception>
        public virtual TQuantity MultiplyWith(TValue multiplier)
        {
            if (multiplier == null)
                throw new ArgumentNullException(nameof(multiplier));

            var product = valueCalculator.Multiply(Value, multiplier);
            return CreateInstance(product);
        }

        /// <summary>
        /// Multiply the value of this quantity with a given value.
        /// </summary>
        /// <param name="multiplier">The multiplier part in the calculation.</param>
        /// <returns>A new <see cref="TQuantity"/> with the result in the calculation.</returns>
        public virtual TQuantity MultiplyWith(short multiplier)
        {
            var product = valueCalculator.Multiply(Value, multiplier);
            return CreateInstance(product);
        }

        /// <summary>
        /// Multiply the value of this quantity with a given value.
        /// </summary>
        /// <param name="multiplier">The multiplier part in the calculation.</param>
        /// <returns>A new <see cref="TQuantity"/> with the result in the calculation.</returns>
        public virtual TQuantity MultiplyWith(ushort multiplier)
        {
            var product = valueCalculator.Multiply(Value, multiplier);
            return CreateInstance(product);
        }

        /// <summary>
        /// Multiply the value of this quantity with a given value.
        /// </summary>
        /// <param name="multiplier">The multiplier part in the calculation.</param>
        /// <returns>A new <see cref="TQuantity"/> with the result in the calculation.</returns>
        public virtual TQuantity MultiplyWith(int multiplier)
        {
            var product = valueCalculator.Multiply(Value, multiplier);
            return CreateInstance(product);
        }

        /// <summary>
        /// Multiply the value of this quantity with a given value.
        /// </summary>
        /// <param name="multiplier">The multiplier part in the calculation.</param>
        /// <returns>A new <see cref="TQuantity"/> with the result in the calculation.</returns>
        public virtual TQuantity MultiplyWith(uint multiplier)
        {
            var product = valueCalculator.Multiply(Value, multiplier);
            return CreateInstance(product);
        }

        /// <summary>
        /// Multiply the value of this quantity with a given value.
        /// </summary>
        /// <param name="multiplier">The multiplier part in the calculation.</param>
        /// <returns>A new <see cref="TQuantity"/> with the result in the calculation.</returns>
        public virtual TQuantity MultiplyWith(long multiplier)
        {
            var product = valueCalculator.Multiply(Value, multiplier);
            return CreateInstance(product);
        }

        /// <summary>
        /// Multiply the value of this quantity with a given value.
        /// </summary>
        /// <param name="multiplier">The multiplier part in the calculation.</param>
        /// <returns>A new <see cref="TQuantity"/> with the result in the calculation.</returns>
        public virtual TQuantity MultiplyWith(ulong multiplier)
        {
            var product = valueCalculator.Multiply(Value, multiplier);
            return CreateInstance(product);
        }

        /// <summary>
        /// Multiply the value of this quantity with a given value.
        /// </summary>
        /// <param name="multiplier">The multiplier part in the calculation.</param>
        /// <returns>A new <see cref="TQuantity"/> with the result in the calculation.</returns>
        public virtual TQuantity MultiplyWith(double multiplier)
        {
            var product = valueCalculator.Multiply(Value, multiplier);
            return CreateInstance(product);
        }

        /// <summary>
        /// Multiply the value of this quantity with a given value.
        /// </summary>
        /// <param name="multiplier">The multiplier part in the calculation.</param>
        /// <returns>A new <see cref="TQuantity"/> with the result in the calculation.</returns>
        public virtual TQuantity MultiplyWith(decimal multiplier)
        {
            var product = valueCalculator.Multiply(Value, multiplier);
            return CreateInstance(product);
        }

        /// <summary>
        /// Multiply the value of this quantity with a given value.
        /// </summary>
        /// <param name="multiplier">The multiplier part in the calculation.</param>
        /// <returns>A new <see cref="TQuantity"/> with the result in the calculation.</returns>
        public virtual TQuantity MultiplyWith(float multiplier)
        {
            var product = valueCalculator.Multiply(Value, multiplier);
            return CreateInstance(product);
        }

        /// <summary>
        /// Multiply the value of this quantity with a given value.
        /// </summary>
        /// <param name="multiplicandQuantity">The quantity of which the value will act as the multiplicand part in the calculation.</param>
        /// <param name="multiplier">The multiplier part in the calculation.</param>
        /// <returns>A new <see cref="TQuantity"/> with the result in the calculation.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="multiplicandQuantity"/> is <code>null</code>.</exception>
        public static TQuantity operator *(Quantity<TValue, TUnit, TQuantity> multiplicandQuantity, short multiplier)
        {
            if (multiplicandQuantity == null)
                throw new ArgumentNullException(nameof(multiplicandQuantity));

            return multiplicandQuantity.MultiplyWith(multiplier);
        }

        /// <summary>
        /// Multiply the value of this quantity with a given value.
        /// </summary>
        /// <param name="multiplicandQuantity">The quantity of which the value will act as the multiplicand part in the calculation.</param>
        /// <param name="multiplier">The multiplier part in the calculation.</param>
        /// <returns>A new <see cref="TQuantity"/> with the result in the calculation.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="multiplicandQuantity"/> is <code>null</code>.</exception>
        public static TQuantity operator *(Quantity<TValue, TUnit, TQuantity> multiplicandQuantity, ushort multiplier)
        {
            if (multiplicandQuantity == null)
                throw new ArgumentNullException(nameof(multiplicandQuantity));

            return multiplicandQuantity.MultiplyWith(multiplier);
        }

        /// <summary>
        /// Multiply the value of this quantity with a given value.
        /// </summary>
        /// <param name="multiplicandQuantity">The quantity of which the value will act as the multiplicand part in the calculation.</param>
        /// <param name="multiplier">The multiplier part in the calculation.</param>
        /// <returns>A new <see cref="TQuantity"/> with the result in the calculation.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="multiplicandQuantity"/> is <code>null</code>.</exception>
        public static TQuantity operator *(Quantity<TValue, TUnit, TQuantity> multiplicandQuantity, int multiplier)
        {
            if (multiplicandQuantity == null)
                throw new ArgumentNullException(nameof(multiplicandQuantity));

            return multiplicandQuantity.MultiplyWith(multiplier);
        }

        /// <summary>
        /// Multiply the value of this quantity with a given value.
        /// </summary>
        /// <param name="multiplicandQuantity">The quantity of which the value will act as the multiplicand part in the calculation.</param>
        /// <param name="multiplier">The multiplier part in the calculation.</param>
        /// <returns>A new <see cref="TQuantity"/> with the result in the calculation.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="multiplicandQuantity"/> is <code>null</code>.</exception>
        public static TQuantity operator *(Quantity<TValue, TUnit, TQuantity> multiplicandQuantity, uint multiplier)
        {
            if (multiplicandQuantity == null)
                throw new ArgumentNullException(nameof(multiplicandQuantity));

            return multiplicandQuantity.MultiplyWith(multiplier);
        }

        /// <summary>
        /// Multiply the value of this quantity with a given value.
        /// </summary>
        /// <param name="multiplicandQuantity">The quantity of which the value will act as the multiplicand part in the calculation.</param>
        /// <param name="multiplier">The multiplier part in the calculation.</param>
        /// <returns>A new <see cref="TQuantity"/> with the result in the calculation.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="multiplicandQuantity"/> is <code>null</code>.</exception>
        public static TQuantity operator *(Quantity<TValue, TUnit, TQuantity> multiplicandQuantity, long multiplier)
        {
            if (multiplicandQuantity == null)
                throw new ArgumentNullException(nameof(multiplicandQuantity));

            return multiplicandQuantity.MultiplyWith(multiplier);
        }

        /// <summary>
        /// Multiply the value of this quantity with a given value.
        /// </summary>
        /// <param name="multiplicandQuantity">The quantity of which the value will act as the multiplicand part in the calculation.</param>
        /// <param name="multiplier">The multiplier part in the calculation.</param>
        /// <returns>A new <see cref="TQuantity"/> with the result in the calculation.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="multiplicandQuantity"/> is <code>null</code>.</exception>
        public static TQuantity operator *(Quantity<TValue, TUnit, TQuantity> multiplicandQuantity, ulong multiplier)
        {
            if (multiplicandQuantity == null)
                throw new ArgumentNullException(nameof(multiplicandQuantity));

            return multiplicandQuantity.MultiplyWith(multiplier);
        }

        /// <summary>
        /// Multiply the value of this quantity with a given value.
        /// </summary>
        /// <param name="multiplicandQuantity">The quantity of which the value will act as the multiplicand part in the calculation.</param>
        /// <param name="multiplier">The multiplier part in the calculation.</param>
        /// <returns>A new <see cref="TQuantity"/> with the result in the calculation.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="multiplicandQuantity"/> is <code>null</code>.</exception>
        public static TQuantity operator *(Quantity<TValue, TUnit, TQuantity> multiplicandQuantity, double multiplier)
        {
            if (multiplicandQuantity == null)
                throw new ArgumentNullException(nameof(multiplicandQuantity));

            return multiplicandQuantity.MultiplyWith(multiplier);
        }

        /// <summary>
        /// Multiply the value of this quantity with a given value.
        /// </summary>
        /// <param name="multiplicandQuantity">The quantity of which the value will act as the multiplicand part in the calculation.</param>
        /// <param name="multiplier">The multiplier part in the calculation.</param>
        /// <returns>A new <see cref="TQuantity"/> with the result in the calculation.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="multiplicandQuantity"/> is <code>null</code>.</exception>
        public static TQuantity operator *(Quantity<TValue, TUnit, TQuantity> multiplicandQuantity, decimal multiplier)
        {
            if (multiplicandQuantity == null)
                throw new ArgumentNullException(nameof(multiplicandQuantity));

            return multiplicandQuantity.MultiplyWith(multiplier);
        }

        /// <summary>
        /// Multiply the value of this quantity with a given value.
        /// </summary>
        /// <param name="multiplicandQuantity">The quantity of which the value will act as the multiplicand part in the calculation.</param>
        /// <param name="multiplier">The multiplier part in the calculation.</param>
        /// <returns>A new <see cref="TQuantity"/> with the result in the calculation.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="multiplicandQuantity"/> is <code>null</code>.</exception>
        public static TQuantity operator *(Quantity<TValue, TUnit, TQuantity> multiplicandQuantity, float multiplier)
        {
            if (multiplicandQuantity == null)
                throw new ArgumentNullException(nameof(multiplicandQuantity));

            return multiplicandQuantity.MultiplyWith(multiplier);
        }
    }
}