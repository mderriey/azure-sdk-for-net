// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    internal partial class SupportedSkusResult
    {
        internal static SupportedSkusResult DeserializeSupportedSkusResult(JsonElement element)
        {
            IReadOnlyList<SupportedSku> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<SupportedSku> array = new List<SupportedSku>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SupportedSku.DeserializeSupportedSku(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new SupportedSkusResult(value, nextLink.Value);
        }
    }
}
