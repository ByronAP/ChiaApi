// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-28-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="RewardChainBlock.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System.Numerics;

namespace ChiaApi.Models.Responses.FullNode
{
    /// <summary>
    /// Class RewardChainBlock.
    /// </summary>
    public class RewardChainBlock
    {
        /// <summary>
        /// Gets or sets the challenge chain ip VDF.
        /// </summary>
        /// <value>The challenge chain ip VDF.</value>
        [JsonProperty("challenge_chain_ip_vdf", NullValueHandling = NullValueHandling.Ignore)]
        public IpSpVdf? ChallengeChainIpVdf { get; set; }

        /// <summary>
        /// Gets or sets the challenge chain sp signature.
        /// </summary>
        /// <value>The challenge chain sp signature.</value>
        [JsonProperty("challenge_chain_sp_signature", NullValueHandling = NullValueHandling.Ignore)]
        public string ChallengeChainSpSignature { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the challenge chain sp VDF.
        /// </summary>
        /// <value>The challenge chain sp VDF.</value>
        [JsonProperty("challenge_chain_sp_vdf", NullValueHandling = NullValueHandling.Ignore)]
        public IpSpVdf? ChallengeChainSpVdf { get; set; }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>The height.</value>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Height { get; set; }

        /// <summary>
        /// Gets or sets the infused challenge chain ip VDF.
        /// </summary>
        /// <value>The infused challenge chain ip VDF.</value>
        [JsonProperty("infused_challenge_chain_ip_vdf", NullValueHandling = NullValueHandling.Ignore)]
        public IpSpVdf? InfusedChallengeChainIpVdf { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is transaction block.
        /// </summary>
        /// <value><c>true</c> if this instance is transaction block; otherwise, <c>false</c>.</value>
        [JsonProperty("is_transaction_block", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsTransactionBlock { get; set; }

        /// <summary>
        /// Gets or sets the position ss cc challenge hash.
        /// </summary>
        /// <value>The position ss cc challenge hash.</value>
        [JsonProperty("pos_ss_cc_challenge_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string PosSsCcChallengeHash { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the proof of space.
        /// </summary>
        /// <value>The proof of space.</value>
        [JsonProperty("proof_of_space", NullValueHandling = NullValueHandling.Ignore)]
        public ProofOfSpace? ProofOfSpace { get; set; }

        /// <summary>
        /// Gets or sets the reward chain ip VDF.
        /// </summary>
        /// <value>The reward chain ip VDF.</value>
        [JsonProperty("reward_chain_ip_vdf", NullValueHandling = NullValueHandling.Ignore)]
        public IpSpVdf? RewardChainIpVdf { get; set; }

        /// <summary>
        /// Gets or sets the reward chain sp signature.
        /// </summary>
        /// <value>The reward chain sp signature.</value>
        [JsonProperty("reward_chain_sp_signature", NullValueHandling = NullValueHandling.Ignore)]
        public string RewardChainSpSignature { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the reward chain sp VDF.
        /// </summary>
        /// <value>The reward chain sp VDF.</value>
        [JsonProperty("reward_chain_sp_vdf", NullValueHandling = NullValueHandling.Ignore)]
        public IpSpVdf? RewardChainSpVdf { get; set; }

        /// <summary>
        /// Gets or sets the index of the signage point.
        /// </summary>
        /// <value>The index of the signage point.</value>
        [JsonProperty("signage_point_index", NullValueHandling = NullValueHandling.Ignore)]
        public uint SignagePointIndex { get; set; }

        /// <summary>
        /// Gets or sets the total iters.
        /// </summary>
        /// <value>The total iters.</value>
        [JsonProperty("total_iters", NullValueHandling = NullValueHandling.Ignore)]
        public BigInteger TotalIters { get; set; }

        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>The weight.</value>
        [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Weight { get; set; }
    }
}