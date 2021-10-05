// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-28-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="FullNodeApiClient.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using ChiaApi.Models.Request.FullNode;
using ChiaApi.Models.Responses.FullNode;
using ChiaApi.Models.Responses.Shared;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChiaApi
{
    /// <summary>
    /// Chia full node API client.
    /// <see href="https://github.com/Chia-Network/chia-blockchain/wiki/RPC-Interfaces#full-node" target="_blank">Chia WIKI RPC Full Node</see>
    /// <see href="https://github.com/Chia-Network/chia-blockchain/blob/main/chia/rpc/full_node_rpc_api.py">Chia Source Full Node RPC</see>
    /// </summary>
    /// <seealso cref="ChiaApi.ApiClientBase" />
    public class FullNodeApiClient : ApiClientBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FullNodeApiClient"/> class.
        /// </summary>
        /// <param name="chiaApiConfig">The chia API configuration.</param>
        public FullNodeApiClient(ChiaApiConfig chiaApiConfig) : base(chiaApiConfig)
        {
        }

        #region Blockchain

        /// <summary>
        /// Get current information about the blockchain, including the peak, sync information, difficulty, mempool size, etc as an asynchronous operation.
        /// </summary>
        /// <returns>A Task&lt;<see cref="BlockchainStateResponse"/>&gt; representing the asynchronous operation.</returns>
        public async Task<BlockchainStateResponse> GetBlockchainStateAsync()
        {
            const string resource = "get_blockchain_state";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody("{}");

            var response = await _restClient.ExecuteAsync<BlockchainStateResponse>(request);

            return response;
        }

        /// <summary>
        /// Get full block by the associated <paramref name="headerHash"/> as an asynchronous operation.
        /// </summary>
        /// <param name="headerHash">The header hash of the block.</param>
        /// <returns>A Task&lt;<see cref="BlockResponse"/>&gt; representing the asynchronous operation.</returns>
        public async Task<BlockResponse> GetBlockAsync(string headerHash)
        {
            const string resource = "get_block";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"header_hash\":\"{headerHash}\"}}");

            var response = await _restClient.ExecuteAsync<BlockResponse>(request);

            return response;
        }

        /// <summary>
        /// Get full blocks from <paramref name="start"/> height to <paramref name="end"/> height as an asynchronous operation.
        /// </summary>
        /// <param name="start">The starting height.</param>
        /// <param name="end">The ending height (non-inclusive).</param>
        /// <param name="excludeHeaderHash">if set to <c>true</c> the header hash is not included.</param>
        /// <returns>A Task&lt;<see cref="BlocksResponse"/>&gt; representing the asynchronous operation.</returns>
        public async Task<BlocksResponse> GetBlocksAsync(ulong start, ulong end, bool excludeHeaderHash)
        {
            const string resource = "get_blocks";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"start\":{start},\"end\":{end},\"excludeHeaderHash\":{excludeHeaderHash.ToString().ToLowerInvariant()}}}");

            var response = await _restClient.ExecuteAsync<BlocksResponse>(request);

            return response;
        }

        /// <summary>
        /// Get block record by <paramref name="height"/> as an asynchronous operation.
        /// </summary>
        /// <param name="height">The height of the block.</param>
        /// <returns>A Task&lt;<see cref="BlockRecordResponse"/>&gt; representing the asynchronous operation.</returns>
        public async Task<BlockRecordResponse> GetBlockRecordByHeightAsync(ulong height)
        {
            const string resource = "get_block_record_by_height";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"height\":{height}}}");

            var response = await _restClient.ExecuteAsync<BlockRecordResponse>(request);

            return response;
        }

        /// <summary>
        /// Get block record by <paramref name="headerHash"/> as an asynchronous operation.
        /// </summary>
        /// <param name="headerHash">The header hash.</param>
        /// <returns>A Task&lt;<see cref="BlockRecordResponse"/>&gt; representing the asynchronous operation.</returns>
        public async Task<BlockRecordResponse> GetBlockRecordAsync(string headerHash)
        {
            const string resource = "get_block_record";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"header_hash\":\"{headerHash}\"}}");

            var response = await _restClient.ExecuteAsync<BlockRecordResponse>(request);

            return response;
        }

        /// <summary>
        /// Get block records <paramref name="startHeight"/> height to <paramref name="endHeight"/> height as an asynchronous operation.
        /// </summary>
        /// <param name="startHeight">The start height.</param>
        /// <param name="endHeight">The end height (non-inclusive).</param>
        /// <returns>A Task&lt;<see cref="BlockRecordsResponse"/>&gt; representing the asynchronous operation.</returns>
        public async Task<BlockRecordsResponse> GetBlockRecordsAsync(ulong? startHeight = null, ulong? endHeight = null)
        {
            const string resource = "get_block_records";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"start\":{startHeight},\"end\":{endHeight}}}");

            var response = await _restClient.ExecuteAsync<BlockRecordsResponse>(request);

            return response;
        }

        /// <summary>
        /// Get unfinished block headers as an asynchronous operation.
        /// </summary>
        /// <returns>A Task&lt;<see cref="UnfinishedBlockHeadersResponse"/>&gt; representing the asynchronous operation.</returns>
        public async Task<UnfinishedBlockHeadersResponse> GetUnfinishedBlockHeadersAsync()
        {
            const string resource = "get_unfinished_block_headers";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody("{}");

            var response = await _restClient.ExecuteAsync<UnfinishedBlockHeadersResponse>(request);

            return response;
        }

        /// <summary>
        /// Get network space estimate (in bytes) as an asynchronous operation.
        /// Calculated from between <paramref name="olderBlockHeaderHash"/> and <paramref name="newerBlockHeaderHash"/>.
        /// </summary>
        /// <param name="olderBlockHeaderHash">The older block header hash.</param>
        /// <param name="newerBlockHeaderHash">The newer block header hash.</param>        
        /// <returns>A Task&lt;<see cref="NetworkSpaceResponse"/>&gt; representing the asynchronous operation.</returns>
        public async Task<NetworkSpaceResponse> GetNetworkSpaceAsync(string olderBlockHeaderHash, string newerBlockHeaderHash)
        {
            const string resource = "get_network_space";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"newer_block_header_hash\":\"{newerBlockHeaderHash}\",\"older_block_header_hash\":\"{olderBlockHeaderHash}\"}}");

            var response = await _restClient.ExecuteAsync<NetworkSpaceResponse>(request);

            return response;
        }

        /// <summary>
        /// Get additions and removals (state transitions) as an asynchronous operation.
        /// </summary>
        /// <param name="headerHash">The header hash of the block containing the additions and removals.</param>
        /// <returns>A Task&lt;<see cref="AdditionsAndRemovalsResponse"/>&gt; representing the asynchronous operation.</returns>
        public async Task<AdditionsAndRemovalsResponse> GetAdditionsAndRemovalsAsync(string headerHash)
        {
            const string resource = "get_additions_and_removals";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"header_hash\":\"{headerHash}\"}}");

            var response = await _restClient.ExecuteAsync<AdditionsAndRemovalsResponse>(request);

            return response;
        }

        // get_recent_signage_point_or_eos
        // {"challenge_hash": "0xe42c620431b4a2bc33ed634060c0bc5470c23f37f38fef5baf0e3b3e37dbe4db"}
        // have not found an sp hash that works
        /// <summary>
        /// Get recent signage point or eos by <paramref name="spHash"/> or <paramref name="challengeHash"/> as an asynchronous operation.
        /// </summary>
        /// <param name="spHash">The sp hash.</param>
        /// <param name="challengeHash">The challenge hash.</param>
        /// <returns>A Task&lt;<see cref="SignagePointOrEosResponseResponse"/>&gt; representing the asynchronous operation.</returns>
        /// <exception cref="System.ArgumentNullException">Must supply a hash.</exception>
        public async Task<SignagePointOrEosResponseResponse> GetRecentSignagePointOrEosAsync(string? spHash, string? challengeHash)
        {
            if (string.IsNullOrWhiteSpace(spHash) && string.IsNullOrEmpty(challengeHash))
                throw new ArgumentNullException("Must supply a hash.");

            const string resource = "get_recent_signage_point_or_eos";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            if (!string.IsNullOrEmpty(spHash)) request.AddJsonBody($"{{\"sp_hash\":\"{spHash}\"}}");
            else if (!string.IsNullOrEmpty(challengeHash)) request.AddJsonBody($"{{\"challenge_hash\":\"{challengeHash}\"}}");
            var response = await _restClient.ExecuteAsync<SignagePointOrEosResponseResponse>(request);

            return response;
        }

        #endregion Blockchain

        #region Coins

        /// <summary>
        /// Get coin records by puzzle hash as an asynchronous operation.
        /// It is recommended that a start and end height be passed to reduce 
        /// lookup time.
        /// </summary>
        /// <param name="puzzleHash">The puzzle hash.</param>
        /// <param name="startHeight">The optional start block height.</param>
        /// <param name="endHeight">The optional end block height.</param>
        /// <param name="includeSpentCoins">if set to <c>true</c> spent coins will be included.</param>
        /// <returns>A Task&lt;<see cref="CoinRecordsResponse"/>&gt; representing the asynchronous operation.</returns>
        public async Task<CoinRecordsResponse> GetCoinRecordsByPuzzleHashAsync(string puzzleHash, ulong? startHeight = null, ulong? endHeight = null, bool includeSpentCoins = true)
        {
            const string resource = "get_coin_records_by_puzzle_hash";

            var jsonStringBuilder = new StringBuilder("{");
            jsonStringBuilder.Append("\"puzzle_hash\":\"").Append(puzzleHash).Append("\"");
            if (startHeight != null) jsonStringBuilder.Append(",\"start_height\":").Append(startHeight);
            if (endHeight != null) jsonStringBuilder.Append(",\"end_height\":").Append(endHeight);
            jsonStringBuilder.Append(",\"include_spent_coins\":").Append(includeSpentCoins.ToString().ToLowerInvariant()).Append("}");

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody(jsonStringBuilder.ToString());

            jsonStringBuilder.Clear();

            var response = await _restClient.ExecuteAsync<CoinRecordsResponse>(request);

            return response;
        }

        /// <summary>
        /// Get coin records by puzzle hashes as an asynchronous operation.
        /// </summary>
        /// <param name="puzzleHashes">The puzzle hashes.</param>
        /// <param name="includeSpentCoins">if set to <c>true</c> spent coins will be included.</param>
        /// <returns>A Task&lt;<see cref="CoinRecordsResponse"/>&gt; representing the asynchronous operation.</returns>
        public async Task<CoinRecordsResponse> GetCoinRecordsByPuzzleHashesAsync(IEnumerable<string> puzzleHashes, bool includeSpentCoins = true)
        {
            const string resource = "get_coin_records_by_puzzle_hashes";

            var jsonStringBuilder = new StringBuilder("{");
            jsonStringBuilder.Append("\"puzzle_hashes\":[");

            foreach (var puzzleHash in puzzleHashes) jsonStringBuilder.Append("\"").Append(puzzleHash).Append("\",");

            jsonStringBuilder = jsonStringBuilder.Remove(jsonStringBuilder.Length - 1, 1);

            jsonStringBuilder.Append("],\"include_spent_coins\":").Append(includeSpentCoins.ToString().ToLowerInvariant()).Append("}");

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody(jsonStringBuilder.ToString());

            jsonStringBuilder.Clear();

            var response = await _restClient.ExecuteAsync<CoinRecordsResponse>(request);

            return response;
        }

        /// <summary>
        /// Get coin record by name/id as an asynchronous operation.
        /// </summary>
        /// <param name="name">The coin record name/id.</param>
        /// <returns>A Task&lt;<see cref="CoinRecordResponse"/>&gt; representing the asynchronous operation.</returns>
        public async Task<CoinRecordResponse> GetCoinRecordByNameAsync(string name)
        {
            const string resource = "get_coin_record_by_name";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"name\":\"{name}\"}}");

            var response = await _restClient.ExecuteAsync<CoinRecordResponse>(request);

            return response;
        }

        /// <summary>
        /// Get coin records by names/ids as an asynchronous operation.
        /// It is recommended that a start and end height be passed to reduce 
        /// lookup time.
        /// </summary>
        /// <param name="names">The names/ids.</param>
        /// <param name="startHeight">The optional start block height.</param>
        /// <param name="endHeight">The optional end block height.</param>
        /// <param name="includeSpentCoins">if set to <c>true</c> spent coins will be included.</param>
        /// <returns>A Task&lt;<see cref="CoinRecordsResponse"/>&gt; representing the asynchronous operation.</returns>
        public async Task<CoinRecordsResponse> GetCoinRecordsByNamesAsync(IEnumerable<string> names, ulong? startHeight = null, ulong? endHeight = null, bool includeSpentCoins = true)
        {
            const string resource = "get_coin_records_by_names";

            var jsonStringBuilder = new StringBuilder("{");
            jsonStringBuilder.Append("\"names\":[");

            foreach (var item in names) jsonStringBuilder.Append("\"").Append(item).Append("\",");

            jsonStringBuilder = jsonStringBuilder.Remove(jsonStringBuilder.Length - 1, 1);

            jsonStringBuilder.Append("]");
            if (startHeight != null) jsonStringBuilder.Append(",\"start_height\":").Append(startHeight);
            if (endHeight != null) jsonStringBuilder.Append(",\"end_height\":").Append(endHeight);
            jsonStringBuilder.Append(",\"include_spent_coins\":").Append(includeSpentCoins.ToString().ToLowerInvariant()).Append("}");

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody(jsonStringBuilder.ToString());

            jsonStringBuilder.Clear();

            var response = await _restClient.ExecuteAsync<CoinRecordsResponse>(request);

            return response;
        }

        /// <summary>
        /// Get coin records by parent ids as an asynchronous operation.
        /// It is recommended that a start and end height be passed to reduce 
        /// lookup time.
        /// </summary>
        /// <param name="parentIds">The parent ids.</param>
        /// <param name="startHeight">The optional start block height.</param>
        /// <param name="endHeight">The optional end block height.</param>
        /// <param name="includeSpentCoins">if set to <c>true</c> [include spent coins].</param>
        /// <returns>A Task&lt;<see cref="CoinRecordsResponse"/>&gt; representing the asynchronous operation.</returns>
        public async Task<CoinRecordsResponse> GetCoinRecordsByParentIdsAsync(IEnumerable<string> parentIds, ulong? startHeight = null, ulong? endHeight = null, bool includeSpentCoins = true)
        {
            const string resource = "get_coin_records_by_parent_ids";

            var jsonStringBuilder = new StringBuilder("{");
            jsonStringBuilder.Append("\"parent_ids\":[");

            foreach (var item in parentIds) jsonStringBuilder.Append("\"").Append(item).Append("\",");

            jsonStringBuilder = jsonStringBuilder.Remove(jsonStringBuilder.Length - 1, 1);

            jsonStringBuilder.Append("]");
            if (startHeight != null) jsonStringBuilder.Append(",\"start_height\":").Append(startHeight);
            if (endHeight != null) jsonStringBuilder.Append(",\"end_height\":").Append(endHeight);
            jsonStringBuilder.Append(",\"include_spent_coins\":").Append(includeSpentCoins.ToString().ToLowerInvariant()).Append("}");

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody(jsonStringBuilder.ToString());

            jsonStringBuilder.Clear();

            var response = await _restClient.ExecuteAsync<CoinRecordsResponse>(request);

            return response;
        }

        /// <summary>
        /// Push transaction / spend bundle to the mempool and blockchain as an asynchronous operation.
        /// Returns whether the spend bundle was successfully included into the mempool.
        /// </summary>
        /// <param name="spendBundleRequest">The spend bundle to send.</param>
        /// <returns>A Task&lt;<see cref="BoolResponse"/>&gt; representing the asynchronous operation.</returns>
        public async Task<BoolResponse> PushTxAsync(SpendBundleRequest spendBundleRequest)
        {
            const string resource = "push_tx";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody(JsonConvert.SerializeObject(spendBundleRequest));

            var response = await _restClient.ExecuteAsync<BoolResponse>(request);

            return response;
        }

        /// <summary>
        /// Get puzzle and solution (spend record) as an asynchronous operation.
        /// </summary>
        /// <param name="coinId">The coin identifier.</param>
        /// <param name="height">The block height.</param>
        /// <returns>A Task&lt;<see cref="PuzzleAndSolutionResponse"/>&gt; representing the asynchronous operation.</returns>
        public async Task<PuzzleAndSolutionResponse> GetPuzzleAndSolutionAsync(string coinId, ulong height)
        {
            const string resource = "get_puzzle_and_solution";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"coin_id\":\"{coinId}\",\"height\":{height}}}");

            var response = await _restClient.ExecuteAsync<PuzzleAndSolutionResponse>(request);

            return response;
        }

        #endregion Coins

        #region MemPool

        /// <summary>
        /// Get all memory pool transaction ids (spend bundle hashes) as an asynchronous operation.
        /// </summary>
        /// <returns>A Task&lt;<see cref="MemPoolTxIdsResponse"/>&gt; representing the asynchronous operation.</returns>
        public async Task<MemPoolTxIdsResponse> GetAllMemPoolTxIdsAsync()
        {
            const string resource = "get_all_mempool_tx_ids";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody("{}");

            var response = await _restClient.ExecuteAsync<MemPoolTxIdsResponse>(request);

            return response;
        }

        /// <summary>
        /// Get all memory pool items as an asynchronous operation.
        /// </summary>
        /// <returns>A Task&lt;<see cref="MemPoolItemsResponse"/>&gt; representing the asynchronous operation.</returns>
        public async Task<MemPoolItemsResponse> GetAllMemPoolItemsAsync()
        {
            const string resource = "get_all_mempool_items";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody("{}");

            var response = await _restClient.ExecuteAsync(request);

#pragma warning disable CS8603 // Possible null reference return.
            return JsonConvert.DeserializeObject<MemPoolItemsResponse>(response.Content, Utils.MemPoolResponseConverter.Settings);
#pragma warning restore CS8603 // Possible null reference return.
        }

        /// <summary>
        /// Get memory pool item by transaction identifier as an asynchronous operation.
        /// </summary>
        /// <param name="txId">The transaction identifier.</param>
        /// <returns>A Task&lt;<see cref="MemPoolItemResponse"/>&gt; representing the asynchronous operation.</returns>
        public async Task<MemPoolItemResponse> GetMemPoolItemByTxIdAsync(string txId)
        {
            const string resource = "get_mempool_item_by_tx_id";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"tx_id\":\"{txId}\"}}");

            var response = await _restClient.ExecuteAsync(request);

#pragma warning disable CS8603 // Possible null reference return.
            return JsonConvert.DeserializeObject<MemPoolItemResponse>(response.Content, Utils.MemPoolResponseConverter.Settings);
#pragma warning restore CS8603 // Possible null reference return.
        }

        #endregion MemPool
    }
}