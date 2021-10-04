using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.Farmer
{
    public class PoolState
    {
        [JsonProperty("authentication_token_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public uint AuthenticationTokenTimeout { get; set; }

        [JsonProperty("current_difficulty", NullValueHandling = NullValueHandling.Ignore)]
        public uint CurrentDifficulty { get; set; }

        [JsonProperty("current_points", NullValueHandling = NullValueHandling.Ignore)]
        public uint CurrentPoints { get; set; }

        [JsonProperty("next_farmer_update", NullValueHandling = NullValueHandling.Ignore)]
        public decimal NextFarmerUpdate { get; set; }

        [JsonProperty("next_pool_info_update", NullValueHandling = NullValueHandling.Ignore)]
        public decimal NextPoolInfoUpdate { get; set; }

        [JsonProperty("p2_singleton_puzzle_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string P2SingletonPuzzleHash { get; set; } = string.Empty;

        [JsonProperty("points_acknowledged_24h", NullValueHandling = NullValueHandling.Ignore)]
        public List<dynamic>? PointsAcknowledged24H { get; set; }

        [JsonProperty("points_acknowledged_since_start", NullValueHandling = NullValueHandling.Ignore)]
        public ulong PointsAcknowledgedSinceStart { get; set; }

        [JsonProperty("points_found_24h", NullValueHandling = NullValueHandling.Ignore)]
        public List<dynamic>? PointsFound24H { get; set; }

        [JsonProperty("points_found_since_start", NullValueHandling = NullValueHandling.Ignore)]
        public ulong PointsFoundSinceStart { get; set; }

        [JsonProperty("pool_config", NullValueHandling = NullValueHandling.Ignore)]
        public PoolConfig? PoolConfig { get; set; }

        [JsonProperty("pool_errors_24h", NullValueHandling = NullValueHandling.Ignore)]
        public List<dynamic>? PoolErrors24H { get; set; }
    }
}
