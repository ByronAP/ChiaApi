// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 10-02-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="RewardTargetsResponse.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Farmer
{
    /// <summary>
    /// Class RewardTargetsResponse.
    /// Implements the <see cref="ChiaApi.Models.Responses.ApiResponseBase" />
    /// </summary>
    /// <seealso cref="ChiaApi.Models.Responses.ApiResponseBase" />
    public class RewardTargetsResponse : ApiResponseBase
    {
        /// <summary>
        /// Gets or sets the farmer target.
        /// </summary>
        /// <value>The farmer target.</value>
        [JsonProperty("farmer_target", NullValueHandling = NullValueHandling.Ignore)]
        public string FarmerTarget { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets a value indicating whether [have farmer sk].
        /// </summary>
        /// <value><c>true</c> if [have farmer sk]; otherwise, <c>false</c>.</value>
        [JsonProperty("have_farmer_sk", NullValueHandling = NullValueHandling.Ignore)]
        public bool HaveFarmerSk { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [have pool sk].
        /// </summary>
        /// <value><c>true</c> if [have pool sk]; otherwise, <c>false</c>.</value>
        [JsonProperty("have_pool_sk", NullValueHandling = NullValueHandling.Ignore)]
        public bool HavePoolSk { get; set; }

        /// <summary>
        /// Gets or sets the pool target.
        /// </summary>
        /// <value>The pool target.</value>
        [JsonProperty("pool_target", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolTarget { get; set; } = string.Empty;
    }
}