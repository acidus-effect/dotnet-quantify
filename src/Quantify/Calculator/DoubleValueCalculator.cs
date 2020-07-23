namespace Quantify
{
    internal class DoubleValueCalculator : ValueCalculator<double>
    {
        public double Add(double term1, int term2)
        {
            return term1 + term2;
        }

        public double Add(double term1, double term2)
        {
            return term1 + term2;
        }

        public double Divide(double numerator, int denominator)
        {
            return numerator / denominator;
        }

        public double Divide(double numerator, double denominator)
        {
            return numerator / denominator;
        }

        public double Multiply(double multiplicand, int multiplier)
        {
            return multiplicand * multiplier;
        }

        public double Multiply(double multiplicand, double multiplier)
        {
            return multiplicand * multiplier;
        }

        public double Subtract(double term1, int term2)
        {
            return term1 - term2;
        }

        public double Subtract(double term1, double term2)
        {
            return term1 - term2;
        }
    }
}