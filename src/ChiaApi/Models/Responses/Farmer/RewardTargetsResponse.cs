using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Farmer
{
    public class RewardTargetsResponse : ApiResponseBase
    {
        [JsonProperty("farmer_target", NullValueHandling = NullValueHandling.Ignore)]
        public string FarmerTarget { get; set; } = string.Empty;

        [JsonProperty("have_farmer_sk", NullValueHandling = NullValueHandling.Ignore)]
        public bool HaveFarmerSk { get; set; }

        [JsonProperty("have_pool_sk", NullValueHandling = NullValueHandling.Ignore)]
        public bool HavePoolSk { get; set; }

        [JsonProperty("pool_target", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolTarget { get; set; } = string.Empty;
    }
}
