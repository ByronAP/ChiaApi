using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.FullNode
{
    public class UnfinishedBlockHeadersResponse : ApiResponseBase
    {
        [JsonProperty("headers", NullValueHandling = NullValueHandling.Ignore)]
        public List<BlockHeader>? Headers { get; set; }
    }
}
