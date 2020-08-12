using System;

namespace Quantify
{
    public partial class Quantity<TValue, TUnit, TQuantity>
    {
        public virtual TQuantity Add(TQuantity termQuantity)
        {
            if (termQuantity == null)
                throw new ArgumentNullException(nameof(termQuantity));

            var convertedTermQuantityValue = valueConverter.ConvertValueToUnit(termQuantity.Value, termQuantity.Unit, Unit);
            return Add(convertedTermQuantityValue);
        }

        public virtual TQuantity Add(TValue term)
        {
            if (term == null)
                throw new ArgumentNullException(nameof(term));

            var sum = valueCalculator.Add(Value, term);
            return CreateInstance(sum);
        }

        public virtual TQuantity Add(short term)
        {
            var sum = valueCalculator.Add(Value, term);
            return CreateInstance(sum);
        }

        public virtual TQuantity Add(ushort term)
        {
            var sum = valueCalculator.Add(Value, term);
            return CreateInstance(sum);
        }

        public virtual TQuantity Add(int term)
        {
            var sum = valueCalculator.Add(Value, term);
            return CreateInstance(sum);
        }

        public virtual TQuantity Add(uint term)
        {
            var sum = valueCalculator.Add(Value, term);
            return CreateInstance(sum);
        }

        public virtual TQuantity Add(long term)
        {
            var sum = valueCalculator.Add(Value, term);
            return CreateInstance(sum);
        }

        public virtual TQuantity Add(ulong term)
        {
            var sum = valueCalculator.Add(Value, term);
            return CreateInstance(sum);
        }

        public virtual TQuantity Add(double term)
        {
            var sum = valueCalculator.Add(Value, term);
            return CreateInstance(sum);
        }

        public virtual TQuantity Add(decimal term)
        {
            var sum = valueCalculator.Add(Value, term);
            return CreateInstance(sum);
        }

        public virtual TQuantity Add(float term)
        {
            var sum = valueCalculator.Add(Value, term);
            return CreateInstance(sum);
        }

        public static TQuantity operator +(Quantity<TValue, TUnit, TQuantity> term1Quantity, TQuantity term2Quantity)
        {
            if (term1Quantity == null)
                throw new ArgumentNullException(nameof(term1Quantity));

            if (term2Quantity == null)
                throw new ArgumentNullException(nameof(term2Quantity));

            return term1Quantity.Add(term2Quantity);
        }

        public static TQuantity operator +(Quantity<TValue, TUnit, TQuantity> termQuantity, short term)
        {
            if (termQuantity == null)
                throw new ArgumentNullException(nameof(termQuantity));

            return termQuantity.Add(term);
        }

        public static TQuantity operator +(Quantity<TValue, TUnit, TQuantity> termQuantity, ushort term)
        {
            if (termQuantity == null)
                throw new ArgumentNullException(nameof(termQuantity));

            return termQuantity.Add(term);
        }

        public static TQuantity operator +(Quantity<TValue, TUnit, TQuantity> termQuantity, int term)
        {
            if (termQuantity == null)
                throw new ArgumentNullException(nameof(termQuantity));

            return termQuantity.Add(term);
        }

        public static TQuantity operator +(Quantity<TValue, TUnit, TQuantity> termQuantity, uint term)
        {
            if (termQuantity == null)
                throw new ArgumentNullException(nameof(termQuantity));

            return termQuantity.Add(term);
        }

        public static TQuantity operator +(Quantity<TValue, TUnit, TQuantity> termQuantity, long term)
        {
            if (termQuantity == null)
                throw new ArgumentNullException(nameof(termQuantity));

            return termQuantity.Add(term);
        }

        public static TQuantity operator +(Quantity<TValue, TUnit, TQuantity> termQuantity, ulong term)
        {
            if (termQuantity == null)
                throw new ArgumentNullException(nameof(termQuantity));

            return termQuantity.Add(term);
        }

        public static TQuantity operator +(Quantity<TValue, TUnit, TQuantity> termQuantity, double term)
        {
            if (termQuantity == null)
                throw new ArgumentNullException(nameof(termQuantity));

            return termQuantity.Add(term);
        }

        public static TQuantity operator +(Quantity<TValue, TUnit, TQuantity> termQuantity, decimal term)
        {
            if (termQuantity == null)
                throw new ArgumentNullException(nameof(termQuantity));

            return termQuantity.Add(term);
        }

        public static TQuantity operator +(Quantity<TValue, TUnit, TQuantity> termQuantity, float term)
        {
            if (termQuantity == null)
                throw new ArgumentNullException(nameof(termQuantity));

            return termQuantity.Add(term);
        }
    }
}