// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Extensions;

    [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.DoNotFormat]
    public partial class AgentUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IAgentUpdateProperties,
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IAgentUpdatePropertiesInternal
    {

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>A description for the Agent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Creates an new <see cref="AgentUpdateProperties" /> instance.</summary>
        public AgentUpdateProperties()
        {

        }
    }
    public partial interface IAgentUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.IJsonSerializable
    {
        /// <summary>A description for the Agent.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A description for the Agent.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }

    }
    internal partial interface IAgentUpdatePropertiesInternal

    {
        /// <summary>A description for the Agent.</summary>
        string Description { get; set; }

    }
}