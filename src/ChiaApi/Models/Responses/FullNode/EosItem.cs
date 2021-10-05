// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-29-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="EosItem.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    /// <summary>
    /// Class EosItem.
    /// </summary>
    public class EosItem
    {
        /// <summary>
        /// Gets or sets the challenge chain.
        /// </summary>
        /// <value>The challenge chain.</value>
        [JsonProperty("challenge_chain", NullValueHandling = NullValueHandling.Ignore)]
        public ChallengeChain? ChallengeChain { get; set; }

        /// <summary>
        /// Gets or sets the infused challenge chain.
        /// </summary>
        /// <value>The infused challenge chain.</value>
        [JsonProperty("infused_challenge_chain", NullValueHandling = NullValueHandling.Ignore)]
        public InfusedChallengeChain? InfusedChallengeChain { get; set; }

        /// <summary>
        /// Gets or sets the proofs.
        /// </summary>
        /// <value>The proofs.</value>
        [JsonProperty("proofs", NullValueHandling = NullValueHandling.Ignore)]
        public Proofs? Proofs { get; set; }

        /// <summary>
        /// Gets or sets the reward chain.
        /// </summary>
        /// <value>The reward chain.</value>
        [JsonProperty("reward_chain", NullValueHandling = NullValueHandling.Ignore)]
        public RewardChain? RewardChain { get; set; }
    }
}