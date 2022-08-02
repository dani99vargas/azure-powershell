// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.PowerShell;

    /// <summary>InMageRcm NIC details.</summary>
    [System.ComponentModel.TypeConverter(typeof(InMageRcmNicDetailsTypeConverter))]
    public partial class InMageRcmNicDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmNicDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new InMageRcmNicDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmNicDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetails" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new InMageRcmNicDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="InMageRcmNicDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="InMageRcmNicDetails" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmNicDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal InMageRcmNicDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("NicId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).NicId = (string) content.GetValueForProperty("NicId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).NicId, global::System.Convert.ToString);
            }
            if (content.Contains("IsPrimaryNic"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).IsPrimaryNic = (string) content.GetValueForProperty("IsPrimaryNic",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).IsPrimaryNic, global::System.Convert.ToString);
            }
            if (content.Contains("IsSelectedForFailover"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).IsSelectedForFailover = (string) content.GetValueForProperty("IsSelectedForFailover",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).IsSelectedForFailover, global::System.Convert.ToString);
            }
            if (content.Contains("SourceIPAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).SourceIPAddress = (string) content.GetValueForProperty("SourceIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).SourceIPAddress, global::System.Convert.ToString);
            }
            if (content.Contains("SourceIPAddressType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).SourceIPAddressType = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.EthernetAddressType?) content.GetValueForProperty("SourceIPAddressType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).SourceIPAddressType, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.EthernetAddressType.CreateFrom);
            }
            if (content.Contains("SourceNetworkId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).SourceNetworkId = (string) content.GetValueForProperty("SourceNetworkId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).SourceNetworkId, global::System.Convert.ToString);
            }
            if (content.Contains("SourceSubnetName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).SourceSubnetName = (string) content.GetValueForProperty("SourceSubnetName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).SourceSubnetName, global::System.Convert.ToString);
            }
            if (content.Contains("TargetIPAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).TargetIPAddress = (string) content.GetValueForProperty("TargetIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).TargetIPAddress, global::System.Convert.ToString);
            }
            if (content.Contains("TargetIPAddressType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).TargetIPAddressType = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.EthernetAddressType?) content.GetValueForProperty("TargetIPAddressType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).TargetIPAddressType, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.EthernetAddressType.CreateFrom);
            }
            if (content.Contains("TargetSubnetName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).TargetSubnetName = (string) content.GetValueForProperty("TargetSubnetName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).TargetSubnetName, global::System.Convert.ToString);
            }
            if (content.Contains("TestSubnetName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).TestSubnetName = (string) content.GetValueForProperty("TestSubnetName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).TestSubnetName, global::System.Convert.ToString);
            }
            if (content.Contains("TestIPAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).TestIPAddress = (string) content.GetValueForProperty("TestIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).TestIPAddress, global::System.Convert.ToString);
            }
            if (content.Contains("TestIPAddressType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).TestIPAddressType = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.EthernetAddressType?) content.GetValueForProperty("TestIPAddressType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).TestIPAddressType, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.EthernetAddressType.CreateFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.InMageRcmNicDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal InMageRcmNicDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("NicId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).NicId = (string) content.GetValueForProperty("NicId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).NicId, global::System.Convert.ToString);
            }
            if (content.Contains("IsPrimaryNic"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).IsPrimaryNic = (string) content.GetValueForProperty("IsPrimaryNic",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).IsPrimaryNic, global::System.Convert.ToString);
            }
            if (content.Contains("IsSelectedForFailover"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).IsSelectedForFailover = (string) content.GetValueForProperty("IsSelectedForFailover",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).IsSelectedForFailover, global::System.Convert.ToString);
            }
            if (content.Contains("SourceIPAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).SourceIPAddress = (string) content.GetValueForProperty("SourceIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).SourceIPAddress, global::System.Convert.ToString);
            }
            if (content.Contains("SourceIPAddressType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).SourceIPAddressType = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.EthernetAddressType?) content.GetValueForProperty("SourceIPAddressType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).SourceIPAddressType, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.EthernetAddressType.CreateFrom);
            }
            if (content.Contains("SourceNetworkId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).SourceNetworkId = (string) content.GetValueForProperty("SourceNetworkId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).SourceNetworkId, global::System.Convert.ToString);
            }
            if (content.Contains("SourceSubnetName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).SourceSubnetName = (string) content.GetValueForProperty("SourceSubnetName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).SourceSubnetName, global::System.Convert.ToString);
            }
            if (content.Contains("TargetIPAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).TargetIPAddress = (string) content.GetValueForProperty("TargetIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).TargetIPAddress, global::System.Convert.ToString);
            }
            if (content.Contains("TargetIPAddressType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).TargetIPAddressType = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.EthernetAddressType?) content.GetValueForProperty("TargetIPAddressType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).TargetIPAddressType, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.EthernetAddressType.CreateFrom);
            }
            if (content.Contains("TargetSubnetName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).TargetSubnetName = (string) content.GetValueForProperty("TargetSubnetName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).TargetSubnetName, global::System.Convert.ToString);
            }
            if (content.Contains("TestSubnetName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).TestSubnetName = (string) content.GetValueForProperty("TestSubnetName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).TestSubnetName, global::System.Convert.ToString);
            }
            if (content.Contains("TestIPAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).TestIPAddress = (string) content.GetValueForProperty("TestIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).TestIPAddress, global::System.Convert.ToString);
            }
            if (content.Contains("TestIPAddressType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).TestIPAddressType = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.EthernetAddressType?) content.GetValueForProperty("TestIPAddressType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageRcmNicDetailsInternal)this).TestIPAddressType, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.EthernetAddressType.CreateFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// InMageRcm NIC details.
    [System.ComponentModel.TypeConverter(typeof(InMageRcmNicDetailsTypeConverter))]
    public partial interface IInMageRcmNicDetails

    {

    }
}