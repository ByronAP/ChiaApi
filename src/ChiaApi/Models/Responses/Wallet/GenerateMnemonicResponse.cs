using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.Wallet
{
    public class GenerateMnemonicResponse : ApiResponseBase
    {
        [JsonProperty("mnemonic", NullValueHandling = NullValueHandling.Ignore)]
        public List<string>? Mnemonic { get; set; }
    }
}