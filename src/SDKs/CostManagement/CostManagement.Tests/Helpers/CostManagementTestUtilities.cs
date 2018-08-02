// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.


using Costmanagement;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using System.Net;

namespace CostManagement.Tests.Helpers
{
    public static class CostManagementTestUtilities
    {
        public static CostManagementClient GetCostManagementClient(MockContext context, RecordedDelegatingHandler handler = null)
        {
            if (handler != null)
            {
                handler.IsPassThrough = true;
            }

            var client = context.GetServiceClient<CostManagementClient>(handlers:
                handler ?? new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK });
            return client;
        }
    }
}