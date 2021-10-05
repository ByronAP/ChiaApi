// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-28-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="Condition.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.FullNode
{
    /// <summary>
    /// Class Condition.
    /// </summary>
    public class Condition
    {
        /// <summary>
        /// Gets or sets the opcode.
        /// </summary>
        /// <value>The opcode.</value>
        [JsonProperty("opcode", NullValueHandling = NullValueHandling.Ignore)]
        public string Opcode { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the vars.
        /// </summary>
        /// <value>The vars.</value>
        [JsonProperty("vars", NullValueHandling = NullValueHandling.Ignore)]
        public List<string>? Vars { get; set; }
    }
}