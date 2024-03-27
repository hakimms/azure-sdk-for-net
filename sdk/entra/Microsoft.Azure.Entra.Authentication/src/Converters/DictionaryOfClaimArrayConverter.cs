// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace Microsoft.Azure.Entra.Authentication
{
    /// <summary>
    /// <see cref="JsonConverter"/> for converting a <see cref="Dictionary{TKey, TValue}"/>.
    /// </summary>
    internal class DictionaryOfClaimArrayConverter
        : JsonConverter<IDictionary<string, IList<string>>>
    {
        /// <summary>
        /// Allows parsing of a dictionary of string and list of strings or a single string to a
        /// <see cref="Dictionary{TKey, TValue}"/>
        /// This class will iterate over the dictionary getting the keys, and call another private method to read
        /// value to determine if it is a string or list of string and then
        /// return the value as <see cref="List{TValue}"/> regardless.
        /// </summary>
        /// <param name="reader">The json reader.</param>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="existingValue">The existing value of object being read. If there is no existing value then <c>null</c> will be used.</param>
        /// <param name="hasExistingValue">The existing value has a value.</param>
        /// <param name="serializer">The calling serializer.</param>
        /// <returns>The object value.</returns>
        /// <exception cref="JsonException">if it is not a json object.</exception>
        public override IDictionary<string, IList<string>> ReadJson(
            JsonReader reader,
            Type objectType,
            IDictionary<string, IList<string>> existingValue,
            bool hasExistingValue,
            JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.StartObject)
            {
                IDictionary<string, IList<string>> ret = new Dictionary<string, IList<string>>();

                while (reader.Read() && reader.TokenType != JsonToken.EndObject)
                {
                    string key = (string)reader.Value;
                    reader.Read();
                    ret.Add(key, ReadSingleObjectOrArrayAsIList(reader, serializer));
                }

                return ret;
            }

            if (reader.TokenType == JsonToken.Null
                || reader.TokenType == JsonToken.None)
            {
                return null;
            }

            throw new JsonReaderException($"Expecting JSON Object. Actual: {reader.TokenType}");
        }

        /// <summary>
        /// Read a Single object or an array as a list.
        /// </summary>
        /// <param name="reader"><see cref="JsonReader"/> Json reader containig the json object.</param>
        /// <param name="serializer"><see cref="JsonSerializer"/> The Json serializer.</param>
        /// <returns>IList of string or null if token type is not string or list.</returns>
        private static IList<string> ReadSingleObjectOrArrayAsIList(JsonReader reader, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
            {
                // is single object, add as array
                return new List<string>() { serializer.Deserialize<string>(reader) };
            }

            if (reader.TokenType == JsonToken.StartArray)
            {
                IList<string> ret = new List<string>();
                while (reader.Read() && reader.TokenType != JsonToken.EndArray)
                {
                    if (reader.TokenType != JsonToken.String)
                    {
                        throw new JsonReaderException($"Expecting JSON string or JSON string array. Actual type: {reader.TokenType}");
                    }

                    ret.Add(serializer.Deserialize<string>(reader));
                }

                return ret;
            }

            throw new JsonReaderException($"Expecting JSON string or JSON string array. Actual type: {reader.TokenType}");
        }

        /// <summary>
        /// Writes a <see cref="Dictionary{TKey, TValue}"/> to value param.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="value">The value to write to.</param>
        /// <param name="serializer">The <see cref="JsonSerializer"/>.</param>
        public override void WriteJson(JsonWriter writer, IDictionary<string, IList<string>> value, JsonSerializer serializer)
        {
            if (value == null || value.Count == 0)
            {
                serializer.Serialize(writer, null);
                return;
            }

            writer.WriteStartObject();

            foreach (KeyValuePair<string, IList<string>> kv in value)
            {
                writer.WritePropertyName(kv.Key.ToString());
                WriteSingleObjectOrArray(writer, kv.Value, serializer);
            }

            writer.WriteEndObject();
        }

        /// <summary>Writes the json string based on the type of the object:
        /// If has 1 item, we write as single object.
        /// If has more than 1 item, we write as array of objects.
        /// </summary>
        /// <param name="writer">The writer.</param>
        /// <param name="value">The value.</param>
        /// <param name="serializer">The serializer.</param>
        private static void WriteSingleObjectOrArray(JsonWriter writer, IList<string> value, JsonSerializer serializer)
        {
            if (value == null || value.Count == 0)
            {
                // write as a null object
                serializer.Serialize(writer, null);
            }
            else if (value.Count == 1)
            {
                // write as a single string object
                serializer.Serialize(writer, value[0]);
            }
            else
            {
                // write as a list of strings
                serializer.Serialize(writer, value);
            }
        }
    }
}
