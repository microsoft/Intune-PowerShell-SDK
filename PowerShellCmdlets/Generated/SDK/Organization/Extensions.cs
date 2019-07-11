// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.extension&quot; objects.</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.extension&quot; objects in the &quot;extensions&quot; collection.</para>
    ///     <para type="description">Graph call: GET ~/organization/{organizationId}/extensions</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Get", "Organization_Extensions", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.extension", "microsoft.graph.openTypeExtension")]
    [ResourceTypePropertyName("extensionODataType")]
    [ResourceReference]
    public class Get_Organization_Extensions : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.organization&quot; object in the &quot;organization&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.organization&quot; object in the &quot;organization&quot; collection.")]
        public System.String organizationId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.extension&quot; object in the &quot;extensions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
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
            return $"organization/{organizationId}/extensions/{extensionId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.extension&quot; object.</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.extension&quot; object to the &quot;extensions&quot; collection.</para>
    ///     <para type="description">Graph call: POST ~/organization/{organizationId}/extensions</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("New", "Organization_Extensions", ConfirmImpact = ConfirmImpact.Low)]
    [ODataType("microsoft.graph.extension", "microsoft.graph.openTypeExtension")]
    [ResourceTypePropertyName("extensionODataType")]
    [ResourceReference]
    public class New_Organization_Extensions : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.extension&quot; object in the &quot;extensions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        public System.String extensionId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.organization&quot; object in the &quot;organization&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.organization&quot; object in the &quot;organization&quot; collection.")]
        public System.String organizationId { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.openTypeExtension&quot; type.</para>
        /// </summary>
        [Selectable]
        [Expandable]
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
            return $"organization/{organizationId}/extensions/{extensionId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.extension&quot;.</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.extension&quot; object in the &quot;extensions&quot; collection.</para>
    ///     <para type="description">Graph Call: PATCH ~/organization/{organizationId}/extensions</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Update", "Organization_Extensions", ConfirmImpact = ConfirmImpact.Medium)]
    [ODataType("microsoft.graph.extension", "microsoft.graph.openTypeExtension")]
    [ResourceTypePropertyName("extensionODataType")]
    public class Update_Organization_Extensions : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.extension&quot; object in the &quot;extensions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.extension&quot; object in the &quot;extensions&quot; collection.")]
        public System.String extensionId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.organization&quot; object in the &quot;organization&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.organization&quot; object in the &quot;organization&quot; collection.")]
        public System.String organizationId { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.openTypeExtension&quot; type.</para>
        /// </summary>
        [Selectable]
        [Expandable]
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
            return $"organization/{organizationId}/extensions/{extensionId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.extension&quot; object.</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.extension&quot; object from the &quot;extensions&quot; collection.</para>
    ///     <para type="description">Graph Call: DELETE ~/organization/{organizationId}/extensions/extensionId</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Remove", "Organization_Extensions", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.extension", "microsoft.graph.openTypeExtension")]
    [ResourceTypePropertyName("extensionODataType")]
    public class Remove_Organization_Extensions : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.extension&quot; object in the &quot;extensions&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.extension&quot; object in the &quot;extensions&quot; collection.")]
        public System.String extensionId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.organization&quot; object in the &quot;organization&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.organization&quot; object in the &quot;organization&quot; collection.")]
        public System.String organizationId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"organization/{organizationId}/extensions/{extensionId}";
        }
    }
}