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

    public partial class QueryColumn
    {
        /// <summary>
        /// Initializes a new instance of the QueryColumn class.
        /// </summary>
        public QueryColumn()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QueryColumn class.
        /// </summary>
        public QueryColumn(string name = default(string), string type = default(string))
        {
            Name = name;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}