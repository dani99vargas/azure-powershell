// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Extensions;

    /// <summary>The resource model definition.</summary>
    public partial class Resource :
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.IResource,
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.IResourceInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Azure resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.IResourceInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.IResourceInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.IResourceInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Azure resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.IResourceTags _tag;

        /// <summary>Azure resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.IResourceTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.ResourceTags()); set => this._tag = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Azure resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Origin(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="Resource" /> instance.</summary>
        public Resource()
        {

        }
    }
    /// The resource model definition.
    public partial interface IResource :
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.IJsonSerializable
    {
        /// <summary>Azure resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Azure resource identifier.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>Azure resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Azure resource name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>Azure resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Azure resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.IResourceTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.IResourceTags Tag { get; set; }
        /// <summary>Azure resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Azure resource type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// The resource model definition.
    internal partial interface IResourceInternal

    {
        /// <summary>Azure resource identifier.</summary>
        string Id { get; set; }
        /// <summary>Azure resource name.</summary>
        string Name { get; set; }
        /// <summary>Azure resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ElasticSan.Models.Api20211120Preview.IResourceTags Tag { get; set; }
        /// <summary>Azure resource type.</summary>
        string Type { get; set; }

    }
}