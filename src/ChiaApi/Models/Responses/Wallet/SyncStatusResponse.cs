using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Wallet
{
    public class SyncStatusResponse : ApiResponseBase
    {
        [JsonProperty("genesis_initialized", NullValueHandling = NullValueHandling.Ignore)]
        public bool GenesisInitialized { get; set; }

        [JsonProperty("synced", NullValueHandling = NullValueHandling.Ignore)]
        public bool Synced { get; set; }

        [JsonProperty("syncing", NullValueHandling = NullValueHandling.Ignore)]
        public bool Syncing { get; set; }
    }
}
