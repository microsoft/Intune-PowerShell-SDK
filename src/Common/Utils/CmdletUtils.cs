// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK
{
    using System;
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
    }
}
