// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-28-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="FoliageTransactionBlock.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    /// <summary>
    /// Class FoliageTransactionBlock.
    /// </summary>
    public class FoliageTransactionBlock
    {
        /// <summary>
        /// Gets or sets the additions root.
        /// </summary>
        /// <value>The additions root.</value>
        [JsonProperty("additions_root", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionsRoot { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the filter hash.
        /// </summary>
        /// <value>The filter hash.</value>
        [JsonProperty("filter_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string FilterHash { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the previous transaction block hash.
        /// </summary>
        /// <value>The previous transaction block hash.</value>
        [JsonProperty("prev_transaction_block_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string PrevTransactionBlockHash { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the removals root.
        /// </summary>
        /// <value>The removals root.</value>
        [JsonProperty("removals_root", NullValueHandling = NullValueHandling.Ignore)]
        public string RemovalsRoot { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the timestamp.
        /// </summary>
        /// <value>The timestamp.</value>
        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Timestamp { get; set; }

        /// <summary>
        /// Gets or sets the transactions information hash.
        /// </summary>
        /// <value>The transactions information hash.</value>
        [JsonProperty("transactions_info_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string TransactionsInfoHash { get; set; } = string.Empty;
    }
}