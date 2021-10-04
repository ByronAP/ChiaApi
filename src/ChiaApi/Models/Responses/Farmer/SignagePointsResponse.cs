using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.Farmer
{
    public class SignagePointsResponse : ApiResponseBase
    {
        [JsonProperty("signage_points", NullValueHandling = NullValueHandling.Ignore)]
        public List<SignagePointItem>? SignagePoints { get; set; }
    }
}
