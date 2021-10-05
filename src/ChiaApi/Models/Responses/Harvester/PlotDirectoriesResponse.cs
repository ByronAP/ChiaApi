// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 10-02-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="PlotDirectoriesResponse.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.Harvester
{
    /// <summary>
    /// Class PlotDirectoriesResponse.
    /// Implements the <see cref="ChiaApi.Models.Responses.ApiResponseBase" />
    /// </summary>
    /// <seealso cref="ChiaApi.Models.Responses.ApiResponseBase" />
    public class PlotDirectoriesResponse : ApiResponseBase
    {
        /// <summary>
        /// Gets or sets the directories.
        /// </summary>
        /// <value>The directories.</value>
        [JsonProperty("directories", NullValueHandling = NullValueHandling.Ignore)]
        public List<string>? Directories { get; set; }
    }
}