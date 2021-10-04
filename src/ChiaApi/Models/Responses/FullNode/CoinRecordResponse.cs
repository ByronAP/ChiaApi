using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    public class CoinRecordResponse : ApiResponseBase
    {
        [JsonProperty("coin_record", NullValueHandling = NullValueHandling.Ignore)]
        public CoinRecord? CoinRecord { get; set; }
    }
}