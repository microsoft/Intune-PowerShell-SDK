// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.profilePhoto&quot; objects.</para>
    ///     <para type="description">GET ~/groups/{groupId}/photos</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.profilePhoto&quot; objects in the &quot;photos&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Groups_Photos", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.profilePhoto")]
    [ResourceTypePropertyName("photoODataType")]
    [ResourceIdPropertyName("photoId")]
    [ResourceReference]
    public class Get_Groups_Photos : GetOrSearchCmdlet
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
        ///     <para type="description">The ID for a &quot;microsoft.graph.profilePhoto&quot; object in the &quot;photos&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.profilePhoto&quot; object in the &quot;photos&quot; collection.")]
        public System.String photoId { get; set; }

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
            return $"groups/{groupId}/photos/{photoId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Retrieves a &quot;photos&quot; object&apos;s data stream.</para>
    ///     <para type="description">GET ~/groups/{groupId}/photos/$value</para>
    ///     <para type="description">Retrieves the data streams from the &quot;photos&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Groups_PhotosData")]
    [ODataType("microsoft.graph.profilePhoto")]
    [ResourceTypePropertyName("photoODataType")]
    [ResourceIdPropertyName("photoId")]
    public class Get_Groups_PhotosData : GetStreamCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.profilePhoto&quot; object in the &quot;photos&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.profilePhoto&quot; object in the &quot;photos&quot; collection.")]
        public System.String photoId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.")]
        public System.String groupId { get; set; }

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
            return $"groups/{groupId}/photos/{photoId}/$value";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Sets the data for the &quot;photo&quot; property.</para>
    ///     <para type="description">PUT ~/groups/{groupId}/photos/$value</para>
    ///     <para type="description">Sets the data for the &quot;photo&quot; property.</para>
    /// </summary>
    [Cmdlet("New", "Groups_PhotosData", ConfirmImpact = ConfirmImpact.Low)]
    [ODataType("microsoft.graph.profilePhoto")]
    [ResourceTypePropertyName("photoODataType")]
    [ResourceIdPropertyName("photoId")]
    public class New_Groups_PhotosData : UpdateStreamCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.profilePhoto&quot; object in the &quot;photos&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.profilePhoto&quot; object in the &quot;photos&quot; collection.")]
        public System.String photoId { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.")]
        public System.String groupId { get; set; }

        internal override System.String GetHttpMethod()
        {
            return "POST";
        }

        internal override System.String GetResourcePath()
        {
            return $"groups/{groupId}/photos/{photoId}/$value";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Sets the data for the &quot;photo&quot; property.</para>
    ///     <para type="description">PUT ~/groups/{groupId}/photos/$value</para>
    ///     <para type="description">Sets the data for the &quot;photo&quot; property.</para>
    /// </summary>
    [Cmdlet("Set", "Groups_PhotosData", ConfirmImpact = ConfirmImpact.Low)]
    [ODataType("microsoft.graph.profilePhoto")]
    [ResourceTypePropertyName("photoODataType")]
    [ResourceIdPropertyName("photoId")]
    public class Set_Groups_PhotosData : UpdateStreamCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.profilePhoto&quot; object in the &quot;photos&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.profilePhoto&quot; object in the &quot;photos&quot; collection.")]
        public System.String photoId { get; set; }

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
            return $"groups/{groupId}/photos/{photoId}/$value";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes the data stream from a &quot;photo&quot; object.</para>
    ///     <para type="description">DELETE ~/groups/{groupId}/photos/photoId/$value</para>
    ///     <para type="description">Removes a reference from a &quot;photo&quot; resource (which is of type &quot;microsoft.graph.profilePhoto&quot;).</para>
    /// </summary>
    [Cmdlet("Remove", "Groups_PhotosData", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.profilePhoto")]
    [ResourceTypePropertyName("photoODataType")]
    [ResourceIdPropertyName("photoId")]
    public class Remove_Groups_PhotosData : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.profilePhoto&quot; object in the &quot;photos&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.profilePhoto&quot; object in the &quot;photos&quot; collection.")]
        public System.String photoId { get; set; }

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
            return $"groups/{groupId}/photos/{photoId}/$value";
        }
    }
}