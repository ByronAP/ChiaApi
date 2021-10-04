using ChiaApi.Models.Responses.Shared;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.Wallet
{
    public class TransactionItem
    {
        [JsonProperty("additions", NullValueHandling = NullValueHandling.Ignore)]
        public List<CoinItem>? Additions { get; set; }

        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Amount { get; set; }

        [JsonProperty("confirmed", NullValueHandling = NullValueHandling.Ignore)]
        public bool Confirmed { get; set; }

        [JsonProperty("confirmed_at_height", NullValueHandling = NullValueHandling.Ignore)]
        public ulong ConfirmedAtHeight { get; set; }

        [JsonProperty("created_at_time", NullValueHandling = NullValueHandling.Ignore)]
        public ulong CreatedAtTime { get; set; }

        [JsonProperty("fee_amount", NullValueHandling = NullValueHandling.Ignore)]
        public ulong FeeAmount { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("removals", NullValueHandling = NullValueHandling.Ignore)]
        public List<CoinItem>? Removals { get; set; }

        [JsonProperty("sent", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Sent { get; set; }

        [JsonProperty("sent_to", NullValueHandling = NullValueHandling.Ignore)]
        public List<dynamic>? SentTo { get; set; }

        [JsonProperty("spend_bundle", NullValueHandling = NullValueHandling.Ignore)]
        public SpendBundle? SpendBundle { get; set; }

        [JsonProperty("to_puzzle_hash", NullValueHandling = NullValueHandling.Ignore)]
        public string ToPuzzleHash { get; set; } = string.Empty;

        [JsonProperty("trade_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeId { get; set; } = string.Empty;

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public uint Type { get; set; }

        [JsonProperty("wallet_id", NullValueHandling = NullValueHandling.Ignore)]
        public uint WalletId { get; set; }
    }
}