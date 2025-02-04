// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MySql;

namespace Azure.ResourceManager.MySql.Models
{
    internal partial class AdvisorsResultList
    {
        internal static AdvisorsResultList DeserializeAdvisorsResultList(JsonElement element)
        {
            Optional<IReadOnlyList<AdvisorData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<AdvisorData> array = new List<AdvisorData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AdvisorData.DeserializeAdvisorData(item));
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
            return new AdvisorsResultList(Optional.ToList(value), nextLink.Value);
        }
    }
}
