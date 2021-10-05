﻿// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 10-02-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="WalletBalanceResponse.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Wallet
{
    /// <summary>
    /// Class WalletBalanceResponse.
    /// Implements the <see cref="ChiaApi.Models.Responses.ApiResponseBase" />
    /// </summary>
    /// <seealso cref="ChiaApi.Models.Responses.ApiResponseBase" />
    public class WalletBalanceResponse : ApiResponseBase
    {
        /// <summary>
        /// Gets or sets the wallet balance.
        /// </summary>
        /// <value>The wallet balance.</value>
        [JsonProperty("wallet_balance", NullValueHandling = NullValueHandling.Ignore)]
        public WalletBalanceItem? WalletBalance { get; set; }
    }
}