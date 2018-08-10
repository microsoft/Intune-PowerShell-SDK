// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.plannerCategoryDescriptions&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.plannerCategoryDescriptions&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "PlannerCategoryDescriptionsObject", DefaultParameterSetName = @"#microsoft.graph.plannerCategoryDescriptions")]
    [ODataType("microsoft.graph.plannerCategoryDescriptions")]
    public class New_PlannerCategoryDescriptionsObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;category1&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerCategoryDescriptions&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerCategoryDescriptions", HelpMessage = @"The &quot;category1&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String category1 { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;category2&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerCategoryDescriptions&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerCategoryDescriptions", HelpMessage = @"The &quot;category2&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String category2 { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;category3&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerCategoryDescriptions&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerCategoryDescriptions", HelpMessage = @"The &quot;category3&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String category3 { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;category4&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerCategoryDescriptions&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerCategoryDescriptions", HelpMessage = @"The &quot;category4&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String category4 { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;category5&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerCategoryDescriptions&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerCategoryDescriptions", HelpMessage = @"The &quot;category5&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String category5 { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;category6&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerCategoryDescriptions&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerCategoryDescriptions", HelpMessage = @"The &quot;category6&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String category6 { get; set; }
    }
}