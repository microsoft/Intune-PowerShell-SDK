// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.contactFolder&quot; objects.</para>
    ///     <para type="description">GET ~/me/contactFolders/{contactFolderId}/childFolders</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.contactFolder&quot; objects in the &quot;childFolders&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_ContactFolders_ChildFolders", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.contactFolder")]
    [ResourceIdPropertyName("childFolderId")]
    [ResourceReference]
    public class Get_Me_ContactFolders_ChildFolders : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.contactFolder&quot; object in the &quot;contactFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.contactFolder&quot; object in the &quot;contactFolders&quot; collection.")]
        public System.String contactFolderId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.contactFolder&quot; object in the &quot;childFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.contactFolder&quot; object in the &quot;childFolders&quot; collection.")]
        public System.String childFolderId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentFolderId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contactFolder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String parentFolderId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contactFolder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contacts&quot; property, of type &quot;microsoft.graph.contact&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contactFolder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.contact")]
        [Selectable]
        [Expandable]
        public System.Object[] contacts { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;childFolders&quot; property, of type &quot;microsoft.graph.contactFolder&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contactFolder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.contactFolder")]
        [Selectable]
        [Expandable]
        public System.Object[] childFolders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contactFolder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.singleValueLegacyExtendedProperty")]
        [Selectable]
        [Expandable]
        public System.Object[] singleValueExtendedProperties { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contactFolder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.multiValueLegacyExtendedProperty")]
        [Selectable]
        [Expandable]
        public System.Object[] multiValueExtendedProperties { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/contactFolders/{contactFolderId}/childFolders/{childFolderId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.contactFolder&quot; object.</para>
    ///     <para type="description">POST ~/me/contactFolders/{contactFolderId}/childFolders</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.contactFolder&quot; object to the &quot;childFolders&quot; collection.</para>
    /// </summary>
    [Cmdlet("New", "Me_ContactFolders_ChildFolders", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.contactFolder")]
    [ODataType("microsoft.graph.contactFolder")]
    [ResourceReference]
    public class New_Me_ContactFolders_ChildFolders : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.contactFolder&quot; object in the &quot;contactFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.contactFolder&quot; object in the &quot;contactFolders&quot; collection.")]
        public System.String contactFolderId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentFolderId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contactFolder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contactFolder", HelpMessage = @"The &quot;parentFolderId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;parentFolderId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String parentFolderId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contactFolder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contactFolder", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contacts&quot; property, of type &quot;microsoft.graph.contact&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contactFolder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.contact")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.contactFolder", HelpMessage = @"The &quot;contacts&quot; property, of type &quot;microsoft.graph.contact&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;contacts&quot; property, of type &quot;microsoft.graph.contact&quot;.")]
        public System.Object[] contacts { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;childFolders&quot; property, of type &quot;microsoft.graph.contactFolder&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contactFolder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.contactFolder")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.contactFolder", HelpMessage = @"The &quot;childFolders&quot; property, of type &quot;microsoft.graph.contactFolder&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;childFolders&quot; property, of type &quot;microsoft.graph.contactFolder&quot;.")]
        public System.Object[] childFolders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contactFolder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.singleValueLegacyExtendedProperty")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.contactFolder", HelpMessage = @"The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.")]
        public System.Object[] singleValueExtendedProperties { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contactFolder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.multiValueLegacyExtendedProperty")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.contactFolder", HelpMessage = @"The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.")]
        public System.Object[] multiValueExtendedProperties { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/contactFolders/{contactFolderId}/childFolders";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.contactFolder&quot;.</para>
    ///     <para type="description">PATCH ~/me/contactFolders/{contactFolderId}/childFolders</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.contactFolder&quot; object in the &quot;childFolders&quot; collection.</para>
    /// </summary>
    [Cmdlet("Update", "Me_ContactFolders_ChildFolders", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.contactFolder")]
    [ODataType("microsoft.graph.contactFolder")]
    [ResourceIdPropertyName("childFolderId")]
    public class Update_Me_ContactFolders_ChildFolders : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.contactFolder&quot; object in the &quot;childFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.contactFolder&quot; object in the &quot;childFolders&quot; collection.")]
        public System.String childFolderId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.contactFolder&quot; object in the &quot;contactFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.contactFolder&quot; object in the &quot;contactFolders&quot; collection.")]
        public System.String contactFolderId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;parentFolderId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contactFolder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contactFolder", HelpMessage = @"The &quot;parentFolderId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;parentFolderId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String parentFolderId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contactFolder&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.contactFolder", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contacts&quot; property, of type &quot;microsoft.graph.contact&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contactFolder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.contact")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.contactFolder", HelpMessage = @"The &quot;contacts&quot; property, of type &quot;microsoft.graph.contact&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;contacts&quot; property, of type &quot;microsoft.graph.contact&quot;.")]
        public System.Object[] contacts { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;childFolders&quot; property, of type &quot;microsoft.graph.contactFolder&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contactFolder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.contactFolder")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.contactFolder", HelpMessage = @"The &quot;childFolders&quot; property, of type &quot;microsoft.graph.contactFolder&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;childFolders&quot; property, of type &quot;microsoft.graph.contactFolder&quot;.")]
        public System.Object[] childFolders { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contactFolder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.singleValueLegacyExtendedProperty")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.contactFolder", HelpMessage = @"The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;singleValueExtendedProperties&quot; property, of type &quot;microsoft.graph.singleValueLegacyExtendedProperty&quot;.")]
        public System.Object[] singleValueExtendedProperties { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.contactFolder&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.multiValueLegacyExtendedProperty")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.contactFolder", HelpMessage = @"The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;multiValueExtendedProperties&quot; property, of type &quot;microsoft.graph.multiValueLegacyExtendedProperty&quot;.")]
        public System.Object[] multiValueExtendedProperties { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/contactFolders/{contactFolderId}/childFolders/{childFolderId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.contactFolder&quot; object.</para>
    ///     <para type="description">DELETE ~/me/contactFolders/{contactFolderId}/childFolders/childFolderId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.contactFolder&quot; object from the &quot;childFolders&quot; collection.</para>
    /// </summary>
    [Cmdlet("Remove", "Me_ContactFolders_ChildFolders", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.contactFolder")]
    [ResourceIdPropertyName("childFolderId")]
    public class Remove_Me_ContactFolders_ChildFolders : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.contactFolder&quot; object in the &quot;childFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.contactFolder&quot; object in the &quot;childFolders&quot; collection.")]
        public System.String childFolderId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.contactFolder&quot; object in the &quot;contactFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.contactFolder&quot; object in the &quot;contactFolders&quot; collection.")]
        public System.String contactFolderId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/contactFolders/{contactFolderId}/childFolders/{childFolderId}";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/me/contactFolders/{contactFolderId}/childFolders/delta</para>
    ///     <para type="description">The function &quot;microsoft.graph.delta&quot;, which exists on the type &quot;microsoft.graph.contactFolder&quot;.</para>
    ///     <para type="description">This function returns a collection of &quot;microsoft.graph.contactFolder&quot; objects.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_ContactFolders_ChildFolders_Delta", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.contactFolder")]
    public class Invoke_Me_ContactFolders_ChildFolders_Delta : FunctionReturningCollectionCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.contactFolder&quot; object in the &quot;contactFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.contactFolder&quot; object in the &quot;contactFolders&quot; collection.")]
        public System.String contactFolderId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/contactFolders/{contactFolderId}/childFolders/delta({this.GetFunctionUrlSegment()})";
        }
    }
}