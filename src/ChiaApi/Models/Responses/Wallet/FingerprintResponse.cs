using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Wallet
{
    public class FingerprintResponse : ApiResponseBase
    {
        [JsonProperty("fingerprint", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Fingerprint { get; set; }
    }
}
