// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Backend update parameters.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class BackendUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the BackendUpdateParameters class.
        /// </summary>
        public BackendUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BackendUpdateParameters class.
        /// </summary>
        /// <param name="title">Backend Title.</param>
        /// <param name="description">Backend Description.</param>
        /// <param name="resourceId">Management Uri of the Resource in External
        /// System. This URL can be the Arm Resource Id of Logic Apps, Function
        /// Apps or API Apps.</param>
        /// <param name="properties">Backend Properties contract</param>
        /// <param name="credentials">Backend Credentials Contract
        /// Properties</param>
        /// <param name="proxy">Backend gateway Contract Properties</param>
        /// <param name="tls">Backend TLS Properties</param>
        /// <param name="url">Runtime Url of the Backend.</param>
        /// <param name="protocol">Backend communication protocol. Possible
        /// values include: 'http', 'soap'</param>
        public BackendUpdateParameters(string title = default(string), string description = default(string), string resourceId = default(string), BackendProperties properties = default(BackendProperties), BackendCredentialsContract credentials = default(BackendCredentialsContract), BackendProxyContract proxy = default(BackendProxyContract), BackendTlsProperties tls = default(BackendTlsProperties), string url = default(string), string protocol = default(string))
        {
            Title = title;
            Description = description;
            ResourceId = resourceId;
            Properties = properties;
            Credentials = credentials;
            Proxy = proxy;
            Tls = tls;
            Url = url;
            Protocol = protocol;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets backend Title.
        /// </summary>
        [JsonProperty(PropertyName = "properties.title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets backend Description.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets management Uri of the Resource in External System.
        /// This URL can be the Arm Resource Id of Logic Apps, Function Apps or
        /// API Apps.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceId")]
        public string ResourceId { get; set; }

        /// <summary>
        /// Gets or sets backend Properties contract
        /// </summary>
        [JsonProperty(PropertyName = "properties.properties")]
        public BackendProperties Properties { get; set; }

        /// <summary>
        /// Gets or sets backend Credentials Contract Properties
        /// </summary>
        [JsonProperty(PropertyName = "properties.credentials")]
        public BackendCredentialsContract Credentials { get; set; }

        /// <summary>
        /// Gets or sets backend gateway Contract Properties
        /// </summary>
        [JsonProperty(PropertyName = "properties.proxy")]
        public BackendProxyContract Proxy { get; set; }

        /// <summary>
        /// Gets or sets backend TLS Properties
        /// </summary>
        [JsonProperty(PropertyName = "properties.tls")]
        public BackendTlsProperties Tls { get; set; }

        /// <summary>
        /// Gets or sets runtime Url of the Backend.
        /// </summary>
        [JsonProperty(PropertyName = "properties.url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets backend communication protocol. Possible values
        /// include: 'http', 'soap'
        /// </summary>
        [JsonProperty(PropertyName = "properties.protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Title != null)
            {
                if (Title.Length > 300)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Title", 300);
                }
                if (Title.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Title", 1);
                }
            }
            if (Description != null)
            {
                if (Description.Length > 2000)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Description", 2000);
                }
                if (Description.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Description", 1);
                }
            }
            if (ResourceId != null)
            {
                if (ResourceId.Length > 2000)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "ResourceId", 2000);
                }
                if (ResourceId.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "ResourceId", 1);
                }
            }
            if (Properties != null)
            {
                Properties.Validate();
            }
            if (Credentials != null)
            {
                Credentials.Validate();
            }
            if (Proxy != null)
            {
                Proxy.Validate();
            }
            if (Url != null)
            {
                if (Url.Length > 2000)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Url", 2000);
                }
                if (Url.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Url", 1);
                }
            }
        }
    }
}
