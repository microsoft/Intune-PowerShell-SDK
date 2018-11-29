// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; objects.</para>
    ///     <para type="description">GET ~/deviceManagement/windowsInformationProtectionNetworkLearningSummaries</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; objects in the &quot;windowsInformationProtectionNetworkLearningSummaries&quot; collection.</para>
    ///     <para type="description">The windows information protection network learning summaries.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Get", "IntuneWindowsInformationProtectionNetworkLearningSummary", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.windowsInformationProtectionNetworkLearningSummary")]
    [ResourceTypePropertyName("windowsInformationProtectionNetworkLearningSummaryODataType")]
    [ResourceReference]
    public class Get_IntuneWindowsInformationProtectionNetworkLearningSummary : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; object in the &quot;windowsInformationProtectionNetworkLearningSummaries&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; object in the &quot;windowsInformationProtectionNetworkLearningSummaries&quot; collection.")]
        public System.String windowsInformationProtectionNetworkLearningSummaryId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;url&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; type.</para>
        ///     <para type="description">Website url</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String url { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; type.</para>
        ///     <para type="description">Device Count</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 deviceCount { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/windowsInformationProtectionNetworkLearningSummaries/{windowsInformationProtectionNetworkLearningSummaryId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; object.</para>
    ///     <para type="description">POST ~/deviceManagement/windowsInformationProtectionNetworkLearningSummaries</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; object to the &quot;windowsInformationProtectionNetworkLearningSummaries&quot; collection.</para>
    ///     <para type="description">The windows information protection network learning summaries.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("New", "IntuneWindowsInformationProtectionNetworkLearningSummary", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.windowsInformationProtectionNetworkLearningSummary")]
    [ODataType("microsoft.graph.windowsInformationProtectionNetworkLearningSummary")]
    [ResourceTypePropertyName("windowsInformationProtectionNetworkLearningSummaryODataType")]
    [ResourceReference]
    public class New_IntuneWindowsInformationProtectionNetworkLearningSummary : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; object in the &quot;windowsInformationProtectionNetworkLearningSummaries&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        public System.String windowsInformationProtectionNetworkLearningSummaryId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;url&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; type.</para>
        ///     <para type="description">Website url</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionNetworkLearningSummary", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;url&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;url&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String url { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; type.</para>
        ///     <para type="description">Device Count</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionNetworkLearningSummary", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 deviceCount { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/windowsInformationProtectionNetworkLearningSummaries/{windowsInformationProtectionNetworkLearningSummaryId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot;.</para>
    ///     <para type="description">PATCH ~/deviceManagement/windowsInformationProtectionNetworkLearningSummaries</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; object in the &quot;windowsInformationProtectionNetworkLearningSummaries&quot; collection.</para>
    ///     <para type="description">The windows information protection network learning summaries.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Update", "IntuneWindowsInformationProtectionNetworkLearningSummary", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.windowsInformationProtectionNetworkLearningSummary")]
    [ODataType("microsoft.graph.windowsInformationProtectionNetworkLearningSummary")]
    [ResourceTypePropertyName("windowsInformationProtectionNetworkLearningSummaryODataType")]
    public class Update_IntuneWindowsInformationProtectionNetworkLearningSummary : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; object in the &quot;windowsInformationProtectionNetworkLearningSummaries&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; object in the &quot;windowsInformationProtectionNetworkLearningSummaries&quot; collection.")]
        public System.String windowsInformationProtectionNetworkLearningSummaryId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;url&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; type.</para>
        ///     <para type="description">Website url</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionNetworkLearningSummary", HelpMessage = @"The &quot;url&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;url&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String url { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; type.</para>
        ///     <para type="description">Device Count</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionNetworkLearningSummary", HelpMessage = @"The &quot;deviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 deviceCount { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/windowsInformationProtectionNetworkLearningSummaries/{windowsInformationProtectionNetworkLearningSummaryId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceManagement/windowsInformationProtectionNetworkLearningSummaries/windowsInformationProtectionNetworkLearningSummaryId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; object from the &quot;windowsInformationProtectionNetworkLearningSummaries&quot; collection.</para>
    ///     <para type="description">The windows information protection network learning summaries.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Remove", "IntuneWindowsInformationProtectionNetworkLearningSummary", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.windowsInformationProtectionNetworkLearningSummary")]
    [ResourceTypePropertyName("windowsInformationProtectionNetworkLearningSummaryODataType")]
    public class Remove_IntuneWindowsInformationProtectionNetworkLearningSummary : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; object in the &quot;windowsInformationProtectionNetworkLearningSummaries&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.windowsInformationProtectionNetworkLearningSummary&quot; object in the &quot;windowsInformationProtectionNetworkLearningSummaries&quot; collection.")]
        public System.String windowsInformationProtectionNetworkLearningSummaryId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/windowsInformationProtectionNetworkLearningSummaries/{windowsInformationProtectionNetworkLearningSummaryId}";
        }
    }
}