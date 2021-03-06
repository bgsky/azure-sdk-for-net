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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The delivery information associated with a report config.
    /// </summary>
    public partial class ReportConfigDeliveryInfo
    {
        /// <summary>
        /// Initializes a new instance of the ReportConfigDeliveryInfo class.
        /// </summary>
        public ReportConfigDeliveryInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ReportConfigDeliveryInfo class.
        /// </summary>
        /// <param name="destination">Has destination for the report being
        /// delivered.</param>
        public ReportConfigDeliveryInfo(ReportConfigDeliveryDestination destination)
        {
            Destination = destination;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets has destination for the report being delivered.
        /// </summary>
        [JsonProperty(PropertyName = "destination")]
        public ReportConfigDeliveryDestination Destination { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Destination == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Destination");
            }
            if (Destination != null)
            {
                Destination.Validate();
            }
        }
    }
}
