// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-28-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="Block.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.FullNode
{
    /// <summary>
    /// Class Block.
    /// </summary>
    public class Block
    {
        /// <summary>
        /// Gets or sets the challenge chain ip proof.
        /// </summary>
        /// <value>The challenge chain ip proof.</value>
        [JsonProperty("challenge_chain_ip_proof", NullValueHandling = NullValueHandling.Ignore)]
        public IpSpProof? ChallengeChainIpProof { get; set; }

        /// <summary>
        /// Gets or sets the challenge chain sp proof.
        /// </summary>
        /// <value>The challenge chain sp proof.</value>
        [JsonProperty("challenge_chain_sp_proof", NullValueHandling = NullValueHandling.Ignore)]
        public IpSpProof? ChallengeChainSpProof { get; set; }

        // TODO: create this type
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
        /// Gets or sets the header hash.
        /// </summary>
        /// <value>The header hash.</value>
        [JsonProperty("header_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string HeaderHash { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the infused challenge chain ip proof.
        /// </summary>
        /// <value>The infused challenge chain ip proof.</value>
        [JsonProperty("infused_challenge_chain_ip_proof", NullValueHandling = NullValueHandling.Ignore)]
        public IpSpProof? InfusedChallengeChainIpProof { get; set; }

        /// <summary>
        /// Gets or sets the reward chain block.
        /// </summary>
        /// <value>The reward chain block.</value>
        [JsonProperty("reward_chain_block", NullValueHandling = NullValueHandling.Ignore)]
        public RewardChainBlock? RewardChainBlock { get; set; }

        /// <summary>
        /// Gets or sets the reward chain ip proof.
        /// </summary>
        /// <value>The reward chain ip proof.</value>
        [JsonProperty("reward_chain_ip_proof", NullValueHandling = NullValueHandling.Ignore)]
        public IpSpProof? RewardChainIpProof { get; set; }

        /// <summary>
        /// Gets or sets the reward chain sp proof.
        /// </summary>
        /// <value>The reward chain sp proof.</value>
        [JsonProperty("reward_chain_sp_proof", NullValueHandling = NullValueHandling.Ignore)]
        public IpSpProof? RewardChainSpProof { get; set; }

        /// <summary>
        /// Gets or sets the transactions generator.
        /// </summary>
        /// <value>The transactions generator.</value>
        [JsonProperty("transactions_generator", NullValueHandling = NullValueHandling.Ignore)]
        public string TransactionsGenerator { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the transactions generator reference list.
        /// </summary>
        /// <value>The transactions generator reference list.</value>
        [JsonProperty("transactions_generator_ref_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ulong>? TransactionsGeneratorRefList { get; set; }

        /// <summary>
        /// Gets or sets the transactions information.
        /// </summary>
        /// <value>The transactions information.</value>
        [JsonProperty("transactions_info", NullValueHandling = NullValueHandling.Ignore)]
        public TransactionsInfo? TransactionsInfo { get; set; }
    }
}