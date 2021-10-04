using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.FullNode
{
    public class NpcListItem
    {
        [JsonProperty("coin_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CoinName { get; set; } = string.Empty;

        [JsonProperty("conditions", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<ConditionUnion>>? Conditions { get; set; }

        [JsonProperty("puzzle_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string PuzzleHash { get; set; } = string.Empty;
    }
}