// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-29-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="SignagePointOrEosResponseResponse.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    /// <summary>
    /// Class SignagePointOrEosResponseResponse.
    /// Implements the <see cref="ChiaApi.Models.Responses.ApiResponseBase" />
    /// </summary>
    /// <seealso cref="ChiaApi.Models.Responses.ApiResponseBase" />
    public class SignagePointOrEosResponseResponse : ApiResponseBase
    {
        /// <summary>
        /// Gets or sets the eos.
        /// </summary>
        /// <value>The eos.</value>
        [JsonProperty("eos", NullValueHandling = NullValueHandling.Ignore)]
        public EosItem? Eos { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="SignagePointOrEosResponseResponse"/> is reverted.
        /// </summary>
        /// <value><c>true</c> if reverted; otherwise, <c>false</c>.</value>
        [JsonProperty("reverted", NullValueHandling = NullValueHandling.Ignore)]
        public bool Reverted { get; set; }

        /// <summary>
        /// Gets or sets the time received.
        /// </summary>
        /// <value>The time received.</value>
        [JsonProperty("time_received", NullValueHandling = NullValueHandling.Ignore)]
        public decimal TimeReceived { get; set; }
    }
}