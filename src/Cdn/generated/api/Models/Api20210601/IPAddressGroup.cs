// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>CDN Ip address group</summary>
    public partial class IPAddressGroup :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IIPAddressGroup,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.IIPAddressGroupInternal
    {

        /// <summary>Backing field for <see cref="DeliveryRegion" /> property.</summary>
        private string _deliveryRegion;

        /// <summary>The delivery region of the ip address group</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string DeliveryRegion { get => this._deliveryRegion; set => this._deliveryRegion = value; }

        /// <summary>Backing field for <see cref="Ipv4Address" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ICidrIPAddress[] _ipv4Address;

        /// <summary>The list of ip v4 addresses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ICidrIPAddress[] Ipv4Address { get => this._ipv4Address; set => this._ipv4Address = value; }

        /// <summary>Backing field for <see cref="Ipv6Address" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ICidrIPAddress[] _ipv6Address;

        /// <summary>The list of ip v6 addresses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ICidrIPAddress[] Ipv6Address { get => this._ipv6Address; set => this._ipv6Address = value; }

        /// <summary>Creates an new <see cref="IPAddressGroup" /> instance.</summary>
        public IPAddressGroup()
        {

        }
    }
    /// CDN Ip address group
    public partial interface IIPAddressGroup :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable
    {
        /// <summary>The delivery region of the ip address group</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The delivery region of the ip address group",
        SerializedName = @"deliveryRegion",
        PossibleTypes = new [] { typeof(string) })]
        string DeliveryRegion { get; set; }
        /// <summary>The list of ip v4 addresses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of ip v4 addresses.",
        SerializedName = @"ipv4Addresses",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ICidrIPAddress) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ICidrIPAddress[] Ipv4Address { get; set; }
        /// <summary>The list of ip v6 addresses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of ip v6 addresses.",
        SerializedName = @"ipv6Addresses",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ICidrIPAddress) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ICidrIPAddress[] Ipv6Address { get; set; }

    }
    /// CDN Ip address group
    internal partial interface IIPAddressGroupInternal

    {
        /// <summary>The delivery region of the ip address group</summary>
        string DeliveryRegion { get; set; }
        /// <summary>The list of ip v4 addresses.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ICidrIPAddress[] Ipv4Address { get; set; }
        /// <summary>The list of ip v6 addresses.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ICidrIPAddress[] Ipv6Address { get; set; }

    }
}