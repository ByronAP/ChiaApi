// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-27-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="ChiaApiConfig.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using ChiaApi.Utils;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace ChiaApi
{
    /// <summary>
    /// A class that contains the required properties to initialize an instance of an API client.
    /// The constructor takes all the required information, making the properties immutable.
    /// </summary>
    public class ChiaApiConfig
    {
        /// <summary>
        /// The cert file
        /// </summary>
        private readonly string _certFile;

        /// <summary>
        /// The key file
        /// </summary>
        private readonly string _keyFile;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChiaApiConfig" /> class.
        /// </summary>
        /// <param name="certFile">The client certificate file.<br />Example: C:\Users\username\.chia\mainnet\config\ssl\full_node\private_full_node.crt</param>
        /// <param name="keyFile">The certificates key file.<br />Example: C:\Users\username\.chia\mainnet\config\ssl\full_node\private_full_node.key</param>
        /// <param name="host">The API server host.<br />Example: localhost</param>
        /// <param name="port">The API server port.<br />Example: 8555</param>
        /// <param name="logger">An optional <see href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.ilogger" target="_blank"> logger </see> instance.</param>
        /// <exception cref="System.ArgumentNullException">certFile</exception>
        /// <exception cref="System.ArgumentNullException">keyFile</exception>
        /// <exception cref="System.ArgumentNullException">host</exception>
        /// <exception cref="System.IO.FileNotFoundException">certFile</exception>
        /// <exception cref="System.IO.FileNotFoundException">keyFile</exception>
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

        /// <summary>
        /// Gets the host.
        /// </summary>
        /// <value>The host.</value>
        public string Host { get; }

        /// <summary>
        /// Gets the logger.
        /// </summary>
        /// <value>The logger.</value>
        public ILogger? Logger { get; }

        /// <summary>
        /// Gets the port.
        /// </summary>
        /// <value>The port.</value>
        public uint Port { get; }

        /// <summary>
        /// Gets the client certificates and loads them into the proper type for use
        /// as network authorization for API calls (http client certificate auth).
        /// </summary>
        /// <returns>An X509CertificateCollection containing the certificate.</returns>
        internal X509CertificateCollection GetClientCertificates()
        {
            var certs = Certificates.Load(_certFile, _keyFile);
            return certs;
        }
    }
}