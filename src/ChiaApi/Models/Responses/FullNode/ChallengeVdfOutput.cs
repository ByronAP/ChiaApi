using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    public class ChallengeVdfOutput
    {
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public string Data { get; set; } = string.Empty;
    }
}