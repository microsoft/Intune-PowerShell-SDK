// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves the &quot;fields&quot; object.</para>
    ///     <para type="description">GET ~/me/drive/root/listItem/versions/{versionId}/fields</para>
    ///     <para type="description">Retrieves the &quot;fields&quot; object (which is of type &quot;microsoft.graph.fieldValueSet&quot;).</para>
    /// </summary>
    [Cmdlet("Get", "Me_Drive_Root_ListItem_Versions_Fields", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.fieldValueSet")]
    [ResourceReference]
    public class Get_Me_Drive_Root_ListItem_Versions_Fields : GetCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.listItemVersion&quot; object in the &quot;versions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.listItemVersion&quot; object in the &quot;versions&quot; collection.")]
        public System.String versionId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/root/listItem/versions/{versionId}/fields";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.fieldValueSet&quot; object.</para>
    ///     <para type="description">POST ~/me/drive/root/listItem/versions/{versionId}/fields</para>
    ///     <para type="description">Creates the &quot;fields&quot; object (which is of type &quot;microsoft.graph.fieldValueSet&quot;).</para>
    /// </summary>
    [Cmdlet("New", "Me_Drive_Root_ListItem_Versions_Fields", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.fieldValueSet")]
    [ODataType("microsoft.graph.fieldValueSet")]
    [ResourceReference]
    public class New_Me_Drive_Root_ListItem_Versions_Fields : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.listItemVersion&quot; object in the &quot;versions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.listItemVersion&quot; object in the &quot;versions&quot; collection.")]
        public System.String versionId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/root/listItem/versions/{versionId}/fields";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.fieldValueSet&quot;.</para>
    ///     <para type="description">PATCH ~/me/drive/root/listItem/versions/{versionId}/fields</para>
    ///     <para type="description">Updates the &quot;fields&quot; object (which is of type &quot;microsoft.graph.fieldValueSet&quot;).</para>
    /// </summary>
    [Cmdlet("Update", "Me_Drive_Root_ListItem_Versions_Fields", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.fieldValueSet")]
    [ODataType("microsoft.graph.fieldValueSet")]
    public class Update_Me_Drive_Root_ListItem_Versions_Fields : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.listItemVersion&quot; object in the &quot;versions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.listItemVersion&quot; object in the &quot;versions&quot; collection.")]
        public System.String versionId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/root/listItem/versions/{versionId}/fields";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.fieldValueSet&quot; object.</para>
    ///     <para type="description">DELETE ~/me/drive/root/listItem/versions/{versionId}/fields</para>
    ///     <para type="description">Removes the &quot;fields&quot; object (which is of type &quot;microsoft.graph.fieldValueSet&quot;).</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Drive_Root_ListItem_Versions_Fields", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.fieldValueSet")]
    public class Remove_Me_Drive_Root_ListItem_Versions_Fields : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.listItemVersion&quot; object in the &quot;versions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.listItemVersion&quot; object in the &quot;versions&quot; collection.")]
        public System.String versionId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/root/listItem/versions/{versionId}/fields";
        }
    }
}