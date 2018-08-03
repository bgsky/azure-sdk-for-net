// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Costmanagement.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The start and end date for pulling data for the report.
    /// </summary>
    public partial class ReportConfigTimePeriod
    {
        /// <summary>
        /// Initializes a new instance of the ReportConfigTimePeriod class.
        /// </summary>
        public ReportConfigTimePeriod()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ReportConfigTimePeriod class.
        /// </summary>
        /// <param name="fromProperty">The start date to pull data
        /// from.</param>
        /// <param name="to">The end date to pull data to.</param>
        public ReportConfigTimePeriod(System.DateTime fromProperty, System.DateTime to)
        {
            FromProperty = fromProperty;
            To = to;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the start date to pull data from.
        /// </summary>
        [JsonProperty(PropertyName = "from")]
        public System.DateTime FromProperty { get; set; }

        /// <summary>
        /// Gets or sets the end date to pull data to.
        /// </summary>
        [JsonProperty(PropertyName = "to")]
        public System.DateTime To { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}