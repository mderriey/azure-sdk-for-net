// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Migrate.Models;

namespace Azure.ResourceManager.Migrate
{
    internal class OperationStatusOperationSource : IOperationSource<OperationStatus>
    {
        OperationStatus IOperationSource<OperationStatus>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return OperationStatus.DeserializeOperationStatus(document.RootElement);
        }

        async ValueTask<OperationStatus> IOperationSource<OperationStatus>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return OperationStatus.DeserializeOperationStatus(document.RootElement);
        }
    }
}
