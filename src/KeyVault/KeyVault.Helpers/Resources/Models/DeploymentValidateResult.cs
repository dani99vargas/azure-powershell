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
    using System.Linq;

    /// <summary>
    /// Information from validate template deployment response.
    /// </summary>
    public partial class DeploymentValidateResult
    {
        /// <summary>
        /// Initializes a new instance of the DeploymentValidateResult class.
        /// </summary>
        public DeploymentValidateResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeploymentValidateResult class.
        /// </summary>
        /// <param name="error">The deployment validation error.</param>
        /// <param name="properties">The template deployment
        /// properties.</param>
        public DeploymentValidateResult(ErrorResponse error = default(ErrorResponse), DeploymentPropertiesExtended properties = default(DeploymentPropertiesExtended))
        {
            Error = error;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the deployment validation error.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public ErrorResponse Error { get; private set; }

        /// <summary>
        /// Gets or sets the template deployment properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public DeploymentPropertiesExtended Properties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Properties != null)
            {
                Properties.Validate();
            }
        }
    }
}
