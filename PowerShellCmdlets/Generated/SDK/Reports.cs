// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves the &quot;reports&quot; object.</para>
    ///     <para type="description">GET ~/reports</para>
    ///     <para type="description">Retrieves the &quot;reports&quot; object (which is of type &quot;microsoft.graph.reportRoot&quot;).</para>
    /// </summary>
    [Cmdlet("Get", "Reports", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Get_Reports : GetCmdlet
    {
        internal override System.String GetResourcePath()
        {
            return $"reports";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.reportRoot&quot; object.</para>
    ///     <para type="description">POST ~/reports</para>
    ///     <para type="description">Creates the &quot;reports&quot; object (which is of type &quot;microsoft.graph.reportRoot&quot;).</para>
    /// </summary>
    [Cmdlet("New", "Reports", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.reportRoot")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class New_Reports : PostCmdlet
    {
        internal override System.String GetResourcePath()
        {
            return $"reports";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">PATCH ~/reports</para>
    ///     <para type="description">Updates the &quot;reports&quot; object (which is of type &quot;microsoft.graph.reportRoot&quot;).</para>
    /// </summary>
    [Cmdlet("Update", "Reports", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.reportRoot")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Update_Reports : PatchCmdlet
    {
        internal override System.String GetResourcePath()
        {
            return $"reports";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.reportRoot&quot; object.</para>
    ///     <para type="description">DELETE ~/reports</para>
    ///     <para type="description">Removes the &quot;reports&quot; object (which is of type &quot;microsoft.graph.reportRoot&quot;).</para>
    /// </summary>
    [Cmdlet("Remove", "Reports", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Remove_Reports : DeleteCmdlet
    {
        internal override System.String GetResourcePath()
        {
            return $"reports";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getOffice365ActivationsUserDetail</para>
    ///     <para type="description">The function &quot;microsoft.graph.getOffice365ActivationsUserDetail&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetOffice365ActivationsUserDetail", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetOffice365ActivationsUserDetail : FunctionReturningEntityCmdlet
    {
        internal override System.String GetResourcePath()
        {
            return $"reports/getOffice365ActivationsUserDetail({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getOffice365ActivationCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getOffice365ActivationCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetOffice365ActivationCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetOffice365ActivationCounts : FunctionReturningEntityCmdlet
    {
        internal override System.String GetResourcePath()
        {
            return $"reports/getOffice365ActivationCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getOffice365ActivationsUserCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getOffice365ActivationsUserCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetOffice365ActivationsUserCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetOffice365ActivationsUserCounts : FunctionReturningEntityCmdlet
    {
        internal override System.String GetResourcePath()
        {
            return $"reports/getOffice365ActivationsUserCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getOffice365ActiveUserDetail</para>
    ///     <para type="description">The function &quot;microsoft.graph.getOffice365ActiveUserDetail&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetOffice365ActiveUserDetail", DefaultParameterSetName = @"Overload_1")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetOffice365ActiveUserDetail : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;date&quot; function parameter of type &quot;Edm.Date&quot;.</para>
        /// </summary>
        [ODataType("Edm.Date")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(ParameterSetName = @"Overload_1", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;date&quot; function parameter of type &quot;Edm.Date&quot;.")]
        public System.DateTimeOffset date { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(ParameterSetName = @"Overload_2", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getOffice365ActiveUserDetail({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getOffice365ServicesUserCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getOffice365ServicesUserCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetOffice365ServicesUserCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetOffice365ServicesUserCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getOffice365ServicesUserCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getOffice365ActiveUserCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getOffice365ActiveUserCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetOffice365ActiveUserCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetOffice365ActiveUserCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getOffice365ActiveUserCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getOffice365GroupsActivityDetail</para>
    ///     <para type="description">The function &quot;microsoft.graph.getOffice365GroupsActivityDetail&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetOffice365GroupsActivityDetail", DefaultParameterSetName = @"Overload_1")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetOffice365GroupsActivityDetail : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;date&quot; function parameter of type &quot;Edm.Date&quot;.</para>
        /// </summary>
        [ODataType("Edm.Date")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(ParameterSetName = @"Overload_1", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;date&quot; function parameter of type &quot;Edm.Date&quot;.")]
        public System.DateTimeOffset date { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(ParameterSetName = @"Overload_2", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getOffice365GroupsActivityDetail({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getOffice365GroupsActivityCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getOffice365GroupsActivityCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetOffice365GroupsActivityCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetOffice365GroupsActivityCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getOffice365GroupsActivityCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getOffice365GroupsActivityGroupCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getOffice365GroupsActivityGroupCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetOffice365GroupsActivityGroupCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetOffice365GroupsActivityGroupCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getOffice365GroupsActivityGroupCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getOffice365GroupsActivityStorage</para>
    ///     <para type="description">The function &quot;microsoft.graph.getOffice365GroupsActivityStorage&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetOffice365GroupsActivityStorage", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetOffice365GroupsActivityStorage : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getOffice365GroupsActivityStorage({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getOffice365GroupsActivityFileCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getOffice365GroupsActivityFileCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetOffice365GroupsActivityFileCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetOffice365GroupsActivityFileCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getOffice365GroupsActivityFileCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getEmailActivityUserDetail</para>
    ///     <para type="description">The function &quot;microsoft.graph.getEmailActivityUserDetail&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetEmailActivityUserDetail", DefaultParameterSetName = @"Overload_1")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetEmailActivityUserDetail : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;date&quot; function parameter of type &quot;Edm.Date&quot;.</para>
        /// </summary>
        [ODataType("Edm.Date")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(ParameterSetName = @"Overload_1", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;date&quot; function parameter of type &quot;Edm.Date&quot;.")]
        public System.DateTimeOffset date { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(ParameterSetName = @"Overload_2", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getEmailActivityUserDetail({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getEmailActivityCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getEmailActivityCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetEmailActivityCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetEmailActivityCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getEmailActivityCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getEmailActivityUserCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getEmailActivityUserCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetEmailActivityUserCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetEmailActivityUserCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getEmailActivityUserCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getEmailAppUsageUserDetail</para>
    ///     <para type="description">The function &quot;microsoft.graph.getEmailAppUsageUserDetail&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetEmailAppUsageUserDetail", DefaultParameterSetName = @"Overload_1")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetEmailAppUsageUserDetail : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;date&quot; function parameter of type &quot;Edm.Date&quot;.</para>
        /// </summary>
        [ODataType("Edm.Date")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(ParameterSetName = @"Overload_1", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;date&quot; function parameter of type &quot;Edm.Date&quot;.")]
        public System.DateTimeOffset date { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(ParameterSetName = @"Overload_2", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getEmailAppUsageUserDetail({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getEmailAppUsageAppsUserCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getEmailAppUsageAppsUserCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetEmailAppUsageAppsUserCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetEmailAppUsageAppsUserCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getEmailAppUsageAppsUserCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getEmailAppUsageUserCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getEmailAppUsageUserCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetEmailAppUsageUserCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetEmailAppUsageUserCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getEmailAppUsageUserCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getEmailAppUsageVersionsUserCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getEmailAppUsageVersionsUserCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetEmailAppUsageVersionsUserCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetEmailAppUsageVersionsUserCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getEmailAppUsageVersionsUserCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getMailboxUsageDetail</para>
    ///     <para type="description">The function &quot;microsoft.graph.getMailboxUsageDetail&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetMailboxUsageDetail", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetMailboxUsageDetail : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getMailboxUsageDetail({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getMailboxUsageMailboxCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getMailboxUsageMailboxCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetMailboxUsageMailboxCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetMailboxUsageMailboxCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getMailboxUsageMailboxCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getMailboxUsageQuotaStatusMailboxCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getMailboxUsageQuotaStatusMailboxCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetMailboxUsageQuotaStatusMailboxCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetMailboxUsageQuotaStatusMailboxCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getMailboxUsageQuotaStatusMailboxCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getMailboxUsageStorage</para>
    ///     <para type="description">The function &quot;microsoft.graph.getMailboxUsageStorage&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetMailboxUsageStorage", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetMailboxUsageStorage : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getMailboxUsageStorage({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getOneDriveActivityUserDetail</para>
    ///     <para type="description">The function &quot;microsoft.graph.getOneDriveActivityUserDetail&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetOneDriveActivityUserDetail", DefaultParameterSetName = @"Overload_1")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetOneDriveActivityUserDetail : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;date&quot; function parameter of type &quot;Edm.Date&quot;.</para>
        /// </summary>
        [ODataType("Edm.Date")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(ParameterSetName = @"Overload_1", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;date&quot; function parameter of type &quot;Edm.Date&quot;.")]
        public System.DateTimeOffset date { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(ParameterSetName = @"Overload_2", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getOneDriveActivityUserDetail({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getOneDriveActivityUserCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getOneDriveActivityUserCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetOneDriveActivityUserCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetOneDriveActivityUserCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getOneDriveActivityUserCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getOneDriveActivityFileCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getOneDriveActivityFileCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetOneDriveActivityFileCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetOneDriveActivityFileCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getOneDriveActivityFileCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getOneDriveUsageAccountDetail</para>
    ///     <para type="description">The function &quot;microsoft.graph.getOneDriveUsageAccountDetail&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetOneDriveUsageAccountDetail", DefaultParameterSetName = @"Overload_1")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetOneDriveUsageAccountDetail : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;date&quot; function parameter of type &quot;Edm.Date&quot;.</para>
        /// </summary>
        [ODataType("Edm.Date")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(ParameterSetName = @"Overload_1", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;date&quot; function parameter of type &quot;Edm.Date&quot;.")]
        public System.DateTimeOffset date { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(ParameterSetName = @"Overload_2", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getOneDriveUsageAccountDetail({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getOneDriveUsageAccountCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getOneDriveUsageAccountCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetOneDriveUsageAccountCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetOneDriveUsageAccountCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getOneDriveUsageAccountCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getOneDriveUsageFileCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getOneDriveUsageFileCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetOneDriveUsageFileCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetOneDriveUsageFileCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getOneDriveUsageFileCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getOneDriveUsageStorage</para>
    ///     <para type="description">The function &quot;microsoft.graph.getOneDriveUsageStorage&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetOneDriveUsageStorage", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetOneDriveUsageStorage : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getOneDriveUsageStorage({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getSharePointActivityUserDetail</para>
    ///     <para type="description">The function &quot;microsoft.graph.getSharePointActivityUserDetail&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetSharePointActivityUserDetail", DefaultParameterSetName = @"Overload_1")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetSharePointActivityUserDetail : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;date&quot; function parameter of type &quot;Edm.Date&quot;.</para>
        /// </summary>
        [ODataType("Edm.Date")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(ParameterSetName = @"Overload_1", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;date&quot; function parameter of type &quot;Edm.Date&quot;.")]
        public System.DateTimeOffset date { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(ParameterSetName = @"Overload_2", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getSharePointActivityUserDetail({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getSharePointActivityFileCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getSharePointActivityFileCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetSharePointActivityFileCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetSharePointActivityFileCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getSharePointActivityFileCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getSharePointActivityUserCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getSharePointActivityUserCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetSharePointActivityUserCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetSharePointActivityUserCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getSharePointActivityUserCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getSharePointActivityPages</para>
    ///     <para type="description">The function &quot;microsoft.graph.getSharePointActivityPages&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetSharePointActivityPages", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetSharePointActivityPages : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getSharePointActivityPages({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getSharePointSiteUsageDetail</para>
    ///     <para type="description">The function &quot;microsoft.graph.getSharePointSiteUsageDetail&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetSharePointSiteUsageDetail", DefaultParameterSetName = @"Overload_1")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetSharePointSiteUsageDetail : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;date&quot; function parameter of type &quot;Edm.Date&quot;.</para>
        /// </summary>
        [ODataType("Edm.Date")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(ParameterSetName = @"Overload_1", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;date&quot; function parameter of type &quot;Edm.Date&quot;.")]
        public System.DateTimeOffset date { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(ParameterSetName = @"Overload_2", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getSharePointSiteUsageDetail({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getSharePointSiteUsageFileCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getSharePointSiteUsageFileCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetSharePointSiteUsageFileCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetSharePointSiteUsageFileCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getSharePointSiteUsageFileCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getSharePointSiteUsageSiteCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getSharePointSiteUsageSiteCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetSharePointSiteUsageSiteCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetSharePointSiteUsageSiteCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getSharePointSiteUsageSiteCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getSharePointSiteUsageStorage</para>
    ///     <para type="description">The function &quot;microsoft.graph.getSharePointSiteUsageStorage&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetSharePointSiteUsageStorage", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetSharePointSiteUsageStorage : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getSharePointSiteUsageStorage({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getSharePointSiteUsagePages</para>
    ///     <para type="description">The function &quot;microsoft.graph.getSharePointSiteUsagePages&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetSharePointSiteUsagePages", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetSharePointSiteUsagePages : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getSharePointSiteUsagePages({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getSkypeForBusinessActivityUserDetail</para>
    ///     <para type="description">The function &quot;microsoft.graph.getSkypeForBusinessActivityUserDetail&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetSkypeForBusinessActivityUserDetail", DefaultParameterSetName = @"Overload_1")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetSkypeForBusinessActivityUserDetail : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;date&quot; function parameter of type &quot;Edm.Date&quot;.</para>
        /// </summary>
        [ODataType("Edm.Date")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(ParameterSetName = @"Overload_1", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;date&quot; function parameter of type &quot;Edm.Date&quot;.")]
        public System.DateTimeOffset date { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(ParameterSetName = @"Overload_2", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getSkypeForBusinessActivityUserDetail({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getSkypeForBusinessActivityCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getSkypeForBusinessActivityCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetSkypeForBusinessActivityCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetSkypeForBusinessActivityCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getSkypeForBusinessActivityCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getSkypeForBusinessActivityUserCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getSkypeForBusinessActivityUserCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetSkypeForBusinessActivityUserCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetSkypeForBusinessActivityUserCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getSkypeForBusinessActivityUserCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getSkypeForBusinessPeerToPeerActivityCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getSkypeForBusinessPeerToPeerActivityCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetSkypeForBusinessPeerToPeerActivityCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetSkypeForBusinessPeerToPeerActivityCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getSkypeForBusinessPeerToPeerActivityCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getSkypeForBusinessPeerToPeerActivityUserCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getSkypeForBusinessPeerToPeerActivityUserCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetSkypeForBusinessPeerToPeerActivityUserCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetSkypeForBusinessPeerToPeerActivityUserCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getSkypeForBusinessPeerToPeerActivityUserCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getSkypeForBusinessPeerToPeerActivityMinuteCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getSkypeForBusinessPeerToPeerActivityMinuteCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetSkypeForBusinessPeerToPeerActivityMinuteCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetSkypeForBusinessPeerToPeerActivityMinuteCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getSkypeForBusinessPeerToPeerActivityMinuteCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getSkypeForBusinessOrganizerActivityCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getSkypeForBusinessOrganizerActivityCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetSkypeForBusinessOrganizerActivityCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetSkypeForBusinessOrganizerActivityCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getSkypeForBusinessOrganizerActivityCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getSkypeForBusinessOrganizerActivityUserCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getSkypeForBusinessOrganizerActivityUserCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetSkypeForBusinessOrganizerActivityUserCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetSkypeForBusinessOrganizerActivityUserCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getSkypeForBusinessOrganizerActivityUserCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getSkypeForBusinessOrganizerActivityMinuteCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getSkypeForBusinessOrganizerActivityMinuteCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetSkypeForBusinessOrganizerActivityMinuteCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetSkypeForBusinessOrganizerActivityMinuteCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getSkypeForBusinessOrganizerActivityMinuteCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getSkypeForBusinessParticipantActivityCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getSkypeForBusinessParticipantActivityCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetSkypeForBusinessParticipantActivityCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetSkypeForBusinessParticipantActivityCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getSkypeForBusinessParticipantActivityCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getSkypeForBusinessParticipantActivityUserCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getSkypeForBusinessParticipantActivityUserCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetSkypeForBusinessParticipantActivityUserCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetSkypeForBusinessParticipantActivityUserCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getSkypeForBusinessParticipantActivityUserCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getSkypeForBusinessParticipantActivityMinuteCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getSkypeForBusinessParticipantActivityMinuteCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetSkypeForBusinessParticipantActivityMinuteCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetSkypeForBusinessParticipantActivityMinuteCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getSkypeForBusinessParticipantActivityMinuteCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getSkypeForBusinessDeviceUsageUserDetail</para>
    ///     <para type="description">The function &quot;microsoft.graph.getSkypeForBusinessDeviceUsageUserDetail&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetSkypeForBusinessDeviceUsageUserDetail", DefaultParameterSetName = @"Overload_1")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetSkypeForBusinessDeviceUsageUserDetail : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;date&quot; function parameter of type &quot;Edm.Date&quot;.</para>
        /// </summary>
        [ODataType("Edm.Date")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(ParameterSetName = @"Overload_1", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;date&quot; function parameter of type &quot;Edm.Date&quot;.")]
        public System.DateTimeOffset date { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(ParameterSetName = @"Overload_2", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getSkypeForBusinessDeviceUsageUserDetail({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getSkypeForBusinessDeviceUsageDistributionUserCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getSkypeForBusinessDeviceUsageDistributionUserCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetSkypeForBusinessDeviceUsageDistributionUserCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetSkypeForBusinessDeviceUsageDistributionUserCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getSkypeForBusinessDeviceUsageDistributionUserCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getSkypeForBusinessDeviceUsageUserCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getSkypeForBusinessDeviceUsageUserCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetSkypeForBusinessDeviceUsageUserCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetSkypeForBusinessDeviceUsageUserCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getSkypeForBusinessDeviceUsageUserCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getYammerActivityUserDetail</para>
    ///     <para type="description">The function &quot;microsoft.graph.getYammerActivityUserDetail&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetYammerActivityUserDetail", DefaultParameterSetName = @"Overload_1")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetYammerActivityUserDetail : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;date&quot; function parameter of type &quot;Edm.Date&quot;.</para>
        /// </summary>
        [ODataType("Edm.Date")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(ParameterSetName = @"Overload_1", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;date&quot; function parameter of type &quot;Edm.Date&quot;.")]
        public System.DateTimeOffset date { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(ParameterSetName = @"Overload_2", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getYammerActivityUserDetail({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getYammerActivityCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getYammerActivityCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetYammerActivityCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetYammerActivityCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getYammerActivityCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getYammerActivityUserCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getYammerActivityUserCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetYammerActivityUserCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetYammerActivityUserCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getYammerActivityUserCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getYammerDeviceUsageUserDetail</para>
    ///     <para type="description">The function &quot;microsoft.graph.getYammerDeviceUsageUserDetail&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetYammerDeviceUsageUserDetail", DefaultParameterSetName = @"Overload_1")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetYammerDeviceUsageUserDetail : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;date&quot; function parameter of type &quot;Edm.Date&quot;.</para>
        /// </summary>
        [ODataType("Edm.Date")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(ParameterSetName = @"Overload_1", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;date&quot; function parameter of type &quot;Edm.Date&quot;.")]
        public System.DateTimeOffset date { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(ParameterSetName = @"Overload_2", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getYammerDeviceUsageUserDetail({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getYammerDeviceUsageDistributionUserCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getYammerDeviceUsageDistributionUserCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetYammerDeviceUsageDistributionUserCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetYammerDeviceUsageDistributionUserCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getYammerDeviceUsageDistributionUserCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getYammerDeviceUsageUserCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getYammerDeviceUsageUserCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetYammerDeviceUsageUserCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetYammerDeviceUsageUserCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getYammerDeviceUsageUserCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getYammerGroupsActivityDetail</para>
    ///     <para type="description">The function &quot;microsoft.graph.getYammerGroupsActivityDetail&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetYammerGroupsActivityDetail", DefaultParameterSetName = @"Overload_1")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetYammerGroupsActivityDetail : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;date&quot; function parameter of type &quot;Edm.Date&quot;.</para>
        /// </summary>
        [ODataType("Edm.Date")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(ParameterSetName = @"Overload_1", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;date&quot; function parameter of type &quot;Edm.Date&quot;.")]
        public System.DateTimeOffset date { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(ParameterSetName = @"Overload_2", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getYammerGroupsActivityDetail({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getYammerGroupsActivityGroupCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getYammerGroupsActivityGroupCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetYammerGroupsActivityGroupCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetYammerGroupsActivityGroupCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getYammerGroupsActivityGroupCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getYammerGroupsActivityCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getYammerGroupsActivityCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetYammerGroupsActivityCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetYammerGroupsActivityCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getYammerGroupsActivityCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getTeamsUserActivityUserDetail</para>
    ///     <para type="description">The function &quot;microsoft.graph.getTeamsUserActivityUserDetail&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetTeamsUserActivityUserDetail", DefaultParameterSetName = @"Overload_1")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetTeamsUserActivityUserDetail : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;date&quot; function parameter of type &quot;Edm.Date&quot;.</para>
        /// </summary>
        [ODataType("Edm.Date")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(ParameterSetName = @"Overload_1", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;date&quot; function parameter of type &quot;Edm.Date&quot;.")]
        public System.DateTimeOffset date { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(ParameterSetName = @"Overload_2", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getTeamsUserActivityUserDetail({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getTeamsUserActivityCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getTeamsUserActivityCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetTeamsUserActivityCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetTeamsUserActivityCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getTeamsUserActivityCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getTeamsUserActivityUserCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getTeamsUserActivityUserCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetTeamsUserActivityUserCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetTeamsUserActivityUserCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getTeamsUserActivityUserCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getTeamsDeviceUsageUserDetail</para>
    ///     <para type="description">The function &quot;microsoft.graph.getTeamsDeviceUsageUserDetail&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetTeamsDeviceUsageUserDetail", DefaultParameterSetName = @"Overload_1")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetTeamsDeviceUsageUserDetail : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;date&quot; function parameter of type &quot;Edm.Date&quot;.</para>
        /// </summary>
        [ODataType("Edm.Date")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(ParameterSetName = @"Overload_1", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;date&quot; function parameter of type &quot;Edm.Date&quot;.")]
        public System.DateTimeOffset date { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(ParameterSetName = @"Overload_2", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getTeamsDeviceUsageUserDetail({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getTeamsDeviceUsageUserCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getTeamsDeviceUsageUserCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetTeamsDeviceUsageUserCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetTeamsDeviceUsageUserCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getTeamsDeviceUsageUserCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/getTeamsDeviceUsageDistributionUserCounts</para>
    ///     <para type="description">The function &quot;microsoft.graph.getTeamsDeviceUsageDistributionUserCounts&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_GetTeamsDeviceUsageDistributionUserCounts", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_GetTeamsDeviceUsageDistributionUserCounts : FunctionReturningEntityCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [ValidateNotNull]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; function parameter of type &quot;Edm.String&quot;.")]
        public System.String period { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"reports/getTeamsDeviceUsageDistributionUserCounts({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/deviceConfigurationUserActivity</para>
    ///     <para type="description">The function &quot;microsoft.graph.deviceConfigurationUserActivity&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_DeviceConfigurationUserActivity", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_DeviceConfigurationUserActivity : FunctionReturningEntityCmdlet
    {
        internal override System.String GetResourcePath()
        {
            return $"reports/deviceConfigurationUserActivity({this.GetFunctionUrlSegment()})";
        }
    }

    /// <summary>
    ///     <para type="description">GET ~/reports/deviceConfigurationDeviceActivity</para>
    ///     <para type="description">The function &quot;microsoft.graph.deviceConfigurationDeviceActivity&quot;, which exists on the type &quot;microsoft.graph.reportRoot&quot;.</para>
    ///     <para type="description">This function returns a &quot;microsoft.graph.report&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Reports_DeviceConfigurationDeviceActivity", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.reportRoot")]
    [ResourceTypePropertyName("reportODataType")]
    public class Invoke_Reports_DeviceConfigurationDeviceActivity : FunctionReturningEntityCmdlet
    {
        internal override System.String GetResourcePath()
        {
            return $"reports/deviceConfigurationDeviceActivity({this.GetFunctionUrlSegment()})";
        }
    }
}