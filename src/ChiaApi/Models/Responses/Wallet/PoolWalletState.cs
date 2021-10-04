using ChiaApi.Models.Responses.Shared;
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Wallet
{
    public class PoolWalletState
    {
        [JsonProperty("current", NullValueHandling = NullValueHandling.Ignore)]
        public PoolWalletCurrentState? Current { get; set; }

        [JsonProperty("current_inner", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentInner { get; set; } = string.Empty;

        [JsonProperty("launcher_coin", NullValueHandling = NullValueHandling.Ignore)]
        public CoinItem? LauncherCoin { get; set; }

        [JsonProperty("launcher_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LauncherId { get; set; } = string.Empty;

        [JsonProperty("p2_singleton_puzzle_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string P2SingletonPuzzleHash { get; set; } = string.Empty;

        [JsonProperty("singleton_block_height", NullValueHandling = NullValueHandling.Ignore)]
        public ulong SingletonBlockHeight { get; set; }

        [JsonProperty("target", NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; } = string.Empty;

        [JsonProperty("tip_singleton_coin_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TipSingletonCoinId { get; set; } = string.Empty;
    }
}