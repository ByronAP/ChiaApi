using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Wallet
{
    public class TransactionsCountResponse : ApiResponseBase
    {
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public uint Count { get; set; }

        [JsonProperty("wallet_id", NullValueHandling = NullValueHandling.Ignore)]
        public uint WalletId { get; set; }
    }
}