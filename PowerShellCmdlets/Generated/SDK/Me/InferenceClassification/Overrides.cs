// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.inferenceClassificationOverride&quot; objects.</para>
    ///     <para type="description">GET ~/me/inferenceClassification/overrides</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.inferenceClassificationOverride&quot; objects in the &quot;overrides&quot; collection.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Get", "Me_InferenceClassification_Overrides", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.inferenceClassificationOverride")]
    [ResourceTypePropertyName("overrideODataType")]
    [ResourceReference]
    public class Get_Me_InferenceClassification_Overrides : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.inferenceClassificationOverride&quot; object in the &quot;overrides&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.inferenceClassificationOverride&quot; object in the &quot;overrides&quot; collection.")]
        public System.String inferenceClassificationOverrideId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;classifyAs&quot; property, of type &quot;microsoft.graph.inferenceClassificationType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.inferenceClassificationOverride&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.inferenceClassificationType")]
        [Selectable]
        [Sortable]
        public System.String classifyAs { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;senderEmailAddress&quot; property, of type &quot;microsoft.graph.emailAddress&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.inferenceClassificationOverride&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.emailAddress")]
        [Selectable]
        [Sortable]
        public System.Object senderEmailAddress { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/inferenceClassification/overrides/{inferenceClassificationOverrideId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.inferenceClassificationOverride&quot; object.</para>
    ///     <para type="description">POST ~/me/inferenceClassification/overrides</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.inferenceClassificationOverride&quot; object to the &quot;overrides&quot; collection.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("New", "Me_InferenceClassification_Overrides", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.inferenceClassificationOverride")]
    [ODataType("microsoft.graph.inferenceClassificationOverride")]
    [ResourceTypePropertyName("overrideODataType")]
    [ResourceReference]
    public class New_Me_InferenceClassification_Overrides : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.inferenceClassificationOverride&quot; object in the &quot;overrides&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        public System.String inferenceClassificationOverrideId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;classifyAs&quot; property, of type &quot;microsoft.graph.inferenceClassificationType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.inferenceClassificationOverride&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;focused&apos;, &apos;other&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.inferenceClassificationType")]
        [Selectable]
        [ValidateSet(@"focused", @"other")]
        [Parameter(ParameterSetName = @"microsoft.graph.inferenceClassificationOverride", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;classifyAs&quot; property, of type &quot;microsoft.graph.inferenceClassificationType&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;classifyAs&quot; property, of type &quot;microsoft.graph.inferenceClassificationType&quot;.")]
        public System.String classifyAs { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;senderEmailAddress&quot; property, of type &quot;microsoft.graph.emailAddress&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.inferenceClassificationOverride&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.emailAddress")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.inferenceClassificationOverride", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;senderEmailAddress&quot; property, of type &quot;microsoft.graph.emailAddress&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;senderEmailAddress&quot; property, of type &quot;microsoft.graph.emailAddress&quot;.")]
        public System.Object senderEmailAddress { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/inferenceClassification/overrides/{inferenceClassificationOverrideId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.inferenceClassificationOverride&quot;.</para>
    ///     <para type="description">PATCH ~/me/inferenceClassification/overrides</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.inferenceClassificationOverride&quot; object in the &quot;overrides&quot; collection.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Update", "Me_InferenceClassification_Overrides", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.inferenceClassificationOverride")]
    [ODataType("microsoft.graph.inferenceClassificationOverride")]
    [ResourceTypePropertyName("overrideODataType")]
    public class Update_Me_InferenceClassification_Overrides : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.inferenceClassificationOverride&quot; object in the &quot;overrides&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.inferenceClassificationOverride&quot; object in the &quot;overrides&quot; collection.")]
        public System.String inferenceClassificationOverrideId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;classifyAs&quot; property, of type &quot;microsoft.graph.inferenceClassificationType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.inferenceClassificationOverride&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;focused&apos;, &apos;other&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.inferenceClassificationType")]
        [Selectable]
        [ValidateSet(@"focused", @"other")]
        [Parameter(ParameterSetName = @"microsoft.graph.inferenceClassificationOverride", HelpMessage = @"The &quot;classifyAs&quot; property, of type &quot;microsoft.graph.inferenceClassificationType&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;classifyAs&quot; property, of type &quot;microsoft.graph.inferenceClassificationType&quot;.")]
        public System.String classifyAs { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;senderEmailAddress&quot; property, of type &quot;microsoft.graph.emailAddress&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.inferenceClassificationOverride&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.emailAddress")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.inferenceClassificationOverride", HelpMessage = @"The &quot;senderEmailAddress&quot; property, of type &quot;microsoft.graph.emailAddress&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;senderEmailAddress&quot; property, of type &quot;microsoft.graph.emailAddress&quot;.")]
        public System.Object senderEmailAddress { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/inferenceClassification/overrides/{inferenceClassificationOverrideId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.inferenceClassificationOverride&quot; object.</para>
    ///     <para type="description">DELETE ~/me/inferenceClassification/overrides/inferenceClassificationOverrideId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.inferenceClassificationOverride&quot; object from the &quot;overrides&quot; collection.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Remove", "Me_InferenceClassification_Overrides", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.inferenceClassificationOverride")]
    [ResourceTypePropertyName("overrideODataType")]
    public class Remove_Me_InferenceClassification_Overrides : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.inferenceClassificationOverride&quot; object in the &quot;overrides&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.inferenceClassificationOverride&quot; object in the &quot;overrides&quot; collection.")]
        public System.String inferenceClassificationOverrideId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/inferenceClassification/overrides/{inferenceClassificationOverrideId}";
        }
    }
}