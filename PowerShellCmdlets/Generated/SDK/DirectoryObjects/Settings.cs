// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.groupSetting&quot; objects.</para>
    ///     <para type="description">GET ~/directoryObjects/{directoryObjectId}/{directoryObjectODataType}/settings</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.groupSetting&quot; objects in the &quot;settings&quot; collection.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Get", "DirectoryObjects_Settings", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.groupSetting")]
    [ResourceTypePropertyName("settingODataType")]
    [ResourceReference]
    public class Get_DirectoryObjects_Settings : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.directoryObject&quot; object in the &quot;directoryObjects&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.directoryObject&quot; object in the &quot;directoryObjects&quot; collection.")]
        public System.String directoryObjectId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.directoryObject&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.directoryObject&apos;, &apos;microsoft.graph.administrativeUnit&apos;, &apos;microsoft.graph.groupSettingTemplate&apos;, &apos;microsoft.graph.user&apos;, &apos;microsoft.graph.organization&apos;, &apos;microsoft.graph.contract&apos;, &apos;microsoft.graph.group&apos;, &apos;microsoft.graph.directoryRoleTemplate&apos;, &apos;microsoft.graph.directoryRole&apos;, &apos;microsoft.graph.device&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [ValidateSet(@"microsoft.graph.directoryObject", @"microsoft.graph.administrativeUnit", @"microsoft.graph.groupSettingTemplate", @"microsoft.graph.user", @"microsoft.graph.organization", @"microsoft.graph.contract", @"microsoft.graph.group", @"microsoft.graph.directoryRoleTemplate", @"microsoft.graph.directoryRole", @"microsoft.graph.device")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.directoryObject&quot; objects.")]
        public System.String directoryObjectODataType { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.groupSetting&quot; object in the &quot;settings&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.groupSetting&quot; object in the &quot;settings&quot; collection.")]
        public System.String groupSettingId { get; set; }

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
            return $"directoryObjects/{directoryObjectId}/{directoryObjectODataType}/settings/{groupSettingId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.groupSetting&quot; object.</para>
    ///     <para type="description">POST ~/directoryObjects/{directoryObjectId}/{directoryObjectODataType}/settings</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.groupSetting&quot; object to the &quot;settings&quot; collection.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("New", "DirectoryObjects_Settings", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.groupSetting")]
    [ODataType("microsoft.graph.groupSetting")]
    [ResourceTypePropertyName("settingODataType")]
    [ResourceReference]
    public class New_DirectoryObjects_Settings : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.groupSetting&quot; object in the &quot;settings&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ResourceIdParameter]
        public System.String groupSettingId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.directoryObject&quot; object in the &quot;directoryObjects&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.directoryObject&quot; object in the &quot;directoryObjects&quot; collection.")]
        public System.String directoryObjectId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.directoryObject&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.directoryObject&apos;, &apos;microsoft.graph.administrativeUnit&apos;, &apos;microsoft.graph.groupSettingTemplate&apos;, &apos;microsoft.graph.user&apos;, &apos;microsoft.graph.organization&apos;, &apos;microsoft.graph.contract&apos;, &apos;microsoft.graph.group&apos;, &apos;microsoft.graph.directoryRoleTemplate&apos;, &apos;microsoft.graph.directoryRole&apos;, &apos;microsoft.graph.device&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [ValidateSet(@"microsoft.graph.directoryObject", @"microsoft.graph.administrativeUnit", @"microsoft.graph.groupSettingTemplate", @"microsoft.graph.user", @"microsoft.graph.organization", @"microsoft.graph.contract", @"microsoft.graph.group", @"microsoft.graph.directoryRoleTemplate", @"microsoft.graph.directoryRole", @"microsoft.graph.device")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.directoryObject&quot; objects.")]
        public System.String directoryObjectODataType { get; set; }

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
            return $"directoryObjects/{directoryObjectId}/{directoryObjectODataType}/settings/{groupSettingId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.groupSetting&quot;.</para>
    ///     <para type="description">PATCH ~/directoryObjects/{directoryObjectId}/{directoryObjectODataType}/settings</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.groupSetting&quot; object in the &quot;settings&quot; collection.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Update", "DirectoryObjects_Settings", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.groupSetting")]
    [ODataType("microsoft.graph.groupSetting")]
    [ResourceTypePropertyName("settingODataType")]
    public class Update_DirectoryObjects_Settings : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.groupSetting&quot; object in the &quot;settings&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.groupSetting&quot; object in the &quot;settings&quot; collection.")]
        public System.String groupSettingId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.directoryObject&quot; object in the &quot;directoryObjects&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.directoryObject&quot; object in the &quot;directoryObjects&quot; collection.")]
        public System.String directoryObjectId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.directoryObject&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.directoryObject&apos;, &apos;microsoft.graph.administrativeUnit&apos;, &apos;microsoft.graph.groupSettingTemplate&apos;, &apos;microsoft.graph.user&apos;, &apos;microsoft.graph.organization&apos;, &apos;microsoft.graph.contract&apos;, &apos;microsoft.graph.group&apos;, &apos;microsoft.graph.directoryRoleTemplate&apos;, &apos;microsoft.graph.directoryRole&apos;, &apos;microsoft.graph.device&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [ValidateSet(@"microsoft.graph.directoryObject", @"microsoft.graph.administrativeUnit", @"microsoft.graph.groupSettingTemplate", @"microsoft.graph.user", @"microsoft.graph.organization", @"microsoft.graph.contract", @"microsoft.graph.group", @"microsoft.graph.directoryRoleTemplate", @"microsoft.graph.directoryRole", @"microsoft.graph.device")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.directoryObject&quot; objects.")]
        public System.String directoryObjectODataType { get; set; }

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
            return $"directoryObjects/{directoryObjectId}/{directoryObjectODataType}/settings/{groupSettingId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.groupSetting&quot; object.</para>
    ///     <para type="description">DELETE ~/directoryObjects/{directoryObjectId}/{directoryObjectODataType}/settings/groupSettingId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.groupSetting&quot; object from the &quot;settings&quot; collection.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Remove", "DirectoryObjects_Settings", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.groupSetting")]
    [ResourceTypePropertyName("settingODataType")]
    public class Remove_DirectoryObjects_Settings : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.groupSetting&quot; object in the &quot;settings&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.groupSetting&quot; object in the &quot;settings&quot; collection.")]
        public System.String groupSettingId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.directoryObject&quot; object in the &quot;directoryObjects&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.directoryObject&quot; object in the &quot;directoryObjects&quot; collection.")]
        public System.String directoryObjectId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.directoryObject&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.directoryObject&apos;, &apos;microsoft.graph.administrativeUnit&apos;, &apos;microsoft.graph.groupSettingTemplate&apos;, &apos;microsoft.graph.user&apos;, &apos;microsoft.graph.organization&apos;, &apos;microsoft.graph.contract&apos;, &apos;microsoft.graph.group&apos;, &apos;microsoft.graph.directoryRoleTemplate&apos;, &apos;microsoft.graph.directoryRole&apos;, &apos;microsoft.graph.device&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [ValidateSet(@"microsoft.graph.directoryObject", @"microsoft.graph.administrativeUnit", @"microsoft.graph.groupSettingTemplate", @"microsoft.graph.user", @"microsoft.graph.organization", @"microsoft.graph.contract", @"microsoft.graph.group", @"microsoft.graph.directoryRoleTemplate", @"microsoft.graph.directoryRole", @"microsoft.graph.device")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.directoryObject&quot; objects.")]
        public System.String directoryObjectODataType { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"directoryObjects/{directoryObjectId}/{directoryObjectODataType}/settings/{groupSettingId}";
        }
    }
}