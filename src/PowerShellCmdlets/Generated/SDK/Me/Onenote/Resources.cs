// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.onenoteResource&quot; objects.</para>
    ///     <para type="description">GET ~/me/onenote/resources</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.onenoteResource&quot; objects in the &quot;resources&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_Onenote_Resources", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.onenoteResource")]
    [ResourceIdPropertyName("resourceId")]
    [ResourceReference]
    public class Get_Me_Onenote_Resources : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.onenoteResource&quot; object in the &quot;resources&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.onenoteResource&quot; object in the &quot;resources&quot; collection.")]
        public System.String resourceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;content&quot; property, of type &quot;Edm.Stream&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteResource&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Stream")]
        [Selectable]
        [Sortable]
        public System.IO.Stream content { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteResource&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String contentUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;self&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteResource&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String self { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote/resources/{resourceId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.onenoteResource&quot; object.</para>
    ///     <para type="description">POST ~/me/onenote/resources</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.onenoteResource&quot; object to the &quot;resources&quot; collection.</para>
    /// </summary>
    [Cmdlet("New", "Me_Onenote_Resources", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.onenoteResource")]
    [ODataType("microsoft.graph.onenoteResource")]
    [ResourceReference]
    public class New_Me_Onenote_Resources : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;content&quot; property, of type &quot;Edm.Stream&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteResource&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Stream")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteResource", HelpMessage = @"The &quot;content&quot; property, of type &quot;Edm.Stream&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;content&quot; property, of type &quot;Edm.Stream&quot;.")]
        public System.IO.Stream content { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteResource&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteResource", HelpMessage = @"The &quot;contentUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;contentUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String contentUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;self&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteResource&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteResource", HelpMessage = @"The &quot;self&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;self&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String self { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote/resources";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.onenoteResource&quot;.</para>
    ///     <para type="description">PATCH ~/me/onenote/resources</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.onenoteResource&quot; object in the &quot;resources&quot; collection.</para>
    /// </summary>
    [Cmdlet("Update", "Me_Onenote_Resources", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.onenoteResource")]
    [ODataType("microsoft.graph.onenoteResource")]
    [ResourceIdPropertyName("resourceId")]
    public class Update_Me_Onenote_Resources : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.onenoteResource&quot; object in the &quot;resources&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.onenoteResource&quot; object in the &quot;resources&quot; collection.")]
        public System.String resourceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;content&quot; property, of type &quot;Edm.Stream&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteResource&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Stream")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteResource", HelpMessage = @"The &quot;content&quot; property, of type &quot;Edm.Stream&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;content&quot; property, of type &quot;Edm.Stream&quot;.")]
        public System.IO.Stream content { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteResource&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteResource", HelpMessage = @"The &quot;contentUrl&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;contentUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String contentUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;self&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteResource&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.onenoteResource", HelpMessage = @"The &quot;self&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;self&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String self { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote/resources/{resourceId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.onenoteResource&quot; object.</para>
    ///     <para type="description">DELETE ~/me/onenote/resources/resourceId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.onenoteResource&quot; object from the &quot;resources&quot; collection.</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Onenote_Resources", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.onenoteResource")]
    [ResourceIdPropertyName("resourceId")]
    public class Remove_Me_Onenote_Resources : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.onenoteResource&quot; object in the &quot;resources&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.onenoteResource&quot; object in the &quot;resources&quot; collection.")]
        public System.String resourceId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote/resources/{resourceId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Retrieves a &quot;resources&quot; object&apos;s data stream.</para>
    ///     <para type="description">GET ~/me/onenote/resources/$value</para>
    ///     <para type="description">Retrieves the data streams from the &quot;resources&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_Onenote_ResourcesData")]
    [ODataType("microsoft.graph.onenoteResource")]
    [ResourceIdPropertyName("resourceId")]
    public class Get_Me_Onenote_ResourcesData : GetStreamCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.onenoteResource&quot; object in the &quot;resources&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.onenoteResource&quot; object in the &quot;resources&quot; collection.")]
        public System.String resourceId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;content&quot; property, of type &quot;Edm.Stream&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteResource&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Stream")]
        [Selectable]
        [Sortable]
        public System.IO.Stream content { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;contentUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteResource&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String contentUrl { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;self&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onenoteResource&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String self { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote/resources/{resourceId}/$value";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Sets the data for the &quot;resource&quot; property.</para>
    ///     <para type="description">PUT ~/me/onenote/resources/$value</para>
    ///     <para type="description">Sets the data for the &quot;resource&quot; property.</para>
    /// </summary>
    [Cmdlet("New", "Me_Onenote_ResourcesData", ConfirmImpact = ConfirmImpact.Low)]
    [ODataType("microsoft.graph.onenoteResource")]
    [ResourceIdPropertyName("resourceId")]
    public class New_Me_Onenote_ResourcesData : UpdateStreamCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.onenoteResource&quot; object in the &quot;resources&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.onenoteResource&quot; object in the &quot;resources&quot; collection.")]
        public System.String resourceId { get; set; }

        internal override System.String GetHttpMethod()
        {
            return "POST";
        }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote/resources/{resourceId}/$value";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Sets the data for the &quot;resource&quot; property.</para>
    ///     <para type="description">PUT ~/me/onenote/resources/$value</para>
    ///     <para type="description">Sets the data for the &quot;resource&quot; property.</para>
    /// </summary>
    [Cmdlet("Set", "Me_Onenote_ResourcesData", ConfirmImpact = ConfirmImpact.Low)]
    [ODataType("microsoft.graph.onenoteResource")]
    [ResourceIdPropertyName("resourceId")]
    public class Set_Me_Onenote_ResourcesData : UpdateStreamCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.onenoteResource&quot; object in the &quot;resources&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.onenoteResource&quot; object in the &quot;resources&quot; collection.")]
        public System.String resourceId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote/resources/{resourceId}/$value";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes the data stream from a &quot;resource&quot; object.</para>
    ///     <para type="description">DELETE ~/me/onenote/resources/resourceId/$ref</para>
    ///     <para type="description">Removes a reference from a &quot;resource&quot; resource (which is of type &quot;microsoft.graph.onenoteResource&quot;).</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Onenote_ResourcesData", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.onenoteResource")]
    [ResourceIdPropertyName("resourceId")]
    public class Remove_Me_Onenote_ResourcesData : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.onenoteResource&quot; object in the &quot;resources&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.onenoteResource&quot; object in the &quot;resources&quot; collection.")]
        public System.String resourceId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/onenote/resources/{resourceId}/$value";
        }
    }
}