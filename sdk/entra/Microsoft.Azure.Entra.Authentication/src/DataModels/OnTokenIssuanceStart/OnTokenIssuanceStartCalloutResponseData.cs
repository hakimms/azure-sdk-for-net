// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Microsoft.Azure.Entra.Authentication
{
    /// <summary>
    /// On Token Issuance Start Callout Response Data.
    /// </summary>
    public class OnTokenIssuanceStartCalloutResponseData : CustomExtensionCalloutResponseData
    {
        private const string oDataTypeSuffix = "onTokenIssuanceStartResponseData";

        /// <summary>
        /// Initializes a new instance of the <see cref="OnTokenIssuanceStartCalloutResponseData"/> class.
        /// </summary>
        public OnTokenIssuanceStartCalloutResponseData() : base(oDataTypeSuffix)
        {
        }

        /// <summary>
        /// Gets or sets the ProvideClaimsForToken action.
        /// </summary>
        public ProvideClaimsForTokenAction ProvideClaimsForToken { get; set; }
    }
}
