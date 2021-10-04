using Newtonsoft.Json;
using System.Collections.Generic;
using System.Numerics;

namespace ChiaApi.Models.Responses.FullNode
{
    public class BlockRecord
    {
        [JsonProperty("challenge_block_info_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string ChallengeBlockInfoHash { get; set; } = string.Empty;

        [JsonProperty("challenge_vdf_output", NullValueHandling = NullValueHandling.Ignore)]
        public ChallengeVdfOutput? ChallengeVdfOutput { get; set; }

        [JsonProperty("deficit", NullValueHandling = NullValueHandling.Ignore)]
        public uint Deficit { get; set; }

        [JsonProperty("farmer_puzzle_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string FarmerPuzzleHash { get; set; } = string.Empty;

        [JsonProperty("fees", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Fees { get; set; }

        [JsonProperty("finished_challenge_slot_hashes", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic? FinishedChallengeSlotHashes { get; set; }

        [JsonProperty("finished_infused_challenge_slot_hashes", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic? FinishedInfusedChallengeSlotHashes { get; set; }

        [JsonProperty("finished_reward_slot_hashes", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic? FinishedRewardSlotHashes { get; set; }

        [JsonProperty("header_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string HeaderHash { get; set; } = string.Empty;

        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Height { get; set; }

        [JsonProperty("infused_challenge_vdf_output", NullValueHandling = NullValueHandling.Ignore)]
        public ChallengeVdfOutput? InfusedChallengeVdfOutput { get; set; }

        [JsonProperty("overflow", NullValueHandling = NullValueHandling.Ignore)]
        public bool Overflow { get; set; }

        [JsonProperty("pool_puzzle_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolPuzzleHash { get; set; } = string.Empty;

        [JsonProperty("prev_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string PrevHash { get; set; } = string.Empty;

        [JsonProperty("prev_transaction_block_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string PrevTransactionBlockHash { get; set; } = string.Empty;

        [JsonProperty("prev_transaction_block_height", NullValueHandling = NullValueHandling.Ignore)]
        public ulong PrevTransactionBlockHeight { get; set; }

        [JsonProperty("required_iters", NullValueHandling = NullValueHandling.Ignore)]
        public ulong RequiredIters { get; set; }

        [JsonProperty("reward_claims_incorporated", NullValueHandling = NullValueHandling.Ignore)]
        public List<RewardClaimsIncorporated>? RewardClaimsIncorporated { get; set; }

        [JsonProperty("reward_infusion_new_challenge", NullValueHandling = NullValueHandling.Ignore)]
        public string RewardInfusionNewChallenge { get; set; } = string.Empty;

        [JsonProperty("signage_point_index", NullValueHandling = NullValueHandling.Ignore)]
        public uint SignagePointIndex { get; set; }

        [JsonProperty("sub_epoch_summary_included", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic? SubEpochSummaryIncluded { get; set; }

        [JsonProperty("sub_slot_iters", NullValueHandling = NullValueHandling.Ignore)]
        public ulong SubSlotIters { get; set; }

        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Timestamp { get; set; }

        [JsonProperty("total_iters", NullValueHandling = NullValueHandling.Ignore)]
        public BigInteger TotalIters { get; set; }

        [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Weight { get; set; }
    }
}