// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-28-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="BlockchainState.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System.Numerics;

namespace ChiaApi.Models.Responses.FullNode
{
    /// <summary>
    /// Class BlockchainState.
    /// </summary>
    public class BlockchainState
    {
        /// <summary>
        /// Gets or sets the difficulty.
        /// </summary>
        /// <value>The difficulty.</value>
        [JsonProperty("difficulty", NullValueHandling = NullValueHandling.Ignore)]
        public uint Difficulty { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [genesis challenge initialized].
        /// </summary>
        /// <value><c>true</c> if [genesis challenge initialized]; otherwise, <c>false</c>.</value>
        [JsonProperty("genesis_challenge_initialized", NullValueHandling = NullValueHandling.Ignore)]
        public bool GenesisChallengeInitialized { get; set; }

        /// <summary>
        /// Gets or sets the size of the mempool.
        /// </summary>
        /// <value>The size of the mempool.</value>
        [JsonProperty("mempool_size", NullValueHandling = NullValueHandling.Ignore)]
        public uint MempoolSize { get; set; }

        /// <summary>
        /// Gets or sets the peak.
        /// </summary>
        /// <value>The peak.</value>
        [JsonProperty("peak", NullValueHandling = NullValueHandling.Ignore)]
        public BlockchainPeak? Peak { get; set; }

        /// <summary>
        /// Gets or sets the space.
        /// </summary>
        /// <value>The space.</value>
        [JsonProperty("space", NullValueHandling = NullValueHandling.Ignore)]
        public BigInteger Space { get; set; }

        /// <summary>
        /// Gets or sets the sub slot iters.
        /// </summary>
        /// <value>The sub slot iters.</value>
        [JsonProperty("sub_slot_iters", NullValueHandling = NullValueHandling.Ignore)]
        public ulong SubSlotIters { get; set; }

        /// <summary>
        /// Gets or sets the synchronize.
        /// </summary>
        /// <value>The synchronize.</value>
        [JsonProperty("sync", NullValueHandling = NullValueHandling.Ignore)]
        public BlockchainSync? Sync { get; set; }
    }
}