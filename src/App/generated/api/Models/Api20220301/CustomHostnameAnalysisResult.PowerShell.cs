// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301
{
    using Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.PowerShell;

    /// <summary>Custom domain analysis.</summary>
    [System.ComponentModel.TypeConverter(typeof(CustomHostnameAnalysisResultTypeConverter))]
    public partial class CustomHostnameAnalysisResult
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.CustomHostnameAnalysisResult"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal CustomHostnameAnalysisResult(global::System.Collections.IDictionary content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.CustomHostnameAnalysisResultPropertiesTypeConverter.ConvertFrom);
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
            if (content.Contains("CustomDomainVerificationFailureInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).CustomDomainVerificationFailureInfo = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IDefaultErrorResponse) content.GetValueForProperty("CustomDomainVerificationFailureInfo",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).CustomDomainVerificationFailureInfo, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.DefaultErrorResponseTypeConverter.ConvertFrom);
            }
            if (content.Contains("HostName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).HostName = (string) content.GetValueForProperty("HostName",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).HostName, global::System.Convert.ToString);
            }
            if (content.Contains("IsHostnameAlreadyVerified"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).IsHostnameAlreadyVerified = (bool?) content.GetValueForProperty("IsHostnameAlreadyVerified",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).IsHostnameAlreadyVerified, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("CustomDomainVerificationTest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).CustomDomainVerificationTest = (Microsoft.Azure.PowerShell.Cmdlets.App.Support.DnsVerificationTestResult?) content.GetValueForProperty("CustomDomainVerificationTest",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).CustomDomainVerificationTest, Microsoft.Azure.PowerShell.Cmdlets.App.Support.DnsVerificationTestResult.CreateFrom);
            }
            if (content.Contains("HasConflictOnManagedEnvironment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).HasConflictOnManagedEnvironment = (bool?) content.GetValueForProperty("HasConflictOnManagedEnvironment",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).HasConflictOnManagedEnvironment, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ConflictingContainerAppResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).ConflictingContainerAppResourceId = (string) content.GetValueForProperty("ConflictingContainerAppResourceId",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).ConflictingContainerAppResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("CNameRecord"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).CNameRecord = (string[]) content.GetValueForProperty("CNameRecord",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).CNameRecord, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("TxtRecord"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).TxtRecord = (string[]) content.GetValueForProperty("TxtRecord",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).TxtRecord, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ARecord"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).ARecord = (string[]) content.GetValueForProperty("ARecord",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).ARecord, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AlternateCNameRecord"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).AlternateCNameRecord = (string[]) content.GetValueForProperty("AlternateCNameRecord",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).AlternateCNameRecord, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AlternateTxtRecord"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).AlternateTxtRecord = (string[]) content.GetValueForProperty("AlternateTxtRecord",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).AlternateTxtRecord, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("CustomDomainVerificationFailureInfoError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).CustomDomainVerificationFailureInfoError = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IDefaultErrorResponseError) content.GetValueForProperty("CustomDomainVerificationFailureInfoError",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).CustomDomainVerificationFailureInfoError, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.DefaultErrorResponseErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).Message, global::System.Convert.ToString);
            }
            if (content.Contains("Target"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).Target = (string) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).Target, global::System.Convert.ToString);
            }
            if (content.Contains("Detail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).Detail = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IDefaultErrorResponseErrorDetailsItem[]) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).Detail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IDefaultErrorResponseErrorDetailsItem>(__y, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.DefaultErrorResponseErrorDetailsItemTypeConverter.ConvertFrom));
            }
            if (content.Contains("Innererror"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).Innererror = (string) content.GetValueForProperty("Innererror",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).Innererror, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.CustomHostnameAnalysisResult"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal CustomHostnameAnalysisResult(global::System.Management.Automation.PSObject content)
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
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.CustomHostnameAnalysisResultPropertiesTypeConverter.ConvertFrom);
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
            if (content.Contains("CustomDomainVerificationFailureInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).CustomDomainVerificationFailureInfo = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IDefaultErrorResponse) content.GetValueForProperty("CustomDomainVerificationFailureInfo",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).CustomDomainVerificationFailureInfo, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.DefaultErrorResponseTypeConverter.ConvertFrom);
            }
            if (content.Contains("HostName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).HostName = (string) content.GetValueForProperty("HostName",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).HostName, global::System.Convert.ToString);
            }
            if (content.Contains("IsHostnameAlreadyVerified"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).IsHostnameAlreadyVerified = (bool?) content.GetValueForProperty("IsHostnameAlreadyVerified",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).IsHostnameAlreadyVerified, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("CustomDomainVerificationTest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).CustomDomainVerificationTest = (Microsoft.Azure.PowerShell.Cmdlets.App.Support.DnsVerificationTestResult?) content.GetValueForProperty("CustomDomainVerificationTest",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).CustomDomainVerificationTest, Microsoft.Azure.PowerShell.Cmdlets.App.Support.DnsVerificationTestResult.CreateFrom);
            }
            if (content.Contains("HasConflictOnManagedEnvironment"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).HasConflictOnManagedEnvironment = (bool?) content.GetValueForProperty("HasConflictOnManagedEnvironment",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).HasConflictOnManagedEnvironment, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ConflictingContainerAppResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).ConflictingContainerAppResourceId = (string) content.GetValueForProperty("ConflictingContainerAppResourceId",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).ConflictingContainerAppResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("CNameRecord"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).CNameRecord = (string[]) content.GetValueForProperty("CNameRecord",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).CNameRecord, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("TxtRecord"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).TxtRecord = (string[]) content.GetValueForProperty("TxtRecord",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).TxtRecord, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ARecord"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).ARecord = (string[]) content.GetValueForProperty("ARecord",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).ARecord, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AlternateCNameRecord"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).AlternateCNameRecord = (string[]) content.GetValueForProperty("AlternateCNameRecord",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).AlternateCNameRecord, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("AlternateTxtRecord"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).AlternateTxtRecord = (string[]) content.GetValueForProperty("AlternateTxtRecord",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).AlternateTxtRecord, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("CustomDomainVerificationFailureInfoError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).CustomDomainVerificationFailureInfoError = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IDefaultErrorResponseError) content.GetValueForProperty("CustomDomainVerificationFailureInfoError",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).CustomDomainVerificationFailureInfoError, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.DefaultErrorResponseErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).Message, global::System.Convert.ToString);
            }
            if (content.Contains("Target"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).Target = (string) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).Target, global::System.Convert.ToString);
            }
            if (content.Contains("Detail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).Detail = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IDefaultErrorResponseErrorDetailsItem[]) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).Detail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IDefaultErrorResponseErrorDetailsItem>(__y, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.DefaultErrorResponseErrorDetailsItemTypeConverter.ConvertFrom));
            }
            if (content.Contains("Innererror"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).Innererror = (string) content.GetValueForProperty("Innererror",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResultInternal)this).Innererror, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.CustomHostnameAnalysisResult"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResult" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResult DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new CustomHostnameAnalysisResult(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.CustomHostnameAnalysisResult"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResult" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResult DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new CustomHostnameAnalysisResult(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="CustomHostnameAnalysisResult" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="CustomHostnameAnalysisResult" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ICustomHostnameAnalysisResult FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// Custom domain analysis.
    [System.ComponentModel.TypeConverter(typeof(CustomHostnameAnalysisResultTypeConverter))]
    public partial interface ICustomHostnameAnalysisResult

    {

    }
}