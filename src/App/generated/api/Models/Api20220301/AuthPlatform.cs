// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Extensions;

    /// <summary>
    /// The configuration settings of the platform of ContainerApp Service Authentication/Authorization.
    /// </summary>
    public partial class AuthPlatform :
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthPlatform,
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.Api20220301.IAuthPlatformInternal
    {

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private bool? _enabled;

        /// <summary>
        /// <code>true</code> if the Authentication / Authorization feature is enabled for the current app; otherwise, <code>false</code>.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public bool? Enabled { get => this._enabled; set => this._enabled = value; }

        /// <summary>Backing field for <see cref="RuntimeVersion" /> property.</summary>
        private string _runtimeVersion;

        /// <summary>
        /// The RuntimeVersion of the Authentication / Authorization feature in use for the current app.
        /// The setting in this value can control the behavior of certain features in the Authentication / Authorization module.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public string RuntimeVersion { get => this._runtimeVersion; set => this._runtimeVersion = value; }

        /// <summary>Creates an new <see cref="AuthPlatform" /> instance.</summary>
        public AuthPlatform()
        {

        }
    }
    /// The configuration settings of the platform of ContainerApp Service Authentication/Authorization.
    public partial interface IAuthPlatform :
        Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.IJsonSerializable
    {
        /// <summary>
        /// <code>true</code> if the Authentication / Authorization feature is enabled for the current app; otherwise, <code>false</code>.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"<code>true</code> if the Authentication / Authorization feature is enabled for the current app; otherwise, <code>false</code>.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enabled { get; set; }
        /// <summary>
        /// The RuntimeVersion of the Authentication / Authorization feature in use for the current app.
        /// The setting in this value can control the behavior of certain features in the Authentication / Authorization module.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The RuntimeVersion of the Authentication / Authorization feature in use for the current app.
        The setting in this value can control the behavior of certain features in the Authentication / Authorization module.",
        SerializedName = @"runtimeVersion",
        PossibleTypes = new [] { typeof(string) })]
        string RuntimeVersion { get; set; }

    }
    /// The configuration settings of the platform of ContainerApp Service Authentication/Authorization.
    internal partial interface IAuthPlatformInternal

    {
        /// <summary>
        /// <code>true</code> if the Authentication / Authorization feature is enabled for the current app; otherwise, <code>false</code>.
        /// </summary>
        bool? Enabled { get; set; }
        /// <summary>
        /// The RuntimeVersion of the Authentication / Authorization feature in use for the current app.
        /// The setting in this value can control the behavior of certain features in the Authentication / Authorization module.
        /// </summary>
        string RuntimeVersion { get; set; }

    }
}