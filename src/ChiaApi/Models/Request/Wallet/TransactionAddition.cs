namespace ChiaApi.Models.Request.Wallet
{
    public class TransactionAddition
    {
        public ulong Amount { get; set; }
        public string PuzzleHash { get; set; } = string.Empty;
    }
}