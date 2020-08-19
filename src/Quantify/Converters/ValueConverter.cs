using System;

namespace Quantify
{
    internal class ValueConverter<TValue, TUnit> : IValueConverter<TValue, TUnit>
    {
        private readonly UnitRepository<TValue, TUnit> unitRepository;
        private readonly ValueCalculator<TValue> valueCalculator;

        public ValueConverter(UnitRepository<TValue, TUnit> unitRepository, ValueCalculator<TValue> valueCalculator)
        {
            this.unitRepository = unitRepository ?? throw new ArgumentNullException(nameof(unitRepository));
            this.valueCalculator = valueCalculator ?? throw new ArgumentNullException(nameof(valueCalculator));
        }

        public TValue ConvertValueToUnit(TValue value, TUnit sourceUnit, TUnit targetUnit)
        {
            if (sourceUnit.Equals(targetUnit))
                return value;

            var sourceUnitData = unitRepository.GetUnitData(sourceUnit);
            var targetUnitData = unitRepository.GetUnitData(targetUnit);

            return valueCalculator.Multiply(value, valueCalculator.Divide(sourceUnitData.ConversionRate, targetUnitData.ConversionRate));
        }
    }
}