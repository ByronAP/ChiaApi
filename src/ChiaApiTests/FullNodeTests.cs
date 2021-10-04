using ChiaApi;
using ChiaApi.Models.Responses;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace ChiaApiTests
{
    public class FullNodeTests
    {
        private const string BlockHeight1Hash = "0x7357071bb77de2e98b9b1daf6b87f67dd8481fa144bcc03d331dba8664fc04f9";
        private const string CoinRecordPuzzleHash = "0xd23da14695a188ae5708dd152263c4db883eb27edeb936178d4d988b8f3ce5fc";
        private const string CoinRecordName = "1fd60c070e821d785b65e10e5135e52d12c8f4d902a506f48bc1c5268b7bb45b";

        private readonly FullNodeApiClient _fullNodeApiClient;

        public FullNodeTests()
        {
            var config = new ChiaApiConfig(Environment.FullNodeCertFile, Environment.FullNodeKeyFile, Environment.FullNodeHost, Environment.FullNodePort);
            _fullNodeApiClient = new FullNodeApiClient(config);
        }

        #region Blockchain

        [Fact]
        public async Task Test_GetBlockchainStateAsync()
        {
            var response = await _fullNodeApiClient.GetBlockchainStateAsync();

            Assert.True(response.Success);

            Assert.NotNull(response.BlockchainState);

            Assert.IsAssignableFrom<ApiResponseBase>(response);
        }

        [Fact]
        public async Task Test_GetBlockAsync()
        {
            var response = await _fullNodeApiClient.GetBlockAsync(BlockHeight1Hash);

            Assert.True(response.Success);

            Assert.NotNull(response.Block);

            Assert.NotNull(response.Block.RewardChainBlock);

            Assert.Equal<ulong>(1, response.Block.RewardChainBlock.Height);

            Assert.Equal(string.Empty, response.Block.HeaderHash);

            Assert.IsAssignableFrom<ApiResponseBase>(response);
        }

        [Fact]
        public async Task Test_GetBlocksAsync()
        {
            var response = await _fullNodeApiClient.GetBlocksAsync(0, 2, false);

            Assert.True(response.Success);

            Assert.NotNull(response.Blocks);

            Assert.NotEmpty(response.Blocks);

            Assert.Equal(2, response.Blocks.Count);

            Assert.NotNull(response.Blocks[0].RewardChainBlock);

            Assert.Equal<ulong>(0, response.Blocks[0].RewardChainBlock.Height);

            Assert.Equal(BlockHeight1Hash[2..], response.Blocks[1].HeaderHash);

            Assert.IsAssignableFrom<ApiResponseBase>(response);
        }

        [Fact]
        public async Task Test_GetBlockRecordByHeightAsync()
        {
            var response = await _fullNodeApiClient.GetBlockRecordByHeightAsync(1);

            Assert.True(response.Success);

            Assert.NotNull(response.BlockRecord);

            Assert.Equal<ulong>(1, response.BlockRecord.Height);

            Assert.Equal(BlockHeight1Hash, response.BlockRecord.HeaderHash);

            Assert.IsAssignableFrom<ApiResponseBase>(response);
        }

        [Fact]
        public async Task Test_GetBlockRecordAsync()
        {
            var response = await _fullNodeApiClient.GetBlockRecordAsync(BlockHeight1Hash);

            Assert.True(response.Success);

            Assert.NotNull(response.BlockRecord);

            Assert.Equal<ulong>(1, response.BlockRecord.Height);

            Assert.Equal(BlockHeight1Hash, response.BlockRecord.HeaderHash);

            Assert.IsAssignableFrom<ApiResponseBase>(response);
        }

        [Fact]
        public async Task Test_GetBlockRecordsAsync()
        {
            var response = await _fullNodeApiClient.GetBlockRecordsAsync(0, 2);

            Assert.True(response.Success);

            Assert.NotNull(response.BlockRecord);

            Assert.NotEmpty(response.BlockRecord);

            Assert.Equal(2, response.BlockRecord.Count);

            Assert.Equal<ulong>(0, response.BlockRecord[0].Height);

            Assert.Equal(BlockHeight1Hash, response.BlockRecord[1].HeaderHash);

            Assert.IsAssignableFrom<ApiResponseBase>(response);
        }

        [Fact]
        public async Task Test_GetUnfinishedBlockHeadersAsync()
        {
            var response = await _fullNodeApiClient.GetUnfinishedBlockHeadersAsync();

            Assert.True(response.Success);

            Assert.IsAssignableFrom<ApiResponseBase>(response);
        }

        [Fact]
        public async Task Test_GetNetworkSpaceAsync()
        {
            var newerBlock = await _fullNodeApiClient.GetBlockRecordByHeightAsync(10);

            var response = await _fullNodeApiClient.GetNetworkSpaceAsync(BlockHeight1Hash, newerBlock.BlockRecord.HeaderHash);

            Assert.True(response.Success);

            Assert.NotEqual(0, response.Space);

            Assert.True(response.Space >= 163472388964095968);

            Assert.IsAssignableFrom<ApiResponseBase>(response);
        }

        [Fact]
        public async Task Test_GetAdditionsAndRemovalsAsync()
        {
            var response = await _fullNodeApiClient.GetAdditionsAndRemovalsAsync(BlockHeight1Hash);

            Assert.True(response.Success);

            Assert.NotNull(response.Additions);

            Assert.Equal(2, response.Additions.Count);

            Assert.IsAssignableFrom<ApiResponseBase>(response);
        }

        //TODO: GetRecentSignagePointOrEosAsync
        // not sure of a reliable way to test this call

        #endregion

        #region Coins

        [Fact]
        public async Task Test_GetCoinRecordsByPuzzleHashAsync()
        {
            var response = await _fullNodeApiClient.GetCoinRecordsByPuzzleHashAsync(CoinRecordPuzzleHash);

            Assert.True(response.Success);

            Assert.NotNull(response.CoinRecords);

            Assert.Equal(8, response.CoinRecords.Count);

            Assert.NotNull(response.CoinRecords[0].Coin);

            Assert.Equal(CoinRecordPuzzleHash, response.CoinRecords[0].Coin.PuzzleHash);

            Assert.IsAssignableFrom<ApiResponseBase>(response);
        }

        [Fact]
        public async Task Test_GetCoinRecordsByPuzzleHashesAsync()
        {
            var response = await _fullNodeApiClient.GetCoinRecordsByPuzzleHashesAsync(new[] { CoinRecordPuzzleHash });

            Assert.True(response.Success);

            Assert.NotNull(response.CoinRecords);

            Assert.Equal(8, response.CoinRecords.Count);

            Assert.NotNull(response.CoinRecords[0].Coin);

            Assert.Equal(CoinRecordPuzzleHash, response.CoinRecords[0].Coin.PuzzleHash);

            Assert.IsAssignableFrom<ApiResponseBase>(response);
        }

        [Fact]
        public async Task Test_GetCoinRecordByNameAsync()
        {
            var response = await _fullNodeApiClient.GetCoinRecordByNameAsync(CoinRecordName);

            Assert.True(response.Success);

            Assert.NotNull(response.CoinRecord);

            Assert.NotNull(response.CoinRecord.Coin);

            Assert.Equal(CoinRecordPuzzleHash, response.CoinRecord.Coin.PuzzleHash);

            Assert.IsAssignableFrom<ApiResponseBase>(response);
        }

        [Fact]
        public async Task Test_GetCoinRecordsByNamesAsync()
        {
            var response = await _fullNodeApiClient.GetCoinRecordsByNamesAsync(new[] { CoinRecordName });

            Assert.True(response.Success);

            Assert.NotNull(response.CoinRecords);

            Assert.NotNull(response.CoinRecords[0].Coin);

            Assert.Equal(CoinRecordPuzzleHash, response.CoinRecords[0].Coin.PuzzleHash);

            Assert.IsAssignableFrom<ApiResponseBase>(response);
        }

        [Fact]
        public async Task Test_GetCoinRecordsByParentIdsAsync()
        {
            var response = await _fullNodeApiClient.GetCoinRecordsByParentIdsAsync(new[] { CoinRecordName });

            Assert.True(response.Success);

            Assert.NotNull(response.CoinRecords);

            Assert.NotNull(response.CoinRecords[0].Coin);

            Assert.Equal<ulong>(9187500000000000000, response.CoinRecords[0].Coin.Amount);

            Assert.IsAssignableFrom<ApiResponseBase>(response);
        }

        [Fact]
        public async Task Test_GetPuzzleAndSolutionAsync()
        {
            var response = await _fullNodeApiClient.GetPuzzleAndSolutionAsync(CoinRecordName, 229316);

            Assert.True(response.Success);

            Assert.NotNull(response.CoinSolution);

            Assert.NotNull(response.CoinSolution.Coin);

            Assert.Equal(CoinRecordPuzzleHash, response.CoinSolution.Coin.PuzzleHash);

            Assert.IsAssignableFrom<ApiResponseBase>(response);
        }

        #endregion

        #region MemPool

        [Fact]
        public async Task Test_GetAllMemPoolTxIdsAsync()
        {
            var response = await _fullNodeApiClient.GetAllMemPoolTxIdsAsync();

            Assert.True(response.Success);

            Assert.IsAssignableFrom<ApiResponseBase>(response);
        }

        [Fact]
        public async Task Test_GetAllMemPoolItemsAsync()
        {
            var response = await _fullNodeApiClient.GetAllMemPoolItemsAsync();

            Assert.True(response.Success);

            Assert.IsAssignableFrom<ApiResponseBase>(response);
        }

        [Fact]
        public async Task Test_GetMemPoolItemByTxIdAsync()
        {
            const uint maxTries = 14;
            var tries = 0;

        GETTXIDS:
            var txIds = await _fullNodeApiClient.GetAllMemPoolTxIdsAsync();
            if (txIds.Success && txIds.TxIds != null && txIds.TxIds.Any())
            {
                var response = await _fullNodeApiClient.GetMemPoolItemByTxIdAsync(txIds.TxIds[0]);

                Assert.True(response.Success);

                Assert.NotNull(response.MemPoolItem);

                Assert.Equal(txIds.TxIds[0], response.MemPoolItem.SpendBundleName);

                Assert.IsAssignableFrom<ApiResponseBase>(response);
            }
            else if (tries < maxTries)
            {
                // we are not guranteed that the mempool has anything so we will wait a few tries to try and get something
                tries++;
                await Task.Delay(System.TimeSpan.FromSeconds(10));
                goto GETTXIDS;
            }
            else
            {
                throw new System.Exception("Test could not obtain a valid txid to test against.");
            }
        }

        #endregion
    }
}
