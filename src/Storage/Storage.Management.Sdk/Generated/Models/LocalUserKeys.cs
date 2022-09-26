// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The Storage Account Local User keys.
    /// </summary>
    public partial class LocalUserKeys
    {
        /// <summary>
        /// Initializes a new instance of the LocalUserKeys class.
        /// </summary>
        public LocalUserKeys()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LocalUserKeys class.
        /// </summary>
        public LocalUserKeys(IList<SshPublicKey> sshAuthorizedKeys = default(IList<SshPublicKey>), string sharedKey = default(string))
        {
            SshAuthorizedKeys = sshAuthorizedKeys;
            SharedKey = sharedKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sshAuthorizedKeys")]
        public IList<SshPublicKey> SshAuthorizedKeys { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sharedKey")]
        public string SharedKey { get; set; }

    }
}
