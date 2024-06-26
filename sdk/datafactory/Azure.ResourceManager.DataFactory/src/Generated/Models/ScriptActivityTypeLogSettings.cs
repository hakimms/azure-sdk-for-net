// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Log settings of script activity. </summary>
    public partial class ScriptActivityTypeLogSettings
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ScriptActivityTypeLogSettings"/>. </summary>
        /// <param name="logDestination"> The destination of logs. Type: string. </param>
        public ScriptActivityTypeLogSettings(ScriptActivityLogDestination logDestination)
        {
            LogDestination = logDestination;
        }

        /// <summary> Initializes a new instance of <see cref="ScriptActivityTypeLogSettings"/>. </summary>
        /// <param name="logDestination"> The destination of logs. Type: string. </param>
        /// <param name="logLocationSettings"> Log location settings customer needs to provide when enabling log. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ScriptActivityTypeLogSettings(ScriptActivityLogDestination logDestination, LogLocationSettings logLocationSettings, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LogDestination = logDestination;
            LogLocationSettings = logLocationSettings;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ScriptActivityTypeLogSettings"/> for deserialization. </summary>
        internal ScriptActivityTypeLogSettings()
        {
        }

        /// <summary> The destination of logs. Type: string. </summary>
        public ScriptActivityLogDestination LogDestination { get; set; }
        /// <summary> Log location settings customer needs to provide when enabling log. </summary>
        public LogLocationSettings LogLocationSettings { get; set; }
    }
}
