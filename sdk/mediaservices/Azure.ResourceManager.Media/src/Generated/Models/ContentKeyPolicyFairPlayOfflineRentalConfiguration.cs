// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The ContentKeyPolicyFairPlayOfflineRentalConfiguration. </summary>
    public partial class ContentKeyPolicyFairPlayOfflineRentalConfiguration
    {
        /// <summary> Initializes a new instance of ContentKeyPolicyFairPlayOfflineRentalConfiguration. </summary>
        /// <param name="playbackDurationSeconds"> Playback duration. </param>
        /// <param name="storageDurationSeconds"> Storage duration. </param>
        public ContentKeyPolicyFairPlayOfflineRentalConfiguration(long playbackDurationSeconds, long storageDurationSeconds)
        {
            PlaybackDurationSeconds = playbackDurationSeconds;
            StorageDurationSeconds = storageDurationSeconds;
        }

        /// <summary> Playback duration. </summary>
        public long PlaybackDurationSeconds { get; set; }
        /// <summary> Storage duration. </summary>
        public long StorageDurationSeconds { get; set; }
    }
}
