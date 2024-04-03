// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Entra.Authentication
{
    /// <summary>
    /// Base class for all OData Json converters.
    /// </summary>
    /// <typeparam name="T">Type of the base class that sub types will be assigned to.</typeparam>
    internal abstract class DataJsonConverter<T> : JsonConverter<T>
    {
        // the deserialization delegate function
        protected delegate T DeserializationFunc(JObject jObject, JsonSerializer serializer);

        /// <summary>Deserializes the object into the correct type.</summary>
        /// <typeparam name="TSpecific">The specific sub-class of base type.</typeparam>
        /// <param name="jObject">The jobject.</param>
        /// <param name="serializer">The serializer.</param>
        /// <returns>The deserialized object.</returns>
        protected static T Convert<TSpecific>(JObject jObject, JsonSerializer serializer)
            where TSpecific : T, new()
        {
            TSpecific item = new();
            serializer.Populate(jObject.CreateReader(), item);
            return item;
        }

        /// <summary>
        /// The map of all the allowed types to their deserialization logic.
        /// </summary>
        private readonly IReadOnlyDictionary<string, DeserializationFunc> convertMap;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataJsonConverter{T}"/> class.
        /// </summary>
        /// <param name="convertMap">The conversion map.</param>
        protected DataJsonConverter(IReadOnlyDictionary<string, DataJsonConverter<T>.DeserializationFunc> convertMap)
        {
            this.convertMap = convertMap;
        }

        /// <summary>
        /// The override is always false since we want to use the default serialization logic.
        /// </summary>
        public override bool CanWrite => false;

        /// <summary>
        /// Reads the JSON representation of the object into the specifc sub-class of T
        /// based on the type property on the JSON object.
        /// </summary>
        /// <param name="reader">The json reader.</param>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="existingValue">The existing value of object being read. If there is no existing value then <c>null</c> will be used.</param>
        /// <param name="hasExistingValue">The existing value has a value.</param>
        /// <param name="serializer">The calling serializer.</param>
        /// <returns>The object value.</returns>
        /// <exception cref="JsonException">
        /// The '{ODataTypePropertyName}' required field is missing. Thrown when type property is missing.
        /// or
        /// The '{type}' specific sub-class type is not supported. Thrown when incorrect type is specified.
        /// or
        /// Unexpected error occurred during deserialization. Thrown if any unexpected error happens during the deserialization.
        /// </exception>
        public override T ReadJson(JsonReader reader, Type objectType, T existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            try
            {
                JObject jo = JObject.Load(reader);
                string type = jo[APIModelConstants.ODataType]?.Value<string>().ToUpperInvariant();

                if (type == null)
                {
                    throw new JsonException($"The '{APIModelConstants.ODataType}' required field is missing.");
                }

                if (this.convertMap.TryGetValue(type, out DeserializationFunc convertFunc))
                {
                    return convertFunc.Invoke(jo, serializer);
                }

                throw new JsonException($"The '{type}' {typeof(T)} type is not supported.");
            }
            catch (Exception ex) when (ex is not JsonException)
            {
                throw new JsonException($"Unexpected error occurred during {typeof(T)} deserialization", ex);
            }
        }

        /// <summary>
        /// Inherited WriteJson function. Currently it is not required.
        /// </summary>
        public override void WriteJson(JsonWriter writer, T value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
