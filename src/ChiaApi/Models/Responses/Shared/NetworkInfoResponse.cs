using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Shared
{
    public class NetworkInfoResponse : ApiResponseBase
    {
        [JsonProperty("network_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkName { get; set; } = string.Empty;

        [JsonProperty("network_prefix", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkPrefix { get; set; } = string.Empty;
    }
}