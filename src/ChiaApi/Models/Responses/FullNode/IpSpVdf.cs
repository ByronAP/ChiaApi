// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-28-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="IpSpVdf.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    /// <summary>
    /// Class IpSpVdf.
    /// </summary>
    public class IpSpVdf
    {
        /// <summary>
        /// Gets or sets the challenge.
        /// </summary>
        /// <value>The challenge.</value>
        [JsonProperty("challenge", NullValueHandling = NullValueHandling.Ignore)]
        public string Challenge { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the number of iterations.
        /// </summary>
        /// <value>The number of iterations.</value>
        [JsonProperty("number_of_iterations", NullValueHandling = NullValueHandling.Ignore)]
        public ulong NumberOfIterations { get; set; }

        /// <summary>
        /// Gets or sets the output.
        /// </summary>
        /// <value>The output.</value>
        [JsonProperty("output", NullValueHandling = NullValueHandling.Ignore)]
        public IpSpVdfOutput? Output { get; set; }
    }
}