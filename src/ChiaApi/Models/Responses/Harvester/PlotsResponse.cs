using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.Harvester
{
    public class PlotsResponse : ApiResponseBase
    {
        [JsonProperty("failed_to_open_filenames", NullValueHandling = NullValueHandling.Ignore)]
        public List<string>? FailedToOpenFilenames { get; set; }

        [JsonProperty("not_found_filenames", NullValueHandling = NullValueHandling.Ignore)]
        public List<string>? NotFoundFilenames { get; set; }

        [JsonProperty("plots", NullValueHandling = NullValueHandling.Ignore)]
        public List<PlotItem>? Plots { get; set; }
    }
}