// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Microsoft.Azure.Functions.Worker.Extensions.Abstractions;

namespace Microsoft.Azure.WebJobs.Extensions.AuthenticationEvents
{
    /// <summary>Authentication Event Trigger that will trigger incoming authentication events.</summary>
    public class AuthenticationEventsTriggerAttribute : TriggerBindingAttribute
    {
        /// <summary>Initializes a new instance of the <see cref="AuthenticationEventsTriggerAttribute" /> class.</summary>
        public AuthenticationEventsTriggerAttribute()
        {
        }

        /// <summary>Gets or sets the Authorized Party application identifier.</summary>
        /// <value>The app id would default to public cloud id</value>
        public string AuthorizedPartyAppId { get; set; } = "99045fe1-7639-4a75-9d4a-577b6ca3810f";

        /// <summary>Gets or sets the audience application identifier.</summary>
        /// <value>The audience application identifier.</value>
        public string AudienceAppId { get; set; }

        /// <summary>
        /// The authority is a URL that indicates the directory where the token came from
        /// </summary>
        public string AuthorityUrl { get; set; }

        internal bool IsParameterString { get; set; } = true;
    }
}
