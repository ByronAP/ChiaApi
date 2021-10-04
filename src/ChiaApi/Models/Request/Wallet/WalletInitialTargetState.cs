namespace ChiaApi.Models.Request.Wallet
{
    public class WalletInitialTargetState
    {
        public string PoolUrl { get; set; } = string.Empty;
        public uint RelativeLockHeight { get; set; }
        public string State { get; set; } = string.Empty;
        public string TargetPuzzleHash { get; set; } = string.Empty;
    }
}