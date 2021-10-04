using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Farmer
{
    public class PoolConfig
    {
        [JsonProperty("authentication_public_key", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthenticationPublicKey { get; set; } = string.Empty;

        [JsonProperty("launcher_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LauncherId { get; set; } = string.Empty;

        [JsonProperty("owner_public_key", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerPublicKey { get; set; } = string.Empty;

        [JsonProperty("p2_singleton_puzzle_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string P2SingletonPuzzleHash { get; set; } = string.Empty;

        [JsonProperty("payout_instructions", NullValueHandling = NullValueHandling.Ignore)]
        public string PayoutInstructions { get; set; } = string.Empty;

        [JsonProperty("pool_url", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolUrl { get; set; } = string.Empty;

        [JsonProperty("target_puzzle_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetPuzzleHash { get; set; } = string.Empty;
    }
}