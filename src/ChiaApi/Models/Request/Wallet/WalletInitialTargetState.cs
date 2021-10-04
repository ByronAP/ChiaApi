namespace ChiaApi.Models.Request.Wallet
{
    public class WalletInitialTargetState
    {
        public string TargetPuzzleHash { get; set; } = string.Empty;

        public uint RelativeLockHeight { get; set; }

        public string PoolUrl { get; set; } = string.Empty;

        public string State { get; set; } = string.Empty;
    }
}
