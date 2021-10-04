using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.FullNode
{
    public class MemPoolItemsResponse : ApiResponseBase
    {
        [JsonProperty("mempool_items", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, MemPoolItem>? MemPoolItems { get; set; }
    }
}