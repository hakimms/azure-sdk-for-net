// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Threading.Tasks;

using Microsoft.Azure.Entra.Authentication;
using Microsoft.Azure.WebJobs.Extensions.AuthenticationEvents.Framework.Validators;

namespace Microsoft.Azure.WebJobs.Extensions.AuthenticationEvents.Framework
{
    /// <summary>The base class for all typed event requests.</summary>
    public class AuthenticationEvent<TEventType>
    {
        /// <summary>
        /// The request status object from the server side.
        /// </summary>
        public CustomExtensionCalloutRequest Request { get; internal set; }

        /// <summary>Gets or sets the related EventResponse object.</summary>
        /// <value>The response.</value>
        public CustomExtensionCalloutResponse Response { get; internal set; }

        /// <summary>Gets or sets the type.</summary>
        /// <value>The type.</value>
        [AuthEventIdentifier]
        [Required]
        public string AuthEventIdentifierType { get; internal set; } = string.Empty;

        /// <summary>Gets or sets the request status.</summary>
        /// <value>The request status.</value>
        [Required]
        public RequestStatusType AuthenticationEventStatus { get; internal set; }

        /// <summary>Gets or sets the status message.</summary>
        /// <value>The status message.</value>
        [Required]
        public string StatusMessage { get; set; } = string.Empty;

        /// <summary>Validates the response and creates the IActionResult with the json payload based on the status of the request.</summary>
        /// <returns>IActionResult based on the EventStatus (UnauthorizedResult, BadRequestObjectResult or JsonResult).</returns>
        public async override Task<AuthenticationEventResponse> Completed()
        {
            try
            {
                if (AuthenticationEventStatus == RequestStatusType.Failed || AuthenticationEventStatus == RequestStatusType.ValidationError)
                {
                    Response.MarkAsFailed(new Exception(string.IsNullOrEmpty(StatusMessage) ? AuthenticationEventResource.Ex_Gen_Failure : StatusMessage), true);
                }
                else if (AuthenticationEventStatus == RequestStatusType.TokenInvalid)
                {
                    Response.MarkAsUnauthorized();
                }
            }
            catch (Exception ex)
            {
                return await Failed(ex, true).ConfigureAwait(false);
            }

            return Response;
        }

        internal override Task<AuthenticationEventResponse> Failed(Exception exception, bool internalError)
        {
            if (Response == null)
            {
                Response = new TResponse();
            }

            Response.MarkAsFailed(exception, internalError);
            return Task.FromResult<AuthenticationEventResponse>((TResponse)Response);
        }

        /// <summary>Converts to string.</summary>
        /// <returns>A <see cref="string" /> that represents this instance.</returns>a
        public override string ToString()
        {
            JsonSerializerOptions options = JsonSerializerOptions;
            options.Converters.Add(new AuthenticationEventResponseConverterFactory());
            return JsonSerializer.Serialize((object)this, options);
        }

        internal virtual JsonSerializerOptions JsonSerializerOptions => new JsonSerializerOptions() { WriteIndented = true, PropertyNameCaseInsensitive = true };

        internal abstract AuthenticationEventResponse GetResponseObject();

        /// <summary>Set the response to Failed mode.</summary>
        /// <param name="exception">The exception to return in the response.</param>
        /// <param name="internalError">Throw 500 internal server error.</param>
        /// <returns>The Underlying AuthEventResponse.</returns>
        internal abstract Task<AuthenticationEventResponse> Failed(Exception exception, bool internalError);

        /// <summary>Set the response to Failed mode.</summary>
        /// <param name="exception">The exception to return in the response.</param>
        /// <returns>The Underlying AuthEventResponse.</returns>
        public Task<AuthenticationEventResponse> Failed(Exception exception)
        {
            return Failed(exception, false);
        }

        /// <summary>Validates the response and creates the IActionResult with the json payload based on the status of the request.</summary>
        /// <returns>IActionResult based on the EventStatus (UnauthorizedResult, BadRequestObjectResult or JsonResult).</returns>
        public abstract Task<AuthenticationEventResponse> Completed();
    }
}