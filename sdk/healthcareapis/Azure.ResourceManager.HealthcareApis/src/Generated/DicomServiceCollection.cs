// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.HealthcareApis
{
    /// <summary>
    /// A class representing a collection of <see cref="DicomServiceResource" /> and their operations.
    /// Each <see cref="DicomServiceResource" /> in the collection will belong to the same instance of <see cref="HealthcareApisWorkspaceResource" />.
    /// To get a <see cref="DicomServiceCollection" /> instance call the GetDicomServices method from an instance of <see cref="HealthcareApisWorkspaceResource" />.
    /// </summary>
    public partial class DicomServiceCollection : ArmCollection, IEnumerable<DicomServiceResource>, IAsyncEnumerable<DicomServiceResource>
    {
        private readonly ClientDiagnostics _dicomServiceClientDiagnostics;
        private readonly DicomServicesRestOperations _dicomServiceRestClient;

        /// <summary> Initializes a new instance of the <see cref="DicomServiceCollection"/> class for mocking. </summary>
        protected DicomServiceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DicomServiceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DicomServiceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dicomServiceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HealthcareApis", DicomServiceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DicomServiceResource.ResourceType, out string dicomServiceApiVersion);
            _dicomServiceRestClient = new DicomServicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dicomServiceApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != HealthcareApisWorkspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, HealthcareApisWorkspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a DICOM Service resource with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/dicomservices/{dicomServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DicomServices_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dicomServiceName"> The name of DICOM Service resource. </param>
        /// <param name="data"> The parameters for creating or updating a Dicom Service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dicomServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dicomServiceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DicomServiceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string dicomServiceName, DicomServiceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dicomServiceName, nameof(dicomServiceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dicomServiceClientDiagnostics.CreateScope("DicomServiceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dicomServiceRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dicomServiceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new HealthcareApisArmOperation<DicomServiceResource>(new DicomServiceOperationSource(Client), _dicomServiceClientDiagnostics, Pipeline, _dicomServiceRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dicomServiceName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a DICOM Service resource with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/dicomservices/{dicomServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DicomServices_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="dicomServiceName"> The name of DICOM Service resource. </param>
        /// <param name="data"> The parameters for creating or updating a Dicom Service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dicomServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dicomServiceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DicomServiceResource> CreateOrUpdate(WaitUntil waitUntil, string dicomServiceName, DicomServiceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dicomServiceName, nameof(dicomServiceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dicomServiceClientDiagnostics.CreateScope("DicomServiceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dicomServiceRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dicomServiceName, data, cancellationToken);
                var operation = new HealthcareApisArmOperation<DicomServiceResource>(new DicomServiceOperationSource(Client), _dicomServiceClientDiagnostics, Pipeline, _dicomServiceRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dicomServiceName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the properties of the specified DICOM Service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/dicomservices/{dicomServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DicomServices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dicomServiceName"> The name of DICOM Service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dicomServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dicomServiceName"/> is null. </exception>
        public virtual async Task<Response<DicomServiceResource>> GetAsync(string dicomServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dicomServiceName, nameof(dicomServiceName));

            using var scope = _dicomServiceClientDiagnostics.CreateScope("DicomServiceCollection.Get");
            scope.Start();
            try
            {
                var response = await _dicomServiceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dicomServiceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DicomServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the properties of the specified DICOM Service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/dicomservices/{dicomServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DicomServices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dicomServiceName"> The name of DICOM Service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dicomServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dicomServiceName"/> is null. </exception>
        public virtual Response<DicomServiceResource> Get(string dicomServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dicomServiceName, nameof(dicomServiceName));

            using var scope = _dicomServiceClientDiagnostics.CreateScope("DicomServiceCollection.Get");
            scope.Start();
            try
            {
                var response = _dicomServiceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dicomServiceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DicomServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all DICOM Services for the given workspace
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/dicomservices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DicomServices_ListByWorkspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DicomServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DicomServiceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dicomServiceRestClient.CreateListByWorkspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dicomServiceRestClient.CreateListByWorkspaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DicomServiceResource(Client, DicomServiceData.DeserializeDicomServiceData(e)), _dicomServiceClientDiagnostics, Pipeline, "DicomServiceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all DICOM Services for the given workspace
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/dicomservices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DicomServices_ListByWorkspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DicomServiceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DicomServiceResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dicomServiceRestClient.CreateListByWorkspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dicomServiceRestClient.CreateListByWorkspaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DicomServiceResource(Client, DicomServiceData.DeserializeDicomServiceData(e)), _dicomServiceClientDiagnostics, Pipeline, "DicomServiceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/dicomservices/{dicomServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DicomServices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dicomServiceName"> The name of DICOM Service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dicomServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dicomServiceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string dicomServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dicomServiceName, nameof(dicomServiceName));

            using var scope = _dicomServiceClientDiagnostics.CreateScope("DicomServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dicomServiceRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dicomServiceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/dicomservices/{dicomServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DicomServices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="dicomServiceName"> The name of DICOM Service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dicomServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dicomServiceName"/> is null. </exception>
        public virtual Response<bool> Exists(string dicomServiceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dicomServiceName, nameof(dicomServiceName));

            using var scope = _dicomServiceClientDiagnostics.CreateScope("DicomServiceCollection.Exists");
            scope.Start();
            try
            {
                var response = _dicomServiceRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, dicomServiceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DicomServiceResource> IEnumerable<DicomServiceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DicomServiceResource> IAsyncEnumerable<DicomServiceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
