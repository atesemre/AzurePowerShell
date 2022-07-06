#
# Module manifest for module 'Az'
#
# Generated by: Microsoft Corporation
#
# Generated on: 6/30/2022
#

@{

# Script module or binary module file associated with this manifest.
# RootModule = ''

# Version number of this module.
ModuleVersion = '8.1.0'

# Supported PSEditions
CompatiblePSEditions = 'Core', 'Desktop'

# ID used to uniquely identify this module
GUID = 'd48d710e-85cb-46a1-990f-22dae76f6b5f'

# Author of this module
Author = 'Microsoft Corporation'

# Company or vendor of this module
CompanyName = 'Microsoft Corporation'

# Copyright statement for this module
Copyright = 'Microsoft Corporation. All rights reserved.'

# Description of the functionality provided by this module
Description = 'Microsoft Azure PowerShell - Cmdlets to manage resources in Azure. This module is compatible with PowerShell and Windows PowerShell.
For more information about the Az module, please visit the following: https://docs.microsoft.com/powershell/azure/'

# Minimum version of the PowerShell engine required by this module
PowerShellVersion = '5.1'

# Name of the PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
DotNetFrameworkVersion = '4.7.2'

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# ClrVersion = ''

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
RequiredModules = @(@{ModuleName = 'Az.Accounts'; ModuleVersion = '2.9.0'; }, 
               @{ModuleName = 'Az.Advisor'; RequiredVersion = '1.1.2'; }, 
               @{ModuleName = 'Az.Aks'; RequiredVersion = '4.2.0'; }, 
               @{ModuleName = 'Az.AnalysisServices'; RequiredVersion = '1.1.4'; }, 
               @{ModuleName = 'Az.ApiManagement'; RequiredVersion = '3.0.0'; }, 
               @{ModuleName = 'Az.AppConfiguration'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.ApplicationInsights'; RequiredVersion = '2.1.0'; }, 
               @{ModuleName = 'Az.Attestation'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.Automation'; RequiredVersion = '1.7.3'; }, 
               @{ModuleName = 'Az.Batch'; RequiredVersion = '3.2.0'; }, 
               @{ModuleName = 'Az.Billing'; RequiredVersion = '2.0.0'; }, 
               @{ModuleName = 'Az.Cdn'; RequiredVersion = '2.1.0'; }, 
               @{ModuleName = 'Az.CloudService'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.CognitiveServices'; RequiredVersion = '1.11.0'; }, 
               @{ModuleName = 'Az.Compute'; RequiredVersion = '4.29.0'; }, 
               @{ModuleName = 'Az.ContainerInstance'; RequiredVersion = '3.1.0'; }, 
               @{ModuleName = 'Az.ContainerRegistry'; RequiredVersion = '3.0.0'; }, 
               @{ModuleName = 'Az.CosmosDB'; RequiredVersion = '1.8.2'; }, 
               @{ModuleName = 'Az.DataBoxEdge'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.Databricks'; RequiredVersion = '1.2.0'; }, 
               @{ModuleName = 'Az.DataFactory'; RequiredVersion = '1.16.8'; }, 
               @{ModuleName = 'Az.DataLakeAnalytics'; RequiredVersion = '1.0.2'; }, 
               @{ModuleName = 'Az.DataLakeStore'; RequiredVersion = '1.3.0'; }, 
               @{ModuleName = 'Az.DataShare'; RequiredVersion = '1.0.1'; }, 
               @{ModuleName = 'Az.DesktopVirtualization'; RequiredVersion = '3.1.0'; }, 
               @{ModuleName = 'Az.DeploymentManager'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.DevTestLabs'; RequiredVersion = '1.0.2'; }, 
               @{ModuleName = 'Az.Dns'; RequiredVersion = '1.1.2'; }, 
               @{ModuleName = 'Az.EventGrid'; RequiredVersion = '1.3.0'; }, 
               @{ModuleName = 'Az.EventHub'; RequiredVersion = '2.1.0'; }, 
               @{ModuleName = 'Az.FrontDoor'; RequiredVersion = '1.9.0'; }, 
               @{ModuleName = 'Az.Functions'; RequiredVersion = '4.0.3'; }, 
               @{ModuleName = 'Az.HDInsight'; RequiredVersion = '5.0.1'; }, 
               @{ModuleName = 'Az.HealthcareApis'; RequiredVersion = '2.0.0'; }, 
               @{ModuleName = 'Az.IotHub'; RequiredVersion = '2.7.4'; }, 
               @{ModuleName = 'Az.KeyVault'; RequiredVersion = '4.6.0'; }, 
               @{ModuleName = 'Az.Kusto'; RequiredVersion = '2.1.0'; }, 
               @{ModuleName = 'Az.LogicApp'; RequiredVersion = '1.5.0'; }, 
               @{ModuleName = 'Az.MachineLearning'; RequiredVersion = '1.1.3'; }, 
               @{ModuleName = 'Az.Maintenance'; RequiredVersion = '1.2.0'; }, 
               @{ModuleName = 'Az.ManagedServiceIdentity'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.ManagedServices'; RequiredVersion = '3.0.0'; }, 
               @{ModuleName = 'Az.MarketplaceOrdering'; RequiredVersion = '1.0.2'; }, 
               @{ModuleName = 'Az.Media'; RequiredVersion = '1.1.1'; }, 
               @{ModuleName = 'Az.Migrate'; RequiredVersion = '1.1.2'; }, 
               @{ModuleName = 'Az.Monitor'; RequiredVersion = '3.0.1'; }, 
               @{ModuleName = 'Az.MySql'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.Network'; RequiredVersion = '4.18.0'; }, 
               @{ModuleName = 'Az.NotificationHubs'; RequiredVersion = '1.1.1'; }, 
               @{ModuleName = 'Az.OperationalInsights'; RequiredVersion = '3.1.0'; }, 
               @{ModuleName = 'Az.PolicyInsights'; RequiredVersion = '1.5.0'; }, 
               @{ModuleName = 'Az.PostgreSql'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.PowerBIEmbedded'; RequiredVersion = '1.2.0'; }, 
               @{ModuleName = 'Az.PrivateDns'; RequiredVersion = '1.0.3'; }, 
               @{ModuleName = 'Az.RecoveryServices'; RequiredVersion = '5.4.1'; }, 
               @{ModuleName = 'Az.RedisCache'; RequiredVersion = '1.6.0'; }, 
               @{ModuleName = 'Az.RedisEnterpriseCache'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.Relay'; RequiredVersion = '1.0.3'; }, 
               @{ModuleName = 'Az.ResourceMover'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.Resources'; RequiredVersion = '6.0.1'; }, 
               @{ModuleName = 'Az.Security'; RequiredVersion = '1.3.0'; }, 
               @{ModuleName = 'Az.SecurityInsights'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.ServiceBus'; RequiredVersion = '1.10.0'; }, 
               @{ModuleName = 'Az.ServiceFabric'; RequiredVersion = '3.1.0'; }, 
               @{ModuleName = 'Az.SignalR'; RequiredVersion = '1.4.1'; }, 
               @{ModuleName = 'Az.Sql'; RequiredVersion = '3.10.0'; }, 
               @{ModuleName = 'Az.SqlVirtualMachine'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.StackHCI'; RequiredVersion = '1.3.0'; }, 
               @{ModuleName = 'Az.Storage'; RequiredVersion = '4.7.0'; }, 
               @{ModuleName = 'Az.StorageSync'; RequiredVersion = '1.7.0'; }, 
               @{ModuleName = 'Az.StreamAnalytics'; RequiredVersion = '2.0.0'; }, 
               @{ModuleName = 'Az.Support'; RequiredVersion = '1.0.0'; }, 
               @{ModuleName = 'Az.Synapse'; RequiredVersion = '1.4.0'; }, 
               @{ModuleName = 'Az.TrafficManager'; RequiredVersion = '1.1.0'; }, 
               @{ModuleName = 'Az.Websites'; RequiredVersion = '2.11.2'; })

# Assemblies that must be loaded prior to importing this module
# RequiredAssemblies = @()

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
# FormatsToProcess = @()

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
# NestedModules = @()

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = @()

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = @()

# Variables to export from this module
# VariablesToExport = @()

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = @()

# DSC resources to export from this module
# DscResourcesToExport = @()

# List of all modules packaged with this module
# ModuleList = @()

# List of all files packaged with this module
# FileList = @()

# Private data to pass to the module specified in RootModule/ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
PrivateData = @{

    PSData = @{

        # Tags applied to this module. These help with module discovery in online galleries.
        Tags = 'Azure','ARM','ResourceManager','Linux','AzureAutomationNotSupported'

        # A URL to the license for this module.
        LicenseUri = 'https://aka.ms/azps-license'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/Azure/azure-powershell'

        # A URL to an icon representing this module.
        # IconUri = ''

        # ReleaseNotes of this module
        ReleaseNotes = '8.1.0 - July 2022
Az.Accounts
* Supported exporting and importing configurations by ''Export-AzConfig'' and ''Import-AzConfig''.
* Fixed an issue that Az.Accounts may fail to be imported in parallel PowerShell processes. [#18321] 
* Fixed incorrect access token [#18105]
* Upgraded version of Microsoft.Identity.Client for .NET Framework. [#18495]
* Fixed an issue that Az.Accounts failed to be imported if multiple environment variables, which only differ by case, are set. [#18304]

Az.Aks
* Added parameter ''CommandContextAttachmentZip'' for ''Invoke-AzAksRunCommand''. [#17454]
* Added ManagedIdentity support for Aks[#15656].
* Added property ''PowerState'' for the output of ''Get-AzAksCluster''[#18271]
* Updated the logic of ''Set-AzAksCluster'' for parameter ''NodeImageOnly''.
* Added parameter ''NodeImageOnly'' for ''Update-AzAksNodePool''.
* Added parameter ''AvailabilityZone'' for ''New-AzAksCluster''. [#18658]

Az.ApplicationInsights
* Fixed parameters for Set-AzApplicationInsightsDailyCap [#18315]
* Fixed parameter ''DocumentType'' for ''New-AzApplicationInsightsContinuousExport'' and ''Set-AzApplicationInsightsContinuousExport'' [#18350]
* Fixed parameter ''ResourceId'' for ''Get-AzApplicationInsights'' [#18707]

Az.Compute
* Added image alias ''Win2022AzureEditionCore''
* Added the ''-DisableIntegrityMonitoring'' switch parameter to the ''New-AzVM'' cmdlet. 
  Changed the default behavior for ''New-AzVM'' and ''New-AzVmss'' when these conditions are met:
  1) ''-DisableIntegrityMonitoring'' is not true.
  2) ''SecurityType'' on the SecurityProfile is ''TrustedLaunch''.
  3) ''VTpmEnabled'' on the SecurityProfile is true.
  4) ''SecureBootEnabled'' on the SecurityProfile is true. 
  Now ''New-AzVM'' will install the ''Guest Attestation'' extension to the new VM when these conditions are met.
  Now ''New-AzVmss'' will install the ''Guest Attestation'' extension to the new Vmss when these conditions are met and installed to all VM instances in the Vmss.
* Added ''-UserAssignedIdentity'' and ''-FederatedClientId'' to the following cmdlets:
    - ''New-AzDiskEncryptionSetConfig''
    - ''Update-AzDiskEncryptionSet''
* Added ''-TreatFailureAsDeploymentFailure'' to cmdlets ''Add-AzVmGalleryApplication'' and ''Add-AzVmssGalleryApplication''
* Removed Exceptions for when SinglePlacementGroup is set to true in ''OrchestrationMode''

Az.CosmosDB
* Added support for partition key and id paths to be part of client encryption policy.
* Fixed bug related to Update-AzCosmosDBSqlContainer command on containers with Client Encryption Policy.

Az.DataFactory
* Updated ADF .Net SDK version to 6.3.0

Az.EventHub
* Added cmdlets for CRUD operations on EventHub Application Groups. The added cmdlets include,
    -New-AzEventHubApplicationGroup
    -Set-AzEventHubApplicationGroup
    -Remove-AzEventHubApplicationGroup
    -Get-AzEventHubApplicationGroup
    -New-AzEventHubThrottlingPolicyConfig
* Get-AzEventHubNamespace returned a maximum of 100 namespaces for list by resource groups or list by subscriptions so far. From here onwards, for resource groups and subscriptions with over a 100 namespaces, the cmdlet will return all the namespaces. You will not see a change in the cmdlet behaviour if your resource groups or subscriptions have less than a 100 namespaces.
* Added cmdlets for manual approval of EventHubs Private Endpoint Connections. The added cmdlets include,
    -Approve-AzEventHubPrivateEndpointConnection
    -Deny-AzEventHubPrivateEndpointConnection
    -Get-AzEventHubPrivateEndpointConnection
    -Remove-AzEventHubPrivateEndpointConnection
    -Get-AzEventHubPrivateLink

Az.KeyVault
* Supported importing pem certificate by ''Import-AzKeyVaultCertificate'' [#18494]
* Supported accepting rotation policy in a JSON file 
* [Breaking Change] Changed parameter ''ExpiresIn'' in ''Set-AzKeyVaultKeyRotationPolicy'' from TimeSpan? to string. It must be an ISO 8601 duration like ''P30D'' for 30 days.
* [Breaking Change] Changed output properties ''ExpiresIn'', ''TimeAfterCreate'' and ''TimeBeforeExpiry'' of ''Set-AzKeyVaultKeyRotationPolicy'' and ''Get-AzKeyVaultKeyRotationPolicy'' from TimeSpan? to string.
* Supported creating/updating key with release policy in a Managed HSM
* Removed default value for ''EnabledForDeployment'', ''EnabledForTemplateDeployment'', ''EnabledForDiskEncryption'' and ''EnableRbacAuthorization'' during the process of key vault creation
* Changed default access policies for Key Vault secret, certificate and storage as ''All''

Az.Network
* Added support for CustomV2 ssl policies for Application Gateway.
    - Added ''CustomV2'' to the validation set of ''PolicyType''
    - Added ''TLSv1_3'' to the validation set of ''MinProtocolVersion''
    - Removed validation for null or empty cipher suites list since there can be empty cipher suites list for min protocol version of tls1.3
* [Breaking Change] Changed default value of ''-PrivateEndpointNetworkPoliciesFlag'' to ''Disabled'' in ''Add-AzVirtualNetworkSubnetConfig'' and ''New-AzVirtualNetworkSubnetConfig''
* Fixed bugs that cannot parse virtual network encryption paramemters when updating exsiting vnet.

Az.PowerBIEmbedded
* Updated SKU allowed values to support A7 and A8

Az.RecoveryServices
* Fixed delay in long running operations [#18567]

Az.Resources
* Added feedback when deleting role assignments even if passthru is not used
* Fixed relative path failure in -AsJob scenario [#18084]
* Fixed logic of ''createtime'' and ''ChangedTime'' in ''Get-AzResource --ExpandProperties''. [#18206]
* Fixed role assignment latency for ''New-AzADServicePrincipal'' [#16777]

Az.ServiceBus
* Added cmdlets for manual approval of Service Bus Private Endpoint Connections. The added cmdlets include,
    -Approve-AzServiceBusPrivateEndpointConnection
    -Deny-AzServiceBusPrivateEndpointConnection
    -Get-AzServiceBusPrivateEndpointConnection
    -Remove-AzServiceBusPrivateEndpointConnection
    -Get-AzServiceBusPrivateLink

Az.ServiceFabric
* Fixed typo in verbose log message.
* Added Tag support for managed cluster create and update

Az.Sql
* Added ''GeoZone'' option to ''BackupStorageRedundancy'' parameter to ''New-AzSqlDatabase'', ''Set-AzSqlDatabase'', ''New-AzSqlDatabaseCopy'', ''New-AzSqlDatabaseSecondary'', and ''Restore-AzSqlDatabase'' to enable create, update, copy, geo secondary and PITR support for GeoZone hyperscale databases
* Added additional input validation to ''Stop-AzSqlInstanceDatabaseLogReplay'' cmdlet to ensure the target database was created by log replay service
* Bug fix for cmdlet ''Restore-AzSqlDatabase''. The optional property ''Tags'' was not working as expected
* Added isManagedIdentityInUse get parameter for ''Get-AzSqlServerAudit'' and ''Get-AzSqlDatabaseAudit''
* Added new cmdlet ''Set-AzSqlInstanceDatabase''

Az.StackHCI
* Added support to Stack HCI Cluster
* Added support to Stack HCI Extension
* Added support to Stack HCI Arc Settings

Az.Storage
* Supported BaseBlob DaysAfterCreationGreaterThan in Management Policy
    -  ''Add-AzStorageAccountManagementPolicyAction''
'

        # Prerelease string of this module
        # Prerelease = ''

        # Flag to indicate whether the module requires explicit user acceptance for install/update/save
        # RequireLicenseAcceptance = $false

        # External dependent modules of this module
        # ExternalModuleDependencies = @()

    } # End of PSData hashtable

 } # End of PrivateData hashtable

# HelpInfo URI of this module
# HelpInfoURI = ''

# Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
# DefaultCommandPrefix = ''

}

