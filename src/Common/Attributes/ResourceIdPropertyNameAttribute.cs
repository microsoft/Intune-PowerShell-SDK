// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK
{
    using System;

    /// <summary>
    /// Indicates that the given property is defined on the specified type.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    internal class ResourceIdPropertyNameAttribute : Attribute
    {
        public string PropertyName { get; }

        public ResourceIdPropertyNameAttribute(string propertyName)
        {
            if (propertyName == null)
            {
                throw new ArgumentNullException(nameof(propertyName));
            }
            if (string.IsNullOrWhiteSpace(propertyName))
            {
                throw new ArgumentException("ID property name cannot be empty or whitespace");
            }

            this.PropertyName = propertyName;
        }
    }
}
