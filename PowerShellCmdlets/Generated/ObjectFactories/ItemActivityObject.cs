// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.itemActivity&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.itemActivity&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "ItemActivityObject", DefaultParameterSetName = @"microsoft.graph.itemActivity")]
    [ODataType("microsoft.graph.itemActivity")]
    public class New_ItemActivityObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;access&quot; property, of type &quot;microsoft.graph.accessAction&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.itemActivity&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.accessAction")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.itemActivity", HelpMessage = @"The &quot;access&quot; property, of type &quot;microsoft.graph.accessAction&quot;.")]
        public System.Object access { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;activityDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.itemActivity&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.itemActivity", HelpMessage = @"The &quot;activityDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset activityDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;actor&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.itemActivity&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.itemActivity", HelpMessage = @"The &quot;actor&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object actor { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;driveItem&quot; property, of type &quot;microsoft.graph.driveItem&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.itemActivity&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.driveItem")]
        [Selectable]
        [Expandable]
        [Parameter(ParameterSetName = @"microsoft.graph.itemActivity", HelpMessage = @"The &quot;driveItem&quot; property, of type &quot;microsoft.graph.driveItem&quot;.")]
        public System.Object driveItem { get; set; }
    }
}