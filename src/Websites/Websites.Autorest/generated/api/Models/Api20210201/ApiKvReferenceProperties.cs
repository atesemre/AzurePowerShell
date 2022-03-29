// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Extensions;

    /// <summary>ApiKVReference resource specific properties</summary>
    public partial class ApiKvReferenceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IApiKvReferenceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IApiKvReferencePropertiesInternal
    {

        /// <summary>Backing field for <see cref="ActiveVersion" /> property.</summary>
        private string _activeVersion;

        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Owned)]
        public string ActiveVersion { get => this._activeVersion; set => this._activeVersion = value; }

        /// <summary>Backing field for <see cref="Detail" /> property.</summary>
        private string _detail;

        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Owned)]
        public string Detail { get => this._detail; set => this._detail = value; }

        /// <summary>Backing field for <see cref="IdentityType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IManagedServiceIdentityAutoGenerated _identityType;

        /// <summary>Managed service identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IManagedServiceIdentityAutoGenerated IdentityType { get => (this._identityType = this._identityType ?? new Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ManagedServiceIdentityAutoGenerated()); set => this._identityType = value; }

        /// <summary>Principal Id of managed service identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inlined)]
        public string IdentityTypePrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IManagedServiceIdentityAutoGeneratedInternal)IdentityType).PrincipalId; }

        /// <summary>Tenant of managed service identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inlined)]
        public string IdentityTypeTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IManagedServiceIdentityAutoGeneratedInternal)IdentityType).TenantId; }

        /// <summary>Type of managed service identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ManagedServiceIdentityType? IdentityTypeType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IManagedServiceIdentityAutoGeneratedInternal)IdentityType).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IManagedServiceIdentityAutoGeneratedInternal)IdentityType).Type = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ManagedServiceIdentityType)""); }

        /// <summary>
        /// The list of user assigned identities associated with the resource. The user identity dictionary key references will be
        /// ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IManagedServiceIdentityUserAssignedIdentities IdentityTypeUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IManagedServiceIdentityAutoGeneratedInternal)IdentityType).UserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IManagedServiceIdentityAutoGeneratedInternal)IdentityType).UserAssignedIdentity = value ?? null /* model class */; }

        /// <summary>Internal Acessors for IdentityType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IManagedServiceIdentityAutoGenerated Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IApiKvReferencePropertiesInternal.IdentityType { get => (this._identityType = this._identityType ?? new Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ManagedServiceIdentityAutoGenerated()); set { {_identityType = value;} } }

        /// <summary>Internal Acessors for IdentityTypePrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IApiKvReferencePropertiesInternal.IdentityTypePrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IManagedServiceIdentityAutoGeneratedInternal)IdentityType).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IManagedServiceIdentityAutoGeneratedInternal)IdentityType).PrincipalId = value; }

        /// <summary>Internal Acessors for IdentityTypeTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IApiKvReferencePropertiesInternal.IdentityTypeTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IManagedServiceIdentityAutoGeneratedInternal)IdentityType).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IManagedServiceIdentityAutoGeneratedInternal)IdentityType).TenantId = value; }

        /// <summary>Backing field for <see cref="Reference" /> property.</summary>
        private string _reference;

        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Owned)]
        public string Reference { get => this._reference; set => this._reference = value; }

        /// <summary>Backing field for <see cref="SecretName" /> property.</summary>
        private string _secretName;

        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Owned)]
        public string SecretName { get => this._secretName; set => this._secretName = value; }

        /// <summary>Backing field for <see cref="SecretVersion" /> property.</summary>
        private string _secretVersion;

        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Owned)]
        public string SecretVersion { get => this._secretVersion; set => this._secretVersion = value; }

        /// <summary>Backing field for <see cref="Source" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ConfigReferenceSource? _source;

        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ConfigReferenceSource? Source { get => this._source; set => this._source = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ResolveStatus? _status;

        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ResolveStatus? Status { get => this._status; set => this._status = value; }

        /// <summary>Backing field for <see cref="VaultName" /> property.</summary>
        private string _vaultName;

        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Owned)]
        public string VaultName { get => this._vaultName; set => this._vaultName = value; }

        /// <summary>Creates an new <see cref="ApiKvReferenceProperties" /> instance.</summary>
        public ApiKvReferenceProperties()
        {

        }
    }
    /// ApiKVReference resource specific properties
    public partial interface IApiKvReferenceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"activeVersion",
        PossibleTypes = new [] { typeof(string) })]
        string ActiveVersion { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(string) })]
        string Detail { get; set; }
        /// <summary>Principal Id of managed service identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Principal Id of managed service identity.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityTypePrincipalId { get;  }
        /// <summary>Tenant of managed service identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Tenant of managed service identity.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityTypeTenantId { get;  }
        /// <summary>Type of managed service identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of managed service identity.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ManagedServiceIdentityType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ManagedServiceIdentityType? IdentityTypeType { get; set; }
        /// <summary>
        /// The list of user assigned identities associated with the resource. The user identity dictionary key references will be
        /// ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of user assigned identities associated with the resource. The user identity dictionary key references will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IManagedServiceIdentityUserAssignedIdentities) })]
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IManagedServiceIdentityUserAssignedIdentities IdentityTypeUserAssignedIdentity { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"reference",
        PossibleTypes = new [] { typeof(string) })]
        string Reference { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"secretName",
        PossibleTypes = new [] { typeof(string) })]
        string SecretName { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"secretVersion",
        PossibleTypes = new [] { typeof(string) })]
        string SecretVersion { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"source",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ConfigReferenceSource) })]
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ConfigReferenceSource? Source { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ResolveStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ResolveStatus? Status { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"vaultName",
        PossibleTypes = new [] { typeof(string) })]
        string VaultName { get; set; }

    }
    /// ApiKVReference resource specific properties
    internal partial interface IApiKvReferencePropertiesInternal

    {
        string ActiveVersion { get; set; }

        string Detail { get; set; }
        /// <summary>Managed service identity.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IManagedServiceIdentityAutoGenerated IdentityType { get; set; }
        /// <summary>Principal Id of managed service identity.</summary>
        string IdentityTypePrincipalId { get; set; }
        /// <summary>Tenant of managed service identity.</summary>
        string IdentityTypeTenantId { get; set; }
        /// <summary>Type of managed service identity.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ManagedServiceIdentityType? IdentityTypeType { get; set; }
        /// <summary>
        /// The list of user assigned identities associated with the resource. The user identity dictionary key references will be
        /// ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IManagedServiceIdentityUserAssignedIdentities IdentityTypeUserAssignedIdentity { get; set; }

        string Reference { get; set; }

        string SecretName { get; set; }

        string SecretVersion { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ConfigReferenceSource? Source { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.ResolveStatus? Status { get; set; }

        string VaultName { get; set; }

    }
}