// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.outlookUser&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.outlookUser&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "OutlookUserObject", DefaultParameterSetName = @"#microsoft.graph.outlookUser")]
    [ODataType("microsoft.graph.outlookUser")]
    public class New_OutlookUserObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;masterCategories&quot; property, of type &quot;microsoft.graph.outlookCategory&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.outlookUser&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.outlookCategory")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.outlookUser", HelpMessage = @"The &quot;masterCategories&quot; property, of type &quot;microsoft.graph.outlookCategory&quot;.")]
        public System.Object[] masterCategories { get; set; }
    }
}