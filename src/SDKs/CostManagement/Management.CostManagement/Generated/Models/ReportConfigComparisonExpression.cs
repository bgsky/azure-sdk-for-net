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
    /// The comparison expression to be used in the report.
    /// </summary>
    public partial class ReportConfigComparisonExpression
    {
        /// <summary>
        /// Initializes a new instance of the ReportConfigComparisonExpression
        /// class.
        /// </summary>
        public ReportConfigComparisonExpression()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ReportConfigComparisonExpression
        /// class.
        /// </summary>
        /// <param name="name">The name of the column to use in
        /// comaprison.</param>
        /// <param name="values">Array of values to use for comparison</param>
        public ReportConfigComparisonExpression(string name, IList<string> values)
        {
            Name = name;
            Values = values;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for ReportConfigComparisonExpression class.
        /// </summary>
        static ReportConfigComparisonExpression()
        {
            OperatorProperty = "In";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the column to use in comaprison.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets array of values to use for comparison
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IList<string> Values { get; set; }

        /// <summary>
        /// The operator to use for comparison.
        /// </summary>
        [JsonProperty(PropertyName = "operator")]
        public static string OperatorProperty { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Values == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Values");
            }
            if (Values != null)
            {
                if (Values.Count < 1)
                {
                    throw new ValidationException(ValidationRules.MinItems, "Values", 1);
                }
            }
        }
    }
}
