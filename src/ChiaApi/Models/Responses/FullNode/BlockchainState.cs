using Newtonsoft.Json;
using System.Numerics;

namespace ChiaApi.Models.Responses.FullNode
{
    public class BlockchainState
    {
        [JsonProperty("difficulty", NullValueHandling = NullValueHandling.Ignore)]
        public uint Difficulty { get; set; }

        [JsonProperty("genesis_challenge_initialized", NullValueHandling = NullValueHandling.Ignore)]
        public bool GenesisChallengeInitialized { get; set; }

        [JsonProperty("mempool_size", NullValueHandling = NullValueHandling.Ignore)]
        public uint MempoolSize { get; set; }

        [JsonProperty("peak", NullValueHandling = NullValueHandling.Ignore)]
        public BlockchainPeak? Peak { get; set; }

        [JsonProperty("space", NullValueHandling = NullValueHandling.Ignore)]
        public BigInteger Space { get; set; }

        [JsonProperty("sub_slot_iters", NullValueHandling = NullValueHandling.Ignore)]
        public ulong SubSlotIters { get; set; }

        [JsonProperty("sync", NullValueHandling = NullValueHandling.Ignore)]
        public BlockchainSync? Sync { get; set; }
    }
}
