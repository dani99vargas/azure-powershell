// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Extensions;

    /// <summary>Metadata property bag.</summary>
    public partial class MetadataProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataProperties,
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Author" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataAuthor _author;

        /// <summary>The creator of the content item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataAuthor Author { get => (this._author = this._author ?? new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.MetadataAuthor()); set => this._author = value; }

        /// <summary>Email of author contact</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public string AuthorEmail { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataAuthorInternal)Author).Email; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataAuthorInternal)Author).Email = value ?? null; }

        /// <summary>Link for author/vendor page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public string AuthorLink { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataAuthorInternal)Author).Link; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataAuthorInternal)Author).Link = value ?? null; }

        /// <summary>Name of the author. Company or person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public string AuthorName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataAuthorInternal)Author).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataAuthorInternal)Author).Name = value ?? null; }

        /// <summary>Backing field for <see cref="Category" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataCategories _category;

        /// <summary>Categories for the solution content item</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataCategories Category { get => (this._category = this._category ?? new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.MetadataCategories()); set => this._category = value; }

        /// <summary>domain for the solution content item</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public string[] CategoryDomain { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataCategoriesInternal)Category).Domain; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataCategoriesInternal)Category).Domain = value ?? null /* arrayOf */; }

        /// <summary>Industry verticals for the solution content item</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public string[] CategoryVertical { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataCategoriesInternal)Category).Vertical; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataCategoriesInternal)Category).Vertical = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="ContentId" /> property.</summary>
        private string _contentId;

        /// <summary>
        /// Static ID for the content. Used to identify dependencies and content from solutions or community. Hard-coded/static for
        /// out of the box content and solutions. Dynamic for user-created. This is the resource name
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string ContentId { get => this._contentId; set => this._contentId = value; }

        /// <summary>Backing field for <see cref="Dependency" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataDependencies _dependency;

        /// <summary>
        /// Dependencies for the content item, what other content items it requires to work. Can describe more complex dependencies
        /// using a recursive/nested structure. For a single dependency an id/kind/version can be supplied or operator/criteria for
        /// complex formats.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataDependencies Dependency { get => (this._dependency = this._dependency ?? new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.MetadataDependencies()); set => this._dependency = value; }

        /// <summary>Id of the content item we depend on</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public string DependencyContentId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataDependenciesInternal)Dependency).ContentId; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataDependenciesInternal)Dependency).ContentId = value ?? null; }

        /// <summary>
        /// This is the list of dependencies we must fulfill, according to the AND/OR operator
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataDependencies[] DependencyCriterion { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataDependenciesInternal)Dependency).Criterion; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataDependenciesInternal)Dependency).Criterion = value ?? null /* arrayOf */; }

        /// <summary>Type of the content item we depend on</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.Kind? DependencyKind { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataDependenciesInternal)Dependency).Kind; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataDependenciesInternal)Dependency).Kind = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.Kind)""); }

        /// <summary>Name of the content item</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public string DependencyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataDependenciesInternal)Dependency).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataDependenciesInternal)Dependency).Name = value ?? null; }

        /// <summary>Operator used for list of dependencies in criteria array.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.Operator? DependencyOperator { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataDependenciesInternal)Dependency).Operator; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataDependenciesInternal)Dependency).Operator = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.Operator)""); }

        /// <summary>
        /// Version of the the content item we depend on. Can be blank, * or missing to indicate any version fulfills the dependency.
        /// If version does not match our defined numeric format then an exact match is required.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public string DependencyVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataDependenciesInternal)Dependency).Version; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataDependenciesInternal)Dependency).Version = value ?? null; }

        /// <summary>Backing field for <see cref="FirstPublishDate" /> property.</summary>
        private global::System.DateTime? _firstPublishDate;

        /// <summary>first publish date solution content item</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public global::System.DateTime? FirstPublishDate { get => this._firstPublishDate; set => this._firstPublishDate = value; }

        /// <summary>Backing field for <see cref="Kind" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.Kind _kind;

        /// <summary>The kind of content the metadata is for.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.Kind Kind { get => this._kind; set => this._kind = value; }

        /// <summary>Backing field for <see cref="LastPublishDate" /> property.</summary>
        private global::System.DateTime? _lastPublishDate;

        /// <summary>last publish date for the solution content item</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public global::System.DateTime? LastPublishDate { get => this._lastPublishDate; set => this._lastPublishDate = value; }

        /// <summary>Internal Acessors for Author</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataAuthor Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataPropertiesInternal.Author { get => (this._author = this._author ?? new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.MetadataAuthor()); set { {_author = value;} } }

        /// <summary>Internal Acessors for Category</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataCategories Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataPropertiesInternal.Category { get => (this._category = this._category ?? new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.MetadataCategories()); set { {_category = value;} } }

        /// <summary>Internal Acessors for Dependency</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataDependencies Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataPropertiesInternal.Dependency { get => (this._dependency = this._dependency ?? new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.MetadataDependencies()); set { {_dependency = value;} } }

        /// <summary>Internal Acessors for Source</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataSource Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataPropertiesInternal.Source { get => (this._source = this._source ?? new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.MetadataSource()); set { {_source = value;} } }

        /// <summary>Internal Acessors for Support</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataSupport Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataPropertiesInternal.Support { get => (this._support = this._support ?? new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.MetadataSupport()); set { {_support = value;} } }

        /// <summary>Backing field for <see cref="ParentId" /> property.</summary>
        private string _parentId;

        /// <summary>
        /// Full parent resource ID of the content item the metadata is for. This is the full resource ID including the scope (subscription
        /// and resource group)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string ParentId { get => this._parentId; set => this._parentId = value; }

        /// <summary>Backing field for <see cref="Provider" /> property.</summary>
        private string[] _provider;

        /// <summary>Providers for the solution content item</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string[] Provider { get => this._provider; set => this._provider = value; }

        /// <summary>Backing field for <see cref="Source" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataSource _source;

        /// <summary>Source of the content. This is where/how it was created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataSource Source { get => (this._source = this._source ?? new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.MetadataSource()); set => this._source = value; }

        /// <summary>ID of the content source. The solution ID, workspace ID, etc</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public string SourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataSourceInternal)Source).SourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataSourceInternal)Source).SourceId = value ?? null; }

        /// <summary>Source type of the content</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.SourceKind? SourceKind { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataSourceInternal)Source).Kind; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataSourceInternal)Source).Kind = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.SourceKind)""); }

        /// <summary>
        /// Name of the content source. The repo name, solution name, LA workspace name etc.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public string SourceName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataSourceInternal)Source).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataSourceInternal)Source).Name = value ?? null; }

        /// <summary>Backing field for <see cref="Support" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataSupport _support;

        /// <summary>Support information for the metadata - type, name, contact information</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataSupport Support { get => (this._support = this._support ?? new Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.MetadataSupport()); set => this._support = value; }

        /// <summary>Email of support contact</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public string SupportEmail { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataSupportInternal)Support).Email; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataSupportInternal)Support).Email = value ?? null; }

        /// <summary>Link for support help, like to support page to open a ticket etc.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public string SupportLink { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataSupportInternal)Support).Link; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataSupportInternal)Support).Link = value ?? null; }

        /// <summary>Name of the support contact. Company or person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public string SupportName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataSupportInternal)Support).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataSupportInternal)Support).Name = value ?? null; }

        /// <summary>Type of support for content item</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.SupportTier? SupportTier { get => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataSupportInternal)Support).Tier; set => ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataSupportInternal)Support).Tier = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.SupportTier)""); }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        /// <summary>
        /// Version of the content. Default and recommended format is numeric (e.g. 1, 1.0, 1.0.0, 1.0.0.0), following ARM template
        /// best practices. Can also be any string, but then we cannot guarantee any version checks
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.PropertyOrigin.Owned)]
        public string Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="MetadataProperties" /> instance.</summary>
        public MetadataProperties()
        {

        }
    }
    /// Metadata property bag.
    public partial interface IMetadataProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.IJsonSerializable
    {
        /// <summary>Email of author contact</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Email of author contact",
        SerializedName = @"email",
        PossibleTypes = new [] { typeof(string) })]
        string AuthorEmail { get; set; }
        /// <summary>Link for author/vendor page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Link for author/vendor page",
        SerializedName = @"link",
        PossibleTypes = new [] { typeof(string) })]
        string AuthorLink { get; set; }
        /// <summary>Name of the author. Company or person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the author. Company or person.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string AuthorName { get; set; }
        /// <summary>domain for the solution content item</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"domain for the solution content item",
        SerializedName = @"domains",
        PossibleTypes = new [] { typeof(string) })]
        string[] CategoryDomain { get; set; }
        /// <summary>Industry verticals for the solution content item</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Industry verticals for the solution content item",
        SerializedName = @"verticals",
        PossibleTypes = new [] { typeof(string) })]
        string[] CategoryVertical { get; set; }
        /// <summary>
        /// Static ID for the content. Used to identify dependencies and content from solutions or community. Hard-coded/static for
        /// out of the box content and solutions. Dynamic for user-created. This is the resource name
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Static ID for the content.  Used to identify dependencies and content from solutions or community.  Hard-coded/static for out of the box content and solutions. Dynamic for user-created.  This is the resource name",
        SerializedName = @"contentId",
        PossibleTypes = new [] { typeof(string) })]
        string ContentId { get; set; }
        /// <summary>Id of the content item we depend on</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Id of the content item we depend on",
        SerializedName = @"contentId",
        PossibleTypes = new [] { typeof(string) })]
        string DependencyContentId { get; set; }
        /// <summary>
        /// This is the list of dependencies we must fulfill, according to the AND/OR operator
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This is the list of dependencies we must fulfill, according to the AND/OR operator",
        SerializedName = @"criteria",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataDependencies) })]
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataDependencies[] DependencyCriterion { get; set; }
        /// <summary>Type of the content item we depend on</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of the content item we depend on",
        SerializedName = @"kind",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.Kind) })]
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.Kind? DependencyKind { get; set; }
        /// <summary>Name of the content item</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the content item",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string DependencyName { get; set; }
        /// <summary>Operator used for list of dependencies in criteria array.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Operator used for list of dependencies in criteria array.",
        SerializedName = @"operator",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.Operator) })]
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.Operator? DependencyOperator { get; set; }
        /// <summary>
        /// Version of the the content item we depend on. Can be blank, * or missing to indicate any version fulfills the dependency.
        /// If version does not match our defined numeric format then an exact match is required.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Version of the the content item we depend on.  Can be blank, * or missing to indicate any version fulfills the dependency.  If version does not match our defined numeric format then an exact match is required.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string DependencyVersion { get; set; }
        /// <summary>first publish date solution content item</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"first publish date solution content item",
        SerializedName = @"firstPublishDate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? FirstPublishDate { get; set; }
        /// <summary>The kind of content the metadata is for.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The kind of content the metadata is for.",
        SerializedName = @"kind",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.Kind) })]
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.Kind Kind { get; set; }
        /// <summary>last publish date for the solution content item</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"last publish date for the solution content item",
        SerializedName = @"lastPublishDate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastPublishDate { get; set; }
        /// <summary>
        /// Full parent resource ID of the content item the metadata is for. This is the full resource ID including the scope (subscription
        /// and resource group)
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Full parent resource ID of the content item the metadata is for.  This is the full resource ID including the scope (subscription and resource group)",
        SerializedName = @"parentId",
        PossibleTypes = new [] { typeof(string) })]
        string ParentId { get; set; }
        /// <summary>Providers for the solution content item</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Providers for the solution content item",
        SerializedName = @"providers",
        PossibleTypes = new [] { typeof(string) })]
        string[] Provider { get; set; }
        /// <summary>ID of the content source. The solution ID, workspace ID, etc</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ID of the content source.  The solution ID, workspace ID, etc",
        SerializedName = @"sourceId",
        PossibleTypes = new [] { typeof(string) })]
        string SourceId { get; set; }
        /// <summary>Source type of the content</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Source type of the content",
        SerializedName = @"kind",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.SourceKind) })]
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.SourceKind? SourceKind { get; set; }
        /// <summary>
        /// Name of the content source. The repo name, solution name, LA workspace name etc.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the content source.  The repo name, solution name, LA workspace name etc.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string SourceName { get; set; }
        /// <summary>Email of support contact</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Email of support contact",
        SerializedName = @"email",
        PossibleTypes = new [] { typeof(string) })]
        string SupportEmail { get; set; }
        /// <summary>Link for support help, like to support page to open a ticket etc.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Link for support help, like to support page to open a ticket etc.",
        SerializedName = @"link",
        PossibleTypes = new [] { typeof(string) })]
        string SupportLink { get; set; }
        /// <summary>Name of the support contact. Company or person.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the support contact. Company or person.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string SupportName { get; set; }
        /// <summary>Type of support for content item</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of support for content item",
        SerializedName = @"tier",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.SupportTier) })]
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.SupportTier? SupportTier { get; set; }
        /// <summary>
        /// Version of the content. Default and recommended format is numeric (e.g. 1, 1.0, 1.0.0, 1.0.0.0), following ARM template
        /// best practices. Can also be any string, but then we cannot guarantee any version checks
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Version of the content.  Default and recommended format is numeric (e.g. 1, 1.0, 1.0.0, 1.0.0.0), following ARM template best practices.  Can also be any string, but then we cannot guarantee any version checks",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get; set; }

    }
    /// Metadata property bag.
    internal partial interface IMetadataPropertiesInternal

    {
        /// <summary>The creator of the content item.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataAuthor Author { get; set; }
        /// <summary>Email of author contact</summary>
        string AuthorEmail { get; set; }
        /// <summary>Link for author/vendor page</summary>
        string AuthorLink { get; set; }
        /// <summary>Name of the author. Company or person.</summary>
        string AuthorName { get; set; }
        /// <summary>Categories for the solution content item</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataCategories Category { get; set; }
        /// <summary>domain for the solution content item</summary>
        string[] CategoryDomain { get; set; }
        /// <summary>Industry verticals for the solution content item</summary>
        string[] CategoryVertical { get; set; }
        /// <summary>
        /// Static ID for the content. Used to identify dependencies and content from solutions or community. Hard-coded/static for
        /// out of the box content and solutions. Dynamic for user-created. This is the resource name
        /// </summary>
        string ContentId { get; set; }
        /// <summary>
        /// Dependencies for the content item, what other content items it requires to work. Can describe more complex dependencies
        /// using a recursive/nested structure. For a single dependency an id/kind/version can be supplied or operator/criteria for
        /// complex formats.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataDependencies Dependency { get; set; }
        /// <summary>Id of the content item we depend on</summary>
        string DependencyContentId { get; set; }
        /// <summary>
        /// This is the list of dependencies we must fulfill, according to the AND/OR operator
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataDependencies[] DependencyCriterion { get; set; }
        /// <summary>Type of the content item we depend on</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.Kind? DependencyKind { get; set; }
        /// <summary>Name of the content item</summary>
        string DependencyName { get; set; }
        /// <summary>Operator used for list of dependencies in criteria array.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.Operator? DependencyOperator { get; set; }
        /// <summary>
        /// Version of the the content item we depend on. Can be blank, * or missing to indicate any version fulfills the dependency.
        /// If version does not match our defined numeric format then an exact match is required.
        /// </summary>
        string DependencyVersion { get; set; }
        /// <summary>first publish date solution content item</summary>
        global::System.DateTime? FirstPublishDate { get; set; }
        /// <summary>The kind of content the metadata is for.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.Kind Kind { get; set; }
        /// <summary>last publish date for the solution content item</summary>
        global::System.DateTime? LastPublishDate { get; set; }
        /// <summary>
        /// Full parent resource ID of the content item the metadata is for. This is the full resource ID including the scope (subscription
        /// and resource group)
        /// </summary>
        string ParentId { get; set; }
        /// <summary>Providers for the solution content item</summary>
        string[] Provider { get; set; }
        /// <summary>Source of the content. This is where/how it was created.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataSource Source { get; set; }
        /// <summary>ID of the content source. The solution ID, workspace ID, etc</summary>
        string SourceId { get; set; }
        /// <summary>Source type of the content</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.SourceKind? SourceKind { get; set; }
        /// <summary>
        /// Name of the content source. The repo name, solution name, LA workspace name etc.
        /// </summary>
        string SourceName { get; set; }
        /// <summary>Support information for the metadata - type, name, contact information</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Models.Api20210901Preview.IMetadataSupport Support { get; set; }
        /// <summary>Email of support contact</summary>
        string SupportEmail { get; set; }
        /// <summary>Link for support help, like to support page to open a ticket etc.</summary>
        string SupportLink { get; set; }
        /// <summary>Name of the support contact. Company or person.</summary>
        string SupportName { get; set; }
        /// <summary>Type of support for content item</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SecurityInsights.Support.SupportTier? SupportTier { get; set; }
        /// <summary>
        /// Version of the content. Default and recommended format is numeric (e.g. 1, 1.0, 1.0.0, 1.0.0.0), following ARM template
        /// best practices. Can also be any string, but then we cannot guarantee any version checks
        /// </summary>
        string Version { get; set; }

    }
}