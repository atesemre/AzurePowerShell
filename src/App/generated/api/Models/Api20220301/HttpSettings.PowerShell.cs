// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301
{
    using Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.PowerShell;

    /// <summary>
    /// The configuration settings of the HTTP requests for authentication and authorization requests made against ContainerApp
    /// Service Authentication/Authorization.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(HttpSettingsTypeConverter))]
    public partial class HttpSettings
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.HttpSettings"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IHttpSettings" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IHttpSettings DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new HttpSettings(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.HttpSettings"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IHttpSettings" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IHttpSettings DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new HttpSettings(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="HttpSettings" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="HttpSettings" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IHttpSettings FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.HttpSettings"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal HttpSettings(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Route"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IHttpSettingsInternal)this).Route = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IHttpSettingsRoutes) content.GetValueForProperty("Route",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IHttpSettingsInternal)this).Route, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.HttpSettingsRoutesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ForwardProxy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IHttpSettingsInternal)this).ForwardProxy = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IForwardProxy) content.GetValueForProperty("ForwardProxy",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IHttpSettingsInternal)this).ForwardProxy, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ForwardProxyTypeConverter.ConvertFrom);
            }
            if (content.Contains("RequireHttps"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IHttpSettingsInternal)this).RequireHttps = (bool?) content.GetValueForProperty("RequireHttps",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IHttpSettingsInternal)this).RequireHttps, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ForwardProxyConvention"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IHttpSettingsInternal)this).ForwardProxyConvention = (Microsoft.Azure.PowerShell.Cmdlets.App.Support.ForwardProxyConvention?) content.GetValueForProperty("ForwardProxyConvention",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IHttpSettingsInternal)this).ForwardProxyConvention, Microsoft.Azure.PowerShell.Cmdlets.App.Support.ForwardProxyConvention.CreateFrom);
            }
            if (content.Contains("RouteApiPrefix"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IHttpSettingsInternal)this).RouteApiPrefix = (string) content.GetValueForProperty("RouteApiPrefix",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IHttpSettingsInternal)this).RouteApiPrefix, global::System.Convert.ToString);
            }
            if (content.Contains("ForwardProxyCustomHostHeaderName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IHttpSettingsInternal)this).ForwardProxyCustomHostHeaderName = (string) content.GetValueForProperty("ForwardProxyCustomHostHeaderName",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IHttpSettingsInternal)this).ForwardProxyCustomHostHeaderName, global::System.Convert.ToString);
            }
            if (content.Contains("ForwardProxyCustomProtoHeaderName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IHttpSettingsInternal)this).ForwardProxyCustomProtoHeaderName = (string) content.GetValueForProperty("ForwardProxyCustomProtoHeaderName",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IHttpSettingsInternal)this).ForwardProxyCustomProtoHeaderName, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.HttpSettings"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal HttpSettings(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Route"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IHttpSettingsInternal)this).Route = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IHttpSettingsRoutes) content.GetValueForProperty("Route",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IHttpSettingsInternal)this).Route, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.HttpSettingsRoutesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ForwardProxy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IHttpSettingsInternal)this).ForwardProxy = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IForwardProxy) content.GetValueForProperty("ForwardProxy",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IHttpSettingsInternal)this).ForwardProxy, Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.ForwardProxyTypeConverter.ConvertFrom);
            }
            if (content.Contains("RequireHttps"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IHttpSettingsInternal)this).RequireHttps = (bool?) content.GetValueForProperty("RequireHttps",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IHttpSettingsInternal)this).RequireHttps, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ForwardProxyConvention"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IHttpSettingsInternal)this).ForwardProxyConvention = (Microsoft.Azure.PowerShell.Cmdlets.App.Support.ForwardProxyConvention?) content.GetValueForProperty("ForwardProxyConvention",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IHttpSettingsInternal)this).ForwardProxyConvention, Microsoft.Azure.PowerShell.Cmdlets.App.Support.ForwardProxyConvention.CreateFrom);
            }
            if (content.Contains("RouteApiPrefix"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IHttpSettingsInternal)this).RouteApiPrefix = (string) content.GetValueForProperty("RouteApiPrefix",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IHttpSettingsInternal)this).RouteApiPrefix, global::System.Convert.ToString);
            }
            if (content.Contains("ForwardProxyCustomHostHeaderName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IHttpSettingsInternal)this).ForwardProxyCustomHostHeaderName = (string) content.GetValueForProperty("ForwardProxyCustomHostHeaderName",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IHttpSettingsInternal)this).ForwardProxyCustomHostHeaderName, global::System.Convert.ToString);
            }
            if (content.Contains("ForwardProxyCustomProtoHeaderName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IHttpSettingsInternal)this).ForwardProxyCustomProtoHeaderName = (string) content.GetValueForProperty("ForwardProxyCustomProtoHeaderName",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IHttpSettingsInternal)this).ForwardProxyCustomProtoHeaderName, global::System.Convert.ToString);
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
    /// The configuration settings of the HTTP requests for authentication and authorization requests made against ContainerApp
    /// Service Authentication/Authorization.
    [System.ComponentModel.TypeConverter(typeof(HttpSettingsTypeConverter))]
    public partial interface IHttpSettings

    {

    }
}