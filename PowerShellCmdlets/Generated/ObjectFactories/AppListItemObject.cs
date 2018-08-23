// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.appListItem&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.appListItem&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "AppListItemObject", DefaultParameterSetName = @"microsoft.graph.appListItem")]
    [ODataType("microsoft.graph.appListItem")]
    public class New_AppListItemObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.appListItem&quot; type.</para>
        ///     <para type="description">The application name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.appListItem", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;publisher&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.appListItem&quot; type.</para>
        ///     <para type="description">The publisher of the application</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.appListItem", HelpMessage = @"The &quot;publisher&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String publisher { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appStoreUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.appListItem&quot; type.</para>
        ///     <para type="description">The Store URL of the application</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.appListItem", HelpMessage = @"The &quot;appStoreUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String appStoreUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.appListItem&quot; type.</para>
        ///     <para type="description">The application or bundle identifier of the application</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.appListItem", HelpMessage = @"The &quot;appId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String appId { get; set; }
    }
}