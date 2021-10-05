// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 10-02-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="WalletInitialTargetState.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace ChiaApi.Models.Request.Wallet
{
    /// <summary>
    /// Class WalletInitialTargetState.
    /// </summary>
    public class WalletInitialTargetState
    {
        /// <summary>
        /// Gets or sets the pool URL.
        /// </summary>
        /// <value>The pool URL.</value>
        public string PoolUrl { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the height of the relative lock.
        /// </summary>
        /// <value>The height of the relative lock.</value>
        public uint RelativeLockHeight { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>The state.</value>
        public string State { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the target puzzle hash.
        /// </summary>
        /// <value>The target puzzle hash.</value>
        public string TargetPuzzleHash { get; set; } = string.Empty;
    }
}