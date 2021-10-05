// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-28-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="NetworkSpaceResponse.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System.Numerics;

namespace ChiaApi.Models.Responses.FullNode
{
    /// <summary>
    /// Class NetworkSpaceResponse.
    /// Implements the <see cref="ChiaApi.Models.Responses.ApiResponseBase" />
    /// </summary>
    /// <seealso cref="ChiaApi.Models.Responses.ApiResponseBase" />
    public class NetworkSpaceResponse : ApiResponseBase
    {
        /// <summary>
        /// Gets or sets the space.
        /// </summary>
        /// <value>The space.</value>
        [JsonProperty("space", NullValueHandling = NullValueHandling.Ignore)]
        public BigInteger Space { get; set; }
    }
}