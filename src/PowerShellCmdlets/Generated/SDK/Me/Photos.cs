// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.profilePhoto&quot; objects.</para>
    ///     <para type="description">GET ~/me/photos</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.profilePhoto&quot; objects in the &quot;photos&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_Photos", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.profilePhoto")]
    [ResourceIdPropertyName("photoId")]
    [ResourceReference]
    public class Get_Me_Photos : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.profilePhoto&quot; object in the &quot;photos&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.profilePhoto&quot; object in the &quot;photos&quot; collection.")]
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
            return $"me/photos/{photoId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Retrieves a &quot;photos&quot; object&apos;s data stream.</para>
    ///     <para type="description">GET ~/me/photos/$value</para>
    ///     <para type="description">Retrieves the data streams from the &quot;photos&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_PhotosData")]
    [ODataType("microsoft.graph.profilePhoto")]
    [ResourceIdPropertyName("photoId")]
    public class Get_Me_PhotosData : GetStreamCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.profilePhoto&quot; object in the &quot;photos&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.profilePhoto&quot; object in the &quot;photos&quot; collection.")]
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
            return $"me/photos/{photoId}/$value";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Sets the data for the &quot;photo&quot; property.</para>
    ///     <para type="description">PUT ~/me/photos/$value</para>
    ///     <para type="description">Sets the data for the &quot;photo&quot; property.</para>
    /// </summary>
    [Cmdlet("New", "Me_PhotosData", ConfirmImpact = ConfirmImpact.Low)]
    [ODataType("microsoft.graph.profilePhoto")]
    [ResourceIdPropertyName("photoId")]
    public class New_Me_PhotosData : UpdateStreamCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.profilePhoto&quot; object in the &quot;photos&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.profilePhoto&quot; object in the &quot;photos&quot; collection.")]
        public System.String photoId { get; set; }

        internal override System.String GetHttpMethod()
        {
            return "POST";
        }

        internal override System.String GetResourcePath()
        {
            return $"me/photos/{photoId}/$value";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Sets the data for the &quot;photo&quot; property.</para>
    ///     <para type="description">PUT ~/me/photos/$value</para>
    ///     <para type="description">Sets the data for the &quot;photo&quot; property.</para>
    /// </summary>
    [Cmdlet("Set", "Me_PhotosData", ConfirmImpact = ConfirmImpact.Low)]
    [ODataType("microsoft.graph.profilePhoto")]
    [ResourceIdPropertyName("photoId")]
    public class Set_Me_PhotosData : UpdateStreamCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.profilePhoto&quot; object in the &quot;photos&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.profilePhoto&quot; object in the &quot;photos&quot; collection.")]
        public System.String photoId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/photos/{photoId}/$value";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes the data stream from a &quot;photo&quot; object.</para>
    ///     <para type="description">DELETE ~/me/photos/photoId/$ref</para>
    ///     <para type="description">Removes a reference from a &quot;photo&quot; resource (which is of type &quot;microsoft.graph.profilePhoto&quot;).</para>
    /// </summary>
    [Cmdlet("Remove", "Me_PhotosData", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.profilePhoto")]
    [ResourceIdPropertyName("photoId")]
    public class Remove_Me_PhotosData : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.profilePhoto&quot; object in the &quot;photos&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.profilePhoto&quot; object in the &quot;photos&quot; collection.")]
        public System.String photoId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/photos/{photoId}/$value";
        }
    }
}