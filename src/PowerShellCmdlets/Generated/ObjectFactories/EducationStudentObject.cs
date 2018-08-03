// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.educationStudent&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.educationStudent&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "EducationStudentObject", DefaultParameterSetName = @"#microsoft.graph.educationStudent")]
    [ODataType("microsoft.graph.educationStudent")]
    public class New_EducationStudentObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;graduationYear&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationStudent&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationStudent", HelpMessage = @"The &quot;graduationYear&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String GraduationYear { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;grade&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationStudent&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationStudent", HelpMessage = @"The &quot;grade&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Grade { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;birthDate&quot; property, of type &quot;Edm.Date&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationStudent&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Date")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationStudent", HelpMessage = @"The &quot;birthDate&quot; property, of type &quot;Edm.Date&quot;.")]
        public System.DateTimeOffset BirthDate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;gender&quot; property, of type &quot;microsoft.graph.educationGender&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationStudent&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;female&apos;, &apos;male&apos;, &apos;other&apos;, &apos;unknownFutureValue&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.educationGender")]
        [Selectable]
        [ValidateSet(@"female", @"male", @"other", @"unknownFutureValue")]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationStudent", HelpMessage = @"The &quot;gender&quot; property, of type &quot;microsoft.graph.educationGender&quot;.")]
        public System.String Gender { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;studentNumber&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationStudent&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationStudent", HelpMessage = @"The &quot;studentNumber&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String StudentNumber { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;externalId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationStudent&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationStudent", HelpMessage = @"The &quot;externalId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String ExternalId { get; set; }
    }
}