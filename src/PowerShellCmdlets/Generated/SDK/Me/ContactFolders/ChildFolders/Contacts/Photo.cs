// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves the &quot;photo&quot; object.</para>
    ///     <para type="description">GET ~/me/contactFolders/{contactFolderId}/childFolders/{childFolderId}/contacts/{contactId}/photo</para>
    ///     <para type="description">Retrieves the &quot;photo&quot; object (which is of type &quot;microsoft.graph.profilePhoto&quot;).</para>
    /// </summary>
    [Cmdlet("Get", "Me_ContactFolders_ChildFolders_Contacts_Photo", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.profilePhoto")]
    [ResourceReference]
    public class Get_Me_ContactFolders_ChildFolders_Contacts_Photo : GetCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.contact&quot; object in the &quot;contacts&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.contact&quot; object in the &quot;contacts&quot; collection.")]
        public System.String contactId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.contactFolder&quot; object in the &quot;childFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.contactFolder&quot; object in the &quot;childFolders&quot; collection.")]
        public System.String childFolderId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.contactFolder&quot; object in the &quot;contactFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.contactFolder&quot; object in the &quot;contactFolders&quot; collection.")]
        public System.String contactFolderId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;height&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.profilePhoto&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 height { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;width&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.profilePhoto&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 width { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/contactFolders/{contactFolderId}/childFolders/{childFolderId}/contacts/{contactId}/photo";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.profilePhoto&quot;.</para>
    ///     <para type="description">PATCH ~/me/contactFolders/{contactFolderId}/childFolders/{childFolderId}/contacts/{contactId}/photo</para>
    ///     <para type="description">Updates the &quot;photo&quot; object (which is of type &quot;microsoft.graph.profilePhoto&quot;).</para>
    /// </summary>
    [Cmdlet("Update", "Me_ContactFolders_ChildFolders_Contacts_Photo", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.profilePhoto")]
    [ODataType("microsoft.graph.profilePhoto")]
    public class Update_Me_ContactFolders_ChildFolders_Contacts_Photo : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.contact&quot; object in the &quot;contacts&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.contact&quot; object in the &quot;contacts&quot; collection.")]
        public System.String contactId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.contactFolder&quot; object in the &quot;childFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.contactFolder&quot; object in the &quot;childFolders&quot; collection.")]
        public System.String childFolderId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.contactFolder&quot; object in the &quot;contactFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.contactFolder&quot; object in the &quot;contactFolders&quot; collection.")]
        public System.String contactFolderId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;height&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.profilePhoto&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.profilePhoto", HelpMessage = @"The &quot;height&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;height&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 height { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;width&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.profilePhoto&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.profilePhoto", HelpMessage = @"The &quot;width&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;width&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 width { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/contactFolders/{contactFolderId}/childFolders/{childFolderId}/contacts/{contactId}/photo";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Retrieves a &quot;photo&quot; object&apos;s data stream.</para>
    ///     <para type="description">GET ~/me/contactFolders/{contactFolderId}/childFolders/{childFolderId}/contacts/{contactId}/photo/$value</para>
    ///     <para type="description">Retrieves the data stream from the &quot;photo&quot; object.</para>
    /// </summary>
    [Cmdlet("Get", "Me_ContactFolders_ChildFolders_Contacts_PhotoData")]
    [ODataType("microsoft.graph.profilePhoto")]
    public class Get_Me_ContactFolders_ChildFolders_Contacts_PhotoData : GetStreamCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.contact&quot; object in the &quot;contacts&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.contact&quot; object in the &quot;contacts&quot; collection.")]
        public System.String contactId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.contactFolder&quot; object in the &quot;childFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.contactFolder&quot; object in the &quot;childFolders&quot; collection.")]
        public System.String childFolderId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.contactFolder&quot; object in the &quot;contactFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.contactFolder&quot; object in the &quot;contactFolders&quot; collection.")]
        public System.String contactFolderId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;height&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.profilePhoto&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 height { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;width&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.profilePhoto&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 width { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/contactFolders/{contactFolderId}/childFolders/{childFolderId}/contacts/{contactId}/photo/$value";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Sets the data for the &quot;photo&quot; property.</para>
    ///     <para type="description">PUT ~/me/contactFolders/{contactFolderId}/childFolders/{childFolderId}/contacts/{contactId}/photo/$value</para>
    ///     <para type="description">Sets the data for the &quot;photo&quot; property.</para>
    /// </summary>
    [Cmdlet("New", "Me_ContactFolders_ChildFolders_Contacts_PhotoData", ConfirmImpact = ConfirmImpact.Low)]
    [ODataType("microsoft.graph.profilePhoto")]
    public class New_Me_ContactFolders_ChildFolders_Contacts_PhotoData : UpdateStreamCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.contact&quot; object in the &quot;contacts&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.contact&quot; object in the &quot;contacts&quot; collection.")]
        public System.String contactId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.contactFolder&quot; object in the &quot;childFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.contactFolder&quot; object in the &quot;childFolders&quot; collection.")]
        public System.String childFolderId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.contactFolder&quot; object in the &quot;contactFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.contactFolder&quot; object in the &quot;contactFolders&quot; collection.")]
        public System.String contactFolderId { get; set; }

        internal override System.String GetHttpMethod()
        {
            return "POST";
        }

        internal override System.String GetResourcePath()
        {
            return $"me/contactFolders/{contactFolderId}/childFolders/{childFolderId}/contacts/{contactId}/photo/$value";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Sets the data for the &quot;photo&quot; property.</para>
    ///     <para type="description">PUT ~/me/contactFolders/{contactFolderId}/childFolders/{childFolderId}/contacts/{contactId}/photo/$value</para>
    ///     <para type="description">Sets the data for the &quot;photo&quot; property.</para>
    /// </summary>
    [Cmdlet("Set", "Me_ContactFolders_ChildFolders_Contacts_PhotoData", ConfirmImpact = ConfirmImpact.Low)]
    [ODataType("microsoft.graph.profilePhoto")]
    public class Set_Me_ContactFolders_ChildFolders_Contacts_PhotoData : UpdateStreamCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.contact&quot; object in the &quot;contacts&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.contact&quot; object in the &quot;contacts&quot; collection.")]
        public System.String contactId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.contactFolder&quot; object in the &quot;childFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.contactFolder&quot; object in the &quot;childFolders&quot; collection.")]
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
            return $"me/contactFolders/{contactFolderId}/childFolders/{childFolderId}/contacts/{contactId}/photo/$value";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes the data stream from a &quot;photo&quot; object.</para>
    ///     <para type="description">DELETE ~/me/contactFolders/{contactFolderId}/childFolders/{childFolderId}/contacts/{contactId}/photo/$ref</para>
    ///     <para type="description">Removes a reference from a &quot;photo&quot; resource (which is of type &quot;microsoft.graph.profilePhoto&quot;).</para>
    /// </summary>
    [Cmdlet("Remove", "Me_ContactFolders_ChildFolders_Contacts_PhotoData", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.profilePhoto")]
    public class Remove_Me_ContactFolders_ChildFolders_Contacts_PhotoData : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.contact&quot; object in the &quot;contacts&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.contact&quot; object in the &quot;contacts&quot; collection.")]
        public System.String contactId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.contactFolder&quot; object in the &quot;childFolders&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.contactFolder&quot; object in the &quot;childFolders&quot; collection.")]
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
            return $"me/contactFolders/{contactFolderId}/childFolders/{childFolderId}/contacts/{contactId}/photo/$value";
        }
    }
}