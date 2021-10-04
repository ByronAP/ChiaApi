using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.FullNode
{
    public class MemPoolTxIdsResponse : ApiResponseBase
    {
        [JsonProperty("tx_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string>? TxIds { get; set; }
    }
}