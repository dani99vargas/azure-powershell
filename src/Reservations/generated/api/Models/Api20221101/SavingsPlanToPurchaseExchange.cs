// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Extensions;

    /// <summary>Savings plan purchase details</summary>
    public partial class SavingsPlanToPurchaseExchange :
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseExchange,
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseExchangeInternal
    {

        /// <summary>Display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Inlined)]
        public string AppliedScopePropertyDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequestInternal)Property).AppliedScopePropertyDisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequestInternal)Property).AppliedScopePropertyDisplayName = value ?? null; }

        /// <summary>
        /// Fully-qualified identifier of the management group where the benefit must be applied.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Inlined)]
        public string AppliedScopePropertyManagementGroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequestInternal)Property).AppliedScopePropertyManagementGroupId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequestInternal)Property).AppliedScopePropertyManagementGroupId = value ?? null; }

        /// <summary>Fully-qualified identifier of the resource group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Inlined)]
        public string AppliedScopePropertyResourceGroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequestInternal)Property).AppliedScopePropertyResourceGroupId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequestInternal)Property).AppliedScopePropertyResourceGroupId = value ?? null; }

        /// <summary>Fully-qualified identifier of the subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Inlined)]
        public string AppliedScopePropertySubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequestInternal)Property).AppliedScopePropertySubscriptionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequestInternal)Property).AppliedScopePropertySubscriptionId = value ?? null; }

        /// <summary>Tenant ID where the savings plan should apply benefit.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Inlined)]
        public string AppliedScopePropertyTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequestInternal)Property).AppliedScopePropertyTenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequestInternal)Property).AppliedScopePropertyTenantId = value ?? null; }

        /// <summary>Type of the Applied Scope.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.AppliedScopeType? AppliedScopeType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequestInternal)Property).AppliedScopeType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequestInternal)Property).AppliedScopeType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.AppliedScopeType)""); }

        /// <summary>Backing field for <see cref="BillingCurrencyTotal" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPrice _billingCurrencyTotal;

        /// <summary>Pricing information containing the amount and the currency code</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPrice BillingCurrencyTotal { get => (this._billingCurrencyTotal = this._billingCurrencyTotal ?? new Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.Price()); set => this._billingCurrencyTotal = value; }

        /// <summary>
        /// Represents the billing plan in ISO 8601 format. Required only for monthly billing plans.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.BillingPlan? BillingPlan { get => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequestInternal)Property).BillingPlan; set => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequestInternal)Property).BillingPlan = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.BillingPlan)""); }

        /// <summary>Subscription that will be charged for purchasing reservation or savings plan</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Inlined)]
        public string BillingScopeId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequestInternal)Property).BillingScopeId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequestInternal)Property).BillingScopeId = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Inlined)]
        public double? CommitmentAmount { get => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequestInternal)Property).CommitmentAmount; set => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequestInternal)Property).CommitmentAmount = value ?? default(double); }

        /// <summary>
        /// The ISO 4217 3-letter currency code for the currency used by this purchase record.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Inlined)]
        public string CommitmentCurrencyCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequestInternal)Property).CommitmentCurrencyCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequestInternal)Property).CommitmentCurrencyCode = value ?? null; }

        /// <summary>Commitment grain.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.CommitmentGrain? CommitmentGrain { get => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequestInternal)Property).CommitmentGrain; set => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequestInternal)Property).CommitmentGrain = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.CommitmentGrain)""); }

        /// <summary>Friendly name of the savings plan</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Inlined)]
        public string DisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequestInternal)Property).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequestInternal)Property).DisplayName = value ?? null; }

        /// <summary>Internal Acessors for AppliedScopeProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IAppliedScopeProperties Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseExchangeInternal.AppliedScopeProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequestInternal)Property).AppliedScopeProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequestInternal)Property).AppliedScopeProperty = value; }

        /// <summary>Internal Acessors for Commitment</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICommitment Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseExchangeInternal.Commitment { get => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequestInternal)Property).Commitment; set => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequestInternal)Property).Commitment = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequest Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseExchangeInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.SavingsPlanPurchaseRequest()); set { {_property = value;} } }

        /// <summary>Internal Acessors for SavingsPlanPurchaseRequestProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequestProperties Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseExchangeInternal.SavingsPlanPurchaseRequestProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequestInternal)Property).Properties; set => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequestInternal)Property).Properties = value; }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISkuName Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanToPurchaseExchangeInternal.Sku { get => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequestInternal)Property).InternalSkuName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequestInternal)Property).InternalSkuName = value; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequest _property;

        /// <summary>Request body for savings plan purchase</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequest Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.SavingsPlanPurchaseRequest()); set => this._property = value; }

        /// <summary>Backing field for <see cref="SavingsPlanId" /> property.</summary>
        private string _savingsPlanId;

        /// <summary>
        /// Fully qualified id of the savings plan being purchased. This value is only guaranteed to be non-null if the purchase is
        /// successful.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        public string SavingsPlanId { get => this._savingsPlanId; set => this._savingsPlanId = value; }

        /// <summary>Backing field for <see cref="SavingsPlanOrderId" /> property.</summary>
        private string _savingsPlanOrderId;

        /// <summary>Fully qualified id of the savings plan order being purchased</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        public string SavingsPlanOrderId { get => this._savingsPlanOrderId; set => this._savingsPlanOrderId = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Inlined)]
        public string SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequestInternal)Property).SkuName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequestInternal)Property).SkuName = value ?? null; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.OperationStatus? _status;

        /// <summary>Status of the individual operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.OperationStatus? Status { get => this._status; set => this._status = value; }

        /// <summary>Represent savings plan term in ISO 8601 format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Origin(Microsoft.Azure.PowerShell.Cmdlets.Reservations.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.SavingsPlanTerm? Term { get => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequestInternal)Property).Term; set => ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequestInternal)Property).Term = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.SavingsPlanTerm)""); }

        /// <summary>Creates an new <see cref="SavingsPlanToPurchaseExchange" /> instance.</summary>
        public SavingsPlanToPurchaseExchange()
        {

        }
    }
    /// Savings plan purchase details
    public partial interface ISavingsPlanToPurchaseExchange :
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.IJsonSerializable
    {
        /// <summary>Display name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string AppliedScopePropertyDisplayName { get; set; }
        /// <summary>
        /// Fully-qualified identifier of the management group where the benefit must be applied.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Fully-qualified identifier of the management group where the benefit must be applied.",
        SerializedName = @"managementGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string AppliedScopePropertyManagementGroupId { get; set; }
        /// <summary>Fully-qualified identifier of the resource group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Fully-qualified identifier of the resource group.",
        SerializedName = @"resourceGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string AppliedScopePropertyResourceGroupId { get; set; }
        /// <summary>Fully-qualified identifier of the subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Fully-qualified identifier of the subscription.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string AppliedScopePropertySubscriptionId { get; set; }
        /// <summary>Tenant ID where the savings plan should apply benefit.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Tenant ID where the savings plan should apply benefit.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string AppliedScopePropertyTenantId { get; set; }
        /// <summary>Type of the Applied Scope.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of the Applied Scope.",
        SerializedName = @"appliedScopeType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.AppliedScopeType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.AppliedScopeType? AppliedScopeType { get; set; }
        /// <summary>Pricing information containing the amount and the currency code</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Pricing information containing the amount and the currency code",
        SerializedName = @"billingCurrencyTotal",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPrice) })]
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPrice BillingCurrencyTotal { get; set; }
        /// <summary>
        /// Represents the billing plan in ISO 8601 format. Required only for monthly billing plans.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Represents the billing plan in ISO 8601 format. Required only for monthly billing plans.",
        SerializedName = @"billingPlan",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.BillingPlan) })]
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.BillingPlan? BillingPlan { get; set; }
        /// <summary>Subscription that will be charged for purchasing reservation or savings plan</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Subscription that will be charged for purchasing reservation or savings plan",
        SerializedName = @"billingScopeId",
        PossibleTypes = new [] { typeof(string) })]
        string BillingScopeId { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"amount",
        PossibleTypes = new [] { typeof(double) })]
        double? CommitmentAmount { get; set; }
        /// <summary>
        /// The ISO 4217 3-letter currency code for the currency used by this purchase record.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ISO 4217 3-letter currency code for the currency used by this purchase record.",
        SerializedName = @"currencyCode",
        PossibleTypes = new [] { typeof(string) })]
        string CommitmentCurrencyCode { get; set; }
        /// <summary>Commitment grain.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Commitment grain.",
        SerializedName = @"grain",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.CommitmentGrain) })]
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.CommitmentGrain? CommitmentGrain { get; set; }
        /// <summary>Friendly name of the savings plan</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Friendly name of the savings plan",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>
        /// Fully qualified id of the savings plan being purchased. This value is only guaranteed to be non-null if the purchase is
        /// successful.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Fully qualified id of the savings plan being purchased. This value is only guaranteed to be non-null if the purchase is successful.",
        SerializedName = @"savingsPlanId",
        PossibleTypes = new [] { typeof(string) })]
        string SavingsPlanId { get; set; }
        /// <summary>Fully qualified id of the savings plan order being purchased</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Fully qualified id of the savings plan order being purchased",
        SerializedName = @"savingsPlanOrderId",
        PossibleTypes = new [] { typeof(string) })]
        string SavingsPlanOrderId { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string SkuName { get; set; }
        /// <summary>Status of the individual operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Status of the individual operation.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.OperationStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.OperationStatus? Status { get; set; }
        /// <summary>Represent savings plan term in ISO 8601 format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Reservations.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Represent savings plan term in ISO 8601 format.",
        SerializedName = @"term",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.SavingsPlanTerm) })]
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.SavingsPlanTerm? Term { get; set; }

    }
    /// Savings plan purchase details
    internal partial interface ISavingsPlanToPurchaseExchangeInternal

    {
        /// <summary>
        /// Properties specific to applied scope type. Not required if not applicable. Required and need to provide tenantId and managementGroupId
        /// if AppliedScopeType is ManagementGroup
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IAppliedScopeProperties AppliedScopeProperty { get; set; }
        /// <summary>Display name</summary>
        string AppliedScopePropertyDisplayName { get; set; }
        /// <summary>
        /// Fully-qualified identifier of the management group where the benefit must be applied.
        /// </summary>
        string AppliedScopePropertyManagementGroupId { get; set; }
        /// <summary>Fully-qualified identifier of the resource group.</summary>
        string AppliedScopePropertyResourceGroupId { get; set; }
        /// <summary>Fully-qualified identifier of the subscription.</summary>
        string AppliedScopePropertySubscriptionId { get; set; }
        /// <summary>Tenant ID where the savings plan should apply benefit.</summary>
        string AppliedScopePropertyTenantId { get; set; }
        /// <summary>Type of the Applied Scope.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.AppliedScopeType? AppliedScopeType { get; set; }
        /// <summary>Pricing information containing the amount and the currency code</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.IPrice BillingCurrencyTotal { get; set; }
        /// <summary>
        /// Represents the billing plan in ISO 8601 format. Required only for monthly billing plans.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.BillingPlan? BillingPlan { get; set; }
        /// <summary>Subscription that will be charged for purchasing reservation or savings plan</summary>
        string BillingScopeId { get; set; }
        /// <summary>Commitment towards the benefit.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ICommitment Commitment { get; set; }

        double? CommitmentAmount { get; set; }
        /// <summary>
        /// The ISO 4217 3-letter currency code for the currency used by this purchase record.
        /// </summary>
        string CommitmentCurrencyCode { get; set; }
        /// <summary>Commitment grain.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.CommitmentGrain? CommitmentGrain { get; set; }
        /// <summary>Friendly name of the savings plan</summary>
        string DisplayName { get; set; }
        /// <summary>Request body for savings plan purchase</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequest Property { get; set; }
        /// <summary>
        /// Fully qualified id of the savings plan being purchased. This value is only guaranteed to be non-null if the purchase is
        /// successful.
        /// </summary>
        string SavingsPlanId { get; set; }
        /// <summary>Fully qualified id of the savings plan order being purchased</summary>
        string SavingsPlanOrderId { get; set; }
        /// <summary>Properties of a savings plan purchase</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISavingsPlanPurchaseRequestProperties SavingsPlanPurchaseRequestProperty { get; set; }
        /// <summary>The name of sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Models.Api20221101.ISkuName Sku { get; set; }

        string SkuName { get; set; }
        /// <summary>Status of the individual operation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.OperationStatus? Status { get; set; }
        /// <summary>Represent savings plan term in ISO 8601 format.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Reservations.Support.SavingsPlanTerm? Term { get; set; }

    }
}