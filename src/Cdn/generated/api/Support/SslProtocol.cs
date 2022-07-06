// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support
{

    /// <summary>The protocol of an established TLS connection.</summary>
    public partial struct SslProtocol :
        System.IEquatable<SslProtocol>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SslProtocol TlSv1 = @"TLSv1";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SslProtocol TlSv11 = @"TLSv1.1";

        public static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SslProtocol TlSv12 = @"TLSv1.2";

        /// <summary>the value for an instance of the <see cref="SslProtocol" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to SslProtocol</summary>
        /// <param name="value">the value to convert to an instance of <see cref="SslProtocol" />.</param>
        internal static object CreateFrom(object value)
        {
            return new SslProtocol(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type SslProtocol</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SslProtocol e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type SslProtocol (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is SslProtocol && Equals((SslProtocol)obj);
        }

        /// <summary>Returns hashCode for enum SslProtocol</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="SslProtocol"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private SslProtocol(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for SslProtocol</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to SslProtocol</summary>
        /// <param name="value">the value to convert to an instance of <see cref="SslProtocol" />.</param>

        public static implicit operator SslProtocol(string value)
        {
            return new SslProtocol(value);
        }

        /// <summary>Implicit operator to convert SslProtocol to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="SslProtocol" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SslProtocol e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum SslProtocol</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SslProtocol e1, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SslProtocol e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum SslProtocol</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SslProtocol e1, Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.SslProtocol e2)
        {
            return e2.Equals(e1);
        }
    }
}