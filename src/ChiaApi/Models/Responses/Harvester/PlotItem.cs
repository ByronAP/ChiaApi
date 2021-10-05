// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 10-02-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="PlotItem.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Harvester
{
    /// <summary>
    /// Class PlotItem.
    /// </summary>
    public class PlotItem
    {
        /// <summary>
        /// Gets or sets the filename.
        /// </summary>
        /// <value>The filename.</value>
        [JsonProperty("filename", NullValueHandling = NullValueHandling.Ignore)]
        public string Filename { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the size of the file.
        /// </summary>
        /// <value>The size of the file.</value>
        [JsonProperty("file_size", NullValueHandling = NullValueHandling.Ignore)]
        public ulong FileSize { get; set; }

        /// <summary>
        /// Gets or sets the plot identifier.
        /// </summary>
        /// <value>The plot identifier.</value>
        [JsonProperty("plot_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PlotId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the plot public key.
        /// </summary>
        /// <value>The plot public key.</value>
        [JsonProperty("plot_public_key", NullValueHandling = NullValueHandling.Ignore)]
        public string PlotPublicKey { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the plot seed.
        /// </summary>
        /// <value>The plot seed.</value>
        [JsonProperty("plot-seed", NullValueHandling = NullValueHandling.Ignore)]
        public string PlotSeed { get; set; } = string.Empty;

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
        /// Gets or sets the size.
        /// </summary>
        /// <value>The size.</value>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public uint Size { get; set; }

        /// <summary>
        /// Gets or sets the time modified.
        /// </summary>
        /// <value>The time modified.</value>
        [JsonProperty("time_modified", NullValueHandling = NullValueHandling.Ignore)]
        public decimal TimeModified { get; set; }
    }
}