using System;
using System.Collections.Generic;
using System.Text;

namespace Quantify
{
    public partial class Quantity<TValue, TUnit, TQuantity>
    {
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
    }
}