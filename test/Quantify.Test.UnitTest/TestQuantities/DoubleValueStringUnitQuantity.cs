namespace Quantify.Test.UnitTest.TestQuantities
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

        protected override DoubleValueStringUnitQuantity CreateInstance(double value, string unit, UnitRepository<string> unitRepository, ValueCalculator<double> valueCalculator, ValueConverter<double, string> valueConverter)
        {
            return new DoubleValueStringUnitQuantity(value, unit, unitRepository, valueCalculator, valueConverter);
        }
    }
}