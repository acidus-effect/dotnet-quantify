namespace Quantify.Test.Assets
{
    public class DoubleValueStringUnitQuantity : Quantity<double, string, DoubleValueStringUnitQuantity>
    {
        public DoubleValueStringUnitQuantity(double value, string unit, UnitRepository<double, string> unitRepository)
            : base(value, unit, unitRepository)
        {

        }

        public DoubleValueStringUnitQuantity(double value, string unit, UnitRepository<double, string> unitRepository, ValueCalculator<double> valueCalculator, IValueConverter<double, string> valueConverter)
            : base(value, unit, unitRepository, valueCalculator, valueConverter)
        {
        }
    }
}