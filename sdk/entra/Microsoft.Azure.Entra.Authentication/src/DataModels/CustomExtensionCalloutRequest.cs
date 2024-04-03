// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Microsoft.Azure.Entra.Authentication.Converters;

using Newtonsoft.Json;

namespace Microsoft.Azure.Entra.Authentication
{
    /// <summary>The request format of the custom extension call to the user-defined external API.</summary>
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public abstract class CustomExtensionCalloutRequest<TCustomExtensionData>
        where TCustomExtensionData : CustomExtensionData
    {
        /// <summary>
        /// Base constructor to set type, source, and resourceAppId.
        /// </summary>
        /// <param name="tenantId">TenantId of who's making the request to the custom extension.</param>
        /// <param name="resourceAppId">Resource Id of application making the request.</param>
        /// <param name="eventType">Type of <see cref="EventType"/> that is excuting the this request.</param>
        protected CustomExtensionCalloutRequest(string tenantId, string resourceAppId, EventType eventType)
        {
            this.Type = APIModelConstants.MicrosoftGraphPrefixAuthEvent + eventType.ToString();
            this.Source = $"/tenants/{tenantId}/applications/{resourceAppId}";
        }

        /// <summary>
        /// Default Constructor for Json Deserialization.
        /// </summary>
        protected CustomExtensionCalloutRequest()
        {
        }

        /// <summary>Gets the type of the custom extension.</summary>
        /// <value>The type of the custom extension.</value>
        [JsonProperty(propertyName: "type", Order = -3)]
        public string Type { get; private set; }

        /// <summary>Gets the custom extension identifier.</summary>
        /// <value>The custom extension identifier.</value>
        [JsonProperty(propertyName: "source", Order = -2)]
        public string Source { get; private set; }

        /// <summary>Gets or sets data context object that is sent to the user-defined external
        /// api when custom extension is configured for an event.</summary>
        /// <value>The context object.</value>
        [JsonProperty("data", Order = int.MaxValue)]
        [JsonConverter(typeof(CustomExtensionDataConvertor))]
        public TCustomExtensionData Data { get; set; }
    }
}