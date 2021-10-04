using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.FullNode
{
    public class CoinRecordsResponse : ApiResponseBase
    {
        [JsonProperty("coin_records", NullValueHandling = NullValueHandling.Ignore)]
        public List<CoinRecord>? CoinRecords { get; set; }
    }
}