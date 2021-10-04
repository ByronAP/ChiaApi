using Newtonsoft.Json;

namespace ChiaApi.Models.Responses
{
    public abstract class ApiResponseBase
    {
        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public string Error { get; set; } = string.Empty;

        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}