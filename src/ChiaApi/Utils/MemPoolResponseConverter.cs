using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Globalization;

namespace ChiaApi.Utils
{
    internal class MemPoolResponseConverter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                ConditionUnionConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}