// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    internal partial class GatewayCustomDomainProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Thumbprint))
            {
                writer.WritePropertyName("thumbprint");
                writer.WriteStringValue(Thumbprint);
            }
            writer.WriteEndObject();
        }

        internal static GatewayCustomDomainProperties DeserializeGatewayCustomDomainProperties(JsonElement element)
        {
            Optional<string> thumbprint = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("thumbprint"))
                {
                    thumbprint = property.Value.GetString();
                    continue;
                }
            }
            return new GatewayCustomDomainProperties(thumbprint.Value);
        }
    }
}
