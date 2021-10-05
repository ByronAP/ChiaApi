// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-29-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="Proofs.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    /// <summary>
    /// Class Proofs.
    /// </summary>
    public class Proofs
    {
        /// <summary>
        /// Gets or sets the challenge chain slot proof.
        /// </summary>
        /// <value>The challenge chain slot proof.</value>
        [JsonProperty("challenge_chain_slot_proof", NullValueHandling = NullValueHandling.Ignore)]
        public IpSpProof? ChallengeChainSlotProof { get; set; }

        /// <summary>
        /// Gets or sets the infused challenge chain slot proof.
        /// </summary>
        /// <value>The infused challenge chain slot proof.</value>
        [JsonProperty("infused_challenge_chain_slot_proof", NullValueHandling = NullValueHandling.Ignore)]
        public IpSpProof? InfusedChallengeChainSlotProof { get; set; }

        /// <summary>
        /// Gets or sets the reward chain slot proof.
        /// </summary>
        /// <value>The reward chain slot proof.</value>
        [JsonProperty("reward_chain_slot_proof", NullValueHandling = NullValueHandling.Ignore)]
        public IpSpProof? RewardChainSlotProof { get; set; }
    }
}