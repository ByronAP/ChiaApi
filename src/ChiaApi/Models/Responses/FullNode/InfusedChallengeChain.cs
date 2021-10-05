// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-29-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="InfusedChallengeChain.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    /// <summary>
    /// Class InfusedChallengeChain.
    /// </summary>
    public class InfusedChallengeChain
    {
        /// <summary>
        /// Gets or sets the infused challenge chain end of slot VDF.
        /// </summary>
        /// <value>The infused challenge chain end of slot VDF.</value>
        [JsonProperty("infused_challenge_chain_end_of_slot_vdf", NullValueHandling = NullValueHandling.Ignore)]
        public IpSpVdf? InfusedChallengeChainEndOfSlotVdf { get; set; }
    }
}