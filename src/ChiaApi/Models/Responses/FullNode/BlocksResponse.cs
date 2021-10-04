using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.FullNode
{
    public class BlocksResponse : ApiResponseBase
    {
        [JsonProperty("blocks", NullValueHandling = NullValueHandling.Ignore)]
        public List<Block>? Blocks { get; set; }
    }
}
