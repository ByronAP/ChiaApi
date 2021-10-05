// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 10-01-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="SyncStatusResponse.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Wallet
{
    /// <summary>
    /// Class SyncStatusResponse.
    /// Implements the <see cref="ChiaApi.Models.Responses.ApiResponseBase" />
    /// </summary>
    /// <seealso cref="ChiaApi.Models.Responses.ApiResponseBase" />
    public class SyncStatusResponse : ApiResponseBase
    {
        /// <summary>
        /// Gets or sets a value indicating whether [genesis initialized].
        /// </summary>
        /// <value><c>true</c> if [genesis initialized]; otherwise, <c>false</c>.</value>
        [JsonProperty("genesis_initialized", NullValueHandling = NullValueHandling.Ignore)]
        public bool GenesisInitialized { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="SyncStatusResponse"/> is synced.
        /// </summary>
        /// <value><c>true</c> if synced; otherwise, <c>false</c>.</value>
        [JsonProperty("synced", NullValueHandling = NullValueHandling.Ignore)]
        public bool Synced { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="SyncStatusResponse"/> is syncing.
        /// </summary>
        /// <value><c>true</c> if syncing; otherwise, <c>false</c>.</value>
        [JsonProperty("syncing", NullValueHandling = NullValueHandling.Ignore)]
        public bool Syncing { get; set; }
    }
}