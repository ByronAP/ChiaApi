// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-28-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="CoinRecordsResponse.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.FullNode
{
    /// <summary>
    /// Class CoinRecordsResponse.
    /// Implements the <see cref="ChiaApi.Models.Responses.ApiResponseBase" />
    /// </summary>
    /// <seealso cref="ChiaApi.Models.Responses.ApiResponseBase" />
    public class CoinRecordsResponse : ApiResponseBase
    {
        /// <summary>
        /// Gets or sets the coin records.
        /// </summary>
        /// <value>The coin records.</value>
        [JsonProperty("coin_records", NullValueHandling = NullValueHandling.Ignore)]
        public List<CoinRecord>? CoinRecords { get; set; }
    }
}