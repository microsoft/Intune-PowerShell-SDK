// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.localizedNotificationMessage&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.localizedNotificationMessage&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">The text content of a Notification Message Template for the specified locale.</para>
    /// </summary>
    [Cmdlet("New", "LocalizedNotificationMessageObject", DefaultParameterSetName = @"#microsoft.graph.localizedNotificationMessage")]
    [ODataType("microsoft.graph.localizedNotificationMessage")]
    public class New_LocalizedNotificationMessageObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.localizedNotificationMessage&quot; type.</para>
        ///     <para type="description">DateTime the object was last modified.</para>
        /// </summary>
        [ODataType("Edm.DateTimeOffset")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.localizedNotificationMessage", HelpMessage = @"The &quot;lastModifiedDateTime&quot; property, of type &quot;Edm.DateTimeOffset&quot;.")]
        public System.DateTimeOffset LastModifiedDateTime { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;locale&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.localizedNotificationMessage&quot; type.</para>
        ///     <para type="description">The Locale for which this message is destined.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.localizedNotificationMessage", HelpMessage = @"The &quot;locale&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Locale { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;subject&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.localizedNotificationMessage&quot; type.</para>
        ///     <para type="description">The Message Template Subject.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.localizedNotificationMessage", HelpMessage = @"The &quot;subject&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Subject { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;messageTemplate&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.localizedNotificationMessage&quot; type.</para>
        ///     <para type="description">The Message Template content.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.localizedNotificationMessage", HelpMessage = @"The &quot;messageTemplate&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String MessageTemplate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;isDefault&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.localizedNotificationMessage&quot; type.</para>
        ///     <para type="description">Flag to indicate whether or not this is the default locale for language fallback. This flag can only be set. To unset, set this property to true on another Localized Notification Message.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.localizedNotificationMessage", HelpMessage = @"The &quot;isDefault&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean IsDefault { get; set; }
    }
}