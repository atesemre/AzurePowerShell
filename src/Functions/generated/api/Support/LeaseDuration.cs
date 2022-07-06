// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Support
{

    /// <summary>
    /// Specifies whether the lease on a container is of infinite or fixed duration, only when the container is leased.
    /// </summary>
    public partial struct LeaseDuration :
        System.IEquatable<LeaseDuration>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.LeaseDuration Fixed = @"Fixed";

        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.LeaseDuration Infinite = @"Infinite";

        /// <summary>the value for an instance of the <see cref="LeaseDuration" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to LeaseDuration</summary>
        /// <param name="value">the value to convert to an instance of <see cref="LeaseDuration" />.</param>
        internal static object CreateFrom(object value)
        {
            return new LeaseDuration(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type LeaseDuration</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.LeaseDuration e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type LeaseDuration (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is LeaseDuration && Equals((LeaseDuration)obj);
        }

        /// <summary>Returns hashCode for enum LeaseDuration</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="LeaseDuration"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private LeaseDuration(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for LeaseDuration</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to LeaseDuration</summary>
        /// <param name="value">the value to convert to an instance of <see cref="LeaseDuration" />.</param>

        public static implicit operator LeaseDuration(string value)
        {
            return new LeaseDuration(value);
        }

        /// <summary>Implicit operator to convert LeaseDuration to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="LeaseDuration" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.LeaseDuration e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum LeaseDuration</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.LeaseDuration e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.LeaseDuration e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum LeaseDuration</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.LeaseDuration e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.LeaseDuration e2)
        {
            return e2.Equals(e1);
        }
    }
}