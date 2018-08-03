// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK
{
    using System;
    using Humanizer;

    internal static class StringUtils
    {
        internal static string ToPascalCase(this string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.Pascalize();
        }

        internal static string ToCamelCase(this string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.Camelize();
        }
    }
}
