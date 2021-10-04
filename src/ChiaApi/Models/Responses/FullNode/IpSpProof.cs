using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    public class IpSpProof
    {
        [JsonProperty("normalized_to_identity", NullValueHandling = NullValueHandling.Ignore)]
        public bool NormalizedToIdentity { get; set; }

        [JsonProperty("witness", NullValueHandling = NullValueHandling.Ignore)]
        public string Witness { get; set; } = string.Empty;

        [JsonProperty("witness_type", NullValueHandling = NullValueHandling.Ignore)]
        public uint WitnessType { get; set; }
    }
}
