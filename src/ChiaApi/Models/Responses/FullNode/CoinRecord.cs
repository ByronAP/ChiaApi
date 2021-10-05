// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-28-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="CoinRecord.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using ChiaApi.Models.Responses.Shared;
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    /// <summary>
    /// Class CoinRecord.
    /// </summary>
    public class CoinRecord
    {
        /// <summary>
        /// Gets or sets the coin.
        /// </summary>
        /// <value>The coin.</value>
        [JsonProperty("coin", NullValueHandling = NullValueHandling.Ignore)]
        public CoinItem? Coin { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CoinRecord"/> is coinbase.
        /// </summary>
        /// <value><c>true</c> if coinbase; otherwise, <c>false</c>.</value>
        [JsonProperty("coinbase", NullValueHandling = NullValueHandling.Ignore)]
        public bool Coinbase { get; set; }

        /// <summary>
        /// Gets or sets the index of the confirmed block.
        /// </summary>
        /// <value>The index of the confirmed block.</value>
        [JsonProperty("confirmed_block_index", NullValueHandling = NullValueHandling.Ignore)]
        public uint ConfirmedBlockIndex { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CoinRecord"/> is spent.
        /// </summary>
        /// <value><c>true</c> if spent; otherwise, <c>false</c>.</value>
        [JsonProperty("spent", NullValueHandling = NullValueHandling.Ignore)]
        public bool Spent { get; set; }

        /// <summary>
        /// Gets or sets the index of the spent block.
        /// </summary>
        /// <value>The index of the spent block.</value>
        [JsonProperty("spent_block_index", NullValueHandling = NullValueHandling.Ignore)]
        public uint SpentBlockIndex { get; set; }

        /// <summary>
        /// Gets or sets the timestamp.
        /// </summary>
        /// <value>The timestamp.</value>
        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Timestamp { get; set; }
    }
}