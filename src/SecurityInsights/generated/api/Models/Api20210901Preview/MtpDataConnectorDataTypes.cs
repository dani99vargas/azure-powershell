// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Extensions;

    /// <summary>
    /// The available data types for Microsoft Threat Protection Platforms data connector.
    /// </summary>
    public partial class MtpDataConnectorDataTypes :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMtpDataConnectorDataTypes,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMtpDataConnectorDataTypesInternal
    {

        /// <summary>Backing field for <see cref="Incident" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorDataTypeCommon _incident;

        /// <summary>Data type for Microsoft Threat Protection Platforms data connector.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorDataTypeCommon Incident { get => (this._incident = this._incident ?? new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.DataConnectorDataTypeCommon()); set => this._incident = value; }

        /// <summary>Describe whether this data type connection is enabled or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.DataTypeState IncidentState { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorDataTypeCommonInternal)Incident).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorDataTypeCommonInternal)Incident).State = value ; }

        /// <summary>Internal Acessors for Incident</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorDataTypeCommon Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMtpDataConnectorDataTypesInternal.Incident { get => (this._incident = this._incident ?? new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.DataConnectorDataTypeCommon()); set { {_incident = value;} } }

        /// <summary>Creates an new <see cref="MtpDataConnectorDataTypes" /> instance.</summary>
        public MtpDataConnectorDataTypes()
        {

        }
    }
    /// The available data types for Microsoft Threat Protection Platforms data connector.
    public partial interface IMtpDataConnectorDataTypes :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IJsonSerializable
    {
        /// <summary>Describe whether this data type connection is enabled or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Describe whether this data type connection is enabled or not.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.DataTypeState) })]
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.DataTypeState IncidentState { get; set; }

    }
    /// The available data types for Microsoft Threat Protection Platforms data connector.
    internal partial interface IMtpDataConnectorDataTypesInternal

    {
        /// <summary>Data type for Microsoft Threat Protection Platforms data connector.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IDataConnectorDataTypeCommon Incident { get; set; }
        /// <summary>Describe whether this data type connection is enabled or not.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.DataTypeState IncidentState { get; set; }

    }
}