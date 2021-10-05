// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 10-02-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="PlotsResponse.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.Harvester
{
    /// <summary>
    /// Class PlotsResponse.
    /// Implements the <see cref="ChiaApi.Models.Responses.ApiResponseBase" />
    /// </summary>
    /// <seealso cref="ChiaApi.Models.Responses.ApiResponseBase" />
    public class PlotsResponse : ApiResponseBase
    {
        /// <summary>
        /// Gets or sets the failed to open filenames.
        /// </summary>
        /// <value>The failed to open filenames.</value>
        [JsonProperty("failed_to_open_filenames", NullValueHandling = NullValueHandling.Ignore)]
        public List<string>? FailedToOpenFilenames { get; set; }

        /// <summary>
        /// Gets or sets the not found filenames.
        /// </summary>
        /// <value>The not found filenames.</value>
        [JsonProperty("not_found_filenames", NullValueHandling = NullValueHandling.Ignore)]
        public List<string>? NotFoundFilenames { get; set; }

        /// <summary>
        /// Gets or sets the plots.
        /// </summary>
        /// <value>The plots.</value>
        [JsonProperty("plots", NullValueHandling = NullValueHandling.Ignore)]
        public List<PlotItem>? Plots { get; set; }
    }
}