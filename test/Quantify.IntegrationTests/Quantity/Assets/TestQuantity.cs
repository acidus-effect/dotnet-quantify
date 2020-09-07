namespace Quantify.IntegrationTests.Quantity.Assets
{
    internal class TestQuantity : Quantity<double, string, TestQuantity>
    {
        internal TestQuantity(double value, string unit, UnitRepository<string> unitRepository, ValueCalculator<double> valueCalculator, ValueConverter<double, string> valueConverter)
            : base(value, unit, unitRepository, valueCalculator, valueConverter)
        {

        }

        internal TestQuantity(double value, string unit, UnitRepository<string> unitRepository)
            : base(value, unit, unitRepository)
        {

        }

        public static TestQuantity Create(double value, string unit)
        {
            var unitRepository = TestData.CreateUnitRepository();
            return new TestQuantity(value, unit, unitRepository);
        }

        protected override TestQuantity CreateInstance(double value, string unit, UnitRepository<string> unitRepository, ValueCalculator<double> valueCalculator, ValueConverter<double, string> valueConverter)
        {
            return new TestQuantity(value, unit, unitRepository, valueCalculator, valueConverter);
        }
    }
}