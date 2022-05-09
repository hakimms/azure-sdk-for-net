// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The AfdDeploymentStatus. </summary>
    public readonly partial struct AfdDeploymentStatus : IEquatable<AfdDeploymentStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AfdDeploymentStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AfdDeploymentStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotStartedValue = "NotStarted";
        private const string InProgressValue = "InProgress";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";

        /// <summary> NotStarted. </summary>
        public static AfdDeploymentStatus NotStarted { get; } = new AfdDeploymentStatus(NotStartedValue);
        /// <summary> InProgress. </summary>
        public static AfdDeploymentStatus InProgress { get; } = new AfdDeploymentStatus(InProgressValue);
        /// <summary> Succeeded. </summary>
        public static AfdDeploymentStatus Succeeded { get; } = new AfdDeploymentStatus(SucceededValue);
        /// <summary> Failed. </summary>
        public static AfdDeploymentStatus Failed { get; } = new AfdDeploymentStatus(FailedValue);
        /// <summary> Determines if two <see cref="AfdDeploymentStatus"/> values are the same. </summary>
        public static bool operator ==(AfdDeploymentStatus left, AfdDeploymentStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AfdDeploymentStatus"/> values are not the same. </summary>
        public static bool operator !=(AfdDeploymentStatus left, AfdDeploymentStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AfdDeploymentStatus"/>. </summary>
        public static implicit operator AfdDeploymentStatus(string value) => new AfdDeploymentStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AfdDeploymentStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AfdDeploymentStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
