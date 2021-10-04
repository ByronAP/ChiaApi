using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    public class EosItem
    {
        [JsonProperty("challenge_chain", NullValueHandling = NullValueHandling.Ignore)]
        public ChallengeChain? ChallengeChain { get; set; }

        [JsonProperty("infused_challenge_chain", NullValueHandling = NullValueHandling.Ignore)]
        public InfusedChallengeChain? InfusedChallengeChain { get; set; }

        [JsonProperty("proofs", NullValueHandling = NullValueHandling.Ignore)]
        public Proofs? Proofs { get; set; }

        [JsonProperty("reward_chain", NullValueHandling = NullValueHandling.Ignore)]
        public RewardChain? RewardChain { get; set; }
    }
}
