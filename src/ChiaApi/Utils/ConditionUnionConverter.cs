// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-28-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="ConditionUnionConverter.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using ChiaApi.Models.Responses.FullNode;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ChiaApi.Utils
{
    /// <summary>
    /// Class ConditionUnionConverter.
    /// Implements the <see cref="Newtonsoft.Json.JsonConverter" />
    /// </summary>
    /// <seealso cref="Newtonsoft.Json.JsonConverter" />
    internal class ConditionUnionConverter : JsonConverter
    {
        /// <summary>
        /// Determines whether this instance can convert the specified t.
        /// </summary>
        /// <param name="t">The t.</param>
        /// <returns><c>true</c> if this instance can convert the specified t; otherwise, <c>false</c>.</returns>
        public override bool CanConvert(Type t) => t == typeof(ConditionUnion) || t == typeof(ConditionUnion?);

#pragma warning disable CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).

        /// <summary>
        /// Reads the json.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <param name="t">The t.</param>
        /// <param name="existingValue">The existing value.</param>
        /// <param name="serializer">The serializer.</param>
        /// <returns>System.Object.</returns>
        /// <exception cref="System.Exception">Cannot unmarshal type ConditionUnion</exception>
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

        /// <summary>
        /// Writes the json.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="untypedValue">The untyped value.</param>
        /// <param name="serializer">The serializer.</param>
        /// <exception cref="System.Exception">Cannot marshal type ConditionUnion</exception>
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

        /// <summary>
        /// The singleton
        /// </summary>
        public static readonly ConditionUnionConverter Singleton = new ConditionUnionConverter();
    }
}