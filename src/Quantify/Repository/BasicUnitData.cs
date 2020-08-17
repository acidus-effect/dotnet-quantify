using System;

namespace Quantify
{
    public class BasicUnitData<TValue, TUnit> : UnitData<TValue, TUnit>
    {
        public virtual TValue Value { get; }
        public virtual TUnit Unit { get; }

        public BasicUnitData(TValue value, TUnit unit)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            if (unit == null)
                throw new ArgumentNullException(nameof(unit));

            Value = value;
            Unit = unit;
        }
    }
}