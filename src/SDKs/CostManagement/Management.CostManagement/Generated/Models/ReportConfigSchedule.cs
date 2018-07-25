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
    /// The schedule associated with a report config.
    /// </summary>
    public partial class ReportConfigSchedule
    {
        /// <summary>
        /// Initializes a new instance of the ReportConfigSchedule class.
        /// </summary>
        public ReportConfigSchedule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ReportConfigSchedule class.
        /// </summary>
        /// <param name="recurrence">The schedule recurrence. Possible values
        /// include: 'Daily', 'Weekly', 'Monthly', 'Annually'</param>
        /// <param name="recurrencePeriod">Has start and end date of the
        /// recurrence. The start date must be in future. If present, the end
        /// date must be greater than start date.</param>
        /// <param name="status">The status of the schedule. Whether active or
        /// not. If inactive, the report's scheduled execution is paused.
        /// Possible values include: 'Active', 'Inactive'</param>
        public ReportConfigSchedule(string recurrence, ReportConfigRecurrencePeriod recurrencePeriod, string status = default(string))
        {
            Status = status;
            Recurrence = recurrence;
            RecurrencePeriod = recurrencePeriod;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the status of the schedule. Whether active or not. If
        /// inactive, the report's scheduled execution is paused. Possible
        /// values include: 'Active', 'Inactive'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the schedule recurrence. Possible values include:
        /// 'Daily', 'Weekly', 'Monthly', 'Annually'
        /// </summary>
        [JsonProperty(PropertyName = "recurrence")]
        public string Recurrence { get; set; }

        /// <summary>
        /// Gets or sets has start and end date of the recurrence. The start
        /// date must be in future. If present, the end date must be greater
        /// than start date.
        /// </summary>
        [JsonProperty(PropertyName = "recurrencePeriod")]
        public ReportConfigRecurrencePeriod RecurrencePeriod { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Recurrence == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Recurrence");
            }
            if (RecurrencePeriod == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RecurrencePeriod");
            }
            if (RecurrencePeriod != null)
            {
                RecurrencePeriod.Validate();
            }
        }
    }
}
