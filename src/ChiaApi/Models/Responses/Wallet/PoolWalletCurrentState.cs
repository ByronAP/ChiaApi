using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Wallet
{
    public class PoolWalletCurrentState
    {
        [JsonProperty("owner_pubkey", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerPubkey { get; set; } = string.Empty;

        [JsonProperty("pool_url", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolUrl { get; set; } = string.Empty;

        [JsonProperty("relative_lock_height", NullValueHandling = NullValueHandling.Ignore)]
        public ulong RelativeLockHeight { get; set; }

        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public uint State { get; set; }

        [JsonProperty("target_puzzle_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetPuzzleHash { get; set; } = string.Empty;

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public uint Version { get; set; }
    }
}
