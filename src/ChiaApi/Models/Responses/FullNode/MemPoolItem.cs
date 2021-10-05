// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-28-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="MemPoolItem.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using ChiaApi.Models.Responses.Shared;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.FullNode
{
    /// <summary>
    /// Class MemPoolItem.
    /// </summary>
    public class MemPoolItem
    {
        /// <summary>
        /// Gets or sets the additions.
        /// </summary>
        /// <value>The additions.</value>
        [JsonProperty("additions", NullValueHandling = NullValueHandling.Ignore)]
        public List<CoinItem>? Additions { get; set; }

        /// <summary>
        /// Gets or sets the cost.
        /// </summary>
        /// <value>The cost.</value>
        [JsonProperty("cost", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Cost { get; set; }

        /// <summary>
        /// Gets or sets the fee.
        /// </summary>
        /// <value>The fee.</value>
        [JsonProperty("fee", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Fee { get; set; }

        /// <summary>
        /// Gets or sets the NPC result.
        /// </summary>
        /// <value>The NPC result.</value>
        [JsonProperty("npc_result", NullValueHandling = NullValueHandling.Ignore)]
        public NpcItem? NpcResult { get; set; }

        /// <summary>
        /// Gets or sets the program.
        /// </summary>
        /// <value>The program.</value>
        [JsonProperty("program", NullValueHandling = NullValueHandling.Ignore)]
        public string Program { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the removals.
        /// </summary>
        /// <value>The removals.</value>
        [JsonProperty("removals", NullValueHandling = NullValueHandling.Ignore)]
        public List<CoinItem>? Removals { get; set; }

        /// <summary>
        /// Gets or sets the spend bundle.
        /// </summary>
        /// <value>The spend bundle.</value>
        [JsonProperty("spend_bundle", NullValueHandling = NullValueHandling.Ignore)]
        public SpendBundle? SpendBundle { get; set; }

        /// <summary>
        /// Gets or sets the name of the spend bundle.
        /// </summary>
        /// <value>The name of the spend bundle.</value>
        [JsonProperty("spend_bundle_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SpendBundleName { get; set; } = string.Empty;
    }
}