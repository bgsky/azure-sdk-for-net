// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Costmanagement;
using Costmanagement.Models;
using CostManagement.Tests.Helpers;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using System;
using System.Net;
using Xunit;

namespace CostManagement.Tests.ScenarioTests
{
    public class ReportConfigTests : TestBase
    {
        protected const string SubscriptionId = "1caaa5a3-2b66-438e-8ab4-bce37d518c5d";
        protected const string ResourceGroupName = "testrg";
        protected const string SubscriptionTestName = "subscriptionNetTest";
        protected const string ResourceGroupTestName = "resourceGroupNetTest";

        [Fact]
        public void ReportConfigCreateOrUpdateTest()
        {
            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                var costMgmtClient = CostManagementTestUtilities.GetCostManagementClient(
                    context, new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK });

                costMgmtClient.SubscriptionId = SubscriptionId;
                var report = GetReportBody();

                var reportConfig = costMgmtClient.ReportConfig.CreateOrUpdate(SubscriptionTestName, report);

                Assert.NotNull(reportConfig);
            }
        }

        [Fact]
        public void ReportConfigGetTest()
        {
            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                var costMgmtClient = CostManagementTestUtilities.GetCostManagementClient(
                    context, new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK });

                costMgmtClient.SubscriptionId = SubscriptionId;

                var reportConfig = costMgmtClient.ReportConfig.Get(SubscriptionTestName);

                Assert.NotNull(reportConfig);
            }
        }

        [Fact]
        public void ReportConfigListTest()
        {
            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                var costMgmtClient = CostManagementTestUtilities.GetCostManagementClient(
                    context, new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK });

                costMgmtClient.SubscriptionId = SubscriptionId;

                var reportConfig = costMgmtClient.ReportConfig.List();

                Assert.NotNull(reportConfig);
            }
        }

        [Fact]
        public void ReportConfigDeleteTest()
        {
            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                var costMgmtClient = CostManagementTestUtilities.GetCostManagementClient(
                    context, new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK });

                costMgmtClient.SubscriptionId = SubscriptionId;

                costMgmtClient.ReportConfig.Delete(SubscriptionTestName);
            }
        }

        [Fact]
        public void ReportConfigCreateOrUpdateByResourceGroupNameTest()
        {
            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                var costMgmtClient = CostManagementTestUtilities.GetCostManagementClient(
                    context, new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK });

                costMgmtClient.SubscriptionId = SubscriptionId;
                var report = GetReportBody();

                var reportConfig = costMgmtClient.ReportConfig.CreateOrUpdateByResourceGroupName(ResourceGroupName, ResourceGroupTestName, report);

                Assert.NotNull(reportConfig);
            }
        }

        [Fact]
        public void ReportConfigGetByResourceGroupNameTest()
        {
            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                var costMgmtClient = CostManagementTestUtilities.GetCostManagementClient(
                    context, new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK });

                costMgmtClient.SubscriptionId = SubscriptionId;

                var reportConfig = costMgmtClient.ReportConfig.GetByResourceGroupName(ResourceGroupName, ResourceGroupTestName);

                Assert.NotNull(reportConfig);
            }
        }

        [Fact]
        public void ReportConfigListByResourceGroupNameTest()
        {
            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                var costMgmtClient = CostManagementTestUtilities.GetCostManagementClient(
                    context, new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK });

                costMgmtClient.SubscriptionId = SubscriptionId;

                var reportConfig = costMgmtClient.ReportConfig.ListByResourceGroupName(ResourceGroupName);

                Assert.NotNull(reportConfig);
            }
        }

        [Fact]
        public void ReportConfigDeleteByResourceGroupNameTest()
        {
            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                var costMgmtClient = CostManagementTestUtilities.GetCostManagementClient(
                    context, new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK });

                costMgmtClient.SubscriptionId = SubscriptionId;

                costMgmtClient.ReportConfig.DeleteByResourceGroupName(ResourceGroupName, ResourceGroupTestName);
            }
        }

        public static ReportConfig GetReportBody()
        {
            var report = new ReportConfig()
            {
                Schedule = new ReportConfigSchedule()
                {
                    Status = "Inactive",
                    Recurrence = "Monthly",
                    RecurrencePeriod = new ReportConfigRecurrencePeriod()
                    {
                        FromProperty = DateTime.UtcNow.AddMonths(1),
                        To = DateTime.UtcNow.AddMonths(2)
                    }
                },
                Format = "Csv",
                DeliveryInfo = new ReportConfigDeliveryInfo()
                {
                    Destination = new ReportConfigDeliveryDestination()
                    {
                        ResourceId = "",
                        Container = "",
                        RootFolderPath = ""
                    }
                },
                Definition = new ReportConfigDefinition()
                {
                    Timeframe = TimeframeType.Custom,
                    TimePeriod = new ReportConfigTimePeriod()
                    {
                        FromProperty = DateTime.UtcNow.AddMonths(-1),
                        To = DateTime.UtcNow
                    }
                }
            };
            return report;
        }
    }
}
