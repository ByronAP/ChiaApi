using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Shared
{
    public class CoinItem
    {
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Amount { get; set; }

        [JsonProperty("parent_coin_info", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentCoinInfo { get; set; } = string.Empty;

        [JsonProperty("puzzle_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string PuzzleHash { get; set; } = string.Empty;
    }
}