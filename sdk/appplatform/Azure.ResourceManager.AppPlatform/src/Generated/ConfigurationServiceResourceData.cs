// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.AppPlatform.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary> A class representing the ConfigurationServiceResource data model. </summary>
    public partial class ConfigurationServiceResourceData : ResourceData
    {
        /// <summary> Initializes a new instance of ConfigurationServiceResourceData. </summary>
        public ConfigurationServiceResourceData()
        {
        }

        /// <summary> Initializes a new instance of ConfigurationServiceResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Application Configuration Service properties payload. </param>
        internal ConfigurationServiceResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ConfigurationServiceProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> Application Configuration Service properties payload. </summary>
        public ConfigurationServiceProperties Properties { get; set; }
    }
}
