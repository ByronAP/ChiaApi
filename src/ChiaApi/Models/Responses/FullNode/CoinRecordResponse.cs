// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-28-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="CoinRecordResponse.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    /// <summary>
    /// Class CoinRecordResponse.
    /// Implements the <see cref="ChiaApi.Models.Responses.ApiResponseBase" />
    /// </summary>
    /// <seealso cref="ChiaApi.Models.Responses.ApiResponseBase" />
    public class CoinRecordResponse : ApiResponseBase
    {
        /// <summary>
        /// Gets or sets the coin record.
        /// </summary>
        /// <value>The coin record.</value>
        [JsonProperty("coin_record", NullValueHandling = NullValueHandling.Ignore)]
        public CoinRecord? CoinRecord { get; set; }
    }
}