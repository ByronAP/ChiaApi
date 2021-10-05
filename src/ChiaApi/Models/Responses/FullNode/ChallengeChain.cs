// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-29-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="ChallengeChain.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    /// <summary>
    /// Class ChallengeChain.
    /// </summary>
    public class ChallengeChain
    {
        /// <summary>
        /// Gets or sets the challenge chain end of slot VDF.
        /// </summary>
        /// <value>The challenge chain end of slot VDF.</value>
        [JsonProperty("challenge_chain_end_of_slot_vdf", NullValueHandling = NullValueHandling.Ignore)]
        public IpSpVdf? ChallengeChainEndOfSlotVdf { get; set; }

        /// <summary>
        /// Gets or sets the infused challenge chain sub slot hash.
        /// </summary>
        /// <value>The infused challenge chain sub slot hash.</value>
        [JsonProperty("infused_challenge_chain_sub_slot_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string InfusedChallengeChainSubSlotHash { get; set; } = string.Empty;

        /// <summary>
        /// Creates new difficulty.
        /// </summary>
        /// <value>The new difficulty.</value>
        [JsonProperty("new_difficulty", NullValueHandling = NullValueHandling.Ignore)]
        public uint NewDifficulty { get; set; }

        /// <summary>
        /// Creates new subslotiters.
        /// </summary>
        /// <value>The new sub slot iters.</value>
        [JsonProperty("new_sub_slot_iters", NullValueHandling = NullValueHandling.Ignore)]
        public ulong NewSubSlotIters { get; set; }

        /// <summary>
        /// Gets or sets the subepoch summary hash.
        /// </summary>
        /// <value>The subepoch summary hash.</value>
        [JsonProperty("subepoch_summary_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string SubepochSummaryHash { get; set; } = string.Empty;
    }
}