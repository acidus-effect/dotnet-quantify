namespace Quantify
{
    public interface ValueCalculator<TValue>
    {
        TValue Add(TValue term1, TValue term2);
        TValue Add(TValue term1, short term2);
        TValue Add(TValue term1, ushort term2);
        TValue Add(TValue term1, int term2);
        TValue Add(TValue term1, uint term2);
        TValue Add(TValue term1, long term2);
        TValue Add(TValue term1, ulong term2);
        TValue Add(TValue term1, double term2);
        TValue Add(TValue term1, decimal term2);
        TValue Add(TValue term1, float term2);

        TValue Subtract(TValue minuend, TValue subtrahend);
        TValue Subtract(TValue minuend, short subtrahend);
        TValue Subtract(TValue minuend, ushort subtrahend);
        TValue Subtract(TValue minuend, int subtrahend);
        TValue Subtract(TValue minuend, uint subtrahend);
        TValue Subtract(TValue minuend, long subtrahend);
        TValue Subtract(TValue minuend, ulong subtrahend);
        TValue Subtract(TValue minuend, double subtrahend);
        TValue Subtract(TValue minuend, decimal subtrahend);
        TValue Subtract(TValue minuend, float subtrahend);

        TValue Multiply(TValue multiplicand, TValue multiplier);
        TValue Multiply(TValue multiplicand, short multiplier);
        TValue Multiply(TValue multiplicand, ushort multiplier);
        TValue Multiply(TValue multiplicand, int multiplier);
        TValue Multiply(TValue multiplicand, uint multiplier);
        TValue Multiply(TValue multiplicand, long multiplier);
        TValue Multiply(TValue multiplicand, ulong multiplier);
        TValue Multiply(TValue multiplicand, double multiplier);
        TValue Multiply(TValue multiplicand, decimal multiplier);
        TValue Multiply(TValue multiplicand, float multiplier);

        TValue Divide(TValue dividend, TValue divisor);
        TValue Divide(TValue dividend, short divisor);
        TValue Divide(TValue dividend, ushort divisor);
        TValue Divide(TValue dividend, int divisor);
        TValue Divide(TValue dividend, uint divisor);
        TValue Divide(TValue dividend, long divisor);
        TValue Divide(TValue dividend, ulong divisor);
        TValue Divide(TValue dividend, double divisor);
        TValue Divide(TValue dividend, decimal divisor);
        TValue Divide(TValue dividend, float divisor);
    }
}