// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.RecoveryServicesBackup;
using Azure.ResourceManager.RecoveryServicesBackup.Models;

namespace Azure.ResourceManager.RecoveryServicesBackup.Samples
{
    public partial class Sample_BackupProtectedItemCollection
    {
        // Get Protected Classic Virtual Machine Details
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetProtectedClassicVirtualMachineDetails()
        {
            // Generated from example definition: specification/recoveryservicesbackup/resource-manager/Microsoft.RecoveryServices/stable/2023-04-01/examples/AzureIaasVm/ClassicCompute_ProtectedItem_Get.json
            // this example is just showing the usage of "ProtectedItems_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BackupProtectionContainerResource created on azure
            // for more information of creating BackupProtectionContainerResource, please refer to the document of BackupProtectionContainerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "PythonSDKBackupTestRg";
            string vaultName = "PySDKBackupTestRsVault";
            string fabricName = "Azure";
            string containerName = "iaasvmcontainer;iaasvmcontainer;iaasvm-rg;iaasvm-1";
            ResourceIdentifier backupProtectionContainerResourceId = BackupProtectionContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName, fabricName, containerName);
            BackupProtectionContainerResource backupProtectionContainer = client.GetBackupProtectionContainerResource(backupProtectionContainerResourceId);

            // get the collection of this BackupProtectedItemResource
            BackupProtectedItemCollection collection = backupProtectionContainer.GetBackupProtectedItems();

            // invoke the operation
            string protectedItemName = "vm;iaasvmcontainer;iaasvm-rg;iaasvm-1";
            BackupProtectedItemResource result = await collection.GetAsync(protectedItemName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BackupProtectedItemData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Protected Classic Virtual Machine Details
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetProtectedClassicVirtualMachineDetails()
        {
            // Generated from example definition: specification/recoveryservicesbackup/resource-manager/Microsoft.RecoveryServices/stable/2023-04-01/examples/AzureIaasVm/ClassicCompute_ProtectedItem_Get.json
            // this example is just showing the usage of "ProtectedItems_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BackupProtectionContainerResource created on azure
            // for more information of creating BackupProtectionContainerResource, please refer to the document of BackupProtectionContainerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "PythonSDKBackupTestRg";
            string vaultName = "PySDKBackupTestRsVault";
            string fabricName = "Azure";
            string containerName = "iaasvmcontainer;iaasvmcontainer;iaasvm-rg;iaasvm-1";
            ResourceIdentifier backupProtectionContainerResourceId = BackupProtectionContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName, fabricName, containerName);
            BackupProtectionContainerResource backupProtectionContainer = client.GetBackupProtectionContainerResource(backupProtectionContainerResourceId);

            // get the collection of this BackupProtectedItemResource
            BackupProtectedItemCollection collection = backupProtectionContainer.GetBackupProtectedItems();

            // invoke the operation
            string protectedItemName = "vm;iaasvmcontainer;iaasvm-rg;iaasvm-1";
            bool result = await collection.ExistsAsync(protectedItemName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get Protected Virtual Machine Details
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetProtectedVirtualMachineDetails()
        {
            // Generated from example definition: specification/recoveryservicesbackup/resource-manager/Microsoft.RecoveryServices/stable/2023-04-01/examples/AzureIaasVm/Compute_ProtectedItem_Get.json
            // this example is just showing the usage of "ProtectedItems_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BackupProtectionContainerResource created on azure
            // for more information of creating BackupProtectionContainerResource, please refer to the document of BackupProtectionContainerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "PythonSDKBackupTestRg";
            string vaultName = "PySDKBackupTestRsVault";
            string fabricName = "Azure";
            string containerName = "iaasvmcontainer;iaasvmcontainerv2;iaasvm-rg;iaasvm-1";
            ResourceIdentifier backupProtectionContainerResourceId = BackupProtectionContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName, fabricName, containerName);
            BackupProtectionContainerResource backupProtectionContainer = client.GetBackupProtectionContainerResource(backupProtectionContainerResourceId);

            // get the collection of this BackupProtectedItemResource
            BackupProtectedItemCollection collection = backupProtectionContainer.GetBackupProtectedItems();

            // invoke the operation
            string protectedItemName = "vm;iaasvmcontainerv2;iaasvm-rg;iaasvm-1";
            BackupProtectedItemResource result = await collection.GetAsync(protectedItemName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BackupProtectedItemData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get Protected Virtual Machine Details
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetProtectedVirtualMachineDetails()
        {
            // Generated from example definition: specification/recoveryservicesbackup/resource-manager/Microsoft.RecoveryServices/stable/2023-04-01/examples/AzureIaasVm/Compute_ProtectedItem_Get.json
            // this example is just showing the usage of "ProtectedItems_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BackupProtectionContainerResource created on azure
            // for more information of creating BackupProtectionContainerResource, please refer to the document of BackupProtectionContainerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "PythonSDKBackupTestRg";
            string vaultName = "PySDKBackupTestRsVault";
            string fabricName = "Azure";
            string containerName = "iaasvmcontainer;iaasvmcontainerv2;iaasvm-rg;iaasvm-1";
            ResourceIdentifier backupProtectionContainerResourceId = BackupProtectionContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName, fabricName, containerName);
            BackupProtectionContainerResource backupProtectionContainer = client.GetBackupProtectionContainerResource(backupProtectionContainerResourceId);

            // get the collection of this BackupProtectedItemResource
            BackupProtectedItemCollection collection = backupProtectionContainer.GetBackupProtectedItems();

            // invoke the operation
            string protectedItemName = "vm;iaasvmcontainerv2;iaasvm-rg;iaasvm-1";
            bool result = await collection.ExistsAsync(protectedItemName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Enable Protection on Azure IaasVm
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_EnableProtectionOnAzureIaasVm()
        {
            // Generated from example definition: specification/recoveryservicesbackup/resource-manager/Microsoft.RecoveryServices/stable/2023-04-01/examples/AzureIaasVm/ConfigureProtection.json
            // this example is just showing the usage of "ProtectedItems_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BackupProtectionContainerResource created on azure
            // for more information of creating BackupProtectionContainerResource, please refer to the document of BackupProtectionContainerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "SwaggerTestRg";
            string vaultName = "NetSDKTestRsVault";
            string fabricName = "Azure";
            string containerName = "IaasVMContainer;iaasvmcontainerv2;netsdktestrg;netvmtestv2vm1";
            ResourceIdentifier backupProtectionContainerResourceId = BackupProtectionContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName, fabricName, containerName);
            BackupProtectionContainerResource backupProtectionContainer = client.GetBackupProtectionContainerResource(backupProtectionContainerResourceId);

            // get the collection of this BackupProtectedItemResource
            BackupProtectedItemCollection collection = backupProtectionContainer.GetBackupProtectedItems();

            // invoke the operation
            string protectedItemName = "VM;iaasvmcontainerv2;netsdktestrg;netvmtestv2vm1";
            BackupProtectedItemData data = new BackupProtectedItemData(new AzureLocation("placeholder"))
            {
                Properties = new IaasComputeVmProtectedItem()
                {
                    SourceResourceId = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/netsdktestrg/providers/Microsoft.Compute/virtualMachines/netvmtestv2vm1"),
                    PolicyId = new ResourceIdentifier("/Subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/SwaggerTestRg/providers/Microsoft.RecoveryServices/vaults/NetSDKTestRsVault/backupPolicies/DefaultPolicy"),
                },
            };
            ArmOperation<BackupProtectedItemResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, protectedItemName, data);
            BackupProtectedItemResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BackupProtectedItemData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Stop Protection with retain data on Azure IaasVm
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_StopProtectionWithRetainDataOnAzureIaasVm()
        {
            // Generated from example definition: specification/recoveryservicesbackup/resource-manager/Microsoft.RecoveryServices/stable/2023-04-01/examples/AzureIaasVm/StopProtection.json
            // this example is just showing the usage of "ProtectedItems_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BackupProtectionContainerResource created on azure
            // for more information of creating BackupProtectionContainerResource, please refer to the document of BackupProtectionContainerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "SwaggerTestRg";
            string vaultName = "NetSDKTestRsVault";
            string fabricName = "Azure";
            string containerName = "IaasVMContainer;iaasvmcontainerv2;netsdktestrg;netvmtestv2vm1";
            ResourceIdentifier backupProtectionContainerResourceId = BackupProtectionContainerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, vaultName, fabricName, containerName);
            BackupProtectionContainerResource backupProtectionContainer = client.GetBackupProtectionContainerResource(backupProtectionContainerResourceId);

            // get the collection of this BackupProtectedItemResource
            BackupProtectedItemCollection collection = backupProtectionContainer.GetBackupProtectedItems();

            // invoke the operation
            string protectedItemName = "VM;iaasvmcontainerv2;netsdktestrg;netvmtestv2vm1";
            BackupProtectedItemData data = new BackupProtectedItemData(new AzureLocation("placeholder"))
            {
                Properties = new IaasComputeVmProtectedItem()
                {
                    ProtectionState = BackupProtectionState.ProtectionStopped,
                    SourceResourceId = new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/netsdktestrg/providers/Microsoft.Compute/virtualMachines/netvmtestv2vm1"),
                },
            };
            ArmOperation<BackupProtectedItemResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, protectedItemName, data);
            BackupProtectedItemResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BackupProtectedItemData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
