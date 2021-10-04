using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.Wallet
{
    public class PoolWalletInfoResponse : ApiResponseBase
    {
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public PoolWalletState? State { get; set; }

        [JsonProperty("unconfirmed_transactions", NullValueHandling = NullValueHandling.Ignore)]
        public List<TransactionItem>? UnconfirmedTransactions { get; set; }
    }
}