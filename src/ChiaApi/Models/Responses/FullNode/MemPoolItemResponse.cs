using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    public class MemPoolItemResponse : ApiResponseBase
    {
        [JsonProperty("mempool_item", NullValueHandling = NullValueHandling.Ignore)]
        public MemPoolItem? MemPoolItem { get; set; }
    }
}