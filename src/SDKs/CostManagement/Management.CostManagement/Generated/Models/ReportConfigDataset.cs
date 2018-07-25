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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The definition of data present in the report.
    /// </summary>
    public partial class ReportConfigDataset
    {
        /// <summary>
        /// Initializes a new instance of the ReportConfigDataset class.
        /// </summary>
        public ReportConfigDataset()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ReportConfigDataset class.
        /// </summary>
        /// <param name="granularity">The granularity of rows in the report.
        /// Possible values include: 'Daily'</param>
        /// <param name="configuration">Has configuration information for the
        /// data in the report. The configuration will be ignored if
        /// aggregation and grouping are provided.</param>
        /// <param name="aggregation">Dictionary of aggregation expression to
        /// use in the report. The key of each item in the dictionary is the
        /// alias for the aggregated column. Report can have upto 2 aggregation
        /// clauses.</param>
        /// <param name="grouping">Array of group by expression to use in the
        /// report. Report can have upto 2 group by clauses.</param>
        /// <param name="filter">Has filter expression to use in the
        /// report.</param>
        public ReportConfigDataset(string granularity = default(string), ReportConfigDatasetConfiguration configuration = default(ReportConfigDatasetConfiguration), IDictionary<string, ReportConfigAggregation> aggregation = default(IDictionary<string, ReportConfigAggregation>), IList<ReportConfigGrouping> grouping = default(IList<ReportConfigGrouping>), ReportConfigFilter filter = default(ReportConfigFilter))
        {
            Granularity = granularity;
            Configuration = configuration;
            Aggregation = aggregation;
            Grouping = grouping;
            Filter = filter;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the granularity of rows in the report. Possible values
        /// include: 'Daily'
        /// </summary>
        [JsonProperty(PropertyName = "granularity")]
        public string Granularity { get; set; }

        /// <summary>
        /// Gets or sets has configuration information for the data in the
        /// report. The configuration will be ignored if aggregation and
        /// grouping are provided.
        /// </summary>
        [JsonProperty(PropertyName = "configuration")]
        public ReportConfigDatasetConfiguration Configuration { get; set; }

        /// <summary>
        /// Gets or sets dictionary of aggregation expression to use in the
        /// report. The key of each item in the dictionary is the alias for the
        /// aggregated column. Report can have upto 2 aggregation clauses.
        /// </summary>
        [JsonProperty(PropertyName = "aggregation")]
        public IDictionary<string, ReportConfigAggregation> Aggregation { get; set; }

        /// <summary>
        /// Gets or sets array of group by expression to use in the report.
        /// Report can have upto 2 group by clauses.
        /// </summary>
        [JsonProperty(PropertyName = "grouping")]
        public IList<ReportConfigGrouping> Grouping { get; set; }

        /// <summary>
        /// Gets or sets has filter expression to use in the report.
        /// </summary>
        [JsonProperty(PropertyName = "filter")]
        public ReportConfigFilter Filter { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Aggregation != null)
            {
                foreach (var valueElement in Aggregation.Values)
                {
                    if (valueElement != null)
                    {
                        valueElement.Validate();
                    }
                }
            }
            if (Grouping != null)
            {
                if (Grouping.Count > 2)
                {
                    throw new ValidationException(ValidationRules.MaxItems, "Grouping", 2);
                }
                foreach (var element in Grouping)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Filter != null)
            {
                Filter.Validate();
            }
        }
    }
}
