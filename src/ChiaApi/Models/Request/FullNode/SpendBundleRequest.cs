// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-28-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="SpendBundleRequest.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace ChiaApi.Models.Request.FullNode
{
    /// <summary>
    /// Class SpendBundleRequest.
    /// </summary>
    public class SpendBundleRequest
    {
        /// <summary>
        /// Gets or sets the spend bundle.
        /// </summary>
        /// <value>The spend bundle.</value>
        [JsonProperty("spend_bundle", NullValueHandling = NullValueHandling.Ignore)]
        public SpendBundle? SpendBundle { get; set; }
    }
}