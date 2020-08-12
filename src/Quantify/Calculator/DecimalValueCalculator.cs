using System;

namespace Quantify
{
    internal class DecimalValueCalculator : ValueCalculator<decimal>
    {
        public decimal Add(decimal term1, short term2)
        {
            return term1 + term2;
        }

        public decimal Add(decimal term1, ushort term2)
        {
            return term1 + term2;
        }

        public decimal Add(decimal term1, int term2)
        {
            return term1 + term2;
        }

        public decimal Add(decimal term1, uint term2)
        {
            return term1 + term2;
        }

        public decimal Add(decimal term1, long term2)
        {
            return term1 + term2;
        }

        public decimal Add(decimal term1, ulong term2)
        {
            return term1 + term2;
        }

        public decimal Add(decimal term1, double term2)
        {
            return term1 + Convert.ToDecimal(term2);
        }

        public decimal Add(decimal term1, decimal term2)
        {
            return term1 + term2;
        }

        public decimal Add(decimal term1, float term2)
        {
            return term1 + Convert.ToDecimal(term2);
        }

        public decimal Divide(decimal dividend, short divisor)
        {
            return dividend / divisor;
        }

        public decimal Divide(decimal dividend, ushort divisor)
        {
            return dividend / divisor;
        }

        public decimal Divide(decimal dividend, int divisor)
        {
            return dividend / divisor;
        }

        public decimal Divide(decimal dividend, uint divisor)
        {
            return dividend / divisor;
        }

        public decimal Divide(decimal dividend, long divisor)
        {
            return dividend / divisor;
        }

        public decimal Divide(decimal dividend, ulong divisor)
        {
            return dividend / divisor;
        }

        public decimal Divide(decimal dividend, double divisor)
        {
            return dividend / Convert.ToDecimal(divisor);
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return dividend / divisor;
        }

        public decimal Divide(decimal dividend, float divisor)
        {
            return dividend / Convert.ToDecimal(divisor);
        }

        public decimal Multiply(decimal multiplicand, short multiplier)
        {
            return multiplicand * multiplier;
        }

        public decimal Multiply(decimal multiplicand, ushort multiplier)
        {
            return multiplicand * multiplier;
        }

        public decimal Multiply(decimal multiplicand, int multiplier)
        {
            return multiplicand * multiplier;
        }

        public decimal Multiply(decimal multiplicand, uint multiplier)
        {
            return multiplicand * multiplier;
        }

        public decimal Multiply(decimal multiplicand, long multiplier)
        {
            return multiplicand * multiplier;
        }

        public decimal Multiply(decimal multiplicand, ulong multiplier)
        {
            return multiplicand * multiplier;
        }

        public decimal Multiply(decimal multiplicand, double multiplier)
        {
            return multiplicand * Convert.ToDecimal(multiplier);
        }

        public decimal Multiply(decimal multiplicand, decimal multiplier)
        {
            return multiplicand * multiplier;
        }

        public decimal Multiply(decimal multiplicand, float multiplier)
        {
            return multiplicand * Convert.ToDecimal(multiplier);
        }

        public decimal Subtract(decimal minuend, short term2)
        {
            return minuend - term2;
        }

        public decimal Subtract(decimal minuend, ushort term2)
        {
            return minuend - term2;
        }

        public decimal Subtract(decimal minuend, int term2)
        {
            return minuend - term2;
        }

        public decimal Subtract(decimal minuend, uint term2)
        {
            return minuend - term2;
        }

        public decimal Subtract(decimal minuend, long term2)
        {
            return minuend - term2;
        }

        public decimal Subtract(decimal minuend, ulong term2)
        {
            return minuend - term2;
        }

        public decimal Subtract(decimal minuend, double term2)
        {
            return minuend - Convert.ToDecimal(term2);
        }

        public decimal Subtract(decimal minuend, decimal term2)
        {
            return minuend - term2;
        }

        public decimal Subtract(decimal minuend, float term2)
        {
            return minuend - Convert.ToDecimal(term2);
        }
    }
}