using ChiaApi.Models.Responses.Farmer;
using ChiaApi.Models.Responses.Shared;
using RestSharp;
using System.Text;
using System.Threading.Tasks;

namespace ChiaApi
{
    public class FarmerApiClient : ApiClientBase
    {
        public FarmerApiClient(ChiaApiConfig chiaApiConfig) : base(chiaApiConfig)
        {
        }

        public async Task<PoolLoginLinkResponse> GetPoolLoginLinkAsync(string launcherId)
        {
            const string resource = "set_payout_instructions";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"launcher_id\":\"{launcherId}\"}}");

            var response = await _restClient.ExecuteAsync<PoolLoginLinkResponse>(request);

            return response;
        }

        public async Task<PoolStateResponse> GetPoolStateAsync()
        {
            const string resource = "get_pool_state";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody("{}");

            var response = await _restClient.ExecuteAsync<PoolStateResponse>(request);

            return response;
        }

        public async Task<RewardTargetsResponse> GetRewardTargetsAsync(bool searchForPK)
        {
            const string resource = "get_reward_targets";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"search_for_private_key\":{searchForPK.ToString().ToLowerInvariant()}}}");

            var response = await _restClient.ExecuteAsync<RewardTargetsResponse>(request);

            return response;
        }

        public async Task<SignagePointResponse> GetSignagePointAsync(string spHash)
        {
            const string resource = "get_signage_point";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody("{}");

            var response = await _restClient.ExecuteAsync<SignagePointResponse>(request);

            return response;
        }

        public async Task<SignagePointsResponse> GetSignagePointsAsync()
        {
            const string resource = "get_signage_points";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody("{}");

            var response = await _restClient.ExecuteAsync<SignagePointsResponse>(request);

            return response;
        }

        public async Task<BoolResponse> SetPayoutInstructionsAsync(string launcherId, string instructions)
        {
            const string resource = "set_payout_instructions";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"launcher_id\":\"{launcherId}\",\"payout_instructions\":\"{instructions}\"}}");

            var response = await _restClient.ExecuteAsync<BoolResponse>(request);

            return response;
        }

        public async Task<BoolResponse> SetRewardTargetsAsync(string farmerTarget, string poolTarget)
        {
            const string resource = "set_reward_targets";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);

            var jsonStringBuilder = new StringBuilder();
            jsonStringBuilder.Append("{");
            if (!string.IsNullOrEmpty(farmerTarget)) jsonStringBuilder.Append("\"farmer_target\":\"").Append(farmerTarget).Append("\"");
            if (!string.IsNullOrEmpty(poolTarget)) jsonStringBuilder.Append(",\"pool_target\":\"").Append(poolTarget).Append("\"");
            jsonStringBuilder.Append("}");

            request.AddJsonBody(jsonStringBuilder.ToString());

            var response = await _restClient.ExecuteAsync<BoolResponse>(request);

            return response;
        }
    }
}