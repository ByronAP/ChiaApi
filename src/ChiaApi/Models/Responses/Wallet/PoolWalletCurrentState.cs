// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 10-02-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="PoolWalletCurrentState.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Wallet
{
    /// <summary>
    /// Class PoolWalletCurrentState.
    /// </summary>
    public class PoolWalletCurrentState
    {
        /// <summary>
        /// Gets or sets the owner pubkey.
        /// </summary>
        /// <value>The owner pubkey.</value>
        [JsonProperty("owner_pubkey", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerPubkey { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the pool URL.
        /// </summary>
        /// <value>The pool URL.</value>
        [JsonProperty("pool_url", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolUrl { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the height of the relative lock.
        /// </summary>
        /// <value>The height of the relative lock.</value>
        [JsonProperty("relative_lock_height", NullValueHandling = NullValueHandling.Ignore)]
        public ulong RelativeLockHeight { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>The state.</value>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public uint State { get; set; }

        /// <summary>
        /// Gets or sets the target puzzle hash.
        /// </summary>
        /// <value>The target puzzle hash.</value>
        [JsonProperty("target_puzzle_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetPuzzleHash { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the version.
        /// </summary>
        /// <value>The version.</value>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public uint Version { get; set; }
    }
}