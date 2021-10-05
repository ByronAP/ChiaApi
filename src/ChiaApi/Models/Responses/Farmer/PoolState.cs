// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 10-02-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="PoolState.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.Farmer
{
    /// <summary>
    /// Class PoolState.
    /// </summary>
    public class PoolState
    {
        /// <summary>
        /// Gets or sets the authentication token timeout.
        /// </summary>
        /// <value>The authentication token timeout.</value>
        [JsonProperty("authentication_token_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public uint AuthenticationTokenTimeout { get; set; }

        /// <summary>
        /// Gets or sets the current difficulty.
        /// </summary>
        /// <value>The current difficulty.</value>
        [JsonProperty("current_difficulty", NullValueHandling = NullValueHandling.Ignore)]
        public uint CurrentDifficulty { get; set; }

        /// <summary>
        /// Gets or sets the current points.
        /// </summary>
        /// <value>The current points.</value>
        [JsonProperty("current_points", NullValueHandling = NullValueHandling.Ignore)]
        public uint CurrentPoints { get; set; }

        /// <summary>
        /// Gets or sets the next farmer update.
        /// </summary>
        /// <value>The next farmer update.</value>
        [JsonProperty("next_farmer_update", NullValueHandling = NullValueHandling.Ignore)]
        public decimal NextFarmerUpdate { get; set; }

        /// <summary>
        /// Gets or sets the next pool information update.
        /// </summary>
        /// <value>The next pool information update.</value>
        [JsonProperty("next_pool_info_update", NullValueHandling = NullValueHandling.Ignore)]
        public decimal NextPoolInfoUpdate { get; set; }

        /// <summary>
        /// Gets or sets the p2 singleton puzzle hash.
        /// </summary>
        /// <value>The p2 singleton puzzle hash.</value>
        [JsonProperty("p2_singleton_puzzle_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string P2SingletonPuzzleHash { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the points acknowledged24 h.
        /// </summary>
        /// <value>The points acknowledged24 h.</value>
        [JsonProperty("points_acknowledged_24h", NullValueHandling = NullValueHandling.Ignore)]
        public List<dynamic>? PointsAcknowledged24H { get; set; }

        /// <summary>
        /// Gets or sets the points acknowledged since start.
        /// </summary>
        /// <value>The points acknowledged since start.</value>
        [JsonProperty("points_acknowledged_since_start", NullValueHandling = NullValueHandling.Ignore)]
        public ulong PointsAcknowledgedSinceStart { get; set; }

        /// <summary>
        /// Gets or sets the points found24 h.
        /// </summary>
        /// <value>The points found24 h.</value>
        [JsonProperty("points_found_24h", NullValueHandling = NullValueHandling.Ignore)]
        public List<dynamic>? PointsFound24H { get; set; }

        /// <summary>
        /// Gets or sets the points found since start.
        /// </summary>
        /// <value>The points found since start.</value>
        [JsonProperty("points_found_since_start", NullValueHandling = NullValueHandling.Ignore)]
        public ulong PointsFoundSinceStart { get; set; }

        /// <summary>
        /// Gets or sets the pool configuration.
        /// </summary>
        /// <value>The pool configuration.</value>
        [JsonProperty("pool_config", NullValueHandling = NullValueHandling.Ignore)]
        public PoolConfig? PoolConfig { get; set; }

        /// <summary>
        /// Gets or sets the pool errors24 h.
        /// </summary>
        /// <value>The pool errors24 h.</value>
        [JsonProperty("pool_errors_24h", NullValueHandling = NullValueHandling.Ignore)]
        public List<dynamic>? PoolErrors24H { get; set; }
    }
}