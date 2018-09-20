// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.groupSetting&quot; objects.</para>
    ///     <para type="description">GET ~/groups/{groupId}/settings</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.groupSetting&quot; objects in the &quot;settings&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Groups_Settings", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.groupSetting")]
    [ResourceTypePropertyName("settingODataType")]
    [ResourceIdPropertyName("settingId")]
    [ResourceReference]
    public class Get_Groups_Settings : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.")]
        public System.String groupId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.groupSetting&quot; object in the &quot;settings&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.groupSetting&quot; object in the &quot;settings&quot; collection.")]
        public System.String settingId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.groupSetting&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;templateId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.groupSetting&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String templateId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;values&quot; property, of type &quot;microsoft.graph.settingValue&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.groupSetting&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.settingValue")]
        [Selectable]
        public System.Object[] values { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"groups/{groupId}/settings/{settingId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.groupSetting&quot; object.</para>
    ///     <para type="description">POST ~/groups/{groupId}/settings</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.groupSetting&quot; object to the &quot;settings&quot; collection.</para>
    /// </summary>
    [Cmdlet("New", "Groups_Settings", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.groupSetting")]
    [ODataType("microsoft.graph.groupSetting")]
    [ResourceTypePropertyName("settingODataType")]
    [ResourceIdPropertyName("settingId")]
    [ResourceReference]
    public class New_Groups_Settings : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.groupSetting&quot; object in the &quot;settings&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        public System.String settingId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.")]
        public System.String groupId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.groupSetting&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.groupSetting", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;templateId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.groupSetting&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.groupSetting", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;templateId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;templateId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String templateId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;values&quot; property, of type &quot;microsoft.graph.settingValue&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.groupSetting&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.settingValue")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.groupSetting", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; property, of type &quot;microsoft.graph.settingValue&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; property, of type &quot;microsoft.graph.settingValue&quot;.")]
        public System.Object[] values { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"groups/{groupId}/settings/{settingId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.groupSetting&quot;.</para>
    ///     <para type="description">PATCH ~/groups/{groupId}/settings</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.groupSetting&quot; object in the &quot;settings&quot; collection.</para>
    /// </summary>
    [Cmdlet("Update", "Groups_Settings", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.groupSetting")]
    [ODataType("microsoft.graph.groupSetting")]
    [ResourceTypePropertyName("settingODataType")]
    [ResourceIdPropertyName("settingId")]
    public class Update_Groups_Settings : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.groupSetting&quot; object in the &quot;settings&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.groupSetting&quot; object in the &quot;settings&quot; collection.")]
        public System.String settingId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.")]
        public System.String groupId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.groupSetting&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.groupSetting", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;templateId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.groupSetting&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.groupSetting", HelpMessage = @"The &quot;templateId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;templateId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String templateId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;values&quot; property, of type &quot;microsoft.graph.settingValue&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.groupSetting&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.settingValue")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.groupSetting", HelpMessage = @"The &quot;values&quot; property, of type &quot;microsoft.graph.settingValue&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;values&quot; property, of type &quot;microsoft.graph.settingValue&quot;.")]
        public System.Object[] values { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"groups/{groupId}/settings/{settingId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.groupSetting&quot; object.</para>
    ///     <para type="description">DELETE ~/groups/{groupId}/settings/settingId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.groupSetting&quot; object from the &quot;settings&quot; collection.</para>
    /// </summary>
    [Cmdlet("Remove", "Groups_Settings", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.groupSetting")]
    [ResourceTypePropertyName("settingODataType")]
    [ResourceIdPropertyName("settingId")]
    public class Remove_Groups_Settings : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.groupSetting&quot; object in the &quot;settings&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.groupSetting&quot; object in the &quot;settings&quot; collection.")]
        public System.String settingId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.")]
        public System.String groupId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"groups/{groupId}/settings/{settingId}";
        }
    }
}