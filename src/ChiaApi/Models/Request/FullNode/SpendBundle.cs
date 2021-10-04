using ChiaApi.Models.Responses.Shared;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Request.FullNode
{
    public class SpendBundle
    {
        [JsonProperty("aggregated_signature", NullValueHandling = NullValueHandling.Ignore)]
        public string AggregatedSignature { get; set; } = string.Empty;

        [JsonProperty("coin_solutions", NullValueHandling = NullValueHandling.Ignore)]
        public List<CoinSpend>? CoinSolutions { get; set; }
    }
}