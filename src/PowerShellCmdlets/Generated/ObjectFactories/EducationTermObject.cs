// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.educationTerm&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.educationTerm&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "EducationTermObject", DefaultParameterSetName = @"#microsoft.graph.educationTerm")]
    [ODataType("microsoft.graph.educationTerm")]
    public class New_EducationTermObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;externalId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationTerm&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationTerm", HelpMessage = @"The &quot;externalId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String ExternalId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;startDate&quot; property, of type &quot;Edm.Date&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationTerm&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Date")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationTerm", HelpMessage = @"The &quot;startDate&quot; property, of type &quot;Edm.Date&quot;.")]
        public System.DateTimeOffset StartDate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;endDate&quot; property, of type &quot;Edm.Date&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationTerm&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Date")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationTerm", HelpMessage = @"The &quot;endDate&quot; property, of type &quot;Edm.Date&quot;.")]
        public System.DateTimeOffset EndDate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationTerm&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationTerm", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DisplayName { get; set; }
    }
}