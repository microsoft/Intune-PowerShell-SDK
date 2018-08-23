// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.educationTeacher&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.educationTeacher&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "EducationTeacherObject", DefaultParameterSetName = @"microsoft.graph.educationTeacher")]
    [ODataType("microsoft.graph.educationTeacher")]
    public class New_EducationTeacherObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;teacherNumber&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationTeacher&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.educationTeacher", HelpMessage = @"The &quot;teacherNumber&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String teacherNumber { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;externalId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationTeacher&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.educationTeacher", HelpMessage = @"The &quot;externalId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String externalId { get; set; }
    }
}