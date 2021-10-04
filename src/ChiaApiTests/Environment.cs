namespace ChiaApiTests
{
    internal static class Environment
    {
        // full node
        public const string FullNodeHost = "127.0.0.1";
        public const uint FullNodePort = 8555;
        public const string FullNodeCertFile = "C:\\Users\\bapen\\.chia\\mainnet\\config\\ssl\\full_node\\private_full_node.crt";
        public const string FullNodeKeyFile = "C:\\Users\\bapen\\.chia\\mainnet\\config\\ssl\\full_node\\private_full_node.key";

        // wallet
        public const string WalletHost = "127.0.0.1";
        public const uint WalletPort = 9256;
        public const string WalletCertFile = "C:\\Users\\bapen\\.chia\\mainnet\\config\\ssl\\wallet\\private_wallet.crt";
        public const string WalletKeyFile = "C:\\Users\\bapen\\.chia\\mainnet\\config\\ssl\\wallet\\private_wallet.key";
    }
}
