using ChiaApi.Models.Responses.Shared;
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    public class CoinRecord
    {
        [JsonProperty("coin", NullValueHandling = NullValueHandling.Ignore)]
        public CoinItem? Coin { get; set; }

        [JsonProperty("coinbase", NullValueHandling = NullValueHandling.Ignore)]
        public bool Coinbase { get; set; }

        [JsonProperty("confirmed_block_index", NullValueHandling = NullValueHandling.Ignore)]
        public uint ConfirmedBlockIndex { get; set; }

        [JsonProperty("spent", NullValueHandling = NullValueHandling.Ignore)]
        public bool Spent { get; set; }

        [JsonProperty("spent_block_index", NullValueHandling = NullValueHandling.Ignore)]
        public uint SpentBlockIndex { get; set; }

        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Timestamp { get; set; }
    }
}