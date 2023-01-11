// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Helpers.Resources.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// List of resource types of a resource provider.
    /// </summary>
    public partial class ProviderResourceTypeListResult
    {
        /// <summary>
        /// Initializes a new instance of the ProviderResourceTypeListResult
        /// class.
        /// </summary>
        public ProviderResourceTypeListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProviderResourceTypeListResult
        /// class.
        /// </summary>
        /// <param name="value">An array of resource types.</param>
        /// <param name="nextLink">The URL to use for getting the next set of
        /// results.</param>
        public ProviderResourceTypeListResult(IList<ProviderResourceType> value = default(IList<ProviderResourceType>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an array of resource types.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<ProviderResourceType> Value { get; set; }

        /// <summary>
        /// Gets the URL to use for getting the next set of results.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; private set; }

    }
}
