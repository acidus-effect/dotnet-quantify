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

            var sourceUnitConversionValue = unitRepository.GetPreciseUnitConversionValue(sourceUnit);
            var targetUnitConversionValue = unitRepository.GetPreciseUnitConversionValue(targetUnit);

            if (sourceUnitConversionValue.HasValue == false)
                throw new UnitNotFoundException<TUnit>(sourceUnit);

            if (targetUnitConversionValue.HasValue == false)
                throw new UnitNotFoundException<TUnit>(targetUnit);

            return valueCalculator.Multiply(value, sourceUnitConversionValue.Value / targetUnitConversionValue.Value);
        }
    }
}