// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.resourceOperation&quot; objects.</para>
    ///     <para type="description">GET ~/deviceManagement/resourceOperations</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.resourceOperation&quot; objects in the &quot;resourceOperations&quot; collection.</para>
    ///     <para type="description">The Resource Operations.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Get", "IntuneResourceOperation", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.resourceOperation")]
    [ResourceTypePropertyName("resourceOperationODataType")]
    [ResourceReference]
    public class Get_IntuneResourceOperation : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.resourceOperation&quot; object in the &quot;resourceOperations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.resourceOperation&quot; object in the &quot;resourceOperations&quot; collection.")]
        public System.String resourceOperationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;resourceName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.resourceOperation&quot; type.</para>
        ///     <para type="description">Name of the Resource this operation is performed on.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String resourceName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;actionName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.resourceOperation&quot; type.</para>
        ///     <para type="description">Type of action this operation is going to perform. The actionName should be concise and limited to as few words as possible.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String actionName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.resourceOperation&quot; type.</para>
        ///     <para type="description">Description of the resource operation. The description is used in mouse-over text for the operation when shown in the Azure Portal.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String description { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/resourceOperations/{resourceOperationId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.resourceOperation&quot; object.</para>
    ///     <para type="description">POST ~/deviceManagement/resourceOperations</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.resourceOperation&quot; object to the &quot;resourceOperations&quot; collection.</para>
    ///     <para type="description">The Resource Operations.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("New", "IntuneResourceOperation", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.resourceOperation")]
    [ODataType("microsoft.graph.resourceOperation")]
    [ResourceTypePropertyName("resourceOperationODataType")]
    [ResourceReference]
    public class New_IntuneResourceOperation : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.resourceOperation&quot; object in the &quot;resourceOperations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        public System.String resourceOperationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;resourceName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.resourceOperation&quot; type.</para>
        ///     <para type="description">Name of the Resource this operation is performed on.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.resourceOperation", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;resourceName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;resourceName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String resourceName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;actionName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.resourceOperation&quot; type.</para>
        ///     <para type="description">Type of action this operation is going to perform. The actionName should be concise and limited to as few words as possible.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.resourceOperation", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;actionName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;actionName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String actionName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.resourceOperation&quot; type.</para>
        ///     <para type="description">Description of the resource operation. The description is used in mouse-over text for the operation when shown in the Azure Portal.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.resourceOperation", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/resourceOperations/{resourceOperationId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.resourceOperation&quot;.</para>
    ///     <para type="description">PATCH ~/deviceManagement/resourceOperations</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.resourceOperation&quot; object in the &quot;resourceOperations&quot; collection.</para>
    ///     <para type="description">The Resource Operations.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Update", "IntuneResourceOperation", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.resourceOperation")]
    [ODataType("microsoft.graph.resourceOperation")]
    [ResourceTypePropertyName("resourceOperationODataType")]
    public class Update_IntuneResourceOperation : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.resourceOperation&quot; object in the &quot;resourceOperations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.resourceOperation&quot; object in the &quot;resourceOperations&quot; collection.")]
        public System.String resourceOperationId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;resourceName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.resourceOperation&quot; type.</para>
        ///     <para type="description">Name of the Resource this operation is performed on.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.resourceOperation", HelpMessage = @"The &quot;resourceName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;resourceName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String resourceName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;actionName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.resourceOperation&quot; type.</para>
        ///     <para type="description">Type of action this operation is going to perform. The actionName should be concise and limited to as few words as possible.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.resourceOperation", HelpMessage = @"The &quot;actionName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;actionName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String actionName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.resourceOperation&quot; type.</para>
        ///     <para type="description">Description of the resource operation. The description is used in mouse-over text for the operation when shown in the Azure Portal.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.resourceOperation", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/resourceOperations/{resourceOperationId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.resourceOperation&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceManagement/resourceOperations/resourceOperationId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.resourceOperation&quot; object from the &quot;resourceOperations&quot; collection.</para>
    ///     <para type="description">The Resource Operations.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Remove", "IntuneResourceOperation", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.resourceOperation")]
    [ResourceTypePropertyName("resourceOperationODataType")]
    public class Remove_IntuneResourceOperation : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.resourceOperation&quot; object in the &quot;resourceOperations&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.resourceOperation&quot; object in the &quot;resourceOperations&quot; collection.")]
        public System.String resourceOperationId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/resourceOperations/{resourceOperationId}";
        }
    }
}