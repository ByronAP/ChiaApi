using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    public class FoliageBlockData
    {
        [JsonProperty("extension_data", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtensionData { get; set; } = string.Empty;

        [JsonProperty("farmer_reward_puzzle_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string FarmerRewardPuzzleHash { get; set; } = string.Empty;

        [JsonProperty("pool_signature", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolSignature { get; set; } = string.Empty;

        [JsonProperty("pool_target", NullValueHandling = NullValueHandling.Ignore)]
        public PoolTarget? PoolTarget { get; set; }

        [JsonProperty("unfinished_reward_block_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string UnfinishedRewardBlockHash { get; set; } = string.Empty;
    }
}