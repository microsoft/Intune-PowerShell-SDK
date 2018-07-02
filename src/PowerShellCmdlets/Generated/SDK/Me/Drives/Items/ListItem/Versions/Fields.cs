// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves the &quot;fields&quot; object.</para>
    ///     <para type="description">GET ~/me/drives/{driveId}/items/{itemId}/listItem/versions/{versionId}/fields</para>
    ///     <para type="description">Retrieves the &quot;fields&quot; object (which is of type &quot;microsoft.graph.fieldValueSet&quot;).</para>
    /// </summary>
    [Cmdlet("Get", "Me_Drives_Items_ListItem_Versions_Fields", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.fieldValueSet")]
    [ResourceReference]
    public class Get_Me_Drives_Items_ListItem_Versions_Fields : GetCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.listItemVersion&quot; object in the &quot;versions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.listItemVersion&quot; object in the &quot;versions&quot; collection.")]
        public System.String versionId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.")]
        public System.String itemId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/items/{itemId}/listItem/versions/{versionId}/fields";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.fieldValueSet&quot; object.</para>
    ///     <para type="description">POST ~/me/drives/{driveId}/items/{itemId}/listItem/versions/{versionId}/fields</para>
    ///     <para type="description">Creates the &quot;fields&quot; object (which is of type &quot;microsoft.graph.fieldValueSet&quot;).</para>
    /// </summary>
    [Cmdlet("New", "Me_Drives_Items_ListItem_Versions_Fields", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.fieldValueSet")]
    [ODataType("microsoft.graph.fieldValueSet")]
    [ResourceReference]
    public class New_Me_Drives_Items_ListItem_Versions_Fields : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.listItemVersion&quot; object in the &quot;versions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.listItemVersion&quot; object in the &quot;versions&quot; collection.")]
        public System.String versionId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.")]
        public System.String itemId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/items/{itemId}/listItem/versions/{versionId}/fields";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.fieldValueSet&quot;.</para>
    ///     <para type="description">PATCH ~/me/drives/{driveId}/items/{itemId}/listItem/versions/{versionId}/fields</para>
    ///     <para type="description">Updates the &quot;fields&quot; object (which is of type &quot;microsoft.graph.fieldValueSet&quot;).</para>
    /// </summary>
    [Cmdlet("Update", "Me_Drives_Items_ListItem_Versions_Fields", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.fieldValueSet")]
    [ODataType("microsoft.graph.fieldValueSet")]
    public class Update_Me_Drives_Items_ListItem_Versions_Fields : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.listItemVersion&quot; object in the &quot;versions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.listItemVersion&quot; object in the &quot;versions&quot; collection.")]
        public System.String versionId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.")]
        public System.String itemId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/items/{itemId}/listItem/versions/{versionId}/fields";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.fieldValueSet&quot; object.</para>
    ///     <para type="description">DELETE ~/me/drives/{driveId}/items/{itemId}/listItem/versions/{versionId}/fields</para>
    ///     <para type="description">Removes the &quot;fields&quot; object (which is of type &quot;microsoft.graph.fieldValueSet&quot;).</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Drives_Items_ListItem_Versions_Fields", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.fieldValueSet")]
    public class Remove_Me_Drives_Items_ListItem_Versions_Fields : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.listItemVersion&quot; object in the &quot;versions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.listItemVersion&quot; object in the &quot;versions&quot; collection.")]
        public System.String versionId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;items&quot; collection.")]
        public System.String itemId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.drive&quot; object in the &quot;drives&quot; collection.")]
        public System.String driveId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drives/{driveId}/items/{itemId}/listItem/versions/{versionId}/fields";
        }
    }
}