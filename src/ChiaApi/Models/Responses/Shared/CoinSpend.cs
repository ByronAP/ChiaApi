// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 10-02-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="CoinSpend.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Shared
{
    /// <summary>
    /// Class CoinSpend.
    /// </summary>
    public class CoinSpend
    {
        /// <summary>
        /// Gets or sets the coin.
        /// </summary>
        /// <value>The coin.</value>
        [JsonProperty("coin", NullValueHandling = NullValueHandling.Ignore)]
        public CoinItem? Coin { get; set; }

        /// <summary>
        /// Gets or sets the puzzle reveal.
        /// </summary>
        /// <value>The puzzle reveal.</value>
        [JsonProperty("puzzle_reveal", NullValueHandling = NullValueHandling.Ignore)]
        public string PuzzleReveal { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the solution.
        /// </summary>
        /// <value>The solution.</value>
        [JsonProperty("solution", NullValueHandling = NullValueHandling.Ignore)]
        public string Solution { get; set; } = string.Empty;
    }
}