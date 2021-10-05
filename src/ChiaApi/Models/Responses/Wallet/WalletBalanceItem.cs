// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 10-02-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="WalletBalanceItem.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Wallet
{
    /// <summary>
    /// Class WalletBalanceItem.
    /// </summary>
    public class WalletBalanceItem
    {
        /// <summary>
        /// Gets or sets the confirmed wallet balance.
        /// </summary>
        /// <value>The confirmed wallet balance.</value>
        [JsonProperty("confirmed_wallet_balance", NullValueHandling = NullValueHandling.Ignore)]
        public ulong ConfirmedWalletBalance { get; set; }

        /// <summary>
        /// Gets or sets the maximum send amount.
        /// </summary>
        /// <value>The maximum send amount.</value>
        [JsonProperty("max_send_amount", NullValueHandling = NullValueHandling.Ignore)]
        public ulong MaxSendAmount { get; set; }

        /// <summary>
        /// Gets or sets the pending change.
        /// </summary>
        /// <value>The pending change.</value>
        [JsonProperty("pending_change", NullValueHandling = NullValueHandling.Ignore)]
        public ulong PendingChange { get; set; }

        /// <summary>
        /// Gets or sets the pending coin removal count.
        /// </summary>
        /// <value>The pending coin removal count.</value>
        [JsonProperty("pending_coin_removal_count", NullValueHandling = NullValueHandling.Ignore)]
        public ulong PendingCoinRemovalCount { get; set; }

        /// <summary>
        /// Gets or sets the spendable balance.
        /// </summary>
        /// <value>The spendable balance.</value>
        [JsonProperty("spendable_balance", NullValueHandling = NullValueHandling.Ignore)]
        public ulong SpendableBalance { get; set; }

        /// <summary>
        /// Gets or sets the unconfirmed wallet balance.
        /// </summary>
        /// <value>The unconfirmed wallet balance.</value>
        [JsonProperty("unconfirmed_wallet_balance", NullValueHandling = NullValueHandling.Ignore)]
        public ulong UnconfirmedWalletBalance { get; set; }

        /// <summary>
        /// Gets or sets the unspent coin count.
        /// </summary>
        /// <value>The unspent coin count.</value>
        [JsonProperty("unspent_coin_count", NullValueHandling = NullValueHandling.Ignore)]
        public uint UnspentCoinCount { get; set; }

        /// <summary>
        /// Gets or sets the wallet identifier.
        /// </summary>
        /// <value>The wallet identifier.</value>
        [JsonProperty("wallet_id", NullValueHandling = NullValueHandling.Ignore)]
        public uint WalletId { get; set; }
    }
}