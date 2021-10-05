// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 10-02-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="FarmedAmountResponse.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Wallet
{
    /// <summary>
    /// Class FarmedAmountResponse.
    /// Implements the <see cref="ChiaApi.Models.Responses.ApiResponseBase" />
    /// </summary>
    /// <seealso cref="ChiaApi.Models.Responses.ApiResponseBase" />
    public class FarmedAmountResponse : ApiResponseBase
    {
        /// <summary>
        /// Gets or sets the farmed amount.
        /// </summary>
        /// <value>The farmed amount.</value>
        [JsonProperty("farmed_amount", NullValueHandling = NullValueHandling.Ignore)]
        public ulong FarmedAmount { get; set; }

        /// <summary>
        /// Gets or sets the farmer reward amount.
        /// </summary>
        /// <value>The farmer reward amount.</value>
        [JsonProperty("farmer_reward_amount", NullValueHandling = NullValueHandling.Ignore)]
        public ulong FarmerRewardAmount { get; set; }

        /// <summary>
        /// Gets or sets the fee amount.
        /// </summary>
        /// <value>The fee amount.</value>
        [JsonProperty("fee_amount", NullValueHandling = NullValueHandling.Ignore)]
        public ulong FeeAmount { get; set; }

        /// <summary>
        /// Gets or sets the last height farmed.
        /// </summary>
        /// <value>The last height farmed.</value>
        [JsonProperty("last_height_farmed", NullValueHandling = NullValueHandling.Ignore)]
        public ulong LastHeightFarmed { get; set; }

        /// <summary>
        /// Gets or sets the pool reward amount.
        /// </summary>
        /// <value>The pool reward amount.</value>
        [JsonProperty("pool_reward_amount", NullValueHandling = NullValueHandling.Ignore)]
        public ulong PoolRewardAmount { get; set; }
    }
}