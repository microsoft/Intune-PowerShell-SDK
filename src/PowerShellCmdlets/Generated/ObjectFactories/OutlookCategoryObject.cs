// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.outlookCategory&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.outlookCategory&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "OutlookCategoryObject", DefaultParameterSetName = @"#microsoft.graph.outlookCategory")]
    [ODataType("microsoft.graph.outlookCategory")]
    public class New_OutlookCategoryObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.outlookCategory&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.outlookCategory", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;color&quot; property, of type &quot;microsoft.graph.categoryColor&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.outlookCategory&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;preset0&apos;, &apos;preset1&apos;, &apos;preset2&apos;, &apos;preset3&apos;, &apos;preset4&apos;, &apos;preset5&apos;, &apos;preset6&apos;, &apos;preset7&apos;, &apos;preset8&apos;, &apos;preset9&apos;, &apos;preset10&apos;, &apos;preset11&apos;, &apos;preset12&apos;, &apos;preset13&apos;, &apos;preset14&apos;, &apos;preset15&apos;, &apos;preset16&apos;, &apos;preset17&apos;, &apos;preset18&apos;, &apos;preset19&apos;, &apos;preset20&apos;, &apos;preset21&apos;, &apos;preset22&apos;, &apos;preset23&apos;, &apos;preset24&apos;, &apos;none&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.categoryColor")]
        [Selectable]
        [ValidateSet(@"preset0", @"preset1", @"preset2", @"preset3", @"preset4", @"preset5", @"preset6", @"preset7", @"preset8", @"preset9", @"preset10", @"preset11", @"preset12", @"preset13", @"preset14", @"preset15", @"preset16", @"preset17", @"preset18", @"preset19", @"preset20", @"preset21", @"preset22", @"preset23", @"preset24", @"none")]
        [Parameter(ParameterSetName = @"#microsoft.graph.outlookCategory", HelpMessage = @"The &quot;color&quot; property, of type &quot;microsoft.graph.categoryColor&quot;.")]
        public System.String color { get; set; }
    }
}