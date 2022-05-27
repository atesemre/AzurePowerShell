// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support
{

    /// <summary>
    /// Provisioning substate shows the progress of custom HTTPS enabling/disabling process step by step. DCV stands for DomainControlValidation.
    /// </summary>
    public partial struct DomainValidationState :
        System.IEquatable<DomainValidationState>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DomainValidationState Approved = @"Approved";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DomainValidationState InternalError = @"InternalError";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DomainValidationState Pending = @"Pending";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DomainValidationState PendingRevalidation = @"PendingRevalidation";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DomainValidationState RefreshingValidationToken = @"RefreshingValidationToken";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DomainValidationState Rejected = @"Rejected";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DomainValidationState Submitting = @"Submitting";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DomainValidationState TimedOut = @"TimedOut";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DomainValidationState Unknown = @"Unknown";

        /// <summary>the value for an instance of the <see cref="DomainValidationState" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to DomainValidationState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DomainValidationState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new DomainValidationState(global::System.Convert.ToString(value));
        }

        /// <summary>Creates an instance of the <see cref="DomainValidationState"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private DomainValidationState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Compares values of enum type DomainValidationState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DomainValidationState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type DomainValidationState (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is DomainValidationState && Equals((DomainValidationState)obj);
        }

        /// <summary>Returns hashCode for enum DomainValidationState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for DomainValidationState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to DomainValidationState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DomainValidationState" />.</param>

        public static implicit operator DomainValidationState(string value)
        {
            return new DomainValidationState(value);
        }

        /// <summary>Implicit operator to convert DomainValidationState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="DomainValidationState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DomainValidationState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum DomainValidationState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DomainValidationState e1, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DomainValidationState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum DomainValidationState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DomainValidationState e1, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.DomainValidationState e2)
        {
            return e2.Equals(e1);
        }
    }
}