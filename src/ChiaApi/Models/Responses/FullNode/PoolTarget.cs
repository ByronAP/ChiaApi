using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    public class PoolTarget
    {
        [JsonProperty("max_height", NullValueHandling = NullValueHandling.Ignore)]
        public ulong MaxHeight { get; set; }

        [JsonProperty("puzzle_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string PuzzleHash { get; set; } = string.Empty;
    }
}
