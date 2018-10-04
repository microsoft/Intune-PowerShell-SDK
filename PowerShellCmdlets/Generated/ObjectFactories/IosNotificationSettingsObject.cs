// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.iosNotificationSettings&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.iosNotificationSettings&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "IosNotificationSettingsObject", DefaultParameterSetName = @"microsoft.graph.iosNotificationSettings")]
    [ODataType("microsoft.graph.iosNotificationSettings")]
    public class New_IosNotificationSettingsObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;bundleID&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosNotificationSettings&quot; type.</para>
        ///     <para type="description">Bundle id of app to which to apply these notification settings.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosNotificationSettings", HelpMessage = @"The &quot;bundleID&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String bundleID { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;appName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosNotificationSettings&quot; type.</para>
        ///     <para type="description">Application name to be associated with the bundleID.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosNotificationSettings", HelpMessage = @"The &quot;appName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String appName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;publisher&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosNotificationSettings&quot; type.</para>
        ///     <para type="description">Publisher to be associated with the bundleID.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosNotificationSettings", HelpMessage = @"The &quot;publisher&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String publisher { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;enabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosNotificationSettings&quot; type.</para>
        ///     <para type="description">Indicates whether notifications are allowed for this app.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosNotificationSettings", HelpMessage = @"The &quot;enabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean enabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;showInNotificationCenter&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosNotificationSettings&quot; type.</para>
        ///     <para type="description">Indicates whether notifications can be shown in notification center.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosNotificationSettings", HelpMessage = @"The &quot;showInNotificationCenter&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean showInNotificationCenter { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;showOnLockScreen&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosNotificationSettings&quot; type.</para>
        ///     <para type="description">Indicates whether notifications can be shown on the lock screen.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosNotificationSettings", HelpMessage = @"The &quot;showOnLockScreen&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean showOnLockScreen { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;alertType&quot; property, of type &quot;microsoft.graph.iosNotificationAlertType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosNotificationSettings&quot; type.</para>
        ///     <para type="description">Indicates the type of alert for notifications for this app.</para>
        ///     <para type="description">
        ///          Valid values: &apos;deviceDefault&apos;, &apos;banner&apos;, &apos;modal&apos;, &apos;none&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.iosNotificationAlertType")]
        [Selectable]
        [ValidateSet(@"deviceDefault", @"banner", @"modal", @"none")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosNotificationSettings", HelpMessage = @"The &quot;alertType&quot; property, of type &quot;microsoft.graph.iosNotificationAlertType&quot;.")]
        public System.String alertType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;badgesEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosNotificationSettings&quot; type.</para>
        ///     <para type="description">Indicates whether badges are allowed for this app.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosNotificationSettings", HelpMessage = @"The &quot;badgesEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean badgesEnabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;soundsEnabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosNotificationSettings&quot; type.</para>
        ///     <para type="description">Indicates whether sounds are allowed for this app.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosNotificationSettings", HelpMessage = @"The &quot;soundsEnabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean soundsEnabled { get; set; }
    }
}