// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-28-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="AdditionsAndRemovalsResponse.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.FullNode
{
    /// <summary>
    /// Class AdditionsAndRemovalsResponse.
    /// Implements the <see cref="ChiaApi.Models.Responses.ApiResponseBase" />
    /// </summary>
    /// <seealso cref="ChiaApi.Models.Responses.ApiResponseBase" />
    public class AdditionsAndRemovalsResponse : ApiResponseBase
    {
        /// <summary>
        /// Gets or sets the additions.
        /// </summary>
        /// <value>The additions.</value>
        [JsonProperty("additions", NullValueHandling = NullValueHandling.Ignore)]
        public List<CoinRecord>? Additions { get; set; }

        /// <summary>
        /// Gets or sets the removals.
        /// </summary>
        /// <value>The removals.</value>
        [JsonProperty("removals", NullValueHandling = NullValueHandling.Ignore)]
        public List<CoinRecord>? Removals { get; set; }
    }
}