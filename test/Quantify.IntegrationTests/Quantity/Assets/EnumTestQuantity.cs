using Quantify.Test.Shared;

namespace Quantify.IntegrationTest.Quantity.Assets
{
    internal class EnumTestQuantity : Quantity<double, TestUnit, EnumTestQuantity>
    {
        public EnumTestQuantity(double value, TestUnit unit, QuantityFactory<double, TestUnit, EnumTestQuantity> quantityFactory, UnitRepository<double, TestUnit> unitRepository, ValueCalculator<double> valueCalculator, IValueConverter<double, TestUnit> valueConverter)
            : base(value, unit, quantityFactory, unitRepository, valueCalculator, valueConverter)
        {

        }

        public static EnumTestQuantity Create(double value, TestUnit unit)
        {
            var quantityFactory = new LengthQuantityFactory();
            var unitRepository = EnumUnitRepository<double, TestUnit>.CreateInstance();
            var valueCalculator = ValueCalculatorFactory.Create<double>();
            var valueConverter = new ValueConverter<double, TestUnit>(unitRepository, valueCalculator);
            return new EnumTestQuantity(value, unit, quantityFactory, unitRepository, valueCalculator, valueConverter);
        }

        private class LengthQuantityFactory : QuantityFactory<double, TestUnit, EnumTestQuantity>
        {
            EnumTestQuantity QuantityFactory<double, TestUnit, EnumTestQuantity>.CreateInstance(double value, TestUnit unit, QuantityFactory<double, TestUnit, EnumTestQuantity> quantityFactory, UnitRepository<double, TestUnit> unitRepository, ValueCalculator<double> valueCalculator, IValueConverter<double, TestUnit> valueConverter)
            {
                return new EnumTestQuantity(value, unit, quantityFactory, unitRepository, valueCalculator, valueConverter);
            }
        }
    }
}