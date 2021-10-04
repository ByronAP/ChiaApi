using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Farmer
{
    public class SignagePoint
    {
        [JsonProperty("challenge_chain_sp", NullValueHandling = NullValueHandling.Ignore)]
        public string ChallengeChainSp { get; set; } = string.Empty;

        [JsonProperty("challenge_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string ChallengeHash { get; set; } = string.Empty;

        [JsonProperty("difficulty", NullValueHandling = NullValueHandling.Ignore)]
        public uint Difficulty { get; set; }

        [JsonProperty("reward_chain_sp", NullValueHandling = NullValueHandling.Ignore)]
        public string RewardChainSp { get; set; } = string.Empty;

        [JsonProperty("signage_point_index", NullValueHandling = NullValueHandling.Ignore)]
        public uint SignagePointIndex { get; set; }

        [JsonProperty("sub_slot_iters", NullValueHandling = NullValueHandling.Ignore)]
        public ulong SubSlotIters { get; set; }
    }
}