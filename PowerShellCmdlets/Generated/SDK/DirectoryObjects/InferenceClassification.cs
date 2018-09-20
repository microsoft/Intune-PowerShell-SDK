// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves the &quot;inferenceClassification&quot; object.</para>
    ///     <para type="description">GET ~/directoryObjects/{directoryObjectId}/{directoryObjectODataType}/inferenceClassification</para>
    ///     <para type="description">Retrieves the &quot;inferenceClassification&quot; object (which is of type &quot;microsoft.graph.inferenceClassification&quot;).</para>
    /// </summary>
    [Cmdlet("Get", "DirectoryObjects_InferenceClassification", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.inferenceClassification")]
    [ResourceTypePropertyName("inferenceClassificationODataType")]
    [ResourceReference]
    public class Get_DirectoryObjects_InferenceClassification : GetCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.directoryObject&quot; object in the &quot;directoryObjects&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.directoryObject&quot; object in the &quot;directoryObjects&quot; collection.")]
        public System.String directoryObjectId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.directoryObject&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.directoryObject&apos;, &apos;microsoft.graph.administrativeUnit&apos;, &apos;microsoft.graph.groupSettingTemplate&apos;, &apos;microsoft.graph.user&apos;, &apos;microsoft.graph.organization&apos;, &apos;microsoft.graph.contract&apos;, &apos;microsoft.graph.group&apos;, &apos;microsoft.graph.directoryRoleTemplate&apos;, &apos;microsoft.graph.directoryRole&apos;, &apos;microsoft.graph.device&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [ValidateSet(@"microsoft.graph.directoryObject", @"microsoft.graph.administrativeUnit", @"microsoft.graph.groupSettingTemplate", @"microsoft.graph.user", @"microsoft.graph.organization", @"microsoft.graph.contract", @"microsoft.graph.group", @"microsoft.graph.directoryRoleTemplate", @"microsoft.graph.directoryRole", @"microsoft.graph.device")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.directoryObject&quot; objects.")]
        public System.String directoryObjectODataType { get; set; }

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
            return $"directoryObjects/{directoryObjectId}/{directoryObjectODataType}/inferenceClassification";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.inferenceClassification&quot;.</para>
    ///     <para type="description">PATCH ~/directoryObjects/{directoryObjectId}/{directoryObjectODataType}/inferenceClassification</para>
    ///     <para type="description">Updates the &quot;inferenceClassification&quot; object (which is of type &quot;microsoft.graph.inferenceClassification&quot;).</para>
    /// </summary>
    [Cmdlet("Update", "DirectoryObjects_InferenceClassification", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.inferenceClassification")]
    [ODataType("microsoft.graph.inferenceClassification")]
    [ResourceTypePropertyName("inferenceClassificationODataType")]
    public class Update_DirectoryObjects_InferenceClassification : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.directoryObject&quot; object in the &quot;directoryObjects&quot; collection.</para>
        /// </summary>
        [Selectable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.directoryObject&quot; object in the &quot;directoryObjects&quot; collection.")]
        public System.String directoryObjectId { get; set; }

        /// <summary>
        ///     <para type="description">A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.directoryObject&quot; objects.</para>
        ///     <para type="description">
        ///          Valid values: &apos;microsoft.graph.directoryObject&apos;, &apos;microsoft.graph.administrativeUnit&apos;, &apos;microsoft.graph.groupSettingTemplate&apos;, &apos;microsoft.graph.user&apos;, &apos;microsoft.graph.organization&apos;, &apos;microsoft.graph.contract&apos;, &apos;microsoft.graph.group&apos;, &apos;microsoft.graph.directoryRoleTemplate&apos;, &apos;microsoft.graph.directoryRole&apos;, &apos;microsoft.graph.device&apos;
        ///     </para>
        /// </summary>
        [Selectable]
        [ValidateSet(@"microsoft.graph.directoryObject", @"microsoft.graph.administrativeUnit", @"microsoft.graph.groupSettingTemplate", @"microsoft.graph.user", @"microsoft.graph.organization", @"microsoft.graph.contract", @"microsoft.graph.group", @"microsoft.graph.directoryRoleTemplate", @"microsoft.graph.directoryRole", @"microsoft.graph.device")]
        [TypeCastParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required type cast for referencing properties that exist only on certain types of &quot;microsoft.graph.directoryObject&quot; objects.")]
        public System.String directoryObjectODataType { get; set; }

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
            return $"directoryObjects/{directoryObjectId}/{directoryObjectODataType}/inferenceClassification";
        }
    }
}