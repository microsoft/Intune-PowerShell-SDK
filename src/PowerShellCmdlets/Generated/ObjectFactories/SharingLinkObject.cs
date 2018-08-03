// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.sharingLink&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.sharingLink&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "SharingLinkObject", DefaultParameterSetName = @"#microsoft.graph.sharingLink")]
    [ODataType("microsoft.graph.sharingLink")]
    public class New_SharingLinkObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;application&quot; property, of type &quot;microsoft.graph.identity&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sharingLink&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identity")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.sharingLink", HelpMessage = @"The &quot;application&quot; property, of type &quot;microsoft.graph.identity&quot;.")]
        public System.Object Application { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;scope&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sharingLink&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.sharingLink", HelpMessage = @"The &quot;scope&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Scope { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;type&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sharingLink&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.sharingLink", HelpMessage = @"The &quot;type&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Type { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sharingLink&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.sharingLink", HelpMessage = @"The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String WebUrl { get; set; }
    }
}