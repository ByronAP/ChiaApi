﻿// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 10-02-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="WalletIdResponse.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Wallet
{
    /// <summary>
    /// Class WalletIdResponse.
    /// Implements the <see cref="ChiaApi.Models.Responses.ApiResponseBase" />
    /// </summary>
    /// <seealso cref="ChiaApi.Models.Responses.ApiResponseBase" />
    public class WalletIdResponse : ApiResponseBase
    {
        /// <summary>
        /// Gets or sets the wallet identifier.
        /// </summary>
        /// <value>The wallet identifier.</value>
        [JsonProperty("wallet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WalletId { get; set; } = string.Empty;
    }
}