using System;

namespace Quantify
{
    public abstract class Quantity<TValue, TUnit, TQuantity> 
        : IQuantity<TValue, TUnit>, IEquatable<Quantity<TValue, TUnit, TQuantity>> where TQuantity : Quantity<TValue, TUnit, TQuantity>
    {
        public TValue Value { get; }
        public TUnit Unit { get; }

        private readonly QuantityFactory<TValue, TUnit, TQuantity> quantityFactory;
        private readonly UnitRepository<TValue, TUnit> unitRepository;
        private readonly ValueCalculator<TValue> valueCalculator;
        private readonly IValueConverter<TValue, TUnit> valueConverter;

        protected Quantity(
            TValue value,
            TUnit unit,
            QuantityFactory<TValue, TUnit, TQuantity> quantityFactory,
            UnitRepository<TValue, TUnit> unitRepository,
            ValueCalculator<TValue> valueCalculator,
            IValueConverter<TValue, TUnit> valueConverter)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            if (unit == null)
                throw new ArgumentNullException(nameof(unit));

            Value = value;
            Unit = unit;

            this.quantityFactory = quantityFactory ?? throw new ArgumentNullException(nameof(quantityFactory));
            this.unitRepository = unitRepository ?? throw new ArgumentNullException(nameof(unitRepository));
            this.valueCalculator = valueCalculator ?? throw new ArgumentNullException(nameof(valueCalculator));
            this.valueConverter = valueConverter ?? throw new ArgumentNullException(nameof(valueConverter));
        }

        public virtual TQuantity ToUnit(TUnit targetUnit)
        {
            if (targetUnit == null)
                throw new ArgumentNullException(nameof(targetUnit));

            if (Unit.Equals(targetUnit))
                return this as TQuantity;

            var newValue = valueConverter.ConvertValueToUnit(Value, Unit, targetUnit);
            return CreateInstance(newValue, targetUnit);
        }

        private TQuantity CreateInstance(TValue value) => CreateInstance(value, Unit);
        private TQuantity CreateInstance(TValue value, TUnit unit) => quantityFactory.CreateInstance(value, unit, quantityFactory, unitRepository, valueCalculator, valueConverter);

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

        public override bool Equals(object other)
        {
            return Equals(other as Quantity<TValue, TUnit, TQuantity>);
        }

        public override int GetHashCode()
        {
            var hash = 17;
            hash = hash * 23 + Unit.GetHashCode();
            hash = hash * 23 + Value.GetHashCode();
            return hash;
        }

        public TQuantity Add(TQuantity quantity)
        {
            if (quantity == null)
                throw new ArgumentNullException(nameof(quantity));

            var convertedQuantity = quantity.ToUnit(Unit);
            return Add(convertedQuantity.Value);
        }

        public TQuantity Add(TValue value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            var newValue = valueCalculator.Add(Value, value);
            return CreateInstance(newValue);
        }

        public TQuantity Add(int value)
        {
            var newValue = valueCalculator.Add(Value, value);
            return CreateInstance(newValue);
        }

        public static TQuantity operator +(Quantity<TValue, TUnit, TQuantity> quantity, TValue value)
        {
            if (quantity == null)
                throw new ArgumentNullException(nameof(quantity));

            if (value == null)
                throw new ArgumentNullException(nameof(value));

            return quantity.Add(value);
        }

        public static TQuantity operator +(Quantity<TValue, TUnit, TQuantity> quantity, int value)
        {
            if (quantity == null)
                throw new ArgumentNullException(nameof(quantity));

            return quantity.Add(value);
        }

        public TQuantity DivideBy(TQuantity quantity)
        {
            var convertedQuantity = ToUnit(quantity.Unit);
            return DivideBy(convertedQuantity.Value);
        }

        /// <summary>
        /// Returns a new <see cref="QuantityBase"/> with the current <see cref="Value"/> divided by a given denominator.
        /// The <see cref="Unit"/> will remain the same.
        /// </summary>
        /// <param name="denominator">The denominator to divide the current <see cref="Value"/> by.</param>
        /// <returns>A new <see cref="QuantityBase"/> with the current <see cref="Value"/> divided by <paramref name="denominator"/>.</returns>
        /// <exception cref="DivideByZeroException">Is thrown when there is an attempt to divide the <see cref="Value"/> by zero.</exception>
        public TQuantity DivideBy(TValue denominator)
        {
            var newValue = valueCalculator.Divide(Value, denominator);
            return CreateInstance(newValue);
        }

        public TQuantity DivideBy(int denominator)
        {
            var newValue = valueCalculator.Divide(Value, denominator);
            return CreateInstance(newValue);
        }

        public static TQuantity operator /(Quantity<TValue, TUnit, TQuantity> quantity, TValue denominator)
        {
            return quantity.DivideBy(denominator);
        }

        public static TQuantity operator /(Quantity<TValue, TUnit, TQuantity> quantity, int denominator)
        {
            return quantity.DivideBy(denominator);
        }

        public TQuantity MultiplyWith(TQuantity quantity)
        {
            var convertedQuantity = ToUnit(quantity.Unit);
            return MultiplyWith(convertedQuantity.Value);
        }

        public TQuantity MultiplyWith(TValue factor)
        {
            var newValue = valueCalculator.Multiply(Value, factor);
            return CreateInstance(newValue);
        }

        public TQuantity MultiplyWith(int factor)
        {
            var newValue = valueCalculator.Multiply(Value, factor);
            return CreateInstance(newValue);
        }

        public static TQuantity operator *(Quantity<TValue, TUnit, TQuantity> quantity, TValue factor)
        {
            return quantity.MultiplyWith(factor);
        }

        public static TQuantity operator *(Quantity<TValue, TUnit, TQuantity> quantity, int factor)
        {
            return quantity.MultiplyWith(factor);
        }

        public TQuantity Subtract(TQuantity quantity)
        {
            var convertedQuantity = ToUnit(quantity.Unit);
            return Subtract(convertedQuantity.Value);
        }

        public TQuantity Subtract(TValue value)
        {
            var newValue = valueCalculator.Subtract(Value, value);
            return CreateInstance(newValue);
        }

        public TQuantity Subtract(int value)
        {
            var newValue = valueCalculator.Subtract(Value, value);
            return CreateInstance(newValue);
        }

        public static TQuantity operator -(Quantity<TValue, TUnit, TQuantity> quantity, TValue value)
        {
            return quantity.Subtract(value);
        }

        public static TQuantity operator -(Quantity<TValue, TUnit, TQuantity> quantity, int value)
        {
            return quantity.Subtract(value);
        }
    }
}