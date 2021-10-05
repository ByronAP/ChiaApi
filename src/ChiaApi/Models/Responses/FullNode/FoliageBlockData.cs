// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-28-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="FoliageBlockData.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    /// <summary>
    /// Class FoliageBlockData.
    /// </summary>
    public class FoliageBlockData
    {
        /// <summary>
        /// Gets or sets the extension data.
        /// </summary>
        /// <value>The extension data.</value>
        [JsonProperty("extension_data", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtensionData { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the farmer reward puzzle hash.
        /// </summary>
        /// <value>The farmer reward puzzle hash.</value>
        [JsonProperty("farmer_reward_puzzle_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string FarmerRewardPuzzleHash { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the pool signature.
        /// </summary>
        /// <value>The pool signature.</value>
        [JsonProperty("pool_signature", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolSignature { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the pool target.
        /// </summary>
        /// <value>The pool target.</value>
        [JsonProperty("pool_target", NullValueHandling = NullValueHandling.Ignore)]
        public PoolTarget? PoolTarget { get; set; }

        /// <summary>
        /// Gets or sets the unfinished reward block hash.
        /// </summary>
        /// <value>The unfinished reward block hash.</value>
        [JsonProperty("unfinished_reward_block_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string UnfinishedRewardBlockHash { get; set; } = string.Empty;
    }
}