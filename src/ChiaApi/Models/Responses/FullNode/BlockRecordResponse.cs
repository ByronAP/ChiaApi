using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    public class BlockRecordResponse : ApiResponseBase
    {
        [JsonProperty("block_record", NullValueHandling = NullValueHandling.Ignore)]
        public BlockRecord? BlockRecord { get; set; }
    }
}