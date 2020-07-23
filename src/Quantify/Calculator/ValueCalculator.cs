namespace Quantify
{
    public interface ValueCalculator<TValue>
    {
        TValue Add(TValue term1, int term2);
        TValue Add(TValue term1, TValue term2);

        TValue Subtract(TValue term1, int term2);
        TValue Subtract(TValue term1, TValue term2);

        TValue Multiply(TValue multiplicand, int multiplier);
        TValue Multiply(TValue multiplicand, TValue multiplier);

        TValue Divide(TValue numerator, int denominator);
        TValue Divide(TValue numerator, TValue denominator);
    }
}