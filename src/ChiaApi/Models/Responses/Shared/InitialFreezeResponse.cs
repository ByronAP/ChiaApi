// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 10-01-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="InitialFreezeResponse.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Shared
{
    /// <summary>
    /// Class InitialFreezeResponse.
    /// Implements the <see cref="ChiaApi.Models.Responses.ApiResponseBase" />
    /// </summary>
    /// <seealso cref="ChiaApi.Models.Responses.ApiResponseBase" />
    public class InitialFreezeResponse : ApiResponseBase
    {
        /// <summary>
        /// Gets or sets the initial freeze end timestamp.
        /// </summary>
        /// <value>The initial freeze end timestamp.</value>
        [JsonProperty("INITIAL_FREEZE_END_TIMESTAMP", NullValueHandling = NullValueHandling.Ignore)]
        public ulong InitialFreezeEndTimestamp { get; set; }
    }
}