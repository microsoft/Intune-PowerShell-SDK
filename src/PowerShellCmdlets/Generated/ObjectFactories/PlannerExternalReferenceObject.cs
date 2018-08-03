// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.plannerExternalReference&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.plannerExternalReference&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "PlannerExternalReferenceObject", DefaultParameterSetName = @"#microsoft.graph.plannerExternalReference")]
    [ODataType("microsoft.graph.plannerExternalReference")]
    public class New_PlannerExternalReferenceObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;alias&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerExternalReference&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerExternalReference", HelpMessage = @"The &quot;alias&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Alias { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;type&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerExternalReference&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerExternalReference", HelpMessage = @"The &quot;type&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Type { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;previewPriority&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerExternalReference&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerExternalReference", HelpMessage = @"The &quot;previewPriority&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String PreviewPriority { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerExternalReference&quot; type.</para>
        /// </summary>
        [ODataType("microsoft.graph.identitySet")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerExternalReference", HelpMessage = @"The &quot;lastModifiedBy&quot; property, of type &quot;microsoft.graph.identitySet&quot;.")]
        public System.Object LastModifiedBy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.plannerExternalReference&quot; type.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.plannerExternalReference", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset LastModifiedDateTime { get; set; }
    }
}