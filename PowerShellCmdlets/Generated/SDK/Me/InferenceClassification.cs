// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves the &quot;inferenceClassification&quot; object.</para>
    ///     <para type="description">GET ~/me/inferenceClassification</para>
    ///     <para type="description">Retrieves the &quot;inferenceClassification&quot; object (which is of type &quot;microsoft.graph.inferenceClassification&quot;).</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Get", "Me_InferenceClassification", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.inferenceClassification")]
    [ResourceTypePropertyName("inferenceClassificationODataType")]
    [ResourceReference]
    public class Get_Me_InferenceClassification : GetCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;overrides&quot; property, of type &quot;microsoft.graph.inferenceClassificationOverride&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.inferenceClassification&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.inferenceClassificationOverride")]
        [Selectable]
        [Expandable]
        public System.Object[] overrides { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/inferenceClassification";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.inferenceClassification&quot;.</para>
    ///     <para type="description">PATCH ~/me/inferenceClassification</para>
    ///     <para type="description">Updates the &quot;inferenceClassification&quot; object (which is of type &quot;microsoft.graph.inferenceClassification&quot;).</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Update", "Me_InferenceClassification", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.inferenceClassification")]
    [ODataType("microsoft.graph.inferenceClassification")]
    [ResourceTypePropertyName("inferenceClassificationODataType")]
    public class Update_Me_InferenceClassification : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;overrides&quot; property, of type &quot;microsoft.graph.inferenceClassificationOverride&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.inferenceClassification&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.inferenceClassificationOverride")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.inferenceClassification", HelpMessage = @"The &quot;overrides&quot; property, of type &quot;microsoft.graph.inferenceClassificationOverride&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;overrides&quot; property, of type &quot;microsoft.graph.inferenceClassificationOverride&quot;.")]
        public System.Object[] overrides { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/inferenceClassification";
        }
    }
}