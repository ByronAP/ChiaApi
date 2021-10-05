// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 10-01-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="PublicKeysResponse.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.Wallet
{
    /// <summary>
    /// Class PublicKeysResponse.
    /// Implements the <see cref="ChiaApi.Models.Responses.ApiResponseBase" />
    /// </summary>
    /// <seealso cref="ChiaApi.Models.Responses.ApiResponseBase" />
    public class PublicKeysResponse : ApiResponseBase
    {
        /// <summary>
        /// Gets or sets the public key fingerprints.
        /// </summary>
        /// <value>The public key fingerprints.</value>
        [JsonProperty("public_key_fingerprints", NullValueHandling = NullValueHandling.Ignore)]
        public List<ulong>? PublicKeyFingerprints { get; set; }
    }
}