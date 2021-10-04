using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ChiaApi.Utils
{
    public class HttpTools
    {
        public class HttpRestClient
        {
            public TimeSpan RetryWait { get; set; } = TimeSpan.FromSeconds(1);
            public uint MaxRetries { get; set; } = 6;
            public bool BackoffExponentially { get; set; } = true;

            private readonly IRestClient _restClient;
            private readonly ILogger? _logger;

            public IWebProxy? Proxy
            {
                get => _restClient.Proxy;
                set => _restClient.Proxy = value;
            }

            public HttpRestClient(string baseUrl, X509CertificateCollection? clientCertificates = null, ILogger? logger = null)
            {
                _logger = logger;
                _logger?.LogDebug("Creating HttpRestClient instance for base url {BaseUrl}", baseUrl);
                _restClient = new RestClient(baseUrl)
                {
                    UserAgent = UserAgents.Chrome_Win10_x64,
                    ClientCertificates = clientCertificates,
                    RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true
                };
            }

            public async Task<IRestResponse> ExecuteAsync(IRestRequest request)
            {
            RETRY:
                var response = await _restClient.ExecuteAsync(request);

                if (response.IsSuccessful)
                    return response;

                if (request.Attempts < MaxRetries)
                {
                    request.IncreaseNumAttempts();
                    var waitTime = BackoffExponentially ? RetryWait * request.Attempts : RetryWait;
                    _logger?.LogWarning("HTTP request failed ({Tries}), retrying in {RetryWaitTime} second, {Params}.",
                        request.Attempts, waitTime, request.Parameters.ToString());

                    await Task.Delay(waitTime);
                    goto RETRY;
                }

                throw new HttpRequestException();
            }

            public async Task<T> ExecuteAsync<T>(IRestRequest request)
            {
            RETRY:
                var response = await _restClient.ExecuteAsync(request);

                if (response.IsSuccessful && !string.IsNullOrEmpty(response.Content))
                {
#pragma warning disable CS8603 // Possible null reference return.
                    return JsonConvert.DeserializeObject<T>(response.Content);
#pragma warning restore CS8603 // Possible null reference return.
                }

                if (request.Attempts < MaxRetries)
                {
                    request.IncreaseNumAttempts();
                    var waitTime = BackoffExponentially ? RetryWait * request.Attempts : RetryWait;
                    _logger?.LogWarning("HTTP request failed ({Tries}), retrying in {RetryWaitTime} second, {Params}.",
                        request.Attempts, waitTime, request.Parameters.ToString());

                    await Task.Delay(waitTime);
                    goto RETRY;
                }

                throw new HttpRequestException();
            }
        }

        /// <summary>
        /// Performs a ping to the host N times.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="timeoutMs"></param>
        /// <param name="samples"></param>
        /// <returns>The average round trip time to the host. long.MaxValue = error</returns>
        public static TimeSpan PingSample(string url, uint timeoutMs = 8000, ushort samples = 6)
        {
            // Create a buffer of 32 bytes of data to be transmitted.
            const string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            var buffer = Encoding.ASCII.GetBytes(data);
            const int waitStateTimeMs = 120;

            var pingSender = new Ping();
            var options = new PingOptions(128, true);

            // warm up
            for (int i = 0; i < 4; i++)
            {
                pingSender.Send(url, (int)timeoutMs, buffer, options);
                Task.Delay(waitStateTimeMs).Wait();
            }

            var results = new long[samples];

            for (var i = 0; i < samples; i++)
            {
                var reply = pingSender.Send(url, (int)timeoutMs, buffer, options);
                if (reply != null && reply.Status == IPStatus.Success)
                    results[i] = reply.RoundtripTime;
                else
                    results[i] = long.MaxValue;

                Task.Delay(waitStateTimeMs).Wait();
            }

            var averageRoundTrip = results.Average();

            return TimeSpan.FromMilliseconds(averageRoundTrip);
        }

        /// <summary>
        /// Performs a ping to the host.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="timeoutMs"></param>
        /// <returns>The round trip time to the host. long.MaxValue = error</returns>
        public static TimeSpan Ping(string url, uint timeoutMs = 8000)
        {
            // Create a buffer of 32 bytes of data to be transmitted.
            const string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            var buffer = Encoding.ASCII.GetBytes(data);

            var pingSender = new Ping();
            var options = new PingOptions(128, true);


            var reply = pingSender.Send(url, (int)timeoutMs, buffer, options);
            if (reply != null && reply.Status == IPStatus.Success)
            {
                return TimeSpan.FromMilliseconds(reply.RoundtripTime);
            }
            else
            {
                return TimeSpan.FromMilliseconds(long.MaxValue);
            }
        }
    }
}
