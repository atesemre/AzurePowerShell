// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501
{
    using Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Runtime.PowerShell;

    /// <summary>Metadata pertaining to creation and last modification of the resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(CollectorPolicySystemDataTypeConverter))]
    public partial class CollectorPolicySystemData
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.CollectorPolicySystemData"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal CollectorPolicySystemData(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("CreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ISystemDataInternal)this).CreatedBy = (string) content.GetValueForProperty("CreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ISystemDataInternal)this).CreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("CreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ISystemDataInternal)this).CreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.CreatedByType?) content.GetValueForProperty("CreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ISystemDataInternal)this).CreatedByType, Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("CreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ISystemDataInternal)this).CreatedAt = (global::System.DateTime?) content.GetValueForProperty("CreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ISystemDataInternal)this).CreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ISystemDataInternal)this).LastModifiedBy = (string) content.GetValueForProperty("LastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ISystemDataInternal)this).LastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("LastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ISystemDataInternal)this).LastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.CreatedByType?) content.GetValueForProperty("LastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ISystemDataInternal)this).LastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.CreatedByType.CreateFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.CollectorPolicySystemData"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal CollectorPolicySystemData(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("CreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ISystemDataInternal)this).CreatedBy = (string) content.GetValueForProperty("CreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ISystemDataInternal)this).CreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("CreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ISystemDataInternal)this).CreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.CreatedByType?) content.GetValueForProperty("CreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ISystemDataInternal)this).CreatedByType, Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("CreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ISystemDataInternal)this).CreatedAt = (global::System.DateTime?) content.GetValueForProperty("CreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ISystemDataInternal)this).CreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ISystemDataInternal)this).LastModifiedBy = (string) content.GetValueForProperty("LastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ISystemDataInternal)this).LastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("LastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ISystemDataInternal)this).LastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.CreatedByType?) content.GetValueForProperty("LastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ISystemDataInternal)this).LastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Support.CreatedByType.CreateFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.CollectorPolicySystemData"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicySystemData"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicySystemData DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new CollectorPolicySystemData(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.CollectorPolicySystemData"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicySystemData"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicySystemData DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new CollectorPolicySystemData(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="CollectorPolicySystemData" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="CollectorPolicySystemData" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Models.Api20220501.ICollectorPolicySystemData FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.NetworkFunction.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Metadata pertaining to creation and last modification of the resource.
    [System.ComponentModel.TypeConverter(typeof(CollectorPolicySystemDataTypeConverter))]
    public partial interface ICollectorPolicySystemData

    {

    }
}