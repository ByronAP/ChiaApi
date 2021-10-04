namespace ChiaApi.Models.Request.Wallet
{
    public class TransactionAddition
    {
        public string PuzzleHash { get; set; } = string.Empty;

        public ulong Amount { get; set; }
    }
}
