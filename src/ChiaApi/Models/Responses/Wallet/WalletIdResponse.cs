using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Wallet
{
    public class WalletIdResponse : ApiResponseBase
    {
        [JsonProperty("wallet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WalletId { get; set; } = string.Empty;
    }
}