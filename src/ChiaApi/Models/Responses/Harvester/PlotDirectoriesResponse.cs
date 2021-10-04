using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.Harvester
{
    public class PlotDirectoriesResponse : ApiResponseBase
    {
        [JsonProperty("directories", NullValueHandling = NullValueHandling.Ignore)]
        public List<string>? Directories { get; set; }
    }
}
