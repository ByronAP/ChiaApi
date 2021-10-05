// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 10-02-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="SpendBundle.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.Shared
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
        /// Gets or sets the coin spends.
        /// </summary>
        /// <value>The coin spends.</value>
        [JsonProperty("coin_spends", NullValueHandling = NullValueHandling.Ignore)]
        public List<CoinSpend>? CoinSpends { get; set; }
    }
}