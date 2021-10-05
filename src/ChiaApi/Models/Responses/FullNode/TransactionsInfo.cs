// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-28-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="TransactionsInfo.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.FullNode
{
    /// <summary>
    /// Class TransactionsInfo.
    /// </summary>
    public class TransactionsInfo
    {
        /// <summary>
        /// Gets or sets the aggregated signature.
        /// </summary>
        /// <value>The aggregated signature.</value>
        [JsonProperty("aggregated_signature", NullValueHandling = NullValueHandling.Ignore)]
        public string AggregatedSignature { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the cost.
        /// </summary>
        /// <value>The cost.</value>
        [JsonProperty("cost", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Cost { get; set; }

        /// <summary>
        /// Gets or sets the fees.
        /// </summary>
        /// <value>The fees.</value>
        [JsonProperty("fees", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Fees { get; set; }

        /// <summary>
        /// Gets or sets the generator refs root.
        /// </summary>
        /// <value>The generator refs root.</value>
        [JsonProperty("generator_refs_root", NullValueHandling = NullValueHandling.Ignore)]
        public string GeneratorRefsRoot { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the generator root.
        /// </summary>
        /// <value>The generator root.</value>
        [JsonProperty("generator_root", NullValueHandling = NullValueHandling.Ignore)]
        public string GeneratorRoot { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the reward claims incorporated.
        /// </summary>
        /// <value>The reward claims incorporated.</value>
        [JsonProperty("reward_claims_incorporated", NullValueHandling = NullValueHandling.Ignore)]
        public List<RewardClaimsIncorporated>? RewardClaimsIncorporated { get; set; }
    }
}