using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.Farmer
{
    public class PoolStateResponse : ApiResponseBase
    {
        [JsonProperty("pool_state", NullValueHandling = NullValueHandling.Ignore)]
        public List<PoolState>? PoolState { get; set; }
    }
}
