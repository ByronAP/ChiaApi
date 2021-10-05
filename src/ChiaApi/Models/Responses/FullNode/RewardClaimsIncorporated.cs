﻿// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-28-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="RewardClaimsIncorporated.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    /// <summary>
    /// Class RewardClaimsIncorporated.
    /// </summary>
    public class RewardClaimsIncorporated
    {
        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>The amount.</value>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Amount { get; set; }

        /// <summary>
        /// Gets or sets the parent coin information.
        /// </summary>
        /// <value>The parent coin information.</value>
        [JsonProperty("parent_coin_info", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentCoinInfo { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the puzzle hash.
        /// </summary>
        /// <value>The puzzle hash.</value>
        [JsonProperty("puzzle_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string PuzzleHash { get; set; } = string.Empty;
    }
}