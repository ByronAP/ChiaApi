using ChiaApi.Models.Responses.Harvester;
using ChiaApi.Models.Responses.Shared;
using RestSharp;
using System.Threading.Tasks;

namespace ChiaApi
{
    public class HarvesterApiClient : ApiClientBase
    {
        public HarvesterApiClient(ChiaApiConfig chiaApiConfig) : base(chiaApiConfig)
        {
        }

        public async Task<BoolResponse> AddPlotDirectoryAsync(string dirName)
        {
            dirName = System.Web.HttpUtility.JavaScriptStringEncode(dirName);

            const string resource = "add_plot_directory";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"dirname\":\"{dirName}\"}}");

            var response = await _restClient.ExecuteAsync<BoolResponse>(request);

            return response;
        }

        public async Task<BoolResponse> DeletePlotAsync(string fileName)
        {
            fileName = System.Web.HttpUtility.JavaScriptStringEncode(fileName);

            const string resource = "delete_plot";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"filename\":\"{fileName}\"}}");

            var response = await _restClient.ExecuteAsync<BoolResponse>(request);

            return response;
        }

        public async Task<PlotDirectoriesResponse> GetPlotDirectoriesAsync()
        {
            const string resource = "get_plot_directories";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody("{}");

            var response = await _restClient.ExecuteAsync<PlotDirectoriesResponse>(request);

            return response;
        }

        public async Task<PlotsResponse> GetPlotsAsync()
        {
            const string resource = "get_plots";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody("{}");

            var response = await _restClient.ExecuteAsync<PlotsResponse>(request);

            return response;
        }

        public async Task<BoolResponse> RefreshPlotsAsync()
        {
            const string resource = "refresh_plots";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody("{}");

            var response = await _restClient.ExecuteAsync<BoolResponse>(request);

            return response;
        }

        public async Task<BoolResponse> RemovePlotDirectoryAsync(string dirName)
        {
            dirName = System.Web.HttpUtility.JavaScriptStringEncode(dirName);

            const string resource = "remove_plot_directory";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"dirname\":\"{dirName}\"}}");

            var response = await _restClient.ExecuteAsync<BoolResponse>(request);

            return response;
        }
    }
}