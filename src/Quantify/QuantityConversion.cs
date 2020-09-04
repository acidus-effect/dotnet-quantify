using System;

namespace Quantify
{
    public partial class Quantity<TValue, TUnit, TQuantity>
    {
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
    }
}