namespace Quantify
{
    internal class DecimalValueCalculator : ValueCalculator<decimal>
    {
        public decimal Add(decimal term1, int term2)
        {
            return term1 + term2;
        }

        public decimal Add(decimal term1, decimal term2)
        {
            return term1 + term2;
        }

        public decimal Divide(decimal numerator, int denominator)
        {
            return numerator / denominator;
        }

        public decimal Divide(decimal numerator, decimal denominator)
        {
            return numerator / denominator;
        }

        public decimal Multiply(decimal multiplicand, int multiplier)
        {
            return multiplicand * multiplier;
        }

        public decimal Multiply(decimal multiplicand, decimal multiplier)
        {
            return multiplicand * multiplier;
        }

        public decimal Subtract(decimal term1, int term2)
        {
            return term1 - term2;
        }

        public decimal Subtract(decimal term1, decimal term2)
        {
            return term1 - term2;
        }
    }
}