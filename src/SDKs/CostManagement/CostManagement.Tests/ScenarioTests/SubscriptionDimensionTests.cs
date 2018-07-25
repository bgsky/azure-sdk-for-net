// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Costmanagement;
using CostManagement.Tests.Helpers;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using System.Net;
using Xunit;

namespace CostManagement.Tests.ScenarioTests
{
    public class SubscriptionDimensionTests : TestBase
    {
        protected const string subscriptionId = "39ae8bea-c3fd-4e24-8936-7c34974326ce";

        [Fact]
        public void SubscriptionDimensionDefaultTest()
        {
            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                var costMgmtClient = CostManagementTestUtilities.GetCostManagementClient(
                    context, new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK});
                costMgmtClient.SubscriptionId = subscriptionId;
                var result = costMgmtClient.SubscriptionDimensions.List();
                Assert.NotNull(result);
            }
        }

    }
}
