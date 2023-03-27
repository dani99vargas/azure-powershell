// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Extensions;

    /// <summary>Availability group configuration.</summary>
    public partial class AgConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAgConfiguration,
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAgConfigurationInternal
    {

        /// <summary>Backing field for <see cref="Replica" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAgReplica[] _replica;

        /// <summary>Replica configurations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAgReplica[] Replica { get => this._replica; set => this._replica = value; }

        /// <summary>Creates an new <see cref="AgConfiguration" /> instance.</summary>
        public AgConfiguration()
        {

        }
    }
    /// Availability group configuration.
    public partial interface IAgConfiguration :
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.IJsonSerializable
    {
        /// <summary>Replica configurations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Replica configurations.",
        SerializedName = @"replicas",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAgReplica) })]
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAgReplica[] Replica { get; set; }

    }
    /// Availability group configuration.
    internal partial interface IAgConfigurationInternal

    {
        /// <summary>Replica configurations.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.IAgReplica[] Replica { get; set; }

    }
}