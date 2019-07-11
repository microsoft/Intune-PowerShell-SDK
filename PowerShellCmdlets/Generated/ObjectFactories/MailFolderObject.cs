// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.mailFolder&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.mailFolder&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "MailFolderObject", DefaultParameterSetName = @"microsoft.graph.mailFolder")]
    [ODataType("microsoft.graph.mailFolder")]
    public class New_MailFolderObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [ParameterSetSelector(@"microsoft.graph.mailFolder")]
        [Parameter(ParameterSetName = @"microsoft.graph.mailFolder", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.mailFolder&quot; type.")]
        public System.Management.Automation.SwitchParameter mailFolder { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mailFolder", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.mailSearchFolder", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentFolderId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mailFolder", HelpMessage = @"The &quot;parentFolderId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.mailSearchFolder", HelpMessage = @"The &quot;parentFolderId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String parentFolderId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;childFolderCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mailFolder", HelpMessage = @"The &quot;childFolderCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.mailSearchFolder", HelpMessage = @"The &quot;childFolderCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 childFolderCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;unreadItemCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mailFolder", HelpMessage = @"The &quot;unreadItemCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.mailSearchFolder", HelpMessage = @"The &quot;unreadItemCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 unreadItemCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;totalItemCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mailFolder", HelpMessage = @"The &quot;totalItemCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.mailSearchFolder", HelpMessage = @"The &quot;totalItemCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 totalItemCount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;messages&quot; property, of type &quot;microsoft.graph.message&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.message", "microsoft.graph.eventMessage")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.mailFolder", HelpMessage = @"The &quot;messages&quot; property, of type &quot;microsoft.graph.message&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.mailSearchFolder", HelpMessage = @"The &quot;messages&quot; property, of type &quot;microsoft.graph.message&quot;.")]
        public System.Object[] messages { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;messageRules&quot; property, of type &quot;microsoft.graph.messageRule&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.messageRule")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.mailFolder", HelpMessage = @"The &quot;messageRules&quot; property, of type &quot;microsoft.graph.messageRule&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.mailSearchFolder", HelpMessage = @"The &quot;messageRules&quot; property, of type &quot;microsoft.graph.messageRule&quot;.")]
        public System.Object[] messageRules { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;childFolders&quot; property, of type &quot;microsoft.graph.mailFolder&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.mailFolder", "microsoft.graph.mailSearchFolder")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.mailFolder", HelpMessage = @"The &quot;childFolders&quot; property, of type &quot;microsoft.graph.mailFolder&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.mailSearchFolder", HelpMessage = @"The &quot;childFolders&quot; property, of type &quot;microsoft.graph.mailFolder&quot;.")]
        public System.Object[] childFolders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.singleValueLegacyExtendedProperty")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.mailFolder", HelpMessage = @"The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.mailSearchFolder", HelpMessage = @"The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.")]
        public System.Object[] singleValueExtendedProperties { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailFolder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.multiValueLegacyExtendedProperty")]
        [Selectable]
        [Expandable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.mailFolder", HelpMessage = @"The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.")]
        [Parameter(ParameterSetName = @"microsoft.graph.mailSearchFolder", HelpMessage = @"The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.")]
        public System.Object[] multiValueExtendedProperties { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.mailSearchFolder&quot; type.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [ParameterSetSelector(@"microsoft.graph.mailSearchFolder")]
        [Parameter(ParameterSetName = @"microsoft.graph.mailSearchFolder", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.mailSearchFolder&quot; type.")]
        public System.Management.Automation.SwitchParameter mailSearchFolder { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isSupported&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailSearchFolder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mailSearchFolder", HelpMessage = @"The &quot;isSupported&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean isSupported { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;includeNestedFolders&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailSearchFolder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mailSearchFolder", HelpMessage = @"The &quot;includeNestedFolders&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean includeNestedFolders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sourceFolderIds&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailSearchFolder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.mailSearchFolder", HelpMessage = @"The &quot;sourceFolderIds&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String[] sourceFolderIds { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;filterQuery&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mailSearchFolder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.mailSearchFolder", HelpMessage = @"The &quot;filterQuery&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String filterQuery { get; set; }
    }
}