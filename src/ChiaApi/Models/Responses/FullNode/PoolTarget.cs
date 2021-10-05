// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-28-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="PoolTarget.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    /// <summary>
    /// Class PoolTarget.
    /// </summary>
    public class PoolTarget
    {
        /// <summary>
        /// Gets or sets the maximum height.
        /// </summary>
        /// <value>The maximum height.</value>
        [JsonProperty("max_height", NullValueHandling = NullValueHandling.Ignore)]
        public ulong MaxHeight { get; set; }

        /// <summary>
        /// Gets or sets the puzzle hash.
        /// </summary>
        /// <value>The puzzle hash.</value>
        [JsonProperty("puzzle_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string PuzzleHash { get; set; } = string.Empty;
    }
}