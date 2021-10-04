using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Harvester
{
    public class PlotItem
    {
        [JsonProperty("filename", NullValueHandling = NullValueHandling.Ignore)]
        public string Filename { get; set; } = string.Empty;

        [JsonProperty("file_size", NullValueHandling = NullValueHandling.Ignore)]
        public ulong FileSize { get; set; }

        [JsonProperty("plot_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PlotId { get; set; } = string.Empty;

        [JsonProperty("plot_public_key", NullValueHandling = NullValueHandling.Ignore)]
        public string PlotPublicKey { get; set; } = string.Empty;

        [JsonProperty("plot-seed", NullValueHandling = NullValueHandling.Ignore)]
        public string PlotSeed { get; set; } = string.Empty;

        [JsonProperty("pool_contract_puzzle_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolContractPuzzleHash { get; set; } = string.Empty;

        [JsonProperty("pool_public_key", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolPublicKey { get; set; } = string.Empty;

        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public uint Size { get; set; }

        [JsonProperty("time_modified", NullValueHandling = NullValueHandling.Ignore)]
        public decimal TimeModified { get; set; }
    }
}