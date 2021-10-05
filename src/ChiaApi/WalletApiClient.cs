// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-30-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="WalletApiClient.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
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
    /// <summary>
    /// Class WalletApiClient.
    /// Implements the <see cref="ChiaApi.ApiClientBase" />
    /// </summary>
    /// <seealso cref="ChiaApi.ApiClientBase" />
    public class WalletApiClient : ApiClientBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletApiClient"/> class.
        /// </summary>
        /// <param name="chiaApiConfig">The chia API configuration.</param>
        public WalletApiClient(ChiaApiConfig chiaApiConfig) : base(chiaApiConfig)
        {
        }

        #region Key management

        /// <summary>
        /// Add key as an asynchronous operation.
        /// </summary>
        /// <param name="mnemonic">The mnemonic.</param>
        /// <returns>A Task&lt;FingerprintResponse&gt; representing the asynchronous operation.</returns>
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

        /// <summary>
        /// Check delete key as an asynchronous operation.
        /// </summary>
        /// <param name="fingerprint">The fingerprint.</param>
        /// <returns>A Task&lt;CheckDeleteKeyResponse&gt; representing the asynchronous operation.</returns>
        public async Task<CheckDeleteKeyResponse> CheckDeleteKeyAsync(ulong fingerprint)
        {
            const string resource = "check_delete_key";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"fingerprint\":{fingerprint}}}");

            var response = await _restClient.ExecuteAsync<CheckDeleteKeyResponse>(request);

            return response;
        }

        /// <summary>
        /// Delete all keys as an asynchronous operation.
        /// </summary>
        /// <returns>A Task&lt;BoolResponse&gt; representing the asynchronous operation.</returns>
        public async Task<BoolResponse> DeleteAllKeysAsync()
        {
            const string resource = "delete_all_keys";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody("{}");

            var response = await _restClient.ExecuteAsync<BoolResponse>(request);

            return response;
        }

        /// <summary>
        /// Delete key as an asynchronous operation.
        /// </summary>
        /// <param name="fingerprint">The fingerprint.</param>
        /// <returns>A Task&lt;BoolResponse&gt; representing the asynchronous operation.</returns>
        public async Task<BoolResponse> DeleteKeyAsync(ulong fingerprint)
        {
            const string resource = "delete_key";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"fingerprint\":{fingerprint}}}");

            var response = await _restClient.ExecuteAsync<BoolResponse>(request);

            return response;
        }

        /// <summary>
        /// Generate mnemonic as an asynchronous operation.
        /// </summary>
        /// <returns>A Task&lt;GenerateMnemonicResponse&gt; representing the asynchronous operation.</returns>
        public async Task<GenerateMnemonicResponse> GenerateMnemonicAsync()
        {
            const string resource = "generate_mnemonic";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody("{}");

            var response = await _restClient.ExecuteAsync<GenerateMnemonicResponse>(request);

            return response;
        }

        /// <summary>
        /// Get private key as an asynchronous operation.
        /// </summary>
        /// <param name="fingerprint">The fingerprint.</param>
        /// <returns>A Task&lt;PrivateKeyResponse&gt; representing the asynchronous operation.</returns>
        public async Task<PrivateKeyResponse> GetPrivateKeyAsync(ulong fingerprint)
        {
            const string resource = "get_private_key";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"fingerprint\":{fingerprint}}}");

            var response = await _restClient.ExecuteAsync<PrivateKeyResponse>(request);

            return response;
        }

        /// <summary>
        /// Get public keys as an asynchronous operation.
        /// </summary>
        /// <returns>A Task&lt;PublicKeysResponse&gt; representing the asynchronous operation.</returns>
        public async Task<PublicKeysResponse> GetPublicKeysAsync()
        {
            const string resource = "get_public_keys";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody("{}");

            var response = await _restClient.ExecuteAsync<PublicKeysResponse>(request);

            return response;
        }

        /// <summary>
        /// Logins the and restore asynchronous.
        /// </summary>
        /// <param name="fingerprint">The fingerprint.</param>
        /// <param name="filePath">The file path.</param>
        /// <returns>Task&lt;FingerprintResponse&gt;.</returns>
        public Task<FingerprintResponse> LoginAndRestoreAsync(ulong fingerprint, string filePath)
        {
            return LoginAsync(fingerprint, LoginType.Restore_Backup, filePath);
        }

        /// <summary>
        /// Logins the and skip asynchronous.
        /// </summary>
        /// <param name="fingerprint">The fingerprint.</param>
        /// <returns>Task&lt;FingerprintResponse&gt;.</returns>
        public Task<FingerprintResponse> LoginAndSkipAsync(ulong fingerprint)
        {
            return LoginAsync(fingerprint, LoginType.Skip);
        }

        /// <summary>
        /// Login as an asynchronous operation.
        /// </summary>
        /// <param name="fingerprint">The fingerprint.</param>
        /// <param name="loginType">Type of the login.</param>
        /// <param name="filePath">The file path.</param>
        /// <param name="host">The host.</param>
        /// <returns>A Task&lt;FingerprintResponse&gt; representing the asynchronous operation.</returns>
        public async Task<FingerprintResponse> LoginAsync(ulong fingerprint, LoginType loginType, string filePath = "", string host = "")
        {
            filePath = System.Web.HttpUtility.JavaScriptStringEncode(filePath);
            const string resource = "log_in";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"fingerprint\":{fingerprint},\"type\":\"{loginType.ToString().ToLowerInvariant()}\",\"host\":\"{host}\",\"file_path\":\"{filePath}\"}}");

            var response = await _restClient.ExecuteAsync<FingerprintResponse>(request);

            return response;
        }

        /// <summary>
        /// Logins the asynchronous.
        /// </summary>
        /// <param name="fingerprint">The fingerprint.</param>
        /// <returns>Task&lt;FingerprintResponse&gt;.</returns>
        public Task<FingerprintResponse> LoginAsync(ulong fingerprint)
        {
            return LoginAsync(fingerprint, LoginType.Start);
        }

        #endregion Key management

        #region Wallet node

        /// <summary>
        /// Farm block as an asynchronous operation.
        /// </summary>
        /// <param name="address">The address.</param>
        /// <returns>A Task&lt;dynamic&gt; representing the asynchronous operation.</returns>
        public async Task<dynamic> FarmBlockAsync(string address)
        {
            const string resource = "farm_block";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"address\":\"{address}\"}}");

            var response = await _restClient.ExecuteAsync<HeightInfoResponse>(request);

            return response;
        }

        /// <summary>
        /// Get height information as an asynchronous operation.
        /// </summary>
        /// <returns>A Task&lt;HeightInfoResponse&gt; representing the asynchronous operation.</returns>
        public async Task<HeightInfoResponse> GetHeightInfoAsync()
        {
            const string resource = "get_height_info";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody("{}");

            var response = await _restClient.ExecuteAsync<HeightInfoResponse>(request);

            return response;
        }

        /// <summary>
        /// Get synchronize status as an asynchronous operation.
        /// </summary>
        /// <returns>A Task&lt;SyncStatusResponse&gt; representing the asynchronous operation.</returns>
        public async Task<SyncStatusResponse> GetSyncStatusAsync()
        {
            const string resource = "get_sync_status";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody("{}");

            var response = await _restClient.ExecuteAsync<SyncStatusResponse>(request);

            return response;
        }

        #endregion Wallet node

        #region Wallet management

        /// <summary>
        /// Creates the new did wallet asynchronous.
        /// </summary>
        /// <param name="amount">The amount.</param>
        /// <returns>Task&lt;dynamic&gt;.</returns>
        public Task<dynamic> CreateNewDidWalletAsync(uint amount = 1)
        {
            var emptyBackupDids = new List<string>();
            return CreateWalletAsync<dynamic>(walletType: WalletType.DID_Wallet, didType: Did_Type.New, amount: amount, backupDids: emptyBackupDids);
        }

        /// <summary>
        /// Creates the new did wallet from recovery asynchronous.
        /// </summary>
        /// <param name="filename">The filename.</param>
        /// <returns>Task&lt;dynamic&gt;.</returns>
        public Task<dynamic> CreateNewDidWalletFromRecoveryAsync(string filename)
        {
            return CreateWalletAsync<dynamic>(walletType: WalletType.DID_Wallet, didType: Did_Type.Recovery, fileName: filename);
        }

        /// <summary>
        /// Creates the new pool wallet asynchronous.
        /// </summary>
        /// <param name="mode">The mode.</param>
        /// <param name="targetState">State of the target.</param>
        /// <param name="p2SingletonDelayTime">The p2 singleton delay time.</param>
        /// <param name="p2SingletonDelayedPh">The p2 singleton delayed ph.</param>
        /// <returns>Task&lt;TransactionResponse&gt;.</returns>
        public Task<TransactionResponse> CreateNewPoolWalletAsync(CreateWalletMode mode, WalletInitialTargetState targetState, ulong p2SingletonDelayTime, string p2SingletonDelayedPh)
        {
            return CreateWalletAsync<TransactionResponse>(walletType: WalletType.Pool_Wallet, createWalletMode: mode, initialTargetState: targetState, p2SingletonDelayedPh: p2SingletonDelayedPh, p2SingletonDelayTime: p2SingletonDelayTime);
        }

        /// <summary>
        /// Create wallet as an asynchronous operation.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="walletType">Type of the wallet.</param>
        /// <param name="createWalletMode">The create wallet mode.</param>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="pubKey">The pub key.</param>
        /// <param name="rLType">Type of the r l.</param>
        /// <param name="didType">Type of the did.</param>
        /// <param name="fee">The fee.</param>
        /// <param name="amount">The amount.</param>
        /// <param name="initialTargetState">Initial state of the target.</param>
        /// <param name="backupDids">The backup dids.</param>
        /// <param name="backupIdsNeeded">The backup ids needed.</param>
        /// <param name="p2SingletonDelayTime">The p2 singleton delay time.</param>
        /// <param name="p2SingletonDelayedPh">The p2 singleton delayed ph.</param>
        /// <param name="host">The host.</param>
        /// <returns>A Task&lt;T&gt; representing the asynchronous operation.</returns>
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

        /// <summary>
        /// Get wallets as an asynchronous operation.
        /// </summary>
        /// <returns>A Task&lt;WalletsResponse&gt; representing the asynchronous operation.</returns>
        public async Task<WalletsResponse> GetWalletsAsync()
        {
            const string resource = "get_wallets";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody("{}");

            var response = await _restClient.ExecuteAsync<WalletsResponse>(request);

            return response;
        }

        #endregion Wallet management

        #region Wallet

        /// <summary>
        /// Create backup as an asynchronous operation.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns>A Task&lt;BoolResponse&gt; representing the asynchronous operation.</returns>
        public async Task<BoolResponse> CreateBackupAsync(string filePath)
        {
            filePath = System.Web.HttpUtility.JavaScriptStringEncode(filePath);

            const string resource = "create_backup";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"file_path\":\"{filePath}\"}}");

            var response = await _restClient.ExecuteAsync<BoolResponse>(request);

            return response;
        }

        /// <summary>
        /// Create signed transaction as an asynchronous operation.
        /// </summary>
        /// <param name="amount">The amount.</param>
        /// <param name="fee">The fee.</param>
        /// <param name="puzzleHash">The puzzle hash.</param>
        /// <returns>A Task&lt;SignedTransactionResponse&gt; representing the asynchronous operation.</returns>
        public async Task<SignedTransactionResponse> CreateSignedTransactionAsync(ulong amount, ulong fee, string puzzleHash)
        {
            // TODO: use bech32 to convert the addresses to puzzle hashes instead of requiring the puzzle hash
            const string resource = "create_signed_transaction";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"fee\":{fee},\"additions\":[{{\"amount\":{amount},\"puzzle_hash\":\"{puzzleHash}\"}}]}}");

            var response = await _restClient.ExecuteAsync<SignedTransactionResponse>(request);

            return response;
        }

        /// <summary>
        /// Delete unconfirmed transactions as an asynchronous operation.
        /// </summary>
        /// <param name="walletId">The wallet identifier.</param>
        /// <returns>A Task&lt;dynamic&gt; representing the asynchronous operation.</returns>
        public async Task<dynamic> DeleteUnconfirmedTransactionsAsync(uint walletId)
        {
            const string resource = "delete_unconfirmed_transactions";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"wallet_id\":{walletId}}}");

            var response = await _restClient.ExecuteAsync<dynamic>(request);

            return response;
        }

        /// <summary>
        /// Get address as an asynchronous operation.
        /// </summary>
        /// <param name="walletId">The wallet identifier.</param>
        /// <returns>A Task&lt;AddressResponse&gt; representing the asynchronous operation.</returns>
        public async Task<AddressResponse> GetAddressAsync(uint walletId)
        {
            const string resource = "get_next_address";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"wallet_id\":{walletId},\"new_address\":false}}");

            var response = await _restClient.ExecuteAsync<AddressResponse>(request);

            return response;
        }

        /// <summary>
        /// Get farmed amount as an asynchronous operation.
        /// </summary>
        /// <returns>A Task&lt;FarmedAmountResponse&gt; representing the asynchronous operation.</returns>
        public async Task<FarmedAmountResponse> GetFarmedAmountAsync()
        {
            const string resource = "get_farmed_amount";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody("{}");

            var response = await _restClient.ExecuteAsync<FarmedAmountResponse>(request);

            return response;
        }

        /// <summary>
        /// Get next address as an asynchronous operation.
        /// </summary>
        /// <param name="walletId">The wallet identifier.</param>
        /// <returns>A Task&lt;AddressResponse&gt; representing the asynchronous operation.</returns>
        public async Task<AddressResponse> GetNextAddressAsync(uint walletId)
        {
            const string resource = "get_next_address";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"wallet_id\":{walletId},\"new_address\":true}}");

            var response = await _restClient.ExecuteAsync<AddressResponse>(request);

            return response;
        }

        /// <summary>
        /// Get transaction as an asynchronous operation.
        /// </summary>
        /// <param name="transactionId">The transaction identifier.</param>
        /// <returns>A Task&lt;TransactionResponse&gt; representing the asynchronous operation.</returns>
        public async Task<TransactionResponse> GetTransactionAsync(string transactionId)
        {
            const string resource = "get_transaction";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"transaction_id\":{transactionId}}}");

            var response = await _restClient.ExecuteAsync<TransactionResponse>(request);

            return response;
        }

        /// <summary>
        /// Get transaction count as an asynchronous operation.
        /// </summary>
        /// <param name="walletId">The wallet identifier.</param>
        /// <returns>A Task&lt;TransactionsCountResponse&gt; representing the asynchronous operation.</returns>
        public async Task<TransactionsCountResponse> GetTransactionCountAsync(uint walletId)
        {
            const string resource = "get_transaction_count";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"wallet_id\":{walletId}}}");

            var response = await _restClient.ExecuteAsync<TransactionsCountResponse>(request);

            return response;
        }

        /// <summary>
        /// Get transactions as an asynchronous operation.
        /// </summary>
        /// <param name="transactionId">The transaction identifier.</param>
        /// <returns>A Task&lt;TransactionsResponse&gt; representing the asynchronous operation.</returns>
        public async Task<TransactionsResponse> GetTransactionsAsync(string transactionId)
        {
            const string resource = "get_transactions";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"transaction_id\":{transactionId}}}");

            var response = await _restClient.ExecuteAsync<TransactionsResponse>(request);

            return response;
        }

        /// <summary>
        /// Get wallet balance as an asynchronous operation.
        /// </summary>
        /// <param name="walletId">The wallet identifier.</param>
        /// <returns>A Task&lt;WalletBalanceResponse&gt; representing the asynchronous operation.</returns>
        public async Task<WalletBalanceResponse> GetWalletBalanceAsync(uint walletId)
        {
            const string resource = "get_wallet_balance";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"wallet_id\":{walletId}}}");

            var response = await _restClient.ExecuteAsync<WalletBalanceResponse>(request);

            return response;
        }

        /// <summary>
        /// Send transaction as an asynchronous operation.
        /// </summary>
        /// <param name="walletId">The wallet identifier.</param>
        /// <param name="amount">The amount.</param>
        /// <param name="fee">The fee.</param>
        /// <param name="address">The address.</param>
        /// <returns>A Task&lt;TransactionResponse&gt; representing the asynchronous operation.</returns>
        public async Task<TransactionResponse> SendTransactionAsync(uint walletId, ulong amount, ulong fee, string address)
        {
            const string resource = "send_transaction";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"wallet_id\":{walletId},\"amount\":{amount},\"fee\":{fee},\"address\":\"{address}\"}}");

            var response = await _restClient.ExecuteAsync<TransactionResponse>(request);

            return response;
        }

        /// <summary>
        /// Sends the transaction multi.
        /// </summary>
        /// <param name="walletId">The wallet identifier.</param>
        /// <param name="fee">The fee.</param>
        /// <param name="additions">The additions.</param>
        /// <returns>TransactionResponse.</returns>
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

        #endregion Wallet

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

        /// <summary>
        /// Cc get name as an asynchronous operation.
        /// </summary>
        /// <param name="walletId">The wallet identifier.</param>
        /// <returns>A Task&lt;WalletNameIdResponse&gt; representing the asynchronous operation.</returns>
        public async Task<WalletNameIdResponse> CCGetNameAsync(uint walletId)
        {
            const string resource = "cc_get_name";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"wallet_id\":{walletId}}}");

            var response = await _restClient.ExecuteAsync<WalletNameIdResponse>(request);

            return response;
        }

        /// <summary>
        /// Cc set name as an asynchronous operation.
        /// </summary>
        /// <param name="walletId">The wallet identifier.</param>
        /// <param name="name">The name.</param>
        /// <returns>A Task&lt;WalletIdResponse&gt; representing the asynchronous operation.</returns>
        public async Task<WalletIdResponse> CCSetNameAsync(uint walletId, string name)
        {
            const string resource = "cc_set_name";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"wallet_id\":{walletId},\"name\":\"{name}\"}}");

            var response = await _restClient.ExecuteAsync<WalletIdResponse>(request);

            return response;
        }

        /// <summary>
        /// Cc spend as an asynchronous operation.
        /// </summary>
        /// <param name="walletId">The wallet identifier.</param>
        /// <param name="innerAddress">The inner address.</param>
        /// <param name="amount">The amount.</param>
        /// <param name="fee">The fee.</param>
        /// <returns>A Task&lt;TransactionResponse&gt; representing the asynchronous operation.</returns>
        public async Task<TransactionResponse> CCSpendAsync(uint walletId, string innerAddress, ulong amount, ulong fee)
        {
            const string resource = "cc_spend";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"wallet_id\":{walletId},\"inner_address\":\"{innerAddress}\",\"amount\":{amount},\"fee\":{fee}");

            var response = await _restClient.ExecuteAsync<TransactionResponse>(request);

            return response;
        }

        #endregion Coloured coins and trading

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

        /// <summary>
        /// Did create attest as an asynchronous operation.
        /// </summary>
        /// <param name="walletId">The wallet identifier.</param>
        /// <param name="coinName">Name of the coin.</param>
        /// <param name="pubKey">The pub key.</param>
        /// <param name="puzzleHash">The puzzle hash.</param>
        /// <param name="filename">The filename.</param>
        /// <returns>A Task&lt;dynamic&gt; representing the asynchronous operation.</returns>
        public async Task<dynamic> DidCreateAttestAsync(ulong walletId, string coinName, string pubKey, string puzzleHash, string filename)
        {
            filename = System.Web.HttpUtility.JavaScriptStringEncode(filename);

            const string resource = "did_create_attest";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"wallet_id\":{walletId},\"coin_name\":\"{coinName}\",\"pubkey\":\"{pubKey}\",\"puzhash\":\"{puzzleHash}\",\"filename\":\"{filename}\"}}");

            var response = await _restClient.ExecuteAsync<dynamic>(request);

            return response;
        }

        /// <summary>
        /// Did recovery spend as an asynchronous operation.
        /// </summary>
        /// <param name="walletId">The wallet identifier.</param>
        /// <param name="attestFilename">The attest filename.</param>
        /// <returns>A Task&lt;dynamic&gt; representing the asynchronous operation.</returns>
        public async Task<dynamic> DidRecoverySpendAsync(ulong walletId, string attestFilename)
        {
            attestFilename = System.Web.HttpUtility.JavaScriptStringEncode(attestFilename);

            const string resource = "did_recovery_spend";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"wallet_id\":{walletId},\"attest_filename\":\"{attestFilename}\"}}");

            var response = await _restClient.ExecuteAsync<dynamic>(request);

            return response;
        }

        #endregion DID Wallet

        #region RL wallet

        /*
         * # Rate Limited Wallet #
        * "/rl_set_user_info": self.rl_set_user_info
        * "/send_clawback_transaction:": self.send_clawback_transaction
        * "/add_rate_limited_funds:": self.add_rate_limited_funds
        */

        #endregion RL wallet

        #region Pool Wallet

        /// <summary>
        /// Get pool wallet status as an asynchronous operation.
        /// </summary>
        /// <param name="walletId">The wallet identifier.</param>
        /// <param name="fee">The fee.</param>
        /// <returns>A Task&lt;PoolWalletInfoResponse&gt; representing the asynchronous operation.</returns>
        public async Task<PoolWalletInfoResponse> GetPoolWalletStatusAsync(ulong walletId, ulong fee)
        {
            const string resource = "pw_status";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"wallet_id\":{walletId}}}");

            var response = await _restClient.ExecuteAsync<PoolWalletInfoResponse>(request);

            return response;
        }

        /// <summary>
        /// Pool wallet absorb rewards as an asynchronous operation.
        /// </summary>
        /// <param name="walletId">The wallet identifier.</param>
        /// <param name="fee">The fee.</param>
        /// <returns>A Task&lt;TransactionResponse&gt; representing the asynchronous operation.</returns>
        public async Task<TransactionResponse> PoolWalletAbsorbRewardsAsync(ulong walletId, ulong fee)
        {
            const string resource = "pw_absorb_rewards";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"wallet_id\":{walletId},\"fee\":{fee}}}");

            var response = await _restClient.ExecuteAsync<TransactionResponse>(request);

            return response;
        }

        /// <summary>
        /// Pool wallet join pool as an asynchronous operation.
        /// </summary>
        /// <param name="walletId">The wallet identifier.</param>
        /// <param name="targetPuzzleHash">The target puzzle hash.</param>
        /// <param name="relativeLockHeight">Height of the relative lock.</param>
        /// <param name="poolUrl">The pool URL.</param>
        /// <returns>A Task&lt;TransactionResponse&gt; representing the asynchronous operation.</returns>
        public async Task<TransactionResponse> PoolWalletJoinPoolAsync(ulong walletId, string targetPuzzleHash, ulong relativeLockHeight, string poolUrl)
        {
            poolUrl = System.Web.HttpUtility.JavaScriptStringEncode(poolUrl);

            const string resource = "pw_join_pool";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"wallet_id\":{walletId},\"target_puzzlehash\":\"{targetPuzzleHash}\",\"relative_lock_height\":{relativeLockHeight},\"pool_url\":\"{poolUrl}\"}}");

            var response = await _restClient.ExecuteAsync<TransactionResponse>(request);

            return response;
        }

        /// <summary>
        /// Pool wallet self pool as an asynchronous operation.
        /// </summary>
        /// <param name="walletId">The wallet identifier.</param>
        /// <returns>A Task&lt;TransactionResponse&gt; representing the asynchronous operation.</returns>
        public async Task<TransactionResponse> PoolWalletSelfPoolAsync(ulong walletId)
        {
            const string resource = "pw_self_pool";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"wallet_id\":{walletId}}}");

            var response = await _restClient.ExecuteAsync<TransactionResponse>(request);

            return response;
        }

        #endregion Pool Wallet
    }
}