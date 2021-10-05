// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-28-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="Foliage.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    /// <summary>
    /// Class Foliage.
    /// </summary>
    public class Foliage
    {
        /// <summary>
        /// Gets or sets the foliage block data.
        /// </summary>
        /// <value>The foliage block data.</value>
        [JsonProperty("foliage_block_data", NullValueHandling = NullValueHandling.Ignore)]
        public FoliageBlockData? FoliageBlockData { get; set; }

        /// <summary>
        /// Gets or sets the foliage block data signature.
        /// </summary>
        /// <value>The foliage block data signature.</value>
        [JsonProperty("foliage_block_data_signature", NullValueHandling = NullValueHandling.Ignore)]
        public string FoliageBlockDataSignature { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the foliage transaction block hash.
        /// </summary>
        /// <value>The foliage transaction block hash.</value>
        [JsonProperty("foliage_transaction_block_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string FoliageTransactionBlockHash { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the foliage transaction block signature.
        /// </summary>
        /// <value>The foliage transaction block signature.</value>
        [JsonProperty("foliage_transaction_block_signature", NullValueHandling = NullValueHandling.Ignore)]
        public string FoliageTransactionBlockSignature { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the previous block hash.
        /// </summary>
        /// <value>The previous block hash.</value>
        [JsonProperty("prev_block_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string PrevBlockHash { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the reward block hash.
        /// </summary>
        /// <value>The reward block hash.</value>
        [JsonProperty("reward_block_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string RewardBlockHash { get; set; } = string.Empty;
    }
}