using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Wallet
{
    public class FarmedAmountResponse : ApiResponseBase
    {
        [JsonProperty("farmed_amount", NullValueHandling = NullValueHandling.Ignore)]
        public ulong FarmedAmount { get; set; }

        [JsonProperty("farmer_reward_amount", NullValueHandling = NullValueHandling.Ignore)]
        public ulong FarmerRewardAmount { get; set; }

        [JsonProperty("fee_amount", NullValueHandling = NullValueHandling.Ignore)]
        public ulong FeeAmount { get; set; }

        [JsonProperty("last_height_farmed", NullValueHandling = NullValueHandling.Ignore)]
        public ulong LastHeightFarmed { get; set; }

        [JsonProperty("pool_reward_amount", NullValueHandling = NullValueHandling.Ignore)]
        public ulong PoolRewardAmount { get; set; }
    }
}