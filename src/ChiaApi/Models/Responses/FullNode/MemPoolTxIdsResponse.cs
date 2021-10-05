// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-28-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="MemPoolTxIdsResponse.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.FullNode
{
    /// <summary>
    /// Class MemPoolTxIdsResponse.
    /// Implements the <see cref="ChiaApi.Models.Responses.ApiResponseBase" />
    /// </summary>
    /// <seealso cref="ChiaApi.Models.Responses.ApiResponseBase" />
    public class MemPoolTxIdsResponse : ApiResponseBase
    {
        /// <summary>
        /// Gets or sets the tx ids.
        /// </summary>
        /// <value>The tx ids.</value>
        [JsonProperty("tx_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string>? TxIds { get; set; }
    }
}