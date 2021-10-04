using ChiaApi.Models.Responses.Shared;
using RestSharp;
using System;
using System.Threading.Tasks;
using static ChiaApi.Utils.HttpTools;

namespace ChiaApi
{
    public abstract class ApiClientBase
    {
        internal readonly ChiaApiConfig _chiaApiConfig;
        internal readonly HttpRestClient _restClient;

        public ApiClientBase(ChiaApiConfig chiaApiConfig)
        {
            _chiaApiConfig = chiaApiConfig;
            _restClient = new HttpRestClient($"https://{_chiaApiConfig.Host}:{_chiaApiConfig.Port}", _chiaApiConfig.GetClientCertificates(), _chiaApiConfig.Logger)
            {
                BackoffExponentially = true
            };
        }

        public async Task<BoolResponse> CloseConnectionAsync(string nodeId)
        {
            const string resource = "close_connection";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"node_id\":\"{nodeId}\"}}");

            var response = await _restClient.ExecuteAsync<BoolResponse>(request);

            return response;
        }

        public async Task<ConnectionsResponse> GetConnectionsAsync()
        {
            const string resource = "get_connections";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody("{}");

            var response = await _restClient.ExecuteAsync<ConnectionsResponse>(request);

            return response;
        }

        [Obsolete("Forks may use this still when first starting the chain so we keep it for now.")]
        public async Task<InitialFreezeResponse> GetInitialFreezePeriodAsync()
        {
            const string resource = "get_initial_freeze_period";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody("{}");

            var response = await _restClient.ExecuteAsync<InitialFreezeResponse>(request);

            return response;
        }

        public async Task<NetworkInfoResponse> GetNetworkInfoAsync()
        {
            const string resource = "get_network_info";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody("{}");

            var response = await _restClient.ExecuteAsync<NetworkInfoResponse>(request);

            return response;
        }

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