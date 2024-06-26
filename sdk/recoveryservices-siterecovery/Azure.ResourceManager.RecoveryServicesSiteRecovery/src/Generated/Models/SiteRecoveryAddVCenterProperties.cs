// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The properties of an add vCenter request. </summary>
    public partial class SiteRecoveryAddVCenterProperties
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

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryAddVCenterProperties"/>. </summary>
        public SiteRecoveryAddVCenterProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryAddVCenterProperties"/>. </summary>
        /// <param name="friendlyName"> The friendly name of the vCenter. </param>
        /// <param name="ipAddress"> The IP address of the vCenter to be discovered. </param>
        /// <param name="processServerId"> The process server Id from where the discovery is orchestrated. </param>
        /// <param name="port"> The port number for discovery. </param>
        /// <param name="runAsAccountId"> The account Id which has privileges to discover the vCenter. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SiteRecoveryAddVCenterProperties(string friendlyName, IPAddress ipAddress, Guid? processServerId, string port, string runAsAccountId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FriendlyName = friendlyName;
            IPAddress = ipAddress;
            ProcessServerId = processServerId;
            Port = port;
            RunAsAccountId = runAsAccountId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The friendly name of the vCenter. </summary>
        public string FriendlyName { get; set; }
        /// <summary> The IP address of the vCenter to be discovered. </summary>
        public IPAddress IPAddress { get; set; }
        /// <summary> The process server Id from where the discovery is orchestrated. </summary>
        public Guid? ProcessServerId { get; set; }
        /// <summary> The port number for discovery. </summary>
        public string Port { get; set; }
        /// <summary> The account Id which has privileges to discover the vCenter. </summary>
        public string RunAsAccountId { get; set; }
    }
}
