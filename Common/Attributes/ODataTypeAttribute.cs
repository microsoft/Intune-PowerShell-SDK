// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Indicates that the property was generated from an OData property of the given type.
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Property | AttributeTargets.Class,
        AllowMultiple = false,
        Inherited = true)]
    internal class ODataTypeAttribute : Attribute
    {
        /// <summary>
        /// The name of the OData type.
        /// </summary>
        internal string TypeFullName { get; }

        /// <summary>
        /// The names of all the subtypes of the given type.
        /// </summary>
        internal IEnumerable<string> SubTypeFullNames { get; }

        /// <summary>
        /// Creates a new <see cref="ODataTypeAttribute"/>.
        /// </summary>
        /// <param name="oDataTypeFullName">The name of the OData type.</param>
        /// <param name="oDataSubTypeFullNames">The names of all the subtypes of the given type.</param>
        internal ODataTypeAttribute(string oDataTypeFullName, params string[] oDataSubTypeFullNames)
        {
            this.TypeFullName = oDataTypeFullName ?? throw new ArgumentNullException(nameof(oDataTypeFullName));
            this.SubTypeFullNames = oDataSubTypeFullNames != null
                ? new HashSet<string>(oDataSubTypeFullNames) as IEnumerable<string>
                : Array.Empty<string>();
        }
    }
}
