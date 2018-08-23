// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves the &quot;conditionalAccessSettings&quot; object.</para>
    ///     <para type="description">GET ~/deviceManagement/conditionalAccessSettings</para>
    ///     <para type="description">Retrieves the &quot;conditionalAccessSettings&quot; object (which is of type &quot;microsoft.graph.onPremisesConditionalAccessSettings&quot;).</para>
    ///     <para type="description">The Exchange on premises conditional access settings. On premises conditional access will require devices to be both enrolled and compliant for mail access</para>
    /// </summary>
    [Cmdlet("Get", "DeviceManagement_ConditionalAccessSettings", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.onPremisesConditionalAccessSettings")]
    [ResourceTypePropertyName("conditionalAccessSettingODataType")]
    [ResourceReference]
    public class Get_DeviceManagement_ConditionalAccessSettings : GetCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;enabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onPremisesConditionalAccessSettings&quot; type.</para>
        ///     <para type="description">Indicates if on premises conditional access is enabled for this organization</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean enabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;includedGroups&quot; property, of type &quot;Edm.Guid&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onPremisesConditionalAccessSettings&quot; type.</para>
        ///     <para type="description">User groups that will be targeted by on premises conditional access. All users in these groups will be required to have mobile device managed and compliant for mail access.</para>
        /// </summary>
        [ODataType("Edm.Guid")]
        [Selectable]
        public System.Guid[] includedGroups { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;excludedGroups&quot; property, of type &quot;Edm.Guid&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onPremisesConditionalAccessSettings&quot; type.</para>
        ///     <para type="description">User groups that will be exempt by on premises conditional access. All users in these groups will be exempt from the conditional access policy.</para>
        /// </summary>
        [ODataType("Edm.Guid")]
        [Selectable]
        public System.Guid[] excludedGroups { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;overrideDefaultRule&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onPremisesConditionalAccessSettings&quot; type.</para>
        ///     <para type="description">Override the default access rule when allowing a device to ensure access is granted.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Sortable]
        public System.Boolean overrideDefaultRule { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/conditionalAccessSettings";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.onPremisesConditionalAccessSettings&quot; object.</para>
    ///     <para type="description">POST ~/deviceManagement/conditionalAccessSettings</para>
    ///     <para type="description">Creates the &quot;conditionalAccessSettings&quot; object (which is of type &quot;microsoft.graph.onPremisesConditionalAccessSettings&quot;).</para>
    ///     <para type="description">The Exchange on premises conditional access settings. On premises conditional access will require devices to be both enrolled and compliant for mail access</para>
    /// </summary>
    [Cmdlet("New", "DeviceManagement_ConditionalAccessSettings", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.onPremisesConditionalAccessSettings")]
    [ODataType("microsoft.graph.onPremisesConditionalAccessSettings")]
    [ResourceTypePropertyName("conditionalAccessSettingODataType")]
    [ResourceReference]
    public class New_DeviceManagement_ConditionalAccessSettings : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;enabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onPremisesConditionalAccessSettings&quot; type.</para>
        ///     <para type="description">Indicates if on premises conditional access is enabled for this organization</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.onPremisesConditionalAccessSettings", HelpMessage = @"The &quot;enabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean enabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;includedGroups&quot; property, of type &quot;Edm.Guid&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onPremisesConditionalAccessSettings&quot; type.</para>
        ///     <para type="description">User groups that will be targeted by on premises conditional access. All users in these groups will be required to have mobile device managed and compliant for mail access.</para>
        /// </summary>
        [ODataType("Edm.Guid")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.onPremisesConditionalAccessSettings", HelpMessage = @"The &quot;includedGroups&quot; property, of type &quot;Edm.Guid&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;includedGroups&quot; property, of type &quot;Edm.Guid&quot;.")]
        public System.Guid[] includedGroups { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;excludedGroups&quot; property, of type &quot;Edm.Guid&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onPremisesConditionalAccessSettings&quot; type.</para>
        ///     <para type="description">User groups that will be exempt by on premises conditional access. All users in these groups will be exempt from the conditional access policy.</para>
        /// </summary>
        [ODataType("Edm.Guid")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.onPremisesConditionalAccessSettings", HelpMessage = @"The &quot;excludedGroups&quot; property, of type &quot;Edm.Guid&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;excludedGroups&quot; property, of type &quot;Edm.Guid&quot;.")]
        public System.Guid[] excludedGroups { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;overrideDefaultRule&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onPremisesConditionalAccessSettings&quot; type.</para>
        ///     <para type="description">Override the default access rule when allowing a device to ensure access is granted.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.onPremisesConditionalAccessSettings", HelpMessage = @"The &quot;overrideDefaultRule&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;overrideDefaultRule&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean overrideDefaultRule { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/conditionalAccessSettings";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.onPremisesConditionalAccessSettings&quot;.</para>
    ///     <para type="description">PATCH ~/deviceManagement/conditionalAccessSettings</para>
    ///     <para type="description">Updates the &quot;conditionalAccessSettings&quot; object (which is of type &quot;microsoft.graph.onPremisesConditionalAccessSettings&quot;).</para>
    ///     <para type="description">The Exchange on premises conditional access settings. On premises conditional access will require devices to be both enrolled and compliant for mail access</para>
    /// </summary>
    [Cmdlet("Update", "DeviceManagement_ConditionalAccessSettings", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.onPremisesConditionalAccessSettings")]
    [ODataType("microsoft.graph.onPremisesConditionalAccessSettings")]
    [ResourceTypePropertyName("conditionalAccessSettingODataType")]
    public class Update_DeviceManagement_ConditionalAccessSettings : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;enabled&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onPremisesConditionalAccessSettings&quot; type.</para>
        ///     <para type="description">Indicates if on premises conditional access is enabled for this organization</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.onPremisesConditionalAccessSettings", HelpMessage = @"The &quot;enabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;enabled&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean enabled { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;includedGroups&quot; property, of type &quot;Edm.Guid&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onPremisesConditionalAccessSettings&quot; type.</para>
        ///     <para type="description">User groups that will be targeted by on premises conditional access. All users in these groups will be required to have mobile device managed and compliant for mail access.</para>
        /// </summary>
        [ODataType("Edm.Guid")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.onPremisesConditionalAccessSettings", HelpMessage = @"The &quot;includedGroups&quot; property, of type &quot;Edm.Guid&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;includedGroups&quot; property, of type &quot;Edm.Guid&quot;.")]
        public System.Guid[] includedGroups { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;excludedGroups&quot; property, of type &quot;Edm.Guid&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onPremisesConditionalAccessSettings&quot; type.</para>
        ///     <para type="description">User groups that will be exempt by on premises conditional access. All users in these groups will be exempt from the conditional access policy.</para>
        /// </summary>
        [ODataType("Edm.Guid")]
        [Selectable]
        [AllowEmptyCollection]
        [Parameter(ParameterSetName = @"microsoft.graph.onPremisesConditionalAccessSettings", HelpMessage = @"The &quot;excludedGroups&quot; property, of type &quot;Edm.Guid&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;excludedGroups&quot; property, of type &quot;Edm.Guid&quot;.")]
        public System.Guid[] excludedGroups { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;overrideDefaultRule&quot; property, of type &quot;Edm.Boolean&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.onPremisesConditionalAccessSettings&quot; type.</para>
        ///     <para type="description">Override the default access rule when allowing a device to ensure access is granted.</para>
        /// </summary>
        [ODataType("Edm.Boolean")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.onPremisesConditionalAccessSettings", HelpMessage = @"The &quot;overrideDefaultRule&quot; property, of type &quot;Edm.Boolean&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;overrideDefaultRule&quot; property, of type &quot;Edm.Boolean&quot;.")]
        public System.Boolean overrideDefaultRule { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/conditionalAccessSettings";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.onPremisesConditionalAccessSettings&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceManagement/conditionalAccessSettings</para>
    ///     <para type="description">Removes the &quot;conditionalAccessSettings&quot; object (which is of type &quot;microsoft.graph.onPremisesConditionalAccessSettings&quot;).</para>
    ///     <para type="description">The Exchange on premises conditional access settings. On premises conditional access will require devices to be both enrolled and compliant for mail access</para>
    /// </summary>
    [Cmdlet("Remove", "DeviceManagement_ConditionalAccessSettings", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.onPremisesConditionalAccessSettings")]
    [ResourceTypePropertyName("conditionalAccessSettingODataType")]
    public class Remove_DeviceManagement_ConditionalAccessSettings : DeleteCmdlet
    {
        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/conditionalAccessSettings";
        }
    }
}