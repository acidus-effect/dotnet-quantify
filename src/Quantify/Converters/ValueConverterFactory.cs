using System;

namespace Quantify
{
    internal class ValueConverterFactory<TValue, TUnit>
    {
        private readonly UnitRepository<TUnit> unitRepository;
        private readonly ValueCalculator<TValue> valueCalculator;

        public ValueConverterFactory(UnitRepository<TUnit> unitRepository, ValueCalculator<TValue> valueCalculator)
        {
            this.unitRepository = unitRepository ?? throw new ArgumentNullException(nameof(unitRepository));
            this.valueCalculator = valueCalculator ?? throw new ArgumentNullException(nameof(valueCalculator));
        }

        public ValueConverter<TValue, TUnit> Create()
        {
            if (IsPreciseValueType)
                return new PreciseValueConverter<TValue, TUnit>(unitRepository, valueCalculator);

            return new RegularValueConverter<TValue, TUnit>(unitRepository, valueCalculator);
        }

        private bool IsPreciseValueType => typeof(TValue) == typeof(decimal);
    }
}