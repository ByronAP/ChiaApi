// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 10-02-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="PoolWalletState.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using ChiaApi.Models.Responses.Shared;
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Wallet
{
    /// <summary>
    /// Class PoolWalletState.
    /// </summary>
    public class PoolWalletState
    {
        /// <summary>
        /// Gets or sets the current.
        /// </summary>
        /// <value>The current.</value>
        [JsonProperty("current", NullValueHandling = NullValueHandling.Ignore)]
        public PoolWalletCurrentState? Current { get; set; }

        /// <summary>
        /// Gets or sets the current inner.
        /// </summary>
        /// <value>The current inner.</value>
        [JsonProperty("current_inner", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentInner { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the launcher coin.
        /// </summary>
        /// <value>The launcher coin.</value>
        [JsonProperty("launcher_coin", NullValueHandling = NullValueHandling.Ignore)]
        public CoinItem? LauncherCoin { get; set; }

        /// <summary>
        /// Gets or sets the launcher identifier.
        /// </summary>
        /// <value>The launcher identifier.</value>
        [JsonProperty("launcher_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LauncherId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the p2 singleton puzzle hash.
        /// </summary>
        /// <value>The p2 singleton puzzle hash.</value>
        [JsonProperty("p2_singleton_puzzle_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string P2SingletonPuzzleHash { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the height of the singleton block.
        /// </summary>
        /// <value>The height of the singleton block.</value>
        [JsonProperty("singleton_block_height", NullValueHandling = NullValueHandling.Ignore)]
        public ulong SingletonBlockHeight { get; set; }

        /// <summary>
        /// Gets or sets the target.
        /// </summary>
        /// <value>The target.</value>
        [JsonProperty("target", NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the tip singleton coin identifier.
        /// </summary>
        /// <value>The tip singleton coin identifier.</value>
        [JsonProperty("tip_singleton_coin_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TipSingletonCoinId { get; set; } = string.Empty;
    }
}