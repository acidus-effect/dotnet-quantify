namespace Quantify
{
    internal static class ValueCalculatorFactory
    {
        public static ValueCalculator<TValue> Create<TValue>()
        {
            if (typeof(TValue) == typeof(double))
                return (ValueCalculator<TValue>)new DoubleValueCalculator();

            if (typeof(TValue) == typeof(decimal))
                return (ValueCalculator<TValue>)new DecimalValueCalculator();

            throw new GenericArgumentException($"The parameter is not of a valid type. Expected {typeof(double).Name} or {typeof(decimal).Name}.", nameof(TValue), typeof(TValue));
        }
    }
}