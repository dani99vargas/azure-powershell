// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Extensions;

    /// <summary>Set the server/instance-level settings for SQL Server.</summary>
    public partial class SqlInstanceSettings :
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlInstanceSettings,
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlInstanceSettingsInternal
    {

        /// <summary>Backing field for <see cref="Collation" /> property.</summary>
        private string _collation;

        /// <summary>SQL Server Collation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Owned)]
        public string Collation { get => this._collation; set => this._collation = value; }

        /// <summary>Backing field for <see cref="IsIfiEnabled" /> property.</summary>
        private bool? _isIfiEnabled;

        /// <summary>SQL Server IFI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Owned)]
        public bool? IsIfiEnabled { get => this._isIfiEnabled; set => this._isIfiEnabled = value; }

        /// <summary>Backing field for <see cref="IsLpimEnabled" /> property.</summary>
        private bool? _isLpimEnabled;

        /// <summary>SQL Server LPIM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Owned)]
        public bool? IsLpimEnabled { get => this._isLpimEnabled; set => this._isLpimEnabled = value; }

        /// <summary>Backing field for <see cref="IsOptimizeForAdHocWorkloadsEnabled" /> property.</summary>
        private bool? _isOptimizeForAdHocWorkloadsEnabled;

        /// <summary>SQL Server Optimize for Adhoc workloads.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Owned)]
        public bool? IsOptimizeForAdHocWorkloadsEnabled { get => this._isOptimizeForAdHocWorkloadsEnabled; set => this._isOptimizeForAdHocWorkloadsEnabled = value; }

        /// <summary>Backing field for <see cref="MaxDop" /> property.</summary>
        private int? _maxDop;

        /// <summary>SQL Server MAXDOP.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Owned)]
        public int? MaxDop { get => this._maxDop; set => this._maxDop = value; }

        /// <summary>Backing field for <see cref="MaxServerMemoryMb" /> property.</summary>
        private int? _maxServerMemoryMb;

        /// <summary>SQL Server maximum memory.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Owned)]
        public int? MaxServerMemoryMb { get => this._maxServerMemoryMb; set => this._maxServerMemoryMb = value; }

        /// <summary>Backing field for <see cref="MinServerMemoryMb" /> property.</summary>
        private int? _minServerMemoryMb;

        /// <summary>SQL Server minimum memory.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Owned)]
        public int? MinServerMemoryMb { get => this._minServerMemoryMb; set => this._minServerMemoryMb = value; }

        /// <summary>Creates an new <see cref="SqlInstanceSettings" /> instance.</summary>
        public SqlInstanceSettings()
        {

        }
    }
    /// Set the server/instance-level settings for SQL Server.
    public partial interface ISqlInstanceSettings :
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.IJsonSerializable
    {
        /// <summary>SQL Server Collation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"SQL Server Collation.",
        SerializedName = @"collation",
        PossibleTypes = new [] { typeof(string) })]
        string Collation { get; set; }
        /// <summary>SQL Server IFI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"SQL Server IFI.",
        SerializedName = @"isIfiEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsIfiEnabled { get; set; }
        /// <summary>SQL Server LPIM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"SQL Server LPIM.",
        SerializedName = @"isLpimEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsLpimEnabled { get; set; }
        /// <summary>SQL Server Optimize for Adhoc workloads.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"SQL Server Optimize for Adhoc workloads.",
        SerializedName = @"isOptimizeForAdHocWorkloadsEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsOptimizeForAdHocWorkloadsEnabled { get; set; }
        /// <summary>SQL Server MAXDOP.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"SQL Server MAXDOP.",
        SerializedName = @"maxDop",
        PossibleTypes = new [] { typeof(int) })]
        int? MaxDop { get; set; }
        /// <summary>SQL Server maximum memory.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"SQL Server maximum memory.",
        SerializedName = @"maxServerMemoryMB",
        PossibleTypes = new [] { typeof(int) })]
        int? MaxServerMemoryMb { get; set; }
        /// <summary>SQL Server minimum memory.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"SQL Server minimum memory.",
        SerializedName = @"minServerMemoryMB",
        PossibleTypes = new [] { typeof(int) })]
        int? MinServerMemoryMb { get; set; }

    }
    /// Set the server/instance-level settings for SQL Server.
    internal partial interface ISqlInstanceSettingsInternal

    {
        /// <summary>SQL Server Collation.</summary>
        string Collation { get; set; }
        /// <summary>SQL Server IFI.</summary>
        bool? IsIfiEnabled { get; set; }
        /// <summary>SQL Server LPIM.</summary>
        bool? IsLpimEnabled { get; set; }
        /// <summary>SQL Server Optimize for Adhoc workloads.</summary>
        bool? IsOptimizeForAdHocWorkloadsEnabled { get; set; }
        /// <summary>SQL Server MAXDOP.</summary>
        int? MaxDop { get; set; }
        /// <summary>SQL Server maximum memory.</summary>
        int? MaxServerMemoryMb { get; set; }
        /// <summary>SQL Server minimum memory.</summary>
        int? MinServerMemoryMb { get; set; }

    }
}