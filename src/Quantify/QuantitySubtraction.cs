using System;

namespace Quantify
{
    public partial class Quantity<TValue, TUnit, TQuantity>
    {
        /// <summary>
        /// Subtract the value of a quantity from the value of the current quantity.
        /// </summary>
        /// <param name="subtrahendQuantity">The quantity for which the value will be subtracted from to value of the current quantity.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation. The returned quantity will be of the same unit as the current quantity.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="termQuantity"/> is <code>null</code>.</exception>
        public virtual TQuantity Subtract(TQuantity subtrahendQuantity)
        {
            if (subtrahendQuantity == null)
                throw new ArgumentNullException(nameof(subtrahendQuantity));

            var convertedSubtrahendQuantityValue = _valueConverter.ConvertValueToUnit(subtrahendQuantity.Value, subtrahendQuantity.Unit, Unit);
            return Subtract(convertedSubtrahendQuantityValue);
        }

        /// <summary>
        /// Subtract a value from the value of the current quantity.
        /// </summary>
        /// <param name="subtrahend">The value to subtract.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="subtrahend"/> is <code>null</code>.</exception>
        public virtual TQuantity Subtract(TValue subtrahend)
        {
            if (subtrahend == null)
                throw new ArgumentNullException(nameof(subtrahend));

            var difference = _valueCalculator.Subtract(Value, subtrahend);
            return CreateInstance(difference);
        }

        /// <summary>
        /// Subtract a value from the value of the current quantity.
        /// </summary>
        /// <param name="subtrahend">The value to subtract.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation.</returns>
        public virtual TQuantity Subtract(short subtrahend)
        {
            var difference = _valueCalculator.Subtract(Value, subtrahend);
            return CreateInstance(difference);
        }

        /// <summary>
        /// Subtract a value from the value of the current quantity.
        /// </summary>
        /// <param name="subtrahend">The value to subtract.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation.</returns>
        public virtual TQuantity Subtract(ushort subtrahend)
        {
            var difference = _valueCalculator.Subtract(Value, subtrahend);
            return CreateInstance(difference);
        }

        /// <summary>
        /// Subtract a value from the value of the current quantity.
        /// </summary>
        /// <param name="subtrahend">The value to subtract.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation.</returns>
        public virtual TQuantity Subtract(int subtrahend)
        {
            var difference = _valueCalculator.Subtract(Value, subtrahend);
            return CreateInstance(difference);
        }

        /// <summary>
        /// Subtract a value from the value of the current quantity.
        /// </summary>
        /// <param name="subtrahend">The value to subtract.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation.</returns>
        public virtual TQuantity Subtract(uint subtrahend)
        {
            var difference = _valueCalculator.Subtract(Value, subtrahend);
            return CreateInstance(difference);
        }

        /// <summary>
        /// Subtract a value from the value of the current quantity.
        /// </summary>
        /// <param name="subtrahend">The value to subtract.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation.</returns>
        public virtual TQuantity Subtract(long subtrahend)
        {
            var difference = _valueCalculator.Subtract(Value, subtrahend);
            return CreateInstance(difference);
        }

        /// <summary>
        /// Subtract a value from the value of the current quantity.
        /// </summary>
        /// <param name="subtrahend">The value to subtract.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation.</returns>
        public virtual TQuantity Subtract(ulong subtrahend)
        {
            var difference = _valueCalculator.Subtract(Value, subtrahend);
            return CreateInstance(difference);
        }

        /// <summary>
        /// Subtract a value from the value of the current quantity.
        /// </summary>
        /// <param name="subtrahend">The value to subtract.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation.</returns>
        public virtual TQuantity Subtract(double subtrahend)
        {
            var difference = _valueCalculator.Subtract(Value, subtrahend);
            return CreateInstance(difference);
        }

        /// <summary>
        /// Subtract a value from the value of the current quantity.
        /// </summary>
        /// <param name="subtrahend">The value to subtract.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation.</returns>
        public virtual TQuantity Subtract(decimal subtrahend)
        {
            var difference = _valueCalculator.Subtract(Value, subtrahend);
            return CreateInstance(difference);
        }

        /// <summary>
        /// Subtract a value from the value of the current quantity.
        /// </summary>
        /// <param name="subtrahend">The value to subtract.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation.</returns>
        public virtual TQuantity Subtract(float subtrahend)
        {
            var difference = _valueCalculator.Subtract(Value, subtrahend);
            return CreateInstance(difference);
        }

        /// <summary>
        /// Subtract the value of the right hand side quantity from the value of the left hand side quantity.
        /// </summary>
        /// <param name="minuendQuantity">The quantity of which the value will act as the minuted part in the calculation.</param>
        /// <param name="subtrahendQuantity">The quantity of which the value will act as the subtrahend part in the calculation.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation. The returned quantity will be of the same unit as the left hand side quantity <paramref name="term1Quantity"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="minuendQuantity"/> is <code>null</code> -or- <paramref name="subtrahendQuantity"/> is <code>null</code>.</exception>
        public static TQuantity operator -(Quantity<TValue, TUnit, TQuantity> minuendQuantity, TQuantity subtrahendQuantity)
        {
            if (minuendQuantity == null)
                throw new ArgumentNullException(nameof(minuendQuantity));

            if (subtrahendQuantity == null)
                throw new ArgumentNullException(nameof(subtrahendQuantity));

            return minuendQuantity.Subtract(subtrahendQuantity);
        }

        /// <summary>
        /// Subtract a given value from the value of the left hand side quantity.
        /// </summary>
        /// <param name="minuendQuantity">The quantity of which the value will act as the minuted part in the calculation.</param>
        /// <param name="subtrahend">The value to subtract.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="minuendQuantity"/> is <code>null</code>.</exception>
        public static TQuantity operator -(Quantity<TValue, TUnit, TQuantity> minuendQuantity, short subtrahend)
        {
            if (minuendQuantity == null)
                throw new ArgumentNullException(nameof(minuendQuantity));

            return minuendQuantity.Subtract(subtrahend);
        }

        /// <summary>
        /// Subtract a given value from the value of the left hand side quantity.
        /// </summary>
        /// <param name="minuendQuantity">The quantity of which the value will act as the minuted part in the calculation.</param>
        /// <param name="subtrahend">The value to subtract.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="minuendQuantity"/> is <code>null</code>.</exception>
        public static TQuantity operator -(Quantity<TValue, TUnit, TQuantity> minuendQuantity, ushort subtrahend)
        {
            if (minuendQuantity == null)
                throw new ArgumentNullException(nameof(minuendQuantity));

            return minuendQuantity.Subtract(subtrahend);
        }

        /// <summary>
        /// Subtract a given value from the value of the left hand side quantity.
        /// </summary>
        /// <param name="minuendQuantity">The quantity of which the value will act as the minuted part in the calculation.</param>
        /// <param name="subtrahend">The value to subtract.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="minuendQuantity"/> is <code>null</code>.</exception>
        public static TQuantity operator -(Quantity<TValue, TUnit, TQuantity> minuendQuantity, int subtrahend)
        {
            if (minuendQuantity == null)
                throw new ArgumentNullException(nameof(minuendQuantity));

            return minuendQuantity.Subtract(subtrahend);
        }

        /// <summary>
        /// Subtract a given value from the value of the left hand side quantity.
        /// </summary>
        /// <param name="minuendQuantity">The quantity of which the value will act as the minuted part in the calculation.</param>
        /// <param name="subtrahend">The value to subtract.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="minuendQuantity"/> is <code>null</code>.</exception>
        public static TQuantity operator -(Quantity<TValue, TUnit, TQuantity> minuendQuantity, uint subtrahend)
        {
            if (minuendQuantity == null)
                throw new ArgumentNullException(nameof(minuendQuantity));

            return minuendQuantity.Subtract(subtrahend);
        }

        /// <summary>
        /// Subtract a given value from the value of the left hand side quantity.
        /// </summary>
        /// <param name="minuendQuantity">The quantity of which the value will act as the minuted part in the calculation.</param>
        /// <param name="subtrahend">The value to subtract.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="minuendQuantity"/> is <code>null</code>.</exception>
        public static TQuantity operator -(Quantity<TValue, TUnit, TQuantity> minuendQuantity, long subtrahend)
        {
            if (minuendQuantity == null)
                throw new ArgumentNullException(nameof(minuendQuantity));

            return minuendQuantity.Subtract(subtrahend);
        }

        /// <summary>
        /// Subtract a given value from the value of the left hand side quantity.
        /// </summary>
        /// <param name="minuendQuantity">The quantity of which the value will act as the minuted part in the calculation.</param>
        /// <param name="subtrahend">The value to subtract.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="minuendQuantity"/> is <code>null</code>.</exception>
        public static TQuantity operator -(Quantity<TValue, TUnit, TQuantity> minuendQuantity, ulong subtrahend)
        {
            if (minuendQuantity == null)
                throw new ArgumentNullException(nameof(minuendQuantity));

            return minuendQuantity.Subtract(subtrahend);
        }

        /// <summary>
        /// Subtract a given value from the value of the left hand side quantity.
        /// </summary>
        /// <param name="minuendQuantity">The quantity of which the value will act as the minuted part in the calculation.</param>
        /// <param name="subtrahend">The value to subtract.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="minuendQuantity"/> is <code>null</code>.</exception>
        public static TQuantity operator -(Quantity<TValue, TUnit, TQuantity> minuendQuantity, double subtrahend)
        {
            if (minuendQuantity == null)
                throw new ArgumentNullException(nameof(minuendQuantity));

            return minuendQuantity.Subtract(subtrahend);
        }

        /// <summary>
        /// Subtract a given value from the value of the left hand side quantity.
        /// </summary>
        /// <param name="minuendQuantity">The quantity of which the value will act as the minuted part in the calculation.</param>
        /// <param name="subtrahend">The value to subtract.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="minuendQuantity"/> is <code>null</code>.</exception>
        public static TQuantity operator -(Quantity<TValue, TUnit, TQuantity> minuendQuantity, decimal subtrahend)
        {
            if (minuendQuantity == null)
                throw new ArgumentNullException(nameof(minuendQuantity));

            return minuendQuantity.Subtract(subtrahend);
        }

        /// <summary>
        /// Subtract a given value from the value of the left hand side quantity.
        /// </summary>
        /// <param name="minuendQuantity">The quantity of which the value will act as the minuted part in the calculation.</param>
        /// <param name="subtrahend">The value to subtract.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="minuendQuantity"/> is <code>null</code>.</exception>
        public static TQuantity operator -(Quantity<TValue, TUnit, TQuantity> minuendQuantity, float subtrahend)
        {
            if (minuendQuantity == null)
                throw new ArgumentNullException(nameof(minuendQuantity));

            return minuendQuantity.Subtract(subtrahend);
        }
    }
}