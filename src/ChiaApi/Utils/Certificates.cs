using System;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ChiaApi.Utils
{
    public static class Certificates
    {
        private const string RSA_KEY_HEADER = "-----BEGIN RSA PRIVATE KEY-----";
        private const string RSA_KEY_FOOTER = "-----END RSA PRIVATE KEY-----";

        /// <summary>
        /// Creates a <see cref="X509Certificate2"/> from given cert and key files.
        /// </summary>
        /// <param name="certPath">The path to the certificate file.</param>
        /// <param name="keyPath">The path to the certificates private key file.</param>
        /// <returns>A certificate that can be used for authentication.</returns>
        public static X509Certificate2Collection Load(string certPath, string keyPath)
        {
            using var cert = new X509Certificate2(certPath);
            using var streamReader = new StreamReader(keyPath);

            var base64CertKey = new StringBuilder(streamReader.ReadToEnd())
                .Replace(RSA_KEY_HEADER, string.Empty)
                .Replace(RSA_KEY_FOOTER, string.Empty)
                .Replace(Environment.NewLine, string.Empty)
                .ToString();

            using var rsa = RSA.Create();
            rsa.ImportRSAPrivateKey(Convert.FromBase64String(base64CertKey), out _);

            using var certWithKey = cert.CopyWithPrivateKey(rsa);
            var tempCert = new X509Certificate2(certWithKey.Export(X509ContentType.Pkcs12));

            return new X509Certificate2Collection(tempCert);
        }
    }
}
