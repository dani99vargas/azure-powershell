// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class BackupResourceEncryptionConfig
    {
        /// <summary>
        /// Initializes a new instance of the BackupResourceEncryptionConfig
        /// class.
        /// </summary>
        public BackupResourceEncryptionConfig()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BackupResourceEncryptionConfig
        /// class.
        /// </summary>
        /// <param name="encryptionAtRestType">Encryption At Rest Type.
        /// Possible values include: 'Invalid', 'MicrosoftManaged',
        /// 'CustomerManaged'</param>
        /// <param name="keyUri">Key Vault Key URI</param>
        /// <param name="subscriptionId">Key Vault Subscription Id</param>
        /// <param name="lastUpdateStatus">Possible values include: 'Invalid',
        /// 'NotEnabled', 'PartiallySucceeded', 'PartiallyFailed', 'Failed',
        /// 'Succeeded', 'Initialized', 'FirstInitialization'</param>
        /// <param name="infrastructureEncryptionState">Possible values
        /// include: 'Invalid', 'Disabled', 'Enabled'</param>
        public BackupResourceEncryptionConfig(string encryptionAtRestType = default(string), string keyUri = default(string), string subscriptionId = default(string), string lastUpdateStatus = default(string), string infrastructureEncryptionState = default(string))
        {
            EncryptionAtRestType = encryptionAtRestType;
            KeyUri = keyUri;
            SubscriptionId = subscriptionId;
            LastUpdateStatus = lastUpdateStatus;
            InfrastructureEncryptionState = infrastructureEncryptionState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets encryption At Rest Type. Possible values include:
        /// 'Invalid', 'MicrosoftManaged', 'CustomerManaged'
        /// </summary>
        [JsonProperty(PropertyName = "encryptionAtRestType")]
        public string EncryptionAtRestType { get; set; }

        /// <summary>
        /// Gets or sets key Vault Key URI
        /// </summary>
        [JsonProperty(PropertyName = "keyUri")]
        public string KeyUri { get; set; }

        /// <summary>
        /// Gets or sets key Vault Subscription Id
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionId")]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Invalid', 'NotEnabled',
        /// 'PartiallySucceeded', 'PartiallyFailed', 'Failed', 'Succeeded',
        /// 'Initialized', 'FirstInitialization'
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdateStatus")]
        public string LastUpdateStatus { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Invalid', 'Disabled',
        /// 'Enabled'
        /// </summary>
        [JsonProperty(PropertyName = "infrastructureEncryptionState")]
        public string InfrastructureEncryptionState { get; set; }

    }
}
