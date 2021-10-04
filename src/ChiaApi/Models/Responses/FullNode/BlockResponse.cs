using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    public class BlockResponse : ApiResponseBase
    {
        [JsonProperty("block", NullValueHandling = NullValueHandling.Ignore)]
        public Block? Block { get; set; }
    }
}