using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    public class ChallengeChain
    {
        [JsonProperty("challenge_chain_end_of_slot_vdf", NullValueHandling = NullValueHandling.Ignore)]
        public IpSpVdf? ChallengeChainEndOfSlotVdf { get; set; }

        [JsonProperty("infused_challenge_chain_sub_slot_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string InfusedChallengeChainSubSlotHash { get; set; } = string.Empty;

        [JsonProperty("new_difficulty", NullValueHandling = NullValueHandling.Ignore)]
        public uint NewDifficulty { get; set; }

        [JsonProperty("new_sub_slot_iters", NullValueHandling = NullValueHandling.Ignore)]
        public ulong NewSubSlotIters { get; set; }

        [JsonProperty("subepoch_summary_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string SubepochSummaryHash { get; set; } = string.Empty;
    }
}