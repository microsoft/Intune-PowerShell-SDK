// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.applePushNotificationCertificate&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.applePushNotificationCertificate&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Apple push notification certificate.</para>
    /// </summary>
    [Cmdlet("New", "ApplePushNotificationCertificateObject", DefaultParameterSetName = @"microsoft.graph.applePushNotificationCertificate")]
    [ODataType("microsoft.graph.applePushNotificationCertificate")]
    public class New_ApplePushNotificationCertificateObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;appleIdentifier&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.applePushNotificationCertificate&quot; type.</para>
        ///     <para type="description">Apple Id of the account used to create the MDM push certificate.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.applePushNotificationCertificate", HelpMessage = @"The &quot;appleIdentifier&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String appleIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;topicIdentifier&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.applePushNotificationCertificate&quot; type.</para>
        ///     <para type="description">Topic Id.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.applePushNotificationCertificate", HelpMessage = @"The &quot;topicIdentifier&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String topicIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.applePushNotificationCertificate&quot; type.</para>
        ///     <para type="description">Last modified date and time for Apple push notification certificate.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.applePushNotificationCertificate", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset lastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.applePushNotificationCertificate&quot; type.</para>
        ///     <para type="description">The expiration date and time for Apple push notification certificate.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.applePushNotificationCertificate", HelpMessage = @"The &quot;expirationDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset expirationDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;certificate&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.applePushNotificationCertificate&quot; type.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.applePushNotificationCertificate", HelpMessage = @"The &quot;certificate&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String certificate { get; set; }
    }
}