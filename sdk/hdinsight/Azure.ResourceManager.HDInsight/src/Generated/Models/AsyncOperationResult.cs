// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The azure async operation response. </summary>
    public partial class AsyncOperationResult
    {
        /// <summary> Initializes a new instance of AsyncOperationResult. </summary>
        internal AsyncOperationResult()
        {
        }

        /// <summary> Initializes a new instance of AsyncOperationResult. </summary>
        /// <param name="status"> The async operation state. </param>
        /// <param name="error"> The operation error information. </param>
        internal AsyncOperationResult(AsyncOperationState? status, Errors error)
        {
            Status = status;
            Error = error;
        }

        /// <summary> The async operation state. </summary>
        public AsyncOperationState? Status { get; }
        /// <summary> The operation error information. </summary>
        public Errors Error { get; }
    }
}
