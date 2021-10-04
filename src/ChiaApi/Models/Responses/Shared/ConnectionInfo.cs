using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Shared
{
    public class ConnectionInfo
    {
        [JsonProperty("bytes_read", NullValueHandling = NullValueHandling.Ignore)]
        public ulong BytesRead { get; set; }

        [JsonProperty("bytes_written", NullValueHandling = NullValueHandling.Ignore)]
        public ulong BytesWritten { get; set; }

        [JsonProperty("creation_time", NullValueHandling = NullValueHandling.Ignore)]
        public decimal CreationTime { get; set; }

        [JsonProperty("last_message_time", NullValueHandling = NullValueHandling.Ignore)]
        public decimal LastMessageTime { get; set; }

        [JsonProperty("local_port", NullValueHandling = NullValueHandling.Ignore)]
        public uint LocalPort { get; set; }

        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; } = string.Empty;

        [JsonProperty("peak_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string PeakHash { get; set; } = string.Empty;

        [JsonProperty("peak_height", NullValueHandling = NullValueHandling.Ignore)]
        public ulong? PeakHeight { get; set; }

        [JsonProperty("peak_weight", NullValueHandling = NullValueHandling.Ignore)]
        public ulong? PeakWeight { get; set; }

        [JsonProperty("peer_host", NullValueHandling = NullValueHandling.Ignore)]
        public string PeerHost { get; set; } = string.Empty;

        [JsonProperty("peer_port", NullValueHandling = NullValueHandling.Ignore)]
        public uint PeerPort { get; set; }

        [JsonProperty("peer_server_port", NullValueHandling = NullValueHandling.Ignore)]
        public uint PeerServerPort { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public uint Type { get; set; }
    }
}