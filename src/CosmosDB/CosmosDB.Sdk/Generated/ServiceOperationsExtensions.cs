// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ServiceOperations.
    /// </summary>
    public static partial class ServiceOperationsExtensions
    {
            /// <summary>
            /// Gets the status of service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// Cosmos DB database account name.
            /// </param>
            public static IEnumerable<ServiceResource> List(this IServiceOperations operations, string resourceGroupName, string accountName)
            {
                return operations.ListAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the status of service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// Cosmos DB database account name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<ServiceResource>> ListAsync(this IServiceOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// Cosmos DB database account name.
            /// </param>
            /// <param name='serviceName'>
            /// Cosmos DB service name.
            /// </param>
            /// <param name='createUpdateParameters'>
            /// The Service resource parameters.
            /// </param>
            public static ServiceResource Create(this IServiceOperations operations, string resourceGroupName, string accountName, string serviceName, ServiceResourceCreateUpdateParameters createUpdateParameters)
            {
                return operations.CreateAsync(resourceGroupName, accountName, serviceName, createUpdateParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// Cosmos DB database account name.
            /// </param>
            /// <param name='serviceName'>
            /// Cosmos DB service name.
            /// </param>
            /// <param name='createUpdateParameters'>
            /// The Service resource parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServiceResource> CreateAsync(this IServiceOperations operations, string resourceGroupName, string accountName, string serviceName, ServiceResourceCreateUpdateParameters createUpdateParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, accountName, serviceName, createUpdateParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the status of service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// Cosmos DB database account name.
            /// </param>
            /// <param name='serviceName'>
            /// Cosmos DB service name.
            /// </param>
            public static ServiceResource Get(this IServiceOperations operations, string resourceGroupName, string accountName, string serviceName)
            {
                return operations.GetAsync(resourceGroupName, accountName, serviceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the status of service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// Cosmos DB database account name.
            /// </param>
            /// <param name='serviceName'>
            /// Cosmos DB service name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServiceResource> GetAsync(this IServiceOperations operations, string resourceGroupName, string accountName, string serviceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, serviceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes service with the given serviceName.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// Cosmos DB database account name.
            /// </param>
            /// <param name='serviceName'>
            /// Cosmos DB service name.
            /// </param>
            public static ServiceDeleteHeaders Delete(this IServiceOperations operations, string resourceGroupName, string accountName, string serviceName)
            {
                return operations.DeleteAsync(resourceGroupName, accountName, serviceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes service with the given serviceName.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// Cosmos DB database account name.
            /// </param>
            /// <param name='serviceName'>
            /// Cosmos DB service name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServiceDeleteHeaders> DeleteAsync(this IServiceOperations operations, string resourceGroupName, string accountName, string serviceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, serviceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Creates a service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// Cosmos DB database account name.
            /// </param>
            /// <param name='serviceName'>
            /// Cosmos DB service name.
            /// </param>
            /// <param name='createUpdateParameters'>
            /// The Service resource parameters.
            /// </param>
            public static ServiceResource BeginCreate(this IServiceOperations operations, string resourceGroupName, string accountName, string serviceName, ServiceResourceCreateUpdateParameters createUpdateParameters)
            {
                return operations.BeginCreateAsync(resourceGroupName, accountName, serviceName, createUpdateParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// Cosmos DB database account name.
            /// </param>
            /// <param name='serviceName'>
            /// Cosmos DB service name.
            /// </param>
            /// <param name='createUpdateParameters'>
            /// The Service resource parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServiceResource> BeginCreateAsync(this IServiceOperations operations, string resourceGroupName, string accountName, string serviceName, ServiceResourceCreateUpdateParameters createUpdateParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, accountName, serviceName, createUpdateParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes service with the given serviceName.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// Cosmos DB database account name.
            /// </param>
            /// <param name='serviceName'>
            /// Cosmos DB service name.
            /// </param>
            public static ServiceDeleteHeaders BeginDelete(this IServiceOperations operations, string resourceGroupName, string accountName, string serviceName)
            {
                return operations.BeginDeleteAsync(resourceGroupName, accountName, serviceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes service with the given serviceName.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// Cosmos DB database account name.
            /// </param>
            /// <param name='serviceName'>
            /// Cosmos DB service name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServiceDeleteHeaders> BeginDeleteAsync(this IServiceOperations operations, string resourceGroupName, string accountName, string serviceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, accountName, serviceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

    }
}
