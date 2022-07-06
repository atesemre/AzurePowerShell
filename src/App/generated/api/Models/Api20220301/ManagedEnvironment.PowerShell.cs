// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301
{
    using Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.PowerShell;

    /// <summary>An environment for hosting container apps</summary>
    [System.ComponentModel.TypeConverter(typeof(ManagedEnvironmentTypeConverter))]
    public partial class ManagedEnvironment
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ManagedEnvironment"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironment" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironment DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ManagedEnvironment(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ManagedEnvironment"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironment" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironment DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ManagedEnvironment(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ManagedEnvironment" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ManagedEnvironment" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironment FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ManagedEnvironment"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ManagedEnvironment(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ManagedEnvironmentPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.App.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.App.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.App.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.App.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.TrackedResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("VnetConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).VnetConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IVnetConfiguration) content.GetValueForProperty("VnetConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).VnetConfiguration, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.VnetConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("AppLogsConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).AppLogsConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAppLogsConfiguration) content.GetValueForProperty("AppLogsConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).AppLogsConfiguration, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.AppLogsConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.App.Support.EnvironmentProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.App.Support.EnvironmentProvisioningState.CreateFrom);
            }
            if (content.Contains("DaprAiInstrumentationKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).DaprAiInstrumentationKey = (string) content.GetValueForProperty("DaprAiInstrumentationKey",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).DaprAiInstrumentationKey, global::System.Convert.ToString);
            }
            if (content.Contains("DaprAiConnectionString"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).DaprAiConnectionString = (string) content.GetValueForProperty("DaprAiConnectionString",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).DaprAiConnectionString, global::System.Convert.ToString);
            }
            if (content.Contains("DeploymentError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).DeploymentError = (string) content.GetValueForProperty("DeploymentError",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).DeploymentError, global::System.Convert.ToString);
            }
            if (content.Contains("DefaultDomain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).DefaultDomain = (string) content.GetValueForProperty("DefaultDomain",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).DefaultDomain, global::System.Convert.ToString);
            }
            if (content.Contains("StaticIP"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).StaticIP = (string) content.GetValueForProperty("StaticIP",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).StaticIP, global::System.Convert.ToString);
            }
            if (content.Contains("ZoneRedundant"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).ZoneRedundant = (bool?) content.GetValueForProperty("ZoneRedundant",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).ZoneRedundant, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AppLogConfigurationDestination"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).AppLogConfigurationDestination = (string) content.GetValueForProperty("AppLogConfigurationDestination",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).AppLogConfigurationDestination, global::System.Convert.ToString);
            }
            if (content.Contains("VnetConfigurationInternal"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).VnetConfigurationInternal = (bool?) content.GetValueForProperty("VnetConfigurationInternal",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).VnetConfigurationInternal, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("VnetConfigurationInfrastructureSubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).VnetConfigurationInfrastructureSubnetId = (string) content.GetValueForProperty("VnetConfigurationInfrastructureSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).VnetConfigurationInfrastructureSubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("VnetConfigurationRuntimeSubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).VnetConfigurationRuntimeSubnetId = (string) content.GetValueForProperty("VnetConfigurationRuntimeSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).VnetConfigurationRuntimeSubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("VnetConfigurationDockerBridgeCidr"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).VnetConfigurationDockerBridgeCidr = (string) content.GetValueForProperty("VnetConfigurationDockerBridgeCidr",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).VnetConfigurationDockerBridgeCidr, global::System.Convert.ToString);
            }
            if (content.Contains("VnetConfigurationPlatformReservedCidr"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).VnetConfigurationPlatformReservedCidr = (string) content.GetValueForProperty("VnetConfigurationPlatformReservedCidr",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).VnetConfigurationPlatformReservedCidr, global::System.Convert.ToString);
            }
            if (content.Contains("VnetConfigurationPlatformReservedDnsIP"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).VnetConfigurationPlatformReservedDnsIP = (string) content.GetValueForProperty("VnetConfigurationPlatformReservedDnsIP",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).VnetConfigurationPlatformReservedDnsIP, global::System.Convert.ToString);
            }
            if (content.Contains("AppLogConfigurationLogAnalyticsConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).AppLogConfigurationLogAnalyticsConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ILogAnalyticsConfiguration) content.GetValueForProperty("AppLogConfigurationLogAnalyticsConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).AppLogConfigurationLogAnalyticsConfiguration, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.LogAnalyticsConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("LogAnalyticConfigurationCustomerId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).LogAnalyticConfigurationCustomerId = (string) content.GetValueForProperty("LogAnalyticConfigurationCustomerId",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).LogAnalyticConfigurationCustomerId, global::System.Convert.ToString);
            }
            if (content.Contains("LogAnalyticConfigurationSharedKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).LogAnalyticConfigurationSharedKey = (string) content.GetValueForProperty("LogAnalyticConfigurationSharedKey",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).LogAnalyticConfigurationSharedKey, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ManagedEnvironment"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ManagedEnvironment(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ManagedEnvironmentPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.App.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.App.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.App.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.App.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.TrackedResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api30.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("VnetConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).VnetConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IVnetConfiguration) content.GetValueForProperty("VnetConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).VnetConfiguration, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.VnetConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("AppLogsConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).AppLogsConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAppLogsConfiguration) content.GetValueForProperty("AppLogsConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).AppLogsConfiguration, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.AppLogsConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.App.Support.EnvironmentProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.App.Support.EnvironmentProvisioningState.CreateFrom);
            }
            if (content.Contains("DaprAiInstrumentationKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).DaprAiInstrumentationKey = (string) content.GetValueForProperty("DaprAiInstrumentationKey",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).DaprAiInstrumentationKey, global::System.Convert.ToString);
            }
            if (content.Contains("DaprAiConnectionString"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).DaprAiConnectionString = (string) content.GetValueForProperty("DaprAiConnectionString",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).DaprAiConnectionString, global::System.Convert.ToString);
            }
            if (content.Contains("DeploymentError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).DeploymentError = (string) content.GetValueForProperty("DeploymentError",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).DeploymentError, global::System.Convert.ToString);
            }
            if (content.Contains("DefaultDomain"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).DefaultDomain = (string) content.GetValueForProperty("DefaultDomain",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).DefaultDomain, global::System.Convert.ToString);
            }
            if (content.Contains("StaticIP"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).StaticIP = (string) content.GetValueForProperty("StaticIP",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).StaticIP, global::System.Convert.ToString);
            }
            if (content.Contains("ZoneRedundant"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).ZoneRedundant = (bool?) content.GetValueForProperty("ZoneRedundant",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).ZoneRedundant, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AppLogConfigurationDestination"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).AppLogConfigurationDestination = (string) content.GetValueForProperty("AppLogConfigurationDestination",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).AppLogConfigurationDestination, global::System.Convert.ToString);
            }
            if (content.Contains("VnetConfigurationInternal"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).VnetConfigurationInternal = (bool?) content.GetValueForProperty("VnetConfigurationInternal",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).VnetConfigurationInternal, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("VnetConfigurationInfrastructureSubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).VnetConfigurationInfrastructureSubnetId = (string) content.GetValueForProperty("VnetConfigurationInfrastructureSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).VnetConfigurationInfrastructureSubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("VnetConfigurationRuntimeSubnetId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).VnetConfigurationRuntimeSubnetId = (string) content.GetValueForProperty("VnetConfigurationRuntimeSubnetId",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).VnetConfigurationRuntimeSubnetId, global::System.Convert.ToString);
            }
            if (content.Contains("VnetConfigurationDockerBridgeCidr"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).VnetConfigurationDockerBridgeCidr = (string) content.GetValueForProperty("VnetConfigurationDockerBridgeCidr",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).VnetConfigurationDockerBridgeCidr, global::System.Convert.ToString);
            }
            if (content.Contains("VnetConfigurationPlatformReservedCidr"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).VnetConfigurationPlatformReservedCidr = (string) content.GetValueForProperty("VnetConfigurationPlatformReservedCidr",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).VnetConfigurationPlatformReservedCidr, global::System.Convert.ToString);
            }
            if (content.Contains("VnetConfigurationPlatformReservedDnsIP"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).VnetConfigurationPlatformReservedDnsIP = (string) content.GetValueForProperty("VnetConfigurationPlatformReservedDnsIP",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).VnetConfigurationPlatformReservedDnsIP, global::System.Convert.ToString);
            }
            if (content.Contains("AppLogConfigurationLogAnalyticsConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).AppLogConfigurationLogAnalyticsConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ILogAnalyticsConfiguration) content.GetValueForProperty("AppLogConfigurationLogAnalyticsConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).AppLogConfigurationLogAnalyticsConfiguration, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.LogAnalyticsConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("LogAnalyticConfigurationCustomerId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).LogAnalyticConfigurationCustomerId = (string) content.GetValueForProperty("LogAnalyticConfigurationCustomerId",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).LogAnalyticConfigurationCustomerId, global::System.Convert.ToString);
            }
            if (content.Contains("LogAnalyticConfigurationSharedKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).LogAnalyticConfigurationSharedKey = (string) content.GetValueForProperty("LogAnalyticConfigurationSharedKey",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IManagedEnvironmentInternal)this).LogAnalyticConfigurationSharedKey, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// An environment for hosting container apps
    [System.ComponentModel.TypeConverter(typeof(ManagedEnvironmentTypeConverter))]
    public partial interface IManagedEnvironment

    {

    }
}