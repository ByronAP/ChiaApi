using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.Wallet
{
    public class WalletsResponse : ApiResponseBase
    {
        [JsonProperty("wallets", NullValueHandling = NullValueHandling.Ignore)]
        public List<WalletItem>? Wallets { get; set; }
    }
}
