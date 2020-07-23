namespace Quantify.Test.Assets
{
    public class DoubleValueStringUnitQuantity : Quantity<double, string, DoubleValueStringUnitQuantity>
    {
        public DoubleValueStringUnitQuantity(double value, string unit, QuantityFactory<double, string, DoubleValueStringUnitQuantity> quantityFactory, UnitRepository<double, string> unitRepository, ValueCalculator<double> valueCalculator, IValueConverter<double, string> valueConverter)
            : base(value, unit, quantityFactory, unitRepository, valueCalculator, valueConverter)
        {
        }
    }
}