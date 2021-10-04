using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.FullNode
{
    public class Condition
    {
        [JsonProperty("opcode", NullValueHandling = NullValueHandling.Ignore)]
        public string Opcode { get; set; } = string.Empty;

        [JsonProperty("vars", NullValueHandling = NullValueHandling.Ignore)]
        public List<string>? Vars { get; set; }
    }
}
