// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-29-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="RewardChain.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    /// <summary>
    /// Class RewardChain.
    /// </summary>
    public class RewardChain
    {
        /// <summary>
        /// Gets or sets the challenge chain sub slot hash.
        /// </summary>
        /// <value>The challenge chain sub slot hash.</value>
        [JsonProperty("challenge_chain_sub_slot_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string ChallengeChainSubSlotHash { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the deficit.
        /// </summary>
        /// <value>The deficit.</value>
        [JsonProperty("deficit", NullValueHandling = NullValueHandling.Ignore)]
        public uint Deficit { get; set; }

        /// <summary>
        /// Gets or sets the end of slot VDF.
        /// </summary>
        /// <value>The end of slot VDF.</value>
        [JsonProperty("end_of_slot_vdf", NullValueHandling = NullValueHandling.Ignore)]
        public IpSpVdf? EndOfSlotVdf { get; set; }

        /// <summary>
        /// Gets or sets the infused challenge chain sub slot hash.
        /// </summary>
        /// <value>The infused challenge chain sub slot hash.</value>
        [JsonProperty("infused_challenge_chain_sub_slot_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string InfusedChallengeChainSubSlotHash { get; set; } = string.Empty;
    }
}