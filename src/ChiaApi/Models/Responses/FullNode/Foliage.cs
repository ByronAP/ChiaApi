using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    public class Foliage
    {
        [JsonProperty("foliage_block_data", NullValueHandling = NullValueHandling.Ignore)]
        public FoliageBlockData? FoliageBlockData { get; set; }

        [JsonProperty("foliage_block_data_signature", NullValueHandling = NullValueHandling.Ignore)]
        public string FoliageBlockDataSignature { get; set; } = string.Empty;

        [JsonProperty("foliage_transaction_block_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string FoliageTransactionBlockHash { get; set; } = string.Empty;

        [JsonProperty("foliage_transaction_block_signature", NullValueHandling = NullValueHandling.Ignore)]
        public string FoliageTransactionBlockSignature { get; set; } = string.Empty;

        [JsonProperty("prev_block_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string PrevBlockHash { get; set; } = string.Empty;

        [JsonProperty("reward_block_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string RewardBlockHash { get; set; } = string.Empty;
    }
}