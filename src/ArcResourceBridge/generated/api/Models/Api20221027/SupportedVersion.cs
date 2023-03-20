// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.Extensions;

    /// <summary>The SupportedVersion object for appliance.</summary>
    public partial class SupportedVersion :
        Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersion,
        Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersionInternal
    {

        /// <summary>The catalog version name for the version available for upgrade.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Origin(Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.PropertyOrigin.Inlined)]
        public string CatalogVersionName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersionMetadataInternal)Metadata).CatalogVersionName; }

        /// <summary>The catalog version namespace for the version available for upgrade.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Origin(Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.PropertyOrigin.Inlined)]
        public string CatalogVersionNamespace { get => ((Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersionMetadataInternal)Metadata).CatalogVersionNamespace; }

        /// <summary>The image audience name for the version available for upgrade.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Origin(Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.PropertyOrigin.Inlined)]
        public string DataAudience { get => ((Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersionMetadataInternal)Metadata).DataAudience; }

        /// <summary>The image catalog name for the version available for upgrade.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Origin(Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.PropertyOrigin.Inlined)]
        public string DataCatalog { get => ((Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersionMetadataInternal)Metadata).DataCatalog; }

        /// <summary>The image offer name for the version available for upgrade.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Origin(Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.PropertyOrigin.Inlined)]
        public string DataOffer { get => ((Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersionMetadataInternal)Metadata).DataOffer; }

        /// <summary>The image version for the version available for upgrade.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Origin(Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.PropertyOrigin.Inlined)]
        public string DataVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersionMetadataInternal)Metadata).DataVersion; }

        /// <summary>Backing field for <see cref="Metadata" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersionMetadata _metadata;

        /// <summary>This is the metadata of the supported newer version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Origin(Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersionMetadata Metadata { get => (this._metadata = this._metadata ?? new Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.SupportedVersionMetadata()); }

        /// <summary>Internal Acessors for CatalogVersionData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersionCatalogVersionData Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersionInternal.CatalogVersionData { get => ((Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersionMetadataInternal)Metadata).CatalogVersionData; set => ((Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersionMetadataInternal)Metadata).CatalogVersionData = value; }

        /// <summary>Internal Acessors for CatalogVersionName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersionInternal.CatalogVersionName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersionMetadataInternal)Metadata).CatalogVersionName; set => ((Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersionMetadataInternal)Metadata).CatalogVersionName = value; }

        /// <summary>Internal Acessors for CatalogVersionNamespace</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersionInternal.CatalogVersionNamespace { get => ((Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersionMetadataInternal)Metadata).CatalogVersionNamespace; set => ((Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersionMetadataInternal)Metadata).CatalogVersionNamespace = value; }

        /// <summary>Internal Acessors for DataAudience</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersionInternal.DataAudience { get => ((Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersionMetadataInternal)Metadata).DataAudience; set => ((Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersionMetadataInternal)Metadata).DataAudience = value; }

        /// <summary>Internal Acessors for DataCatalog</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersionInternal.DataCatalog { get => ((Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersionMetadataInternal)Metadata).DataCatalog; set => ((Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersionMetadataInternal)Metadata).DataCatalog = value; }

        /// <summary>Internal Acessors for DataOffer</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersionInternal.DataOffer { get => ((Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersionMetadataInternal)Metadata).DataOffer; set => ((Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersionMetadataInternal)Metadata).DataOffer = value; }

        /// <summary>Internal Acessors for DataVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersionInternal.DataVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersionMetadataInternal)Metadata).DataVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersionMetadataInternal)Metadata).DataVersion = value; }

        /// <summary>Internal Acessors for Metadata</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersionMetadata Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersionInternal.Metadata { get => (this._metadata = this._metadata ?? new Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.SupportedVersionMetadata()); set { {_metadata = value;} } }

        /// <summary>Internal Acessors for MetadataCatalogVersion</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersionCatalogVersion Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersionInternal.MetadataCatalogVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersionMetadataInternal)Metadata).CatalogVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersionMetadataInternal)Metadata).CatalogVersion = value; }

        /// <summary>Internal Acessors for Version</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersionInternal.Version { get => this._version; set { {_version = value;} } }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        /// <summary>The newer version available for upgrade.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Origin(Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.PropertyOrigin.Owned)]
        public string Version { get => this._version; }

        /// <summary>Creates an new <see cref="SupportedVersion" /> instance.</summary>
        public SupportedVersion()
        {

        }
    }
    /// The SupportedVersion object for appliance.
    public partial interface ISupportedVersion :
        Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.IJsonSerializable
    {
        /// <summary>The catalog version name for the version available for upgrade.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The catalog version name for the version available for upgrade.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string CatalogVersionName { get;  }
        /// <summary>The catalog version namespace for the version available for upgrade.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The catalog version namespace for the version available for upgrade.",
        SerializedName = @"namespace",
        PossibleTypes = new [] { typeof(string) })]
        string CatalogVersionNamespace { get;  }
        /// <summary>The image audience name for the version available for upgrade.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The image audience name for the version available for upgrade.",
        SerializedName = @"audience",
        PossibleTypes = new [] { typeof(string) })]
        string DataAudience { get;  }
        /// <summary>The image catalog name for the version available for upgrade.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The image catalog name for the version available for upgrade.",
        SerializedName = @"catalog",
        PossibleTypes = new [] { typeof(string) })]
        string DataCatalog { get;  }
        /// <summary>The image offer name for the version available for upgrade.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The image offer name for the version available for upgrade.",
        SerializedName = @"offer",
        PossibleTypes = new [] { typeof(string) })]
        string DataOffer { get;  }
        /// <summary>The image version for the version available for upgrade.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The image version for the version available for upgrade.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string DataVersion { get;  }
        /// <summary>The newer version available for upgrade.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The newer version available for upgrade.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get;  }

    }
    /// The SupportedVersion object for appliance.
    internal partial interface ISupportedVersionInternal

    {
        /// <summary>The newer supported version catalog version data.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersionCatalogVersionData CatalogVersionData { get; set; }
        /// <summary>The catalog version name for the version available for upgrade.</summary>
        string CatalogVersionName { get; set; }
        /// <summary>The catalog version namespace for the version available for upgrade.</summary>
        string CatalogVersionNamespace { get; set; }
        /// <summary>The image audience name for the version available for upgrade.</summary>
        string DataAudience { get; set; }
        /// <summary>The image catalog name for the version available for upgrade.</summary>
        string DataCatalog { get; set; }
        /// <summary>The image offer name for the version available for upgrade.</summary>
        string DataOffer { get; set; }
        /// <summary>The image version for the version available for upgrade.</summary>
        string DataVersion { get; set; }
        /// <summary>This is the metadata of the supported newer version.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersionMetadata Metadata { get; set; }
        /// <summary>The newer supported version catalog version.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Models.Api20221027.ISupportedVersionCatalogVersion MetadataCatalogVersion { get; set; }
        /// <summary>The newer version available for upgrade.</summary>
        string Version { get; set; }

    }
}