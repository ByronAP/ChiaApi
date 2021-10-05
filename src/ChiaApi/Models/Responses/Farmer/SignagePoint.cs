// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 10-02-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="SignagePoint.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Farmer
{
    /// <summary>
    /// Class SignagePoint.
    /// </summary>
    public class SignagePoint
    {
        /// <summary>
        /// Gets or sets the challenge chain sp.
        /// </summary>
        /// <value>The challenge chain sp.</value>
        [JsonProperty("challenge_chain_sp", NullValueHandling = NullValueHandling.Ignore)]
        public string ChallengeChainSp { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the challenge hash.
        /// </summary>
        /// <value>The challenge hash.</value>
        [JsonProperty("challenge_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string ChallengeHash { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the difficulty.
        /// </summary>
        /// <value>The difficulty.</value>
        [JsonProperty("difficulty", NullValueHandling = NullValueHandling.Ignore)]
        public uint Difficulty { get; set; }

        /// <summary>
        /// Gets or sets the reward chain sp.
        /// </summary>
        /// <value>The reward chain sp.</value>
        [JsonProperty("reward_chain_sp", NullValueHandling = NullValueHandling.Ignore)]
        public string RewardChainSp { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the index of the signage point.
        /// </summary>
        /// <value>The index of the signage point.</value>
        [JsonProperty("signage_point_index", NullValueHandling = NullValueHandling.Ignore)]
        public uint SignagePointIndex { get; set; }

        /// <summary>
        /// Gets or sets the sub slot iters.
        /// </summary>
        /// <value>The sub slot iters.</value>
        [JsonProperty("sub_slot_iters", NullValueHandling = NullValueHandling.Ignore)]
        public ulong SubSlotIters { get; set; }
    }
}