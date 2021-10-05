// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-28-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="BlockRecordsResponse.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.FullNode
{
    /// <summary>
    /// Class BlockRecordsResponse.
    /// Implements the <see cref="ChiaApi.Models.Responses.ApiResponseBase" />
    /// </summary>
    /// <seealso cref="ChiaApi.Models.Responses.ApiResponseBase" />
    public class BlockRecordsResponse : ApiResponseBase
    {
        /// <summary>
        /// Gets or sets the block record.
        /// </summary>
        /// <value>The block record.</value>
        [JsonProperty("block_records", NullValueHandling = NullValueHandling.Ignore)]
        public List<BlockRecord>? BlockRecord { get; set; }
    }
}