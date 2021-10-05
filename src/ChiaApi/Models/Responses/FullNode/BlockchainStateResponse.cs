// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-28-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="BlockchainStateResponse.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    /// <summary>
    /// Class BlockchainStateResponse.
    /// Implements the <see cref="ChiaApi.Models.Responses.ApiResponseBase" />
    /// </summary>
    /// <seealso cref="ChiaApi.Models.Responses.ApiResponseBase" />
    public class BlockchainStateResponse : ApiResponseBase
    {
        /// <summary>
        /// Gets or sets the state of the blockchain.
        /// </summary>
        /// <value>The state of the blockchain.</value>
        [JsonProperty("blockchain_state", NullValueHandling = NullValueHandling.Ignore)]
        public BlockchainState? BlockchainState { get; set; }
    }
}