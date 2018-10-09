// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.edgeSearchEngineBase&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.edgeSearchEngineBase&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "EdgeSearchEngineBaseObject", DefaultParameterSetName = @"microsoft.graph.edgeSearchEngineBase")]
    [ODataType("microsoft.graph.edgeSearchEngineBase")]
    public class New_EdgeSearchEngineBaseObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.edgeSearchEngine&quot; type.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [ParameterSetSelector(@"microsoft.graph.edgeSearchEngine")]
        [Parameter(ParameterSetName = @"microsoft.graph.edgeSearchEngine", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.edgeSearchEngine&quot; type.")]
        public System.Management.Automation.SwitchParameter edgeSearchEngine { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;edgeSearchEngineType&quot; property, of type &quot;microsoft.graph.edgeSearchEngineType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.edgeSearchEngine&quot; type.</para>
        ///     <para type="description">Allows IT admins to set a predefined default search engine for MDM-Controlled devices.</para>
        ///     <para type="description">
        ///          Valid values: &apos;default&apos;, &apos;bing&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.edgeSearchEngineType")]
        [Selectable]
        [ValidateSet(@"default", @"bing")]
        [Parameter(ParameterSetName = @"microsoft.graph.edgeSearchEngine", HelpMessage = @"The &quot;edgeSearchEngineType&quot; property, of type &quot;microsoft.graph.edgeSearchEngineType&quot;.")]
        public System.String edgeSearchEngineType { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.edgeSearchEngineCustom&quot; type.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [ParameterSetSelector(@"microsoft.graph.edgeSearchEngineCustom")]
        [Parameter(ParameterSetName = @"microsoft.graph.edgeSearchEngineCustom", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.edgeSearchEngineCustom&quot; type.")]
        public System.Management.Automation.SwitchParameter edgeSearchEngineCustom { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;edgeSearchEngineOpenSearchXmlUrl&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.edgeSearchEngineCustom&quot; type.</para>
        ///     <para type="description">Points to a https link containing the OpenSearch xml file that contains, at minimum, the short name and the URL to the search Engine.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.edgeSearchEngineCustom", HelpMessage = @"The &quot;edgeSearchEngineOpenSearchXmlUrl&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String edgeSearchEngineOpenSearchXmlUrl { get; set; }
    }
}