// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.accessAction&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.accessAction&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "AccessActionObject", DefaultParameterSetName = @"microsoft.graph.accessAction")]
    [ODataType("microsoft.graph.accessAction")]
    public class New_AccessActionObject : ObjectFactoryCmdletBase
    {
    }
}