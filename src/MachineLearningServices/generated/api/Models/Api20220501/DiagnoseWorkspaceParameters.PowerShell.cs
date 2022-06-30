// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501
{
    using Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.PowerShell;

    /// <summary>Parameters to diagnose a workspace</summary>
    [System.ComponentModel.TypeConverter(typeof(DiagnoseWorkspaceParametersTypeConverter))]
    public partial class DiagnoseWorkspaceParameters
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.DiagnoseWorkspaceParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParameters"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParameters DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DiagnoseWorkspaceParameters(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.DiagnoseWorkspaceParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParameters"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParameters DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DiagnoseWorkspaceParameters(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.DiagnoseWorkspaceParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DiagnoseWorkspaceParameters(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Value"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParametersInternal)this).Value = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseRequestProperties) content.GetValueForProperty("Value",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParametersInternal)this).Value, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.DiagnoseRequestPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ValueUdr"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParametersInternal)this).ValueUdr = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseRequestPropertiesUdr) content.GetValueForProperty("ValueUdr",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParametersInternal)this).ValueUdr, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.DiagnoseRequestPropertiesUdrTypeConverter.ConvertFrom);
            }
            if (content.Contains("ValueNsg"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParametersInternal)this).ValueNsg = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseRequestPropertiesNsg) content.GetValueForProperty("ValueNsg",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParametersInternal)this).ValueNsg, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.DiagnoseRequestPropertiesNsgTypeConverter.ConvertFrom);
            }
            if (content.Contains("ValueResourceLock"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParametersInternal)this).ValueResourceLock = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseRequestPropertiesResourceLock) content.GetValueForProperty("ValueResourceLock",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParametersInternal)this).ValueResourceLock, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.DiagnoseRequestPropertiesResourceLockTypeConverter.ConvertFrom);
            }
            if (content.Contains("ValueDnsResolution"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParametersInternal)this).ValueDnsResolution = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseRequestPropertiesDnsResolution) content.GetValueForProperty("ValueDnsResolution",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParametersInternal)this).ValueDnsResolution, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.DiagnoseRequestPropertiesDnsResolutionTypeConverter.ConvertFrom);
            }
            if (content.Contains("ValueStorageAccount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParametersInternal)this).ValueStorageAccount = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseRequestPropertiesStorageAccount) content.GetValueForProperty("ValueStorageAccount",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParametersInternal)this).ValueStorageAccount, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.DiagnoseRequestPropertiesStorageAccountTypeConverter.ConvertFrom);
            }
            if (content.Contains("ValueKeyVault"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParametersInternal)this).ValueKeyVault = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseRequestPropertiesKeyVault) content.GetValueForProperty("ValueKeyVault",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParametersInternal)this).ValueKeyVault, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.DiagnoseRequestPropertiesKeyVaultTypeConverter.ConvertFrom);
            }
            if (content.Contains("ValueContainerRegistry"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParametersInternal)this).ValueContainerRegistry = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseRequestPropertiesContainerRegistry) content.GetValueForProperty("ValueContainerRegistry",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParametersInternal)this).ValueContainerRegistry, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.DiagnoseRequestPropertiesContainerRegistryTypeConverter.ConvertFrom);
            }
            if (content.Contains("ValueApplicationInsight"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParametersInternal)this).ValueApplicationInsight = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseRequestPropertiesApplicationInsights) content.GetValueForProperty("ValueApplicationInsight",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParametersInternal)this).ValueApplicationInsight, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.DiagnoseRequestPropertiesApplicationInsightsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ValueOthers"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParametersInternal)this).ValueOthers = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseRequestPropertiesOthers) content.GetValueForProperty("ValueOthers",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParametersInternal)this).ValueOthers, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.DiagnoseRequestPropertiesOthersTypeConverter.ConvertFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.DiagnoseWorkspaceParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DiagnoseWorkspaceParameters(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Value"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParametersInternal)this).Value = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseRequestProperties) content.GetValueForProperty("Value",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParametersInternal)this).Value, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.DiagnoseRequestPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ValueUdr"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParametersInternal)this).ValueUdr = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseRequestPropertiesUdr) content.GetValueForProperty("ValueUdr",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParametersInternal)this).ValueUdr, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.DiagnoseRequestPropertiesUdrTypeConverter.ConvertFrom);
            }
            if (content.Contains("ValueNsg"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParametersInternal)this).ValueNsg = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseRequestPropertiesNsg) content.GetValueForProperty("ValueNsg",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParametersInternal)this).ValueNsg, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.DiagnoseRequestPropertiesNsgTypeConverter.ConvertFrom);
            }
            if (content.Contains("ValueResourceLock"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParametersInternal)this).ValueResourceLock = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseRequestPropertiesResourceLock) content.GetValueForProperty("ValueResourceLock",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParametersInternal)this).ValueResourceLock, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.DiagnoseRequestPropertiesResourceLockTypeConverter.ConvertFrom);
            }
            if (content.Contains("ValueDnsResolution"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParametersInternal)this).ValueDnsResolution = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseRequestPropertiesDnsResolution) content.GetValueForProperty("ValueDnsResolution",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParametersInternal)this).ValueDnsResolution, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.DiagnoseRequestPropertiesDnsResolutionTypeConverter.ConvertFrom);
            }
            if (content.Contains("ValueStorageAccount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParametersInternal)this).ValueStorageAccount = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseRequestPropertiesStorageAccount) content.GetValueForProperty("ValueStorageAccount",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParametersInternal)this).ValueStorageAccount, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.DiagnoseRequestPropertiesStorageAccountTypeConverter.ConvertFrom);
            }
            if (content.Contains("ValueKeyVault"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParametersInternal)this).ValueKeyVault = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseRequestPropertiesKeyVault) content.GetValueForProperty("ValueKeyVault",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParametersInternal)this).ValueKeyVault, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.DiagnoseRequestPropertiesKeyVaultTypeConverter.ConvertFrom);
            }
            if (content.Contains("ValueContainerRegistry"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParametersInternal)this).ValueContainerRegistry = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseRequestPropertiesContainerRegistry) content.GetValueForProperty("ValueContainerRegistry",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParametersInternal)this).ValueContainerRegistry, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.DiagnoseRequestPropertiesContainerRegistryTypeConverter.ConvertFrom);
            }
            if (content.Contains("ValueApplicationInsight"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParametersInternal)this).ValueApplicationInsight = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseRequestPropertiesApplicationInsights) content.GetValueForProperty("ValueApplicationInsight",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParametersInternal)this).ValueApplicationInsight, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.DiagnoseRequestPropertiesApplicationInsightsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ValueOthers"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParametersInternal)this).ValueOthers = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseRequestPropertiesOthers) content.GetValueForProperty("ValueOthers",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParametersInternal)this).ValueOthers, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.DiagnoseRequestPropertiesOthersTypeConverter.ConvertFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DiagnoseWorkspaceParameters" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="DiagnoseWorkspaceParameters" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IDiagnoseWorkspaceParameters FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// Parameters to diagnose a workspace
    [System.ComponentModel.TypeConverter(typeof(DiagnoseWorkspaceParametersTypeConverter))]
    public partial interface IDiagnoseWorkspaceParameters

    {

    }
}