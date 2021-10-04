using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.FullNode
{
    public class BlockRecordsResponse : ApiResponseBase
    {
        [JsonProperty("block_records", NullValueHandling = NullValueHandling.Ignore)]
        public List<BlockRecord>? BlockRecord { get; set; }
    }
}
