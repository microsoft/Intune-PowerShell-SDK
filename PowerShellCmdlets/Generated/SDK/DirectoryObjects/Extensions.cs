// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.extension&quot; objects.</para>
    ///     <para type="description">GET ~/directoryObjects/{directoryObjectId}/{directoryObjectODataType}/extensions</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.extension&quot; objects in the &quot;extensions&quot; collection.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Get", "DirectoryObjects_Extensions", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.extension", "microsoft.graph.openTypeExtension")]
    [ResourceTypePropertyName("extensionODataType")]
    [ResourceReference]
    public class Get_DirectoryObjects_Extensions : GetOrSearchCmdlet
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
        ///     <para type="description">The ID for a &quot;microsoft.graph.extension&quot; object in the &quot;extensions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.extension&quot; object in the &quot;extensions&quot; collection.")]
        public System.String extensionId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;extensionName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.openTypeExtension&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        [DerivedType("microsoft.graph.openTypeExtension")]
        public System.String extensionName { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"directoryObjects/{directoryObjectId}/{directoryObjectODataType}/extensions/{extensionId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.extension&quot; object.</para>
    ///     <para type="description">POST ~/directoryObjects/{directoryObjectId}/{directoryObjectODataType}/extensions</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.extension&quot; object to the &quot;extensions&quot; collection.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("New", "DirectoryObjects_Extensions", ConfirmImpact = ConfirmImpact.Low)]
    [ODataType("microsoft.graph.extension", "microsoft.graph.openTypeExtension")]
    [ResourceTypePropertyName("extensionODataType")]
    [ResourceReference]
    public class New_DirectoryObjects_Extensions : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.extension&quot; object in the &quot;extensions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ResourceIdParameter]
        public System.String extensionId { get; set; }

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
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.openTypeExtension&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.openTypeExtension")]
        [Parameter(ParameterSetName = @"microsoft.graph.openTypeExtension", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.openTypeExtension&quot; type.")]
        public System.Management.Automation.SwitchParameter openTypeExtension { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;extensionName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.openTypeExtension&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.openTypeExtension", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;extensionName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;extensionName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String extensionName { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"directoryObjects/{directoryObjectId}/{directoryObjectODataType}/extensions/{extensionId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.extension&quot;.</para>
    ///     <para type="description">PATCH ~/directoryObjects/{directoryObjectId}/{directoryObjectODataType}/extensions</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.extension&quot; object in the &quot;extensions&quot; collection.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Update", "DirectoryObjects_Extensions", ConfirmImpact = ConfirmImpact.Medium)]
    [ODataType("microsoft.graph.extension", "microsoft.graph.openTypeExtension")]
    [ResourceTypePropertyName("extensionODataType")]
    public class Update_DirectoryObjects_Extensions : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.extension&quot; object in the &quot;extensions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.extension&quot; object in the &quot;extensions&quot; collection.")]
        public System.String extensionId { get; set; }

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
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.openTypeExtension&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.openTypeExtension")]
        [Parameter(ParameterSetName = @"microsoft.graph.openTypeExtension", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.openTypeExtension&quot; type.")]
        public System.Management.Automation.SwitchParameter openTypeExtension { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;extensionName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.openTypeExtension&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.openTypeExtension", HelpMessage = @"The &quot;extensionName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;extensionName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String extensionName { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"directoryObjects/{directoryObjectId}/{directoryObjectODataType}/extensions/{extensionId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.extension&quot; object.</para>
    ///     <para type="description">DELETE ~/directoryObjects/{directoryObjectId}/{directoryObjectODataType}/extensions/extensionId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.extension&quot; object from the &quot;extensions&quot; collection.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Remove", "DirectoryObjects_Extensions", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.extension", "microsoft.graph.openTypeExtension")]
    [ResourceTypePropertyName("extensionODataType")]
    public class Remove_DirectoryObjects_Extensions : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.extension&quot; object in the &quot;extensions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.extension&quot; object in the &quot;extensions&quot; collection.")]
        public System.String extensionId { get; set; }

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
            return $"directoryObjects/{directoryObjectId}/{directoryObjectODataType}/extensions/{extensionId}";
        }
    }
}