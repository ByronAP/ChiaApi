using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.Wallet
{
    public class PublicKeysResponse : ApiResponseBase
    {
        [JsonProperty("public_key_fingerprints", NullValueHandling = NullValueHandling.Ignore)]
        public List<ulong>? PublicKeyFingerprints { get; set; }
    }
}