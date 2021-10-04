using Newtonsoft.Json;

namespace ChiaApi.Models.Request.FullNode
{
    public class SpendBundleRequest
    {
        [JsonProperty("spend_bundle", NullValueHandling = NullValueHandling.Ignore)]
        public SpendBundle? SpendBundleSpendBundle { get; set; }
    }
}