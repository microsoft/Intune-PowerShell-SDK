// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.vppToken&quot; objects.</para>
    ///     <para type="description">GET ~/deviceAppManagement/vppTokens</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.vppToken&quot; objects in the &quot;vppTokens&quot; collection.</para>
    ///     <para type="description">List of Vpp tokens for this organization.</para>
    /// </summary>
    [Cmdlet("Get", "DeviceAppManagement_VppTokens", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.vppToken")]
    [ResourceIdPropertyName("VppTokenId")]
    [ResourceReference]
    public class Get_DeviceAppManagement_VppTokens : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.vppToken&quot; object in the &quot;vppTokens&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.vppToken&quot; object in the &quot;vppTokens&quot; collection.")]
        public System.String VppTokenId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;organizationName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.vppToken&quot; type.</para>
        ///     <para type="description">The organization associated with the Apple Volume Purchase Program Token</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String OrganizationName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;vppTokenAccountType&quot; property, of type &quot;microsoft.graph.vppTokenAccountType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.vppToken&quot; type.</para>
        ///     <para type="description">The type of volume purchase program which the given Apple Volume Purchase Program Token is associated with. Possible values are: `business`, `education`.</para>
        /// </summary>
        [ODataType("microsoft.graph.vppTokenAccountType")]
        [Selectable]
        [Sortable]
        public System.String VppTokenAccountType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appleId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.vppToken&quot; type.</para>
        ///     <para type="description">The apple Id associated with the given Apple Volume Purchase Program Token.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String AppleId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.vppToken&quot; type.</para>
        ///     <para type="description">The expiration date time of the Apple Volume Purchase Program Token.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset ExpirationDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.vppToken&quot; type.</para>
        ///     <para type="description">The last time when an application sync was done with the Apple volume purchase program service using the the Apple Volume Purchase Program Token.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset LastSyncDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;token&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.vppToken&quot; type.</para>
        ///     <para type="description">The Apple Volume Purchase Program Token string downloaded from the Apple Volume Purchase Program.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String Token { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.vppToken&quot; type.</para>
        ///     <para type="description">Last modification date time associated with the Apple Volume Purchase Program Token.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset LastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;state&quot; property, of type &quot;microsoft.graph.vppTokenState&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.vppToken&quot; type.</para>
        ///     <para type="description">Current state of the Apple Volume Purchase Program Token. Possible values are: `unknown`, `valid`, `expired`, `invalid`.</para>
        /// </summary>
        [ODataType("microsoft.graph.vppTokenState")]
        [Selectable]
        [Sortable]
        public System.String State { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastSyncStatus&quot; property, of type &quot;microsoft.graph.vppTokenSyncStatus&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.vppToken&quot; type.</para>
        ///     <para type="description">Current sync status of the last application sync which was triggered using the Apple Volume Purchase Program Token. Possible values are: `none`, `inProgress`, `completed`, `failed`.</para>
        /// </summary>
        [ODataType("microsoft.graph.vppTokenSyncStatus")]
        [Selectable]
        [Sortable]
        public System.String LastSyncStatus { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;automaticallyUpdateApps&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.vppToken&quot; type.</para>
        ///     <para type="description">Whether or not apps for the VPP token will be automatically updated.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean AutomaticallyUpdateApps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;countryOrRegion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.vppToken&quot; type.</para>
        ///     <para type="description">Whether or not apps for the VPP token will be automatically updated.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String CountryOrRegion { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;id&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.vppToken&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String Id { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/vppTokens/{VppTokenId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.vppToken&quot; object.</para>
    ///     <para type="description">POST ~/deviceAppManagement/vppTokens</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.vppToken&quot; object to the &quot;vppTokens&quot; collection.</para>
    ///     <para type="description">List of Vpp tokens for this organization.</para>
    /// </summary>
    [Cmdlet("New", "DeviceAppManagement_VppTokens", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.vppToken")]
    [ODataType("microsoft.graph.vppToken")]
    [ResourceReference]
    public class New_DeviceAppManagement_VppTokens : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;organizationName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.vppToken&quot; type.</para>
        ///     <para type="description">The organization associated with the Apple Volume Purchase Program Token</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.vppToken", HelpMessage = @"The &quot;organizationName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;organizationName&quot; property, of type &quot;Edm.String&quot;.")]
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
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;vppTokenAccountType&quot; property, of type &quot;microsoft.graph.vppTokenAccountType&quot;.")]
        public System.String VppTokenAccountType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appleId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.vppToken&quot; type.</para>
        ///     <para type="description">The apple Id associated with the given Apple Volume Purchase Program Token.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.vppToken", HelpMessage = @"The &quot;appleId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;appleId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String AppleId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.vppToken&quot; type.</para>
        ///     <para type="description">The expiration date time of the Apple Volume Purchase Program Token.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.vppToken", HelpMessage = @"The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset ExpirationDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.vppToken&quot; type.</para>
        ///     <para type="description">The last time when an application sync was done with the Apple volume purchase program service using the the Apple Volume Purchase Program Token.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.vppToken", HelpMessage = @"The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset LastSyncDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;token&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.vppToken&quot; type.</para>
        ///     <para type="description">The Apple Volume Purchase Program Token string downloaded from the Apple Volume Purchase Program.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.vppToken", HelpMessage = @"The &quot;token&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;token&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Token { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.vppToken&quot; type.</para>
        ///     <para type="description">Last modification date time associated with the Apple Volume Purchase Program Token.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.vppToken", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
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
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;state&quot; property, of type &quot;microsoft.graph.vppTokenState&quot;.")]
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
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastSyncStatus&quot; property, of type &quot;microsoft.graph.vppTokenSyncStatus&quot;.")]
        public System.String LastSyncStatus { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;automaticallyUpdateApps&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.vppToken&quot; type.</para>
        ///     <para type="description">Whether or not apps for the VPP token will be automatically updated.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.vppToken", HelpMessage = @"The &quot;automaticallyUpdateApps&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;automaticallyUpdateApps&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean AutomaticallyUpdateApps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;countryOrRegion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.vppToken&quot; type.</para>
        ///     <para type="description">Whether or not apps for the VPP token will be automatically updated.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.vppToken", HelpMessage = @"The &quot;countryOrRegion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;countryOrRegion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String CountryOrRegion { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/vppTokens";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.vppToken&quot;.</para>
    ///     <para type="description">PATCH ~/deviceAppManagement/vppTokens</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.vppToken&quot; object in the &quot;vppTokens&quot; collection.</para>
    ///     <para type="description">List of Vpp tokens for this organization.</para>
    /// </summary>
    [Cmdlet("Update", "DeviceAppManagement_VppTokens", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.vppToken")]
    [ODataType("microsoft.graph.vppToken")]
    [ResourceIdPropertyName("VppTokenId")]
    public class Update_DeviceAppManagement_VppTokens : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.vppToken&quot; object in the &quot;vppTokens&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.vppToken&quot; object in the &quot;vppTokens&quot; collection.")]
        public System.String VppTokenId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;organizationName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.vppToken&quot; type.</para>
        ///     <para type="description">The organization associated with the Apple Volume Purchase Program Token</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.vppToken", HelpMessage = @"The &quot;organizationName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;organizationName&quot; property, of type &quot;Edm.String&quot;.")]
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
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;vppTokenAccountType&quot; property, of type &quot;microsoft.graph.vppTokenAccountType&quot;.")]
        public System.String VppTokenAccountType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appleId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.vppToken&quot; type.</para>
        ///     <para type="description">The apple Id associated with the given Apple Volume Purchase Program Token.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.vppToken", HelpMessage = @"The &quot;appleId&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;appleId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String AppleId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.vppToken&quot; type.</para>
        ///     <para type="description">The expiration date time of the Apple Volume Purchase Program Token.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.vppToken", HelpMessage = @"The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset ExpirationDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.vppToken&quot; type.</para>
        ///     <para type="description">The last time when an application sync was done with the Apple volume purchase program service using the the Apple Volume Purchase Program Token.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.vppToken", HelpMessage = @"The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastSyncDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset LastSyncDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;token&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.vppToken&quot; type.</para>
        ///     <para type="description">The Apple Volume Purchase Program Token string downloaded from the Apple Volume Purchase Program.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.vppToken", HelpMessage = @"The &quot;token&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;token&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Token { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.vppToken&quot; type.</para>
        ///     <para type="description">Last modification date time associated with the Apple Volume Purchase Program Token.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.vppToken", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
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
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;state&quot; property, of type &quot;microsoft.graph.vppTokenState&quot;.")]
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
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastSyncStatus&quot; property, of type &quot;microsoft.graph.vppTokenSyncStatus&quot;.")]
        public System.String LastSyncStatus { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;automaticallyUpdateApps&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.vppToken&quot; type.</para>
        ///     <para type="description">Whether or not apps for the VPP token will be automatically updated.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.vppToken", HelpMessage = @"The &quot;automaticallyUpdateApps&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;automaticallyUpdateApps&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean AutomaticallyUpdateApps { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;countryOrRegion&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.vppToken&quot; type.</para>
        ///     <para type="description">Whether or not apps for the VPP token will be automatically updated.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.vppToken", HelpMessage = @"The &quot;countryOrRegion&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;countryOrRegion&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String CountryOrRegion { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/vppTokens/{VppTokenId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.vppToken&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceAppManagement/vppTokens/VppTokenId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.vppToken&quot; object from the &quot;vppTokens&quot; collection.</para>
    ///     <para type="description">List of Vpp tokens for this organization.</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceAppManagement_VppTokens", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.vppToken")]
    [ResourceIdPropertyName("VppTokenId")]
    public class Remove_DeviceAppManagement_VppTokens : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.vppToken&quot; object in the &quot;vppTokens&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.vppToken&quot; object in the &quot;vppTokens&quot; collection.")]
        public System.String VppTokenId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/vppTokens/{VppTokenId}";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/deviceAppManagement/vppTokens/syncLicenses</para>
    ///     <para type="description">The action &quot;microsoft.graph.syncLicenses&quot;, which exists on the type &quot;microsoft.graph.vppToken&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.vppToken&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "DeviceAppManagement_VppTokens_SyncLicenses", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.vppToken")]
    [ResourceIdPropertyName("VppTokenId")]
    public class Invoke_DeviceAppManagement_VppTokens_SyncLicenses : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.vppToken&quot; object in the &quot;vppTokens&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Alias("Id")]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.vppToken&quot; object in the &quot;vppTokens&quot; collection.")]
        public System.String VppTokenId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceAppManagement/vppTokens/{VppTokenId}/syncLicenses";
        }
    }
}