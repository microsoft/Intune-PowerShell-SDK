// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.inferenceClassificationOverride&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.inferenceClassificationOverride&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "InferenceClassificationOverrideObject", DefaultParameterSetName = @"#microsoft.graph.inferenceClassificationOverride")]
    [ODataType("microsoft.graph.inferenceClassificationOverride")]
    public class New_InferenceClassificationOverrideObject : ObjectFactoryCmdletBase
    {
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
        [Parameter(ParameterSetName = @"#microsoft.graph.inferenceClassificationOverride", HelpMessage = @"The &quot;classifyAs&quot; property, of type &quot;microsoft.graph.inferenceClassificationType&quot;.")]
        public System.String classifyAs { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;senderEmailAddress&quot; property, of type &quot;microsoft.graph.emailAddress&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.inferenceClassificationOverride&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.emailAddress")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.inferenceClassificationOverride", HelpMessage = @"The &quot;senderEmailAddress&quot; property, of type &quot;microsoft.graph.emailAddress&quot;.")]
        public System.Object senderEmailAddress { get; set; }
    }
}