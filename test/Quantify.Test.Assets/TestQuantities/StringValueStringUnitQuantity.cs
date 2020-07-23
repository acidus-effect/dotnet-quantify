namespace Quantify.Test.Assets
{
    public class StringValueStringUnitQuantity : Quantity<string, string, StringValueStringUnitQuantity>
    {
        public StringValueStringUnitQuantity(string value, string unit, QuantityFactory<string, string, StringValueStringUnitQuantity> quantityFactory, UnitRepository<string, string> unitRepository, ValueCalculator<string> valueCalculator, IValueConverter<string, string> valueConverter)
            : base(value, unit, quantityFactory, unitRepository, valueCalculator, valueConverter)
        {

        }
    }
}