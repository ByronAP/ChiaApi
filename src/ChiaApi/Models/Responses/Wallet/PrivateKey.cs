using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Wallet
{
    public class PrivateKey
    {
        [JsonProperty("farmer_pk", NullValueHandling = NullValueHandling.Ignore)]
        public string FarmerPk { get; set; } = string.Empty;

        [JsonProperty("fingerprint", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Fingerprint { get; set; }

        [JsonProperty("pk", NullValueHandling = NullValueHandling.Ignore)]
        public string Pk { get; set; } = string.Empty;

        [JsonProperty("pool_pk", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolPk { get; set; } = string.Empty;

        [JsonProperty("seed", NullValueHandling = NullValueHandling.Ignore)]
        public string Seed { get; set; } = string.Empty;

        [JsonProperty("sk", NullValueHandling = NullValueHandling.Ignore)]
        public string Sk { get; set; } = string.Empty;
    }
}