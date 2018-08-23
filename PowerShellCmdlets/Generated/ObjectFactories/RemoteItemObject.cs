// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.remoteItem&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.remoteItem&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "RemoteItemObject", DefaultParameterSetName = @"microsoft.graph.remoteItem")]
    [ODataType("microsoft.graph.remoteItem")]
    public class New_RemoteItemObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.remoteItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.remoteItem", HelpMessage = @"The &quot;createdBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object createdBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.remoteItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.remoteItem", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset createdDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;file&quot; property, of type &quot;microsoft.graph.file&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.remoteItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.file")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.remoteItem", HelpMessage = @"The &quot;file&quot; property, of type &quot;microsoft.graph.file&quot;.")]
        public System.Object file { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fileSystemInfo&quot; property, of type &quot;microsoft.graph.fileSystemInfo&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.remoteItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.fileSystemInfo")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.remoteItem", HelpMessage = @"The &quot;fileSystemInfo&quot; property, of type &quot;microsoft.graph.fileSystemInfo&quot;.")]
        public System.Object fileSystemInfo { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;folder&quot; property, of type &quot;microsoft.graph.folder&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.remoteItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.folder")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.remoteItem", HelpMessage = @"The &quot;folder&quot; property, of type &quot;microsoft.graph.folder&quot;.")]
        public System.Object folder { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.remoteItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.remoteItem", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object lastModifiedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.remoteItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.remoteItem", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;name&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.remoteItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.remoteItem", HelpMessage = @"The &quot;name&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String name { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;package&quot; property, of type &quot;microsoft.graph.package&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.remoteItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.package")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.remoteItem", HelpMessage = @"The &quot;package&quot; property, of type &quot;microsoft.graph.package&quot;.")]
        public System.Object package { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentReference&quot; property, of type &quot;microsoft.graph.itemReference&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.remoteItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.itemReference")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.remoteItem", HelpMessage = @"The &quot;parentReference&quot; property, of type &quot;microsoft.graph.itemReference&quot;.")]
        public System.Object parentReference { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;shared&quot; property, of type &quot;microsoft.graph.shared&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.remoteItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.shared")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.remoteItem", HelpMessage = @"The &quot;shared&quot; property, of type &quot;microsoft.graph.shared&quot;.")]
        public System.Object shared { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sharepointIds&quot; property, of type &quot;microsoft.graph.sharepointIds&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.remoteItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.sharepointIds")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.remoteItem", HelpMessage = @"The &quot;sharepointIds&quot; property, of type &quot;microsoft.graph.sharepointIds&quot;.")]
        public System.Object sharepointIds { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;size&quot; property, of type &quot;Edm.Int64&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.remoteItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int64")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.remoteItem", HelpMessage = @"The &quot;size&quot; property, of type &quot;Edm.Int64&quot;.")]
        public System.Int64 size { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;specialFolder&quot; property, of type &quot;microsoft.graph.specialFolder&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.remoteItem&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.specialFolder")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.remoteItem", HelpMessage = @"The &quot;specialFolder&quot; property, of type &quot;microsoft.graph.specialFolder&quot;.")]
        public System.Object specialFolder { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;webDavUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.remoteItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.remoteItem", HelpMessage = @"The &quot;webDavUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String webDavUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.remoteItem&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.remoteItem", HelpMessage = @"The &quot;webUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String webUrl { get; set; }
    }
}