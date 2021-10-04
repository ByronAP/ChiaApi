using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Wallet
{
    public class WalletNameIdResponse : ApiResponseBase
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("wallet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WalletId { get; set; } = string.Empty;
    }
}
