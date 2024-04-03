// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Microsoft.Azure.Entra.Authentication.Converters
{
    internal class CustomExtensionDataConvertor : DataJsonConverter<CustomExtensionData>
    {
        // map of all the allowed action types to their deserialization logic
        private static readonly IReadOnlyDictionary<string, DeserializationFunc> CustomExtensionDataTypeMap
            = new ReadOnlyDictionary<string, DeserializationFunc>(
                new Dictionary<string, DeserializationFunc>(StringComparer.InvariantCultureIgnoreCase)
                {
                    // OnTokenIssuanceStart actions
                    [OnTokenIssuanceStartCalloutRequestData.GetODataString()] = Convert<OnTokenIssuanceStartCalloutRequestData>
                });

        /// <summary>
        /// Initializes a new instance of the <see cref="EventActionConverter"/> class.
        /// </summary>
        public CustomExtensionDataConvertor()
            : base(CustomExtensionDataTypeMap)
        {
        }
    }
}
