// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Extensions;

    /// <summary>SiteLogsConfig resource specific properties</summary>
    public partial class SiteLogsConfigProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISiteLogsConfigProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISiteLogsConfigProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ISiteLogsConfigProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject json ? new SiteLogsConfigProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject into a new instance of <see cref="SiteLogsConfigProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal SiteLogsConfigProperties(Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_applicationLog = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject>("applicationLogs"), out var __jsonApplicationLogs) ? Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.ApplicationLogsConfig.FromJson(__jsonApplicationLogs) : ApplicationLog;}
            {_httpLog = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject>("httpLogs"), out var __jsonHttpLogs) ? Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.HttpLogsConfig.FromJson(__jsonHttpLogs) : HttpLog;}
            {_failedRequestsTracing = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject>("failedRequestsTracing"), out var __jsonFailedRequestsTracing) ? Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.EnabledConfig.FromJson(__jsonFailedRequestsTracing) : FailedRequestsTracing;}
            {_detailedErrorMessage = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject>("detailedErrorMessages"), out var __jsonDetailedErrorMessages) ? Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.EnabledConfig.FromJson(__jsonDetailedErrorMessages) : DetailedErrorMessage;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="SiteLogsConfigProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="SiteLogsConfigProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._applicationLog ? (Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode) this._applicationLog.ToJson(null,serializationMode) : null, "applicationLogs" ,container.Add );
            AddIf( null != this._httpLog ? (Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode) this._httpLog.ToJson(null,serializationMode) : null, "httpLogs" ,container.Add );
            AddIf( null != this._failedRequestsTracing ? (Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode) this._failedRequestsTracing.ToJson(null,serializationMode) : null, "failedRequestsTracing" ,container.Add );
            AddIf( null != this._detailedErrorMessage ? (Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Json.JsonNode) this._detailedErrorMessage.ToJson(null,serializationMode) : null, "detailedErrorMessages" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}