﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Costmanagement;
using Costmanagement.Models;
using CostManagement.Tests.Helpers;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using Xunit;

namespace CostManagement.Tests.ScenarioTests
{
    public class BillingAccountDimensionTests : TestBase
    {
        protected const string BillingAccountId = "100";
        protected const int NumberOfItems = 3;
        protected const string CategoryFilter = "ResourceId";
        protected static DateTime StartDate = new DateTime(2018, 3, 1);
        protected static DateTime EndDate = new DateTime(2018, 5, 25);
        protected const string DateFormat = "yyyy-MM-dd";

        [Fact]
        public void BillingAccountnDimensionDefaultTest()
        {
            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                var costMgmtClient = CostManagementTestUtilities.GetCostManagementClient(
                    context, new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK });
                var result = costMgmtClient.BillingAccountDimensions.List(BillingAccountId);
                Assert.NotNull(result);
                Assert.True(result.IsAny());
                foreach (var item in result)
                {
                    ValidateProperties(item);
                }
            }
        }

        [Fact]
        public void BillingAccountDimensionWithNextPageLinkTest()
        {
            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                var costMgmtClient = CostManagementTestUtilities.GetCostManagementClient(
                    context, new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK });
                var result = costMgmtClient.BillingAccountDimensions.List(
                    BillingAccountId,
                    odataQuery: new Microsoft.Rest.Azure.OData.ODataQuery<Dimension>
                    {
                        Top = NumberOfItems
                    });
                Assert.NotNull(result);
                Assert.True(result.IsAny());
                Assert.True(result.Count() <= NumberOfItems);
                foreach (var item in result)
                {
                    ValidateProperties(item);
                }
            }
        }

        [Fact]
        public void BillingAccountDimensionWithExpandDataTest()
        {
            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                var costMgmtClient = CostManagementTestUtilities.GetCostManagementClient(
                    context, new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK });
                var result = costMgmtClient.BillingAccountDimensions.List(
                    BillingAccountId,
                    odataQuery: new Microsoft.Rest.Azure.OData.ODataQuery<Dimension>
                    {
                        Top = NumberOfItems,
                        Expand = "properties/data"
                    });
                Assert.NotNull(result);
                Assert.True(result.IsAny());
                Assert.True(result.Count() <= NumberOfItems);
                foreach (var item in result)
                {
                    ValidateProperties(item, true);
                }
            }
        }

        [Fact]
        public void BillingAccountDimensionWithCategoryFilterTest()
        {
            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                var costMgmtClient = CostManagementTestUtilities.GetCostManagementClient(
                    context, new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK });
                var result = costMgmtClient.BillingAccountDimensions.List(
                    BillingAccountId,
                    odataQuery: new Microsoft.Rest.Azure.OData.ODataQuery<Dimension>
                    {
                        Top = NumberOfItems,
                        Filter = "properties/category eq '" + CategoryFilter + "'"
                    });
                Assert.NotNull(result);
                Assert.True(result.IsAny());
                Assert.True(result.Count() <= NumberOfItems);
                foreach (var item in result)
                {
                    ValidateProperties(item, false, CategoryFilter);
                }
            }
        }

        [Fact]
        public void BillingAccountDimensionWithDateFilterTest()
        {
            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                var startDate = StartDate.ToString(DateFormat);
                var endDate = EndDate.ToString(DateFormat);

                var costMgmtClient = CostManagementTestUtilities.GetCostManagementClient(
                    context, new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK });
                var result = costMgmtClient.BillingAccountDimensions.List(
                    BillingAccountId,
                    odataQuery: new Microsoft.Rest.Azure.OData.ODataQuery<Dimension>
                    {
                        Top = NumberOfItems,
                        Filter = "properties/usageStart ge " + startDate + " and properties/usageEnd le " + endDate
                    });
                Assert.NotNull(result);
                Assert.True(result.IsAny());
                Assert.True(result.Count() <= NumberOfItems);
                foreach (var item in result)
                {
                    ValidateProperties(item, false, null, true);
                }
            }
        }


        private static void ValidateProperties(Dimension item, bool dataExpanded = false, string categoryFilter = null, bool dateFilter = false)
        {
            Assert.NotNull(item.Total);
            Assert.NotNull(item.Category);
            Assert.NotNull(item.UsageStart);
            Assert.NotNull(item.UsageEnd);

            if (dataExpanded)
            {
                Assert.NotNull(item.Data);
                Assert.True(item.Data.Any());
            }

            if (!string.IsNullOrWhiteSpace(categoryFilter))
            {
                Assert.Equal(categoryFilter, item.Category, ignoreCase: true);
            }

            if (dateFilter)
            {
                Assert.True(item.UsageStart == StartDate);
                Assert.True(item.UsageEnd == EndDate);
            }
        }

    }
}
