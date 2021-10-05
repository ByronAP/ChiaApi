// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 10-01-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="PrivateKey.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Wallet
{
    /// <summary>
    /// Class PrivateKey.
    /// </summary>
    public class PrivateKey
    {
        /// <summary>
        /// Gets or sets the farmer pk.
        /// </summary>
        /// <value>The farmer pk.</value>
        [JsonProperty("farmer_pk", NullValueHandling = NullValueHandling.Ignore)]
        public string FarmerPk { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the fingerprint.
        /// </summary>
        /// <value>The fingerprint.</value>
        [JsonProperty("fingerprint", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Fingerprint { get; set; }

        /// <summary>
        /// Gets or sets the pk.
        /// </summary>
        /// <value>The pk.</value>
        [JsonProperty("pk", NullValueHandling = NullValueHandling.Ignore)]
        public string Pk { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the pool pk.
        /// </summary>
        /// <value>The pool pk.</value>
        [JsonProperty("pool_pk", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolPk { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the seed.
        /// </summary>
        /// <value>The seed.</value>
        [JsonProperty("seed", NullValueHandling = NullValueHandling.Ignore)]
        public string Seed { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the sk.
        /// </summary>
        /// <value>The sk.</value>
        [JsonProperty("sk", NullValueHandling = NullValueHandling.Ignore)]
        public string Sk { get; set; } = string.Empty;
    }
}