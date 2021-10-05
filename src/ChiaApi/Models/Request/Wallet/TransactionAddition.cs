// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 10-02-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="TransactionAddition.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace ChiaApi.Models.Request.Wallet
{
    /// <summary>
    /// Class TransactionAddition.
    /// </summary>
    public class TransactionAddition
    {
        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>The amount.</value>
        public ulong Amount { get; set; }

        /// <summary>
        /// Gets or sets the puzzle hash.
        /// </summary>
        /// <value>The puzzle hash.</value>
        public string PuzzleHash { get; set; } = string.Empty;
    }
}