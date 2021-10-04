using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    public class InfusedChallengeChain
    {
        [JsonProperty("infused_challenge_chain_end_of_slot_vdf", NullValueHandling = NullValueHandling.Ignore)]
        public IpSpVdf? InfusedChallengeChainEndOfSlotVdf { get; set; }
    }
}