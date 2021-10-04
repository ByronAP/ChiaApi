using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Wallet
{
    public class PrivateKeyResponse : ApiResponseBase
    {
        [JsonProperty("private_key", NullValueHandling = NullValueHandling.Ignore)]
        public PrivateKey? PrivateKey { get; set; }
    }
}