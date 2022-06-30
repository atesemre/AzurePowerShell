// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501
{
    using Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.PowerShell;

    /// <summary>Base definition for endpoint deployment.</summary>
    [System.ComponentModel.TypeConverter(typeof(EndpointDeploymentPropertiesBaseTypeConverter))]
    public partial class EndpointDeploymentPropertiesBase
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.EndpointDeploymentPropertiesBase"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointDeploymentPropertiesBase"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointDeploymentPropertiesBase DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new EndpointDeploymentPropertiesBase(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.EndpointDeploymentPropertiesBase"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointDeploymentPropertiesBase"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointDeploymentPropertiesBase DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new EndpointDeploymentPropertiesBase(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.EndpointDeploymentPropertiesBase"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal EndpointDeploymentPropertiesBase(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("CodeConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointDeploymentPropertiesBaseInternal)this).CodeConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ICodeConfiguration) content.GetValueForProperty("CodeConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointDeploymentPropertiesBaseInternal)this).CodeConfiguration, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.CodeConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointDeploymentPropertiesBaseInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointDeploymentPropertiesBaseInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("EnvironmentId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointDeploymentPropertiesBaseInternal)this).EnvironmentId = (string) content.GetValueForProperty("EnvironmentId",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointDeploymentPropertiesBaseInternal)this).EnvironmentId, global::System.Convert.ToString);
            }
            if (content.Contains("EnvironmentVariable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointDeploymentPropertiesBaseInternal)this).EnvironmentVariable = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointDeploymentPropertiesBaseEnvironmentVariables) content.GetValueForProperty("EnvironmentVariable",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointDeploymentPropertiesBaseInternal)this).EnvironmentVariable, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.EndpointDeploymentPropertiesBaseEnvironmentVariablesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointDeploymentPropertiesBaseInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointDeploymentPropertiesBaseProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointDeploymentPropertiesBaseInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.EndpointDeploymentPropertiesBasePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("CodeConfigurationCodeId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointDeploymentPropertiesBaseInternal)this).CodeConfigurationCodeId = (string) content.GetValueForProperty("CodeConfigurationCodeId",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointDeploymentPropertiesBaseInternal)this).CodeConfigurationCodeId, global::System.Convert.ToString);
            }
            if (content.Contains("CodeConfigurationScoringScript"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointDeploymentPropertiesBaseInternal)this).CodeConfigurationScoringScript = (string) content.GetValueForProperty("CodeConfigurationScoringScript",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointDeploymentPropertiesBaseInternal)this).CodeConfigurationScoringScript, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.EndpointDeploymentPropertiesBase"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal EndpointDeploymentPropertiesBase(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("CodeConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointDeploymentPropertiesBaseInternal)this).CodeConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ICodeConfiguration) content.GetValueForProperty("CodeConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointDeploymentPropertiesBaseInternal)this).CodeConfiguration, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.CodeConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointDeploymentPropertiesBaseInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointDeploymentPropertiesBaseInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("EnvironmentId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointDeploymentPropertiesBaseInternal)this).EnvironmentId = (string) content.GetValueForProperty("EnvironmentId",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointDeploymentPropertiesBaseInternal)this).EnvironmentId, global::System.Convert.ToString);
            }
            if (content.Contains("EnvironmentVariable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointDeploymentPropertiesBaseInternal)this).EnvironmentVariable = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointDeploymentPropertiesBaseEnvironmentVariables) content.GetValueForProperty("EnvironmentVariable",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointDeploymentPropertiesBaseInternal)this).EnvironmentVariable, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.EndpointDeploymentPropertiesBaseEnvironmentVariablesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointDeploymentPropertiesBaseInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointDeploymentPropertiesBaseProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointDeploymentPropertiesBaseInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.EndpointDeploymentPropertiesBasePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("CodeConfigurationCodeId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointDeploymentPropertiesBaseInternal)this).CodeConfigurationCodeId = (string) content.GetValueForProperty("CodeConfigurationCodeId",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointDeploymentPropertiesBaseInternal)this).CodeConfigurationCodeId, global::System.Convert.ToString);
            }
            if (content.Contains("CodeConfigurationScoringScript"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointDeploymentPropertiesBaseInternal)this).CodeConfigurationScoringScript = (string) content.GetValueForProperty("CodeConfigurationScoringScript",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointDeploymentPropertiesBaseInternal)this).CodeConfigurationScoringScript, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="EndpointDeploymentPropertiesBase" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="EndpointDeploymentPropertiesBase" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IEndpointDeploymentPropertiesBase FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// Base definition for endpoint deployment.
    [System.ComponentModel.TypeConverter(typeof(EndpointDeploymentPropertiesBaseTypeConverter))]
    public partial interface IEndpointDeploymentPropertiesBase

    {

    }
}