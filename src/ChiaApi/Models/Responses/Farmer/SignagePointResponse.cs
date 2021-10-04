using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.Farmer
{
    public class SignagePointResponse : ApiResponseBase
    {
        [JsonProperty("proofs", NullValueHandling = NullValueHandling.Ignore)]
        public List<dynamic>? Proofs { get; set; }

        [JsonProperty("signage_point", NullValueHandling = NullValueHandling.Ignore)]
        public SignagePoint? SignagePoint { get; set; }

    }
}
