namespace Quantify.Test.Assets
{
    public class StringValueStringUnitQuantity : Quantity<string, string, StringValueStringUnitQuantity>
    {
        public StringValueStringUnitQuantity(string value, string unit, UnitRepository<string, string> unitRepository)
            : base(value, unit, unitRepository)
        {

        }

        public StringValueStringUnitQuantity(string value, string unit, UnitRepository<string, string> unitRepository, ValueCalculator<string> valueCalculator, IValueConverter<string, string> valueConverter)
            : base(value, unit, unitRepository, valueCalculator, valueConverter)
        {

        }
    }
}