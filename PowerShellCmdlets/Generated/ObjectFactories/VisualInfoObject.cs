// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.visualInfo&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.visualInfo&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "VisualInfoObject", DefaultParameterSetName = @"microsoft.graph.visualInfo")]
    [ODataType("microsoft.graph.visualInfo")]
    public class New_VisualInfoObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;attribution&quot; property, of type &quot;microsoft.graph.imageInfo&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.visualInfo&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.imageInfo")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.visualInfo", HelpMessage = @"The &quot;attribution&quot; property, of type &quot;microsoft.graph.imageInfo&quot;.")]
        public System.Object attribution { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;backgroundColor&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.visualInfo&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.visualInfo", HelpMessage = @"The &quot;backgroundColor&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String backgroundColor { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.visualInfo&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.visualInfo", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayText&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.visualInfo&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.visualInfo", HelpMessage = @"The &quot;displayText&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayText { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;content&quot; property, of type &quot;microsoft.graph.Json&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.visualInfo&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.visualInfo", HelpMessage = @"The &quot;content&quot; property, of type &quot;microsoft.graph.Json&quot;.")]
        public System.Object content { get; set; }
    }
}