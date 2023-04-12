// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201
{
    using Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.PowerShell;

    /// <summary>Security profile for the container service cluster.</summary>
    [System.ComponentModel.TypeConverter(typeof(ManagedClusterSecurityProfileTypeConverter))]
    public partial class ManagedClusterSecurityProfile
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterSecurityProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfile" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfile DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ManagedClusterSecurityProfile(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterSecurityProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfile" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfile DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ManagedClusterSecurityProfile(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ManagedClusterSecurityProfile" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ManagedClusterSecurityProfile" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfile FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterSecurityProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ManagedClusterSecurityProfile(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Defender"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).Defender = (Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileDefender) content.GetValueForProperty("Defender",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).Defender, Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterSecurityProfileDefenderTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureKeyVaultKm"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).AzureKeyVaultKm = (Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IAzureKeyVaultKms) content.GetValueForProperty("AzureKeyVaultKm",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).AzureKeyVaultKm, Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.AzureKeyVaultKmsTypeConverter.ConvertFrom);
            }
            if (content.Contains("WorkloadIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).WorkloadIdentity = (Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileWorkloadIdentity) content.GetValueForProperty("WorkloadIdentity",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).WorkloadIdentity, Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterSecurityProfileWorkloadIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("ImageCleaner"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).ImageCleaner = (Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileImageCleaner) content.GetValueForProperty("ImageCleaner",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).ImageCleaner, Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterSecurityProfileImageCleanerTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureKeyVaultKmKeyId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).AzureKeyVaultKmKeyId = (string) content.GetValueForProperty("AzureKeyVaultKmKeyId",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).AzureKeyVaultKmKeyId, global::System.Convert.ToString);
            }
            if (content.Contains("DefenderSecurityMonitoring"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).DefenderSecurityMonitoring = (Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileDefenderSecurityMonitoring) content.GetValueForProperty("DefenderSecurityMonitoring",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).DefenderSecurityMonitoring, Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterSecurityProfileDefenderSecurityMonitoringTypeConverter.ConvertFrom);
            }
            if (content.Contains("DefenderLogAnalyticsWorkspaceResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).DefenderLogAnalyticsWorkspaceResourceId = (string) content.GetValueForProperty("DefenderLogAnalyticsWorkspaceResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).DefenderLogAnalyticsWorkspaceResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("AzureKeyVaultKmEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).AzureKeyVaultKmEnabled = (bool?) content.GetValueForProperty("AzureKeyVaultKmEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).AzureKeyVaultKmEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AzureKeyVaultKmKeyVaultNetworkAccess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).AzureKeyVaultKmKeyVaultNetworkAccess = (Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.KeyVaultNetworkAccessTypes?) content.GetValueForProperty("AzureKeyVaultKmKeyVaultNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).AzureKeyVaultKmKeyVaultNetworkAccess, Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.KeyVaultNetworkAccessTypes.CreateFrom);
            }
            if (content.Contains("AzureKeyVaultKmKeyVaultResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).AzureKeyVaultKmKeyVaultResourceId = (string) content.GetValueForProperty("AzureKeyVaultKmKeyVaultResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).AzureKeyVaultKmKeyVaultResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("WorkloadIdentityEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).WorkloadIdentityEnabled = (bool?) content.GetValueForProperty("WorkloadIdentityEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).WorkloadIdentityEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ImageCleanerEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).ImageCleanerEnabled = (bool?) content.GetValueForProperty("ImageCleanerEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).ImageCleanerEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ImageCleanerIntervalHour"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).ImageCleanerIntervalHour = (int?) content.GetValueForProperty("ImageCleanerIntervalHour",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).ImageCleanerIntervalHour, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SecurityMonitoringEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).SecurityMonitoringEnabled = (bool?) content.GetValueForProperty("SecurityMonitoringEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).SecurityMonitoringEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterSecurityProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ManagedClusterSecurityProfile(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Defender"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).Defender = (Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileDefender) content.GetValueForProperty("Defender",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).Defender, Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterSecurityProfileDefenderTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureKeyVaultKm"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).AzureKeyVaultKm = (Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IAzureKeyVaultKms) content.GetValueForProperty("AzureKeyVaultKm",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).AzureKeyVaultKm, Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.AzureKeyVaultKmsTypeConverter.ConvertFrom);
            }
            if (content.Contains("WorkloadIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).WorkloadIdentity = (Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileWorkloadIdentity) content.GetValueForProperty("WorkloadIdentity",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).WorkloadIdentity, Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterSecurityProfileWorkloadIdentityTypeConverter.ConvertFrom);
            }
            if (content.Contains("ImageCleaner"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).ImageCleaner = (Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileImageCleaner) content.GetValueForProperty("ImageCleaner",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).ImageCleaner, Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterSecurityProfileImageCleanerTypeConverter.ConvertFrom);
            }
            if (content.Contains("AzureKeyVaultKmKeyId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).AzureKeyVaultKmKeyId = (string) content.GetValueForProperty("AzureKeyVaultKmKeyId",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).AzureKeyVaultKmKeyId, global::System.Convert.ToString);
            }
            if (content.Contains("DefenderSecurityMonitoring"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).DefenderSecurityMonitoring = (Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileDefenderSecurityMonitoring) content.GetValueForProperty("DefenderSecurityMonitoring",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).DefenderSecurityMonitoring, Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.ManagedClusterSecurityProfileDefenderSecurityMonitoringTypeConverter.ConvertFrom);
            }
            if (content.Contains("DefenderLogAnalyticsWorkspaceResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).DefenderLogAnalyticsWorkspaceResourceId = (string) content.GetValueForProperty("DefenderLogAnalyticsWorkspaceResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).DefenderLogAnalyticsWorkspaceResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("AzureKeyVaultKmEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).AzureKeyVaultKmEnabled = (bool?) content.GetValueForProperty("AzureKeyVaultKmEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).AzureKeyVaultKmEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("AzureKeyVaultKmKeyVaultNetworkAccess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).AzureKeyVaultKmKeyVaultNetworkAccess = (Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.KeyVaultNetworkAccessTypes?) content.GetValueForProperty("AzureKeyVaultKmKeyVaultNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).AzureKeyVaultKmKeyVaultNetworkAccess, Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.KeyVaultNetworkAccessTypes.CreateFrom);
            }
            if (content.Contains("AzureKeyVaultKmKeyVaultResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).AzureKeyVaultKmKeyVaultResourceId = (string) content.GetValueForProperty("AzureKeyVaultKmKeyVaultResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).AzureKeyVaultKmKeyVaultResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("WorkloadIdentityEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).WorkloadIdentityEnabled = (bool?) content.GetValueForProperty("WorkloadIdentityEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).WorkloadIdentityEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ImageCleanerEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).ImageCleanerEnabled = (bool?) content.GetValueForProperty("ImageCleanerEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).ImageCleanerEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ImageCleanerIntervalHour"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).ImageCleanerIntervalHour = (int?) content.GetValueForProperty("ImageCleanerIntervalHour",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).ImageCleanerIntervalHour, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("SecurityMonitoringEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).SecurityMonitoringEnabled = (bool?) content.GetValueForProperty("SecurityMonitoringEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.Api20230201.IManagedClusterSecurityProfileInternal)this).SecurityMonitoringEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Security profile for the container service cluster.
    [System.ComponentModel.TypeConverter(typeof(ManagedClusterSecurityProfileTypeConverter))]
    public partial interface IManagedClusterSecurityProfile

    {

    }
}