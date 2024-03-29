﻿using System;
using System.Collections.Generic;

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

        private readonly UnitRepository<TUnit> _unitRepository;
        private readonly ValueCalculator<TValue> _valueCalculator;
        private readonly ValueConverter<TValue, TUnit> _valueConverter;

        protected Quantity(TValue value, TUnit unit, UnitRepository<TUnit> unitRepository, ValueCalculator<TValue> valueCalculator = null, ValueConverter<TValue, TUnit> valueConverter = null)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            if (unit == null)
                throw new ArgumentNullException(nameof(unit));

            Value = value;
            Unit = unit;

            _unitRepository = unitRepository ?? throw new ArgumentNullException(nameof(unitRepository));
            _valueCalculator = valueCalculator ?? ValueCalculatorFactory.Create<TValue>();
            _valueConverter = valueConverter ?? new ValueConverterFactory<TValue, TUnit>(_unitRepository, _valueCalculator).Create();
        }

        protected abstract TQuantity CreateInstance(TValue value, TUnit unit, UnitRepository<TUnit> unitRepository, ValueCalculator<TValue> valueCalculator, ValueConverter<TValue, TUnit> valueConverter);

        private TQuantity CreateInstance(TValue value) => CreateInstance(value, Unit);
        private TQuantity CreateInstance(TValue value, TUnit unit) => CreateInstance(value, unit, _unitRepository, _valueCalculator, _valueConverter);

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