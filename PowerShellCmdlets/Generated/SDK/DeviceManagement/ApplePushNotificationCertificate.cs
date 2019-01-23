// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves the &quot;applePushNotificationCertificate&quot; object.</para>
    ///     <para type="description">Retrieves the &quot;applePushNotificationCertificate&quot; object (which is of type &quot;microsoft.graph.applePushNotificationCertificate&quot;).</para>
    ///     <para type="description">Apple push notification certificate.</para>
    ///     <para type="description">Graph call: GET ~/deviceManagement/applePushNotificationCertificate</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Get", "IntuneApplePushNotificationCertificate", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.applePushNotificationCertificate")]
    [ResourceTypePropertyName("applePushNotificationCertificateODataType")]
    [ResourceReference]
    public class Get_IntuneApplePushNotificationCertificate : GetCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;appleIdentifier&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.applePushNotificationCertificate&quot; type.</para>
        ///     <para type="description">Apple Id of the account used to create the MDM push certificate.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String appleIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;topicIdentifier&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.applePushNotificationCertificate&quot; type.</para>
        ///     <para type="description">Topic Id.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String topicIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.applePushNotificationCertificate&quot; type.</para>
        ///     <para type="description">Last modified date and time for Apple push notification certificate.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.applePushNotificationCertificate&quot; type.</para>
        ///     <para type="description">The expiration date and time for Apple push notification certificate.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Sortable]
        public System.DateTimeOffset expirationDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;certificate&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.applePushNotificationCertificate&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String certificate { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/applePushNotificationCertificate";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.applePushNotificationCertificate&quot; object.</para>
    ///     <para type="description">Creates the &quot;applePushNotificationCertificate&quot; object (which is of type &quot;microsoft.graph.applePushNotificationCertificate&quot;).</para>
    ///     <para type="description">Apple push notification certificate.</para>
    ///     <para type="description">Graph call: POST ~/deviceManagement/applePushNotificationCertificate</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("New", "IntuneApplePushNotificationCertificate", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.applePushNotificationCertificate")]
    [ODataType("microsoft.graph.applePushNotificationCertificate")]
    [ResourceTypePropertyName("applePushNotificationCertificateODataType")]
    [ResourceReference]
    public class New_IntuneApplePushNotificationCertificate : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;appleIdentifier&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.applePushNotificationCertificate&quot; type.</para>
        ///     <para type="description">Apple Id of the account used to create the MDM push certificate.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.applePushNotificationCertificate", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;appleIdentifier&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;appleIdentifier&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String appleIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;topicIdentifier&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.applePushNotificationCertificate&quot; type.</para>
        ///     <para type="description">Topic Id.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.applePushNotificationCertificate", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;topicIdentifier&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;topicIdentifier&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String topicIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.applePushNotificationCertificate&quot; type.</para>
        ///     <para type="description">Last modified date and time for Apple push notification certificate.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.applePushNotificationCertificate", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.applePushNotificationCertificate&quot; type.</para>
        ///     <para type="description">The expiration date and time for Apple push notification certificate.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.applePushNotificationCertificate", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset expirationDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;certificate&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.applePushNotificationCertificate&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.applePushNotificationCertificate", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;certificate&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;certificate&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String certificate { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/applePushNotificationCertificate";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.applePushNotificationCertificate&quot;.</para>
    ///     <para type="description">Updates the &quot;applePushNotificationCertificate&quot; object (which is of type &quot;microsoft.graph.applePushNotificationCertificate&quot;).</para>
    ///     <para type="description">Apple push notification certificate.</para>
    ///     <para type="description">Graph Call: PATCH ~/deviceManagement/applePushNotificationCertificate</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Update", "IntuneApplePushNotificationCertificate", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.applePushNotificationCertificate")]
    [ODataType("microsoft.graph.applePushNotificationCertificate")]
    [ResourceTypePropertyName("applePushNotificationCertificateODataType")]
    public class Update_IntuneApplePushNotificationCertificate : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;appleIdentifier&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.applePushNotificationCertificate&quot; type.</para>
        ///     <para type="description">Apple Id of the account used to create the MDM push certificate.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.applePushNotificationCertificate", HelpMessage = @"The &quot;appleIdentifier&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;appleIdentifier&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String appleIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;topicIdentifier&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.applePushNotificationCertificate&quot; type.</para>
        ///     <para type="description">Topic Id.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.applePushNotificationCertificate", HelpMessage = @"The &quot;topicIdentifier&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;topicIdentifier&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String topicIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.applePushNotificationCertificate&quot; type.</para>
        ///     <para type="description">Last modified date and time for Apple push notification certificate.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.applePushNotificationCertificate", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.applePushNotificationCertificate&quot; type.</para>
        ///     <para type="description">The expiration date and time for Apple push notification certificate.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.applePushNotificationCertificate", HelpMessage = @"The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset expirationDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;certificate&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.applePushNotificationCertificate&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.applePushNotificationCertificate", HelpMessage = @"The &quot;certificate&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;certificate&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String certificate { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/applePushNotificationCertificate";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.applePushNotificationCertificate&quot; object.</para>
    ///     <para type="description">Removes the &quot;applePushNotificationCertificate&quot; object (which is of type &quot;microsoft.graph.applePushNotificationCertificate&quot;).</para>
    ///     <para type="description">Apple push notification certificate.</para>
    ///     <para type="description">Graph Call: DELETE ~/deviceManagement/applePushNotificationCertificate</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Remove", "IntuneApplePushNotificationCertificate", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.applePushNotificationCertificate")]
    [ResourceTypePropertyName("applePushNotificationCertificateODataType")]
    public class Remove_IntuneApplePushNotificationCertificate : DeleteCmdlet
    {
        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/applePushNotificationCertificate";
        }
    }

    /// <summary>
    ///     <para type="description">The function &quot;microsoft.graph.downloadApplePushNotificationCertificateSigningRequest&quot;, which exists on the type &quot;microsoft.graph.applePushNotificationCertificate&quot;.</para>
    ///     <para type="description">This function returns a &quot;Edm.String&quot; object.</para>
    ///     <para type="description">Graph Call: GET ~/deviceManagement/applePushNotificationCertificate/downloadApplePushNotificationCertificateSigningRequest</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Invoke", "IntuneDownloadApplePushNotificationCertificateSigningRequest", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.applePushNotificationCertificate")]
    [ResourceTypePropertyName("applePushNotificationCertificateODataType")]
    public class Invoke_IntuneDownloadApplePushNotificationCertificateSigningRequest : FunctionReturningEntityCmdlet
    {
        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/applePushNotificationCertificate/downloadApplePushNotificationCertificateSigningRequest({this.GetFunctionUrlSegment()})";
        }
    }
}