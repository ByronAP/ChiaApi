// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 10-01-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="LoginType.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace ChiaApi.Models.Request.Wallet
{
    /// <summary>
    /// Enum LoginType
    /// </summary>
    public enum LoginType
    {
        /// <summary>
        /// The start
        /// </summary>
        Start,

        /// <summary>
        /// The restore backup
        /// </summary>
        Restore_Backup,

        /// <summary>
        /// The skip
        /// </summary>
        Skip
    }
}