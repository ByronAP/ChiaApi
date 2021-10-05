// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-28-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="NpcItem.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.FullNode
{
    /// <summary>
    /// Class NpcItem.
    /// </summary>
    public class NpcItem
    {
        /// <summary>
        /// Gets or sets the CLVM cost.
        /// </summary>
        /// <value>The CLVM cost.</value>
        [JsonProperty("clvm_cost", NullValueHandling = NullValueHandling.Ignore)]
        public ulong ClvmCost { get; set; }

        /// <summary>
        /// Gets or sets the error.
        /// </summary>
        /// <value>The error.</value>
        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public string Error { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the NPC list.
        /// </summary>
        /// <value>The NPC list.</value>
        [JsonProperty("npc_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<NpcListItem>? NpcList { get; set; }
    }
}