// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.inferenceClassification&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.inferenceClassification&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "InferenceClassificationObject", DefaultParameterSetName = @"microsoft.graph.inferenceClassification")]
    [ODataType("microsoft.graph.inferenceClassification")]
    public class New_InferenceClassificationObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;overrides&quot; property, of type &quot;microsoft.graph.inferenceClassificationOverride&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.inferenceClassification&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.inferenceClassificationOverride")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.inferenceClassification", HelpMessage = @"The &quot;overrides&quot; property, of type &quot;microsoft.graph.inferenceClassificationOverride&quot;.")]
        public System.Object[] overrides { get; set; }
    }
}