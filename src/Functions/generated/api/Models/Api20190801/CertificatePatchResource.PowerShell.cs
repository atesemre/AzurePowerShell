namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801
{
    using Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.PowerShell;

    /// <summary>ARM resource for a certificate.</summary>
    [System.ComponentModel.TypeConverter(typeof(CertificatePatchResourceTypeConverter))]
    public partial class CertificatePatchResource
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
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.CertificatePatchResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal CertificatePatchResource(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.CertificatePatchResourcePropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IProxyOnlyResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IProxyOnlyResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IProxyOnlyResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IProxyOnlyResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IProxyOnlyResourceInternal)this).Kind = (string) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IProxyOnlyResourceInternal)this).Kind, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IProxyOnlyResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IProxyOnlyResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).Thumbprint = (string) content.GetValueForProperty("Thumbprint",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).Thumbprint, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).HostingEnvironmentProfile = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IHostingEnvironmentProfile) content.GetValueForProperty("HostingEnvironmentProfile",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).HostingEnvironmentProfile, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.HostingEnvironmentProfileTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).SubjectName = (string) content.GetValueForProperty("SubjectName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).SubjectName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).HostName = (string[]) content.GetValueForProperty("HostName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).HostName, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).PfxBlob = (byte[]) content.GetValueForProperty("PfxBlob",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).PfxBlob, i => i);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).SiteName = (string) content.GetValueForProperty("SiteName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).SiteName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).SelfLink = (string) content.GetValueForProperty("SelfLink",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).SelfLink, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).Issuer = (string) content.GetValueForProperty("Issuer",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).Issuer, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).IssueDate = (global::System.DateTime?) content.GetValueForProperty("IssueDate",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).IssueDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).ExpirationDate = (global::System.DateTime?) content.GetValueForProperty("ExpirationDate",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).ExpirationDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).Password = (string) content.GetValueForProperty("Password",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).Password, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).FriendlyName = (string) content.GetValueForProperty("FriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).FriendlyName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).Valid = (bool?) content.GetValueForProperty("Valid",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).Valid, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).CerBlob = (byte[]) content.GetValueForProperty("CerBlob",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).CerBlob, i => i);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).PublicKeyHash = (string) content.GetValueForProperty("PublicKeyHash",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).PublicKeyHash, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).KeyVaultId = (string) content.GetValueForProperty("KeyVaultId",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).KeyVaultId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).KeyVaultSecretName = (string) content.GetValueForProperty("KeyVaultSecretName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).KeyVaultSecretName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).KeyVaultSecretStatus = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.KeyVaultSecretStatus?) content.GetValueForProperty("KeyVaultSecretStatus",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).KeyVaultSecretStatus, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.KeyVaultSecretStatus.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).ServerFarmId = (string) content.GetValueForProperty("ServerFarmId",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).ServerFarmId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).CanonicalName = (string) content.GetValueForProperty("CanonicalName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).CanonicalName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).HostingEnvironmentProfileId = (string) content.GetValueForProperty("HostingEnvironmentProfileId",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).HostingEnvironmentProfileId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).HostingEnvironmentProfileName = (string) content.GetValueForProperty("HostingEnvironmentProfileName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).HostingEnvironmentProfileName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).HostingEnvironmentProfileType = (string) content.GetValueForProperty("HostingEnvironmentProfileType",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).HostingEnvironmentProfileType, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.CertificatePatchResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal CertificatePatchResource(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.CertificatePatchResourcePropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IProxyOnlyResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IProxyOnlyResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IProxyOnlyResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IProxyOnlyResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IProxyOnlyResourceInternal)this).Kind = (string) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IProxyOnlyResourceInternal)this).Kind, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IProxyOnlyResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IProxyOnlyResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).Thumbprint = (string) content.GetValueForProperty("Thumbprint",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).Thumbprint, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).HostingEnvironmentProfile = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.IHostingEnvironmentProfile) content.GetValueForProperty("HostingEnvironmentProfile",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).HostingEnvironmentProfile, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.HostingEnvironmentProfileTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).SubjectName = (string) content.GetValueForProperty("SubjectName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).SubjectName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).HostName = (string[]) content.GetValueForProperty("HostName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).HostName, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).PfxBlob = (byte[]) content.GetValueForProperty("PfxBlob",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).PfxBlob, i => i);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).SiteName = (string) content.GetValueForProperty("SiteName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).SiteName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).SelfLink = (string) content.GetValueForProperty("SelfLink",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).SelfLink, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).Issuer = (string) content.GetValueForProperty("Issuer",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).Issuer, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).IssueDate = (global::System.DateTime?) content.GetValueForProperty("IssueDate",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).IssueDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).ExpirationDate = (global::System.DateTime?) content.GetValueForProperty("ExpirationDate",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).ExpirationDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).Password = (string) content.GetValueForProperty("Password",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).Password, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).FriendlyName = (string) content.GetValueForProperty("FriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).FriendlyName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).Valid = (bool?) content.GetValueForProperty("Valid",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).Valid, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).CerBlob = (byte[]) content.GetValueForProperty("CerBlob",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).CerBlob, i => i);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).PublicKeyHash = (string) content.GetValueForProperty("PublicKeyHash",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).PublicKeyHash, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).KeyVaultId = (string) content.GetValueForProperty("KeyVaultId",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).KeyVaultId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).KeyVaultSecretName = (string) content.GetValueForProperty("KeyVaultSecretName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).KeyVaultSecretName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).KeyVaultSecretStatus = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.KeyVaultSecretStatus?) content.GetValueForProperty("KeyVaultSecretStatus",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).KeyVaultSecretStatus, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.KeyVaultSecretStatus.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).ServerFarmId = (string) content.GetValueForProperty("ServerFarmId",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).ServerFarmId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).CanonicalName = (string) content.GetValueForProperty("CanonicalName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).CanonicalName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).HostingEnvironmentProfileId = (string) content.GetValueForProperty("HostingEnvironmentProfileId",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).HostingEnvironmentProfileId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).HostingEnvironmentProfileName = (string) content.GetValueForProperty("HostingEnvironmentProfileName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).HostingEnvironmentProfileName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).HostingEnvironmentProfileType = (string) content.GetValueForProperty("HostingEnvironmentProfileType",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResourceInternal)this).HostingEnvironmentProfileType, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.CertificatePatchResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResource DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new CertificatePatchResource(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.CertificatePatchResource"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResource" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResource DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new CertificatePatchResource(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="CertificatePatchResource" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20190801.ICertificatePatchResource FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// ARM resource for a certificate.
    [System.ComponentModel.TypeConverter(typeof(CertificatePatchResourceTypeConverter))]
    public partial interface ICertificatePatchResource

    {

    }
}