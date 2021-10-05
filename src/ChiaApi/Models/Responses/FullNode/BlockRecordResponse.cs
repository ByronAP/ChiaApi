// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-28-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="BlockRecordResponse.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    /// <summary>
    /// Class BlockRecordResponse.
    /// Implements the <see cref="ChiaApi.Models.Responses.ApiResponseBase" />
    /// </summary>
    /// <seealso cref="ChiaApi.Models.Responses.ApiResponseBase" />
    public class BlockRecordResponse : ApiResponseBase
    {
        /// <summary>
        /// Gets or sets the block record.
        /// </summary>
        /// <value>The block record.</value>
        [JsonProperty("block_record", NullValueHandling = NullValueHandling.Ignore)]
        public BlockRecord? BlockRecord { get; set; }
    }
}