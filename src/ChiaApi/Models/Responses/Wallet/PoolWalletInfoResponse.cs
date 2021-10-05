// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 10-02-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="PoolWalletInfoResponse.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.Wallet
{
    /// <summary>
    /// Class PoolWalletInfoResponse.
    /// Implements the <see cref="ChiaApi.Models.Responses.ApiResponseBase" />
    /// </summary>
    /// <seealso cref="ChiaApi.Models.Responses.ApiResponseBase" />
    public class PoolWalletInfoResponse : ApiResponseBase
    {
        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>The state.</value>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public PoolWalletState? State { get; set; }

        /// <summary>
        /// Gets or sets the unconfirmed transactions.
        /// </summary>
        /// <value>The unconfirmed transactions.</value>
        [JsonProperty("unconfirmed_transactions", NullValueHandling = NullValueHandling.Ignore)]
        public List<TransactionItem>? UnconfirmedTransactions { get; set; }
    }
}