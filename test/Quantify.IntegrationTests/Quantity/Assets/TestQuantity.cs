namespace Quantify.IntegrationTests.Quantity.Assets
{
    internal class TestQuantity : Quantity<double, string, TestQuantity>
    {
        internal TestQuantity(double value, string unit, UnitConversionDataRepository<string> unitRepository, ValueCalculator<double> valueCalculator, IValueConverter<double, string> valueConverter)
            : base(value, unit, unitRepository, valueCalculator, valueConverter)
        {

        }

        internal TestQuantity(double value, string unit, UnitConversionDataRepository<string> unitRepository)
            : base(value, unit, unitRepository)
        {

        }

        public static TestQuantity Create(double value, string unit)
        {
            var unitRepository = TestData.CreateUnitRepository();
            return new TestQuantity(value, unit, unitRepository);
        }
    }
}