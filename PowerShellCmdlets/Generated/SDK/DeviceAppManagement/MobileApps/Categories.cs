// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.mobileAppCategory&quot; objects.</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.mobileAppCategory&quot; objects in the &quot;categories&quot; collection.</para>
    ///     <para type="description">The list of categories for this app.</para>
    ///     <para type="description">Graph call: GET ~/deviceAppManagement/mobileApps/{mobileAppId}/categories</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Get", "IntuneMobileAppCategorySet", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.mobileAppCategory")]
    [ResourceTypePropertyName("categoryODataType")]
    public class Get_IntuneMobileAppCategorySet : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mobileApp&quot; object in the &quot;mobileApps&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mobileApp&quot; object in the &quot;mobileApps&quot; collection.")]
        public System.String mobileAppId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.mobileAppCategory&quot; object in the &quot;categories&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.mobileAppCategory&quot; object in the &quot;categories&quot; collection.")]
        public System.String mobileAppCategoryId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppCategory&quot; type.</para>
        ///     <para type="description">The name of the app category.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppCategory&quot; type.</para>
        ///     <para type="description">The date and time the mobileAppCategory was last modified.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/mobileApps/{mobileAppId}/categories/{mobileAppCategoryId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.mobileAppCategory&quot; object references.</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.mobileAppCategory&quot; object references in the &quot;categories&quot; collection.</para>
    ///     <para type="description">The list of categories for this app.</para>
    ///     <para type="description">Graph call: GET ~/deviceAppManagement/mobileApps/{mobileAppId}/categories/$ref</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Get", "IntuneMobileAppCategorySetReferenceSet", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.mobileAppCategory")]
    [ResourceTypePropertyName("categoryODataType")]
    public class Get_IntuneMobileAppCategorySetReferenceSet : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mobileApp&quot; object in the &quot;mobileApps&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mobileApp&quot; object in the &quot;mobileApps&quot; collection.")]
        public System.String mobileAppId { get; set; }

        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.mobileAppCategory&quot; object in the &quot;categories&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.mobileAppCategory&quot; object in the &quot;categories&quot; collection.")]
        public System.String mobileAppCategoryId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppCategory&quot; type.</para>
        ///     <para type="description">The name of the app category.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.mobileAppCategory&quot; type.</para>
        ///     <para type="description">The date and time the mobileAppCategory was last modified.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/mobileApps/{mobileAppId}/categories/{mobileAppCategoryId ?? string.Empty}/$ref";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a reference from a &quot;mobileApp&quot; to a &quot;microsoft.graph.mobileAppCategory&quot; object.</para>
    ///     <para type="description">Creates a reference from the specified &quot;mobileApp&quot; object to a &quot;category&quot;.</para>
    ///     <para type="description">The list of categories for this app.</para>
    ///     <para type="description">Graph Call: POST ~/deviceAppManagement/mobileApps/{mobileAppId}/categories/$ref</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("New", "IntuneMobileAppCategorySetReferenceSet", ConfirmImpact = ConfirmImpact.Low)]
    [ODataType("microsoft.graph.mobileAppCategory")]
    [ResourceTypePropertyName("categoryODataType")]
    public class New_IntuneMobileAppCategorySetReferenceSet : PostReferenceToCollectionCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.mobileAppCategory&quot; object in the &quot;categories&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        public System.String mobileAppCategoryId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mobileApp&quot; object in the &quot;mobileApps&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mobileApp&quot; object in the &quot;mobileApps&quot; collection.")]
        public System.String mobileAppId { get; set; }

        /// <summary>
        ///     <para type="description">The URL which should be used to access a &quot;microsoft.graph.mobileAppCategory&quot; object.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The URL which should be used to access a &quot;microsoft.graph.mobileAppCategory&quot; object.")]
        public System.String mobileAppCategoryReferenceUrl { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/mobileApps/{mobileAppId}/categories/{mobileAppCategoryId}/$ref";
        }

        internal override System.Object GetContent()
        {
            return this.GetReferenceRequestContent(mobileAppCategoryReferenceUrl);
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a reference from a &quot;mobileApp&quot; to a &quot;microsoft.graph.mobileAppCategory&quot; object.</para>
    ///     <para type="description">Removes a reference from the specified &quot;mobileApp&quot; object to a &quot;category&quot;.</para>
    ///     <para type="description">The list of categories for this app.</para>
    ///     <para type="description">Graph Call: DELETE ~/deviceAppManagement/mobileApps/{mobileAppId}/categories/mobileAppCategoryId/$ref</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Remove", "IntuneMobileAppCategorySetReferenceSet", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.mobileAppCategory")]
    [ResourceTypePropertyName("categoryODataType")]
    public class Remove_IntuneMobileAppCategorySetReferenceSet : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.mobileAppCategory&quot; object in the &quot;categories&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.mobileAppCategory&quot; object in the &quot;categories&quot; collection.")]
        public System.String mobileAppCategoryId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.mobileApp&quot; object in the &quot;mobileApps&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.mobileApp&quot; object in the &quot;mobileApps&quot; collection.")]
        public System.String mobileAppId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/mobileApps/{mobileAppId}/categories/{mobileAppCategoryId}/$ref";
        }
    }
}