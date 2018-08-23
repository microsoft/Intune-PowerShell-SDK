// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.mailFolder&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.mailFolder&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "MailFolderObject", DefaultParameterSetName = @"microsoft.graph.mailFolder")]
    [ODataType("microsoft.graph.mailFolder")]
    public class New_MailFolderObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mailFolder", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentFolderId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mailFolder", HelpMessage = @"The &quot;parentFolderId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String parentFolderId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;childFolderCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mailFolder", HelpMessage = @"The &quot;childFolderCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 childFolderCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;unreadItemCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mailFolder", HelpMessage = @"The &quot;unreadItemCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 unreadItemCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;totalItemCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mailFolder", HelpMessage = @"The &quot;totalItemCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 totalItemCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;messages&quot; property, of type &quot;microsoft.graph.message&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.message", "microsoft.graph.eventMessage")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.mailFolder", HelpMessage = @"The &quot;messages&quot; property, of type &quot;microsoft.graph.message&quot;.")]
        public System.Object[] messages { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;messageRules&quot; property, of type &quot;microsoft.graph.messageRule&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.messageRule")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.mailFolder", HelpMessage = @"The &quot;messageRules&quot; property, of type &quot;microsoft.graph.messageRule&quot;.")]
        public System.Object[] messageRules { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;childFolders&quot; property, of type &quot;microsoft.graph.mailFolder&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.mailFolder")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.mailFolder", HelpMessage = @"The &quot;childFolders&quot; property, of type &quot;microsoft.graph.mailFolder&quot;.")]
        public System.Object[] childFolders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.singleValueLegacyExtendedProperty")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.mailFolder", HelpMessage = @"The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.")]
        public System.Object[] singleValueExtendedProperties { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.multiValueLegacyExtendedProperty")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.mailFolder", HelpMessage = @"The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.")]
        public System.Object[] multiValueExtendedProperties { get; set; }
    }
}