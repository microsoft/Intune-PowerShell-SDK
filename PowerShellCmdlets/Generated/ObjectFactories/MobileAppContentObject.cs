// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.mobileAppContent&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.mobileAppContent&quot; (or one of its derived types).</para>
    ///     <para type="description">Contains content properties for a specific app version. Each mobileAppContent can have multiple mobileAppContentFile.</para>
    /// </summary>
    [Cmdlet("New", "MobileAppContentObject", DefaultParameterSetName = @"microsoft.graph.mobileAppContent")]
    [ODataType("microsoft.graph.mobileAppContent")]
    public class New_MobileAppContentObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;files&quot; property, of type &quot;microsoft.graph.mobileAppContentFile&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppContent&quot; type.</para>
        ///     <para type="description">The list of files for this app content version.</para>
        /// </summary>
        [ODataType("microsoft.graph.mobileAppContentFile")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.mobileAppContent", HelpMessage = @"The &quot;files&quot; property, of type &quot;microsoft.graph.mobileAppContentFile&quot;.")]
        public System.Object[] files { get; set; }
    }
}