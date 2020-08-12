namespace Quantify.UnitTests.TestQuantities
{
    public class DoubleValueStringUnitQuantity : Quantity<double, string, DoubleValueStringUnitQuantity>
    {
        internal DoubleValueStringUnitQuantity(double value, string unit, UnitRepository<double, string> unitRepository)
            : base(value, unit, unitRepository)
        {

        }

        internal DoubleValueStringUnitQuantity(double value, string unit, UnitRepository<double, string> unitRepository, ValueCalculator<double> valueCalculator, IValueConverter<double, string> valueConverter)
            : base(value, unit, unitRepository, valueCalculator, valueConverter)
        {
        }
    }
}