// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetworkCloud.Models;

namespace Azure.ResourceManager.NetworkCloud
{
    /// <summary>
    /// A class representing the NetworkCloudVolume data model.
    /// Volume represents storage made available for use by resources running on the cluster.
    /// </summary>
    public partial class NetworkCloudVolumeData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of NetworkCloudVolumeData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> The extended location of the cluster associated with the resource. </param>
        /// <param name="sizeInMiB"> The size of the allocation for this volume in Mebibytes. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="extendedLocation"/> is null. </exception>
        public NetworkCloudVolumeData(AzureLocation location, ExtendedLocation extendedLocation, long sizeInMiB) : base(location)
        {
            Argument.AssertNotNull(extendedLocation, nameof(extendedLocation));

            ExtendedLocation = extendedLocation;
            AttachedTo = new ChangeTrackingList<string>();
            SizeInMiB = sizeInMiB;
        }

        /// <summary> Initializes a new instance of NetworkCloudVolumeData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> The extended location of the cluster associated with the resource. </param>
        /// <param name="attachedTo"> The list of resource IDs that attach the volume. It may include virtual machines and Hybrid AKS clusters. </param>
        /// <param name="detailedStatus"> The more detailed status of the volume. </param>
        /// <param name="detailedStatusMessage"> The descriptive message about the current detailed status. </param>
        /// <param name="provisioningState"> The provisioning state of the volume. </param>
        /// <param name="serialNumber"> The unique identifier of the volume. </param>
        /// <param name="sizeInMiB"> The size of the allocation for this volume in Mebibytes. </param>
        internal NetworkCloudVolumeData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ExtendedLocation extendedLocation, IReadOnlyList<string> attachedTo, VolumeDetailedStatus? detailedStatus, string detailedStatusMessage, VolumeProvisioningState? provisioningState, string serialNumber, long sizeInMiB) : base(id, name, resourceType, systemData, tags, location)
        {
            ExtendedLocation = extendedLocation;
            AttachedTo = attachedTo;
            DetailedStatus = detailedStatus;
            DetailedStatusMessage = detailedStatusMessage;
            ProvisioningState = provisioningState;
            SerialNumber = serialNumber;
            SizeInMiB = sizeInMiB;
        }

        /// <summary> The extended location of the cluster associated with the resource. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> The list of resource IDs that attach the volume. It may include virtual machines and Hybrid AKS clusters. </summary>
        public IReadOnlyList<string> AttachedTo { get; }
        /// <summary> The more detailed status of the volume. </summary>
        public VolumeDetailedStatus? DetailedStatus { get; }
        /// <summary> The descriptive message about the current detailed status. </summary>
        public string DetailedStatusMessage { get; }
        /// <summary> The provisioning state of the volume. </summary>
        public VolumeProvisioningState? ProvisioningState { get; }
        /// <summary> The unique identifier of the volume. </summary>
        public string SerialNumber { get; }
        /// <summary> The size of the allocation for this volume in Mebibytes. </summary>
        public long SizeInMiB { get; set; }
    }
}
