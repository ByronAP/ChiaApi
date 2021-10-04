using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    public class IpSpVdf
    {
        [JsonProperty("challenge", NullValueHandling = NullValueHandling.Ignore)]
        public string Challenge { get; set; } = string.Empty;

        [JsonProperty("number_of_iterations", NullValueHandling = NullValueHandling.Ignore)]
        public ulong NumberOfIterations { get; set; }

        [JsonProperty("output", NullValueHandling = NullValueHandling.Ignore)]
        public IpSpVdfOutput? Output { get; set; }
    }
}