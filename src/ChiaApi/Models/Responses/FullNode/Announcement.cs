// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-30-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="Announcement.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    /// <summary>
    /// Class Announcement.
    /// </summary>
    public class Announcement
    {
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>The message.</value>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the origin information.
        /// </summary>
        /// <value>The origin information.</value>
        [JsonProperty("origin_info", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginInfo { get; set; } = string.Empty;
    }
}