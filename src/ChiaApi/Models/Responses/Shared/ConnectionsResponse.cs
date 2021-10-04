using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.Shared
{
    public class ConnectionsResponse : ApiResponseBase
    {
        [JsonProperty("connections", NullValueHandling = NullValueHandling.Ignore)]
        public List<ConnectionInfo>? Connections { get; set; }
    }
}
