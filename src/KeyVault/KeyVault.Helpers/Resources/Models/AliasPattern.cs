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
    /// The type of the pattern for an alias path.
    /// </summary>
    public partial class AliasPattern
    {
        /// <summary>
        /// Initializes a new instance of the AliasPattern class.
        /// </summary>
        public AliasPattern()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AliasPattern class.
        /// </summary>
        /// <param name="phrase">The alias pattern phrase.</param>
        /// <param name="variable">The alias pattern variable.</param>
        /// <param name="type">The type of alias pattern. Possible values
        /// include: 'NotSpecified', 'Extract'</param>
        public AliasPattern(string phrase = default(string), string variable = default(string), AliasPatternType? type = default(AliasPatternType?))
        {
            Phrase = phrase;
            Variable = variable;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the alias pattern phrase.
        /// </summary>
        [JsonProperty(PropertyName = "phrase")]
        public string Phrase { get; set; }

        /// <summary>
        /// Gets or sets the alias pattern variable.
        /// </summary>
        [JsonProperty(PropertyName = "variable")]
        public string Variable { get; set; }

        /// <summary>
        /// Gets or sets the type of alias pattern. Possible values include:
        /// 'NotSpecified', 'Extract'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public AliasPatternType? Type { get; set; }

    }
}
