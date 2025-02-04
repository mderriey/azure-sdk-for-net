// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The properties for updating a timer trigger. </summary>
    public partial class TimerTriggerUpdateParameters
    {
        /// <summary> Initializes a new instance of TimerTriggerUpdateParameters. </summary>
        /// <param name="name"> The name of the trigger. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public TimerTriggerUpdateParameters(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        /// <summary> The CRON expression for the task schedule. </summary>
        public string Schedule { get; set; }
        /// <summary> The current status of trigger. </summary>
        public TriggerStatus? Status { get; set; }
        /// <summary> The name of the trigger. </summary>
        public string Name { get; }
    }
}
