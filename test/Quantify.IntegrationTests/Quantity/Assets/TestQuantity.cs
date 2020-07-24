namespace Quantify.IntegrationTests.Quantity.Assets
{
    internal class TestQuantity : Quantity<double, string, TestQuantity>
    {
        public TestQuantity(double value, string unit, QuantityFactory<double, string, TestQuantity> quantityFactory, UnitRepository<double, string> unitRepository, ValueCalculator<double> valueCalculator, IValueConverter<double, string> valueConverter)
            : base(value, unit, quantityFactory, unitRepository, valueCalculator, valueConverter)
        {

        }

        public static TestQuantity Create(double value, string unit)
        {
            var quantityFactory = new TestQuantityBuilder();
            var unitRepository = TestData.CreateUnitRepository();
            var valueCalculator = ValueCalculatorFactory.Create<double>();
            var valueConverter = new ValueConverter<double, string>(unitRepository, valueCalculator);
            return new TestQuantity(value, unit, quantityFactory, unitRepository, valueCalculator, valueConverter);
        }

        private class TestQuantityBuilder : QuantityFactory<double, string, TestQuantity>
        {
            TestQuantity QuantityFactory<double, string, TestQuantity>.CreateInstance(double value, string unit, QuantityFactory<double, string, TestQuantity> quantityFactory, UnitRepository<double, string> unitRepository, ValueCalculator<double> valueCalculator, IValueConverter<double, string> valueConverter)
            {
                return new TestQuantity(value, unit, quantityFactory, unitRepository, valueCalculator, valueConverter);
            }
        }
    }
}