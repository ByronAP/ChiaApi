// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 10-02-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="PoolConfig.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Farmer
{
    /// <summary>
    /// Class PoolConfig.
    /// </summary>
    public class PoolConfig
    {
        /// <summary>
        /// Gets or sets the authentication public key.
        /// </summary>
        /// <value>The authentication public key.</value>
        [JsonProperty("authentication_public_key", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthenticationPublicKey { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the launcher identifier.
        /// </summary>
        /// <value>The launcher identifier.</value>
        [JsonProperty("launcher_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LauncherId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the owner public key.
        /// </summary>
        /// <value>The owner public key.</value>
        [JsonProperty("owner_public_key", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerPublicKey { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the p2 singleton puzzle hash.
        /// </summary>
        /// <value>The p2 singleton puzzle hash.</value>
        [JsonProperty("p2_singleton_puzzle_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string P2SingletonPuzzleHash { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the payout instructions.
        /// </summary>
        /// <value>The payout instructions.</value>
        [JsonProperty("payout_instructions", NullValueHandling = NullValueHandling.Ignore)]
        public string PayoutInstructions { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the pool URL.
        /// </summary>
        /// <value>The pool URL.</value>
        [JsonProperty("pool_url", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolUrl { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the target puzzle hash.
        /// </summary>
        /// <value>The target puzzle hash.</value>
        [JsonProperty("target_puzzle_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetPuzzleHash { get; set; } = string.Empty;
    }
}