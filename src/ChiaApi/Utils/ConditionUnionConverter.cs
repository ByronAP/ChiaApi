using ChiaApi.Models.Responses.FullNode;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ChiaApi.Utils
{
    internal class ConditionUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ConditionUnion) || t == typeof(ConditionUnion?);

#pragma warning disable CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
#pragma warning restore CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    if (stringValue == null) stringValue = string.Empty;
                    return new ConditionUnion { String = stringValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<List<Condition>>(reader);
                    if (arrayValue == null) arrayValue = new List<Condition>();
                    return new ConditionUnion { ConditionArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type ConditionUnion");
        }

#pragma warning disable CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
#pragma warning restore CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
        {
            if (untypedValue == null) return;

            var value = (ConditionUnion)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.ConditionArray != null)
            {
                serializer.Serialize(writer, value.ConditionArray);
                return;
            }
            throw new Exception("Cannot marshal type ConditionUnion");
        }

        public static readonly ConditionUnionConverter Singleton = new ConditionUnionConverter();
    }
}
