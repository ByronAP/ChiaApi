// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 10-01-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="CheckDeleteKeyResponse.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Wallet
{
    /// <summary>
    /// Class CheckDeleteKeyResponse.
    /// Implements the <see cref="ChiaApi.Models.Responses.ApiResponseBase" />
    /// </summary>
    /// <seealso cref="ChiaApi.Models.Responses.ApiResponseBase" />
    public class CheckDeleteKeyResponse : ApiResponseBase
    {
        /// <summary>
        /// Gets or sets the fingerprint.
        /// </summary>
        /// <value>The fingerprint.</value>
        [JsonProperty("fingerprint", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Fingerprint { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [used for farmer rewards].
        /// </summary>
        /// <value><c>true</c> if [used for farmer rewards]; otherwise, <c>false</c>.</value>
        [JsonProperty("used_for_farmer_rewards", NullValueHandling = NullValueHandling.Ignore)]
        public bool UsedForFarmerRewards { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [used for pool rewards].
        /// </summary>
        /// <value><c>true</c> if [used for pool rewards]; otherwise, <c>false</c>.</value>
        [JsonProperty("used_for_pool_rewards", NullValueHandling = NullValueHandling.Ignore)]
        public bool UsedForPoolRewards { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [wallet balance].
        /// </summary>
        /// <value><c>true</c> if [wallet balance]; otherwise, <c>false</c>.</value>
        [JsonProperty("wallet_balance", NullValueHandling = NullValueHandling.Ignore)]
        public bool WalletBalance { get; set; }
    }
}