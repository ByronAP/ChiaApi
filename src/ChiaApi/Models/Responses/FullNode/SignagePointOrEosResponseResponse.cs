using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    public class SignagePointOrEosResponseResponse : ApiResponseBase
    {
        [JsonProperty("eos", NullValueHandling = NullValueHandling.Ignore)]
        public EosItem? Eos { get; set; }

        [JsonProperty("reverted", NullValueHandling = NullValueHandling.Ignore)]
        public bool Reverted { get; set; }

        [JsonProperty("time_received", NullValueHandling = NullValueHandling.Ignore)]
        public decimal TimeReceived { get; set; }
    }
}
