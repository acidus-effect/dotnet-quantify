using System;

namespace Quantify
{
    public class UnitData<TValue, TUnit>
    {
        public TUnit Unit { get; }
        public TValue Value { get; }

        public UnitData(TUnit unit, TValue value)
        {
            if (unit == null)
                throw new ArgumentNullException(nameof(unit));

            if (value == null)
                throw new ArgumentNullException(nameof(value));

            Unit = unit;
            Value = value;
        }
    }
}