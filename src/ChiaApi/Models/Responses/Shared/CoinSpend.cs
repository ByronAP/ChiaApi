using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Shared
{
    public class CoinSpend
    {
        [JsonProperty("coin", NullValueHandling = NullValueHandling.Ignore)]
        public CoinItem? Coin { get; set; }

        [JsonProperty("puzzle_reveal", NullValueHandling = NullValueHandling.Ignore)]
        public string PuzzleReveal { get; set; } = string.Empty;

        [JsonProperty("solution", NullValueHandling = NullValueHandling.Ignore)]
        public string Solution { get; set; } = string.Empty;
    }
}
