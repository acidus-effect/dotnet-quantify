using System;

namespace Quantify
{
    public partial class Quantity<TValue, TUnit, TQuantity>
    {
        /// <summary>
        /// Add the value of another quantity to the value of the current quantity.
        /// </summary>
        /// <param name="termQuantity">The quantity for which the value will be added to the value of the quantity.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation. The returned quantity will be of the same unit as the current quantity.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="termQuantity"/> is <code>null</code>.</exception>
        public virtual TQuantity Add(TQuantity termQuantity)
        {
            if (termQuantity == null)
                throw new ArgumentNullException(nameof(termQuantity));

            var convertedTermQuantityValue = valueConverter.ConvertValueToUnit(termQuantity.Value, termQuantity.Unit, Unit);
            return Add(convertedTermQuantityValue);
        }

        /// <summary>
        /// Add a value to the current quantity value.
        /// </summary>
        /// <param name="term">The value to add.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="term"/> is <code>null</code>.</exception>
        public virtual TQuantity Add(TValue term)
        {
            if (term == null)
                throw new ArgumentNullException(nameof(term));

            var sum = valueCalculator.Add(Value, term);
            return CreateInstance(sum);
        }

        /// <summary>
        /// Add a value to the current quantity value.
        /// </summary>
        /// <param name="term">The value to add.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation.</returns>
        public virtual TQuantity Add(short term)
        {
            var sum = valueCalculator.Add(Value, term);
            return CreateInstance(sum);
        }

        /// <summary>
        /// Add a value to the current quantity value.
        /// </summary>
        /// <param name="term">The value to add.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation.</returns>
        public virtual TQuantity Add(ushort term)
        {
            var sum = valueCalculator.Add(Value, term);
            return CreateInstance(sum);
        }

        /// <summary>
        /// Add a value to the current quantity value.
        /// </summary>
        /// <param name="term">The value to add.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation.</returns>
        public virtual TQuantity Add(int term)
        {
            var sum = valueCalculator.Add(Value, term);
            return CreateInstance(sum);
        }

        /// <summary>
        /// Add a value to the current quantity value.
        /// </summary>
        /// <param name="term">The value to add.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation.</returns>
        public virtual TQuantity Add(uint term)
        {
            var sum = valueCalculator.Add(Value, term);
            return CreateInstance(sum);
        }

        /// <summary>
        /// Add a value to the current quantity value.
        /// </summary>
        /// <param name="term">The value to add.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation.</returns>
        public virtual TQuantity Add(long term)
        {
            var sum = valueCalculator.Add(Value, term);
            return CreateInstance(sum);
        }

        /// <summary>
        /// Add a value to the current quantity value.
        /// </summary>
        /// <param name="term">The value to add.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation.</returns>
        public virtual TQuantity Add(ulong term)
        {
            var sum = valueCalculator.Add(Value, term);
            return CreateInstance(sum);
        }

        /// <summary>
        /// Add a value to the current quantity value.
        /// </summary>
        /// <param name="term">The value to add.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation.</returns>
        public virtual TQuantity Add(double term)
        {
            var sum = valueCalculator.Add(Value, term);
            return CreateInstance(sum);
        }

        /// <summary>
        /// Add a value to the current quantity value.
        /// </summary>
        /// <param name="term">The value to add.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation.</returns>
        public virtual TQuantity Add(decimal term)
        {
            var sum = valueCalculator.Add(Value, term);
            return CreateInstance(sum);
        }

        /// <summary>
        /// Add a value to the value of the current quantity.
        /// </summary>
        /// <param name="term">The value to add.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation.</returns>
        public virtual TQuantity Add(float term)
        {
            var sum = valueCalculator.Add(Value, term);
            return CreateInstance(sum);
        }

        /// <summary>
        /// Add the value of the right hand side quantity to the value of the left hand side quantity.
        /// </summary>
        /// <param name="term1Quantity">The quantity of which the value will act as the first term in the calculation.</param>
        /// <param name="term2Quantity">The quantity of which the value will act as the second term in the calculation.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation. The returned quantity will be of the same unit as the left hand side quantity <paramref name="term1Quantity"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="term1Quantity"/> is <code>null</code> -or- <paramref name="term2Quantity"/> is <code>null</code>.</exception>
        public static TQuantity operator +(Quantity<TValue, TUnit, TQuantity> term1Quantity, TQuantity term2Quantity)
        {
            if (term1Quantity == null)
                throw new ArgumentNullException(nameof(term1Quantity));

            if (term2Quantity == null)
                throw new ArgumentNullException(nameof(term2Quantity));

            return term1Quantity.Add(term2Quantity);
        }

        /// <summary>
        /// Add a given value to the value of the left hand side quantity.
        /// </summary>
        /// <param name="termQuantity">The quantity of which the value will act as the first term in the calculation.</param>
        /// <param name="term">The value to add.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="termQuantity"/> is <code>null</code>.</exception>
        public static TQuantity operator +(Quantity<TValue, TUnit, TQuantity> termQuantity, short term)
        {
            if (termQuantity == null)
                throw new ArgumentNullException(nameof(termQuantity));

            return termQuantity.Add(term);
        }

        /// <summary>
        /// Add a given value to the value of the left hand side quantity.
        /// </summary>
        /// <param name="termQuantity">The quantity of which the value will act as the first term in the calculation.</param>
        /// <param name="term">The value to add.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="termQuantity"/> is <code>null</code>.</exception>
        public static TQuantity operator +(Quantity<TValue, TUnit, TQuantity> termQuantity, ushort term)
        {
            if (termQuantity == null)
                throw new ArgumentNullException(nameof(termQuantity));

            return termQuantity.Add(term);
        }

        /// <summary>
        /// Add a given value to the value of the left hand side quantity.
        /// </summary>
        /// <param name="termQuantity">The quantity of which the value will act as the first term in the calculation.</param>
        /// <param name="term">The value to add.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="termQuantity"/> is <code>null</code>.</exception>
        public static TQuantity operator +(Quantity<TValue, TUnit, TQuantity> termQuantity, int term)
        {
            if (termQuantity == null)
                throw new ArgumentNullException(nameof(termQuantity));

            return termQuantity.Add(term);
        }

        /// <summary>
        /// Add a given value to the value of the left hand side quantity.
        /// </summary>
        /// <param name="termQuantity">The quantity of which the value will act as the first term in the calculation.</param>
        /// <param name="term">The value to add.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="termQuantity"/> is <code>null</code>.</exception>
        public static TQuantity operator +(Quantity<TValue, TUnit, TQuantity> termQuantity, uint term)
        {
            if (termQuantity == null)
                throw new ArgumentNullException(nameof(termQuantity));

            return termQuantity.Add(term);
        }

        /// <summary>
        /// Add a given value to the value of the left hand side quantity.
        /// </summary>
        /// <param name="termQuantity">The quantity of which the value will act as the first term in the calculation.</param>
        /// <param name="term">The value to add.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="termQuantity"/> is <code>null</code>.</exception>
        public static TQuantity operator +(Quantity<TValue, TUnit, TQuantity> termQuantity, long term)
        {
            if (termQuantity == null)
                throw new ArgumentNullException(nameof(termQuantity));

            return termQuantity.Add(term);
        }

        /// <summary>
        /// Add a given value to the value of the left hand side quantity.
        /// </summary>
        /// <param name="termQuantity">The quantity of which the value will act as the first term in the calculation.</param>
        /// <param name="term">The value to add.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="termQuantity"/> is <code>null</code>.</exception>
        public static TQuantity operator +(Quantity<TValue, TUnit, TQuantity> termQuantity, ulong term)
        {
            if (termQuantity == null)
                throw new ArgumentNullException(nameof(termQuantity));

            return termQuantity.Add(term);
        }

        /// <summary>
        /// Add a given value to the value of the left hand side quantity.
        /// </summary>
        /// <param name="termQuantity">The quantity of which the value will act as the first term in the calculation.</param>
        /// <param name="term">The value to add.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="termQuantity"/> is <code>null</code>.</exception>
        public static TQuantity operator +(Quantity<TValue, TUnit, TQuantity> termQuantity, double term)
        {
            if (termQuantity == null)
                throw new ArgumentNullException(nameof(termQuantity));

            return termQuantity.Add(term);
        }

        /// <summary>
        /// Add a given value to the value of the left hand side quantity.
        /// </summary>
        /// <param name="termQuantity">The quantity of which the value will act as the first term in the calculation.</param>
        /// <param name="term">The value to add.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="termQuantity"/> is <code>null</code>.</exception>
        public static TQuantity operator +(Quantity<TValue, TUnit, TQuantity> termQuantity, decimal term)
        {
            if (termQuantity == null)
                throw new ArgumentNullException(nameof(termQuantity));

            return termQuantity.Add(term);
        }

        /// <summary>
        /// Add a given value to the value of the left hand side quantity.
        /// </summary>
        /// <param name="termQuantity">The quantity of which the value will act as the first term in the calculation.</param>
        /// <param name="term">The value to add.</param>
        /// <returns>A <see cref="TQuantity"/> with the result of the calculation.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="termQuantity"/> is <code>null</code>.</exception>
        public static TQuantity operator +(Quantity<TValue, TUnit, TQuantity> termQuantity, float term)
        {
            if (termQuantity == null)
                throw new ArgumentNullException(nameof(termQuantity));

            return termQuantity.Add(term);
        }
    }
}