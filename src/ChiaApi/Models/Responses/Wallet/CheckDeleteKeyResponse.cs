using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Wallet
{
    public class CheckDeleteKeyResponse : ApiResponseBase
    {
        [JsonProperty("fingerprint", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Fingerprint { get; set; }

        [JsonProperty("used_for_farmer_rewards", NullValueHandling = NullValueHandling.Ignore)]
        public bool UsedForFarmerRewards { get; set; }

        [JsonProperty("used_for_pool_rewards", NullValueHandling = NullValueHandling.Ignore)]
        public bool UsedForPoolRewards { get; set; }

        [JsonProperty("wallet_balance", NullValueHandling = NullValueHandling.Ignore)]
        public bool WalletBalance { get; set; }
    }
}
