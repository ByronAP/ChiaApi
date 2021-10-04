using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    public class RewardChain
    {
        [JsonProperty("challenge_chain_sub_slot_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string ChallengeChainSubSlotHash { get; set; } = string.Empty;

        [JsonProperty("deficit", NullValueHandling = NullValueHandling.Ignore)]
        public uint Deficit { get; set; }

        [JsonProperty("end_of_slot_vdf", NullValueHandling = NullValueHandling.Ignore)]
        public IpSpVdf? EndOfSlotVdf { get; set; }

        [JsonProperty("infused_challenge_chain_sub_slot_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string InfusedChallengeChainSubSlotHash { get; set; } = string.Empty;
    }
}