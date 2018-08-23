// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.itemReference&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.itemReference&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "ItemReferenceObject", DefaultParameterSetName = @"microsoft.graph.itemReference")]
    [ODataType("microsoft.graph.itemReference")]
    public class New_ItemReferenceObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;driveId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.itemReference&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.itemReference", HelpMessage = @"The &quot;driveId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String driveId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;driveType&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.itemReference&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.itemReference", HelpMessage = @"The &quot;driveType&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String driveType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.itemReference&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.itemReference", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;path&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.itemReference&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.itemReference", HelpMessage = @"The &quot;path&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String path { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;shareId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.itemReference&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.itemReference", HelpMessage = @"The &quot;shareId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String shareId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sharepointIds&quot; property, of type &quot;microsoft.graph.sharepointIds&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.itemReference&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sharepointIds")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.itemReference", HelpMessage = @"The &quot;sharepointIds&quot; property, of type &quot;microsoft.graph.sharepointIds&quot;.")]
        public System.Object sharepointIds { get; set; }
    }
}