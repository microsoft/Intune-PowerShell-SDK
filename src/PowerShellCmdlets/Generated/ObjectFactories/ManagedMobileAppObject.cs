// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.managedMobileApp&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.managedMobileApp&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">The identifier for the deployment an app.</para>
    /// </summary>
    [Cmdlet("New", "ManagedMobileAppObject", DefaultParameterSetName = @"#microsoft.graph.managedMobileApp")]
    [ODataType("microsoft.graph.managedMobileApp")]
    public class New_ManagedMobileAppObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;mobileAppIdentifier&quot; property, of type &quot;microsoft.graph.mobileAppIdentifier&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedMobileApp&quot; type.</para>
        ///     <para type="description">The identifier for an app with it&apos;s operating system type.</para>
        /// </summary>
        [ODataType("microsoft.graph.mobileAppIdentifier")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedMobileApp", HelpMessage = @"The &quot;mobileAppIdentifier&quot; property, of type &quot;microsoft.graph.mobileAppIdentifier&quot;.")]
        public System.Object MobileAppIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;version&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.managedMobileApp&quot; type.</para>
        ///     <para type="description">Version of the entity.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"#microsoft.graph.managedMobileApp", HelpMessage = @"The &quot;version&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String Version { get; set; }
    }
}