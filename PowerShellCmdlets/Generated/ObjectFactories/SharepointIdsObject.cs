// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.sharepointIds&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.sharepointIds&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "SharepointIdsObject", DefaultParameterSetName = @"microsoft.graph.sharepointIds")]
    [ODataType("microsoft.graph.sharepointIds")]
    public class New_SharepointIdsObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;listId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sharepointIds&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.sharepointIds", HelpMessage = @"The &quot;listId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String listId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;listItemId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sharepointIds&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.sharepointIds", HelpMessage = @"The &quot;listItemId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String listItemId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;listItemUniqueId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sharepointIds&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.sharepointIds", HelpMessage = @"The &quot;listItemUniqueId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String listItemUniqueId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;siteId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sharepointIds&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.sharepointIds", HelpMessage = @"The &quot;siteId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String siteId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;siteUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sharepointIds&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.sharepointIds", HelpMessage = @"The &quot;siteUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String siteUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;webId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sharepointIds&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.sharepointIds", HelpMessage = @"The &quot;webId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String webId { get; set; }
    }
}