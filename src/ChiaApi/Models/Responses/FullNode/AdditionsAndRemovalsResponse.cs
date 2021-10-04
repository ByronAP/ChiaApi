using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.FullNode
{
    public class AdditionsAndRemovalsResponse : ApiResponseBase
    {
        [JsonProperty("additions", NullValueHandling = NullValueHandling.Ignore)]
        public List<CoinRecord>? Additions { get; set; }

        [JsonProperty("removals", NullValueHandling = NullValueHandling.Ignore)]
        public List<CoinRecord>? Removals { get; set; }
    }
}