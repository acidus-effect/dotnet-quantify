using System;
using System.Collections.Generic;
using System.Text;

namespace Quantify
{
    internal class PreciseValueConverter<TValue, TUnit> : ValueConverter<TValue, TUnit>
    {
        private readonly UnitRepository<TUnit> unitRepository;
        private readonly ValueCalculator<TValue> valueCalculator;

        public PreciseValueConverter(UnitRepository<TUnit> unitRepository, ValueCalculator<TValue> valueCalculator)
        {
            this.unitRepository = unitRepository ?? throw new ArgumentNullException(nameof(unitRepository));
            this.valueCalculator = valueCalculator ?? throw new ArgumentNullException(nameof(valueCalculator));
        }

        public TValue ConvertValueToUnit(TValue value, TUnit sourceUnit, TUnit targetUnit)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            if (sourceUnit == null) throw new ArgumentNullException(nameof(sourceUnit));
            if (targetUnit == null) throw new ArgumentNullException(nameof(targetUnit));

            if (sourceUnit.Equals(targetUnit))
                return value;

            var sourceUnitConversionRate = unitRepository.GetPreciseUnitConversionRate(sourceUnit);
            var targetUnitConversionRate = unitRepository.GetPreciseUnitConversionRate(targetUnit);

            if (sourceUnitConversionRate.HasValue == false)
                throw new UnitNotFoundException<TUnit>(sourceUnit);

            if (targetUnitConversionRate.HasValue == false)
                throw new UnitNotFoundException<TUnit>(targetUnit);

            return valueCalculator.Multiply(value, sourceUnitConversionRate.Value / targetUnitConversionRate.Value);
        }
    }
}