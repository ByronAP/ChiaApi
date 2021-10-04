using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Wallet
{
    public class AddressResponse : ApiResponseBase
    {
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; } = string.Empty;

        [JsonProperty("wallet_id", NullValueHandling = NullValueHandling.Ignore)]
        public uint WalletId { get; set; }
    }
}