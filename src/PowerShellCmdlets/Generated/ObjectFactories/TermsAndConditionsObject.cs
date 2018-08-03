// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.termsAndConditions&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.termsAndConditions&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">A termsAndConditions entity represents the metadata and contents of a given Terms and Conditions (T&amp;C) policy. T&amp;C policies’ contents are presented to users upon their first attempt to enroll into Intune and subsequently upon edits where an administrator has required re-acceptance. They enable administrators to communicate the provisions to which a user must agree in order to have devices enrolled into Intune.</para>
    /// </summary>
    [Cmdlet("New", "TermsAndConditionsObject", DefaultParameterSetName = @"#microsoft.graph.termsAndConditions")]
    [ODataType("microsoft.graph.termsAndConditions")]
    public class New_TermsAndConditionsObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditions&quot; type.</para>
        ///     <para type="description">DateTime the object was created.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.termsAndConditions", HelpMessage = @"The &quot;createdDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset CreatedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditions&quot; type.</para>
        ///     <para type="description">DateTime the object was last modified.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.termsAndConditions", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset LastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditions&quot; type.</para>
        ///     <para type="description">Administrator-supplied name for the T&amp;C policy. </para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.termsAndConditions", HelpMessage = @"The &quot;displayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String DisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;description&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditions&quot; type.</para>
        ///     <para type="description">Administrator-supplied description of the T&amp;C policy.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.termsAndConditions", HelpMessage = @"The &quot;description&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Description { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;title&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditions&quot; type.</para>
        ///     <para type="description">Administrator-supplied title of the terms and conditions. This is shown to the user on prompts to accept the T&amp;C policy.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.termsAndConditions", HelpMessage = @"The &quot;title&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Title { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;bodyText&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditions&quot; type.</para>
        ///     <para type="description">Administrator-supplied body text of the terms and conditions, typically the terms themselves. This is shown to the user on prompts to accept the T&amp;C policy.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.termsAndConditions", HelpMessage = @"The &quot;bodyText&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String BodyText { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;acceptanceStatement&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditions&quot; type.</para>
        ///     <para type="description">Administrator-supplied explanation of the terms and conditions, typically describing what it means to accept the terms and conditions set out in the T&amp;C policy. This is shown to the user on prompts to accept the T&amp;C policy.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.termsAndConditions", HelpMessage = @"The &quot;acceptanceStatement&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String AcceptanceStatement { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditions&quot; type.</para>
        ///     <para type="description">Integer indicating the current version of the terms. Incremented when an administrator makes a change to the terms and wishes to require users to re-accept the modified T&amp;C policy.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.termsAndConditions", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 Version { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;assignments&quot; property, of type &quot;microsoft.graph.termsAndConditionsAssignment&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditions&quot; type.</para>
        ///     <para type="description">The list of assignments for this T&amp;C policy.</para>
        /// </summary>
        [ODataType("microsoft.graph.termsAndConditionsAssignment")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.termsAndConditions", HelpMessage = @"The &quot;assignments&quot; property, of type &quot;microsoft.graph.termsAndConditionsAssignment&quot;.")]
        public System.Object[] Assignments { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;acceptanceStatuses&quot; property, of type &quot;microsoft.graph.termsAndConditionsAcceptanceStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditions&quot; type.</para>
        ///     <para type="description">The list of acceptance statuses for this T&amp;C policy.</para>
        /// </summary>
        [ODataType("microsoft.graph.termsAndConditionsAcceptanceStatus")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"#microsoft.graph.termsAndConditions", HelpMessage = @"The &quot;acceptanceStatuses&quot; property, of type &quot;microsoft.graph.termsAndConditionsAcceptanceStatus&quot;.")]
        public System.Object[] AcceptanceStatuses { get; set; }
    }
}