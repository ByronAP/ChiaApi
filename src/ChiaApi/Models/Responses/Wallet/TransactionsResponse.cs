using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.Wallet
{
    public class TransactionsResponse : ApiResponseBase
    {
        [JsonProperty("transactions", NullValueHandling = NullValueHandling.Ignore)]
        public List<TransactionItem>? Transactions { get; set; }

        [JsonProperty("wallet_id", NullValueHandling = NullValueHandling.Ignore)]
        public uint WalletId { get; set; }
    }
}