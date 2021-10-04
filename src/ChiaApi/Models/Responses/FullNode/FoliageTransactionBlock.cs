using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    public class FoliageTransactionBlock
    {
        [JsonProperty("additions_root", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionsRoot { get; set; } = string.Empty;

        [JsonProperty("filter_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string FilterHash { get; set; } = string.Empty;

        [JsonProperty("prev_transaction_block_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string PrevTransactionBlockHash { get; set; } = string.Empty;

        [JsonProperty("removals_root", NullValueHandling = NullValueHandling.Ignore)]
        public string RemovalsRoot { get; set; } = string.Empty;

        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Timestamp { get; set; }

        [JsonProperty("transactions_info_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string TransactionsInfoHash { get; set; } = string.Empty;
    }
}
