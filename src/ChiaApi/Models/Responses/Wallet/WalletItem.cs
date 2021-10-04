using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Wallet
{
    public class WalletItem
    {
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public string Data { get; set; } = string.Empty;

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public uint Type { get; set; }
    }
}