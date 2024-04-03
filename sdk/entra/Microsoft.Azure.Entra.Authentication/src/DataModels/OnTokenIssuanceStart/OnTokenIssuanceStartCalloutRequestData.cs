// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Newtonsoft.Json;

namespace Microsoft.Azure.Entra.Authentication
{
    /// <summary>
    /// The model specific to the TokenIssuanceStart event custom extension callout to user-defined external API.
    /// Inherits from <see cref="CustomExtensionCalloutRequestData"/>.
    /// </summary>
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class OnTokenIssuanceStartCalloutRequestData : CustomExtensionCalloutRequestData
    {
        /// <summary>
        /// Get the OData type string for this model.
        /// </summary>
        /// <returns></returns>
        public static string GetODataString()
        {
            return APIModelConstants.ODataType + GraphDataType;
        }

        private const string GraphDataType = "onTokenIssuanceStartCalloutData";

        /// <summary>
        /// Default Constructor for Json Deserialization.
        /// </summary>
        [JsonConstructor]
        public OnTokenIssuanceStartCalloutRequestData()
            : base(GraphDataType)
        {
        }
    }
}
