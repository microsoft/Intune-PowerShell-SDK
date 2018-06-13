// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK
{
    using System;

    /// <summary>
    /// Indicates that the switch parameter is used to select a particular parameter set.
    /// This attribute should only be included on <see cref="System.Management.Automation.SwitchParameter"/> properties.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    internal class ParameterSetSelectorAttribute : Attribute
    {
        /// <summary>
        /// The name of the parameter set that this <see cref="System.Management.Automation.SwitchParameter"/> selects.
        /// </summary>
        internal string ParameterSetName { get; }

        /// <summary>
        /// Creates a new <see cref="ParameterSetSelectorAttribute"/>.
        /// </summary>
        /// <param name="parameterSetName">The name of the parameter set that the switch parameter would select.</param>
        internal ParameterSetSelectorAttribute(string parameterSetName)
        {
            if (string.IsNullOrWhiteSpace(parameterSetName))
            {
                throw new ArgumentException($"{nameof(parameterSetName)} cannot be null or whitespace", nameof(parameterSetName));
            }

            this.ParameterSetName = parameterSetName;
        }
    }
}
