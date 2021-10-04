using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    public class Proofs
    {
        [JsonProperty("challenge_chain_slot_proof", NullValueHandling = NullValueHandling.Ignore)]
        public IpSpProof? ChallengeChainSlotProof { get; set; }

        [JsonProperty("infused_challenge_chain_slot_proof", NullValueHandling = NullValueHandling.Ignore)]
        public IpSpProof? InfusedChallengeChainSlotProof { get; set; }

        [JsonProperty("reward_chain_slot_proof", NullValueHandling = NullValueHandling.Ignore)]
        public IpSpProof? RewardChainSlotProof { get; set; }
    }
}