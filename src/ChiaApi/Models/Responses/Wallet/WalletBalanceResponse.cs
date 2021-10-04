using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Wallet
{
    public class WalletBalanceResponse : ApiResponseBase
    {
        [JsonProperty("wallet_balance", NullValueHandling = NullValueHandling.Ignore)]
        public WalletBalanceItem? WalletBalance { get; set; }
    }
}
