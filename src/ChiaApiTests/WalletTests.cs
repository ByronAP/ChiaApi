using ChiaApi;

namespace ChiaApiTests
{
    public class WalletTests
    {
        private readonly WalletApiClient _walletApiClient;

        public WalletTests()
        {
            var config = new ChiaApiConfig(Environment.WalletCertFile, Environment.WalletKeyFile, Environment.WalletHost, Environment.WalletPort);
            _walletApiClient = new WalletApiClient(config);
        }

        #region Key management

        #endregion

        #region Wallet node

        #endregion

        #region Wallet management

        #endregion

        #region Wallet

        #endregion

        #region Coloured coins and trading

        #endregion

        #region DID Wallet

        #endregion

        #region RL wallet

        #endregion

        #region Pool Wallet

        #endregion
    }
}
