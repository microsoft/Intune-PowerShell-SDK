// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.onenote&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.onenote&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "OnenoteObject", DefaultParameterSetName = @"microsoft.graph.onenote")]
    [ODataType("microsoft.graph.onenote")]
    public class New_OnenoteObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;notebooks&quot; property, of type &quot;microsoft.graph.notebook&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenote&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.notebook")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.onenote", HelpMessage = @"The &quot;notebooks&quot; property, of type &quot;microsoft.graph.notebook&quot;.")]
        public System.Object[] notebooks { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sections&quot; property, of type &quot;microsoft.graph.onenoteSection&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenote&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenoteSection")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.onenote", HelpMessage = @"The &quot;sections&quot; property, of type &quot;microsoft.graph.onenoteSection&quot;.")]
        public System.Object[] sections { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sectionGroups&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenote&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sectionGroup")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.onenote", HelpMessage = @"The &quot;sectionGroups&quot; property, of type &quot;microsoft.graph.sectionGroup&quot;.")]
        public System.Object[] sectionGroups { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pages&quot; property, of type &quot;microsoft.graph.onenotePage&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenote&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenotePage")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.onenote", HelpMessage = @"The &quot;pages&quot; property, of type &quot;microsoft.graph.onenotePage&quot;.")]
        public System.Object[] pages { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;resources&quot; property, of type &quot;microsoft.graph.onenoteResource&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenote&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenoteResource")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.onenote", HelpMessage = @"The &quot;resources&quot; property, of type &quot;microsoft.graph.onenoteResource&quot;.")]
        public System.Object[] resources { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;operations&quot; property, of type &quot;microsoft.graph.onenoteOperation&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenote&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.onenoteOperation")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.onenote", HelpMessage = @"The &quot;operations&quot; property, of type &quot;microsoft.graph.onenoteOperation&quot;.")]
        public System.Object[] operations { get; set; }
    }
}