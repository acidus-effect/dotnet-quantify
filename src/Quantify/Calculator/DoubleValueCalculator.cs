using System;

namespace Quantify
{
    internal class DoubleValueCalculator : ValueCalculator<double>
    {
        public double Add(double term1, short term2)
        {
            return term1 + term2;
        }

        public double Add(double term1, ushort term2)
        {
            return term1 + term2;
        }

        public double Add(double term1, int term2)
        {
            return term1 + term2;
        }

        public double Add(double term1, uint term2)
        {
            return term1 + term2;
        }

        public double Add(double term1, long term2)
        {
            return term1 + term2;
        }

        public double Add(double term1, ulong term2)
        {
            return term1 + term2;
        }

        public double Add(double term1, double term2)
        {
            return term1 + term2;
        }

        public double Add(double term1, decimal term2)
        {
            return term1 + Convert.ToDouble(term2);
        }

        public double Add(double term1, float term2)
        {
            return term1 + Convert.ToDouble(term2);
        }

        public double Divide(double dividend, short divisor)
        {
            return dividend / divisor;
        }

        public double Divide(double dividend, ushort divisor)
        {
            return dividend / divisor;
        }

        public double Divide(double dividend, int divisor)
        {
            return dividend / divisor;
        }

        public double Divide(double dividend, uint divisor)
        {
            return dividend / divisor;
        }

        public double Divide(double dividend, long divisor)
        {
            return dividend / divisor;
        }

        public double Divide(double dividend, ulong divisor)
        {
            return dividend / divisor;
        }

        public double Divide(double dividend, double divisor)
        {
            return dividend / divisor;
        }

        public double Divide(double dividend, decimal divisor)
        {
            return dividend / Convert.ToDouble(divisor);
        }

        public double Divide(double dividend, float divisor)
        {
            return dividend / Convert.ToDouble(divisor);
        }

        public double Multiply(double multiplicand, short multiplier)
        {
            return multiplicand * multiplier;
        }

        public double Multiply(double multiplicand, ushort multiplier)
        {
            return multiplicand * multiplier;
        }

        public double Multiply(double multiplicand, int multiplier)
        {
            return multiplicand * multiplier;
        }

        public double Multiply(double multiplicand, uint multiplier)
        {
            return multiplicand * multiplier;
        }

        public double Multiply(double multiplicand, long multiplier)
        {
            return multiplicand * multiplier;
        }

        public double Multiply(double multiplicand, ulong multiplier)
        {
            return multiplicand * multiplier;
        }

        public double Multiply(double multiplicand, double multiplier)
        {
            return multiplicand * multiplier;
        }

        public double Multiply(double multiplicand, decimal multiplier)
        {
            return multiplicand * Convert.ToDouble(multiplier);
        }

        public double Multiply(double multiplicand, float multiplier)
        {
            return multiplicand * Convert.ToDouble(multiplier);
        }

        public double Subtract(double minuend, short subtrahend)
        {
            return minuend - subtrahend;
        }

        public double Subtract(double minuend, ushort subtrahend)
        {
            return minuend - subtrahend;
        }

        public double Subtract(double minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        public double Subtract(double minuend, uint subtrahend)
        {
            return minuend - subtrahend;
        }

        public double Subtract(double minuend, long subtrahend)
        {
            return minuend - subtrahend;
        }

        public double Subtract(double minuend, ulong subtrahend)
        {
            return minuend - subtrahend;
        }

        public double Subtract(double minuend, double subtrahend)
        {
            return minuend - subtrahend;
        }

        public double Subtract(double minuend, decimal subtrahend)
        {
            return minuend - Convert.ToDouble(subtrahend);
        }

        public double Subtract(double minuend, float subtrahend)
        {
            return minuend - Convert.ToDouble(subtrahend);
        }
    }
}