// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-28-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="ConnectionInfo.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Shared
{
    /// <summary>
    /// Class ConnectionInfo.
    /// </summary>
    public class ConnectionInfo
    {
        /// <summary>
        /// Gets or sets the bytes read.
        /// </summary>
        /// <value>The bytes read.</value>
        [JsonProperty("bytes_read", NullValueHandling = NullValueHandling.Ignore)]
        public ulong BytesRead { get; set; }

        /// <summary>
        /// Gets or sets the bytes written.
        /// </summary>
        /// <value>The bytes written.</value>
        [JsonProperty("bytes_written", NullValueHandling = NullValueHandling.Ignore)]
        public ulong BytesWritten { get; set; }

        /// <summary>
        /// Gets or sets the creation time.
        /// </summary>
        /// <value>The creation time.</value>
        [JsonProperty("creation_time", NullValueHandling = NullValueHandling.Ignore)]
        public decimal CreationTime { get; set; }

        /// <summary>
        /// Gets or sets the last message time.
        /// </summary>
        /// <value>The last message time.</value>
        [JsonProperty("last_message_time", NullValueHandling = NullValueHandling.Ignore)]
        public decimal LastMessageTime { get; set; }

        /// <summary>
        /// Gets or sets the local port.
        /// </summary>
        /// <value>The local port.</value>
        [JsonProperty("local_port", NullValueHandling = NullValueHandling.Ignore)]
        public uint LocalPort { get; set; }

        /// <summary>
        /// Gets or sets the node identifier.
        /// </summary>
        /// <value>The node identifier.</value>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the peak hash.
        /// </summary>
        /// <value>The peak hash.</value>
        [JsonProperty("peak_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string PeakHash { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the height of the peak.
        /// </summary>
        /// <value>The height of the peak.</value>
        [JsonProperty("peak_height", NullValueHandling = NullValueHandling.Ignore)]
        public ulong? PeakHeight { get; set; }

        /// <summary>
        /// Gets or sets the peak weight.
        /// </summary>
        /// <value>The peak weight.</value>
        [JsonProperty("peak_weight", NullValueHandling = NullValueHandling.Ignore)]
        public ulong? PeakWeight { get; set; }

        /// <summary>
        /// Gets or sets the peer host.
        /// </summary>
        /// <value>The peer host.</value>
        [JsonProperty("peer_host", NullValueHandling = NullValueHandling.Ignore)]
        public string PeerHost { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the peer port.
        /// </summary>
        /// <value>The peer port.</value>
        [JsonProperty("peer_port", NullValueHandling = NullValueHandling.Ignore)]
        public uint PeerPort { get; set; }

        /// <summary>
        /// Gets or sets the peer server port.
        /// </summary>
        /// <value>The peer server port.</value>
        [JsonProperty("peer_server_port", NullValueHandling = NullValueHandling.Ignore)]
        public uint PeerServerPort { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public uint Type { get; set; }
    }
}