// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.vppToken&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.vppToken&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">You purchase multiple licenses for iOS apps through the Apple Volume Purchase Program for Business or Education. This involves setting up an Apple VPP account from the Apple website and uploading the Apple VPP Business or Education token to Intune. You can then synchronize your volume purchase information with Intune and track your volume-purchased app use. You can upload multiple Apple VPP Business or Education tokens.</para>
    /// </summary>
    [Cmdlet("New", "VppTokenObject", DefaultParameterSetName = @"#microsoft.graph.vppToken")]
    [ODataType("microsoft.graph.vppToken")]
    public class New_VppTokenObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;organizationName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.vppToken&quot; type.</para>
        ///     <para type="description">The organization associated with the Apple Volume Purchase Program Token</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.vppToken", HelpMessage = @"The &quot;organizationName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String OrganizationName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;vppTokenAccountType&quot; property, of type &quot;microsoft.graph.vppTokenAccountType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.vppToken&quot; type.</para>
        ///     <para type="description">The type of volume purchase program which the given Apple Volume Purchase Program Token is associated with. Possible values are: `business`, `education`.</para>
        ///     <para type="description">
        ///          Valid values: &apos;business&apos;, &apos;education&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.vppTokenAccountType")]
        [Selectable]
        [ValidateSet(@"business", @"education")]
        [Parameter(ParameterSetName = @"#microsoft.graph.vppToken", HelpMessage = @"The &quot;vppTokenAccountType&quot; property, of type &quot;microsoft.graph.vppTokenAccountType&quot;.")]
        public System.String VppTokenAccountType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appleId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.vppToken&quot; type.</para>
        ///     <para type="description">The apple Id associated with the given Apple Volume Purchase Program Token.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.vppToken", HelpMessage = @"The &quot;appleId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String AppleId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.vppToken&quot; type.</para>
        ///     <para type="description">The expiration date time of the Apple Volume Purchase Program Token.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.vppToken", HelpMessage = @"The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset ExpirationDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.vppToken&quot; type.</para>
        ///     <para type="description">The last time when an application sync was done with the Apple volume purchase program service using the the Apple Volume Purchase Program Token.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.vppToken", HelpMessage = @"The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset LastSyncDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;token&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.vppToken&quot; type.</para>
        ///     <para type="description">The Apple Volume Purchase Program Token string downloaded from the Apple Volume Purchase Program.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.vppToken", HelpMessage = @"The &quot;token&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Token { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.vppToken&quot; type.</para>
        ///     <para type="description">Last modification date time associated with the Apple Volume Purchase Program Token.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.vppToken", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset LastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;state&quot; property, of type &quot;microsoft.graph.vppTokenState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.vppToken&quot; type.</para>
        ///     <para type="description">Current state of the Apple Volume Purchase Program Token. Possible values are: `unknown`, `valid`, `expired`, `invalid`.</para>
        ///     <para type="description">
        ///          Valid values: &apos;unknown&apos;, &apos;valid&apos;, &apos;expired&apos;, &apos;invalid&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.vppTokenState")]
        [Selectable]
        [ValidateSet(@"unknown", @"valid", @"expired", @"invalid")]
        [Parameter(ParameterSetName = @"#microsoft.graph.vppToken", HelpMessage = @"The &quot;state&quot; property, of type &quot;microsoft.graph.vppTokenState&quot;.")]
        public System.String State { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastSyncStatus&quot; property, of type &quot;microsoft.graph.vppTokenSyncStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.vppToken&quot; type.</para>
        ///     <para type="description">Current sync status of the last application sync which was triggered using the Apple Volume Purchase Program Token. Possible values are: `none`, `inProgress`, `completed`, `failed`.</para>
        ///     <para type="description">
        ///          Valid values: &apos;none&apos;, &apos;inProgress&apos;, &apos;completed&apos;, &apos;failed&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.vppTokenSyncStatus")]
        [Selectable]
        [ValidateSet(@"none", @"inProgress", @"completed", @"failed")]
        [Parameter(ParameterSetName = @"#microsoft.graph.vppToken", HelpMessage = @"The &quot;lastSyncStatus&quot; property, of type &quot;microsoft.graph.vppTokenSyncStatus&quot;.")]
        public System.String LastSyncStatus { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;automaticallyUpdateApps&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.vppToken&quot; type.</para>
        ///     <para type="description">Whether or not apps for the VPP token will be automatically updated.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.vppToken", HelpMessage = @"The &quot;automaticallyUpdateApps&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean AutomaticallyUpdateApps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;countryOrRegion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.vppToken&quot; type.</para>
        ///     <para type="description">Whether or not apps for the VPP token will be automatically updated.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.vppToken", HelpMessage = @"The &quot;countryOrRegion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String CountryOrRegion { get; set; }
    }
}