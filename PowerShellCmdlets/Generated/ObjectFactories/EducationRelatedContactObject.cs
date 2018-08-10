// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.educationRelatedContact&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.educationRelatedContact&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "EducationRelatedContactObject", DefaultParameterSetName = @"#microsoft.graph.educationRelatedContact")]
    [ODataType("microsoft.graph.educationRelatedContact")]
    public class New_EducationRelatedContactObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationRelatedContact&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationRelatedContact", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String displayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;emailAddress&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationRelatedContact&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationRelatedContact", HelpMessage = @"The &quot;emailAddress&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String emailAddress { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mobilePhone&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationRelatedContact&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationRelatedContact", HelpMessage = @"The &quot;mobilePhone&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String mobilePhone { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;relationship&quot; property, of type &quot;microsoft.graph.educationContactRelationship&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationRelatedContact&quot; type.</para>
        ///     <para type="description">
        ///          Valid values: &apos;parent&apos;, &apos;relative&apos;, &apos;aide&apos;, &apos;doctor&apos;, &apos;guardian&apos;, &apos;child&apos;, &apos;other&apos;, &apos;unknownFutureValue&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.educationContactRelationship")]
        [Selectable]
        [ValidateSet(@"parent", @"relative", @"aide", @"doctor", @"guardian", @"child", @"other", @"unknownFutureValue")]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationRelatedContact", HelpMessage = @"The &quot;relationship&quot; property, of type &quot;microsoft.graph.educationContactRelationship&quot;.")]
        public System.String relationship { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;accessConsent&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.educationRelatedContact&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.educationRelatedContact", HelpMessage = @"The &quot;accessConsent&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean accessConsent { get; set; }
    }
}