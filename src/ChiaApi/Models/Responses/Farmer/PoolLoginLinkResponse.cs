// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 10-02-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="PoolLoginLinkResponse.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Farmer
{
    /// <summary>
    /// Class PoolLoginLinkResponse.
    /// Implements the <see cref="ChiaApi.Models.Responses.ApiResponseBase" />
    /// </summary>
    /// <seealso cref="ChiaApi.Models.Responses.ApiResponseBase" />
    public class PoolLoginLinkResponse : ApiResponseBase
    {
        /// <summary>
        /// Gets or sets the login link.
        /// </summary>
        /// <value>The login link.</value>
        [JsonProperty("login_link", NullValueHandling = NullValueHandling.Ignore)]
        public string LoginLink { get; set; } = string.Empty;
    }
}