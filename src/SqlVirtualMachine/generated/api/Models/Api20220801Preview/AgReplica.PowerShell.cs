// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.PowerShell;

    /// <summary>Availability group replica configuration.</summary>
    [System.ComponentModel.TypeConverter(typeof(AgReplicaTypeConverter))]
    public partial class AgReplica
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.AgReplica"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AgReplica(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("SqlVirtualMachineInstanceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAgReplicaInternal)this).SqlVirtualMachineInstanceId = (string) content.GetValueForProperty("SqlVirtualMachineInstanceId",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAgReplicaInternal)this).SqlVirtualMachineInstanceId, global::System.Convert.ToString);
            }
            if (content.Contains("Role"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAgReplicaInternal)this).Role = (Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.Role?) content.GetValueForProperty("Role",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAgReplicaInternal)this).Role, Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.Role.CreateFrom);
            }
            if (content.Contains("Commit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAgReplicaInternal)this).Commit = (Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.Commit?) content.GetValueForProperty("Commit",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAgReplicaInternal)this).Commit, Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.Commit.CreateFrom);
            }
            if (content.Contains("Failover"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAgReplicaInternal)this).Failover = (Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.Failover?) content.GetValueForProperty("Failover",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAgReplicaInternal)this).Failover, Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.Failover.CreateFrom);
            }
            if (content.Contains("ReadableSecondary"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAgReplicaInternal)this).ReadableSecondary = (Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.ReadableSecondary?) content.GetValueForProperty("ReadableSecondary",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAgReplicaInternal)this).ReadableSecondary, Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.ReadableSecondary.CreateFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.AgReplica"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AgReplica(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("SqlVirtualMachineInstanceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAgReplicaInternal)this).SqlVirtualMachineInstanceId = (string) content.GetValueForProperty("SqlVirtualMachineInstanceId",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAgReplicaInternal)this).SqlVirtualMachineInstanceId, global::System.Convert.ToString);
            }
            if (content.Contains("Role"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAgReplicaInternal)this).Role = (Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.Role?) content.GetValueForProperty("Role",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAgReplicaInternal)this).Role, Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.Role.CreateFrom);
            }
            if (content.Contains("Commit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAgReplicaInternal)this).Commit = (Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.Commit?) content.GetValueForProperty("Commit",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAgReplicaInternal)this).Commit, Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.Commit.CreateFrom);
            }
            if (content.Contains("Failover"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAgReplicaInternal)this).Failover = (Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.Failover?) content.GetValueForProperty("Failover",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAgReplicaInternal)this).Failover, Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.Failover.CreateFrom);
            }
            if (content.Contains("ReadableSecondary"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAgReplicaInternal)this).ReadableSecondary = (Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.ReadableSecondary?) content.GetValueForProperty("ReadableSecondary",((Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAgReplicaInternal)this).ReadableSecondary, Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Support.ReadableSecondary.CreateFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.AgReplica"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAgReplica" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAgReplica DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AgReplica(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.AgReplica"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAgReplica" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAgReplica DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AgReplica(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AgReplica" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="AgReplica" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAgReplica FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Json.JsonNode.Parse(jsonText));

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
    /// Availability group replica configuration.
    [System.ComponentModel.TypeConverter(typeof(AgReplicaTypeConverter))]
    public partial interface IAgReplica

    {

    }
}