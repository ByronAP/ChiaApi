// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-29-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="MemPoolItemResponse.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    /// <summary>
    /// Class MemPoolItemResponse.
    /// Implements the <see cref="ChiaApi.Models.Responses.ApiResponseBase" />
    /// </summary>
    /// <seealso cref="ChiaApi.Models.Responses.ApiResponseBase" />
    public class MemPoolItemResponse : ApiResponseBase
    {
        /// <summary>
        /// Gets or sets the memory pool item.
        /// </summary>
        /// <value>The memory pool item.</value>
        [JsonProperty("mempool_item", NullValueHandling = NullValueHandling.Ignore)]
        public MemPoolItem? MemPoolItem { get; set; }
    }
}