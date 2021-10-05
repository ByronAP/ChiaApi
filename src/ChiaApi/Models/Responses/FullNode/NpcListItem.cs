// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-28-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="NpcListItem.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.FullNode
{
    /// <summary>
    /// Class NpcListItem.
    /// </summary>
    public class NpcListItem
    {
        /// <summary>
        /// Gets or sets the name of the coin.
        /// </summary>
        /// <value>The name of the coin.</value>
        [JsonProperty("coin_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CoinName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the conditions.
        /// </summary>
        /// <value>The conditions.</value>
        [JsonProperty("conditions", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<ConditionUnion>>? Conditions { get; set; }

        /// <summary>
        /// Gets or sets the puzzle hash.
        /// </summary>
        /// <value>The puzzle hash.</value>
        [JsonProperty("puzzle_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string PuzzleHash { get; set; } = string.Empty;
    }
}