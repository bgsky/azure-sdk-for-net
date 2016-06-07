// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Batch.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Contains information about an application in a Batch account.
    /// </summary>
    public partial class Application
    {
        /// <summary>
        /// Initializes a new instance of the Application class.
        /// </summary>
        public Application() { }

        /// <summary>
        /// Initializes a new instance of the Application class.
        /// </summary>
        public Application(string id = default(string), string displayName = default(string), IList<ApplicationPackage> packages = default(IList<ApplicationPackage>), bool? allowUpdates = default(bool?), string defaultVersion = default(string))
        {
            Id = id;
            DisplayName = displayName;
            Packages = packages;
            AllowUpdates = allowUpdates;
            DefaultVersion = defaultVersion;
        }

        /// <summary>
        /// Gets or sets a string that uniquely identifies the application
        /// within the account.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the display name for the application.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the list of packages under this application.
        /// </summary>
        [JsonProperty(PropertyName = "packages")]
        public IList<ApplicationPackage> Packages { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether packages within the
        /// application may be overwritten using the same version string.
        /// </summary>
        [JsonProperty(PropertyName = "allowUpdates")]
        public bool? AllowUpdates { get; set; }

        /// <summary>
        /// Gets or sets the package to use if a client requests the
        /// application but does not specify a version.
        /// </summary>
        [JsonProperty(PropertyName = "defaultVersion")]
        public string DefaultVersion { get; set; }

    }
}