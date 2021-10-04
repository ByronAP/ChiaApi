using Newtonsoft.Json;
using System.Numerics;

namespace ChiaApi.Models.Responses.FullNode
{
    public class NetworkSpaceResponse : ApiResponseBase
    {
        [JsonProperty("space", NullValueHandling = NullValueHandling.Ignore)]
        public BigInteger Space { get; set; }
    }
}