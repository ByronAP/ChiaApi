// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-28-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="ProofOfSpace.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    /// <summary>
    /// Class ProofOfSpace.
    /// </summary>
    public class ProofOfSpace
    {
        /// <summary>
        /// Gets or sets the challenge.
        /// </summary>
        /// <value>The challenge.</value>
        [JsonProperty("challenge", NullValueHandling = NullValueHandling.Ignore)]
        public string Challenge { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the plot public key.
        /// </summary>
        /// <value>The plot public key.</value>
        [JsonProperty("plot_public_key", NullValueHandling = NullValueHandling.Ignore)]
        public string PlotPublicKey { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the pool contract puzzle hash.
        /// </summary>
        /// <value>The pool contract puzzle hash.</value>
        [JsonProperty("pool_contract_puzzle_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolContractPuzzleHash { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the pool public key.
        /// </summary>
        /// <value>The pool public key.</value>
        [JsonProperty("pool_public_key", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolPublicKey { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the proof.
        /// </summary>
        /// <value>The proof.</value>
        [JsonProperty("proof", NullValueHandling = NullValueHandling.Ignore)]
        public string Proof { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>The size.</value>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public uint Size { get; set; }
    }
}