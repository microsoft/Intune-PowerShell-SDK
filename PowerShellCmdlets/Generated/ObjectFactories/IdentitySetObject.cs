// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.identitySet&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.identitySet&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "IdentitySetObject", DefaultParameterSetName = @"microsoft.graph.identitySet")]
    [ODataType("microsoft.graph.identitySet")]
    public class New_IdentitySetObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;application&quot; property, of type &quot;microsoft.graph.identity&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.identitySet&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identity")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.identitySet", HelpMessage = @"The &quot;application&quot; property, of type &quot;microsoft.graph.identity&quot;.")]
        public System.Object application { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;device&quot; property, of type &quot;microsoft.graph.identity&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.identitySet&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identity")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.identitySet", HelpMessage = @"The &quot;device&quot; property, of type &quot;microsoft.graph.identity&quot;.")]
        public System.Object device { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;user&quot; property, of type &quot;microsoft.graph.identity&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.identitySet&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identity")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.identitySet", HelpMessage = @"The &quot;user&quot; property, of type &quot;microsoft.graph.identity&quot;.")]
        public System.Object user { get; set; }
    }
}