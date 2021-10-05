// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 10-02-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="FarmerApiClient.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using ChiaApi.Models.Responses.Farmer;
using ChiaApi.Models.Responses.Shared;
using RestSharp;
using System.Text;
using System.Threading.Tasks;

namespace ChiaApi
{
    /// <summary>
    /// Class FarmerApiClient.
    /// Implements the <see cref="ChiaApi.ApiClientBase" />
    /// </summary>
    /// <seealso cref="ChiaApi.ApiClientBase" />
    public class FarmerApiClient : ApiClientBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FarmerApiClient"/> class.
        /// </summary>
        /// <param name="chiaApiConfig">The chia API configuration.</param>
        public FarmerApiClient(ChiaApiConfig chiaApiConfig) : base(chiaApiConfig)
        {
        }

        /// <summary>
        /// Get pool login link as an asynchronous operation.
        /// </summary>
        /// <param name="launcherId">The launcher identifier.</param>
        /// <returns>A Task&lt;PoolLoginLinkResponse&gt; representing the asynchronous operation.</returns>
        public async Task<PoolLoginLinkResponse> GetPoolLoginLinkAsync(string launcherId)
        {
            const string resource = "set_payout_instructions";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"launcher_id\":\"{launcherId}\"}}");

            var response = await _restClient.ExecuteAsync<PoolLoginLinkResponse>(request);

            return response;
        }

        /// <summary>
        /// Get pool state as an asynchronous operation.
        /// </summary>
        /// <returns>A Task&lt;PoolStateResponse&gt; representing the asynchronous operation.</returns>
        public async Task<PoolStateResponse> GetPoolStateAsync()
        {
            const string resource = "get_pool_state";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody("{}");

            var response = await _restClient.ExecuteAsync<PoolStateResponse>(request);

            return response;
        }

        /// <summary>
        /// Get reward targets as an asynchronous operation.
        /// </summary>
        /// <param name="searchForPK">if set to <c>true</c> [search for pk].</param>
        /// <returns>A Task&lt;RewardTargetsResponse&gt; representing the asynchronous operation.</returns>
        public async Task<RewardTargetsResponse> GetRewardTargetsAsync(bool searchForPK)
        {
            const string resource = "get_reward_targets";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"search_for_private_key\":{searchForPK.ToString().ToLowerInvariant()}}}");

            var response = await _restClient.ExecuteAsync<RewardTargetsResponse>(request);

            return response;
        }

        /// <summary>
        /// Get signage point as an asynchronous operation.
        /// </summary>
        /// <param name="spHash">The sp hash.</param>
        /// <returns>A Task&lt;SignagePointResponse&gt; representing the asynchronous operation.</returns>
        public async Task<SignagePointResponse> GetSignagePointAsync(string spHash)
        {
            const string resource = "get_signage_point";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody("{}");

            var response = await _restClient.ExecuteAsync<SignagePointResponse>(request);

            return response;
        }

        /// <summary>
        /// Get signage points as an asynchronous operation.
        /// </summary>
        /// <returns>A Task&lt;SignagePointsResponse&gt; representing the asynchronous operation.</returns>
        public async Task<SignagePointsResponse> GetSignagePointsAsync()
        {
            const string resource = "get_signage_points";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody("{}");

            var response = await _restClient.ExecuteAsync<SignagePointsResponse>(request);

            return response;
        }

        /// <summary>
        /// Set payout instructions as an asynchronous operation.
        /// </summary>
        /// <param name="launcherId">The launcher identifier.</param>
        /// <param name="instructions">The instructions.</param>
        /// <returns>A Task&lt;BoolResponse&gt; representing the asynchronous operation.</returns>
        public async Task<BoolResponse> SetPayoutInstructionsAsync(string launcherId, string instructions)
        {
            const string resource = "set_payout_instructions";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"launcher_id\":\"{launcherId}\",\"payout_instructions\":\"{instructions}\"}}");

            var response = await _restClient.ExecuteAsync<BoolResponse>(request);

            return response;
        }

        /// <summary>
        /// Set reward targets as an asynchronous operation.
        /// </summary>
        /// <param name="farmerTarget">The farmer target.</param>
        /// <param name="poolTarget">The pool target.</param>
        /// <returns>A Task&lt;BoolResponse&gt; representing the asynchronous operation.</returns>
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