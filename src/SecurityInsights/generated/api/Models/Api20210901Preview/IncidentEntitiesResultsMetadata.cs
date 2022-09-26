// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Extensions;

    /// <summary>Information of a specific aggregation in the incident related entities result.</summary>
    public partial class IncidentEntitiesResultsMetadata :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIncidentEntitiesResultsMetadata,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IIncidentEntitiesResultsMetadataInternal
    {

        /// <summary>Backing field for <see cref="Count" /> property.</summary>
        private int _count;

        /// <summary>
        /// Total number of aggregations of the given kind in the incident related entities result.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public int Count { get => this._count; set => this._count = value; }

        /// <summary>Backing field for <see cref="EntityKind" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityKind _entityKind;

        /// <summary>The kind of the aggregated entity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityKind EntityKind { get => this._entityKind; set => this._entityKind = value; }

        /// <summary>Creates an new <see cref="IncidentEntitiesResultsMetadata" /> instance.</summary>
        public IncidentEntitiesResultsMetadata()
        {

        }
    }
    /// Information of a specific aggregation in the incident related entities result.
    public partial interface IIncidentEntitiesResultsMetadata :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Total number of aggregations of the given kind in the incident related entities result.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Total number of aggregations of the given kind in the incident related entities result.",
        SerializedName = @"count",
        PossibleTypes = new [] { typeof(int) })]
        int Count { get; set; }
        /// <summary>The kind of the aggregated entity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The kind of the aggregated entity.",
        SerializedName = @"entityKind",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityKind) })]
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityKind EntityKind { get; set; }

    }
    /// Information of a specific aggregation in the incident related entities result.
    internal partial interface IIncidentEntitiesResultsMetadataInternal

    {
        /// <summary>
        /// Total number of aggregations of the given kind in the incident related entities result.
        /// </summary>
        int Count { get; set; }
        /// <summary>The kind of the aggregated entity.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.EntityKind EntityKind { get; set; }

    }
}