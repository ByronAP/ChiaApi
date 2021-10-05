// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 10-01-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="PrivateKeyResponse.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Wallet
{
    /// <summary>
    /// Class PrivateKeyResponse.
    /// Implements the <see cref="ChiaApi.Models.Responses.ApiResponseBase" />
    /// </summary>
    /// <seealso cref="ChiaApi.Models.Responses.ApiResponseBase" />
    public class PrivateKeyResponse : ApiResponseBase
    {
        /// <summary>
        /// Gets or sets the private key.
        /// </summary>
        /// <value>The private key.</value>
        [JsonProperty("private_key", NullValueHandling = NullValueHandling.Ignore)]
        public PrivateKey? PrivateKey { get; set; }
    }
}