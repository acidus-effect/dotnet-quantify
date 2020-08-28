namespace Quantify.UnitTests.TestQuantities
{
    public class StringValueStringUnitQuantity : Quantity<string, string, StringValueStringUnitQuantity>
    {
        public StringValueStringUnitQuantity(string value, string unit, UnitRepository<string> unitRepository)
            : base(value, unit, unitRepository)
        {

        }

        public StringValueStringUnitQuantity(string value, string unit, UnitRepository<string> unitRepository, ValueCalculator<string> valueCalculator, ValueConverter<string, string> valueConverter)
            : base(value, unit, unitRepository, valueCalculator, valueConverter)
        {

        }
    }
}