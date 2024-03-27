// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Microsoft.Azure.Entra.Authentication
{
    /// <summary>
    /// Directory Attribute convertor. Use odataname to convert directory objects.
    /// </summary>
    internal class DirectoryAttributeConverter : ODataJsonConverter<DirectoryAttribute>
    {
        // map of all the allowed action types to their deserialization logic
        private static readonly IReadOnlyDictionary<string, DeserializationFunc> DirectoryAttributeConvertMap
            = new ReadOnlyDictionary<string, DeserializationFunc>(
                new Dictionary<string, DeserializationFunc>(StringComparer.InvariantCultureIgnoreCase)
                {
                    [StringDirectoryAttribute.ODataTypeName] = Convert<StringDirectoryAttribute>,
                    [StringCollectionDirectoryAttribute.ODataTypeName] = Convert<StringCollectionDirectoryAttribute>,
                    [BooleanDirectoryAttribute.ODataTypeName] = Convert<BooleanDirectoryAttribute>,
                    [Int64DirectoryAttribute.ODataTypeName] = Convert<Int64DirectoryAttribute>
                });

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryAttributeConverter"/> class.
        /// </summary>
        public DirectoryAttributeConverter()
            : base(DirectoryAttributeConvertMap)
        {
        }
    }
}
