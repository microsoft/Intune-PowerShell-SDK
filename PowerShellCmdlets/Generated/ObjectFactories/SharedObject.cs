// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.shared&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.shared&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "SharedObject", DefaultParameterSetName = @"#microsoft.graph.shared")]
    [ODataType("microsoft.graph.shared")]
    public class New_SharedObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;owner&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.shared&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.shared", HelpMessage = @"The &quot;owner&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object owner { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;scope&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.shared&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.shared", HelpMessage = @"The &quot;scope&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String scope { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sharedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.shared&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.shared", HelpMessage = @"The &quot;sharedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object sharedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sharedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.shared&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.shared", HelpMessage = @"The &quot;sharedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset sharedDateTime { get; set; }
    }
}