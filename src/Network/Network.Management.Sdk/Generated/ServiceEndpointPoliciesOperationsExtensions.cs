// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ServiceEndpointPoliciesOperations.
    /// </summary>
    public static partial class ServiceEndpointPoliciesOperationsExtensions
    {
            /// <summary>
            /// Deletes the specified service endpoint policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceEndpointPolicyName'>
            /// The name of the service endpoint policy.
            /// </param>
            public static void Delete(this IServiceEndpointPoliciesOperations operations, string resourceGroupName, string serviceEndpointPolicyName)
            {
                operations.DeleteAsync(resourceGroupName, serviceEndpointPolicyName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified service endpoint policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceEndpointPolicyName'>
            /// The name of the service endpoint policy.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IServiceEndpointPoliciesOperations operations, string resourceGroupName, string serviceEndpointPolicyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serviceEndpointPolicyName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the specified service Endpoint Policies in a specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceEndpointPolicyName'>
            /// The name of the service endpoint policy.
            /// </param>
            /// <param name='expand'>
            /// Expands referenced resources.
            /// </param>
            public static ServiceEndpointPolicy Get(this IServiceEndpointPoliciesOperations operations, string resourceGroupName, string serviceEndpointPolicyName, string expand = default(string))
            {
                return operations.GetAsync(resourceGroupName, serviceEndpointPolicyName, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified service Endpoint Policies in a specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceEndpointPolicyName'>
            /// The name of the service endpoint policy.
            /// </param>
            /// <param name='expand'>
            /// Expands referenced resources.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServiceEndpointPolicy> GetAsync(this IServiceEndpointPoliciesOperations operations, string resourceGroupName, string serviceEndpointPolicyName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serviceEndpointPolicyName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a service Endpoint Policies.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceEndpointPolicyName'>
            /// The name of the service endpoint policy.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update service endpoint policy
            /// operation.
            /// </param>
            public static ServiceEndpointPolicy CreateOrUpdate(this IServiceEndpointPoliciesOperations operations, string resourceGroupName, string serviceEndpointPolicyName, ServiceEndpointPolicy parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serviceEndpointPolicyName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a service Endpoint Policies.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceEndpointPolicyName'>
            /// The name of the service endpoint policy.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update service endpoint policy
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServiceEndpointPolicy> CreateOrUpdateAsync(this IServiceEndpointPoliciesOperations operations, string resourceGroupName, string serviceEndpointPolicyName, ServiceEndpointPolicy parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serviceEndpointPolicyName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates tags of a service endpoint policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceEndpointPolicyName'>
            /// The name of the service endpoint policy.
            /// </param>
            /// <param name='tags'>
            /// Resource tags.
            /// </param>
            public static ServiceEndpointPolicy UpdateTags(this IServiceEndpointPoliciesOperations operations, string resourceGroupName, string serviceEndpointPolicyName, IDictionary<string, string> tags = default(IDictionary<string, string>))
            {
                return operations.UpdateTagsAsync(resourceGroupName, serviceEndpointPolicyName, tags).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates tags of a service endpoint policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceEndpointPolicyName'>
            /// The name of the service endpoint policy.
            /// </param>
            /// <param name='tags'>
            /// Resource tags.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServiceEndpointPolicy> UpdateTagsAsync(this IServiceEndpointPoliciesOperations operations, string resourceGroupName, string serviceEndpointPolicyName, IDictionary<string, string> tags = default(IDictionary<string, string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateTagsWithHttpMessagesAsync(resourceGroupName, serviceEndpointPolicyName, tags, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the service endpoint policies in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<ServiceEndpointPolicy> List(this IServiceEndpointPoliciesOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the service endpoint policies in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ServiceEndpointPolicy>> ListAsync(this IServiceEndpointPoliciesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all service endpoint Policies in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static IPage<ServiceEndpointPolicy> ListByResourceGroup(this IServiceEndpointPoliciesOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all service endpoint Policies in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ServiceEndpointPolicy>> ListByResourceGroupAsync(this IServiceEndpointPoliciesOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified service endpoint policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceEndpointPolicyName'>
            /// The name of the service endpoint policy.
            /// </param>
            public static void BeginDelete(this IServiceEndpointPoliciesOperations operations, string resourceGroupName, string serviceEndpointPolicyName)
            {
                operations.BeginDeleteAsync(resourceGroupName, serviceEndpointPolicyName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified service endpoint policy.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceEndpointPolicyName'>
            /// The name of the service endpoint policy.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IServiceEndpointPoliciesOperations operations, string resourceGroupName, string serviceEndpointPolicyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, serviceEndpointPolicyName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates or updates a service Endpoint Policies.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceEndpointPolicyName'>
            /// The name of the service endpoint policy.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update service endpoint policy
            /// operation.
            /// </param>
            public static ServiceEndpointPolicy BeginCreateOrUpdate(this IServiceEndpointPoliciesOperations operations, string resourceGroupName, string serviceEndpointPolicyName, ServiceEndpointPolicy parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, serviceEndpointPolicyName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a service Endpoint Policies.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceEndpointPolicyName'>
            /// The name of the service endpoint policy.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update service endpoint policy
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServiceEndpointPolicy> BeginCreateOrUpdateAsync(this IServiceEndpointPoliciesOperations operations, string resourceGroupName, string serviceEndpointPolicyName, ServiceEndpointPolicy parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serviceEndpointPolicyName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the service endpoint policies in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ServiceEndpointPolicy> ListNext(this IServiceEndpointPoliciesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the service endpoint policies in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ServiceEndpointPolicy>> ListNextAsync(this IServiceEndpointPoliciesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all service endpoint Policies in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ServiceEndpointPolicy> ListByResourceGroupNext(this IServiceEndpointPoliciesOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all service endpoint Policies in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ServiceEndpointPolicy>> ListByResourceGroupNextAsync(this IServiceEndpointPoliciesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
