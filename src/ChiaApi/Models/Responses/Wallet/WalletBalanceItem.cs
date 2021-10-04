using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.Wallet
{
    public class WalletBalanceItem
    {
        [JsonProperty("confirmed_wallet_balance", NullValueHandling = NullValueHandling.Ignore)]
        public ulong ConfirmedWalletBalance { get; set; }

        [JsonProperty("max_send_amount", NullValueHandling = NullValueHandling.Ignore)]
        public ulong MaxSendAmount { get; set; }

        [JsonProperty("pending_change", NullValueHandling = NullValueHandling.Ignore)]
        public ulong PendingChange { get; set; }

        [JsonProperty("pending_coin_removal_count", NullValueHandling = NullValueHandling.Ignore)]
        public ulong PendingCoinRemovalCount { get; set; }

        [JsonProperty("spendable_balance", NullValueHandling = NullValueHandling.Ignore)]
        public ulong SpendableBalance { get; set; }

        [JsonProperty("unconfirmed_wallet_balance", NullValueHandling = NullValueHandling.Ignore)]
        public ulong UnconfirmedWalletBalance { get; set; }

        [JsonProperty("unspent_coin_count", NullValueHandling = NullValueHandling.Ignore)]
        public uint UnspentCoinCount { get; set; }

        [JsonProperty("wallet_id", NullValueHandling = NullValueHandling.Ignore)]
        public uint WalletId { get; set; }
    }
}