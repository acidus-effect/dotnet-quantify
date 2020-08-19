using System;
using System.Collections.Generic;
using System.Reflection;

namespace Quantify
{
    public abstract partial class Quantity<TValue, TUnit, TQuantity> : IQuantity<TValue, TUnit>, IEquatable<Quantity<TValue, TUnit, TQuantity>> where TQuantity : Quantity<TValue, TUnit, TQuantity>
    {
        public TValue Value { get; }
        public TUnit Unit { get; }

        private readonly UnitRepository<TValue, TUnit> unitRepository;
        private readonly ValueCalculator<TValue> valueCalculator;
        private readonly IValueConverter<TValue, TUnit> valueConverter;

        protected Quantity(TValue value, TUnit unit, UnitRepository<TValue, TUnit> unitRepository)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            if (unit == null)
                throw new ArgumentNullException(nameof(unit));

            Value = value;
            Unit = unit;

            this.unitRepository = unitRepository ?? throw new ArgumentNullException(nameof(unitRepository));
            this.valueCalculator = ValueCalculatorFactory.Create<TValue>();
            this.valueConverter = new ValueConverter<TValue, TUnit>(unitRepository, valueCalculator);
        }

        protected Quantity(TValue value, TUnit unit, UnitRepository<TValue, TUnit> unitRepository, ValueCalculator<TValue> valueCalculator, IValueConverter<TValue, TUnit> valueConverter)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            if (unit == null)
                throw new ArgumentNullException(nameof(unit));

            Value = value;
            Unit = unit;

            this.unitRepository = unitRepository ?? throw new ArgumentNullException(nameof(unitRepository));
            this.valueCalculator = valueCalculator ?? throw new ArgumentNullException(nameof(valueCalculator));
            this.valueConverter = valueConverter ?? throw new ArgumentNullException(nameof(valueConverter));
        }

        /// <summary>
        /// Convert the quantity to a different unit.
        /// </summary>
        /// <param name="targetUnit">The unit this quantity should be converted to.</param>
        /// <returns>A new <see cref="TQuantity"/> with the converted value and the conversion target unit.</returns>
        public virtual TQuantity ToUnit(TUnit targetUnit)
        {
            if (targetUnit == null)
                throw new ArgumentNullException(nameof(targetUnit));

            if (Unit.Equals(targetUnit))
                return this as TQuantity;

            var convertedValue = valueConverter.ConvertValueToUnit(Value, Unit, targetUnit);
            return CreateInstance(convertedValue, targetUnit);
        }

        private TQuantity CreateInstance(TValue value) => CreateInstance(value, Unit);
        private TQuantity CreateInstance(TValue value, TUnit unit) => (TQuantity)Activator.CreateInstance(typeof(TQuantity), BindingFlags.Instance | BindingFlags.NonPublic, null, new object[] { value, unit, unitRepository, valueCalculator, valueConverter }, null);

        public override bool Equals(object other)
        {
            return Equals(other as Quantity<TValue, TUnit, TQuantity>);
        }

        public bool Equals(Quantity<TValue, TUnit, TQuantity> other)
        {
            if (other == null)
                return false;

            if (ReferenceEquals(this, other))
                return true;

            if (Value.Equals(other.Value) == false)
                return false;

            if (Unit.Equals(other.Unit) == false)
                return false;

            return true;
        }

        public override int GetHashCode()
        {
            int hashCode = -177567199;
            hashCode = hashCode * -1521134295 + EqualityComparer<TValue>.Default.GetHashCode(Value);
            hashCode = hashCode * -1521134295 + EqualityComparer<TUnit>.Default.GetHashCode(Unit);
            return hashCode;
        }
    }
}