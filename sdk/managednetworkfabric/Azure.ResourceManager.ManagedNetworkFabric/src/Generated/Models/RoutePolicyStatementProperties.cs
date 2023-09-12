// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Route Policy Statement properties. </summary>
    public partial class RoutePolicyStatementProperties : AnnotationResourceProperties
    {
        /// <summary> Initializes a new instance of RoutePolicyStatementProperties. </summary>
        /// <param name="sequenceNumber"> Sequence to insert to/delete from existing route. </param>
        /// <param name="condition"> Route policy condition properties. </param>
        /// <param name="action"> Route policy action properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="condition"/> or <paramref name="action"/> is null. </exception>
        public RoutePolicyStatementProperties(long sequenceNumber, StatementConditionProperties condition, StatementActionProperties action)
        {
            Argument.AssertNotNull(condition, nameof(condition));
            Argument.AssertNotNull(action, nameof(action));

            SequenceNumber = sequenceNumber;
            Condition = condition;
            Action = action;
        }

        /// <summary> Initializes a new instance of RoutePolicyStatementProperties. </summary>
        /// <param name="annotation"> Switch configuration description. </param>
        /// <param name="sequenceNumber"> Sequence to insert to/delete from existing route. </param>
        /// <param name="condition"> Route policy condition properties. </param>
        /// <param name="action"> Route policy action properties. </param>
        internal RoutePolicyStatementProperties(string annotation, long sequenceNumber, StatementConditionProperties condition, StatementActionProperties action) : base(annotation)
        {
            SequenceNumber = sequenceNumber;
            Condition = condition;
            Action = action;
        }

        /// <summary> Sequence to insert to/delete from existing route. </summary>
        public long SequenceNumber { get; set; }
        /// <summary> Route policy condition properties. </summary>
        public StatementConditionProperties Condition { get; set; }
        /// <summary> Route policy action properties. </summary>
        public StatementActionProperties Action { get; set; }
    }
}
