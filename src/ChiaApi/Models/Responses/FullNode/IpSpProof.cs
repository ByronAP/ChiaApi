// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-28-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="IpSpProof.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    /// <summary>
    /// Class IpSpProof.
    /// </summary>
    public class IpSpProof
    {
        /// <summary>
        /// Gets or sets a value indicating whether [normalized to identity].
        /// </summary>
        /// <value><c>true</c> if [normalized to identity]; otherwise, <c>false</c>.</value>
        [JsonProperty("normalized_to_identity", NullValueHandling = NullValueHandling.Ignore)]
        public bool NormalizedToIdentity { get; set; }

        /// <summary>
        /// Gets or sets the witness.
        /// </summary>
        /// <value>The witness.</value>
        [JsonProperty("witness", NullValueHandling = NullValueHandling.Ignore)]
        public string Witness { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the type of the witness.
        /// </summary>
        /// <value>The type of the witness.</value>
        [JsonProperty("witness_type", NullValueHandling = NullValueHandling.Ignore)]
        public uint WitnessType { get; set; }
    }
}