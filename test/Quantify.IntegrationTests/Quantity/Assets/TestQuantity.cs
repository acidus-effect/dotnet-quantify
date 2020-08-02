namespace Quantify.IntegrationTests.Quantity.Assets
{
    internal class TestQuantity : Quantity<double, string, TestQuantity>
    {
        public TestQuantity(double value, string unit, UnitRepository<double, string> unitRepository, ValueCalculator<double> valueCalculator, IValueConverter<double, string> valueConverter)
            : base(value, unit, unitRepository, valueCalculator, valueConverter)
        {

        }

        public static TestQuantity Create(double value, string unit)
        {
            var unitRepository = TestData.CreateUnitRepository();
            var valueCalculator = ValueCalculatorFactory.Create<double>();
            var valueConverter = new ValueConverter<double, string>(unitRepository, valueCalculator);
            return new TestQuantity(value, unit, unitRepository, valueCalculator, valueConverter);
        }
    }
}