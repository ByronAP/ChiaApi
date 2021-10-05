// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 10-02-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="SignagePointItem.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.Farmer
{
    /// <summary>
    /// Class SignagePointItem.
    /// </summary>
    public class SignagePointItem
    {
        /// <summary>
        /// Gets or sets the proofs.
        /// </summary>
        /// <value>The proofs.</value>
        [JsonProperty("proofs", NullValueHandling = NullValueHandling.Ignore)]
        public List<dynamic>? Proofs { get; set; }

        /// <summary>
        /// Gets or sets the signage point.
        /// </summary>
        /// <value>The signage point.</value>
        [JsonProperty("signage_point", NullValueHandling = NullValueHandling.Ignore)]
        public SignagePoint? SignagePoint { get; set; }
    }
}