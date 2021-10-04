using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Farmer
{
    public class PoolLoginLinkResponse : ApiResponseBase
    {
        [JsonProperty("login_link", NullValueHandling = NullValueHandling.Ignore)]
        public string LoginLink { get; set; } = string.Empty;
    }
}