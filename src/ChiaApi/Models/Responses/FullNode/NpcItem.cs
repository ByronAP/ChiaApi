using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.FullNode
{
    public class NpcItem
    {
        [JsonProperty("clvm_cost", NullValueHandling = NullValueHandling.Ignore)]
        public ulong ClvmCost { get; set; }

        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public string Error { get; set; } = string.Empty;

        [JsonProperty("npc_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<NpcListItem>? NpcList { get; set; }
    }
}
