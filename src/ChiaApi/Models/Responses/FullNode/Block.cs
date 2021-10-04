using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.FullNode
{
    public class Block
    {
        [JsonProperty("challenge_chain_ip_proof", NullValueHandling = NullValueHandling.Ignore)]
        public IpSpProof? ChallengeChainIpProof { get; set; }

        [JsonProperty("challenge_chain_sp_proof", NullValueHandling = NullValueHandling.Ignore)]
        public IpSpProof? ChallengeChainSpProof { get; set; }

        // TODO: create this type
        [JsonProperty("finished_sub_slots", NullValueHandling = NullValueHandling.Ignore)]
        public List<dynamic>? FinishedSubSlots { get; set; }

        [JsonProperty("foliage", NullValueHandling = NullValueHandling.Ignore)]
        public Foliage? Foliage { get; set; }

        [JsonProperty("foliage_transaction_block", NullValueHandling = NullValueHandling.Ignore)]
        public FoliageTransactionBlock? FoliageTransactionBlock { get; set; }

        [JsonProperty("header_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string HeaderHash { get; set; } = string.Empty;

        [JsonProperty("infused_challenge_chain_ip_proof", NullValueHandling = NullValueHandling.Ignore)]
        public IpSpProof? InfusedChallengeChainIpProof { get; set; }

        [JsonProperty("reward_chain_block", NullValueHandling = NullValueHandling.Ignore)]
        public RewardChainBlock? RewardChainBlock { get; set; }

        [JsonProperty("reward_chain_ip_proof", NullValueHandling = NullValueHandling.Ignore)]
        public IpSpProof? RewardChainIpProof { get; set; }

        [JsonProperty("reward_chain_sp_proof", NullValueHandling = NullValueHandling.Ignore)]
        public IpSpProof? RewardChainSpProof { get; set; }

        [JsonProperty("transactions_generator", NullValueHandling = NullValueHandling.Ignore)]
        public string TransactionsGenerator { get; set; } = string.Empty;

        [JsonProperty("transactions_generator_ref_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ulong>? TransactionsGeneratorRefList { get; set; }

        [JsonProperty("transactions_info", NullValueHandling = NullValueHandling.Ignore)]
        public TransactionsInfo? TransactionsInfo { get; set; }
    }
}
