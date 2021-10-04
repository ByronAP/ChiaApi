using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Wallet
{
    public class TransactionResponse : ApiResponseBase
    {
        [JsonProperty("transaction", NullValueHandling = NullValueHandling.Ignore)]
        public TransactionItem? Transaction { get; set; }

        [JsonProperty("transaction_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TransactionId { get; set; } = string.Empty;
    }
}