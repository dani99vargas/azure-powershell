// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Extensions;

    /// <summary>Container App registry information.</summary>
    public partial class RegistryInfo :
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IRegistryInfo,
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IRegistryInfoInternal
    {

        /// <summary>Backing field for <see cref="RegistryPassword" /> property.</summary>
        private string _registryPassword;

        /// <summary>registry secret.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public string RegistryPassword { get => this._registryPassword; set => this._registryPassword = value; }

        /// <summary>Backing field for <see cref="RegistryUrl" /> property.</summary>
        private string _registryUrl;

        /// <summary>registry server Url.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public string RegistryUrl { get => this._registryUrl; set => this._registryUrl = value; }

        /// <summary>Backing field for <see cref="RegistryUserName" /> property.</summary>
        private string _registryUserName;

        /// <summary>registry username.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public string RegistryUserName { get => this._registryUserName; set => this._registryUserName = value; }

        /// <summary>Creates an new <see cref="RegistryInfo" /> instance.</summary>
        public RegistryInfo()
        {

        }
    }
    /// Container App registry information.
    public partial interface IRegistryInfo :
        Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.IJsonSerializable
    {
        /// <summary>registry secret.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"registry secret.",
        SerializedName = @"registryPassword",
        PossibleTypes = new [] { typeof(string) })]
        string RegistryPassword { get; set; }
        /// <summary>registry server Url.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"registry server Url.",
        SerializedName = @"registryUrl",
        PossibleTypes = new [] { typeof(string) })]
        string RegistryUrl { get; set; }
        /// <summary>registry username.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"registry username.",
        SerializedName = @"registryUserName",
        PossibleTypes = new [] { typeof(string) })]
        string RegistryUserName { get; set; }

    }
    /// Container App registry information.
    internal partial interface IRegistryInfoInternal

    {
        /// <summary>registry secret.</summary>
        string RegistryPassword { get; set; }
        /// <summary>registry server Url.</summary>
        string RegistryUrl { get; set; }
        /// <summary>registry username.</summary>
        string RegistryUserName { get; set; }

    }
}