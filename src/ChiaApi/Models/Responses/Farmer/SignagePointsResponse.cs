// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 10-02-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="SignagePointsResponse.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.Farmer
{
    /// <summary>
    /// Class SignagePointsResponse.
    /// Implements the <see cref="ChiaApi.Models.Responses.ApiResponseBase" />
    /// </summary>
    /// <seealso cref="ChiaApi.Models.Responses.ApiResponseBase" />
    public class SignagePointsResponse : ApiResponseBase
    {
        /// <summary>
        /// Gets or sets the signage points.
        /// </summary>
        /// <value>The signage points.</value>
        [JsonProperty("signage_points", NullValueHandling = NullValueHandling.Ignore)]
        public List<SignagePointItem>? SignagePoints { get; set; }
    }
}