using ChiaApi.Utils;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace ChiaApi
{
    public class ChiaApiConfig
    {
        public string Host { get; }
        public uint Port { get; }
        public ILogger? Logger { get; }

        private readonly string _certFile;
        private readonly string _keyFile;

        public ChiaApiConfig(string certFile, string keyFile, string host, uint port, ILogger? logger = null)
        {
            if (string.IsNullOrEmpty(certFile) || string.IsNullOrWhiteSpace(certFile)) throw new ArgumentNullException(nameof(certFile));
            if (string.IsNullOrEmpty(keyFile) || string.IsNullOrWhiteSpace(keyFile)) throw new ArgumentNullException(nameof(keyFile));
            if (string.IsNullOrEmpty(host) || string.IsNullOrWhiteSpace(host)) throw new ArgumentNullException(nameof(host));

            if (!File.Exists(certFile)) throw new FileNotFoundException(nameof(certFile));
            if (!File.Exists(keyFile)) throw new FileNotFoundException(nameof(keyFile));

            Host = host;
            Port = port;
            _certFile = certFile;
            _keyFile = keyFile;
            Logger = logger;
        }

        internal X509CertificateCollection GetClientCertificates()
        {
            var certs = Certificates.Load(_certFile, _keyFile);
            return certs;
        }
    }
}
