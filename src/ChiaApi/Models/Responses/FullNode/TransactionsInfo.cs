using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.FullNode
{
    public class TransactionsInfo
    {
        [JsonProperty("aggregated_signature", NullValueHandling = NullValueHandling.Ignore)]
        public string AggregatedSignature { get; set; } = string.Empty;

        [JsonProperty("cost", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Cost { get; set; }

        [JsonProperty("fees", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Fees { get; set; }

        [JsonProperty("generator_refs_root", NullValueHandling = NullValueHandling.Ignore)]
        public string GeneratorRefsRoot { get; set; } = string.Empty;

        [JsonProperty("generator_root", NullValueHandling = NullValueHandling.Ignore)]
        public string GeneratorRoot { get; set; } = string.Empty;

        [JsonProperty("reward_claims_incorporated", NullValueHandling = NullValueHandling.Ignore)]
        public List<RewardClaimsIncorporated>? RewardClaimsIncorporated { get; set; }
    }
}
