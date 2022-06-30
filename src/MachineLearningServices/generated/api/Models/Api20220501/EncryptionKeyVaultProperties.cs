// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    public partial class EncryptionKeyVaultProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEncryptionKeyVaultProperties,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEncryptionKeyVaultPropertiesInternal
    {

        /// <summary>Backing field for <see cref="IdentityClientId" /> property.</summary>
        private string _identityClientId;

        /// <summary>
        /// For future use - The client id of the identity which will be used to access key vault.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string IdentityClientId { get => this._identityClientId; set => this._identityClientId = value; }

        /// <summary>Backing field for <see cref="KeyIdentifier" /> property.</summary>
        private string _keyIdentifier;

        /// <summary>Key vault uri to access the encryption key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string KeyIdentifier { get => this._keyIdentifier; set => this._keyIdentifier = value; }

        /// <summary>Backing field for <see cref="KeyVaultArmId" /> property.</summary>
        private string _keyVaultArmId;

        /// <summary>The ArmId of the keyVault where the customer owned encryption key is present.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string KeyVaultArmId { get => this._keyVaultArmId; set => this._keyVaultArmId = value; }

        /// <summary>Creates an new <see cref="EncryptionKeyVaultProperties" /> instance.</summary>
        public EncryptionKeyVaultProperties()
        {

        }
    }
    public partial interface IEncryptionKeyVaultProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        /// <summary>
        /// For future use - The client id of the identity which will be used to access key vault.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"For future use - The client id of the identity which will be used to access key vault.",
        SerializedName = @"identityClientId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityClientId { get; set; }
        /// <summary>Key vault uri to access the encryption key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Key vault uri to access the encryption key.",
        SerializedName = @"keyIdentifier",
        PossibleTypes = new [] { typeof(string) })]
        string KeyIdentifier { get; set; }
        /// <summary>The ArmId of the keyVault where the customer owned encryption key is present.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The ArmId of the keyVault where the customer owned encryption key is present.",
        SerializedName = @"keyVaultArmId",
        PossibleTypes = new [] { typeof(string) })]
        string KeyVaultArmId { get; set; }

    }
    internal partial interface IEncryptionKeyVaultPropertiesInternal

    {
        /// <summary>
        /// For future use - The client id of the identity which will be used to access key vault.
        /// </summary>
        string IdentityClientId { get; set; }
        /// <summary>Key vault uri to access the encryption key.</summary>
        string KeyIdentifier { get; set; }
        /// <summary>The ArmId of the keyVault where the customer owned encryption key is present.</summary>
        string KeyVaultArmId { get; set; }

    }
}