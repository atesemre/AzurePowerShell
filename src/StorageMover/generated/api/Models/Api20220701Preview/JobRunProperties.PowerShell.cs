// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.PowerShell;

    /// <summary>Job run properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(JobRunPropertiesTypeConverter))]
    public partial class JobRunProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.JobRunProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new JobRunProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.JobRunProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new JobRunProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="JobRunProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="JobRunProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.JobRunProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal JobRunProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Error"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunError) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.JobRunErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.JobRunStatus?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.JobRunStatus.CreateFrom);
            }
            if (content.Contains("ScanStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).ScanStatus = (Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.JobRunScanStatus?) content.GetValueForProperty("ScanStatus",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).ScanStatus, Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.JobRunScanStatus.CreateFrom);
            }
            if (content.Contains("AgentName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).AgentName = (string) content.GetValueForProperty("AgentName",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).AgentName, global::System.Convert.ToString);
            }
            if (content.Contains("AgentResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).AgentResourceId = (string) content.GetValueForProperty("AgentResourceId",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).AgentResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ExecutionStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).ExecutionStartTime = (global::System.DateTime?) content.GetValueForProperty("ExecutionStartTime",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).ExecutionStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ExecutionEndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).ExecutionEndTime = (global::System.DateTime?) content.GetValueForProperty("ExecutionEndTime",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).ExecutionEndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastStatusUpdate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).LastStatusUpdate = (global::System.DateTime?) content.GetValueForProperty("LastStatusUpdate",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).LastStatusUpdate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ItemsScanned"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).ItemsScanned = (long?) content.GetValueForProperty("ItemsScanned",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).ItemsScanned, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ItemsExcluded"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).ItemsExcluded = (long?) content.GetValueForProperty("ItemsExcluded",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).ItemsExcluded, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ItemsUnsupported"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).ItemsUnsupported = (long?) content.GetValueForProperty("ItemsUnsupported",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).ItemsUnsupported, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ItemsNoTransferNeeded"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).ItemsNoTransferNeeded = (long?) content.GetValueForProperty("ItemsNoTransferNeeded",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).ItemsNoTransferNeeded, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ItemsFailed"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).ItemsFailed = (long?) content.GetValueForProperty("ItemsFailed",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).ItemsFailed, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ItemsTransferred"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).ItemsTransferred = (long?) content.GetValueForProperty("ItemsTransferred",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).ItemsTransferred, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("BytesScanned"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).BytesScanned = (long?) content.GetValueForProperty("BytesScanned",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).BytesScanned, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("BytesExcluded"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).BytesExcluded = (long?) content.GetValueForProperty("BytesExcluded",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).BytesExcluded, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("BytesUnsupported"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).BytesUnsupported = (long?) content.GetValueForProperty("BytesUnsupported",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).BytesUnsupported, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("BytesNoTransferNeeded"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).BytesNoTransferNeeded = (long?) content.GetValueForProperty("BytesNoTransferNeeded",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).BytesNoTransferNeeded, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("BytesFailed"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).BytesFailed = (long?) content.GetValueForProperty("BytesFailed",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).BytesFailed, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("BytesTransferred"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).BytesTransferred = (long?) content.GetValueForProperty("BytesTransferred",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).BytesTransferred, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("SourceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).SourceName = (string) content.GetValueForProperty("SourceName",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).SourceName, global::System.Convert.ToString);
            }
            if (content.Contains("SourceResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).SourceResourceId = (string) content.GetValueForProperty("SourceResourceId",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).SourceResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("SourceProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).SourceProperty = (Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.IAny) content.GetValueForProperty("SourceProperty",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).SourceProperty, Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.AnyTypeConverter.ConvertFrom);
            }
            if (content.Contains("TargetName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).TargetName = (string) content.GetValueForProperty("TargetName",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).TargetName, global::System.Convert.ToString);
            }
            if (content.Contains("TargetResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).TargetResourceId = (string) content.GetValueForProperty("TargetResourceId",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).TargetResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("TargetProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).TargetProperty = (Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.IAny) content.GetValueForProperty("TargetProperty",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).TargetProperty, Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.AnyTypeConverter.ConvertFrom);
            }
            if (content.Contains("JobDefinitionProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).JobDefinitionProperty = (Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.IAny) content.GetValueForProperty("JobDefinitionProperty",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).JobDefinitionProperty, Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.AnyTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).Message, global::System.Convert.ToString);
            }
            if (content.Contains("Target"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).Target = (string) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).Target, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.JobRunProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal JobRunProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Error"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunError) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.JobRunErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.JobRunStatus?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.JobRunStatus.CreateFrom);
            }
            if (content.Contains("ScanStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).ScanStatus = (Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.JobRunScanStatus?) content.GetValueForProperty("ScanStatus",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).ScanStatus, Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.JobRunScanStatus.CreateFrom);
            }
            if (content.Contains("AgentName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).AgentName = (string) content.GetValueForProperty("AgentName",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).AgentName, global::System.Convert.ToString);
            }
            if (content.Contains("AgentResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).AgentResourceId = (string) content.GetValueForProperty("AgentResourceId",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).AgentResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("ExecutionStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).ExecutionStartTime = (global::System.DateTime?) content.GetValueForProperty("ExecutionStartTime",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).ExecutionStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ExecutionEndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).ExecutionEndTime = (global::System.DateTime?) content.GetValueForProperty("ExecutionEndTime",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).ExecutionEndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("LastStatusUpdate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).LastStatusUpdate = (global::System.DateTime?) content.GetValueForProperty("LastStatusUpdate",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).LastStatusUpdate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ItemsScanned"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).ItemsScanned = (long?) content.GetValueForProperty("ItemsScanned",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).ItemsScanned, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ItemsExcluded"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).ItemsExcluded = (long?) content.GetValueForProperty("ItemsExcluded",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).ItemsExcluded, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ItemsUnsupported"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).ItemsUnsupported = (long?) content.GetValueForProperty("ItemsUnsupported",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).ItemsUnsupported, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ItemsNoTransferNeeded"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).ItemsNoTransferNeeded = (long?) content.GetValueForProperty("ItemsNoTransferNeeded",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).ItemsNoTransferNeeded, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ItemsFailed"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).ItemsFailed = (long?) content.GetValueForProperty("ItemsFailed",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).ItemsFailed, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("ItemsTransferred"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).ItemsTransferred = (long?) content.GetValueForProperty("ItemsTransferred",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).ItemsTransferred, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("BytesScanned"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).BytesScanned = (long?) content.GetValueForProperty("BytesScanned",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).BytesScanned, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("BytesExcluded"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).BytesExcluded = (long?) content.GetValueForProperty("BytesExcluded",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).BytesExcluded, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("BytesUnsupported"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).BytesUnsupported = (long?) content.GetValueForProperty("BytesUnsupported",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).BytesUnsupported, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("BytesNoTransferNeeded"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).BytesNoTransferNeeded = (long?) content.GetValueForProperty("BytesNoTransferNeeded",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).BytesNoTransferNeeded, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("BytesFailed"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).BytesFailed = (long?) content.GetValueForProperty("BytesFailed",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).BytesFailed, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("BytesTransferred"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).BytesTransferred = (long?) content.GetValueForProperty("BytesTransferred",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).BytesTransferred, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("SourceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).SourceName = (string) content.GetValueForProperty("SourceName",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).SourceName, global::System.Convert.ToString);
            }
            if (content.Contains("SourceResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).SourceResourceId = (string) content.GetValueForProperty("SourceResourceId",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).SourceResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("SourceProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).SourceProperty = (Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.IAny) content.GetValueForProperty("SourceProperty",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).SourceProperty, Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.AnyTypeConverter.ConvertFrom);
            }
            if (content.Contains("TargetName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).TargetName = (string) content.GetValueForProperty("TargetName",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).TargetName, global::System.Convert.ToString);
            }
            if (content.Contains("TargetResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).TargetResourceId = (string) content.GetValueForProperty("TargetResourceId",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).TargetResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("TargetProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).TargetProperty = (Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.IAny) content.GetValueForProperty("TargetProperty",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).TargetProperty, Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.AnyTypeConverter.ConvertFrom);
            }
            if (content.Contains("JobDefinitionProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).JobDefinitionProperty = (Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.IAny) content.GetValueForProperty("JobDefinitionProperty",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).JobDefinitionProperty, Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.AnyTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).Message, global::System.Convert.ToString);
            }
            if (content.Contains("Target"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).Target = (string) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20220701Preview.IJobRunPropertiesInternal)this).Target, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Job run properties.
    [System.ComponentModel.TypeConverter(typeof(JobRunPropertiesTypeConverter))]
    public partial interface IJobRunProperties

    {

    }
}