// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-28-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="SpendBundle.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using ChiaApi.Models.Responses.Shared;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Request.FullNode
{
    /// <summary>
    /// Class SpendBundle.
    /// </summary>
    public class SpendBundle
    {
        /// <summary>
        /// Gets or sets the aggregated signature.
        /// </summary>
        /// <value>The aggregated signature.</value>
        [JsonProperty("aggregated_signature", NullValueHandling = NullValueHandling.Ignore)]
        public string AggregatedSignature { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the coin solutions.
        /// </summary>
        /// <value>The coin solutions.</value>
        [JsonProperty("coin_solutions", NullValueHandling = NullValueHandling.Ignore)]
        public List<CoinSpend>? CoinSolutions { get; set; }
    }
}