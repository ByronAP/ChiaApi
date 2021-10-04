using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Wallet
{
    public class HeightInfoResponse : ApiResponseBase
    {
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Height { get; set; }
    }
}
