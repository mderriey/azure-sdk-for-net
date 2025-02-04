﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Threading.Tasks;
using NUnit.Framework;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources.Models;
using Azure.Core;
using Azure.ResourceManager.DnsResolver.Models;
using System.Linq;

namespace Azure.ResourceManager.DnsResolver.Tests
{
    public class DnsResolverTests : DnsResolverTestBase
    {
        private DnsResolverCollection dnsResolverCollection;

        public DnsResolverTests(bool async) : base(async)
        {
        }

        [SetUp]
        public async Task CreateDnsResolverCollectionAsync()
        {
            var subscription = await Client.GetSubscriptions().GetAsync(TestEnvironment.SubscriptionId);
            var resourceGroup = await subscription.Value.GetResourceGroups().GetAsync(TestEnvironment.ResourceGroup);

            this.dnsResolverCollection = resourceGroup.Value.GetDnsResolvers();
        }

        [Test]
        [RecordedTest]
        public async Task CreateDnsResolverAsync()
        {
            // ARRANGE
            var dnsResolverName = Recording.GenerateAssetName("dnsResolver-");
            var vnetName = Recording.GenerateAssetName("dnsResolver-");
            var dnsResolverData = new DnsResolverData(this.DefaultLocation);
            var vnetId = $"/subscriptions/{TestEnvironment.SubscriptionId}/resourceGroups/{TestEnvironment.ResourceGroup}/providers/Microsoft.Network/virtualNetworks/{vnetName}";

            if (Mode == RecordedTestMode.Record)
            {
                await CreateVirtualNetworkAsync(vnetName);
            }

            dnsResolverData.VirtualNetwork = new WritableSubResource()
            {
                Id = new ResourceIdentifier(vnetId)
            };

            // ACT
            var dnsResolver = await this.dnsResolverCollection.CreateOrUpdateAsync(WaitUntil.Completed, dnsResolverName, dnsResolverData);

            // ASSERT
            Assert.AreEqual(dnsResolver.Value.Data.ProvisioningState, ProvisioningState.Succeeded);
        }

        [Test]
        [RecordedTest]
        public async Task GetDnsResolverAsync()
        {
            // ARRANGE
            var dnsResolverName = Recording.GenerateAssetName("dnsResolver-");
            var vnetName = Recording.GenerateAssetName("dnsResolver-");
            var dnsResolverData = new DnsResolverData(this.DefaultLocation);
            var vnetId = $"/subscriptions/{TestEnvironment.SubscriptionId}/resourceGroups/{TestEnvironment.ResourceGroup}/providers/Microsoft.Network/virtualNetworks/{vnetName}";

            if (Mode == RecordedTestMode.Record)
            {
                await CreateVirtualNetworkAsync(vnetName);
            }

            dnsResolverData.VirtualNetwork = new WritableSubResource()
            {
                Id = new ResourceIdentifier(vnetId)
            };

            await this.dnsResolverCollection.CreateOrUpdateAsync(WaitUntil.Completed, dnsResolverName, dnsResolverData);

            // ACT
            var retrievedDnsResolver = await this.dnsResolverCollection.GetAsync(dnsResolverName);

            // ASSERT
            Assert.AreEqual(retrievedDnsResolver.Value.Data.Name, dnsResolverName);
        }

        [Test]
        [RecordedTest]
        [Ignore("Lack of testing resources")]
        public async Task UpdateDnsResolverAsync()
        {
            // ARRANGE
            var dnsResolverName = Recording.GenerateAssetName("dnsResolver-");
            var vnetName = Recording.GenerateAssetName("dnsResolver-");
            var dnsResolverData = new DnsResolverData(this.DefaultLocation);
            var vnetId = $"/subscriptions/{TestEnvironment.SubscriptionId}/resourceGroups/{TestEnvironment.ResourceGroup}/providers/Microsoft.Network/virtualNetworks/{vnetName}";

            if (Mode == RecordedTestMode.Record)
            {
                await CreateVirtualNetworkAsync(vnetName);
            }

            dnsResolverData.VirtualNetwork = new WritableSubResource()
            {
                Id = new ResourceIdentifier(vnetId)
            };

            var createdDnsResolver = await this.dnsResolverCollection.CreateOrUpdateAsync(WaitUntil.Completed, dnsResolverName, dnsResolverData);

            var newTagKey = Recording.GenerateAlphaNumericId("tagKey");
            var newTagValue = Recording.GenerateAlphaNumericId("tagValue");

            // ACT
            var patchedDnsResolver = await createdDnsResolver.Value.AddTagAsync(newTagKey, newTagValue);

            // ASSERT
            CollectionAssert.AreEquivalent(new Dictionary<string, string> { { newTagKey, newTagValue } }, patchedDnsResolver.Value.Data.Tags);
        }

        [Test]
        [RecordedTest]
        public async Task RemoveDnsResolverAsync()
        {
            // ARRANGE
            var dnsResolverName = Recording.GenerateAssetName("dnsResolver-");
            var vnetName = Recording.GenerateAssetName("dnsResolver-");
            var dnsResolverData = new DnsResolverData(this.DefaultLocation);
            var vnetId = $"/subscriptions/{TestEnvironment.SubscriptionId}/resourceGroups/{TestEnvironment.ResourceGroup}/providers/Microsoft.Network/virtualNetworks/{vnetName}";

            if (Mode == RecordedTestMode.Record)
            {
                await CreateVirtualNetworkAsync(vnetName);
            }

            dnsResolverData.VirtualNetwork = new WritableSubResource()
            {
                Id = new ResourceIdentifier(vnetId)
            };

            var dnsResolver = await this.dnsResolverCollection.CreateOrUpdateAsync(WaitUntil.Completed, dnsResolverName, dnsResolverData);

            // ACT
            await dnsResolver.Value.DeleteAsync(WaitUntil.Completed);

            // ASSERT
            var getDnsResolverResult = await this.dnsResolverCollection.ExistsAsync(dnsResolverName);
            Assert.AreEqual(getDnsResolverResult.Value, false);
        }
    }
}
