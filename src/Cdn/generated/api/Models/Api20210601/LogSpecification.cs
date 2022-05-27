// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>Log specification of operation.</summary>
    public partial class LogSpecification :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ILogSpecification,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20210601.ILogSpecificationInternal
    {

        /// <summary>Backing field for <see cref="BlobDuration" /> property.</summary>
        private string _blobDuration;

        /// <summary>Blob duration of specification.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string BlobDuration { get => this._blobDuration; set => this._blobDuration = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Display name of log specification.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="LogFilterPattern" /> property.</summary>
        private string _logFilterPattern;

        /// <summary>Pattern to filter based on name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string LogFilterPattern { get => this._logFilterPattern; set => this._logFilterPattern = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of log specification.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="LogSpecification" /> instance.</summary>
        public LogSpecification()
        {

        }
    }
    /// Log specification of operation.
    public partial interface ILogSpecification :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable
    {
        /// <summary>Blob duration of specification.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Blob duration of specification.",
        SerializedName = @"blobDuration",
        PossibleTypes = new [] { typeof(string) })]
        string BlobDuration { get; set; }
        /// <summary>Display name of log specification.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name of log specification.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>Pattern to filter based on name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Pattern to filter based on name",
        SerializedName = @"logFilterPattern",
        PossibleTypes = new [] { typeof(string) })]
        string LogFilterPattern { get; set; }
        /// <summary>Name of log specification.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of log specification.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    /// Log specification of operation.
    internal partial interface ILogSpecificationInternal

    {
        /// <summary>Blob duration of specification.</summary>
        string BlobDuration { get; set; }
        /// <summary>Display name of log specification.</summary>
        string DisplayName { get; set; }
        /// <summary>Pattern to filter based on name</summary>
        string LogFilterPattern { get; set; }
        /// <summary>Name of log specification.</summary>
        string Name { get; set; }

    }
}