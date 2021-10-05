// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-28-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="BlockHeader.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.FullNode
{
    /// <summary>
    /// Class BlockHeader.
    /// </summary>
    public class BlockHeader
    {
        /// <summary>
        /// Gets or sets the challenge chain sp proof.
        /// </summary>
        /// <value>The challenge chain sp proof.</value>
        [JsonProperty("challenge_chain_sp_proof", NullValueHandling = NullValueHandling.Ignore)]
        public IpSpProof? ChallengeChainSpProof { get; set; }

        /// <summary>
        /// Gets or sets the finished sub slots.
        /// </summary>
        /// <value>The finished sub slots.</value>
        [JsonProperty("finished_sub_slots", NullValueHandling = NullValueHandling.Ignore)]
        public List<dynamic>? FinishedSubSlots { get; set; }

        /// <summary>
        /// Gets or sets the foliage.
        /// </summary>
        /// <value>The foliage.</value>
        [JsonProperty("foliage", NullValueHandling = NullValueHandling.Ignore)]
        public Foliage? Foliage { get; set; }

        /// <summary>
        /// Gets or sets the foliage transaction block.
        /// </summary>
        /// <value>The foliage transaction block.</value>
        [JsonProperty("foliage_transaction_block", NullValueHandling = NullValueHandling.Ignore)]
        public FoliageTransactionBlock? FoliageTransactionBlock { get; set; }

        /// <summary>
        /// Gets or sets the reward chain block.
        /// </summary>
        /// <value>The reward chain block.</value>
        [JsonProperty("reward_chain_block", NullValueHandling = NullValueHandling.Ignore)]
        public RewardChainBlock? RewardChainBlock { get; set; }

        /// <summary>
        /// Gets or sets the reward chain sp proof.
        /// </summary>
        /// <value>The reward chain sp proof.</value>
        [JsonProperty("reward_chain_sp_proof", NullValueHandling = NullValueHandling.Ignore)]
        public IpSpProof? RewardChainSpProof { get; set; }

        /// <summary>
        /// Gets or sets the transactions filter.
        /// </summary>
        /// <value>The transactions filter.</value>
        [JsonProperty("transactions_filter", NullValueHandling = NullValueHandling.Ignore)]
        public string TransactionsFilter { get; set; } = string.Empty;
    }
}