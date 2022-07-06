// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>Keys for endpoint authentication.</summary>
    public partial class EndpointAuthKeys :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointAuthKeys,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointAuthKeysInternal
    {

        /// <summary>Backing field for <see cref="PrimaryKey" /> property.</summary>
        private string _primaryKey;

        /// <summary>The primary key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string PrimaryKey { get => this._primaryKey; set => this._primaryKey = value; }

        /// <summary>Backing field for <see cref="SecondaryKey" /> property.</summary>
        private string _secondaryKey;

        /// <summary>The secondary key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string SecondaryKey { get => this._secondaryKey; set => this._secondaryKey = value; }

        /// <summary>Creates an new <see cref="EndpointAuthKeys" /> instance.</summary>
        public EndpointAuthKeys()
        {

        }
    }
    /// Keys for endpoint authentication.
    public partial interface IEndpointAuthKeys :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        /// <summary>The primary key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The primary key.",
        SerializedName = @"primaryKey",
        PossibleTypes = new [] { typeof(string) })]
        string PrimaryKey { get; set; }
        /// <summary>The secondary key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The secondary key.",
        SerializedName = @"secondaryKey",
        PossibleTypes = new [] { typeof(string) })]
        string SecondaryKey { get; set; }

    }
    /// Keys for endpoint authentication.
    internal partial interface IEndpointAuthKeysInternal

    {
        /// <summary>The primary key.</summary>
        string PrimaryKey { get; set; }
        /// <summary>The secondary key.</summary>
        string SecondaryKey { get; set; }

    }
}