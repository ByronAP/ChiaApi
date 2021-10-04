using ChiaApi.Models.Responses.Shared;
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    public class PuzzleAndSolutionResponse : ApiResponseBase
    {
        [JsonProperty("coin_solution", NullValueHandling = NullValueHandling.Ignore)]
        public CoinSpend? CoinSolution { get; set; }
    }
}
