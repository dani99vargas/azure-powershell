// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for SqlContainerRedistributeThroughput operation.
    /// </summary>
    public partial class SqlResourcesSqlContainerRedistributeThroughputHeaders
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SqlResourcesSqlContainerRedistributeThroughputHeaders class.
        /// </summary>
        public SqlResourcesSqlContainerRedistributeThroughputHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SqlResourcesSqlContainerRedistributeThroughputHeaders class.
        /// </summary>
        /// <param name="azureAsyncOperation">URI to poll for completion
        /// status.</param>
        /// <param name="location">URI to poll for completion status.</param>
        public SqlResourcesSqlContainerRedistributeThroughputHeaders(string azureAsyncOperation = default(string), string location = default(string))
        {
            AzureAsyncOperation = azureAsyncOperation;
            Location = location;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets URI to poll for completion status.
        /// </summary>
        [JsonProperty(PropertyName = "azure-AsyncOperation")]
        public string AzureAsyncOperation { get; set; }

        /// <summary>
        /// Gets or sets URI to poll for completion status.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

    }
}
