using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    public class BlockchainSync
    {
        [JsonProperty("sync_mode", NullValueHandling = NullValueHandling.Ignore)]
        public bool SyncMode { get; set; }

        [JsonProperty("sync_progress_height", NullValueHandling = NullValueHandling.Ignore)]
        public ulong SyncProgressHeight { get; set; }

        [JsonProperty("sync_tip_height", NullValueHandling = NullValueHandling.Ignore)]
        public ulong SyncTipHeight { get; set; }

        [JsonProperty("synced", NullValueHandling = NullValueHandling.Ignore)]
        public bool Synced { get; set; }
    }
}
