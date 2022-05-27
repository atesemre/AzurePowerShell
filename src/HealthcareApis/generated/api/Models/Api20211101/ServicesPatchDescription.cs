// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Extensions;

    /// <summary>The description of the service.</summary>
    public partial class ServicesPatchDescription :
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServicesPatchDescription,
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServicesPatchDescriptionInternal
    {

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServicesPropertiesUpdateParameters Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServicesPatchDescriptionInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.ServicesPropertiesUpdateParameters()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServicesPropertiesUpdateParameters _property;

        /// <summary>The properties for updating a service instance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServicesPropertiesUpdateParameters Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.ServicesPropertiesUpdateParameters()); set => this._property = value; }

        /// <summary>
        /// Control permission for data plane traffic coming from public networks while private endpoint is enabled.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.PublicNetworkAccess? PublicNetworkAccess { get => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServicesPropertiesUpdateParametersInternal)Property).PublicNetworkAccess; set => ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServicesPropertiesUpdateParametersInternal)Property).PublicNetworkAccess = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.PublicNetworkAccess)""); }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServicesPatchDescriptionTags _tag;

        /// <summary>Instance tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Origin(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServicesPatchDescriptionTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.ServicesPatchDescriptionTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="ServicesPatchDescription" /> instance.</summary>
        public ServicesPatchDescription()
        {

        }
    }
    /// The description of the service.
    public partial interface IServicesPatchDescription :
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Control permission for data plane traffic coming from public networks while private endpoint is enabled.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Control permission for data plane traffic coming from public networks while private endpoint is enabled.",
        SerializedName = @"publicNetworkAccess",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.PublicNetworkAccess) })]
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.PublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary>Instance tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Instance tags",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServicesPatchDescriptionTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServicesPatchDescriptionTags Tag { get; set; }

    }
    /// The description of the service.
    internal partial interface IServicesPatchDescriptionInternal

    {
        /// <summary>The properties for updating a service instance.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServicesPropertiesUpdateParameters Property { get; set; }
        /// <summary>
        /// Control permission for data plane traffic coming from public networks while private endpoint is enabled.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Support.PublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary>Instance tags</summary>
        Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Models.Api20211101.IServicesPatchDescriptionTags Tag { get; set; }

    }
}