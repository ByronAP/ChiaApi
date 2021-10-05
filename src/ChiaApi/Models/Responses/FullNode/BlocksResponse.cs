// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-28-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="BlocksResponse.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.FullNode
{
    /// <summary>
    /// Class BlocksResponse.
    /// Implements the <see cref="ChiaApi.Models.Responses.ApiResponseBase" />
    /// </summary>
    /// <seealso cref="ChiaApi.Models.Responses.ApiResponseBase" />
    public class BlocksResponse : ApiResponseBase
    {
        /// <summary>
        /// Gets or sets the blocks.
        /// </summary>
        /// <value>The blocks.</value>
        [JsonProperty("blocks", NullValueHandling = NullValueHandling.Ignore)]
        public List<Block>? Blocks { get; set; }
    }
}