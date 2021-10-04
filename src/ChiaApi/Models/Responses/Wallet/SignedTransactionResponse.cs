using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Wallet
{
    public class SignedTransactionResponse : ApiResponseBase
    {
        [JsonProperty("signed_tx", NullValueHandling = NullValueHandling.Ignore)]
        public TransactionItem? SignedTx { get; set; }
    }
}