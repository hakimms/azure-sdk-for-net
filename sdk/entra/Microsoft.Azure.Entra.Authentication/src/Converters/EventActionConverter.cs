// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Microsoft.Azure.Entra.Authentication
{
    /// <summary>
    /// Event action object converter.
    /// Ensures that the json is parsed into the proper subclass based on the type property.
    /// </summary>
    internal class EventActionConverter : DataJsonConverter<EventAction>
    {
        // map of all the allowed action types to their deserialization logic
        private static readonly IReadOnlyDictionary<string, DeserializationFunc> EventActionConvertMap
            = new ReadOnlyDictionary<string, DeserializationFunc>(
                new Dictionary<string, DeserializationFunc>(StringComparer.InvariantCultureIgnoreCase)
                {
                    // OnTokenIssuanceStart actions
                    [ProvideClaimsForTokenAction.LegacyODataTypeName] = Convert<ProvideClaimsForTokenAction>,
                    [ProvideClaimsForTokenAction.ODataTypeName] = Convert<ProvideClaimsForTokenAction>,
                });

        /// <summary>
        /// Initializes a new instance of the <see cref="EventActionConverter"/> class.
        /// </summary>
        public EventActionConverter()
            : base(EventActionConvertMap)
        {
        }
    }
}
