// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK
{
    using System;

    /// <summary>
    /// Indicates that the given property is defined on the specified type.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    internal class DerivedTypeAttribute : Attribute
    {
        /// <summary>
        /// The name of the type that this property is from.
        /// </summary>
        internal string FullName { get; }

        /// <summary>
        /// Creates a new <see cref="DerivedTypeAttribute"/>.
        /// </summary>
        /// <param name="derivedTypeFullName">The name of the type that this property exists on.</param>
        internal DerivedTypeAttribute(string derivedTypeFullName)
        {
            if (string.IsNullOrWhiteSpace(derivedTypeFullName))
            {
                throw new ArgumentNullException(nameof(derivedTypeFullName));
            }

            this.FullName = derivedTypeFullName;
        }
    }
}
