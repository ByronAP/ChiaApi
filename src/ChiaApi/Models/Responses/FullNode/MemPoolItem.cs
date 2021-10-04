using ChiaApi.Models.Responses.Shared;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.FullNode
{
    public class MemPoolItem
    {
        [JsonProperty("additions", NullValueHandling = NullValueHandling.Ignore)]
        public List<CoinItem>? Additions { get; set; }

        [JsonProperty("cost", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Cost { get; set; }

        [JsonProperty("fee", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Fee { get; set; }

        [JsonProperty("npc_result", NullValueHandling = NullValueHandling.Ignore)]
        public NpcItem? NpcResult { get; set; }

        [JsonProperty("program", NullValueHandling = NullValueHandling.Ignore)]
        public string Program { get; set; } = string.Empty;

        [JsonProperty("removals", NullValueHandling = NullValueHandling.Ignore)]
        public List<CoinItem>? Removals { get; set; }

        [JsonProperty("spend_bundle", NullValueHandling = NullValueHandling.Ignore)]
        public SpendBundle? SpendBundle { get; set; }

        [JsonProperty("spend_bundle_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SpendBundleName { get; set; } = string.Empty;
    }
}
