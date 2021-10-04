using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.Shared
{
    public class SpendBundle
    {
        [JsonProperty("aggregated_signature", NullValueHandling = NullValueHandling.Ignore)]
        public string AggregatedSignature { get; set; } = string.Empty;

        [JsonProperty("coin_spends", NullValueHandling = NullValueHandling.Ignore)]
        public List<CoinSpend>? CoinSpends { get; set; }
    }
}