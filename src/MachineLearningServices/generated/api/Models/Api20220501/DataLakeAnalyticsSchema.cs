// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    public partial class DataLakeAnalyticsSchema :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDataLakeAnalyticsSchema,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDataLakeAnalyticsSchemaInternal
    {

        /// <summary>DataLake Store Account Name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public string DataLakeStoreAccountName { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDataLakeAnalyticsSchemaPropertiesInternal)Property).DataLakeStoreAccountName; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDataLakeAnalyticsSchemaPropertiesInternal)Property).DataLakeStoreAccountName = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDataLakeAnalyticsSchemaProperties Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDataLakeAnalyticsSchemaInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.DataLakeAnalyticsSchemaProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDataLakeAnalyticsSchemaProperties _property;

        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDataLakeAnalyticsSchemaProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.DataLakeAnalyticsSchemaProperties()); set => this._property = value; }

        /// <summary>Creates an new <see cref="DataLakeAnalyticsSchema" /> instance.</summary>
        public DataLakeAnalyticsSchema()
        {

        }
    }
    public partial interface IDataLakeAnalyticsSchema :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        /// <summary>DataLake Store Account Name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"DataLake Store Account Name",
        SerializedName = @"dataLakeStoreAccountName",
        PossibleTypes = new [] { typeof(string) })]
        string DataLakeStoreAccountName { get; set; }

    }
    internal partial interface IDataLakeAnalyticsSchemaInternal

    {
        /// <summary>DataLake Store Account Name</summary>
        string DataLakeStoreAccountName { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDataLakeAnalyticsSchemaProperties Property { get; set; }

    }
}