namespace Quantify.UnitTests.TestQuantities
{
    public class DoubleValueStringUnitQuantity : Quantity<double, string, DoubleValueStringUnitQuantity>
    {
        internal DoubleValueStringUnitQuantity(double value, string unit, UnitRepository<string> unitRepository)
            : base(value, unit, unitRepository)
        {

        }

        internal DoubleValueStringUnitQuantity(double value, string unit, UnitRepository<string> unitRepository, ValueCalculator<double> valueCalculator, ValueConverter<double, string> valueConverter)
            : base(value, unit, unitRepository, valueCalculator, valueConverter)
        {
        }
    }
}