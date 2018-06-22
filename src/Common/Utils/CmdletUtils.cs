// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Management.Automation;
    using System.Reflection;

    internal static class CmdletUtils
    {
        internal static string GetCmdletNoun(this Type cmdletType)
        {
            if (cmdletType == null)
            {
                throw new ArgumentNullException(nameof(cmdletType));
            }

            return cmdletType.GetCustomAttribute<CmdletAttribute>()?.NounName;
        }

        internal static string GetCmdletNoun(this Cmdlet cmdlet)
        {
            if (cmdlet == null)
            {
                throw new ArgumentNullException(nameof(cmdlet));
            }

            return cmdlet.GetType().GetCmdletNoun();
        }

        /// <summary>
        /// Gets the properties that are bound (set by the user) in the current invocation of this cmdlet.
        /// </summary>
        /// <param name="cmdlet">The cmdlet to get the properties from</param>
        /// <param name="includeInherited">Whether or not to include inherited properties</param>
        /// <param name="filter">The filter for the properties to include in the result (if it evaluates to true, the property is included)</param>
        /// <returns>The properties that are bound in the current invocation of this cmdlet.</returns>
        internal static IEnumerable<PropertyInfo> GetBoundProperties(this PSCmdlet cmdlet, bool includeInherited = true, Func<PropertyInfo, bool> filter = null)
        {
            // Get the cmdlet's properties
            IEnumerable<PropertyInfo> cmdletProperties = cmdlet.GetProperties(includeInherited, filter);

            // Get only the properties that were set from PowerShell
            IEnumerable<string> boundParameterNames = cmdlet.MyInvocation.BoundParameters.Keys;
            IEnumerable<PropertyInfo> boundProperties = cmdletProperties.Where(prop => boundParameterNames.Contains(prop.Name));

            return boundProperties;
        }

        /// <summary>
        /// Gets all the properties declared on this class.
        /// </summary>
        /// <param name="cmdlet">The cmdlet to get the properties from</param>
        /// <param name="includeInherited">Whether or not to include inherited properties (defaults to true)</param>
        /// <param name="filter">The filter for the properties to include in the result (if it evaluates to true, the property is included)</param>
        /// <returns>The properties that are defined on this cmdlet.</returns>
        internal static IEnumerable<PropertyInfo> GetProperties(this PSCmdlet cmdlet, bool includeInherited, Func<PropertyInfo, bool> filter = null)
        {
            // Create the binding flags
            BindingFlags bindingFlags =
                BindingFlags.Instance | // ignore static/const properties
                BindingFlags.Public; // only include public properties
            if (!includeInherited)
            {
                bindingFlags |= BindingFlags.DeclaredOnly; // ignore inherited properties
            }

            // Get the properties on this cmdlet
            IEnumerable<PropertyInfo> result = cmdlet.GetType().GetProperties(bindingFlags);

            // Apply filter if necessary
            if (filter != null)
            {
                result = result.Where(filter);
            }

            return result;
        }
    }
}
