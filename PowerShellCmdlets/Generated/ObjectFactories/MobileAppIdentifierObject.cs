// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.mobileAppIdentifier&quot; (or one of its derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.mobileAppIdentifier&quot; (or one of its derived types).</para>
    /// </summary>
    [Cmdlet("New", "MobileAppIdentifierObject", DefaultParameterSetName = @"microsoft.graph.mobileAppIdentifier")]
    [ODataType("microsoft.graph.mobileAppIdentifier")]
    public class New_MobileAppIdentifierObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosMobileAppIdentifier&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.iosMobileAppIdentifier")]
        [Parameter(ParameterSetName = @"microsoft.graph.iosMobileAppIdentifier", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.iosMobileAppIdentifier&quot; type.")]
        public System.Management.Automation.SwitchParameter iosMobileAppIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;bundleId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.iosMobileAppIdentifier&quot; type.</para>
        ///     <para type="description">The identifier for an app, as specified in the app store.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.iosMobileAppIdentifier", HelpMessage = @"The &quot;bundleId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String bundleId { get; set; }

        /// <summary>
        ///     <para type="description">A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.androidMobileAppIdentifier&quot; type.</para>
        /// </summary>
        [Selectable]
        [ParameterSetSelector(@"microsoft.graph.androidMobileAppIdentifier")]
        [Parameter(ParameterSetName = @"microsoft.graph.androidMobileAppIdentifier", Mandatory = true, HelpMessage = @"A switch parameter for selecting the parameter set which corresponds to the &quot;microsoft.graph.androidMobileAppIdentifier&quot; type.")]
        public System.Management.Automation.SwitchParameter androidMobileAppIdentifier { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;packageId&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.androidMobileAppIdentifier&quot; type.</para>
        ///     <para type="description">The identifier for an app, as specified in the play store.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.androidMobileAppIdentifier", HelpMessage = @"The &quot;packageId&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String packageId { get; set; }
    }
}