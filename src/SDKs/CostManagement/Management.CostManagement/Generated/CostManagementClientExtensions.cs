// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Costmanagement
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for CostManagementClient.
    /// </summary>
    public static partial class CostManagementClientExtensions
    {
            /// <summary>
            /// Lists the usage data for subscriptionId.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the CreateOrUpdate Report Config operation.
            /// </param>
            public static IEnumerable<Query> QuerySubscription(this ICostManagementClient operations, ReportConfigDefinition parameters)
            {
                return operations.QuerySubscriptionAsync(parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the usage data for subscriptionId.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the CreateOrUpdate Report Config operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<Query>> QuerySubscriptionAsync(this ICostManagementClient operations, ReportConfigDefinition parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.QuerySubscriptionWithHttpMessagesAsync(parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the usage data for subscriptionId and resource group.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Azure Resource Group Name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the CreateOrUpdate Report Config operation.
            /// </param>
            public static IEnumerable<Query> QueryResourceGroup(this ICostManagementClient operations, string resourceGroupName, ReportConfigDefinition parameters)
            {
                return operations.QueryResourceGroupAsync(resourceGroupName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the usage data for subscriptionId and resource group.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Azure Resource Group Name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the CreateOrUpdate Report Config operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<Query>> QueryResourceGroupAsync(this ICostManagementClient operations, string resourceGroupName, ReportConfigDefinition parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.QueryResourceGroupWithHttpMessagesAsync(resourceGroupName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the usage data for billing account.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountId'>
            /// BillingAccount ID
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the CreateOrUpdate Report Config operation.
            /// </param>
            public static IEnumerable<Query> QueryBillingAccount(this ICostManagementClient operations, string billingAccountId, ReportConfigDefinition parameters)
            {
                return operations.QueryBillingAccountAsync(billingAccountId, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the usage data for billing account.
            /// <see href="https://docs.microsoft.com/en-us/rest/api/consumption/" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountId'>
            /// BillingAccount ID
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the CreateOrUpdate Report Config operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<Query>> QueryBillingAccountAsync(this ICostManagementClient operations, string billingAccountId, ReportConfigDefinition parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.QueryBillingAccountWithHttpMessagesAsync(billingAccountId, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
