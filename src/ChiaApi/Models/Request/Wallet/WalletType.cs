// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 10-01-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="WalletType.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace ChiaApi.Models.Request.Wallet
{
    /// <summary>
    /// Enum WalletType
    /// </summary>
    public enum WalletType
    {
        /// <summary>
        /// The cc wallet
        /// </summary>
        CC_Wallet,

        /// <summary>
        /// The rl wallet
        /// </summary>
        RL_Wallet,

        /// <summary>
        /// The did wallet
        /// </summary>
        DID_Wallet,

        /// <summary>
        /// The pool wallet
        /// </summary>
        Pool_Wallet
    }
}