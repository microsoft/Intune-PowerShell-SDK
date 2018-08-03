// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.permission&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.permission&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "PermissionObject", DefaultParameterSetName = @"#microsoft.graph.permission")]
    [ODataType("microsoft.graph.permission")]
    public class New_PermissionObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;grantedTo&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.permission&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.permission", HelpMessage = @"The &quot;grantedTo&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object GrantedTo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;inheritedFrom&quot; property, of type &quot;microsoft.graph.itemReference&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.permission&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.itemReference")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.permission", HelpMessage = @"The &quot;inheritedFrom&quot; property, of type &quot;microsoft.graph.itemReference&quot;.")]
        public System.Object InheritedFrom { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;invitation&quot; property, of type &quot;microsoft.graph.sharingInvitation&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.permission&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sharingInvitation")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.permission", HelpMessage = @"The &quot;invitation&quot; property, of type &quot;microsoft.graph.sharingInvitation&quot;.")]
        public System.Object Invitation { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;link&quot; property, of type &quot;microsoft.graph.sharingLink&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.permission&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sharingLink")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.permission", HelpMessage = @"The &quot;link&quot; property, of type &quot;microsoft.graph.sharingLink&quot;.")]
        public System.Object Link { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;roles&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.permission&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.permission", HelpMessage = @"The &quot;roles&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] Roles { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;shareId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.permission&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.permission", HelpMessage = @"The &quot;shareId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String ShareId { get; set; }
    }
}