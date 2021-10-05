// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-28-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="MemPoolItemsResponse.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.FullNode
{
    /// <summary>
    /// Class MemPoolItemsResponse.
    /// Implements the <see cref="ChiaApi.Models.Responses.ApiResponseBase" />
    /// </summary>
    /// <seealso cref="ChiaApi.Models.Responses.ApiResponseBase" />
    public class MemPoolItemsResponse : ApiResponseBase
    {
        /// <summary>
        /// Gets or sets the memory pool items.
        /// </summary>
        /// <value>The memory pool items.</value>
        [JsonProperty("mempool_items", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, MemPoolItem>? MemPoolItems { get; set; }
    }
}