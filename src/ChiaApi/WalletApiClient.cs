/*
 * STOPPING WORK ON THIS PART OF THE API UNTIL THE CAT1 vs CC api differences are resolved
 * https://www.chia.net/2021/09/23/chia-token-standard-naming.en.html
 * https://github.com/Chia-Network/chia-blockchain/discussions/8689
 * 
 * Pending question about host parameter usage
 * https://github.com/Chia-Network/chia-blockchain/discussions/8679
 */

using ChiaApi.Models.Request.Wallet;
using ChiaApi.Models.Responses.Shared;
using ChiaApi.Models.Responses.Wallet;
using RestSharp;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChiaApi
{
    public class WalletApiClient : ApiClientBase
    {
        public WalletApiClient(ChiaApiConfig chiaApiConfig) : base(chiaApiConfig) { }

        #region Key management

        public async Task<FingerprintResponse> LoginAsync(ulong fingerprint, LoginType loginType, string filePath = "", string host = "")
        {
            filePath = System.Web.HttpUtility.JavaScriptStringEncode(filePath);
            const string resource = "log_in";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"fingerprint\":{fingerprint},\"type\":\"{loginType.ToString().ToLowerInvariant()}\",\"host\":\"{host}\",\"file_path\":\"{filePath}\"}}");

            var response = await _restClient.ExecuteAsync<FingerprintResponse>(request);

            return response;
        }

        public Task<FingerprintResponse> LoginAsync(ulong fingerprint)
        {
            return LoginAsync(fingerprint, LoginType.Start);
        }

        public Task<FingerprintResponse> LoginAndRestoreAsync(ulong fingerprint, string filePath)
        {
            return LoginAsync(fingerprint, LoginType.Restore_Backup, filePath);
        }

        public Task<FingerprintResponse> LoginAndSkipAsync(ulong fingerprint)
        {
            return LoginAsync(fingerprint, LoginType.Skip);
        }

        public async Task<PublicKeysResponse> GetPublicKeysAsync()
        {
            const string resource = "get_public_keys";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody("{}");

            var response = await _restClient.ExecuteAsync<PublicKeysResponse>(request);

            return response;
        }

        public async Task<PrivateKeyResponse> GetPrivateKeyAsync(ulong fingerprint)
        {
            const string resource = "get_private_key";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"fingerprint\":{fingerprint}}}");

            var response = await _restClient.ExecuteAsync<PrivateKeyResponse>(request);

            return response;
        }

        public async Task<GenerateMnemonicResponse> GenerateMnemonicAsync()
        {
            const string resource = "generate_mnemonic";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody("{}");

            var response = await _restClient.ExecuteAsync<GenerateMnemonicResponse>(request);

            return response;
        }

        public async Task<FingerprintResponse> AddKeyAsync(IEnumerable<string> mnemonic)
        {
            const string resource = "add_key";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);

            var jsonStringBuilder = new StringBuilder();

            jsonStringBuilder.Append("{\"type\":\"new_wallet\",\"mnemonic\":[");

            foreach (var word in mnemonic) jsonStringBuilder.Append("\"\"").Append(word).Append("\"\",");

            jsonStringBuilder = jsonStringBuilder.Remove(jsonStringBuilder.Length - 1, 1);

            jsonStringBuilder.Append("]}");

            request.AddJsonBody(jsonStringBuilder.ToString());

            var response = await _restClient.ExecuteAsync<FingerprintResponse>(request);

            return response;
        }

        public async Task<BoolResponse> DeleteKeyAsync(ulong fingerprint)
        {
            const string resource = "delete_key";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"fingerprint\":{fingerprint}}}");

            var response = await _restClient.ExecuteAsync<BoolResponse>(request);

            return response;
        }

        public async Task<BoolResponse> DeleteAllKeysAsync()
        {
            const string resource = "delete_all_keys";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody("{}");

            var response = await _restClient.ExecuteAsync<BoolResponse>(request);

            return response;
        }

        public async Task<CheckDeleteKeyResponse> CheckDeleteKeyAsync(ulong fingerprint)
        {
            const string resource = "check_delete_key";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"fingerprint\":{fingerprint}}}");

            var response = await _restClient.ExecuteAsync<CheckDeleteKeyResponse>(request);

            return response;
        }

        #endregion

        #region Wallet node

        public async Task<SyncStatusResponse> GetSyncStatusAsync()
        {
            const string resource = "get_sync_status";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody("{}");

            var response = await _restClient.ExecuteAsync<SyncStatusResponse>(request);

            return response;
        }

        public async Task<HeightInfoResponse> GetHeightInfoAsync()
        {
            const string resource = "get_height_info";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody("{}");

            var response = await _restClient.ExecuteAsync<HeightInfoResponse>(request);

            return response;
        }

        public async Task<dynamic> FarmBlockAsync(string address)
        {
            const string resource = "farm_block";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"address\":\"{address}\"}}");

            var response = await _restClient.ExecuteAsync<HeightInfoResponse>(request);

            return response;
        }

        #endregion

        #region Wallet management

        public async Task<WalletsResponse> GetWalletsAsync()
        {
            const string resource = "get_wallets";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody("{}");

            var response = await _restClient.ExecuteAsync<WalletsResponse>(request);

            return response;
        }

        public async Task<T> CreateWalletAsync<T>(WalletType walletType, CreateWalletMode? createWalletMode = null,
            string? fileName = null, string? pubKey = null, RLType? rLType = null, Did_Type? didType = null,
            decimal? fee = null, uint? amount = null, WalletInitialTargetState? initialTargetState = null,
            IEnumerable<string>? backupDids = null, uint? backupIdsNeeded = null, ulong? p2SingletonDelayTime = null,
            string? p2SingletonDelayedPh = null, string host = "")
        {
            if (fileName == null) fileName = System.Web.HttpUtility.JavaScriptStringEncode(fileName);
            if (initialTargetState != null) initialTargetState.PoolUrl = System.Web.HttpUtility.JavaScriptStringEncode(initialTargetState.PoolUrl);

            const string resource = "create_wallet";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);

            var jsonStringBuilder = new StringBuilder();

            jsonStringBuilder.Append("{");
            jsonStringBuilder.Append("\"host\":\"").Append(host).Append("\",");
            jsonStringBuilder.Append("\"wallet_type\":\"").Append(walletType.ToString().ToLowerInvariant()).Append("\",");
            if (createWalletMode != null) jsonStringBuilder.Append("\"mode\":\"").Append(createWalletMode.ToString().ToLowerInvariant()).Append("\",");
            if (backupIdsNeeded != null) jsonStringBuilder.Append("\"num_of_backup_ids_needed\":").Append(backupIdsNeeded).Append(",");
            if (pubKey != null) jsonStringBuilder.Append("\"pubkey\":\"").Append(pubKey).Append("\",");
            if (rLType != null) jsonStringBuilder.Append("\"rl_type\":\"").Append(rLType.ToString().ToLowerInvariant()).Append("\",");
            if (didType != null) jsonStringBuilder.Append("\"did_type\":\"").Append(didType.ToString().ToLowerInvariant()).Append("\",");
            if (fee != null) jsonStringBuilder.Append("\"fee\":").Append(fee).Append(",");
            if (amount != null) jsonStringBuilder.Append("\"amount\":").Append(amount).Append(",");
            if (fileName != null) jsonStringBuilder.Append("\"filename\":\"").Append(fileName).Append("\",");
            if (initialTargetState != null) jsonStringBuilder.Append("\"initial_target_state\":{\"target_puzzle_hash\":\"").Append(initialTargetState.TargetPuzzleHash).Append("\",\"relative_lock_height\":").Append(initialTargetState.RelativeLockHeight).Append(",\"pool_url\":\"").Append(initialTargetState.PoolUrl).Append("\",\"state\":\"").Append(initialTargetState.State).Append("\"},");
            if (p2SingletonDelayTime != null) jsonStringBuilder.Append("\"p2_singleton_delay_time\":").Append(p2SingletonDelayTime).Append(",");
            if (p2SingletonDelayedPh != null) jsonStringBuilder.Append("\"p2_singleton_delayed_ph \":\"").Append(p2SingletonDelayedPh).Append("\",");
            if (backupDids != null)
            {
                jsonStringBuilder.Append("\"backup_dids\":[");

                foreach (var backupDid in backupDids) jsonStringBuilder.Append("\"").Append(backupDid).Append("\",");

                if (jsonStringBuilder.ToString().EndsWith(',')) jsonStringBuilder = jsonStringBuilder.Remove(jsonStringBuilder.Length - 1, 1);

                jsonStringBuilder.Append("]");
            }

            if (jsonStringBuilder.ToString().EndsWith(',')) jsonStringBuilder = jsonStringBuilder.Remove(jsonStringBuilder.Length - 1, 1);

            jsonStringBuilder.Append("}");

            request.AddJsonBody(jsonStringBuilder.ToString());

            var response = await _restClient.ExecuteAsync<T>(request);

            return response;
        }

        public Task<dynamic> CreateNewDidWalletAsync(uint amount = 1)
        {
            var emptyBackupDids = new List<string>();
            return CreateWalletAsync<dynamic>(walletType: WalletType.DID_Wallet, didType: Did_Type.New, amount: amount, backupDids: emptyBackupDids);
        }

        public Task<dynamic> CreateNewDidWalletFromRecoveryAsync(string filename)
        {
            return CreateWalletAsync<dynamic>(walletType: WalletType.DID_Wallet, didType: Did_Type.Recovery, fileName: filename);
        }

        public Task<TransactionResponse> CreateNewPoolWalletAsync(CreateWalletMode mode, WalletInitialTargetState targetState, ulong p2SingletonDelayTime, string p2SingletonDelayedPh)
        {
            return CreateWalletAsync<TransactionResponse>(walletType: WalletType.Pool_Wallet, createWalletMode: mode, initialTargetState: targetState, p2SingletonDelayedPh: p2SingletonDelayedPh, p2SingletonDelayTime: p2SingletonDelayTime);
        }

        #endregion

        #region Wallet

        public async Task<WalletBalanceResponse> GetWalletBalanceAsync(uint walletId)
        {
            const string resource = "get_wallet_balance";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"wallet_id\":{walletId}}}");

            var response = await _restClient.ExecuteAsync<WalletBalanceResponse>(request);

            return response;
        }

        public async Task<TransactionResponse> GetTransactionAsync(string transactionId)
        {
            const string resource = "get_transaction";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"transaction_id\":{transactionId}}}");

            var response = await _restClient.ExecuteAsync<TransactionResponse>(request);

            return response;
        }

        public async Task<TransactionsResponse> GetTransactionsAsync(string transactionId)
        {
            const string resource = "get_transactions";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"transaction_id\":{transactionId}}}");

            var response = await _restClient.ExecuteAsync<TransactionsResponse>(request);

            return response;
        }

        public async Task<AddressResponse> GetNextAddressAsync(uint walletId)
        {
            const string resource = "get_next_address";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"wallet_id\":{walletId},\"new_address\":true}}");

            var response = await _restClient.ExecuteAsync<AddressResponse>(request);

            return response;
        }

        public async Task<AddressResponse> GetAddressAsync(uint walletId)
        {
            const string resource = "get_next_address";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"wallet_id\":{walletId},\"new_address\":false}}");

            var response = await _restClient.ExecuteAsync<AddressResponse>(request);

            return response;
        }

        public async Task<TransactionResponse> SendTransactionAsync(uint walletId, ulong amount, ulong fee, string address)
        {
            const string resource = "send_transaction";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"wallet_id\":{walletId},\"amount\":{amount},\"fee\":{fee},\"address\":\"{address}\"}}");

            var response = await _restClient.ExecuteAsync<TransactionResponse>(request);

            return response;
        }

        public async Task<dynamic> DeleteUnconfirmedTransactionsAsync(uint walletId)
        {
            const string resource = "delete_unconfirmed_transactions";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"wallet_id\":{walletId}}}");

            var response = await _restClient.ExecuteAsync<dynamic>(request);

            return response;
        }

        public async Task<SignedTransactionResponse> CreateSignedTransactionAsync(ulong amount, ulong fee, string puzzleHash)
        {
            // TODO: use bech32 to convert the addresses to puzzle hashes instead of requiring the puzzle hash 
            const string resource = "create_signed_transaction";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"fee\":{fee},\"additions\":[{{\"amount\":{amount},\"puzzle_hash\":\"{puzzleHash}\"}}]}}");

            var response = await _restClient.ExecuteAsync<SignedTransactionResponse>(request);

            return response;
        }

        public async Task<TransactionsCountResponse> GetTransactionCountAsync(uint walletId)
        {
            const string resource = "get_transaction_count";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"wallet_id\":{walletId}}}");

            var response = await _restClient.ExecuteAsync<TransactionsCountResponse>(request);

            return response;
        }

        public async Task<FarmedAmountResponse> GetFarmedAmountAsync()
        {
            const string resource = "get_farmed_amount";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody("{}");

            var response = await _restClient.ExecuteAsync<FarmedAmountResponse>(request);

            return response;
        }

        public async Task<BoolResponse> CreateBackupAsync(string filePath)
        {
            filePath = System.Web.HttpUtility.JavaScriptStringEncode(filePath);

            const string resource = "create_backup";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"file_path\":\"{filePath}\"}}");

            var response = await _restClient.ExecuteAsync<BoolResponse>(request);

            return response;
        }

        public async Task<TransactionResponse> SendTransactionMulti(string walletId, ulong fee, IEnumerable<TransactionAddition> additions)
        {
            const string resource = "send_transaction_multi";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);

            var jsonStringBuilder = new StringBuilder();

            jsonStringBuilder.Append("{\"wallet_id\":").Append(walletId).Append(",\"fee\":").Append(fee).Append(",\"additions\"[");

            foreach (TransactionAddition addition in additions) jsonStringBuilder.Append("{\"puzzle_hash\":\"").Append(addition.PuzzleHash).Append("\",\"amount\":").Append(addition.Amount).Append("},");

            jsonStringBuilder = jsonStringBuilder.Remove(jsonStringBuilder.Length - 1, 1);

            jsonStringBuilder.Append("]}");

            var response = await _restClient.ExecuteAsync<TransactionResponse>(request);

            return response;
        }

        #endregion

        #region Coloured coins and trading
        /*
         * # Coloured coins and trading #
        * "/cc_get_colour": self.cc_get_colour
        * "/create_offer_for_ids": self.create_offer_for_ids
        * "/get_discrepancies_for_offer": self.get_discrepancies_for_offer
        * "/respond_to_offer": self.respond_to_offer
        * "/get_trade": self.get_trade
        * "/get_all_trades": self.get_all_trades
        * "/cancel_trade": self.cancel_trade
        */

        public async Task<WalletIdResponse> CCSetNameAsync(uint walletId, string name)
        {
            const string resource = "cc_set_name";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"wallet_id\":{walletId},\"name\":\"{name}\"}}");

            var response = await _restClient.ExecuteAsync<WalletIdResponse>(request);

            return response;
        }

        public async Task<WalletNameIdResponse> CCGetNameAsync(uint walletId)
        {
            const string resource = "cc_get_name";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"wallet_id\":{walletId}}}");

            var response = await _restClient.ExecuteAsync<WalletNameIdResponse>(request);

            return response;
        }

        public async Task<TransactionResponse> CCSpendAsync(uint walletId, string innerAddress, ulong amount, ulong fee)
        {
            const string resource = "cc_spend";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"wallet_id\":{walletId},\"inner_address\":\"{innerAddress}\",\"amount\":{amount},\"fee\":{fee}");

            var response = await _restClient.ExecuteAsync<TransactionResponse>(request);

            return response;
        }

        #endregion

        #region DID Wallet
        /*
         * # DID Wallet #
        * "/did_update_recovery_ids": self.did_update_recovery_ids
        * "/did_get_pubkey": self.did_get_pubkey
        * "/did_get_did": self.did_get_did
        * "/did_get_recovery_list": self.did_get_recovery_list
        * "/did_get_information_needed_for_recovery": self.did_get_information_needed_for_recovery
        * "/did_create_backup_file": self.did_create_backup_file
        */

        public async Task<dynamic> DidRecoverySpendAsync(ulong walletId, string attestFilename)
        {
            attestFilename = System.Web.HttpUtility.JavaScriptStringEncode(attestFilename);

            const string resource = "did_recovery_spend";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"wallet_id\":{walletId},\"attest_filename\":\"{attestFilename}\"}}");

            var response = await _restClient.ExecuteAsync<dynamic>(request);

            return response;
        }

        public async Task<dynamic> DidCreateAttestAsync(ulong walletId, string coinName, string pubKey, string puzzleHash, string filename)
        {
            filename = System.Web.HttpUtility.JavaScriptStringEncode(filename);

            const string resource = "did_create_attest";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"wallet_id\":{walletId},\"coin_name\":\"{coinName}\",\"pubkey\":\"{pubKey}\",\"puzhash\":\"{puzzleHash}\",\"filename\":\"{filename}\"}}");

            var response = await _restClient.ExecuteAsync<dynamic>(request);

            return response;
        }

        #endregion

        #region RL wallet
        /*
         * # Rate Limited Wallet #
        * "/rl_set_user_info": self.rl_set_user_info
        * "/send_clawback_transaction:": self.send_clawback_transaction
        * "/add_rate_limited_funds:": self.add_rate_limited_funds
        */
        #endregion

        #region Pool Wallet

        public async Task<TransactionResponse> PoolWalletSelfPoolAsync(ulong walletId)
        {
            const string resource = "pw_self_pool";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"wallet_id\":{walletId}}}");

            var response = await _restClient.ExecuteAsync<TransactionResponse>(request);

            return response;
        }

        public async Task<TransactionResponse> PoolWalletJoinPoolAsync(ulong walletId, string targetPuzzleHash, ulong relativeLockHeight, string poolUrl)
        {
            poolUrl = System.Web.HttpUtility.JavaScriptStringEncode(poolUrl);

            const string resource = "pw_join_pool";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"wallet_id\":{walletId},\"target_puzzlehash\":\"{targetPuzzleHash}\",\"relative_lock_height\":{relativeLockHeight},\"pool_url\":\"{poolUrl}\"}}");

            var response = await _restClient.ExecuteAsync<TransactionResponse>(request);

            return response;
        }

        public async Task<TransactionResponse> PoolWalletAbsorbRewardsAsync(ulong walletId, ulong fee)
        {
            const string resource = "pw_absorb_rewards";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"wallet_id\":{walletId},\"fee\":{fee}}}");

            var response = await _restClient.ExecuteAsync<TransactionResponse>(request);

            return response;
        }

        public async Task<PoolWalletInfoResponse> GetPoolWalletStatusAsync(ulong walletId, ulong fee)
        {
            const string resource = "pw_status";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"wallet_id\":{walletId}}}");

            var response = await _restClient.ExecuteAsync<PoolWalletInfoResponse>(request);

            return response;
        }
        #endregion
    }
}
