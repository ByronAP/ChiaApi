﻿using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    public class Announcement
    {
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; } = string.Empty;

        [JsonProperty("origin_info", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginInfo { get; set; } = string.Empty;
    }
}