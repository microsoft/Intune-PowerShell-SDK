// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK
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
        internal string FullName { get; }

        /// <summary>
        /// Creates a new <see cref="ODataTypeAttribute"/>.
        /// </summary>
        /// <param name="oDataTypeFullName">The name of the OData type.</param>
        internal ODataTypeAttribute(string oDataTypeFullName)
        {
            this.FullName = oDataTypeFullName ?? throw new ArgumentNullException(nameof(oDataTypeFullName));
        }
    }
}
