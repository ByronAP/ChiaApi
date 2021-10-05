// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 10-02-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="HarvesterApiClient.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using ChiaApi.Models.Responses.Harvester;
using ChiaApi.Models.Responses.Shared;
using RestSharp;
using System.Threading.Tasks;

namespace ChiaApi
{
    /// <summary>
    /// Class HarvesterApiClient.
    /// Implements the <see cref="ChiaApi.ApiClientBase" />
    /// </summary>
    /// <seealso cref="ChiaApi.ApiClientBase" />
    public class HarvesterApiClient : ApiClientBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HarvesterApiClient"/> class.
        /// </summary>
        /// <param name="chiaApiConfig">The chia API configuration.</param>
        public HarvesterApiClient(ChiaApiConfig chiaApiConfig) : base(chiaApiConfig)
        {
        }

        /// <summary>
        /// Add plot directory as an asynchronous operation.
        /// </summary>
        /// <param name="dirName">Name of the dir.</param>
        /// <returns>A Task&lt;BoolResponse&gt; representing the asynchronous operation.</returns>
        public async Task<BoolResponse> AddPlotDirectoryAsync(string dirName)
        {
            dirName = System.Web.HttpUtility.JavaScriptStringEncode(dirName);

            const string resource = "add_plot_directory";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"dirname\":\"{dirName}\"}}");

            var response = await _restClient.ExecuteAsync<BoolResponse>(request);

            return response;
        }

        /// <summary>
        /// Delete plot as an asynchronous operation.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <returns>A Task&lt;BoolResponse&gt; representing the asynchronous operation.</returns>
        public async Task<BoolResponse> DeletePlotAsync(string fileName)
        {
            fileName = System.Web.HttpUtility.JavaScriptStringEncode(fileName);

            const string resource = "delete_plot";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody($"{{\"filename\":\"{fileName}\"}}");

            var response = await _restClient.ExecuteAsync<BoolResponse>(request);

            return response;
        }

        /// <summary>
        /// Get plot directories as an asynchronous operation.
        /// </summary>
        /// <returns>A Task&lt;PlotDirectoriesResponse&gt; representing the asynchronous operation.</returns>
        public async Task<PlotDirectoriesResponse> GetPlotDirectoriesAsync()
        {
            const string resource = "get_plot_directories";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody("{}");

            var response = await _restClient.ExecuteAsync<PlotDirectoriesResponse>(request);

            return response;
        }

        /// <summary>
        /// Get plots as an asynchronous operation.
        /// </summary>
        /// <returns>A Task&lt;PlotsResponse&gt; representing the asynchronous operation.</returns>
        public async Task<PlotsResponse> GetPlotsAsync()
        {
            const string resource = "get_plots";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody("{}");

            var response = await _restClient.ExecuteAsync<PlotsResponse>(request);

            return response;
        }

        /// <summary>
        /// Refresh plots as an asynchronous operation.
        /// </summary>
        /// <returns>A Task&lt;BoolResponse&gt; representing the asynchronous operation.</returns>
        public async Task<BoolResponse> RefreshPlotsAsync()
        {
            const string resource = "refresh_plots";

            var request = new RestRequest(resource, Method.POST, DataFormat.Json);
            request.AddJsonBody("{}");

            var response = await _restClient.ExecuteAsync<BoolResponse>(request);

            return response;
        }

        /// <summary>
        /// Remove plot directory as an asynchronous operation.
        /// </summary>
        /// <param name="dirName">Name of the dir.</param>
        /// <returns>A Task&lt;BoolResponse&gt; representing the asynchronous operation.</returns>
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