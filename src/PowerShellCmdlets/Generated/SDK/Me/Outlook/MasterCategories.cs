// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.outlookCategory&quot; objects.</para>
    ///     <para type="description">GET ~/me/outlook/masterCategories</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.outlookCategory&quot; objects in the &quot;masterCategories&quot; collection.</para>
    /// </summary>
    [Cmdlet("Get", "Me_Outlook_MasterCategories", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.outlookCategory")]
    [ResourceIdPropertyName("masterCategoryId")]
    [ResourceReference]
    public class Get_Me_Outlook_MasterCategories : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.outlookCategory&quot; object in the &quot;masterCategories&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.outlookCategory&quot; object in the &quot;masterCategories&quot; collection.")]
        public System.String masterCategoryId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.outlookCategory&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;color&quot; property, of type &quot;microsoft.graph.categoryColor&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.outlookCategory&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.categoryColor")]
        [Selectable]
        [Sortable]
        public System.String color { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/outlook/masterCategories/{masterCategoryId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.outlookCategory&quot; object.</para>
    ///     <para type="description">POST ~/me/outlook/masterCategories</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.outlookCategory&quot; object to the &quot;masterCategories&quot; collection.</para>
    /// </summary>
    [Cmdlet("New", "Me_Outlook_MasterCategories", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.outlookCategory")]
    [ODataType("microsoft.graph.outlookCategory")]
    [ResourceReference]
    public class New_Me_Outlook_MasterCategories : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.outlookCategory&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.outlookCategory", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;color&quot; property, of type &quot;microsoft.graph.categoryColor&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.outlookCategory&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;preset0&apos;, &apos;preset1&apos;, &apos;preset2&apos;, &apos;preset3&apos;, &apos;preset4&apos;, &apos;preset5&apos;, &apos;preset6&apos;, &apos;preset7&apos;, &apos;preset8&apos;, &apos;preset9&apos;, &apos;preset10&apos;, &apos;preset11&apos;, &apos;preset12&apos;, &apos;preset13&apos;, &apos;preset14&apos;, &apos;preset15&apos;, &apos;preset16&apos;, &apos;preset17&apos;, &apos;preset18&apos;, &apos;preset19&apos;, &apos;preset20&apos;, &apos;preset21&apos;, &apos;preset22&apos;, &apos;preset23&apos;, &apos;preset24&apos;, &apos;none&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.categoryColor")]
        [Selectable]
        [ValidateSet(@"preset0", @"preset1", @"preset2", @"preset3", @"preset4", @"preset5", @"preset6", @"preset7", @"preset8", @"preset9", @"preset10", @"preset11", @"preset12", @"preset13", @"preset14", @"preset15", @"preset16", @"preset17", @"preset18", @"preset19", @"preset20", @"preset21", @"preset22", @"preset23", @"preset24", @"none")]
        [Parameter(ParameterSetName = @"#microsoft.graph.outlookCategory", HelpMessage = @"The &quot;color&quot; property, of type &quot;microsoft.graph.categoryColor&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;color&quot; property, of type &quot;microsoft.graph.categoryColor&quot;.")]
        public System.String color { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/outlook/masterCategories";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.outlookCategory&quot;.</para>
    ///     <para type="description">PATCH ~/me/outlook/masterCategories</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.outlookCategory&quot; object in the &quot;masterCategories&quot; collection.</para>
    /// </summary>
    [Cmdlet("Update", "Me_Outlook_MasterCategories", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.outlookCategory")]
    [ODataType("microsoft.graph.outlookCategory")]
    [ResourceIdPropertyName("masterCategoryId")]
    public class Update_Me_Outlook_MasterCategories : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.outlookCategory&quot; object in the &quot;masterCategories&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.outlookCategory&quot; object in the &quot;masterCategories&quot; collection.")]
        public System.String masterCategoryId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.outlookCategory&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.outlookCategory", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;color&quot; property, of type &quot;microsoft.graph.categoryColor&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.outlookCategory&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;preset0&apos;, &apos;preset1&apos;, &apos;preset2&apos;, &apos;preset3&apos;, &apos;preset4&apos;, &apos;preset5&apos;, &apos;preset6&apos;, &apos;preset7&apos;, &apos;preset8&apos;, &apos;preset9&apos;, &apos;preset10&apos;, &apos;preset11&apos;, &apos;preset12&apos;, &apos;preset13&apos;, &apos;preset14&apos;, &apos;preset15&apos;, &apos;preset16&apos;, &apos;preset17&apos;, &apos;preset18&apos;, &apos;preset19&apos;, &apos;preset20&apos;, &apos;preset21&apos;, &apos;preset22&apos;, &apos;preset23&apos;, &apos;preset24&apos;, &apos;none&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.categoryColor")]
        [Selectable]
        [ValidateSet(@"preset0", @"preset1", @"preset2", @"preset3", @"preset4", @"preset5", @"preset6", @"preset7", @"preset8", @"preset9", @"preset10", @"preset11", @"preset12", @"preset13", @"preset14", @"preset15", @"preset16", @"preset17", @"preset18", @"preset19", @"preset20", @"preset21", @"preset22", @"preset23", @"preset24", @"none")]
        [Parameter(ParameterSetName = @"#microsoft.graph.outlookCategory", HelpMessage = @"The &quot;color&quot; property, of type &quot;microsoft.graph.categoryColor&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;color&quot; property, of type &quot;microsoft.graph.categoryColor&quot;.")]
        public System.String color { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/outlook/masterCategories/{masterCategoryId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.outlookCategory&quot; object.</para>
    ///     <para type="description">DELETE ~/me/outlook/masterCategories/masterCategoryId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.outlookCategory&quot; object from the &quot;masterCategories&quot; collection.</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Outlook_MasterCategories", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.outlookCategory")]
    [ResourceIdPropertyName("masterCategoryId")]
    public class Remove_Me_Outlook_MasterCategories : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.outlookCategory&quot; object in the &quot;masterCategories&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.outlookCategory&quot; object in the &quot;masterCategories&quot; collection.")]
        public System.String masterCategoryId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/outlook/masterCategories/{masterCategoryId}";
        }
    }
}