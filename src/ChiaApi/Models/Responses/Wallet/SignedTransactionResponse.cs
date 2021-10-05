// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 10-02-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="SignedTransactionResponse.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Wallet
{
    /// <summary>
    /// Class SignedTransactionResponse.
    /// Implements the <see cref="ChiaApi.Models.Responses.ApiResponseBase" />
    /// </summary>
    /// <seealso cref="ChiaApi.Models.Responses.ApiResponseBase" />
    public class SignedTransactionResponse : ApiResponseBase
    {
        /// <summary>
        /// Gets or sets the signed tx.
        /// </summary>
        /// <value>The signed tx.</value>
        [JsonProperty("signed_tx", NullValueHandling = NullValueHandling.Ignore)]
        public TransactionItem? SignedTx { get; set; }
    }
}