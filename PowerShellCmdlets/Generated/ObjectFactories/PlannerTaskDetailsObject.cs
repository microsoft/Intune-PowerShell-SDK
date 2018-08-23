// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.plannerTaskDetails&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.plannerTaskDetails&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "PlannerTaskDetailsObject", DefaultParameterSetName = @"microsoft.graph.plannerTaskDetails")]
    [ODataType("microsoft.graph.plannerTaskDetails")]
    public class New_PlannerTaskDetailsObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTaskDetails&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.plannerTaskDetails", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;previewType&quot; property, of type &quot;microsoft.graph.plannerPreviewType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTaskDetails&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;automatic&apos;, &apos;noPreview&apos;, &apos;checklist&apos;, &apos;description&apos;, &apos;reference&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.plannerPreviewType")]
        [Selectable]
        [ValidateSet(@"automatic", @"noPreview", @"checklist", @"description", @"reference")]
        [Parameter(ParameterSetName = @"microsoft.graph.plannerTaskDetails", HelpMessage = @"The &quot;previewType&quot; property, of type &quot;microsoft.graph.plannerPreviewType&quot;.")]
        public System.String previewType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;references&quot; property, of type &quot;microsoft.graph.plannerExternalReferences&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTaskDetails&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerExternalReferences")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.plannerTaskDetails", HelpMessage = @"The &quot;references&quot; property, of type &quot;microsoft.graph.plannerExternalReferences&quot;.")]
        public System.Object references { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;checklist&quot; property, of type &quot;microsoft.graph.plannerChecklistItems&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerTaskDetails&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.plannerChecklistItems")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.plannerTaskDetails", HelpMessage = @"The &quot;checklist&quot; property, of type &quot;microsoft.graph.plannerChecklistItems&quot;.")]
        public System.Object checklist { get; set; }
    }
}