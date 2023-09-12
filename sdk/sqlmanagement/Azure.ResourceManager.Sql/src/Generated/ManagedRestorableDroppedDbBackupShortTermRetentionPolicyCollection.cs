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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource" /> and their operations.
    /// Each <see cref="ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource" /> in the collection will belong to the same instance of <see cref="RestorableDroppedManagedDatabaseResource" />.
    /// To get a <see cref="ManagedRestorableDroppedDbBackupShortTermRetentionPolicyCollection" /> instance call the GetManagedRestorableDroppedDbBackupShortTermRetentionPolicies method from an instance of <see cref="RestorableDroppedManagedDatabaseResource" />.
    /// </summary>
    public partial class ManagedRestorableDroppedDbBackupShortTermRetentionPolicyCollection : ArmCollection, IEnumerable<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource>, IAsyncEnumerable<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource>
    {
        private readonly ClientDiagnostics _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics;
        private readonly ManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestOperations _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedRestorableDroppedDbBackupShortTermRetentionPolicyCollection"/> class for mocking. </summary>
        protected ManagedRestorableDroppedDbBackupShortTermRetentionPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedRestorableDroppedDbBackupShortTermRetentionPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ManagedRestorableDroppedDbBackupShortTermRetentionPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource.ResourceType, out string managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesApiVersion);
            _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient = new ManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != RestorableDroppedManagedDatabaseResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, RestorableDroppedManagedDatabaseResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Sets a database's short term retention policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}/backupShortTermRetentionPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policyName"> The policy name. Should always be "default". </param>
        /// <param name="data"> The short term retention policy info. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, ManagedShortTermRetentionPolicyName policyName, ManagedBackupShortTermRetentionPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedRestorableDroppedDbBackupShortTermRetentionPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource>(new ManagedRestorableDroppedDbBackupShortTermRetentionPolicyOperationSource(Client), _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics, Pipeline, _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Sets a database's short term retention policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}/backupShortTermRetentionPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="policyName"> The policy name. Should always be "default". </param>
        /// <param name="data"> The short term retention policy info. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource> CreateOrUpdate(WaitUntil waitUntil, ManagedShortTermRetentionPolicyName policyName, ManagedBackupShortTermRetentionPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedRestorableDroppedDbBackupShortTermRetentionPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, data, cancellationToken);
                var operation = new SqlArmOperation<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource>(new ManagedRestorableDroppedDbBackupShortTermRetentionPolicyOperationSource(Client), _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics, Pipeline, _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a dropped database's short term retention policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}/backupShortTermRetentionPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyName"> The policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource>> GetAsync(ManagedShortTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedRestorableDroppedDbBackupShortTermRetentionPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a dropped database's short term retention policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}/backupShortTermRetentionPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyName"> The policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource> Get(ManagedShortTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedRestorableDroppedDbBackupShortTermRetentionPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a dropped database's short term retention policy list.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}/backupShortTermRetentionPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies_ListByRestorableDroppedDatabase</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.CreateListByRestorableDroppedDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.CreateListByRestorableDroppedDatabaseNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource(Client, ManagedBackupShortTermRetentionPolicyData.DeserializeManagedBackupShortTermRetentionPolicyData(e)), _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics, Pipeline, "ManagedRestorableDroppedDbBackupShortTermRetentionPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a dropped database's short term retention policy list.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}/backupShortTermRetentionPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies_ListByRestorableDroppedDatabase</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.CreateListByRestorableDroppedDatabaseRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.CreateListByRestorableDroppedDatabaseNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource(Client, ManagedBackupShortTermRetentionPolicyData.DeserializeManagedBackupShortTermRetentionPolicyData(e)), _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics, Pipeline, "ManagedRestorableDroppedDbBackupShortTermRetentionPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}/backupShortTermRetentionPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyName"> The policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(ManagedShortTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedRestorableDroppedDbBackupShortTermRetentionPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}/backupShortTermRetentionPolicies/{policyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="policyName"> The policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(ManagedShortTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            using var scope = _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesClientDiagnostics.CreateScope("ManagedRestorableDroppedDbBackupShortTermRetentionPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _managedRestorableDroppedDbBackupShortTermRetentionPolicyManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource> IEnumerable<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource> IAsyncEnumerable<ManagedRestorableDroppedDbBackupShortTermRetentionPolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
