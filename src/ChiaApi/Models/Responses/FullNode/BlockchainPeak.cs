// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-28-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="BlockchainPeak.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.FullNode
{
    /// <summary>
    /// Class BlockchainPeak.
    /// </summary>
    public class BlockchainPeak
    {
        /// <summary>
        /// Gets or sets the challenge block information hash.
        /// </summary>
        /// <value>The challenge block information hash.</value>
        [JsonProperty("challenge_block_info_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string ChallengeBlockInfoHash { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the challenge VDF output.
        /// </summary>
        /// <value>The challenge VDF output.</value>
        [JsonProperty("challenge_vdf_output", NullValueHandling = NullValueHandling.Ignore)]
        public ChallengeVdfOutput? ChallengeVdfOutput { get; set; }

        /// <summary>
        /// Gets or sets the deficit.
        /// </summary>
        /// <value>The deficit.</value>
        [JsonProperty("deficit", NullValueHandling = NullValueHandling.Ignore)]
        public uint Deficit { get; set; }

        /// <summary>
        /// Gets or sets the farmer puzzle hash.
        /// </summary>
        /// <value>The farmer puzzle hash.</value>
        [JsonProperty("farmer_puzzle_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string? FarmerPuzzleHash { get; set; }

        /// <summary>
        /// Gets or sets the fees.
        /// </summary>
        /// <value>The fees.</value>
        [JsonProperty("fees", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Fees { get; set; }

        /// <summary>
        /// Gets or sets the finished challenge slot hashes.
        /// </summary>
        /// <value>The finished challenge slot hashes.</value>
        [JsonProperty("finished_challenge_slot_hashes", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic? FinishedChallengeSlotHashes { get; set; }

        /// <summary>
        /// Gets or sets the finished infused challenge slot hashes.
        /// </summary>
        /// <value>The finished infused challenge slot hashes.</value>
        [JsonProperty("finished_infused_challenge_slot_hashes", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic? FinishedInfusedChallengeSlotHashes { get; set; }

        /// <summary>
        /// Gets or sets the finished reward slot hashes.
        /// </summary>
        /// <value>The finished reward slot hashes.</value>
        [JsonProperty("finished_reward_slot_hashes", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic? FinishedRewardSlotHashes { get; set; }

        /// <summary>
        /// Gets or sets the header hash.
        /// </summary>
        /// <value>The header hash.</value>
        [JsonProperty("header_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string HeaderHash { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>The height.</value>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Height { get; set; }

        /// <summary>
        /// Gets or sets the infused challenge VDF output.
        /// </summary>
        /// <value>The infused challenge VDF output.</value>
        [JsonProperty("infused_challenge_vdf_output", NullValueHandling = NullValueHandling.Ignore)]
        public ChallengeVdfOutput? InfusedChallengeVdfOutput { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="BlockchainPeak"/> is overflow.
        /// </summary>
        /// <value><c>true</c> if overflow; otherwise, <c>false</c>.</value>
        [JsonProperty("overflow", NullValueHandling = NullValueHandling.Ignore)]
        public bool Overflow { get; set; }

        /// <summary>
        /// Gets or sets the pool puzzle hash.
        /// </summary>
        /// <value>The pool puzzle hash.</value>
        [JsonProperty("pool_puzzle_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolPuzzleHash { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the previous hash.
        /// </summary>
        /// <value>The previous hash.</value>
        [JsonProperty("prev_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string PrevHash { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the previous transaction block hash.
        /// </summary>
        /// <value>The previous transaction block hash.</value>
        [JsonProperty("prev_transaction_block_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string PrevTransactionBlockHash { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the height of the previous transaction block.
        /// </summary>
        /// <value>The height of the previous transaction block.</value>
        [JsonProperty("prev_transaction_block_height", NullValueHandling = NullValueHandling.Ignore)]
        public ulong PrevTransactionBlockHeight { get; set; }

        /// <summary>
        /// Gets or sets the required iters.
        /// </summary>
        /// <value>The required iters.</value>
        [JsonProperty("required_iters", NullValueHandling = NullValueHandling.Ignore)]
        public ulong RequiredIters { get; set; }

        /// <summary>
        /// Gets or sets the reward claims incorporated.
        /// </summary>
        /// <value>The reward claims incorporated.</value>
        [JsonProperty("reward_claims_incorporated", NullValueHandling = NullValueHandling.Ignore)]
        public List<RewardClaimsIncorporated>? RewardClaimsIncorporated { get; set; }

        /// <summary>
        /// Gets or sets the reward infusion new challenge.
        /// </summary>
        /// <value>The reward infusion new challenge.</value>
        [JsonProperty("reward_infusion_new_challenge", NullValueHandling = NullValueHandling.Ignore)]
        public string RewardInfusionNewChallenge { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the index of the signage point.
        /// </summary>
        /// <value>The index of the signage point.</value>
        [JsonProperty("signage_point_index", NullValueHandling = NullValueHandling.Ignore)]
        public uint SignagePointIndex { get; set; }

        /// <summary>
        /// Gets or sets the sub epoch summary included.
        /// </summary>
        /// <value>The sub epoch summary included.</value>
        [JsonProperty("sub_epoch_summary_included", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic? SubEpochSummaryIncluded { get; set; }

        /// <summary>
        /// Gets or sets the sub slot iters.
        /// </summary>
        /// <value>The sub slot iters.</value>
        [JsonProperty("sub_slot_iters", NullValueHandling = NullValueHandling.Ignore)]
        public ulong SubSlotIters { get; set; }

        /// <summary>
        /// Gets or sets the timestamp.
        /// </summary>
        /// <value>The timestamp.</value>
        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Timestamp { get; set; }

        /// <summary>
        /// Gets or sets the total iters.
        /// </summary>
        /// <value>The total iters.</value>
        [JsonProperty("total_iters", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TotalIters { get; set; }

        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>The weight.</value>
        [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Weight { get; set; }
    }
}