// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-28-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="BlockchainSync.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    /// <summary>
    /// Class BlockchainSync.
    /// </summary>
    public class BlockchainSync
    {
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="BlockchainSync"/> is synced.
        /// </summary>
        /// <value><c>true</c> if synced; otherwise, <c>false</c>.</value>
        [JsonProperty("synced", NullValueHandling = NullValueHandling.Ignore)]
        public bool Synced { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [synchronize mode].
        /// </summary>
        /// <value><c>true</c> if [synchronize mode]; otherwise, <c>false</c>.</value>
        [JsonProperty("sync_mode", NullValueHandling = NullValueHandling.Ignore)]
        public bool SyncMode { get; set; }

        /// <summary>
        /// Gets or sets the height of the synchronize progress.
        /// </summary>
        /// <value>The height of the synchronize progress.</value>
        [JsonProperty("sync_progress_height", NullValueHandling = NullValueHandling.Ignore)]
        public ulong SyncProgressHeight { get; set; }

        /// <summary>
        /// Gets or sets the height of the synchronize tip.
        /// </summary>
        /// <value>The height of the synchronize tip.</value>
        [JsonProperty("sync_tip_height", NullValueHandling = NullValueHandling.Ignore)]
        public ulong SyncTipHeight { get; set; }
    }
}