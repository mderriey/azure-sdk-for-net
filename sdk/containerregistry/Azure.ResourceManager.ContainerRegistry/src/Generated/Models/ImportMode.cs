// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> When Force, any existing target tags will be overwritten. When NoForce, any existing target tags will fail the operation before any copying begins. </summary>
    public readonly partial struct ImportMode : IEquatable<ImportMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ImportMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ImportMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoForceValue = "NoForce";
        private const string ForceValue = "Force";

        /// <summary> NoForce. </summary>
        public static ImportMode NoForce { get; } = new ImportMode(NoForceValue);
        /// <summary> Force. </summary>
        public static ImportMode Force { get; } = new ImportMode(ForceValue);
        /// <summary> Determines if two <see cref="ImportMode"/> values are the same. </summary>
        public static bool operator ==(ImportMode left, ImportMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ImportMode"/> values are not the same. </summary>
        public static bool operator !=(ImportMode left, ImportMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ImportMode"/>. </summary>
        public static implicit operator ImportMode(string value) => new ImportMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ImportMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ImportMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
