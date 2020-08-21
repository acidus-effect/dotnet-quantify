using System;

namespace Quantify
{
    internal class ValueConverter<TValue, TUnit> : IValueConverter<TValue, TUnit>
    {
        private readonly UnitConversionDataRepository<TUnit> unitRepository;
        private readonly ValueCalculator<TValue> valueCalculator;

        public ValueConverter(UnitConversionDataRepository<TUnit> unitRepository, ValueCalculator<TValue> valueCalculator)
        {
            this.unitRepository = unitRepository ?? throw new ArgumentNullException(nameof(unitRepository));
            this.valueCalculator = valueCalculator ?? throw new ArgumentNullException(nameof(valueCalculator));
        }

        public TValue ConvertValueToUnit(TValue value, TUnit sourceUnit, TUnit targetUnit)
        {
            if (sourceUnit.Equals(targetUnit))
                return value;

            if (IsPreciseValueType)
            {
                var sourceUnitData = unitRepository.GetPreciseUnitConversionData(sourceUnit);
                var targetUnitData = unitRepository.GetPreciseUnitConversionData(targetUnit);

                return valueCalculator.Multiply(value, sourceUnitData.ConversionRate / targetUnitData.ConversionRate);
            }
            else
            {
                var sourceUnitData = unitRepository.GetUnitConversionData(sourceUnit);
                var targetUnitData = unitRepository.GetUnitConversionData(targetUnit);

                return valueCalculator.Multiply(value, sourceUnitData.ConversionRate / targetUnitData.ConversionRate);
            }
        }

        private bool IsPreciseValueType => typeof(TValue) == typeof(decimal);
    }
}