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
    /// Extension methods for ConnectionMonitorsOperations.
    /// </summary>
    public static partial class ConnectionMonitorsOperationsExtensions
    {
            /// <summary>
            /// Create or update a connection monitor.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing Network Watcher.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the Network Watcher resource.
            /// </param>
            /// <param name='connectionMonitorName'>
            /// The name of the connection monitor.
            /// </param>
            /// <param name='parameters'>
            /// Parameters that define the operation to create a connection monitor.
            /// </param>
            /// <param name='migrate'>
            /// Value indicating whether connection monitor V1 should be migrated to V2
            /// format.
            /// </param>
            public static ConnectionMonitorResult CreateOrUpdate(this IConnectionMonitorsOperations operations, string resourceGroupName, string networkWatcherName, string connectionMonitorName, ConnectionMonitor parameters, string migrate = default(string))
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, networkWatcherName, connectionMonitorName, parameters, migrate).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a connection monitor.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing Network Watcher.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the Network Watcher resource.
            /// </param>
            /// <param name='connectionMonitorName'>
            /// The name of the connection monitor.
            /// </param>
            /// <param name='parameters'>
            /// Parameters that define the operation to create a connection monitor.
            /// </param>
            /// <param name='migrate'>
            /// Value indicating whether connection monitor V1 should be migrated to V2
            /// format.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ConnectionMonitorResult> CreateOrUpdateAsync(this IConnectionMonitorsOperations operations, string resourceGroupName, string networkWatcherName, string connectionMonitorName, ConnectionMonitor parameters, string migrate = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, networkWatcherName, connectionMonitorName, parameters, migrate, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a connection monitor by name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing Network Watcher.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the Network Watcher resource.
            /// </param>
            /// <param name='connectionMonitorName'>
            /// The name of the connection monitor.
            /// </param>
            public static ConnectionMonitorResult Get(this IConnectionMonitorsOperations operations, string resourceGroupName, string networkWatcherName, string connectionMonitorName)
            {
                return operations.GetAsync(resourceGroupName, networkWatcherName, connectionMonitorName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a connection monitor by name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing Network Watcher.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the Network Watcher resource.
            /// </param>
            /// <param name='connectionMonitorName'>
            /// The name of the connection monitor.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ConnectionMonitorResult> GetAsync(this IConnectionMonitorsOperations operations, string resourceGroupName, string networkWatcherName, string connectionMonitorName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, networkWatcherName, connectionMonitorName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified connection monitor.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing Network Watcher.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the Network Watcher resource.
            /// </param>
            /// <param name='connectionMonitorName'>
            /// The name of the connection monitor.
            /// </param>
            public static void Delete(this IConnectionMonitorsOperations operations, string resourceGroupName, string networkWatcherName, string connectionMonitorName)
            {
                operations.DeleteAsync(resourceGroupName, networkWatcherName, connectionMonitorName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified connection monitor.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing Network Watcher.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the Network Watcher resource.
            /// </param>
            /// <param name='connectionMonitorName'>
            /// The name of the connection monitor.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IConnectionMonitorsOperations operations, string resourceGroupName, string networkWatcherName, string connectionMonitorName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, networkWatcherName, connectionMonitorName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Update tags of the specified connection monitor.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the network watcher.
            /// </param>
            /// <param name='connectionMonitorName'>
            /// The name of the connection monitor.
            /// </param>
            /// <param name='tags'>
            /// Resource tags.
            /// </param>
            public static ConnectionMonitorResult UpdateTags(this IConnectionMonitorsOperations operations, string resourceGroupName, string networkWatcherName, string connectionMonitorName, IDictionary<string, string> tags = default(IDictionary<string, string>))
            {
                return operations.UpdateTagsAsync(resourceGroupName, networkWatcherName, connectionMonitorName, tags).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update tags of the specified connection monitor.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the network watcher.
            /// </param>
            /// <param name='connectionMonitorName'>
            /// The name of the connection monitor.
            /// </param>
            /// <param name='tags'>
            /// Resource tags.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ConnectionMonitorResult> UpdateTagsAsync(this IConnectionMonitorsOperations operations, string resourceGroupName, string networkWatcherName, string connectionMonitorName, IDictionary<string, string> tags = default(IDictionary<string, string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateTagsWithHttpMessagesAsync(resourceGroupName, networkWatcherName, connectionMonitorName, tags, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Stops the specified connection monitor.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing Network Watcher.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the Network Watcher resource.
            /// </param>
            /// <param name='connectionMonitorName'>
            /// The name of the connection monitor.
            /// </param>
            public static void Stop(this IConnectionMonitorsOperations operations, string resourceGroupName, string networkWatcherName, string connectionMonitorName)
            {
                operations.StopAsync(resourceGroupName, networkWatcherName, connectionMonitorName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Stops the specified connection monitor.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing Network Watcher.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the Network Watcher resource.
            /// </param>
            /// <param name='connectionMonitorName'>
            /// The name of the connection monitor.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task StopAsync(this IConnectionMonitorsOperations operations, string resourceGroupName, string networkWatcherName, string connectionMonitorName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.StopWithHttpMessagesAsync(resourceGroupName, networkWatcherName, connectionMonitorName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Starts the specified connection monitor.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing Network Watcher.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the Network Watcher resource.
            /// </param>
            /// <param name='connectionMonitorName'>
            /// The name of the connection monitor.
            /// </param>
            public static void Start(this IConnectionMonitorsOperations operations, string resourceGroupName, string networkWatcherName, string connectionMonitorName)
            {
                operations.StartAsync(resourceGroupName, networkWatcherName, connectionMonitorName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Starts the specified connection monitor.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing Network Watcher.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the Network Watcher resource.
            /// </param>
            /// <param name='connectionMonitorName'>
            /// The name of the connection monitor.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task StartAsync(this IConnectionMonitorsOperations operations, string resourceGroupName, string networkWatcherName, string connectionMonitorName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.StartWithHttpMessagesAsync(resourceGroupName, networkWatcherName, connectionMonitorName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Query a snapshot of the most recent connection states.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing Network Watcher.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the Network Watcher resource.
            /// </param>
            /// <param name='connectionMonitorName'>
            /// The name given to the connection monitor.
            /// </param>
            public static ConnectionMonitorQueryResult Query(this IConnectionMonitorsOperations operations, string resourceGroupName, string networkWatcherName, string connectionMonitorName)
            {
                return operations.QueryAsync(resourceGroupName, networkWatcherName, connectionMonitorName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Query a snapshot of the most recent connection states.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing Network Watcher.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the Network Watcher resource.
            /// </param>
            /// <param name='connectionMonitorName'>
            /// The name given to the connection monitor.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ConnectionMonitorQueryResult> QueryAsync(this IConnectionMonitorsOperations operations, string resourceGroupName, string networkWatcherName, string connectionMonitorName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.QueryWithHttpMessagesAsync(resourceGroupName, networkWatcherName, connectionMonitorName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all connection monitors for the specified Network Watcher.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing Network Watcher.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the Network Watcher resource.
            /// </param>
            public static IEnumerable<ConnectionMonitorResult> List(this IConnectionMonitorsOperations operations, string resourceGroupName, string networkWatcherName)
            {
                return operations.ListAsync(resourceGroupName, networkWatcherName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all connection monitors for the specified Network Watcher.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing Network Watcher.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the Network Watcher resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<ConnectionMonitorResult>> ListAsync(this IConnectionMonitorsOperations operations, string resourceGroupName, string networkWatcherName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, networkWatcherName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a connection monitor.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing Network Watcher.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the Network Watcher resource.
            /// </param>
            /// <param name='connectionMonitorName'>
            /// The name of the connection monitor.
            /// </param>
            /// <param name='parameters'>
            /// Parameters that define the operation to create a connection monitor.
            /// </param>
            /// <param name='migrate'>
            /// Value indicating whether connection monitor V1 should be migrated to V2
            /// format.
            /// </param>
            public static ConnectionMonitorResult BeginCreateOrUpdate(this IConnectionMonitorsOperations operations, string resourceGroupName, string networkWatcherName, string connectionMonitorName, ConnectionMonitor parameters, string migrate = default(string))
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, networkWatcherName, connectionMonitorName, parameters, migrate).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a connection monitor.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing Network Watcher.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the Network Watcher resource.
            /// </param>
            /// <param name='connectionMonitorName'>
            /// The name of the connection monitor.
            /// </param>
            /// <param name='parameters'>
            /// Parameters that define the operation to create a connection monitor.
            /// </param>
            /// <param name='migrate'>
            /// Value indicating whether connection monitor V1 should be migrated to V2
            /// format.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ConnectionMonitorResult> BeginCreateOrUpdateAsync(this IConnectionMonitorsOperations operations, string resourceGroupName, string networkWatcherName, string connectionMonitorName, ConnectionMonitor parameters, string migrate = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, networkWatcherName, connectionMonitorName, parameters, migrate, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified connection monitor.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing Network Watcher.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the Network Watcher resource.
            /// </param>
            /// <param name='connectionMonitorName'>
            /// The name of the connection monitor.
            /// </param>
            public static void BeginDelete(this IConnectionMonitorsOperations operations, string resourceGroupName, string networkWatcherName, string connectionMonitorName)
            {
                operations.BeginDeleteAsync(resourceGroupName, networkWatcherName, connectionMonitorName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified connection monitor.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing Network Watcher.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the Network Watcher resource.
            /// </param>
            /// <param name='connectionMonitorName'>
            /// The name of the connection monitor.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IConnectionMonitorsOperations operations, string resourceGroupName, string networkWatcherName, string connectionMonitorName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, networkWatcherName, connectionMonitorName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Stops the specified connection monitor.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing Network Watcher.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the Network Watcher resource.
            /// </param>
            /// <param name='connectionMonitorName'>
            /// The name of the connection monitor.
            /// </param>
            public static void BeginStop(this IConnectionMonitorsOperations operations, string resourceGroupName, string networkWatcherName, string connectionMonitorName)
            {
                operations.BeginStopAsync(resourceGroupName, networkWatcherName, connectionMonitorName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Stops the specified connection monitor.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing Network Watcher.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the Network Watcher resource.
            /// </param>
            /// <param name='connectionMonitorName'>
            /// The name of the connection monitor.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginStopAsync(this IConnectionMonitorsOperations operations, string resourceGroupName, string networkWatcherName, string connectionMonitorName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginStopWithHttpMessagesAsync(resourceGroupName, networkWatcherName, connectionMonitorName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Starts the specified connection monitor.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing Network Watcher.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the Network Watcher resource.
            /// </param>
            /// <param name='connectionMonitorName'>
            /// The name of the connection monitor.
            /// </param>
            public static void BeginStart(this IConnectionMonitorsOperations operations, string resourceGroupName, string networkWatcherName, string connectionMonitorName)
            {
                operations.BeginStartAsync(resourceGroupName, networkWatcherName, connectionMonitorName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Starts the specified connection monitor.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing Network Watcher.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the Network Watcher resource.
            /// </param>
            /// <param name='connectionMonitorName'>
            /// The name of the connection monitor.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginStartAsync(this IConnectionMonitorsOperations operations, string resourceGroupName, string networkWatcherName, string connectionMonitorName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginStartWithHttpMessagesAsync(resourceGroupName, networkWatcherName, connectionMonitorName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Query a snapshot of the most recent connection states.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing Network Watcher.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the Network Watcher resource.
            /// </param>
            /// <param name='connectionMonitorName'>
            /// The name given to the connection monitor.
            /// </param>
            public static ConnectionMonitorQueryResult BeginQuery(this IConnectionMonitorsOperations operations, string resourceGroupName, string networkWatcherName, string connectionMonitorName)
            {
                return operations.BeginQueryAsync(resourceGroupName, networkWatcherName, connectionMonitorName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Query a snapshot of the most recent connection states.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing Network Watcher.
            /// </param>
            /// <param name='networkWatcherName'>
            /// The name of the Network Watcher resource.
            /// </param>
            /// <param name='connectionMonitorName'>
            /// The name given to the connection monitor.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ConnectionMonitorQueryResult> BeginQueryAsync(this IConnectionMonitorsOperations operations, string resourceGroupName, string networkWatcherName, string connectionMonitorName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginQueryWithHttpMessagesAsync(resourceGroupName, networkWatcherName, connectionMonitorName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
