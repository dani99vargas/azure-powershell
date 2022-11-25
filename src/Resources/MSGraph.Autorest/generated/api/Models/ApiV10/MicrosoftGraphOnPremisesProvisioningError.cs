// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Extensions;

    /// <summary>onPremisesProvisioningError</summary>
    public partial class MicrosoftGraphOnPremisesProvisioningError :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesProvisioningError,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphOnPremisesProvisioningErrorInternal
    {

        /// <summary>Backing field for <see cref="Category" /> property.</summary>
        private string _category;

        /// <summary>
        /// Category of the provisioning error. Note: Currently, there is only one possible value. Possible value: PropertyConflict
        /// - indicates a property value is not unique. Other objects contain the same value for the property.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string Category { get => this._category; set => this._category = value; }

        /// <summary>Backing field for <see cref="OccurredDateTime" /> property.</summary>
        private global::System.DateTime? _occurredDateTime;

        /// <summary>The date and time at which the error occurred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public global::System.DateTime? OccurredDateTime { get => this._occurredDateTime; set => this._occurredDateTime = value; }

        /// <summary>Backing field for <see cref="PropertyCausingError" /> property.</summary>
        private string _propertyCausingError;

        /// <summary>
        /// Name of the directory property causing the error. Current possible values: UserPrincipalName or ProxyAddress
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string PropertyCausingError { get => this._propertyCausingError; set => this._propertyCausingError = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private string _value;

        /// <summary>Value of the property causing the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public string Value { get => this._value; set => this._value = value; }

        /// <summary>
        /// Creates an new <see cref="MicrosoftGraphOnPremisesProvisioningError" /> instance.
        /// </summary>
        public MicrosoftGraphOnPremisesProvisioningError()
        {

        }
    }
    /// onPremisesProvisioningError
    public partial interface IMicrosoftGraphOnPremisesProvisioningError :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IAssociativeArray<global::System.Object>
    {
        /// <summary>
        /// Category of the provisioning error. Note: Currently, there is only one possible value. Possible value: PropertyConflict
        /// - indicates a property value is not unique. Other objects contain the same value for the property.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Category of the provisioning error. Note: Currently, there is only one possible value. Possible value: PropertyConflict - indicates a property value is not unique. Other objects contain the same value for the property.",
        SerializedName = @"category",
        PossibleTypes = new [] { typeof(string) })]
        string Category { get; set; }
        /// <summary>The date and time at which the error occurred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The date and time at which the error occurred.",
        SerializedName = @"occurredDateTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? OccurredDateTime { get; set; }
        /// <summary>
        /// Name of the directory property causing the error. Current possible values: UserPrincipalName or ProxyAddress
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the directory property causing the error. Current possible values: UserPrincipalName or ProxyAddress",
        SerializedName = @"propertyCausingError",
        PossibleTypes = new [] { typeof(string) })]
        string PropertyCausingError { get; set; }
        /// <summary>Value of the property causing the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Value of the property causing the error.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string Value { get; set; }

    }
    /// onPremisesProvisioningError
    internal partial interface IMicrosoftGraphOnPremisesProvisioningErrorInternal

    {
        /// <summary>
        /// Category of the provisioning error. Note: Currently, there is only one possible value. Possible value: PropertyConflict
        /// - indicates a property value is not unique. Other objects contain the same value for the property.
        /// </summary>
        string Category { get; set; }
        /// <summary>The date and time at which the error occurred.</summary>
        global::System.DateTime? OccurredDateTime { get; set; }
        /// <summary>
        /// Name of the directory property causing the error. Current possible values: UserPrincipalName or ProxyAddress
        /// </summary>
        string PropertyCausingError { get; set; }
        /// <summary>Value of the property causing the error.</summary>
        string Value { get; set; }

    }
}