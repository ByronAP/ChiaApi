using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.FullNode
{
    public class BlockHeader
    {
        [JsonProperty("challenge_chain_sp_proof", NullValueHandling = NullValueHandling.Ignore)]
        public IpSpProof? ChallengeChainSpProof { get; set; }

        [JsonProperty("finished_sub_slots", NullValueHandling = NullValueHandling.Ignore)]
        public List<dynamic>? FinishedSubSlots { get; set; }

        [JsonProperty("foliage", NullValueHandling = NullValueHandling.Ignore)]
        public Foliage? Foliage { get; set; }

        [JsonProperty("foliage_transaction_block", NullValueHandling = NullValueHandling.Ignore)]
        public FoliageTransactionBlock? FoliageTransactionBlock { get; set; }

        [JsonProperty("reward_chain_block", NullValueHandling = NullValueHandling.Ignore)]
        public RewardChainBlock? RewardChainBlock { get; set; }

        [JsonProperty("reward_chain_sp_proof", NullValueHandling = NullValueHandling.Ignore)]
        public IpSpProof? RewardChainSpProof { get; set; }

        [JsonProperty("transactions_filter", NullValueHandling = NullValueHandling.Ignore)]
        public string TransactionsFilter { get; set; } = string.Empty;
    }
}
