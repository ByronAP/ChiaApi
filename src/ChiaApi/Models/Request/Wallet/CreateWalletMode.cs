// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 10-01-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="CreateWalletMode.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace ChiaApi.Models.Request.Wallet
{
    /// <summary>
    /// Enum CreateWalletMode
    /// </summary>
    public enum CreateWalletMode
    {
        /// <summary>
        /// New Wallet
        /// </summary>
        New,

        /// <summary>
        /// Existing Wallet
        /// </summary>
        Existing,

        /// <summary>
        /// Wallet Recovery
        /// </summary>
        Recovery
    }
}