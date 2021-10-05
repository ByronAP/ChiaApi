// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 10-02-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="TransactionItem.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using ChiaApi.Models.Responses.Shared;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.Wallet
{
    /// <summary>
    /// Class TransactionItem.
    /// </summary>
    public class TransactionItem
    {
        /// <summary>
        /// Gets or sets the additions.
        /// </summary>
        /// <value>The additions.</value>
        [JsonProperty("additions", NullValueHandling = NullValueHandling.Ignore)]
        public List<CoinItem>? Additions { get; set; }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>The amount.</value>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Amount { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="TransactionItem"/> is confirmed.
        /// </summary>
        /// <value><c>true</c> if confirmed; otherwise, <c>false</c>.</value>
        [JsonProperty("confirmed", NullValueHandling = NullValueHandling.Ignore)]
        public bool Confirmed { get; set; }

        /// <summary>
        /// Gets or sets the height of the confirmed at.
        /// </summary>
        /// <value>The height of the confirmed at.</value>
        [JsonProperty("confirmed_at_height", NullValueHandling = NullValueHandling.Ignore)]
        public ulong ConfirmedAtHeight { get; set; }

        /// <summary>
        /// Gets or sets the created at time.
        /// </summary>
        /// <value>The created at time.</value>
        [JsonProperty("created_at_time", NullValueHandling = NullValueHandling.Ignore)]
        public ulong CreatedAtTime { get; set; }

        /// <summary>
        /// Gets or sets the fee amount.
        /// </summary>
        /// <value>The fee amount.</value>
        [JsonProperty("fee_amount", NullValueHandling = NullValueHandling.Ignore)]
        public ulong FeeAmount { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the removals.
        /// </summary>
        /// <value>The removals.</value>
        [JsonProperty("removals", NullValueHandling = NullValueHandling.Ignore)]
        public List<CoinItem>? Removals { get; set; }

        /// <summary>
        /// Gets or sets the sent.
        /// </summary>
        /// <value>The sent.</value>
        [JsonProperty("sent", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Sent { get; set; }

        /// <summary>
        /// Gets or sets the sent to.
        /// </summary>
        /// <value>The sent to.</value>
        [JsonProperty("sent_to", NullValueHandling = NullValueHandling.Ignore)]
        public List<dynamic>? SentTo { get; set; }

        /// <summary>
        /// Gets or sets the spend bundle.
        /// </summary>
        /// <value>The spend bundle.</value>
        [JsonProperty("spend_bundle", NullValueHandling = NullValueHandling.Ignore)]
        public SpendBundle? SpendBundle { get; set; }

        /// <summary>
        /// Converts to puzzlehash.
        /// </summary>
        /// <value>To puzzle hash.</value>
        [JsonProperty("to_puzzle_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string ToPuzzleHash { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the trade identifier.
        /// </summary>
        /// <value>The trade identifier.</value>
        [JsonProperty("trade_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public uint Type { get; set; }

        /// <summary>
        /// Gets or sets the wallet identifier.
        /// </summary>
        /// <value>The wallet identifier.</value>
        [JsonProperty("wallet_id", NullValueHandling = NullValueHandling.Ignore)]
        public uint WalletId { get; set; }
    }
}