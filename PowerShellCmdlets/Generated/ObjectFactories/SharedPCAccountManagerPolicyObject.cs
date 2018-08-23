// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Creates a new object which represents a &quot;microsoft.graph.sharedPCAccountManagerPolicy&quot; (or one of it&apos;s derived types).</para>
    ///     <para type="description">Creates a new object which represents a &quot;microsoft.graph.sharedPCAccountManagerPolicy&quot; (or one of it&apos;s derived types).</para>
    /// </summary>
    [Cmdlet("New", "SharedPCAccountManagerPolicyObject", DefaultParameterSetName = @"microsoft.graph.sharedPCAccountManagerPolicy")]
    [ODataType("microsoft.graph.sharedPCAccountManagerPolicy")]
    public class New_SharedPCAccountManagerPolicyObject : ObjectFactoryCmdletBase
    {
        /// <summary>
        ///     <para type="description">The &quot;accountDeletionPolicy&quot; property, of type &quot;microsoft.graph.sharedPCAccountDeletionPolicyType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sharedPCAccountManagerPolicy&quot; type.</para>
        ///     <para type="description">Configures when accounts are deleted.</para>
        ///     <para type="description">
        ///          Valid values: &apos;immediate&apos;, &apos;diskSpaceThreshold&apos;, &apos;diskSpaceThresholdOrInactiveThreshold&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.sharedPCAccountDeletionPolicyType")]
        [Selectable]
        [ValidateSet(@"immediate", @"diskSpaceThreshold", @"diskSpaceThresholdOrInactiveThreshold")]
        [Parameter(ParameterSetName = @"microsoft.graph.sharedPCAccountManagerPolicy", HelpMessage = @"The &quot;accountDeletionPolicy&quot; property, of type &quot;microsoft.graph.sharedPCAccountDeletionPolicyType&quot;.")]
        public System.String accountDeletionPolicy { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;cacheAccountsAboveDiskFreePercentage&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sharedPCAccountManagerPolicy&quot; type.</para>
        ///     <para type="description">Sets the percentage of available disk space a PC should have before it stops deleting cached shared PC accounts. Only applies when AccountDeletionPolicy is DiskSpaceThreshold or DiskSpaceThresholdOrInactiveThreshold. Valid values 0 to 100</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.sharedPCAccountManagerPolicy", HelpMessage = @"The &quot;cacheAccountsAboveDiskFreePercentage&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 cacheAccountsAboveDiskFreePercentage { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;inactiveThresholdDays&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sharedPCAccountManagerPolicy&quot; type.</para>
        ///     <para type="description">Specifies when the accounts will start being deleted when they have not been logged on during the specified period, given as number of days. Only applies when AccountDeletionPolicy is DiskSpaceThreshold or DiskSpaceThresholdOrInactiveThreshold.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.sharedPCAccountManagerPolicy", HelpMessage = @"The &quot;inactiveThresholdDays&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 inactiveThresholdDays { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;removeAccountsBelowDiskFreePercentage&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.sharedPCAccountManagerPolicy&quot; type.</para>
        ///     <para type="description">Sets the percentage of disk space remaining on a PC before cached accounts will be deleted to free disk space. Accounts that have been inactive the longest will be deleted first. Only applies when AccountDeletionPolicy is DiskSpaceThresholdOrInactiveThreshold. Valid values 0 to 100</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.sharedPCAccountManagerPolicy", HelpMessage = @"The &quot;removeAccountsBelowDiskFreePercentage&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 removeAccountsBelowDiskFreePercentage { get; set; }
    }
}