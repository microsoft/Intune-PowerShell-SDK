// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.termsAndConditionsAcceptanceStatus&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.termsAndConditionsAcceptanceStatus&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">A termsAndConditionsAcceptanceStatus entity represents the acceptance status of a given Terms and Conditions (T&amp;C) policy by a given user. Users must accept the most up-to-date version of the terms in order to retain access to the Company Portal.</para>
    /// </summary>
    [Cmdlet("New", "TermsAndConditionsAcceptanceStatusObject", DefaultParameterSetName = @"#microsoft.graph.termsAndConditionsAcceptanceStatus")]
    [ODataType("microsoft.graph.termsAndConditionsAcceptanceStatus")]
    public class New_TermsAndConditionsAcceptanceStatusObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;userDisplayName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditionsAcceptanceStatus&quot; type.</para>
        ///     <para type="description">Display name of the user whose acceptance the entity represents.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.termsAndConditionsAcceptanceStatus", HelpMessage = @"The &quot;userDisplayName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String userDisplayName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;acceptedVersion&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditionsAcceptanceStatus&quot; type.</para>
        ///     <para type="description">Most recent version number of the T&amp;C accepted by the user.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.termsAndConditionsAcceptanceStatus", HelpMessage = @"The &quot;acceptedVersion&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 acceptedVersion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;acceptedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditionsAcceptanceStatus&quot; type.</para>
        ///     <para type="description">DateTime when the terms were last accepted by the user.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.termsAndConditionsAcceptanceStatus", HelpMessage = @"The &quot;acceptedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset acceptedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;termsAndConditions&quot; property, of type &quot;microsoft.graph.termsAndConditions&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.termsAndConditionsAcceptanceStatus&quot; type.</para>
        ///     <para type="description">Navigation link to the terms and conditions that are assigned.</para>
        /// </summary>
        [ODataType("microsoft.graph.termsAndConditions")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.termsAndConditionsAcceptanceStatus", HelpMessage = @"The &quot;termsAndConditions&quot; property, of type &quot;microsoft.graph.termsAndConditions&quot;.")]
        public System.Object termsAndConditions { get; set; }
    }
}