// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Extensions;

    /// <summary>The Activity query definitions</summary>
    public partial class ActivityEntityQueryTemplatePropertiesQueryDefinitions :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IActivityEntityQueryTemplatePropertiesQueryDefinitions,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IActivityEntityQueryTemplatePropertiesQueryDefinitionsInternal
    {

        /// <summary>Backing field for <see cref="Query" /> property.</summary>
        private string _query;

        /// <summary>The Activity query to run on a given entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string Query { get => this._query; set => this._query = value; }

        /// <summary>Backing field for <see cref="SummarizeBy" /> property.</summary>
        private string _summarizeBy;

        /// <summary>
        /// The dimensions we want to summarize the timeline results on, this is comma separated list
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string SummarizeBy { get => this._summarizeBy; set => this._summarizeBy = value; }

        /// <summary>
        /// Creates an new <see cref="ActivityEntityQueryTemplatePropertiesQueryDefinitions" /> instance.
        /// </summary>
        public ActivityEntityQueryTemplatePropertiesQueryDefinitions()
        {

        }
    }
    /// The Activity query definitions
    public partial interface IActivityEntityQueryTemplatePropertiesQueryDefinitions :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IJsonSerializable
    {
        /// <summary>The Activity query to run on a given entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Activity query to run on a given entity",
        SerializedName = @"query",
        PossibleTypes = new [] { typeof(string) })]
        string Query { get; set; }
        /// <summary>
        /// The dimensions we want to summarize the timeline results on, this is comma separated list
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The dimensions we want to summarize the timeline results on, this is comma separated list",
        SerializedName = @"summarizeBy",
        PossibleTypes = new [] { typeof(string) })]
        string SummarizeBy { get; set; }

    }
    /// The Activity query definitions
    internal partial interface IActivityEntityQueryTemplatePropertiesQueryDefinitionsInternal

    {
        /// <summary>The Activity query to run on a given entity</summary>
        string Query { get; set; }
        /// <summary>
        /// The dimensions we want to summarize the timeline results on, this is comma separated list
        /// </summary>
        string SummarizeBy { get; set; }

    }
}