// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.PowerShell;

    /// <summary>The properties of an availability group listener.</summary>
    [System.ComponentModel.TypeConverter(typeof(AvailabilityGroupListenerPropertiesTypeConverter))]
    public partial class AvailabilityGroupListenerProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.AvailabilityGroupListenerProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AvailabilityGroupListenerProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("AvailabilityGroupConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAvailabilityGroupListenerPropertiesInternal)this).AvailabilityGroupConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAgConfiguration) content.GetValueForProperty("AvailabilityGroupConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAvailabilityGroupListenerPropertiesInternal)this).AvailabilityGroupConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.AgConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAvailabilityGroupListenerPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAvailabilityGroupListenerPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("AvailabilityGroupName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAvailabilityGroupListenerPropertiesInternal)this).AvailabilityGroupName = (string) content.GetValueForProperty("AvailabilityGroupName",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAvailabilityGroupListenerPropertiesInternal)this).AvailabilityGroupName, global::System.Convert.ToString);
            }
            if (content.Contains("LoadBalancerConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAvailabilityGroupListenerPropertiesInternal)this).LoadBalancerConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ILoadBalancerConfiguration[]) content.GetValueForProperty("LoadBalancerConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAvailabilityGroupListenerPropertiesInternal)this).LoadBalancerConfiguration, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ILoadBalancerConfiguration>(__y, Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.LoadBalancerConfigurationTypeConverter.ConvertFrom));
            }
            if (content.Contains("MultiSubnetIPConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAvailabilityGroupListenerPropertiesInternal)this).MultiSubnetIPConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IMultiSubnetIPConfiguration[]) content.GetValueForProperty("MultiSubnetIPConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAvailabilityGroupListenerPropertiesInternal)this).MultiSubnetIPConfiguration, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IMultiSubnetIPConfiguration>(__y, Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.MultiSubnetIPConfigurationTypeConverter.ConvertFrom));
            }
            if (content.Contains("CreateDefaultAvailabilityGroupIfNotExist"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAvailabilityGroupListenerPropertiesInternal)this).CreateDefaultAvailabilityGroupIfNotExist = (bool?) content.GetValueForProperty("CreateDefaultAvailabilityGroupIfNotExist",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAvailabilityGroupListenerPropertiesInternal)this).CreateDefaultAvailabilityGroupIfNotExist, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("Port"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAvailabilityGroupListenerPropertiesInternal)this).Port = (int?) content.GetValueForProperty("Port",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAvailabilityGroupListenerPropertiesInternal)this).Port, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("AvailabilityGroupConfigurationReplica"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAvailabilityGroupListenerPropertiesInternal)this).AvailabilityGroupConfigurationReplica = (Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAgReplica[]) content.GetValueForProperty("AvailabilityGroupConfigurationReplica",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAvailabilityGroupListenerPropertiesInternal)this).AvailabilityGroupConfigurationReplica, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAgReplica>(__y, Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.AgReplicaTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.AvailabilityGroupListenerProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AvailabilityGroupListenerProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("AvailabilityGroupConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAvailabilityGroupListenerPropertiesInternal)this).AvailabilityGroupConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAgConfiguration) content.GetValueForProperty("AvailabilityGroupConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAvailabilityGroupListenerPropertiesInternal)this).AvailabilityGroupConfiguration, Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.AgConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAvailabilityGroupListenerPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAvailabilityGroupListenerPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("AvailabilityGroupName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAvailabilityGroupListenerPropertiesInternal)this).AvailabilityGroupName = (string) content.GetValueForProperty("AvailabilityGroupName",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAvailabilityGroupListenerPropertiesInternal)this).AvailabilityGroupName, global::System.Convert.ToString);
            }
            if (content.Contains("LoadBalancerConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAvailabilityGroupListenerPropertiesInternal)this).LoadBalancerConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ILoadBalancerConfiguration[]) content.GetValueForProperty("LoadBalancerConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAvailabilityGroupListenerPropertiesInternal)this).LoadBalancerConfiguration, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ILoadBalancerConfiguration>(__y, Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.LoadBalancerConfigurationTypeConverter.ConvertFrom));
            }
            if (content.Contains("MultiSubnetIPConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAvailabilityGroupListenerPropertiesInternal)this).MultiSubnetIPConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IMultiSubnetIPConfiguration[]) content.GetValueForProperty("MultiSubnetIPConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAvailabilityGroupListenerPropertiesInternal)this).MultiSubnetIPConfiguration, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IMultiSubnetIPConfiguration>(__y, Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.MultiSubnetIPConfigurationTypeConverter.ConvertFrom));
            }
            if (content.Contains("CreateDefaultAvailabilityGroupIfNotExist"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAvailabilityGroupListenerPropertiesInternal)this).CreateDefaultAvailabilityGroupIfNotExist = (bool?) content.GetValueForProperty("CreateDefaultAvailabilityGroupIfNotExist",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAvailabilityGroupListenerPropertiesInternal)this).CreateDefaultAvailabilityGroupIfNotExist, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("Port"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAvailabilityGroupListenerPropertiesInternal)this).Port = (int?) content.GetValueForProperty("Port",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAvailabilityGroupListenerPropertiesInternal)this).Port, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("AvailabilityGroupConfigurationReplica"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAvailabilityGroupListenerPropertiesInternal)this).AvailabilityGroupConfigurationReplica = (Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAgReplica[]) content.GetValueForProperty("AvailabilityGroupConfigurationReplica",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAvailabilityGroupListenerPropertiesInternal)this).AvailabilityGroupConfigurationReplica, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAgReplica>(__y, Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.AgReplicaTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.AvailabilityGroupListenerProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAvailabilityGroupListenerProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAvailabilityGroupListenerProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AvailabilityGroupListenerProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.AvailabilityGroupListenerProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAvailabilityGroupListenerProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAvailabilityGroupListenerProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AvailabilityGroupListenerProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AvailabilityGroupListenerProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="AvailabilityGroupListenerProperties" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAvailabilityGroupListenerProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// The properties of an availability group listener.
    [System.ComponentModel.TypeConverter(typeof(AvailabilityGroupListenerPropertiesTypeConverter))]
    public partial interface IAvailabilityGroupListenerProperties

    {

    }
}