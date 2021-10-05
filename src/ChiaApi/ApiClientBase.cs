// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-28-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="ApiClientBase.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using ChiaApi.Models.Responses.Shared;
using RestSharp;
using System;
using System.Threading.Tasks;
using static ChiaApi.Utils.HttpTools;

namespace ChiaApi
{
    /// <summary>
    /// Class ApiClientBase.
    /// </summary>
    public abstract class ApiClientBase
    {
        /// <summary>
        /// The chia API configuration
        /// </summary>
        internal readonly ChiaApiConfig _chiaApiConfig;

        /// <summary>
        /// The rest client
        /// </summary>
        internal readonly HttpRestClient _restClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClientBase"/> class.
        /// </summary>
        /// <param name="chiaApiConfig">The chia API configuration.</param>
        public ApiClientBase(ChiaApiConfig chiaApiConfig)
        {
            _chiaApiConfig = chiaApiConfig;
            _restClient = new HttpRestClient($"https://{_chiaApiConfig.Host}:{_chiaApiConfig.Port}", _chiaApiConfig.GetClientCertificates(), _chiaApiConfig.Logger)
            {
                BackoffExponentially = true
            };
        }

        /// <summary>
        /// Close connection as an asynchronous operation.
        /// </summary>
        /// <param name="nodeId">The node identifier.</param>
        /// <returns>A Task&lt;BoolResponse&gt; representing the asynchronous operation.</returns>
        public async Task<BoolResponse> CloseConnectionAsync(string nodeId)
        {
            const string resource = "close_connection";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"node_id\":\"{nodeId}\"}}");

            var response = await _restClient.ExecuteAsync<BoolResponse>(request);

            return response;
        }

        /// <summary>
        /// Get connections as an asynchronous operation.
        /// </summary>
        /// <returns>A Task&lt;ConnectionsResponse&gt; representing the asynchronous operation.</returns>
        public async Task<ConnectionsResponse> GetConnectionsAsync()
        {
            const string resource = "get_connections";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody("{}");

            var response = await _restClient.ExecuteAsync<ConnectionsResponse>(request);

            return response;
        }

        /// <summary>
        /// Get initial freeze period as an asynchronous operation.
        /// </summary>
        /// <returns>A Task&lt;InitialFreezeResponse&gt; representing the asynchronous operation.</returns>
        [Obsolete("Forks may use this still when first starting the chain so we keep it for now.")]
        public async Task<InitialFreezeResponse> GetInitialFreezePeriodAsync()
        {
            const string resource = "get_initial_freeze_period";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody("{}");

            var response = await _restClient.ExecuteAsync<InitialFreezeResponse>(request);

            return response;
        }

        /// <summary>
        /// Get network information as an asynchronous operation.
        /// </summary>
        /// <returns>A Task&lt;NetworkInfoResponse&gt; representing the asynchronous operation.</returns>
        public async Task<NetworkInfoResponse> GetNetworkInfoAsync()
        {
            const string resource = "get_network_info";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody("{}");

            var response = await _restClient.ExecuteAsync<NetworkInfoResponse>(request);

            return response;
        }

        /// <summary>
        /// Open connection as an asynchronous operation.
        /// </summary>
        /// <param name="host">The host.</param>
        /// <param name="port">The port.</param>
        /// <returns>A Task&lt;BoolResponse&gt; representing the asynchronous operation.</returns>
        public async Task<BoolResponse> OpenConnectionAsync(string host, uint port)
        {
            const string resource = "open_connection";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"host\":\"{host}\",\"port\":{port}}}");

            var response = await _restClient.ExecuteAsync<BoolResponse>(request);

            return response;
        }
    }
}