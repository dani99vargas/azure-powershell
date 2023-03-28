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
    /// ConnectionMonitorsOperations operations.
    /// </summary>
    public partial interface IConnectionMonitorsOperations
    {
        /// <summary>
        /// Create or update a connection monitor.
        /// </summary>
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
        /// Parameters that define the operation to create a connection
        /// monitor.
        /// </param>
        /// <param name='migrate'>
        /// Value indicating whether connection monitor V1 should be migrated
        /// to V2 format.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ConnectionMonitorResult>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string networkWatcherName, string connectionMonitorName, ConnectionMonitor parameters, string migrate = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a connection monitor by name.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing Network Watcher.
        /// </param>
        /// <param name='networkWatcherName'>
        /// The name of the Network Watcher resource.
        /// </param>
        /// <param name='connectionMonitorName'>
        /// The name of the connection monitor.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ConnectionMonitorResult>> GetWithHttpMessagesAsync(string resourceGroupName, string networkWatcherName, string connectionMonitorName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the specified connection monitor.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing Network Watcher.
        /// </param>
        /// <param name='networkWatcherName'>
        /// The name of the Network Watcher resource.
        /// </param>
        /// <param name='connectionMonitorName'>
        /// The name of the connection monitor.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string networkWatcherName, string connectionMonitorName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update tags of the specified connection monitor.
        /// </summary>
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
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ConnectionMonitorResult>> UpdateTagsWithHttpMessagesAsync(string resourceGroupName, string networkWatcherName, string connectionMonitorName, IDictionary<string, string> tags = default(IDictionary<string, string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Stops the specified connection monitor.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing Network Watcher.
        /// </param>
        /// <param name='networkWatcherName'>
        /// The name of the Network Watcher resource.
        /// </param>
        /// <param name='connectionMonitorName'>
        /// The name of the connection monitor.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> StopWithHttpMessagesAsync(string resourceGroupName, string networkWatcherName, string connectionMonitorName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Starts the specified connection monitor.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing Network Watcher.
        /// </param>
        /// <param name='networkWatcherName'>
        /// The name of the Network Watcher resource.
        /// </param>
        /// <param name='connectionMonitorName'>
        /// The name of the connection monitor.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> StartWithHttpMessagesAsync(string resourceGroupName, string networkWatcherName, string connectionMonitorName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Query a snapshot of the most recent connection states.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing Network Watcher.
        /// </param>
        /// <param name='networkWatcherName'>
        /// The name of the Network Watcher resource.
        /// </param>
        /// <param name='connectionMonitorName'>
        /// The name given to the connection monitor.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ConnectionMonitorQueryResult>> QueryWithHttpMessagesAsync(string resourceGroupName, string networkWatcherName, string connectionMonitorName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all connection monitors for the specified Network Watcher.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing Network Watcher.
        /// </param>
        /// <param name='networkWatcherName'>
        /// The name of the Network Watcher resource.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IEnumerable<ConnectionMonitorResult>>> ListWithHttpMessagesAsync(string resourceGroupName, string networkWatcherName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update a connection monitor.
        /// </summary>
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
        /// Parameters that define the operation to create a connection
        /// monitor.
        /// </param>
        /// <param name='migrate'>
        /// Value indicating whether connection monitor V1 should be migrated
        /// to V2 format.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ConnectionMonitorResult>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string networkWatcherName, string connectionMonitorName, ConnectionMonitor parameters, string migrate = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the specified connection monitor.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing Network Watcher.
        /// </param>
        /// <param name='networkWatcherName'>
        /// The name of the Network Watcher resource.
        /// </param>
        /// <param name='connectionMonitorName'>
        /// The name of the connection monitor.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string networkWatcherName, string connectionMonitorName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Stops the specified connection monitor.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing Network Watcher.
        /// </param>
        /// <param name='networkWatcherName'>
        /// The name of the Network Watcher resource.
        /// </param>
        /// <param name='connectionMonitorName'>
        /// The name of the connection monitor.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginStopWithHttpMessagesAsync(string resourceGroupName, string networkWatcherName, string connectionMonitorName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Starts the specified connection monitor.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing Network Watcher.
        /// </param>
        /// <param name='networkWatcherName'>
        /// The name of the Network Watcher resource.
        /// </param>
        /// <param name='connectionMonitorName'>
        /// The name of the connection monitor.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginStartWithHttpMessagesAsync(string resourceGroupName, string networkWatcherName, string connectionMonitorName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Query a snapshot of the most recent connection states.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing Network Watcher.
        /// </param>
        /// <param name='networkWatcherName'>
        /// The name of the Network Watcher resource.
        /// </param>
        /// <param name='connectionMonitorName'>
        /// The name given to the connection monitor.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ConnectionMonitorQueryResult>> BeginQueryWithHttpMessagesAsync(string resourceGroupName, string networkWatcherName, string connectionMonitorName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
