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
    public class FullNodeApiClient : ApiClientBase
    {
        public FullNodeApiClient(ChiaApiConfig chiaApiConfig) : base(chiaApiConfig)
        {
        }

        #region Blockchain

        public async Task<BlockchainStateResponse> GetBlockchainStateAsync()
        {
            const string resource = "get_blockchain_state";
            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody("{}");

            var response = await _restClient.ExecuteAsync<BlockchainStateResponse>(request);

            return response;
        }

        public async Task<BlockResponse> GetBlockAsync(string headerHash)
        {
            const string resource = "get_block";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"header_hash\":\"{headerHash}\"}}");

            var response = await _restClient.ExecuteAsync<BlockResponse>(request);

            return response;
        }

        public async Task<BlocksResponse> GetBlocksAsync(ulong start, ulong end, bool excludeHeaderHash)
        {
            const string resource = "get_blocks";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"start\":{start},\"end\":{end},\"excludeHeaderHash\":{excludeHeaderHash.ToString().ToLowerInvariant()}}}");

            var response = await _restClient.ExecuteAsync<BlocksResponse>(request);

            return response;
        }

        public async Task<BlockRecordResponse> GetBlockRecordByHeightAsync(ulong height)
        {
            const string resource = "get_block_record_by_height";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"height\":{height}}}");

            var response = await _restClient.ExecuteAsync<BlockRecordResponse>(request);

            return response;
        }

        public async Task<BlockRecordResponse> GetBlockRecordAsync(string headerHash)
        {
            const string resource = "get_block_record";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"header_hash\":\"{headerHash}\"}}");

            var response = await _restClient.ExecuteAsync<BlockRecordResponse>(request);

            return response;
        }

        public async Task<BlockRecordsResponse> GetBlockRecordsAsync(ulong? startHeight = null, ulong? endHeight = null)
        {
            const string resource = "get_block_records";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"start\":{startHeight},\"end\":{endHeight}}}");

            var response = await _restClient.ExecuteAsync<BlockRecordsResponse>(request);

            return response;
        }

        public async Task<UnfinishedBlockHeadersResponse> GetUnfinishedBlockHeadersAsync()
        {
            const string resource = "get_unfinished_block_headers";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody("{}");

            var response = await _restClient.ExecuteAsync<UnfinishedBlockHeadersResponse>(request);

            return response;
        }

        public async Task<NetworkSpaceResponse> GetNetworkSpaceAsync(string newerBlockHeaderHash, string olderBlockHeaderHash)
        {
            const string resource = "get_network_space";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"newer_block_header_hash\":\"{newerBlockHeaderHash}\",\"older_block_header_hash\":\"{olderBlockHeaderHash}\"}}");

            var response = await _restClient.ExecuteAsync<NetworkSpaceResponse>(request);

            return response;
        }

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

        public async Task<CoinRecordResponse> GetCoinRecordByNameAsync(string name)
        {
            const string resource = "get_coin_record_by_name";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"name\":\"{name}\"}}");

            var response = await _restClient.ExecuteAsync<CoinRecordResponse>(request);

            return response;
        }

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

        public async Task<BoolResponse> PushTxAsync(SpendBundleRequest spendBundleRequest)
        {
            const string resource = "push_tx";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody(JsonConvert.SerializeObject(spendBundleRequest));

            var response = await _restClient.ExecuteAsync<BoolResponse>(request);

            return response;
        }

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

        public async Task<MemPoolTxIdsResponse> GetAllMemPoolTxIdsAsync()
        {
            const string resource = "get_all_mempool_tx_ids";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody("{}");

            var response = await _restClient.ExecuteAsync<MemPoolTxIdsResponse>(request);

            return response;
        }

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