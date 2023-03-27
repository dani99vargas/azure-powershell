// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Extensions;

    /// <summary>Set disk storage settings for SQL Server.</summary>
    public partial class SqlStorageSettings :
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlStorageSettings,
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlStorageSettingsInternal
    {

        /// <summary>Backing field for <see cref="DefaultFilePath" /> property.</summary>
        private string _defaultFilePath;

        /// <summary>SQL Server default file path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Owned)]
        public string DefaultFilePath { get => this._defaultFilePath; set => this._defaultFilePath = value; }

        /// <summary>Backing field for <see cref="Lun" /> property.</summary>
        private int[] _lun;

        /// <summary>Logical Unit Numbers for the disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Owned)]
        public int[] Lun { get => this._lun; set => this._lun = value; }

        /// <summary>Creates an new <see cref="SqlStorageSettings" /> instance.</summary>
        public SqlStorageSettings()
        {

        }
    }
    /// Set disk storage settings for SQL Server.
    public partial interface ISqlStorageSettings :
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.IJsonSerializable
    {
        /// <summary>SQL Server default file path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"SQL Server default file path",
        SerializedName = @"defaultFilePath",
        PossibleTypes = new [] { typeof(string) })]
        string DefaultFilePath { get; set; }
        /// <summary>Logical Unit Numbers for the disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Logical Unit Numbers for the disks.",
        SerializedName = @"luns",
        PossibleTypes = new [] { typeof(int) })]
        int[] Lun { get; set; }

    }
    /// Set disk storage settings for SQL Server.
    internal partial interface ISqlStorageSettingsInternal

    {
        /// <summary>SQL Server default file path</summary>
        string DefaultFilePath { get; set; }
        /// <summary>Logical Unit Numbers for the disks.</summary>
        int[] Lun { get; set; }

    }
}