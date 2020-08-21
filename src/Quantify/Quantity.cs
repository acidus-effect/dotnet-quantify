using System;
using System.Collections.Generic;
using System.Reflection;

namespace Quantify
{
    /// <summary>
    /// Represents a quantity with a value and a unit.
    /// </summary>
    /// <remarks>
    /// A quantity is represented by a value and a unit, and supports a wide range to operations like basic arithmetics, comparision and conversion between different units of the same kind.
    /// </remarks>
    /// <typeparam name="TValue">The type of the value part.</typeparam>
    /// <typeparam name="TUnit">The type of the unit part.</typeparam>
    /// <typeparam name="TQuantity">The type of the inheriting class.</typeparam>
    public abstract partial class Quantity<TValue, TUnit, TQuantity> : IQuantity<TValue, TUnit>, IEquatable<Quantity<TValue, TUnit, TQuantity>> where TQuantity : Quantity<TValue, TUnit, TQuantity>
    {
        /// <summary>
        /// The value.
        /// </summary>
        public TValue Value { get; }

        /// <summary>
        /// The unit of the <see cref="Value"/>.
        /// </summary>
        public TUnit Unit { get; }

        private readonly UnitConversionDataRepository<TUnit> unitRepository;
        private readonly ValueCalculator<TValue> valueCalculator;
        private readonly IValueConverter<TValue, TUnit> valueConverter;

        protected Quantity(TValue value, TUnit unit, UnitConversionDataRepository<TUnit> unitRepository)
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

        protected Quantity(TValue value, TUnit unit, UnitConversionDataRepository<TUnit> unitRepository, ValueCalculator<TValue> valueCalculator, IValueConverter<TValue, TUnit> valueConverter)
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
        /// <param name="targetUnit">The unit the current quantity should be converted to.</param>
        /// <returns>
        /// A <see cref="TQuantity"/> with the converted value and the conversion target unit.
        /// If the <paramref name="targetUnit"/> is the same as the current <see cref="Unit"/>, the same instance will be returned and no conversion will be done.
        /// </returns>
        /// <exception cref="ArgumentNullException"><paramref name="targetUnit"/> is <code>null</code>.</exception>
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

        /// <inheritdoc />
        public override bool Equals(object other)
        {
            return Equals(other as Quantity<TValue, TUnit, TQuantity>);
        }

        /// <summary>
        /// Determines whether the specified quantity is equal to the current quantity.
        /// </summary>
        /// <param name="other">The quantity to compare with the current quantity.</param>
        /// <returns><code>true</code> if the specified quantity is equal to the current quantity; otherwise, <code>false</code>.</returns>
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

        /// <inheritdoc />
        public override int GetHashCode()
        {
            int hashCode = -177567199;
            hashCode = hashCode * -1521134295 + EqualityComparer<TValue>.Default.GetHashCode(Value);
            hashCode = hashCode * -1521134295 + EqualityComparer<TUnit>.Default.GetHashCode(Unit);
            return hashCode;
        }
    }
}