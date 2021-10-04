using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    public class BlockchainStateResponse : ApiResponseBase
    {
        [JsonProperty("blockchain_state", NullValueHandling = NullValueHandling.Ignore)]
        public BlockchainState? BlockchainState { get; set; }
    }
}
