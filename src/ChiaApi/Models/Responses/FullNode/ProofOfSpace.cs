using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    public class ProofOfSpace
    {
        [JsonProperty("challenge", NullValueHandling = NullValueHandling.Ignore)]
        public string Challenge { get; set; } = string.Empty;

        [JsonProperty("plot_public_key", NullValueHandling = NullValueHandling.Ignore)]
        public string PlotPublicKey { get; set; } = string.Empty;

        [JsonProperty("pool_contract_puzzle_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolContractPuzzleHash { get; set; } = string.Empty;

        [JsonProperty("pool_public_key", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolPublicKey { get; set; } = string.Empty;

        [JsonProperty("proof", NullValueHandling = NullValueHandling.Ignore)]
        public string Proof { get; set; } = string.Empty;

        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public uint Size { get; set; }
    }
}