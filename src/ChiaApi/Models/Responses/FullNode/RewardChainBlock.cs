using Newtonsoft.Json;
using System.Numerics;

namespace ChiaApi.Models.Responses.FullNode
{
    public class RewardChainBlock
    {
        [JsonProperty("challenge_chain_ip_vdf", NullValueHandling = NullValueHandling.Ignore)]
        public IpSpVdf? ChallengeChainIpVdf { get; set; }

        [JsonProperty("challenge_chain_sp_signature", NullValueHandling = NullValueHandling.Ignore)]
        public string ChallengeChainSpSignature { get; set; } = string.Empty;

        [JsonProperty("challenge_chain_sp_vdf", NullValueHandling = NullValueHandling.Ignore)]
        public IpSpVdf? ChallengeChainSpVdf { get; set; }

        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Height { get; set; }

        [JsonProperty("infused_challenge_chain_ip_vdf", NullValueHandling = NullValueHandling.Ignore)]
        public IpSpVdf? InfusedChallengeChainIpVdf { get; set; }

        [JsonProperty("is_transaction_block", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsTransactionBlock { get; set; }

        [JsonProperty("pos_ss_cc_challenge_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string PosSsCcChallengeHash { get; set; } = string.Empty;

        [JsonProperty("proof_of_space", NullValueHandling = NullValueHandling.Ignore)]
        public ProofOfSpace? ProofOfSpace { get; set; }

        [JsonProperty("reward_chain_ip_vdf", NullValueHandling = NullValueHandling.Ignore)]
        public IpSpVdf? RewardChainIpVdf { get; set; }

        [JsonProperty("reward_chain_sp_signature", NullValueHandling = NullValueHandling.Ignore)]
        public string RewardChainSpSignature { get; set; } = string.Empty;

        [JsonProperty("reward_chain_sp_vdf", NullValueHandling = NullValueHandling.Ignore)]
        public IpSpVdf? RewardChainSpVdf { get; set; }

        [JsonProperty("signage_point_index", NullValueHandling = NullValueHandling.Ignore)]
        public uint SignagePointIndex { get; set; }

        [JsonProperty("total_iters", NullValueHandling = NullValueHandling.Ignore)]
        public BigInteger TotalIters { get; set; }

        [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Weight { get; set; }
    }
}