// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 10-01-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="NetworkInfoResponse.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Shared
{
    /// <summary>
    /// Class NetworkInfoResponse.
    /// Implements the <see cref="ChiaApi.Models.Responses.ApiResponseBase" />
    /// </summary>
    /// <seealso cref="ChiaApi.Models.Responses.ApiResponseBase" />
    public class NetworkInfoResponse : ApiResponseBase
    {
        /// <summary>
        /// Gets or sets the name of the network.
        /// </summary>
        /// <value>The name of the network.</value>
        [JsonProperty("network_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the network prefix.
        /// </summary>
        /// <value>The network prefix.</value>
        [JsonProperty("network_prefix", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkPrefix { get; set; } = string.Empty;
    }
}