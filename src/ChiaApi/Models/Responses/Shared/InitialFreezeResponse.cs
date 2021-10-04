using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Shared
{
    public class InitialFreezeResponse : ApiResponseBase
    {
        [JsonProperty("INITIAL_FREEZE_END_TIMESTAMP", NullValueHandling = NullValueHandling.Ignore)]
        public ulong InitialFreezeEndTimestamp { get; set; }
    }
}