// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501
{
    using Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.PowerShell;

    /// <summary>Base definition for a job.</summary>
    [System.ComponentModel.TypeConverter(typeof(JobBasePropertiesTypeConverter))]
    public partial class JobBaseProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.JobBaseProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBaseProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBaseProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new JobBaseProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.JobBaseProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBaseProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBaseProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new JobBaseProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="JobBaseProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="JobBaseProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBaseProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.JobBaseProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal JobBaseProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Identity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IIdentityConfiguration) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IdentityConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("ComputeId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)this).ComputeId = (string) content.GetValueForProperty("ComputeId",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)this).ComputeId, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("ExperimentName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)this).ExperimentName = (string) content.GetValueForProperty("ExperimentName",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)this).ExperimentName, global::System.Convert.ToString);
            }
            if (content.Contains("IsArchived"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)this).IsArchived = (bool?) content.GetValueForProperty("IsArchived",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)this).IsArchived, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("JobType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)this).JobType = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobType) content.GetValueForProperty("JobType",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)this).JobType, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobType.CreateFrom);
            }
            if (content.Contains("Service"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)this).Service = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBaseServices) content.GetValueForProperty("Service",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)this).Service, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.JobBaseServicesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobStatus?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobStatus.CreateFrom);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ResourceBasePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ResourceBaseTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)this).IdentityType = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.IdentityConfigurationType) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)this).IdentityType, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.IdentityConfigurationType.CreateFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.JobBaseProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal JobBaseProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Identity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IIdentityConfiguration) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IdentityConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("ComputeId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)this).ComputeId = (string) content.GetValueForProperty("ComputeId",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)this).ComputeId, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("ExperimentName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)this).ExperimentName = (string) content.GetValueForProperty("ExperimentName",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)this).ExperimentName, global::System.Convert.ToString);
            }
            if (content.Contains("IsArchived"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)this).IsArchived = (bool?) content.GetValueForProperty("IsArchived",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)this).IsArchived, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("JobType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)this).JobType = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobType) content.GetValueForProperty("JobType",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)this).JobType, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobType.CreateFrom);
            }
            if (content.Contains("Service"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)this).Service = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBaseServices) content.GetValueForProperty("Service",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)this).Service, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.JobBaseServicesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobStatus?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobStatus.CreateFrom);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ResourceBasePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IResourceBaseInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ResourceBaseTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)this).IdentityType = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.IdentityConfigurationType) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobBasePropertiesInternal)this).IdentityType, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.IdentityConfigurationType.CreateFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Base definition for a job.
    [System.ComponentModel.TypeConverter(typeof(JobBasePropertiesTypeConverter))]
    public partial interface IJobBaseProperties

    {

    }
}