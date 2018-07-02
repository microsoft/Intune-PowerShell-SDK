// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves the &quot;functions&quot; object.</para>
    ///     <para type="description">GET ~/me/drive/special/{specialId}/workbook/functions</para>
    ///     <para type="description">Retrieves the &quot;functions&quot; object (which is of type &quot;microsoft.graph.workbookFunctions&quot;).</para>
    /// </summary>
    [Cmdlet("Get", "Me_Drive_Special_Workbook_Functions", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.workbookFunctions")]
    [ResourceReference]
    public class Get_Me_Drive_Special_Workbook_Functions : GetCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.workbookFunctions&quot; object.</para>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions</para>
    ///     <para type="description">Creates the &quot;functions&quot; object (which is of type &quot;microsoft.graph.workbookFunctions&quot;).</para>
    /// </summary>
    [Cmdlet("New", "Me_Drive_Special_Workbook_Functions", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"#microsoft.graph.workbookFunctions")]
    [ODataType("microsoft.graph.workbookFunctions")]
    [ResourceReference]
    public class New_Me_Drive_Special_Workbook_Functions : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">PATCH ~/me/drive/special/{specialId}/workbook/functions</para>
    ///     <para type="description">Updates the &quot;functions&quot; object (which is of type &quot;microsoft.graph.workbookFunctions&quot;).</para>
    /// </summary>
    [Cmdlet("Update", "Me_Drive_Special_Workbook_Functions", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"#microsoft.graph.workbookFunctions")]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Update_Me_Drive_Special_Workbook_Functions : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.workbookFunctions&quot; object.</para>
    ///     <para type="description">DELETE ~/me/drive/special/{specialId}/workbook/functions</para>
    ///     <para type="description">Removes the &quot;functions&quot; object (which is of type &quot;microsoft.graph.workbookFunctions&quot;).</para>
    /// </summary>
    [Cmdlet("Remove", "Me_Drive_Special_Workbook_Functions", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Remove_Me_Drive_Special_Workbook_Functions : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/abs</para>
    ///     <para type="description">The action &quot;microsoft.graph.abs&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Abs", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Abs : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.abs&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.abs&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/abs";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/accrInt</para>
    ///     <para type="description">The action &quot;microsoft.graph.accrInt&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_AccrInt", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_AccrInt : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;issue&quot; parameter, which is accepted by the &quot;microsoft.graph.accrInt&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;issue&quot; parameter, which is accepted by the &quot;microsoft.graph.accrInt&quot; action.")]
        public System.Object issue { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;firstInterest&quot; parameter, which is accepted by the &quot;microsoft.graph.accrInt&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;firstInterest&quot; parameter, which is accepted by the &quot;microsoft.graph.accrInt&quot; action.")]
        public System.Object firstInterest { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.accrInt&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.accrInt&quot; action.")]
        public System.Object settlement { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.accrInt&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.accrInt&quot; action.")]
        public System.Object rate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;par&quot; parameter, which is accepted by the &quot;microsoft.graph.accrInt&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;par&quot; parameter, which is accepted by the &quot;microsoft.graph.accrInt&quot; action.")]
        public System.Object par { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;frequency&quot; parameter, which is accepted by the &quot;microsoft.graph.accrInt&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;frequency&quot; parameter, which is accepted by the &quot;microsoft.graph.accrInt&quot; action.")]
        public System.Object frequency { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.accrInt&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.accrInt&quot; action.")]
        public System.Object basis { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;calcMethod&quot; parameter, which is accepted by the &quot;microsoft.graph.accrInt&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;calcMethod&quot; parameter, which is accepted by the &quot;microsoft.graph.accrInt&quot; action.")]
        public System.Object calcMethod { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/accrInt";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/accrIntM</para>
    ///     <para type="description">The action &quot;microsoft.graph.accrIntM&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_AccrIntM", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_AccrIntM : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;issue&quot; parameter, which is accepted by the &quot;microsoft.graph.accrIntM&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;issue&quot; parameter, which is accepted by the &quot;microsoft.graph.accrIntM&quot; action.")]
        public System.Object issue { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.accrIntM&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.accrIntM&quot; action.")]
        public System.Object settlement { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.accrIntM&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.accrIntM&quot; action.")]
        public System.Object rate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;par&quot; parameter, which is accepted by the &quot;microsoft.graph.accrIntM&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;par&quot; parameter, which is accepted by the &quot;microsoft.graph.accrIntM&quot; action.")]
        public System.Object par { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.accrIntM&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.accrIntM&quot; action.")]
        public System.Object basis { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/accrIntM";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/acos</para>
    ///     <para type="description">The action &quot;microsoft.graph.acos&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Acos", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Acos : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.acos&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.acos&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/acos";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/acosh</para>
    ///     <para type="description">The action &quot;microsoft.graph.acosh&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Acosh", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Acosh : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.acosh&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.acosh&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/acosh";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/acot</para>
    ///     <para type="description">The action &quot;microsoft.graph.acot&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Acot", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Acot : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.acot&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.acot&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/acot";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/acoth</para>
    ///     <para type="description">The action &quot;microsoft.graph.acoth&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Acoth", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Acoth : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.acoth&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.acoth&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/acoth";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/amorDegrc</para>
    ///     <para type="description">The action &quot;microsoft.graph.amorDegrc&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_AmorDegrc", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_AmorDegrc : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;cost&quot; parameter, which is accepted by the &quot;microsoft.graph.amorDegrc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;cost&quot; parameter, which is accepted by the &quot;microsoft.graph.amorDegrc&quot; action.")]
        public System.Object cost { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;datePurchased&quot; parameter, which is accepted by the &quot;microsoft.graph.amorDegrc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;datePurchased&quot; parameter, which is accepted by the &quot;microsoft.graph.amorDegrc&quot; action.")]
        public System.Object datePurchased { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;firstPeriod&quot; parameter, which is accepted by the &quot;microsoft.graph.amorDegrc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;firstPeriod&quot; parameter, which is accepted by the &quot;microsoft.graph.amorDegrc&quot; action.")]
        public System.Object firstPeriod { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;salvage&quot; parameter, which is accepted by the &quot;microsoft.graph.amorDegrc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;salvage&quot; parameter, which is accepted by the &quot;microsoft.graph.amorDegrc&quot; action.")]
        public System.Object salvage { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;period&quot; parameter, which is accepted by the &quot;microsoft.graph.amorDegrc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; parameter, which is accepted by the &quot;microsoft.graph.amorDegrc&quot; action.")]
        public System.Object period { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.amorDegrc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.amorDegrc&quot; action.")]
        public System.Object rate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.amorDegrc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.amorDegrc&quot; action.")]
        public System.Object basis { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/amorDegrc";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/amorLinc</para>
    ///     <para type="description">The action &quot;microsoft.graph.amorLinc&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_AmorLinc", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_AmorLinc : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;cost&quot; parameter, which is accepted by the &quot;microsoft.graph.amorLinc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;cost&quot; parameter, which is accepted by the &quot;microsoft.graph.amorLinc&quot; action.")]
        public System.Object cost { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;datePurchased&quot; parameter, which is accepted by the &quot;microsoft.graph.amorLinc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;datePurchased&quot; parameter, which is accepted by the &quot;microsoft.graph.amorLinc&quot; action.")]
        public System.Object datePurchased { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;firstPeriod&quot; parameter, which is accepted by the &quot;microsoft.graph.amorLinc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;firstPeriod&quot; parameter, which is accepted by the &quot;microsoft.graph.amorLinc&quot; action.")]
        public System.Object firstPeriod { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;salvage&quot; parameter, which is accepted by the &quot;microsoft.graph.amorLinc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;salvage&quot; parameter, which is accepted by the &quot;microsoft.graph.amorLinc&quot; action.")]
        public System.Object salvage { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;period&quot; parameter, which is accepted by the &quot;microsoft.graph.amorLinc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; parameter, which is accepted by the &quot;microsoft.graph.amorLinc&quot; action.")]
        public System.Object period { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.amorLinc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.amorLinc&quot; action.")]
        public System.Object rate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.amorLinc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.amorLinc&quot; action.")]
        public System.Object basis { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/amorLinc";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/and</para>
    ///     <para type="description">The action &quot;microsoft.graph.and&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_And", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_And : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.and&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.and&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/and";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/arabic</para>
    ///     <para type="description">The action &quot;microsoft.graph.arabic&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Arabic", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Arabic : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.arabic&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.arabic&quot; action.")]
        public System.Object text { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/arabic";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/areas</para>
    ///     <para type="description">The action &quot;microsoft.graph.areas&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Areas", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Areas : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;reference&quot; parameter, which is accepted by the &quot;microsoft.graph.areas&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;reference&quot; parameter, which is accepted by the &quot;microsoft.graph.areas&quot; action.")]
        public System.Object reference { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/areas";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/asc</para>
    ///     <para type="description">The action &quot;microsoft.graph.asc&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Asc", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Asc : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.asc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.asc&quot; action.")]
        public System.Object text { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/asc";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/asin</para>
    ///     <para type="description">The action &quot;microsoft.graph.asin&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Asin", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Asin : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.asin&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.asin&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/asin";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/asinh</para>
    ///     <para type="description">The action &quot;microsoft.graph.asinh&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Asinh", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Asinh : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.asinh&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.asinh&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/asinh";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/atan</para>
    ///     <para type="description">The action &quot;microsoft.graph.atan&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Atan", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Atan : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.atan&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.atan&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/atan";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/atan2</para>
    ///     <para type="description">The action &quot;microsoft.graph.atan2&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Atan2", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Atan2 : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;xNum&quot; parameter, which is accepted by the &quot;microsoft.graph.atan2&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;xNum&quot; parameter, which is accepted by the &quot;microsoft.graph.atan2&quot; action.")]
        public System.Object xNum { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;yNum&quot; parameter, which is accepted by the &quot;microsoft.graph.atan2&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;yNum&quot; parameter, which is accepted by the &quot;microsoft.graph.atan2&quot; action.")]
        public System.Object yNum { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/atan2";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/atanh</para>
    ///     <para type="description">The action &quot;microsoft.graph.atanh&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Atanh", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Atanh : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.atanh&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.atanh&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/atanh";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/aveDev</para>
    ///     <para type="description">The action &quot;microsoft.graph.aveDev&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_AveDev", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_AveDev : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.aveDev&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.aveDev&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/aveDev";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/average</para>
    ///     <para type="description">The action &quot;microsoft.graph.average&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Average", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Average : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.average&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.average&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/average";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/averageA</para>
    ///     <para type="description">The action &quot;microsoft.graph.averageA&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_AverageA", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_AverageA : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.averageA&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.averageA&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/averageA";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/averageIf</para>
    ///     <para type="description">The action &quot;microsoft.graph.averageIf&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_AverageIf", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_AverageIf : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;range&quot; parameter, which is accepted by the &quot;microsoft.graph.averageIf&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;range&quot; parameter, which is accepted by the &quot;microsoft.graph.averageIf&quot; action.")]
        public System.Object range { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;criteria&quot; parameter, which is accepted by the &quot;microsoft.graph.averageIf&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;criteria&quot; parameter, which is accepted by the &quot;microsoft.graph.averageIf&quot; action.")]
        public System.Object criteria { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;averageRange&quot; parameter, which is accepted by the &quot;microsoft.graph.averageIf&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;averageRange&quot; parameter, which is accepted by the &quot;microsoft.graph.averageIf&quot; action.")]
        public System.Object averageRange { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/averageIf";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/averageIfs</para>
    ///     <para type="description">The action &quot;microsoft.graph.averageIfs&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_AverageIfs", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_AverageIfs : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;averageRange&quot; parameter, which is accepted by the &quot;microsoft.graph.averageIfs&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;averageRange&quot; parameter, which is accepted by the &quot;microsoft.graph.averageIfs&quot; action.")]
        public System.Object averageRange { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.averageIfs&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.averageIfs&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/averageIfs";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/bahtText</para>
    ///     <para type="description">The action &quot;microsoft.graph.bahtText&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_BahtText", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_BahtText : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.bahtText&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.bahtText&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/bahtText";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/base</para>
    ///     <para type="description">The action &quot;microsoft.graph.base&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Base", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Base : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.base&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.base&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;radix&quot; parameter, which is accepted by the &quot;microsoft.graph.base&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;radix&quot; parameter, which is accepted by the &quot;microsoft.graph.base&quot; action.")]
        public System.Object radix { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minLength&quot; parameter, which is accepted by the &quot;microsoft.graph.base&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;minLength&quot; parameter, which is accepted by the &quot;microsoft.graph.base&quot; action.")]
        public System.Object minLength { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/base";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/besselI</para>
    ///     <para type="description">The action &quot;microsoft.graph.besselI&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_BesselI", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_BesselI : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.besselI&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.besselI&quot; action.")]
        public System.Object x { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;n&quot; parameter, which is accepted by the &quot;microsoft.graph.besselI&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;n&quot; parameter, which is accepted by the &quot;microsoft.graph.besselI&quot; action.")]
        public System.Object n { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/besselI";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/besselJ</para>
    ///     <para type="description">The action &quot;microsoft.graph.besselJ&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_BesselJ", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_BesselJ : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.besselJ&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.besselJ&quot; action.")]
        public System.Object x { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;n&quot; parameter, which is accepted by the &quot;microsoft.graph.besselJ&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;n&quot; parameter, which is accepted by the &quot;microsoft.graph.besselJ&quot; action.")]
        public System.Object n { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/besselJ";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/besselK</para>
    ///     <para type="description">The action &quot;microsoft.graph.besselK&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_BesselK", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_BesselK : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.besselK&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.besselK&quot; action.")]
        public System.Object x { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;n&quot; parameter, which is accepted by the &quot;microsoft.graph.besselK&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;n&quot; parameter, which is accepted by the &quot;microsoft.graph.besselK&quot; action.")]
        public System.Object n { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/besselK";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/besselY</para>
    ///     <para type="description">The action &quot;microsoft.graph.besselY&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_BesselY", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_BesselY : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.besselY&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.besselY&quot; action.")]
        public System.Object x { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;n&quot; parameter, which is accepted by the &quot;microsoft.graph.besselY&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;n&quot; parameter, which is accepted by the &quot;microsoft.graph.besselY&quot; action.")]
        public System.Object n { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/besselY";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/beta_Dist</para>
    ///     <para type="description">The action &quot;microsoft.graph.beta_Dist&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_BetaDist", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_BetaDist : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.beta_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.beta_Dist&quot; action.")]
        public System.Object x { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;alpha&quot; parameter, which is accepted by the &quot;microsoft.graph.beta_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;alpha&quot; parameter, which is accepted by the &quot;microsoft.graph.beta_Dist&quot; action.")]
        public System.Object alpha { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;beta&quot; parameter, which is accepted by the &quot;microsoft.graph.beta_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;beta&quot; parameter, which is accepted by the &quot;microsoft.graph.beta_Dist&quot; action.")]
        public System.Object beta { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;cumulative&quot; parameter, which is accepted by the &quot;microsoft.graph.beta_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;cumulative&quot; parameter, which is accepted by the &quot;microsoft.graph.beta_Dist&quot; action.")]
        public System.Object cumulative { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;A&quot; parameter, which is accepted by the &quot;microsoft.graph.beta_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;A&quot; parameter, which is accepted by the &quot;microsoft.graph.beta_Dist&quot; action.")]
        public System.Object A { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;B&quot; parameter, which is accepted by the &quot;microsoft.graph.beta_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;B&quot; parameter, which is accepted by the &quot;microsoft.graph.beta_Dist&quot; action.")]
        public System.Object B { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/beta_Dist";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/beta_Inv</para>
    ///     <para type="description">The action &quot;microsoft.graph.beta_Inv&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_BetaInv", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_BetaInv : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;probability&quot; parameter, which is accepted by the &quot;microsoft.graph.beta_Inv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;probability&quot; parameter, which is accepted by the &quot;microsoft.graph.beta_Inv&quot; action.")]
        public System.Object probability { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;alpha&quot; parameter, which is accepted by the &quot;microsoft.graph.beta_Inv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;alpha&quot; parameter, which is accepted by the &quot;microsoft.graph.beta_Inv&quot; action.")]
        public System.Object alpha { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;beta&quot; parameter, which is accepted by the &quot;microsoft.graph.beta_Inv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;beta&quot; parameter, which is accepted by the &quot;microsoft.graph.beta_Inv&quot; action.")]
        public System.Object beta { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;A&quot; parameter, which is accepted by the &quot;microsoft.graph.beta_Inv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;A&quot; parameter, which is accepted by the &quot;microsoft.graph.beta_Inv&quot; action.")]
        public System.Object A { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;B&quot; parameter, which is accepted by the &quot;microsoft.graph.beta_Inv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;B&quot; parameter, which is accepted by the &quot;microsoft.graph.beta_Inv&quot; action.")]
        public System.Object B { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/beta_Inv";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/bin2Dec</para>
    ///     <para type="description">The action &quot;microsoft.graph.bin2Dec&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Bin2Dec", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Bin2Dec : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.bin2Dec&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.bin2Dec&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/bin2Dec";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/bin2Hex</para>
    ///     <para type="description">The action &quot;microsoft.graph.bin2Hex&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Bin2Hex", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Bin2Hex : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.bin2Hex&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.bin2Hex&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;places&quot; parameter, which is accepted by the &quot;microsoft.graph.bin2Hex&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;places&quot; parameter, which is accepted by the &quot;microsoft.graph.bin2Hex&quot; action.")]
        public System.Object places { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/bin2Hex";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/bin2Oct</para>
    ///     <para type="description">The action &quot;microsoft.graph.bin2Oct&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Bin2Oct", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Bin2Oct : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.bin2Oct&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.bin2Oct&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;places&quot; parameter, which is accepted by the &quot;microsoft.graph.bin2Oct&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;places&quot; parameter, which is accepted by the &quot;microsoft.graph.bin2Oct&quot; action.")]
        public System.Object places { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/bin2Oct";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/binom_Dist</para>
    ///     <para type="description">The action &quot;microsoft.graph.binom_Dist&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_BinomDist", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_BinomDist : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;numberS&quot; parameter, which is accepted by the &quot;microsoft.graph.binom_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;numberS&quot; parameter, which is accepted by the &quot;microsoft.graph.binom_Dist&quot; action.")]
        public System.Object numberS { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;trials&quot; parameter, which is accepted by the &quot;microsoft.graph.binom_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;trials&quot; parameter, which is accepted by the &quot;microsoft.graph.binom_Dist&quot; action.")]
        public System.Object trials { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;probabilityS&quot; parameter, which is accepted by the &quot;microsoft.graph.binom_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;probabilityS&quot; parameter, which is accepted by the &quot;microsoft.graph.binom_Dist&quot; action.")]
        public System.Object probabilityS { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;cumulative&quot; parameter, which is accepted by the &quot;microsoft.graph.binom_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;cumulative&quot; parameter, which is accepted by the &quot;microsoft.graph.binom_Dist&quot; action.")]
        public System.Object cumulative { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/binom_Dist";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/binom_Dist_Range</para>
    ///     <para type="description">The action &quot;microsoft.graph.binom_Dist_Range&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_BinomDistRange", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_BinomDistRange : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;trials&quot; parameter, which is accepted by the &quot;microsoft.graph.binom_Dist_Range&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;trials&quot; parameter, which is accepted by the &quot;microsoft.graph.binom_Dist_Range&quot; action.")]
        public System.Object trials { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;probabilityS&quot; parameter, which is accepted by the &quot;microsoft.graph.binom_Dist_Range&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;probabilityS&quot; parameter, which is accepted by the &quot;microsoft.graph.binom_Dist_Range&quot; action.")]
        public System.Object probabilityS { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;numberS&quot; parameter, which is accepted by the &quot;microsoft.graph.binom_Dist_Range&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;numberS&quot; parameter, which is accepted by the &quot;microsoft.graph.binom_Dist_Range&quot; action.")]
        public System.Object numberS { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;numberS2&quot; parameter, which is accepted by the &quot;microsoft.graph.binom_Dist_Range&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;numberS2&quot; parameter, which is accepted by the &quot;microsoft.graph.binom_Dist_Range&quot; action.")]
        public System.Object numberS2 { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/binom_Dist_Range";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/binom_Inv</para>
    ///     <para type="description">The action &quot;microsoft.graph.binom_Inv&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_BinomInv", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_BinomInv : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;trials&quot; parameter, which is accepted by the &quot;microsoft.graph.binom_Inv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;trials&quot; parameter, which is accepted by the &quot;microsoft.graph.binom_Inv&quot; action.")]
        public System.Object trials { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;probabilityS&quot; parameter, which is accepted by the &quot;microsoft.graph.binom_Inv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;probabilityS&quot; parameter, which is accepted by the &quot;microsoft.graph.binom_Inv&quot; action.")]
        public System.Object probabilityS { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;alpha&quot; parameter, which is accepted by the &quot;microsoft.graph.binom_Inv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;alpha&quot; parameter, which is accepted by the &quot;microsoft.graph.binom_Inv&quot; action.")]
        public System.Object alpha { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/binom_Inv";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/bitand</para>
    ///     <para type="description">The action &quot;microsoft.graph.bitand&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Bitand", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Bitand : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number1&quot; parameter, which is accepted by the &quot;microsoft.graph.bitand&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number1&quot; parameter, which is accepted by the &quot;microsoft.graph.bitand&quot; action.")]
        public System.Object number1 { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;number2&quot; parameter, which is accepted by the &quot;microsoft.graph.bitand&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number2&quot; parameter, which is accepted by the &quot;microsoft.graph.bitand&quot; action.")]
        public System.Object number2 { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/bitand";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/bitlshift</para>
    ///     <para type="description">The action &quot;microsoft.graph.bitlshift&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Bitlshift", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Bitlshift : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.bitlshift&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.bitlshift&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;shiftAmount&quot; parameter, which is accepted by the &quot;microsoft.graph.bitlshift&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;shiftAmount&quot; parameter, which is accepted by the &quot;microsoft.graph.bitlshift&quot; action.")]
        public System.Object shiftAmount { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/bitlshift";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/bitor</para>
    ///     <para type="description">The action &quot;microsoft.graph.bitor&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Bitor", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Bitor : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number1&quot; parameter, which is accepted by the &quot;microsoft.graph.bitor&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number1&quot; parameter, which is accepted by the &quot;microsoft.graph.bitor&quot; action.")]
        public System.Object number1 { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;number2&quot; parameter, which is accepted by the &quot;microsoft.graph.bitor&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number2&quot; parameter, which is accepted by the &quot;microsoft.graph.bitor&quot; action.")]
        public System.Object number2 { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/bitor";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/bitrshift</para>
    ///     <para type="description">The action &quot;microsoft.graph.bitrshift&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Bitrshift", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Bitrshift : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.bitrshift&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.bitrshift&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;shiftAmount&quot; parameter, which is accepted by the &quot;microsoft.graph.bitrshift&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;shiftAmount&quot; parameter, which is accepted by the &quot;microsoft.graph.bitrshift&quot; action.")]
        public System.Object shiftAmount { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/bitrshift";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/bitxor</para>
    ///     <para type="description">The action &quot;microsoft.graph.bitxor&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Bitxor", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Bitxor : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number1&quot; parameter, which is accepted by the &quot;microsoft.graph.bitxor&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number1&quot; parameter, which is accepted by the &quot;microsoft.graph.bitxor&quot; action.")]
        public System.Object number1 { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;number2&quot; parameter, which is accepted by the &quot;microsoft.graph.bitxor&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number2&quot; parameter, which is accepted by the &quot;microsoft.graph.bitxor&quot; action.")]
        public System.Object number2 { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/bitxor";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/ceiling_Math</para>
    ///     <para type="description">The action &quot;microsoft.graph.ceiling_Math&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_CeilingMath", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_CeilingMath : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.ceiling_Math&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.ceiling_Math&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;significance&quot; parameter, which is accepted by the &quot;microsoft.graph.ceiling_Math&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;significance&quot; parameter, which is accepted by the &quot;microsoft.graph.ceiling_Math&quot; action.")]
        public System.Object significance { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mode&quot; parameter, which is accepted by the &quot;microsoft.graph.ceiling_Math&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;mode&quot; parameter, which is accepted by the &quot;microsoft.graph.ceiling_Math&quot; action.")]
        public System.Object mode { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/ceiling_Math";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/ceiling_Precise</para>
    ///     <para type="description">The action &quot;microsoft.graph.ceiling_Precise&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_CeilingPrecise", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_CeilingPrecise : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.ceiling_Precise&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.ceiling_Precise&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;significance&quot; parameter, which is accepted by the &quot;microsoft.graph.ceiling_Precise&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;significance&quot; parameter, which is accepted by the &quot;microsoft.graph.ceiling_Precise&quot; action.")]
        public System.Object significance { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/ceiling_Precise";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/char</para>
    ///     <para type="description">The action &quot;microsoft.graph.char&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Char", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Char : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.char&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.char&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/char";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/chiSq_Dist</para>
    ///     <para type="description">The action &quot;microsoft.graph.chiSq_Dist&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_ChiSqDist", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_ChiSqDist : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.chiSq_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.chiSq_Dist&quot; action.")]
        public System.Object x { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;degFreedom&quot; parameter, which is accepted by the &quot;microsoft.graph.chiSq_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;degFreedom&quot; parameter, which is accepted by the &quot;microsoft.graph.chiSq_Dist&quot; action.")]
        public System.Object degFreedom { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;cumulative&quot; parameter, which is accepted by the &quot;microsoft.graph.chiSq_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;cumulative&quot; parameter, which is accepted by the &quot;microsoft.graph.chiSq_Dist&quot; action.")]
        public System.Object cumulative { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/chiSq_Dist";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/chiSq_Dist_RT</para>
    ///     <para type="description">The action &quot;microsoft.graph.chiSq_Dist_RT&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_ChiSqDistRT", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_ChiSqDistRT : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.chiSq_Dist_RT&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.chiSq_Dist_RT&quot; action.")]
        public System.Object x { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;degFreedom&quot; parameter, which is accepted by the &quot;microsoft.graph.chiSq_Dist_RT&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;degFreedom&quot; parameter, which is accepted by the &quot;microsoft.graph.chiSq_Dist_RT&quot; action.")]
        public System.Object degFreedom { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/chiSq_Dist_RT";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/chiSq_Inv</para>
    ///     <para type="description">The action &quot;microsoft.graph.chiSq_Inv&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_ChiSqInv", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_ChiSqInv : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;probability&quot; parameter, which is accepted by the &quot;microsoft.graph.chiSq_Inv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;probability&quot; parameter, which is accepted by the &quot;microsoft.graph.chiSq_Inv&quot; action.")]
        public System.Object probability { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;degFreedom&quot; parameter, which is accepted by the &quot;microsoft.graph.chiSq_Inv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;degFreedom&quot; parameter, which is accepted by the &quot;microsoft.graph.chiSq_Inv&quot; action.")]
        public System.Object degFreedom { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/chiSq_Inv";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/chiSq_Inv_RT</para>
    ///     <para type="description">The action &quot;microsoft.graph.chiSq_Inv_RT&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_ChiSqInvRT", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_ChiSqInvRT : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;probability&quot; parameter, which is accepted by the &quot;microsoft.graph.chiSq_Inv_RT&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;probability&quot; parameter, which is accepted by the &quot;microsoft.graph.chiSq_Inv_RT&quot; action.")]
        public System.Object probability { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;degFreedom&quot; parameter, which is accepted by the &quot;microsoft.graph.chiSq_Inv_RT&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;degFreedom&quot; parameter, which is accepted by the &quot;microsoft.graph.chiSq_Inv_RT&quot; action.")]
        public System.Object degFreedom { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/chiSq_Inv_RT";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/choose</para>
    ///     <para type="description">The action &quot;microsoft.graph.choose&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Choose", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Choose : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;indexNum&quot; parameter, which is accepted by the &quot;microsoft.graph.choose&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;indexNum&quot; parameter, which is accepted by the &quot;microsoft.graph.choose&quot; action.")]
        public System.Object indexNum { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.choose&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.choose&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/choose";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/clean</para>
    ///     <para type="description">The action &quot;microsoft.graph.clean&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Clean", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Clean : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.clean&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.clean&quot; action.")]
        public System.Object text { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/clean";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/code</para>
    ///     <para type="description">The action &quot;microsoft.graph.code&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Code", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Code : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.code&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.code&quot; action.")]
        public System.Object text { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/code";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/columns</para>
    ///     <para type="description">The action &quot;microsoft.graph.columns&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Columns", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Columns : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;array&quot; parameter, which is accepted by the &quot;microsoft.graph.columns&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;array&quot; parameter, which is accepted by the &quot;microsoft.graph.columns&quot; action.")]
        public System.Object array { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/columns";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/combin</para>
    ///     <para type="description">The action &quot;microsoft.graph.combin&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Combin", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Combin : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.combin&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.combin&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;numberChosen&quot; parameter, which is accepted by the &quot;microsoft.graph.combin&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;numberChosen&quot; parameter, which is accepted by the &quot;microsoft.graph.combin&quot; action.")]
        public System.Object numberChosen { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/combin";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/combina</para>
    ///     <para type="description">The action &quot;microsoft.graph.combina&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Combina", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Combina : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.combina&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.combina&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;numberChosen&quot; parameter, which is accepted by the &quot;microsoft.graph.combina&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;numberChosen&quot; parameter, which is accepted by the &quot;microsoft.graph.combina&quot; action.")]
        public System.Object numberChosen { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/combina";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/complex</para>
    ///     <para type="description">The action &quot;microsoft.graph.complex&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Complex", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Complex : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;realNum&quot; parameter, which is accepted by the &quot;microsoft.graph.complex&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;realNum&quot; parameter, which is accepted by the &quot;microsoft.graph.complex&quot; action.")]
        public System.Object realNum { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;iNum&quot; parameter, which is accepted by the &quot;microsoft.graph.complex&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;iNum&quot; parameter, which is accepted by the &quot;microsoft.graph.complex&quot; action.")]
        public System.Object iNum { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;suffix&quot; parameter, which is accepted by the &quot;microsoft.graph.complex&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;suffix&quot; parameter, which is accepted by the &quot;microsoft.graph.complex&quot; action.")]
        public System.Object suffix { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/complex";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/concatenate</para>
    ///     <para type="description">The action &quot;microsoft.graph.concatenate&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Concatenate", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Concatenate : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.concatenate&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.concatenate&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/concatenate";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/confidence_Norm</para>
    ///     <para type="description">The action &quot;microsoft.graph.confidence_Norm&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_ConfidenceNorm", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_ConfidenceNorm : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;alpha&quot; parameter, which is accepted by the &quot;microsoft.graph.confidence_Norm&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;alpha&quot; parameter, which is accepted by the &quot;microsoft.graph.confidence_Norm&quot; action.")]
        public System.Object alpha { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;standardDev&quot; parameter, which is accepted by the &quot;microsoft.graph.confidence_Norm&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;standardDev&quot; parameter, which is accepted by the &quot;microsoft.graph.confidence_Norm&quot; action.")]
        public System.Object standardDev { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;size&quot; parameter, which is accepted by the &quot;microsoft.graph.confidence_Norm&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;size&quot; parameter, which is accepted by the &quot;microsoft.graph.confidence_Norm&quot; action.")]
        public System.Object size { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/confidence_Norm";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/confidence_T</para>
    ///     <para type="description">The action &quot;microsoft.graph.confidence_T&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_ConfidenceT", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_ConfidenceT : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;alpha&quot; parameter, which is accepted by the &quot;microsoft.graph.confidence_T&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;alpha&quot; parameter, which is accepted by the &quot;microsoft.graph.confidence_T&quot; action.")]
        public System.Object alpha { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;standardDev&quot; parameter, which is accepted by the &quot;microsoft.graph.confidence_T&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;standardDev&quot; parameter, which is accepted by the &quot;microsoft.graph.confidence_T&quot; action.")]
        public System.Object standardDev { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;size&quot; parameter, which is accepted by the &quot;microsoft.graph.confidence_T&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;size&quot; parameter, which is accepted by the &quot;microsoft.graph.confidence_T&quot; action.")]
        public System.Object size { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/confidence_T";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/convert</para>
    ///     <para type="description">The action &quot;microsoft.graph.convert&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Convert", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Convert : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.convert&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.convert&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fromUnit&quot; parameter, which is accepted by the &quot;microsoft.graph.convert&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;fromUnit&quot; parameter, which is accepted by the &quot;microsoft.graph.convert&quot; action.")]
        public System.Object fromUnit { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;toUnit&quot; parameter, which is accepted by the &quot;microsoft.graph.convert&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;toUnit&quot; parameter, which is accepted by the &quot;microsoft.graph.convert&quot; action.")]
        public System.Object toUnit { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/convert";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/cos</para>
    ///     <para type="description">The action &quot;microsoft.graph.cos&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Cos", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Cos : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.cos&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.cos&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/cos";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/cosh</para>
    ///     <para type="description">The action &quot;microsoft.graph.cosh&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Cosh", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Cosh : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.cosh&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.cosh&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/cosh";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/cot</para>
    ///     <para type="description">The action &quot;microsoft.graph.cot&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Cot", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Cot : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.cot&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.cot&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/cot";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/coth</para>
    ///     <para type="description">The action &quot;microsoft.graph.coth&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Coth", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Coth : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.coth&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.coth&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/coth";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/count</para>
    ///     <para type="description">The action &quot;microsoft.graph.count&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Count", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Count : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.count&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.count&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/count";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/countA</para>
    ///     <para type="description">The action &quot;microsoft.graph.countA&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_CountA", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_CountA : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.countA&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.countA&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/countA";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/countBlank</para>
    ///     <para type="description">The action &quot;microsoft.graph.countBlank&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_CountBlank", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_CountBlank : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;range&quot; parameter, which is accepted by the &quot;microsoft.graph.countBlank&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;range&quot; parameter, which is accepted by the &quot;microsoft.graph.countBlank&quot; action.")]
        public System.Object range { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/countBlank";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/countIf</para>
    ///     <para type="description">The action &quot;microsoft.graph.countIf&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_CountIf", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_CountIf : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;range&quot; parameter, which is accepted by the &quot;microsoft.graph.countIf&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;range&quot; parameter, which is accepted by the &quot;microsoft.graph.countIf&quot; action.")]
        public System.Object range { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;criteria&quot; parameter, which is accepted by the &quot;microsoft.graph.countIf&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;criteria&quot; parameter, which is accepted by the &quot;microsoft.graph.countIf&quot; action.")]
        public System.Object criteria { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/countIf";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/countIfs</para>
    ///     <para type="description">The action &quot;microsoft.graph.countIfs&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_CountIfs", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_CountIfs : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.countIfs&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.countIfs&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/countIfs";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/coupDayBs</para>
    ///     <para type="description">The action &quot;microsoft.graph.coupDayBs&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_CoupDayBs", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_CoupDayBs : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.coupDayBs&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.coupDayBs&quot; action.")]
        public System.Object settlement { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.coupDayBs&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.coupDayBs&quot; action.")]
        public System.Object maturity { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;frequency&quot; parameter, which is accepted by the &quot;microsoft.graph.coupDayBs&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;frequency&quot; parameter, which is accepted by the &quot;microsoft.graph.coupDayBs&quot; action.")]
        public System.Object frequency { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.coupDayBs&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.coupDayBs&quot; action.")]
        public System.Object basis { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/coupDayBs";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/coupDays</para>
    ///     <para type="description">The action &quot;microsoft.graph.coupDays&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_CoupDays", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_CoupDays : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.coupDays&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.coupDays&quot; action.")]
        public System.Object settlement { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.coupDays&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.coupDays&quot; action.")]
        public System.Object maturity { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;frequency&quot; parameter, which is accepted by the &quot;microsoft.graph.coupDays&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;frequency&quot; parameter, which is accepted by the &quot;microsoft.graph.coupDays&quot; action.")]
        public System.Object frequency { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.coupDays&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.coupDays&quot; action.")]
        public System.Object basis { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/coupDays";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/coupDaysNc</para>
    ///     <para type="description">The action &quot;microsoft.graph.coupDaysNc&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_CoupDaysNc", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_CoupDaysNc : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.coupDaysNc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.coupDaysNc&quot; action.")]
        public System.Object settlement { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.coupDaysNc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.coupDaysNc&quot; action.")]
        public System.Object maturity { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;frequency&quot; parameter, which is accepted by the &quot;microsoft.graph.coupDaysNc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;frequency&quot; parameter, which is accepted by the &quot;microsoft.graph.coupDaysNc&quot; action.")]
        public System.Object frequency { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.coupDaysNc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.coupDaysNc&quot; action.")]
        public System.Object basis { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/coupDaysNc";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/coupNcd</para>
    ///     <para type="description">The action &quot;microsoft.graph.coupNcd&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_CoupNcd", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_CoupNcd : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.coupNcd&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.coupNcd&quot; action.")]
        public System.Object settlement { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.coupNcd&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.coupNcd&quot; action.")]
        public System.Object maturity { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;frequency&quot; parameter, which is accepted by the &quot;microsoft.graph.coupNcd&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;frequency&quot; parameter, which is accepted by the &quot;microsoft.graph.coupNcd&quot; action.")]
        public System.Object frequency { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.coupNcd&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.coupNcd&quot; action.")]
        public System.Object basis { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/coupNcd";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/coupNum</para>
    ///     <para type="description">The action &quot;microsoft.graph.coupNum&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_CoupNum", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_CoupNum : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.coupNum&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.coupNum&quot; action.")]
        public System.Object settlement { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.coupNum&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.coupNum&quot; action.")]
        public System.Object maturity { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;frequency&quot; parameter, which is accepted by the &quot;microsoft.graph.coupNum&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;frequency&quot; parameter, which is accepted by the &quot;microsoft.graph.coupNum&quot; action.")]
        public System.Object frequency { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.coupNum&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.coupNum&quot; action.")]
        public System.Object basis { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/coupNum";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/coupPcd</para>
    ///     <para type="description">The action &quot;microsoft.graph.coupPcd&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_CoupPcd", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_CoupPcd : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.coupPcd&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.coupPcd&quot; action.")]
        public System.Object settlement { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.coupPcd&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.coupPcd&quot; action.")]
        public System.Object maturity { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;frequency&quot; parameter, which is accepted by the &quot;microsoft.graph.coupPcd&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;frequency&quot; parameter, which is accepted by the &quot;microsoft.graph.coupPcd&quot; action.")]
        public System.Object frequency { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.coupPcd&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.coupPcd&quot; action.")]
        public System.Object basis { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/coupPcd";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/csc</para>
    ///     <para type="description">The action &quot;microsoft.graph.csc&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Csc", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Csc : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.csc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.csc&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/csc";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/csch</para>
    ///     <para type="description">The action &quot;microsoft.graph.csch&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Csch", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Csch : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.csch&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.csch&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/csch";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/cumIPmt</para>
    ///     <para type="description">The action &quot;microsoft.graph.cumIPmt&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_CumIPmt", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_CumIPmt : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.cumIPmt&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.cumIPmt&quot; action.")]
        public System.Object rate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;nper&quot; parameter, which is accepted by the &quot;microsoft.graph.cumIPmt&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;nper&quot; parameter, which is accepted by the &quot;microsoft.graph.cumIPmt&quot; action.")]
        public System.Object nper { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pv&quot; parameter, which is accepted by the &quot;microsoft.graph.cumIPmt&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;pv&quot; parameter, which is accepted by the &quot;microsoft.graph.cumIPmt&quot; action.")]
        public System.Object pv { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;startPeriod&quot; parameter, which is accepted by the &quot;microsoft.graph.cumIPmt&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;startPeriod&quot; parameter, which is accepted by the &quot;microsoft.graph.cumIPmt&quot; action.")]
        public System.Object startPeriod { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;endPeriod&quot; parameter, which is accepted by the &quot;microsoft.graph.cumIPmt&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;endPeriod&quot; parameter, which is accepted by the &quot;microsoft.graph.cumIPmt&quot; action.")]
        public System.Object endPeriod { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;type&quot; parameter, which is accepted by the &quot;microsoft.graph.cumIPmt&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;type&quot; parameter, which is accepted by the &quot;microsoft.graph.cumIPmt&quot; action.")]
        public System.Object type { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/cumIPmt";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/cumPrinc</para>
    ///     <para type="description">The action &quot;microsoft.graph.cumPrinc&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_CumPrinc", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_CumPrinc : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.cumPrinc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.cumPrinc&quot; action.")]
        public System.Object rate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;nper&quot; parameter, which is accepted by the &quot;microsoft.graph.cumPrinc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;nper&quot; parameter, which is accepted by the &quot;microsoft.graph.cumPrinc&quot; action.")]
        public System.Object nper { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pv&quot; parameter, which is accepted by the &quot;microsoft.graph.cumPrinc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;pv&quot; parameter, which is accepted by the &quot;microsoft.graph.cumPrinc&quot; action.")]
        public System.Object pv { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;startPeriod&quot; parameter, which is accepted by the &quot;microsoft.graph.cumPrinc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;startPeriod&quot; parameter, which is accepted by the &quot;microsoft.graph.cumPrinc&quot; action.")]
        public System.Object startPeriod { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;endPeriod&quot; parameter, which is accepted by the &quot;microsoft.graph.cumPrinc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;endPeriod&quot; parameter, which is accepted by the &quot;microsoft.graph.cumPrinc&quot; action.")]
        public System.Object endPeriod { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;type&quot; parameter, which is accepted by the &quot;microsoft.graph.cumPrinc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;type&quot; parameter, which is accepted by the &quot;microsoft.graph.cumPrinc&quot; action.")]
        public System.Object type { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/cumPrinc";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/daverage</para>
    ///     <para type="description">The action &quot;microsoft.graph.daverage&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Daverage", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Daverage : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;database&quot; parameter, which is accepted by the &quot;microsoft.graph.daverage&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;database&quot; parameter, which is accepted by the &quot;microsoft.graph.daverage&quot; action.")]
        public System.Object database { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;field&quot; parameter, which is accepted by the &quot;microsoft.graph.daverage&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;field&quot; parameter, which is accepted by the &quot;microsoft.graph.daverage&quot; action.")]
        public System.Object field { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;criteria&quot; parameter, which is accepted by the &quot;microsoft.graph.daverage&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;criteria&quot; parameter, which is accepted by the &quot;microsoft.graph.daverage&quot; action.")]
        public System.Object criteria { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/daverage";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/dcount</para>
    ///     <para type="description">The action &quot;microsoft.graph.dcount&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Dcount", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Dcount : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;database&quot; parameter, which is accepted by the &quot;microsoft.graph.dcount&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;database&quot; parameter, which is accepted by the &quot;microsoft.graph.dcount&quot; action.")]
        public System.Object database { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;field&quot; parameter, which is accepted by the &quot;microsoft.graph.dcount&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;field&quot; parameter, which is accepted by the &quot;microsoft.graph.dcount&quot; action.")]
        public System.Object field { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;criteria&quot; parameter, which is accepted by the &quot;microsoft.graph.dcount&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;criteria&quot; parameter, which is accepted by the &quot;microsoft.graph.dcount&quot; action.")]
        public System.Object criteria { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/dcount";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/dcountA</para>
    ///     <para type="description">The action &quot;microsoft.graph.dcountA&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_DcountA", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_DcountA : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;database&quot; parameter, which is accepted by the &quot;microsoft.graph.dcountA&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;database&quot; parameter, which is accepted by the &quot;microsoft.graph.dcountA&quot; action.")]
        public System.Object database { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;field&quot; parameter, which is accepted by the &quot;microsoft.graph.dcountA&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;field&quot; parameter, which is accepted by the &quot;microsoft.graph.dcountA&quot; action.")]
        public System.Object field { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;criteria&quot; parameter, which is accepted by the &quot;microsoft.graph.dcountA&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;criteria&quot; parameter, which is accepted by the &quot;microsoft.graph.dcountA&quot; action.")]
        public System.Object criteria { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/dcountA";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/dget</para>
    ///     <para type="description">The action &quot;microsoft.graph.dget&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Dget", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Dget : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;database&quot; parameter, which is accepted by the &quot;microsoft.graph.dget&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;database&quot; parameter, which is accepted by the &quot;microsoft.graph.dget&quot; action.")]
        public System.Object database { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;field&quot; parameter, which is accepted by the &quot;microsoft.graph.dget&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;field&quot; parameter, which is accepted by the &quot;microsoft.graph.dget&quot; action.")]
        public System.Object field { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;criteria&quot; parameter, which is accepted by the &quot;microsoft.graph.dget&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;criteria&quot; parameter, which is accepted by the &quot;microsoft.graph.dget&quot; action.")]
        public System.Object criteria { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/dget";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/dmax</para>
    ///     <para type="description">The action &quot;microsoft.graph.dmax&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Dmax", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Dmax : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;database&quot; parameter, which is accepted by the &quot;microsoft.graph.dmax&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;database&quot; parameter, which is accepted by the &quot;microsoft.graph.dmax&quot; action.")]
        public System.Object database { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;field&quot; parameter, which is accepted by the &quot;microsoft.graph.dmax&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;field&quot; parameter, which is accepted by the &quot;microsoft.graph.dmax&quot; action.")]
        public System.Object field { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;criteria&quot; parameter, which is accepted by the &quot;microsoft.graph.dmax&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;criteria&quot; parameter, which is accepted by the &quot;microsoft.graph.dmax&quot; action.")]
        public System.Object criteria { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/dmax";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/dmin</para>
    ///     <para type="description">The action &quot;microsoft.graph.dmin&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Dmin", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Dmin : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;database&quot; parameter, which is accepted by the &quot;microsoft.graph.dmin&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;database&quot; parameter, which is accepted by the &quot;microsoft.graph.dmin&quot; action.")]
        public System.Object database { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;field&quot; parameter, which is accepted by the &quot;microsoft.graph.dmin&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;field&quot; parameter, which is accepted by the &quot;microsoft.graph.dmin&quot; action.")]
        public System.Object field { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;criteria&quot; parameter, which is accepted by the &quot;microsoft.graph.dmin&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;criteria&quot; parameter, which is accepted by the &quot;microsoft.graph.dmin&quot; action.")]
        public System.Object criteria { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/dmin";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/dproduct</para>
    ///     <para type="description">The action &quot;microsoft.graph.dproduct&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Dproduct", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Dproduct : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;database&quot; parameter, which is accepted by the &quot;microsoft.graph.dproduct&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;database&quot; parameter, which is accepted by the &quot;microsoft.graph.dproduct&quot; action.")]
        public System.Object database { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;field&quot; parameter, which is accepted by the &quot;microsoft.graph.dproduct&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;field&quot; parameter, which is accepted by the &quot;microsoft.graph.dproduct&quot; action.")]
        public System.Object field { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;criteria&quot; parameter, which is accepted by the &quot;microsoft.graph.dproduct&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;criteria&quot; parameter, which is accepted by the &quot;microsoft.graph.dproduct&quot; action.")]
        public System.Object criteria { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/dproduct";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/dstDev</para>
    ///     <para type="description">The action &quot;microsoft.graph.dstDev&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_DstDev", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_DstDev : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;database&quot; parameter, which is accepted by the &quot;microsoft.graph.dstDev&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;database&quot; parameter, which is accepted by the &quot;microsoft.graph.dstDev&quot; action.")]
        public System.Object database { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;field&quot; parameter, which is accepted by the &quot;microsoft.graph.dstDev&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;field&quot; parameter, which is accepted by the &quot;microsoft.graph.dstDev&quot; action.")]
        public System.Object field { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;criteria&quot; parameter, which is accepted by the &quot;microsoft.graph.dstDev&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;criteria&quot; parameter, which is accepted by the &quot;microsoft.graph.dstDev&quot; action.")]
        public System.Object criteria { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/dstDev";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/dstDevP</para>
    ///     <para type="description">The action &quot;microsoft.graph.dstDevP&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_DstDevP", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_DstDevP : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;database&quot; parameter, which is accepted by the &quot;microsoft.graph.dstDevP&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;database&quot; parameter, which is accepted by the &quot;microsoft.graph.dstDevP&quot; action.")]
        public System.Object database { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;field&quot; parameter, which is accepted by the &quot;microsoft.graph.dstDevP&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;field&quot; parameter, which is accepted by the &quot;microsoft.graph.dstDevP&quot; action.")]
        public System.Object field { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;criteria&quot; parameter, which is accepted by the &quot;microsoft.graph.dstDevP&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;criteria&quot; parameter, which is accepted by the &quot;microsoft.graph.dstDevP&quot; action.")]
        public System.Object criteria { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/dstDevP";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/dsum</para>
    ///     <para type="description">The action &quot;microsoft.graph.dsum&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Dsum", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Dsum : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;database&quot; parameter, which is accepted by the &quot;microsoft.graph.dsum&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;database&quot; parameter, which is accepted by the &quot;microsoft.graph.dsum&quot; action.")]
        public System.Object database { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;field&quot; parameter, which is accepted by the &quot;microsoft.graph.dsum&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;field&quot; parameter, which is accepted by the &quot;microsoft.graph.dsum&quot; action.")]
        public System.Object field { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;criteria&quot; parameter, which is accepted by the &quot;microsoft.graph.dsum&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;criteria&quot; parameter, which is accepted by the &quot;microsoft.graph.dsum&quot; action.")]
        public System.Object criteria { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/dsum";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/dvar</para>
    ///     <para type="description">The action &quot;microsoft.graph.dvar&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Dvar", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Dvar : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;database&quot; parameter, which is accepted by the &quot;microsoft.graph.dvar&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;database&quot; parameter, which is accepted by the &quot;microsoft.graph.dvar&quot; action.")]
        public System.Object database { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;field&quot; parameter, which is accepted by the &quot;microsoft.graph.dvar&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;field&quot; parameter, which is accepted by the &quot;microsoft.graph.dvar&quot; action.")]
        public System.Object field { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;criteria&quot; parameter, which is accepted by the &quot;microsoft.graph.dvar&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;criteria&quot; parameter, which is accepted by the &quot;microsoft.graph.dvar&quot; action.")]
        public System.Object criteria { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/dvar";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/dvarP</para>
    ///     <para type="description">The action &quot;microsoft.graph.dvarP&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_DvarP", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_DvarP : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;database&quot; parameter, which is accepted by the &quot;microsoft.graph.dvarP&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;database&quot; parameter, which is accepted by the &quot;microsoft.graph.dvarP&quot; action.")]
        public System.Object database { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;field&quot; parameter, which is accepted by the &quot;microsoft.graph.dvarP&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;field&quot; parameter, which is accepted by the &quot;microsoft.graph.dvarP&quot; action.")]
        public System.Object field { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;criteria&quot; parameter, which is accepted by the &quot;microsoft.graph.dvarP&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;criteria&quot; parameter, which is accepted by the &quot;microsoft.graph.dvarP&quot; action.")]
        public System.Object criteria { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/dvarP";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/date</para>
    ///     <para type="description">The action &quot;microsoft.graph.date&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Date", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Date : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;year&quot; parameter, which is accepted by the &quot;microsoft.graph.date&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;year&quot; parameter, which is accepted by the &quot;microsoft.graph.date&quot; action.")]
        public System.Object year { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;month&quot; parameter, which is accepted by the &quot;microsoft.graph.date&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;month&quot; parameter, which is accepted by the &quot;microsoft.graph.date&quot; action.")]
        public System.Object month { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;day&quot; parameter, which is accepted by the &quot;microsoft.graph.date&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;day&quot; parameter, which is accepted by the &quot;microsoft.graph.date&quot; action.")]
        public System.Object day { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/date";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/datevalue</para>
    ///     <para type="description">The action &quot;microsoft.graph.datevalue&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Datevalue", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Datevalue : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;dateText&quot; parameter, which is accepted by the &quot;microsoft.graph.datevalue&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;dateText&quot; parameter, which is accepted by the &quot;microsoft.graph.datevalue&quot; action.")]
        public System.Object dateText { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/datevalue";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/day</para>
    ///     <para type="description">The action &quot;microsoft.graph.day&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Day", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Day : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;serialNumber&quot; parameter, which is accepted by the &quot;microsoft.graph.day&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;serialNumber&quot; parameter, which is accepted by the &quot;microsoft.graph.day&quot; action.")]
        public System.Object serialNumber { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/day";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/days</para>
    ///     <para type="description">The action &quot;microsoft.graph.days&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Days", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Days : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;endDate&quot; parameter, which is accepted by the &quot;microsoft.graph.days&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;endDate&quot; parameter, which is accepted by the &quot;microsoft.graph.days&quot; action.")]
        public System.Object endDate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;startDate&quot; parameter, which is accepted by the &quot;microsoft.graph.days&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;startDate&quot; parameter, which is accepted by the &quot;microsoft.graph.days&quot; action.")]
        public System.Object startDate { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/days";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/days360</para>
    ///     <para type="description">The action &quot;microsoft.graph.days360&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Days360", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Days360 : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;startDate&quot; parameter, which is accepted by the &quot;microsoft.graph.days360&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;startDate&quot; parameter, which is accepted by the &quot;microsoft.graph.days360&quot; action.")]
        public System.Object startDate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;endDate&quot; parameter, which is accepted by the &quot;microsoft.graph.days360&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;endDate&quot; parameter, which is accepted by the &quot;microsoft.graph.days360&quot; action.")]
        public System.Object endDate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;method&quot; parameter, which is accepted by the &quot;microsoft.graph.days360&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;method&quot; parameter, which is accepted by the &quot;microsoft.graph.days360&quot; action.")]
        public System.Object method { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/days360";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/db</para>
    ///     <para type="description">The action &quot;microsoft.graph.db&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Db", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Db : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;cost&quot; parameter, which is accepted by the &quot;microsoft.graph.db&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;cost&quot; parameter, which is accepted by the &quot;microsoft.graph.db&quot; action.")]
        public System.Object cost { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;salvage&quot; parameter, which is accepted by the &quot;microsoft.graph.db&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;salvage&quot; parameter, which is accepted by the &quot;microsoft.graph.db&quot; action.")]
        public System.Object salvage { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;life&quot; parameter, which is accepted by the &quot;microsoft.graph.db&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;life&quot; parameter, which is accepted by the &quot;microsoft.graph.db&quot; action.")]
        public System.Object life { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;period&quot; parameter, which is accepted by the &quot;microsoft.graph.db&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; parameter, which is accepted by the &quot;microsoft.graph.db&quot; action.")]
        public System.Object period { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;month&quot; parameter, which is accepted by the &quot;microsoft.graph.db&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;month&quot; parameter, which is accepted by the &quot;microsoft.graph.db&quot; action.")]
        public System.Object month { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/db";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/dbcs</para>
    ///     <para type="description">The action &quot;microsoft.graph.dbcs&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Dbcs", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Dbcs : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.dbcs&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.dbcs&quot; action.")]
        public System.Object text { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/dbcs";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/ddb</para>
    ///     <para type="description">The action &quot;microsoft.graph.ddb&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Ddb", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Ddb : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;cost&quot; parameter, which is accepted by the &quot;microsoft.graph.ddb&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;cost&quot; parameter, which is accepted by the &quot;microsoft.graph.ddb&quot; action.")]
        public System.Object cost { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;salvage&quot; parameter, which is accepted by the &quot;microsoft.graph.ddb&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;salvage&quot; parameter, which is accepted by the &quot;microsoft.graph.ddb&quot; action.")]
        public System.Object salvage { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;life&quot; parameter, which is accepted by the &quot;microsoft.graph.ddb&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;life&quot; parameter, which is accepted by the &quot;microsoft.graph.ddb&quot; action.")]
        public System.Object life { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;period&quot; parameter, which is accepted by the &quot;microsoft.graph.ddb&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;period&quot; parameter, which is accepted by the &quot;microsoft.graph.ddb&quot; action.")]
        public System.Object period { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;factor&quot; parameter, which is accepted by the &quot;microsoft.graph.ddb&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;factor&quot; parameter, which is accepted by the &quot;microsoft.graph.ddb&quot; action.")]
        public System.Object factor { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/ddb";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/dec2Bin</para>
    ///     <para type="description">The action &quot;microsoft.graph.dec2Bin&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Dec2Bin", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Dec2Bin : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.dec2Bin&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.dec2Bin&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;places&quot; parameter, which is accepted by the &quot;microsoft.graph.dec2Bin&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;places&quot; parameter, which is accepted by the &quot;microsoft.graph.dec2Bin&quot; action.")]
        public System.Object places { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/dec2Bin";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/dec2Hex</para>
    ///     <para type="description">The action &quot;microsoft.graph.dec2Hex&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Dec2Hex", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Dec2Hex : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.dec2Hex&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.dec2Hex&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;places&quot; parameter, which is accepted by the &quot;microsoft.graph.dec2Hex&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;places&quot; parameter, which is accepted by the &quot;microsoft.graph.dec2Hex&quot; action.")]
        public System.Object places { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/dec2Hex";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/dec2Oct</para>
    ///     <para type="description">The action &quot;microsoft.graph.dec2Oct&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Dec2Oct", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Dec2Oct : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.dec2Oct&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.dec2Oct&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;places&quot; parameter, which is accepted by the &quot;microsoft.graph.dec2Oct&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;places&quot; parameter, which is accepted by the &quot;microsoft.graph.dec2Oct&quot; action.")]
        public System.Object places { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/dec2Oct";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/decimal</para>
    ///     <para type="description">The action &quot;microsoft.graph.decimal&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Decimal", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Decimal : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.decimal&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.decimal&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;radix&quot; parameter, which is accepted by the &quot;microsoft.graph.decimal&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;radix&quot; parameter, which is accepted by the &quot;microsoft.graph.decimal&quot; action.")]
        public System.Object radix { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/decimal";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/degrees</para>
    ///     <para type="description">The action &quot;microsoft.graph.degrees&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Degrees", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Degrees : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;angle&quot; parameter, which is accepted by the &quot;microsoft.graph.degrees&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;angle&quot; parameter, which is accepted by the &quot;microsoft.graph.degrees&quot; action.")]
        public System.Object angle { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/degrees";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/delta</para>
    ///     <para type="description">The action &quot;microsoft.graph.delta&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Delta", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Delta : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number1&quot; parameter, which is accepted by the &quot;microsoft.graph.delta&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number1&quot; parameter, which is accepted by the &quot;microsoft.graph.delta&quot; action.")]
        public System.Object number1 { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;number2&quot; parameter, which is accepted by the &quot;microsoft.graph.delta&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number2&quot; parameter, which is accepted by the &quot;microsoft.graph.delta&quot; action.")]
        public System.Object number2 { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/delta";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/devSq</para>
    ///     <para type="description">The action &quot;microsoft.graph.devSq&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_DevSq", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_DevSq : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.devSq&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.devSq&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/devSq";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/disc</para>
    ///     <para type="description">The action &quot;microsoft.graph.disc&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Disc", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Disc : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.disc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.disc&quot; action.")]
        public System.Object settlement { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.disc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.disc&quot; action.")]
        public System.Object maturity { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pr&quot; parameter, which is accepted by the &quot;microsoft.graph.disc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;pr&quot; parameter, which is accepted by the &quot;microsoft.graph.disc&quot; action.")]
        public System.Object pr { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;redemption&quot; parameter, which is accepted by the &quot;microsoft.graph.disc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;redemption&quot; parameter, which is accepted by the &quot;microsoft.graph.disc&quot; action.")]
        public System.Object redemption { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.disc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.disc&quot; action.")]
        public System.Object basis { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/disc";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/dollar</para>
    ///     <para type="description">The action &quot;microsoft.graph.dollar&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Dollar", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Dollar : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.dollar&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.dollar&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;decimals&quot; parameter, which is accepted by the &quot;microsoft.graph.dollar&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;decimals&quot; parameter, which is accepted by the &quot;microsoft.graph.dollar&quot; action.")]
        public System.Object decimals { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/dollar";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/dollarDe</para>
    ///     <para type="description">The action &quot;microsoft.graph.dollarDe&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_DollarDe", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_DollarDe : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;fractionalDollar&quot; parameter, which is accepted by the &quot;microsoft.graph.dollarDe&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;fractionalDollar&quot; parameter, which is accepted by the &quot;microsoft.graph.dollarDe&quot; action.")]
        public System.Object fractionalDollar { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fraction&quot; parameter, which is accepted by the &quot;microsoft.graph.dollarDe&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;fraction&quot; parameter, which is accepted by the &quot;microsoft.graph.dollarDe&quot; action.")]
        public System.Object fraction { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/dollarDe";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/dollarFr</para>
    ///     <para type="description">The action &quot;microsoft.graph.dollarFr&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_DollarFr", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_DollarFr : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;decimalDollar&quot; parameter, which is accepted by the &quot;microsoft.graph.dollarFr&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;decimalDollar&quot; parameter, which is accepted by the &quot;microsoft.graph.dollarFr&quot; action.")]
        public System.Object decimalDollar { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fraction&quot; parameter, which is accepted by the &quot;microsoft.graph.dollarFr&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;fraction&quot; parameter, which is accepted by the &quot;microsoft.graph.dollarFr&quot; action.")]
        public System.Object fraction { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/dollarFr";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/duration</para>
    ///     <para type="description">The action &quot;microsoft.graph.duration&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Duration", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Duration : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.duration&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.duration&quot; action.")]
        public System.Object settlement { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.duration&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.duration&quot; action.")]
        public System.Object maturity { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;coupon&quot; parameter, which is accepted by the &quot;microsoft.graph.duration&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;coupon&quot; parameter, which is accepted by the &quot;microsoft.graph.duration&quot; action.")]
        public System.Object coupon { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;yld&quot; parameter, which is accepted by the &quot;microsoft.graph.duration&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;yld&quot; parameter, which is accepted by the &quot;microsoft.graph.duration&quot; action.")]
        public System.Object yld { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;frequency&quot; parameter, which is accepted by the &quot;microsoft.graph.duration&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;frequency&quot; parameter, which is accepted by the &quot;microsoft.graph.duration&quot; action.")]
        public System.Object frequency { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.duration&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.duration&quot; action.")]
        public System.Object basis { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/duration";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/ecma_Ceiling</para>
    ///     <para type="description">The action &quot;microsoft.graph.ecma_Ceiling&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_EcmaCeiling", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_EcmaCeiling : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.ecma_Ceiling&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.ecma_Ceiling&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;significance&quot; parameter, which is accepted by the &quot;microsoft.graph.ecma_Ceiling&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;significance&quot; parameter, which is accepted by the &quot;microsoft.graph.ecma_Ceiling&quot; action.")]
        public System.Object significance { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/ecma_Ceiling";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/edate</para>
    ///     <para type="description">The action &quot;microsoft.graph.edate&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Edate", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Edate : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;startDate&quot; parameter, which is accepted by the &quot;microsoft.graph.edate&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;startDate&quot; parameter, which is accepted by the &quot;microsoft.graph.edate&quot; action.")]
        public System.Object startDate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;months&quot; parameter, which is accepted by the &quot;microsoft.graph.edate&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;months&quot; parameter, which is accepted by the &quot;microsoft.graph.edate&quot; action.")]
        public System.Object months { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/edate";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/effect</para>
    ///     <para type="description">The action &quot;microsoft.graph.effect&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Effect", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Effect : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;nominalRate&quot; parameter, which is accepted by the &quot;microsoft.graph.effect&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;nominalRate&quot; parameter, which is accepted by the &quot;microsoft.graph.effect&quot; action.")]
        public System.Object nominalRate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;npery&quot; parameter, which is accepted by the &quot;microsoft.graph.effect&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;npery&quot; parameter, which is accepted by the &quot;microsoft.graph.effect&quot; action.")]
        public System.Object npery { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/effect";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/eoMonth</para>
    ///     <para type="description">The action &quot;microsoft.graph.eoMonth&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_EoMonth", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_EoMonth : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;startDate&quot; parameter, which is accepted by the &quot;microsoft.graph.eoMonth&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;startDate&quot; parameter, which is accepted by the &quot;microsoft.graph.eoMonth&quot; action.")]
        public System.Object startDate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;months&quot; parameter, which is accepted by the &quot;microsoft.graph.eoMonth&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;months&quot; parameter, which is accepted by the &quot;microsoft.graph.eoMonth&quot; action.")]
        public System.Object months { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/eoMonth";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/erf</para>
    ///     <para type="description">The action &quot;microsoft.graph.erf&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Erf", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Erf : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;lowerLimit&quot; parameter, which is accepted by the &quot;microsoft.graph.erf&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;lowerLimit&quot; parameter, which is accepted by the &quot;microsoft.graph.erf&quot; action.")]
        public System.Object lowerLimit { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;upperLimit&quot; parameter, which is accepted by the &quot;microsoft.graph.erf&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;upperLimit&quot; parameter, which is accepted by the &quot;microsoft.graph.erf&quot; action.")]
        public System.Object upperLimit { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/erf";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/erfC</para>
    ///     <para type="description">The action &quot;microsoft.graph.erfC&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_ErfC", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_ErfC : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.erfC&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.erfC&quot; action.")]
        public System.Object x { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/erfC";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/erfC_Precise</para>
    ///     <para type="description">The action &quot;microsoft.graph.erfC_Precise&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_ErfCPrecise", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_ErfCPrecise : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;X&quot; parameter, which is accepted by the &quot;microsoft.graph.erfC_Precise&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;X&quot; parameter, which is accepted by the &quot;microsoft.graph.erfC_Precise&quot; action.")]
        public System.Object X { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/erfC_Precise";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/erf_Precise</para>
    ///     <para type="description">The action &quot;microsoft.graph.erf_Precise&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_ErfPrecise", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_ErfPrecise : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;X&quot; parameter, which is accepted by the &quot;microsoft.graph.erf_Precise&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;X&quot; parameter, which is accepted by the &quot;microsoft.graph.erf_Precise&quot; action.")]
        public System.Object X { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/erf_Precise";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/error_Type</para>
    ///     <para type="description">The action &quot;microsoft.graph.error_Type&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_ErrorType", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_ErrorType : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;errorVal&quot; parameter, which is accepted by the &quot;microsoft.graph.error_Type&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;errorVal&quot; parameter, which is accepted by the &quot;microsoft.graph.error_Type&quot; action.")]
        public System.Object errorVal { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/error_Type";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/even</para>
    ///     <para type="description">The action &quot;microsoft.graph.even&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Even", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Even : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.even&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.even&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/even";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/exact</para>
    ///     <para type="description">The action &quot;microsoft.graph.exact&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Exact", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Exact : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;text1&quot; parameter, which is accepted by the &quot;microsoft.graph.exact&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;text1&quot; parameter, which is accepted by the &quot;microsoft.graph.exact&quot; action.")]
        public System.Object text1 { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;text2&quot; parameter, which is accepted by the &quot;microsoft.graph.exact&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;text2&quot; parameter, which is accepted by the &quot;microsoft.graph.exact&quot; action.")]
        public System.Object text2 { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/exact";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/exp</para>
    ///     <para type="description">The action &quot;microsoft.graph.exp&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Exp", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Exp : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.exp&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.exp&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/exp";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/expon_Dist</para>
    ///     <para type="description">The action &quot;microsoft.graph.expon_Dist&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_ExponDist", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_ExponDist : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.expon_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.expon_Dist&quot; action.")]
        public System.Object x { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lambda&quot; parameter, which is accepted by the &quot;microsoft.graph.expon_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;lambda&quot; parameter, which is accepted by the &quot;microsoft.graph.expon_Dist&quot; action.")]
        public System.Object lambda { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;cumulative&quot; parameter, which is accepted by the &quot;microsoft.graph.expon_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;cumulative&quot; parameter, which is accepted by the &quot;microsoft.graph.expon_Dist&quot; action.")]
        public System.Object cumulative { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/expon_Dist";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/fvschedule</para>
    ///     <para type="description">The action &quot;microsoft.graph.fvschedule&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Fvschedule", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Fvschedule : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;principal&quot; parameter, which is accepted by the &quot;microsoft.graph.fvschedule&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;principal&quot; parameter, which is accepted by the &quot;microsoft.graph.fvschedule&quot; action.")]
        public System.Object principal { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;schedule&quot; parameter, which is accepted by the &quot;microsoft.graph.fvschedule&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;schedule&quot; parameter, which is accepted by the &quot;microsoft.graph.fvschedule&quot; action.")]
        public System.Object schedule { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/fvschedule";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/f_Dist</para>
    ///     <para type="description">The action &quot;microsoft.graph.f_Dist&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_FDist", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_FDist : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.f_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.f_Dist&quot; action.")]
        public System.Object x { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;degFreedom1&quot; parameter, which is accepted by the &quot;microsoft.graph.f_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;degFreedom1&quot; parameter, which is accepted by the &quot;microsoft.graph.f_Dist&quot; action.")]
        public System.Object degFreedom1 { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;degFreedom2&quot; parameter, which is accepted by the &quot;microsoft.graph.f_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;degFreedom2&quot; parameter, which is accepted by the &quot;microsoft.graph.f_Dist&quot; action.")]
        public System.Object degFreedom2 { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;cumulative&quot; parameter, which is accepted by the &quot;microsoft.graph.f_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;cumulative&quot; parameter, which is accepted by the &quot;microsoft.graph.f_Dist&quot; action.")]
        public System.Object cumulative { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/f_Dist";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/f_Dist_RT</para>
    ///     <para type="description">The action &quot;microsoft.graph.f_Dist_RT&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_FDistRT", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_FDistRT : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.f_Dist_RT&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.f_Dist_RT&quot; action.")]
        public System.Object x { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;degFreedom1&quot; parameter, which is accepted by the &quot;microsoft.graph.f_Dist_RT&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;degFreedom1&quot; parameter, which is accepted by the &quot;microsoft.graph.f_Dist_RT&quot; action.")]
        public System.Object degFreedom1 { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;degFreedom2&quot; parameter, which is accepted by the &quot;microsoft.graph.f_Dist_RT&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;degFreedom2&quot; parameter, which is accepted by the &quot;microsoft.graph.f_Dist_RT&quot; action.")]
        public System.Object degFreedom2 { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/f_Dist_RT";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/f_Inv</para>
    ///     <para type="description">The action &quot;microsoft.graph.f_Inv&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_FInv", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_FInv : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;probability&quot; parameter, which is accepted by the &quot;microsoft.graph.f_Inv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;probability&quot; parameter, which is accepted by the &quot;microsoft.graph.f_Inv&quot; action.")]
        public System.Object probability { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;degFreedom1&quot; parameter, which is accepted by the &quot;microsoft.graph.f_Inv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;degFreedom1&quot; parameter, which is accepted by the &quot;microsoft.graph.f_Inv&quot; action.")]
        public System.Object degFreedom1 { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;degFreedom2&quot; parameter, which is accepted by the &quot;microsoft.graph.f_Inv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;degFreedom2&quot; parameter, which is accepted by the &quot;microsoft.graph.f_Inv&quot; action.")]
        public System.Object degFreedom2 { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/f_Inv";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/f_Inv_RT</para>
    ///     <para type="description">The action &quot;microsoft.graph.f_Inv_RT&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_FInvRT", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_FInvRT : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;probability&quot; parameter, which is accepted by the &quot;microsoft.graph.f_Inv_RT&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;probability&quot; parameter, which is accepted by the &quot;microsoft.graph.f_Inv_RT&quot; action.")]
        public System.Object probability { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;degFreedom1&quot; parameter, which is accepted by the &quot;microsoft.graph.f_Inv_RT&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;degFreedom1&quot; parameter, which is accepted by the &quot;microsoft.graph.f_Inv_RT&quot; action.")]
        public System.Object degFreedom1 { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;degFreedom2&quot; parameter, which is accepted by the &quot;microsoft.graph.f_Inv_RT&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;degFreedom2&quot; parameter, which is accepted by the &quot;microsoft.graph.f_Inv_RT&quot; action.")]
        public System.Object degFreedom2 { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/f_Inv_RT";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/fact</para>
    ///     <para type="description">The action &quot;microsoft.graph.fact&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Fact", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Fact : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.fact&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.fact&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/fact";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/factDouble</para>
    ///     <para type="description">The action &quot;microsoft.graph.factDouble&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_FactDouble", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_FactDouble : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.factDouble&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.factDouble&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/factDouble";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/false</para>
    ///     <para type="description">The action &quot;microsoft.graph.false&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_False", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_False : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/false";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/find</para>
    ///     <para type="description">The action &quot;microsoft.graph.find&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Find", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Find : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;findText&quot; parameter, which is accepted by the &quot;microsoft.graph.find&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;findText&quot; parameter, which is accepted by the &quot;microsoft.graph.find&quot; action.")]
        public System.Object findText { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;withinText&quot; parameter, which is accepted by the &quot;microsoft.graph.find&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;withinText&quot; parameter, which is accepted by the &quot;microsoft.graph.find&quot; action.")]
        public System.Object withinText { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;startNum&quot; parameter, which is accepted by the &quot;microsoft.graph.find&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;startNum&quot; parameter, which is accepted by the &quot;microsoft.graph.find&quot; action.")]
        public System.Object startNum { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/find";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/findB</para>
    ///     <para type="description">The action &quot;microsoft.graph.findB&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_FindB", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_FindB : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;findText&quot; parameter, which is accepted by the &quot;microsoft.graph.findB&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;findText&quot; parameter, which is accepted by the &quot;microsoft.graph.findB&quot; action.")]
        public System.Object findText { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;withinText&quot; parameter, which is accepted by the &quot;microsoft.graph.findB&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;withinText&quot; parameter, which is accepted by the &quot;microsoft.graph.findB&quot; action.")]
        public System.Object withinText { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;startNum&quot; parameter, which is accepted by the &quot;microsoft.graph.findB&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;startNum&quot; parameter, which is accepted by the &quot;microsoft.graph.findB&quot; action.")]
        public System.Object startNum { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/findB";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/fisher</para>
    ///     <para type="description">The action &quot;microsoft.graph.fisher&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Fisher", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Fisher : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.fisher&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.fisher&quot; action.")]
        public System.Object x { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/fisher";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/fisherInv</para>
    ///     <para type="description">The action &quot;microsoft.graph.fisherInv&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_FisherInv", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_FisherInv : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;y&quot; parameter, which is accepted by the &quot;microsoft.graph.fisherInv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;y&quot; parameter, which is accepted by the &quot;microsoft.graph.fisherInv&quot; action.")]
        public System.Object y { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/fisherInv";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/fixed</para>
    ///     <para type="description">The action &quot;microsoft.graph.fixed&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Fixed", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Fixed : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.fixed&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.fixed&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;decimals&quot; parameter, which is accepted by the &quot;microsoft.graph.fixed&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;decimals&quot; parameter, which is accepted by the &quot;microsoft.graph.fixed&quot; action.")]
        public System.Object decimals { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;noCommas&quot; parameter, which is accepted by the &quot;microsoft.graph.fixed&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;noCommas&quot; parameter, which is accepted by the &quot;microsoft.graph.fixed&quot; action.")]
        public System.Object noCommas { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/fixed";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/floor_Math</para>
    ///     <para type="description">The action &quot;microsoft.graph.floor_Math&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_FloorMath", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_FloorMath : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.floor_Math&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.floor_Math&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;significance&quot; parameter, which is accepted by the &quot;microsoft.graph.floor_Math&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;significance&quot; parameter, which is accepted by the &quot;microsoft.graph.floor_Math&quot; action.")]
        public System.Object significance { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mode&quot; parameter, which is accepted by the &quot;microsoft.graph.floor_Math&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;mode&quot; parameter, which is accepted by the &quot;microsoft.graph.floor_Math&quot; action.")]
        public System.Object mode { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/floor_Math";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/floor_Precise</para>
    ///     <para type="description">The action &quot;microsoft.graph.floor_Precise&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_FloorPrecise", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_FloorPrecise : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.floor_Precise&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.floor_Precise&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;significance&quot; parameter, which is accepted by the &quot;microsoft.graph.floor_Precise&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;significance&quot; parameter, which is accepted by the &quot;microsoft.graph.floor_Precise&quot; action.")]
        public System.Object significance { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/floor_Precise";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/fv</para>
    ///     <para type="description">The action &quot;microsoft.graph.fv&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Fv", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Fv : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.fv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.fv&quot; action.")]
        public System.Object rate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;nper&quot; parameter, which is accepted by the &quot;microsoft.graph.fv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;nper&quot; parameter, which is accepted by the &quot;microsoft.graph.fv&quot; action.")]
        public System.Object nper { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pmt&quot; parameter, which is accepted by the &quot;microsoft.graph.fv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;pmt&quot; parameter, which is accepted by the &quot;microsoft.graph.fv&quot; action.")]
        public System.Object pmt { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pv&quot; parameter, which is accepted by the &quot;microsoft.graph.fv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;pv&quot; parameter, which is accepted by the &quot;microsoft.graph.fv&quot; action.")]
        public System.Object pv { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;type&quot; parameter, which is accepted by the &quot;microsoft.graph.fv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;type&quot; parameter, which is accepted by the &quot;microsoft.graph.fv&quot; action.")]
        public System.Object type { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/fv";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/gamma</para>
    ///     <para type="description">The action &quot;microsoft.graph.gamma&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Gamma", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Gamma : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.gamma&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.gamma&quot; action.")]
        public System.Object x { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/gamma";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/gammaLn</para>
    ///     <para type="description">The action &quot;microsoft.graph.gammaLn&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_GammaLn", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_GammaLn : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.gammaLn&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.gammaLn&quot; action.")]
        public System.Object x { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/gammaLn";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/gammaLn_Precise</para>
    ///     <para type="description">The action &quot;microsoft.graph.gammaLn_Precise&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_GammaLnPrecise", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_GammaLnPrecise : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.gammaLn_Precise&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.gammaLn_Precise&quot; action.")]
        public System.Object x { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/gammaLn_Precise";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/gamma_Dist</para>
    ///     <para type="description">The action &quot;microsoft.graph.gamma_Dist&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_GammaDist", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_GammaDist : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.gamma_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.gamma_Dist&quot; action.")]
        public System.Object x { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;alpha&quot; parameter, which is accepted by the &quot;microsoft.graph.gamma_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;alpha&quot; parameter, which is accepted by the &quot;microsoft.graph.gamma_Dist&quot; action.")]
        public System.Object alpha { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;beta&quot; parameter, which is accepted by the &quot;microsoft.graph.gamma_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;beta&quot; parameter, which is accepted by the &quot;microsoft.graph.gamma_Dist&quot; action.")]
        public System.Object beta { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;cumulative&quot; parameter, which is accepted by the &quot;microsoft.graph.gamma_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;cumulative&quot; parameter, which is accepted by the &quot;microsoft.graph.gamma_Dist&quot; action.")]
        public System.Object cumulative { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/gamma_Dist";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/gamma_Inv</para>
    ///     <para type="description">The action &quot;microsoft.graph.gamma_Inv&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_GammaInv", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_GammaInv : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;probability&quot; parameter, which is accepted by the &quot;microsoft.graph.gamma_Inv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;probability&quot; parameter, which is accepted by the &quot;microsoft.graph.gamma_Inv&quot; action.")]
        public System.Object probability { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;alpha&quot; parameter, which is accepted by the &quot;microsoft.graph.gamma_Inv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;alpha&quot; parameter, which is accepted by the &quot;microsoft.graph.gamma_Inv&quot; action.")]
        public System.Object alpha { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;beta&quot; parameter, which is accepted by the &quot;microsoft.graph.gamma_Inv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;beta&quot; parameter, which is accepted by the &quot;microsoft.graph.gamma_Inv&quot; action.")]
        public System.Object beta { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/gamma_Inv";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/gauss</para>
    ///     <para type="description">The action &quot;microsoft.graph.gauss&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Gauss", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Gauss : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.gauss&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.gauss&quot; action.")]
        public System.Object x { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/gauss";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/gcd</para>
    ///     <para type="description">The action &quot;microsoft.graph.gcd&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Gcd", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Gcd : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.gcd&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.gcd&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/gcd";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/geStep</para>
    ///     <para type="description">The action &quot;microsoft.graph.geStep&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_GeStep", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_GeStep : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.geStep&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.geStep&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;step&quot; parameter, which is accepted by the &quot;microsoft.graph.geStep&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;step&quot; parameter, which is accepted by the &quot;microsoft.graph.geStep&quot; action.")]
        public System.Object step { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/geStep";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/geoMean</para>
    ///     <para type="description">The action &quot;microsoft.graph.geoMean&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_GeoMean", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_GeoMean : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.geoMean&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.geoMean&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/geoMean";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/hlookup</para>
    ///     <para type="description">The action &quot;microsoft.graph.hlookup&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Hlookup", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Hlookup : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;lookupValue&quot; parameter, which is accepted by the &quot;microsoft.graph.hlookup&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;lookupValue&quot; parameter, which is accepted by the &quot;microsoft.graph.hlookup&quot; action.")]
        public System.Object lookupValue { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;tableArray&quot; parameter, which is accepted by the &quot;microsoft.graph.hlookup&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;tableArray&quot; parameter, which is accepted by the &quot;microsoft.graph.hlookup&quot; action.")]
        public System.Object tableArray { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rowIndexNum&quot; parameter, which is accepted by the &quot;microsoft.graph.hlookup&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;rowIndexNum&quot; parameter, which is accepted by the &quot;microsoft.graph.hlookup&quot; action.")]
        public System.Object rowIndexNum { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rangeLookup&quot; parameter, which is accepted by the &quot;microsoft.graph.hlookup&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;rangeLookup&quot; parameter, which is accepted by the &quot;microsoft.graph.hlookup&quot; action.")]
        public System.Object rangeLookup { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/hlookup";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/harMean</para>
    ///     <para type="description">The action &quot;microsoft.graph.harMean&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_HarMean", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_HarMean : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.harMean&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.harMean&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/harMean";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/hex2Bin</para>
    ///     <para type="description">The action &quot;microsoft.graph.hex2Bin&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Hex2Bin", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Hex2Bin : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.hex2Bin&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.hex2Bin&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;places&quot; parameter, which is accepted by the &quot;microsoft.graph.hex2Bin&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;places&quot; parameter, which is accepted by the &quot;microsoft.graph.hex2Bin&quot; action.")]
        public System.Object places { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/hex2Bin";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/hex2Dec</para>
    ///     <para type="description">The action &quot;microsoft.graph.hex2Dec&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Hex2Dec", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Hex2Dec : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.hex2Dec&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.hex2Dec&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/hex2Dec";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/hex2Oct</para>
    ///     <para type="description">The action &quot;microsoft.graph.hex2Oct&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Hex2Oct", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Hex2Oct : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.hex2Oct&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.hex2Oct&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;places&quot; parameter, which is accepted by the &quot;microsoft.graph.hex2Oct&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;places&quot; parameter, which is accepted by the &quot;microsoft.graph.hex2Oct&quot; action.")]
        public System.Object places { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/hex2Oct";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/hour</para>
    ///     <para type="description">The action &quot;microsoft.graph.hour&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Hour", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Hour : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;serialNumber&quot; parameter, which is accepted by the &quot;microsoft.graph.hour&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;serialNumber&quot; parameter, which is accepted by the &quot;microsoft.graph.hour&quot; action.")]
        public System.Object serialNumber { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/hour";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/hypGeom_Dist</para>
    ///     <para type="description">The action &quot;microsoft.graph.hypGeom_Dist&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_HypGeomDist", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_HypGeomDist : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;sampleS&quot; parameter, which is accepted by the &quot;microsoft.graph.hypGeom_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;sampleS&quot; parameter, which is accepted by the &quot;microsoft.graph.hypGeom_Dist&quot; action.")]
        public System.Object sampleS { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;numberSample&quot; parameter, which is accepted by the &quot;microsoft.graph.hypGeom_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;numberSample&quot; parameter, which is accepted by the &quot;microsoft.graph.hypGeom_Dist&quot; action.")]
        public System.Object numberSample { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;populationS&quot; parameter, which is accepted by the &quot;microsoft.graph.hypGeom_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;populationS&quot; parameter, which is accepted by the &quot;microsoft.graph.hypGeom_Dist&quot; action.")]
        public System.Object populationS { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;numberPop&quot; parameter, which is accepted by the &quot;microsoft.graph.hypGeom_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;numberPop&quot; parameter, which is accepted by the &quot;microsoft.graph.hypGeom_Dist&quot; action.")]
        public System.Object numberPop { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;cumulative&quot; parameter, which is accepted by the &quot;microsoft.graph.hypGeom_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;cumulative&quot; parameter, which is accepted by the &quot;microsoft.graph.hypGeom_Dist&quot; action.")]
        public System.Object cumulative { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/hypGeom_Dist";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/hyperlink</para>
    ///     <para type="description">The action &quot;microsoft.graph.hyperlink&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Hyperlink", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Hyperlink : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;linkLocation&quot; parameter, which is accepted by the &quot;microsoft.graph.hyperlink&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;linkLocation&quot; parameter, which is accepted by the &quot;microsoft.graph.hyperlink&quot; action.")]
        public System.Object linkLocation { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;friendlyName&quot; parameter, which is accepted by the &quot;microsoft.graph.hyperlink&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;friendlyName&quot; parameter, which is accepted by the &quot;microsoft.graph.hyperlink&quot; action.")]
        public System.Object friendlyName { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/hyperlink";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/iso_Ceiling</para>
    ///     <para type="description">The action &quot;microsoft.graph.iso_Ceiling&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_IsoCeiling", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_IsoCeiling : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.iso_Ceiling&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.iso_Ceiling&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;significance&quot; parameter, which is accepted by the &quot;microsoft.graph.iso_Ceiling&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;significance&quot; parameter, which is accepted by the &quot;microsoft.graph.iso_Ceiling&quot; action.")]
        public System.Object significance { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/iso_Ceiling";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/if</para>
    ///     <para type="description">The action &quot;microsoft.graph.if&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_If", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_If : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;logicalTest&quot; parameter, which is accepted by the &quot;microsoft.graph.if&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;logicalTest&quot; parameter, which is accepted by the &quot;microsoft.graph.if&quot; action.")]
        public System.Object logicalTest { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;valueIfTrue&quot; parameter, which is accepted by the &quot;microsoft.graph.if&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;valueIfTrue&quot; parameter, which is accepted by the &quot;microsoft.graph.if&quot; action.")]
        public System.Object valueIfTrue { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;valueIfFalse&quot; parameter, which is accepted by the &quot;microsoft.graph.if&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;valueIfFalse&quot; parameter, which is accepted by the &quot;microsoft.graph.if&quot; action.")]
        public System.Object valueIfFalse { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/if";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/imAbs</para>
    ///     <para type="description">The action &quot;microsoft.graph.imAbs&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_ImAbs", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_ImAbs : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imAbs&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imAbs&quot; action.")]
        public System.Object inumber { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/imAbs";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/imArgument</para>
    ///     <para type="description">The action &quot;microsoft.graph.imArgument&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_ImArgument", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_ImArgument : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imArgument&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imArgument&quot; action.")]
        public System.Object inumber { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/imArgument";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/imConjugate</para>
    ///     <para type="description">The action &quot;microsoft.graph.imConjugate&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_ImConjugate", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_ImConjugate : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imConjugate&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imConjugate&quot; action.")]
        public System.Object inumber { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/imConjugate";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/imCos</para>
    ///     <para type="description">The action &quot;microsoft.graph.imCos&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_ImCos", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_ImCos : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imCos&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imCos&quot; action.")]
        public System.Object inumber { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/imCos";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/imCosh</para>
    ///     <para type="description">The action &quot;microsoft.graph.imCosh&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_ImCosh", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_ImCosh : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imCosh&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imCosh&quot; action.")]
        public System.Object inumber { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/imCosh";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/imCot</para>
    ///     <para type="description">The action &quot;microsoft.graph.imCot&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_ImCot", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_ImCot : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imCot&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imCot&quot; action.")]
        public System.Object inumber { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/imCot";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/imCsc</para>
    ///     <para type="description">The action &quot;microsoft.graph.imCsc&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_ImCsc", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_ImCsc : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imCsc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imCsc&quot; action.")]
        public System.Object inumber { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/imCsc";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/imCsch</para>
    ///     <para type="description">The action &quot;microsoft.graph.imCsch&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_ImCsch", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_ImCsch : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imCsch&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imCsch&quot; action.")]
        public System.Object inumber { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/imCsch";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/imDiv</para>
    ///     <para type="description">The action &quot;microsoft.graph.imDiv&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_ImDiv", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_ImDiv : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;inumber1&quot; parameter, which is accepted by the &quot;microsoft.graph.imDiv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;inumber1&quot; parameter, which is accepted by the &quot;microsoft.graph.imDiv&quot; action.")]
        public System.Object inumber1 { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;inumber2&quot; parameter, which is accepted by the &quot;microsoft.graph.imDiv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;inumber2&quot; parameter, which is accepted by the &quot;microsoft.graph.imDiv&quot; action.")]
        public System.Object inumber2 { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/imDiv";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/imExp</para>
    ///     <para type="description">The action &quot;microsoft.graph.imExp&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_ImExp", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_ImExp : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imExp&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imExp&quot; action.")]
        public System.Object inumber { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/imExp";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/imLn</para>
    ///     <para type="description">The action &quot;microsoft.graph.imLn&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_ImLn", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_ImLn : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imLn&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imLn&quot; action.")]
        public System.Object inumber { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/imLn";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/imLog10</para>
    ///     <para type="description">The action &quot;microsoft.graph.imLog10&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_ImLog10", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_ImLog10 : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imLog10&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imLog10&quot; action.")]
        public System.Object inumber { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/imLog10";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/imLog2</para>
    ///     <para type="description">The action &quot;microsoft.graph.imLog2&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_ImLog2", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_ImLog2 : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imLog2&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imLog2&quot; action.")]
        public System.Object inumber { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/imLog2";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/imPower</para>
    ///     <para type="description">The action &quot;microsoft.graph.imPower&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_ImPower", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_ImPower : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imPower&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imPower&quot; action.")]
        public System.Object inumber { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.imPower&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.imPower&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/imPower";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/imProduct</para>
    ///     <para type="description">The action &quot;microsoft.graph.imProduct&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_ImProduct", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_ImProduct : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.imProduct&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.imProduct&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/imProduct";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/imReal</para>
    ///     <para type="description">The action &quot;microsoft.graph.imReal&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_ImReal", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_ImReal : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imReal&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imReal&quot; action.")]
        public System.Object inumber { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/imReal";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/imSec</para>
    ///     <para type="description">The action &quot;microsoft.graph.imSec&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_ImSec", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_ImSec : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imSec&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imSec&quot; action.")]
        public System.Object inumber { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/imSec";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/imSech</para>
    ///     <para type="description">The action &quot;microsoft.graph.imSech&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_ImSech", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_ImSech : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imSech&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imSech&quot; action.")]
        public System.Object inumber { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/imSech";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/imSin</para>
    ///     <para type="description">The action &quot;microsoft.graph.imSin&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_ImSin", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_ImSin : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imSin&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imSin&quot; action.")]
        public System.Object inumber { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/imSin";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/imSinh</para>
    ///     <para type="description">The action &quot;microsoft.graph.imSinh&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_ImSinh", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_ImSinh : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imSinh&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imSinh&quot; action.")]
        public System.Object inumber { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/imSinh";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/imSqrt</para>
    ///     <para type="description">The action &quot;microsoft.graph.imSqrt&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_ImSqrt", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_ImSqrt : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imSqrt&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imSqrt&quot; action.")]
        public System.Object inumber { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/imSqrt";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/imSub</para>
    ///     <para type="description">The action &quot;microsoft.graph.imSub&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_ImSub", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_ImSub : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;inumber1&quot; parameter, which is accepted by the &quot;microsoft.graph.imSub&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;inumber1&quot; parameter, which is accepted by the &quot;microsoft.graph.imSub&quot; action.")]
        public System.Object inumber1 { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;inumber2&quot; parameter, which is accepted by the &quot;microsoft.graph.imSub&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;inumber2&quot; parameter, which is accepted by the &quot;microsoft.graph.imSub&quot; action.")]
        public System.Object inumber2 { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/imSub";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/imSum</para>
    ///     <para type="description">The action &quot;microsoft.graph.imSum&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_ImSum", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_ImSum : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.imSum&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.imSum&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/imSum";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/imTan</para>
    ///     <para type="description">The action &quot;microsoft.graph.imTan&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_ImTan", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_ImTan : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imTan&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imTan&quot; action.")]
        public System.Object inumber { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/imTan";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/imaginary</para>
    ///     <para type="description">The action &quot;microsoft.graph.imaginary&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Imaginary", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Imaginary : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imaginary&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;inumber&quot; parameter, which is accepted by the &quot;microsoft.graph.imaginary&quot; action.")]
        public System.Object inumber { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/imaginary";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/int</para>
    ///     <para type="description">The action &quot;microsoft.graph.int&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Int", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Int : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.int&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.int&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/int";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/intRate</para>
    ///     <para type="description">The action &quot;microsoft.graph.intRate&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_IntRate", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_IntRate : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.intRate&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.intRate&quot; action.")]
        public System.Object settlement { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.intRate&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.intRate&quot; action.")]
        public System.Object maturity { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;investment&quot; parameter, which is accepted by the &quot;microsoft.graph.intRate&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;investment&quot; parameter, which is accepted by the &quot;microsoft.graph.intRate&quot; action.")]
        public System.Object investment { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;redemption&quot; parameter, which is accepted by the &quot;microsoft.graph.intRate&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;redemption&quot; parameter, which is accepted by the &quot;microsoft.graph.intRate&quot; action.")]
        public System.Object redemption { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.intRate&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.intRate&quot; action.")]
        public System.Object basis { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/intRate";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/ipmt</para>
    ///     <para type="description">The action &quot;microsoft.graph.ipmt&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Ipmt", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Ipmt : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.ipmt&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.ipmt&quot; action.")]
        public System.Object rate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;per&quot; parameter, which is accepted by the &quot;microsoft.graph.ipmt&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;per&quot; parameter, which is accepted by the &quot;microsoft.graph.ipmt&quot; action.")]
        public System.Object per { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;nper&quot; parameter, which is accepted by the &quot;microsoft.graph.ipmt&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;nper&quot; parameter, which is accepted by the &quot;microsoft.graph.ipmt&quot; action.")]
        public System.Object nper { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pv&quot; parameter, which is accepted by the &quot;microsoft.graph.ipmt&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;pv&quot; parameter, which is accepted by the &quot;microsoft.graph.ipmt&quot; action.")]
        public System.Object pv { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fv&quot; parameter, which is accepted by the &quot;microsoft.graph.ipmt&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;fv&quot; parameter, which is accepted by the &quot;microsoft.graph.ipmt&quot; action.")]
        public System.Object fv { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;type&quot; parameter, which is accepted by the &quot;microsoft.graph.ipmt&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;type&quot; parameter, which is accepted by the &quot;microsoft.graph.ipmt&quot; action.")]
        public System.Object type { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/ipmt";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/irr</para>
    ///     <para type="description">The action &quot;microsoft.graph.irr&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Irr", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Irr : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.irr&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.irr&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;guess&quot; parameter, which is accepted by the &quot;microsoft.graph.irr&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;guess&quot; parameter, which is accepted by the &quot;microsoft.graph.irr&quot; action.")]
        public System.Object guess { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/irr";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/isErr</para>
    ///     <para type="description">The action &quot;microsoft.graph.isErr&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_IsErr", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_IsErr : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;value&quot; parameter, which is accepted by the &quot;microsoft.graph.isErr&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;value&quot; parameter, which is accepted by the &quot;microsoft.graph.isErr&quot; action.")]
        public System.Object value { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/isErr";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/isError</para>
    ///     <para type="description">The action &quot;microsoft.graph.isError&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_IsError", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_IsError : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;value&quot; parameter, which is accepted by the &quot;microsoft.graph.isError&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;value&quot; parameter, which is accepted by the &quot;microsoft.graph.isError&quot; action.")]
        public System.Object value { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/isError";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/isEven</para>
    ///     <para type="description">The action &quot;microsoft.graph.isEven&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_IsEven", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_IsEven : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.isEven&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.isEven&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/isEven";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/isFormula</para>
    ///     <para type="description">The action &quot;microsoft.graph.isFormula&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_IsFormula", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_IsFormula : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;reference&quot; parameter, which is accepted by the &quot;microsoft.graph.isFormula&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;reference&quot; parameter, which is accepted by the &quot;microsoft.graph.isFormula&quot; action.")]
        public System.Object reference { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/isFormula";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/isLogical</para>
    ///     <para type="description">The action &quot;microsoft.graph.isLogical&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_IsLogical", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_IsLogical : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;value&quot; parameter, which is accepted by the &quot;microsoft.graph.isLogical&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;value&quot; parameter, which is accepted by the &quot;microsoft.graph.isLogical&quot; action.")]
        public System.Object value { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/isLogical";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/isNA</para>
    ///     <para type="description">The action &quot;microsoft.graph.isNA&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_IsNA", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_IsNA : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;value&quot; parameter, which is accepted by the &quot;microsoft.graph.isNA&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;value&quot; parameter, which is accepted by the &quot;microsoft.graph.isNA&quot; action.")]
        public System.Object value { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/isNA";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/isNonText</para>
    ///     <para type="description">The action &quot;microsoft.graph.isNonText&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_IsNonText", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_IsNonText : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;value&quot; parameter, which is accepted by the &quot;microsoft.graph.isNonText&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;value&quot; parameter, which is accepted by the &quot;microsoft.graph.isNonText&quot; action.")]
        public System.Object value { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/isNonText";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/isNumber</para>
    ///     <para type="description">The action &quot;microsoft.graph.isNumber&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_IsNumber", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_IsNumber : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;value&quot; parameter, which is accepted by the &quot;microsoft.graph.isNumber&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;value&quot; parameter, which is accepted by the &quot;microsoft.graph.isNumber&quot; action.")]
        public System.Object value { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/isNumber";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/isOdd</para>
    ///     <para type="description">The action &quot;microsoft.graph.isOdd&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_IsOdd", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_IsOdd : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.isOdd&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.isOdd&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/isOdd";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/isText</para>
    ///     <para type="description">The action &quot;microsoft.graph.isText&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_IsText", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_IsText : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;value&quot; parameter, which is accepted by the &quot;microsoft.graph.isText&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;value&quot; parameter, which is accepted by the &quot;microsoft.graph.isText&quot; action.")]
        public System.Object value { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/isText";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/isoWeekNum</para>
    ///     <para type="description">The action &quot;microsoft.graph.isoWeekNum&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_IsoWeekNum", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_IsoWeekNum : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;date&quot; parameter, which is accepted by the &quot;microsoft.graph.isoWeekNum&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;date&quot; parameter, which is accepted by the &quot;microsoft.graph.isoWeekNum&quot; action.")]
        public System.Object date { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/isoWeekNum";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/ispmt</para>
    ///     <para type="description">The action &quot;microsoft.graph.ispmt&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Ispmt", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Ispmt : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.ispmt&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.ispmt&quot; action.")]
        public System.Object rate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;per&quot; parameter, which is accepted by the &quot;microsoft.graph.ispmt&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;per&quot; parameter, which is accepted by the &quot;microsoft.graph.ispmt&quot; action.")]
        public System.Object per { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;nper&quot; parameter, which is accepted by the &quot;microsoft.graph.ispmt&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;nper&quot; parameter, which is accepted by the &quot;microsoft.graph.ispmt&quot; action.")]
        public System.Object nper { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pv&quot; parameter, which is accepted by the &quot;microsoft.graph.ispmt&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;pv&quot; parameter, which is accepted by the &quot;microsoft.graph.ispmt&quot; action.")]
        public System.Object pv { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/ispmt";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/isref</para>
    ///     <para type="description">The action &quot;microsoft.graph.isref&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Isref", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Isref : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;value&quot; parameter, which is accepted by the &quot;microsoft.graph.isref&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;value&quot; parameter, which is accepted by the &quot;microsoft.graph.isref&quot; action.")]
        public System.Object value { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/isref";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/kurt</para>
    ///     <para type="description">The action &quot;microsoft.graph.kurt&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Kurt", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Kurt : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.kurt&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.kurt&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/kurt";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/large</para>
    ///     <para type="description">The action &quot;microsoft.graph.large&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Large", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Large : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;array&quot; parameter, which is accepted by the &quot;microsoft.graph.large&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;array&quot; parameter, which is accepted by the &quot;microsoft.graph.large&quot; action.")]
        public System.Object array { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;k&quot; parameter, which is accepted by the &quot;microsoft.graph.large&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;k&quot; parameter, which is accepted by the &quot;microsoft.graph.large&quot; action.")]
        public System.Object k { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/large";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/lcm</para>
    ///     <para type="description">The action &quot;microsoft.graph.lcm&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Lcm", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Lcm : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.lcm&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.lcm&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/lcm";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/left</para>
    ///     <para type="description">The action &quot;microsoft.graph.left&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Left", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Left : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.left&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.left&quot; action.")]
        public System.Object text { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;numChars&quot; parameter, which is accepted by the &quot;microsoft.graph.left&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;numChars&quot; parameter, which is accepted by the &quot;microsoft.graph.left&quot; action.")]
        public System.Object numChars { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/left";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/leftb</para>
    ///     <para type="description">The action &quot;microsoft.graph.leftb&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Leftb", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Leftb : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.leftb&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.leftb&quot; action.")]
        public System.Object text { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;numBytes&quot; parameter, which is accepted by the &quot;microsoft.graph.leftb&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;numBytes&quot; parameter, which is accepted by the &quot;microsoft.graph.leftb&quot; action.")]
        public System.Object numBytes { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/leftb";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/len</para>
    ///     <para type="description">The action &quot;microsoft.graph.len&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Len", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Len : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.len&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.len&quot; action.")]
        public System.Object text { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/len";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/lenb</para>
    ///     <para type="description">The action &quot;microsoft.graph.lenb&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Lenb", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Lenb : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.lenb&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.lenb&quot; action.")]
        public System.Object text { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/lenb";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/ln</para>
    ///     <para type="description">The action &quot;microsoft.graph.ln&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Ln", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Ln : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.ln&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.ln&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/ln";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/log</para>
    ///     <para type="description">The action &quot;microsoft.graph.log&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Log", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Log : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.log&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.log&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;base&quot; parameter, which is accepted by the &quot;microsoft.graph.log&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;base&quot; parameter, which is accepted by the &quot;microsoft.graph.log&quot; action.")]
        public System.Object @base { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/log";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/log10</para>
    ///     <para type="description">The action &quot;microsoft.graph.log10&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Log10", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Log10 : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.log10&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.log10&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/log10";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/logNorm_Dist</para>
    ///     <para type="description">The action &quot;microsoft.graph.logNorm_Dist&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_LogNormDist", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_LogNormDist : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.logNorm_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.logNorm_Dist&quot; action.")]
        public System.Object x { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mean&quot; parameter, which is accepted by the &quot;microsoft.graph.logNorm_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;mean&quot; parameter, which is accepted by the &quot;microsoft.graph.logNorm_Dist&quot; action.")]
        public System.Object mean { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;standardDev&quot; parameter, which is accepted by the &quot;microsoft.graph.logNorm_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;standardDev&quot; parameter, which is accepted by the &quot;microsoft.graph.logNorm_Dist&quot; action.")]
        public System.Object standardDev { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;cumulative&quot; parameter, which is accepted by the &quot;microsoft.graph.logNorm_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;cumulative&quot; parameter, which is accepted by the &quot;microsoft.graph.logNorm_Dist&quot; action.")]
        public System.Object cumulative { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/logNorm_Dist";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/logNorm_Inv</para>
    ///     <para type="description">The action &quot;microsoft.graph.logNorm_Inv&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_LogNormInv", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_LogNormInv : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;probability&quot; parameter, which is accepted by the &quot;microsoft.graph.logNorm_Inv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;probability&quot; parameter, which is accepted by the &quot;microsoft.graph.logNorm_Inv&quot; action.")]
        public System.Object probability { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mean&quot; parameter, which is accepted by the &quot;microsoft.graph.logNorm_Inv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;mean&quot; parameter, which is accepted by the &quot;microsoft.graph.logNorm_Inv&quot; action.")]
        public System.Object mean { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;standardDev&quot; parameter, which is accepted by the &quot;microsoft.graph.logNorm_Inv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;standardDev&quot; parameter, which is accepted by the &quot;microsoft.graph.logNorm_Inv&quot; action.")]
        public System.Object standardDev { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/logNorm_Inv";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/lookup</para>
    ///     <para type="description">The action &quot;microsoft.graph.lookup&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Lookup", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Lookup : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;lookupValue&quot; parameter, which is accepted by the &quot;microsoft.graph.lookup&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;lookupValue&quot; parameter, which is accepted by the &quot;microsoft.graph.lookup&quot; action.")]
        public System.Object lookupValue { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lookupVector&quot; parameter, which is accepted by the &quot;microsoft.graph.lookup&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;lookupVector&quot; parameter, which is accepted by the &quot;microsoft.graph.lookup&quot; action.")]
        public System.Object lookupVector { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;resultVector&quot; parameter, which is accepted by the &quot;microsoft.graph.lookup&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;resultVector&quot; parameter, which is accepted by the &quot;microsoft.graph.lookup&quot; action.")]
        public System.Object resultVector { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/lookup";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/lower</para>
    ///     <para type="description">The action &quot;microsoft.graph.lower&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Lower", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Lower : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.lower&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.lower&quot; action.")]
        public System.Object text { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/lower";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/mduration</para>
    ///     <para type="description">The action &quot;microsoft.graph.mduration&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Mduration", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Mduration : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.mduration&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.mduration&quot; action.")]
        public System.Object settlement { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.mduration&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.mduration&quot; action.")]
        public System.Object maturity { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;coupon&quot; parameter, which is accepted by the &quot;microsoft.graph.mduration&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;coupon&quot; parameter, which is accepted by the &quot;microsoft.graph.mduration&quot; action.")]
        public System.Object coupon { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;yld&quot; parameter, which is accepted by the &quot;microsoft.graph.mduration&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;yld&quot; parameter, which is accepted by the &quot;microsoft.graph.mduration&quot; action.")]
        public System.Object yld { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;frequency&quot; parameter, which is accepted by the &quot;microsoft.graph.mduration&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;frequency&quot; parameter, which is accepted by the &quot;microsoft.graph.mduration&quot; action.")]
        public System.Object frequency { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.mduration&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.mduration&quot; action.")]
        public System.Object basis { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/mduration";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/mirr</para>
    ///     <para type="description">The action &quot;microsoft.graph.mirr&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Mirr", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Mirr : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.mirr&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.mirr&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;financeRate&quot; parameter, which is accepted by the &quot;microsoft.graph.mirr&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;financeRate&quot; parameter, which is accepted by the &quot;microsoft.graph.mirr&quot; action.")]
        public System.Object financeRate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;reinvestRate&quot; parameter, which is accepted by the &quot;microsoft.graph.mirr&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;reinvestRate&quot; parameter, which is accepted by the &quot;microsoft.graph.mirr&quot; action.")]
        public System.Object reinvestRate { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/mirr";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/mround</para>
    ///     <para type="description">The action &quot;microsoft.graph.mround&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Mround", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Mround : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.mround&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.mround&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;multiple&quot; parameter, which is accepted by the &quot;microsoft.graph.mround&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;multiple&quot; parameter, which is accepted by the &quot;microsoft.graph.mround&quot; action.")]
        public System.Object multiple { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/mround";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/match</para>
    ///     <para type="description">The action &quot;microsoft.graph.match&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Match", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Match : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;lookupValue&quot; parameter, which is accepted by the &quot;microsoft.graph.match&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;lookupValue&quot; parameter, which is accepted by the &quot;microsoft.graph.match&quot; action.")]
        public System.Object lookupValue { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lookupArray&quot; parameter, which is accepted by the &quot;microsoft.graph.match&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;lookupArray&quot; parameter, which is accepted by the &quot;microsoft.graph.match&quot; action.")]
        public System.Object lookupArray { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;matchType&quot; parameter, which is accepted by the &quot;microsoft.graph.match&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;matchType&quot; parameter, which is accepted by the &quot;microsoft.graph.match&quot; action.")]
        public System.Object matchType { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/match";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/max</para>
    ///     <para type="description">The action &quot;microsoft.graph.max&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Max", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Max : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.max&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.max&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/max";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/maxA</para>
    ///     <para type="description">The action &quot;microsoft.graph.maxA&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_MaxA", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_MaxA : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.maxA&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.maxA&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/maxA";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/median</para>
    ///     <para type="description">The action &quot;microsoft.graph.median&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Median", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Median : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.median&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.median&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/median";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/mid</para>
    ///     <para type="description">The action &quot;microsoft.graph.mid&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Mid", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Mid : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.mid&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.mid&quot; action.")]
        public System.Object text { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;startNum&quot; parameter, which is accepted by the &quot;microsoft.graph.mid&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;startNum&quot; parameter, which is accepted by the &quot;microsoft.graph.mid&quot; action.")]
        public System.Object startNum { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;numChars&quot; parameter, which is accepted by the &quot;microsoft.graph.mid&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;numChars&quot; parameter, which is accepted by the &quot;microsoft.graph.mid&quot; action.")]
        public System.Object numChars { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/mid";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/midb</para>
    ///     <para type="description">The action &quot;microsoft.graph.midb&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Midb", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Midb : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.midb&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.midb&quot; action.")]
        public System.Object text { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;startNum&quot; parameter, which is accepted by the &quot;microsoft.graph.midb&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;startNum&quot; parameter, which is accepted by the &quot;microsoft.graph.midb&quot; action.")]
        public System.Object startNum { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;numBytes&quot; parameter, which is accepted by the &quot;microsoft.graph.midb&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;numBytes&quot; parameter, which is accepted by the &quot;microsoft.graph.midb&quot; action.")]
        public System.Object numBytes { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/midb";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/min</para>
    ///     <para type="description">The action &quot;microsoft.graph.min&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Min", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Min : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.min&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.min&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/min";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/minA</para>
    ///     <para type="description">The action &quot;microsoft.graph.minA&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_MinA", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_MinA : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.minA&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.minA&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/minA";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/minute</para>
    ///     <para type="description">The action &quot;microsoft.graph.minute&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Minute", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Minute : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;serialNumber&quot; parameter, which is accepted by the &quot;microsoft.graph.minute&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;serialNumber&quot; parameter, which is accepted by the &quot;microsoft.graph.minute&quot; action.")]
        public System.Object serialNumber { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/minute";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/mod</para>
    ///     <para type="description">The action &quot;microsoft.graph.mod&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Mod", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Mod : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.mod&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.mod&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;divisor&quot; parameter, which is accepted by the &quot;microsoft.graph.mod&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;divisor&quot; parameter, which is accepted by the &quot;microsoft.graph.mod&quot; action.")]
        public System.Object divisor { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/mod";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/month</para>
    ///     <para type="description">The action &quot;microsoft.graph.month&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Month", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Month : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;serialNumber&quot; parameter, which is accepted by the &quot;microsoft.graph.month&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;serialNumber&quot; parameter, which is accepted by the &quot;microsoft.graph.month&quot; action.")]
        public System.Object serialNumber { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/month";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/multiNomial</para>
    ///     <para type="description">The action &quot;microsoft.graph.multiNomial&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_MultiNomial", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_MultiNomial : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.multiNomial&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.multiNomial&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/multiNomial";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/n</para>
    ///     <para type="description">The action &quot;microsoft.graph.n&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_N", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_N : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;value&quot; parameter, which is accepted by the &quot;microsoft.graph.n&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;value&quot; parameter, which is accepted by the &quot;microsoft.graph.n&quot; action.")]
        public System.Object value { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/n";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/nper</para>
    ///     <para type="description">The action &quot;microsoft.graph.nper&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Nper", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Nper : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.nper&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.nper&quot; action.")]
        public System.Object rate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pmt&quot; parameter, which is accepted by the &quot;microsoft.graph.nper&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;pmt&quot; parameter, which is accepted by the &quot;microsoft.graph.nper&quot; action.")]
        public System.Object pmt { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pv&quot; parameter, which is accepted by the &quot;microsoft.graph.nper&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;pv&quot; parameter, which is accepted by the &quot;microsoft.graph.nper&quot; action.")]
        public System.Object pv { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fv&quot; parameter, which is accepted by the &quot;microsoft.graph.nper&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;fv&quot; parameter, which is accepted by the &quot;microsoft.graph.nper&quot; action.")]
        public System.Object fv { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;type&quot; parameter, which is accepted by the &quot;microsoft.graph.nper&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;type&quot; parameter, which is accepted by the &quot;microsoft.graph.nper&quot; action.")]
        public System.Object type { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/nper";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/na</para>
    ///     <para type="description">The action &quot;microsoft.graph.na&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Na", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Na : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/na";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/negBinom_Dist</para>
    ///     <para type="description">The action &quot;microsoft.graph.negBinom_Dist&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_NegBinomDist", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_NegBinomDist : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;numberF&quot; parameter, which is accepted by the &quot;microsoft.graph.negBinom_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;numberF&quot; parameter, which is accepted by the &quot;microsoft.graph.negBinom_Dist&quot; action.")]
        public System.Object numberF { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;numberS&quot; parameter, which is accepted by the &quot;microsoft.graph.negBinom_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;numberS&quot; parameter, which is accepted by the &quot;microsoft.graph.negBinom_Dist&quot; action.")]
        public System.Object numberS { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;probabilityS&quot; parameter, which is accepted by the &quot;microsoft.graph.negBinom_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;probabilityS&quot; parameter, which is accepted by the &quot;microsoft.graph.negBinom_Dist&quot; action.")]
        public System.Object probabilityS { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;cumulative&quot; parameter, which is accepted by the &quot;microsoft.graph.negBinom_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;cumulative&quot; parameter, which is accepted by the &quot;microsoft.graph.negBinom_Dist&quot; action.")]
        public System.Object cumulative { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/negBinom_Dist";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/networkDays</para>
    ///     <para type="description">The action &quot;microsoft.graph.networkDays&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_NetworkDays", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_NetworkDays : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;startDate&quot; parameter, which is accepted by the &quot;microsoft.graph.networkDays&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;startDate&quot; parameter, which is accepted by the &quot;microsoft.graph.networkDays&quot; action.")]
        public System.Object startDate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;endDate&quot; parameter, which is accepted by the &quot;microsoft.graph.networkDays&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;endDate&quot; parameter, which is accepted by the &quot;microsoft.graph.networkDays&quot; action.")]
        public System.Object endDate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;holidays&quot; parameter, which is accepted by the &quot;microsoft.graph.networkDays&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;holidays&quot; parameter, which is accepted by the &quot;microsoft.graph.networkDays&quot; action.")]
        public System.Object holidays { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/networkDays";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/networkDays_Intl</para>
    ///     <para type="description">The action &quot;microsoft.graph.networkDays_Intl&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_NetworkDaysIntl", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_NetworkDaysIntl : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;startDate&quot; parameter, which is accepted by the &quot;microsoft.graph.networkDays_Intl&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;startDate&quot; parameter, which is accepted by the &quot;microsoft.graph.networkDays_Intl&quot; action.")]
        public System.Object startDate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;endDate&quot; parameter, which is accepted by the &quot;microsoft.graph.networkDays_Intl&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;endDate&quot; parameter, which is accepted by the &quot;microsoft.graph.networkDays_Intl&quot; action.")]
        public System.Object endDate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;weekend&quot; parameter, which is accepted by the &quot;microsoft.graph.networkDays_Intl&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;weekend&quot; parameter, which is accepted by the &quot;microsoft.graph.networkDays_Intl&quot; action.")]
        public System.Object weekend { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;holidays&quot; parameter, which is accepted by the &quot;microsoft.graph.networkDays_Intl&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;holidays&quot; parameter, which is accepted by the &quot;microsoft.graph.networkDays_Intl&quot; action.")]
        public System.Object holidays { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/networkDays_Intl";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/nominal</para>
    ///     <para type="description">The action &quot;microsoft.graph.nominal&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Nominal", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Nominal : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;effectRate&quot; parameter, which is accepted by the &quot;microsoft.graph.nominal&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;effectRate&quot; parameter, which is accepted by the &quot;microsoft.graph.nominal&quot; action.")]
        public System.Object effectRate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;npery&quot; parameter, which is accepted by the &quot;microsoft.graph.nominal&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;npery&quot; parameter, which is accepted by the &quot;microsoft.graph.nominal&quot; action.")]
        public System.Object npery { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/nominal";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/norm_Dist</para>
    ///     <para type="description">The action &quot;microsoft.graph.norm_Dist&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_NormDist", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_NormDist : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.norm_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.norm_Dist&quot; action.")]
        public System.Object x { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mean&quot; parameter, which is accepted by the &quot;microsoft.graph.norm_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;mean&quot; parameter, which is accepted by the &quot;microsoft.graph.norm_Dist&quot; action.")]
        public System.Object mean { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;standardDev&quot; parameter, which is accepted by the &quot;microsoft.graph.norm_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;standardDev&quot; parameter, which is accepted by the &quot;microsoft.graph.norm_Dist&quot; action.")]
        public System.Object standardDev { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;cumulative&quot; parameter, which is accepted by the &quot;microsoft.graph.norm_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;cumulative&quot; parameter, which is accepted by the &quot;microsoft.graph.norm_Dist&quot; action.")]
        public System.Object cumulative { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/norm_Dist";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/norm_Inv</para>
    ///     <para type="description">The action &quot;microsoft.graph.norm_Inv&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_NormInv", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_NormInv : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;probability&quot; parameter, which is accepted by the &quot;microsoft.graph.norm_Inv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;probability&quot; parameter, which is accepted by the &quot;microsoft.graph.norm_Inv&quot; action.")]
        public System.Object probability { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mean&quot; parameter, which is accepted by the &quot;microsoft.graph.norm_Inv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;mean&quot; parameter, which is accepted by the &quot;microsoft.graph.norm_Inv&quot; action.")]
        public System.Object mean { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;standardDev&quot; parameter, which is accepted by the &quot;microsoft.graph.norm_Inv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;standardDev&quot; parameter, which is accepted by the &quot;microsoft.graph.norm_Inv&quot; action.")]
        public System.Object standardDev { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/norm_Inv";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/norm_S_Dist</para>
    ///     <para type="description">The action &quot;microsoft.graph.norm_S_Dist&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_NormSDist", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_NormSDist : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;z&quot; parameter, which is accepted by the &quot;microsoft.graph.norm_S_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;z&quot; parameter, which is accepted by the &quot;microsoft.graph.norm_S_Dist&quot; action.")]
        public System.Object z { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;cumulative&quot; parameter, which is accepted by the &quot;microsoft.graph.norm_S_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;cumulative&quot; parameter, which is accepted by the &quot;microsoft.graph.norm_S_Dist&quot; action.")]
        public System.Object cumulative { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/norm_S_Dist";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/norm_S_Inv</para>
    ///     <para type="description">The action &quot;microsoft.graph.norm_S_Inv&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_NormSInv", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_NormSInv : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;probability&quot; parameter, which is accepted by the &quot;microsoft.graph.norm_S_Inv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;probability&quot; parameter, which is accepted by the &quot;microsoft.graph.norm_S_Inv&quot; action.")]
        public System.Object probability { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/norm_S_Inv";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/not</para>
    ///     <para type="description">The action &quot;microsoft.graph.not&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Not", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Not : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;logical&quot; parameter, which is accepted by the &quot;microsoft.graph.not&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;logical&quot; parameter, which is accepted by the &quot;microsoft.graph.not&quot; action.")]
        public System.Object logical { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/not";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/now</para>
    ///     <para type="description">The action &quot;microsoft.graph.now&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Now", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Now : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/now";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/npv</para>
    ///     <para type="description">The action &quot;microsoft.graph.npv&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Npv", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Npv : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.npv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.npv&quot; action.")]
        public System.Object rate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.npv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.npv&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/npv";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/numberValue</para>
    ///     <para type="description">The action &quot;microsoft.graph.numberValue&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_NumberValue", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_NumberValue : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.numberValue&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.numberValue&quot; action.")]
        public System.Object text { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;decimalSeparator&quot; parameter, which is accepted by the &quot;microsoft.graph.numberValue&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;decimalSeparator&quot; parameter, which is accepted by the &quot;microsoft.graph.numberValue&quot; action.")]
        public System.Object decimalSeparator { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;groupSeparator&quot; parameter, which is accepted by the &quot;microsoft.graph.numberValue&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;groupSeparator&quot; parameter, which is accepted by the &quot;microsoft.graph.numberValue&quot; action.")]
        public System.Object groupSeparator { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/numberValue";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/oct2Bin</para>
    ///     <para type="description">The action &quot;microsoft.graph.oct2Bin&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Oct2Bin", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Oct2Bin : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.oct2Bin&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.oct2Bin&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;places&quot; parameter, which is accepted by the &quot;microsoft.graph.oct2Bin&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;places&quot; parameter, which is accepted by the &quot;microsoft.graph.oct2Bin&quot; action.")]
        public System.Object places { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/oct2Bin";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/oct2Dec</para>
    ///     <para type="description">The action &quot;microsoft.graph.oct2Dec&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Oct2Dec", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Oct2Dec : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.oct2Dec&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.oct2Dec&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/oct2Dec";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/oct2Hex</para>
    ///     <para type="description">The action &quot;microsoft.graph.oct2Hex&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Oct2Hex", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Oct2Hex : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.oct2Hex&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.oct2Hex&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;places&quot; parameter, which is accepted by the &quot;microsoft.graph.oct2Hex&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;places&quot; parameter, which is accepted by the &quot;microsoft.graph.oct2Hex&quot; action.")]
        public System.Object places { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/oct2Hex";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/odd</para>
    ///     <para type="description">The action &quot;microsoft.graph.odd&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Odd", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Odd : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.odd&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.odd&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/odd";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/oddFPrice</para>
    ///     <para type="description">The action &quot;microsoft.graph.oddFPrice&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_OddFPrice", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_OddFPrice : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.oddFPrice&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.oddFPrice&quot; action.")]
        public System.Object settlement { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.oddFPrice&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.oddFPrice&quot; action.")]
        public System.Object maturity { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;issue&quot; parameter, which is accepted by the &quot;microsoft.graph.oddFPrice&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;issue&quot; parameter, which is accepted by the &quot;microsoft.graph.oddFPrice&quot; action.")]
        public System.Object issue { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;firstCoupon&quot; parameter, which is accepted by the &quot;microsoft.graph.oddFPrice&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;firstCoupon&quot; parameter, which is accepted by the &quot;microsoft.graph.oddFPrice&quot; action.")]
        public System.Object firstCoupon { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.oddFPrice&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.oddFPrice&quot; action.")]
        public System.Object rate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;yld&quot; parameter, which is accepted by the &quot;microsoft.graph.oddFPrice&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;yld&quot; parameter, which is accepted by the &quot;microsoft.graph.oddFPrice&quot; action.")]
        public System.Object yld { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;redemption&quot; parameter, which is accepted by the &quot;microsoft.graph.oddFPrice&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;redemption&quot; parameter, which is accepted by the &quot;microsoft.graph.oddFPrice&quot; action.")]
        public System.Object redemption { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;frequency&quot; parameter, which is accepted by the &quot;microsoft.graph.oddFPrice&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;frequency&quot; parameter, which is accepted by the &quot;microsoft.graph.oddFPrice&quot; action.")]
        public System.Object frequency { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.oddFPrice&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.oddFPrice&quot; action.")]
        public System.Object basis { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/oddFPrice";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/oddFYield</para>
    ///     <para type="description">The action &quot;microsoft.graph.oddFYield&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_OddFYield", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_OddFYield : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.oddFYield&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.oddFYield&quot; action.")]
        public System.Object settlement { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.oddFYield&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.oddFYield&quot; action.")]
        public System.Object maturity { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;issue&quot; parameter, which is accepted by the &quot;microsoft.graph.oddFYield&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;issue&quot; parameter, which is accepted by the &quot;microsoft.graph.oddFYield&quot; action.")]
        public System.Object issue { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;firstCoupon&quot; parameter, which is accepted by the &quot;microsoft.graph.oddFYield&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;firstCoupon&quot; parameter, which is accepted by the &quot;microsoft.graph.oddFYield&quot; action.")]
        public System.Object firstCoupon { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.oddFYield&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.oddFYield&quot; action.")]
        public System.Object rate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pr&quot; parameter, which is accepted by the &quot;microsoft.graph.oddFYield&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;pr&quot; parameter, which is accepted by the &quot;microsoft.graph.oddFYield&quot; action.")]
        public System.Object pr { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;redemption&quot; parameter, which is accepted by the &quot;microsoft.graph.oddFYield&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;redemption&quot; parameter, which is accepted by the &quot;microsoft.graph.oddFYield&quot; action.")]
        public System.Object redemption { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;frequency&quot; parameter, which is accepted by the &quot;microsoft.graph.oddFYield&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;frequency&quot; parameter, which is accepted by the &quot;microsoft.graph.oddFYield&quot; action.")]
        public System.Object frequency { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.oddFYield&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.oddFYield&quot; action.")]
        public System.Object basis { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/oddFYield";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/oddLPrice</para>
    ///     <para type="description">The action &quot;microsoft.graph.oddLPrice&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_OddLPrice", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_OddLPrice : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.oddLPrice&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.oddLPrice&quot; action.")]
        public System.Object settlement { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.oddLPrice&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.oddLPrice&quot; action.")]
        public System.Object maturity { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastInterest&quot; parameter, which is accepted by the &quot;microsoft.graph.oddLPrice&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;lastInterest&quot; parameter, which is accepted by the &quot;microsoft.graph.oddLPrice&quot; action.")]
        public System.Object lastInterest { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.oddLPrice&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.oddLPrice&quot; action.")]
        public System.Object rate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;yld&quot; parameter, which is accepted by the &quot;microsoft.graph.oddLPrice&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;yld&quot; parameter, which is accepted by the &quot;microsoft.graph.oddLPrice&quot; action.")]
        public System.Object yld { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;redemption&quot; parameter, which is accepted by the &quot;microsoft.graph.oddLPrice&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;redemption&quot; parameter, which is accepted by the &quot;microsoft.graph.oddLPrice&quot; action.")]
        public System.Object redemption { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;frequency&quot; parameter, which is accepted by the &quot;microsoft.graph.oddLPrice&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;frequency&quot; parameter, which is accepted by the &quot;microsoft.graph.oddLPrice&quot; action.")]
        public System.Object frequency { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.oddLPrice&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.oddLPrice&quot; action.")]
        public System.Object basis { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/oddLPrice";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/oddLYield</para>
    ///     <para type="description">The action &quot;microsoft.graph.oddLYield&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_OddLYield", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_OddLYield : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.oddLYield&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.oddLYield&quot; action.")]
        public System.Object settlement { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.oddLYield&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.oddLYield&quot; action.")]
        public System.Object maturity { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;lastInterest&quot; parameter, which is accepted by the &quot;microsoft.graph.oddLYield&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;lastInterest&quot; parameter, which is accepted by the &quot;microsoft.graph.oddLYield&quot; action.")]
        public System.Object lastInterest { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.oddLYield&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.oddLYield&quot; action.")]
        public System.Object rate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pr&quot; parameter, which is accepted by the &quot;microsoft.graph.oddLYield&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;pr&quot; parameter, which is accepted by the &quot;microsoft.graph.oddLYield&quot; action.")]
        public System.Object pr { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;redemption&quot; parameter, which is accepted by the &quot;microsoft.graph.oddLYield&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;redemption&quot; parameter, which is accepted by the &quot;microsoft.graph.oddLYield&quot; action.")]
        public System.Object redemption { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;frequency&quot; parameter, which is accepted by the &quot;microsoft.graph.oddLYield&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;frequency&quot; parameter, which is accepted by the &quot;microsoft.graph.oddLYield&quot; action.")]
        public System.Object frequency { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.oddLYield&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.oddLYield&quot; action.")]
        public System.Object basis { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/oddLYield";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/or</para>
    ///     <para type="description">The action &quot;microsoft.graph.or&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Or", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Or : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.or&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.or&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/or";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/pduration</para>
    ///     <para type="description">The action &quot;microsoft.graph.pduration&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Pduration", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Pduration : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.pduration&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.pduration&quot; action.")]
        public System.Object rate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pv&quot; parameter, which is accepted by the &quot;microsoft.graph.pduration&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;pv&quot; parameter, which is accepted by the &quot;microsoft.graph.pduration&quot; action.")]
        public System.Object pv { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fv&quot; parameter, which is accepted by the &quot;microsoft.graph.pduration&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;fv&quot; parameter, which is accepted by the &quot;microsoft.graph.pduration&quot; action.")]
        public System.Object fv { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/pduration";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/percentRank_Exc</para>
    ///     <para type="description">The action &quot;microsoft.graph.percentRank_Exc&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_PercentRankExc", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_PercentRankExc : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;array&quot; parameter, which is accepted by the &quot;microsoft.graph.percentRank_Exc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;array&quot; parameter, which is accepted by the &quot;microsoft.graph.percentRank_Exc&quot; action.")]
        public System.Object array { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.percentRank_Exc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.percentRank_Exc&quot; action.")]
        public System.Object x { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;significance&quot; parameter, which is accepted by the &quot;microsoft.graph.percentRank_Exc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;significance&quot; parameter, which is accepted by the &quot;microsoft.graph.percentRank_Exc&quot; action.")]
        public System.Object significance { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/percentRank_Exc";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/percentRank_Inc</para>
    ///     <para type="description">The action &quot;microsoft.graph.percentRank_Inc&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_PercentRankInc", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_PercentRankInc : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;array&quot; parameter, which is accepted by the &quot;microsoft.graph.percentRank_Inc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;array&quot; parameter, which is accepted by the &quot;microsoft.graph.percentRank_Inc&quot; action.")]
        public System.Object array { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.percentRank_Inc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.percentRank_Inc&quot; action.")]
        public System.Object x { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;significance&quot; parameter, which is accepted by the &quot;microsoft.graph.percentRank_Inc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;significance&quot; parameter, which is accepted by the &quot;microsoft.graph.percentRank_Inc&quot; action.")]
        public System.Object significance { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/percentRank_Inc";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/percentile_Exc</para>
    ///     <para type="description">The action &quot;microsoft.graph.percentile_Exc&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_PercentileExc", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_PercentileExc : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;array&quot; parameter, which is accepted by the &quot;microsoft.graph.percentile_Exc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;array&quot; parameter, which is accepted by the &quot;microsoft.graph.percentile_Exc&quot; action.")]
        public System.Object array { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;k&quot; parameter, which is accepted by the &quot;microsoft.graph.percentile_Exc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;k&quot; parameter, which is accepted by the &quot;microsoft.graph.percentile_Exc&quot; action.")]
        public System.Object k { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/percentile_Exc";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/percentile_Inc</para>
    ///     <para type="description">The action &quot;microsoft.graph.percentile_Inc&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_PercentileInc", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_PercentileInc : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;array&quot; parameter, which is accepted by the &quot;microsoft.graph.percentile_Inc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;array&quot; parameter, which is accepted by the &quot;microsoft.graph.percentile_Inc&quot; action.")]
        public System.Object array { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;k&quot; parameter, which is accepted by the &quot;microsoft.graph.percentile_Inc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;k&quot; parameter, which is accepted by the &quot;microsoft.graph.percentile_Inc&quot; action.")]
        public System.Object k { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/percentile_Inc";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/permut</para>
    ///     <para type="description">The action &quot;microsoft.graph.permut&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Permut", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Permut : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.permut&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.permut&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;numberChosen&quot; parameter, which is accepted by the &quot;microsoft.graph.permut&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;numberChosen&quot; parameter, which is accepted by the &quot;microsoft.graph.permut&quot; action.")]
        public System.Object numberChosen { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/permut";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/permutationa</para>
    ///     <para type="description">The action &quot;microsoft.graph.permutationa&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Permutationa", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Permutationa : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.permutationa&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.permutationa&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;numberChosen&quot; parameter, which is accepted by the &quot;microsoft.graph.permutationa&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;numberChosen&quot; parameter, which is accepted by the &quot;microsoft.graph.permutationa&quot; action.")]
        public System.Object numberChosen { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/permutationa";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/phi</para>
    ///     <para type="description">The action &quot;microsoft.graph.phi&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Phi", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Phi : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.phi&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.phi&quot; action.")]
        public System.Object x { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/phi";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/pi</para>
    ///     <para type="description">The action &quot;microsoft.graph.pi&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Pi", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Pi : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/pi";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/pmt</para>
    ///     <para type="description">The action &quot;microsoft.graph.pmt&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Pmt", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Pmt : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.pmt&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.pmt&quot; action.")]
        public System.Object rate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;nper&quot; parameter, which is accepted by the &quot;microsoft.graph.pmt&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;nper&quot; parameter, which is accepted by the &quot;microsoft.graph.pmt&quot; action.")]
        public System.Object nper { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pv&quot; parameter, which is accepted by the &quot;microsoft.graph.pmt&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;pv&quot; parameter, which is accepted by the &quot;microsoft.graph.pmt&quot; action.")]
        public System.Object pv { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fv&quot; parameter, which is accepted by the &quot;microsoft.graph.pmt&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;fv&quot; parameter, which is accepted by the &quot;microsoft.graph.pmt&quot; action.")]
        public System.Object fv { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;type&quot; parameter, which is accepted by the &quot;microsoft.graph.pmt&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;type&quot; parameter, which is accepted by the &quot;microsoft.graph.pmt&quot; action.")]
        public System.Object type { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/pmt";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/poisson_Dist</para>
    ///     <para type="description">The action &quot;microsoft.graph.poisson_Dist&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_PoissonDist", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_PoissonDist : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.poisson_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.poisson_Dist&quot; action.")]
        public System.Object x { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mean&quot; parameter, which is accepted by the &quot;microsoft.graph.poisson_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;mean&quot; parameter, which is accepted by the &quot;microsoft.graph.poisson_Dist&quot; action.")]
        public System.Object mean { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;cumulative&quot; parameter, which is accepted by the &quot;microsoft.graph.poisson_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;cumulative&quot; parameter, which is accepted by the &quot;microsoft.graph.poisson_Dist&quot; action.")]
        public System.Object cumulative { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/poisson_Dist";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/power</para>
    ///     <para type="description">The action &quot;microsoft.graph.power&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Power", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Power : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.power&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.power&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;power&quot; parameter, which is accepted by the &quot;microsoft.graph.power&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;power&quot; parameter, which is accepted by the &quot;microsoft.graph.power&quot; action.")]
        public System.Object power { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/power";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/ppmt</para>
    ///     <para type="description">The action &quot;microsoft.graph.ppmt&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Ppmt", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Ppmt : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.ppmt&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.ppmt&quot; action.")]
        public System.Object rate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;per&quot; parameter, which is accepted by the &quot;microsoft.graph.ppmt&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;per&quot; parameter, which is accepted by the &quot;microsoft.graph.ppmt&quot; action.")]
        public System.Object per { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;nper&quot; parameter, which is accepted by the &quot;microsoft.graph.ppmt&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;nper&quot; parameter, which is accepted by the &quot;microsoft.graph.ppmt&quot; action.")]
        public System.Object nper { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pv&quot; parameter, which is accepted by the &quot;microsoft.graph.ppmt&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;pv&quot; parameter, which is accepted by the &quot;microsoft.graph.ppmt&quot; action.")]
        public System.Object pv { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fv&quot; parameter, which is accepted by the &quot;microsoft.graph.ppmt&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;fv&quot; parameter, which is accepted by the &quot;microsoft.graph.ppmt&quot; action.")]
        public System.Object fv { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;type&quot; parameter, which is accepted by the &quot;microsoft.graph.ppmt&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;type&quot; parameter, which is accepted by the &quot;microsoft.graph.ppmt&quot; action.")]
        public System.Object type { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/ppmt";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/price</para>
    ///     <para type="description">The action &quot;microsoft.graph.price&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Price", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Price : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.price&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.price&quot; action.")]
        public System.Object settlement { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.price&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.price&quot; action.")]
        public System.Object maturity { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.price&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.price&quot; action.")]
        public System.Object rate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;yld&quot; parameter, which is accepted by the &quot;microsoft.graph.price&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;yld&quot; parameter, which is accepted by the &quot;microsoft.graph.price&quot; action.")]
        public System.Object yld { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;redemption&quot; parameter, which is accepted by the &quot;microsoft.graph.price&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;redemption&quot; parameter, which is accepted by the &quot;microsoft.graph.price&quot; action.")]
        public System.Object redemption { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;frequency&quot; parameter, which is accepted by the &quot;microsoft.graph.price&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;frequency&quot; parameter, which is accepted by the &quot;microsoft.graph.price&quot; action.")]
        public System.Object frequency { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.price&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.price&quot; action.")]
        public System.Object basis { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/price";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/priceDisc</para>
    ///     <para type="description">The action &quot;microsoft.graph.priceDisc&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_PriceDisc", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_PriceDisc : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.priceDisc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.priceDisc&quot; action.")]
        public System.Object settlement { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.priceDisc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.priceDisc&quot; action.")]
        public System.Object maturity { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;discount&quot; parameter, which is accepted by the &quot;microsoft.graph.priceDisc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;discount&quot; parameter, which is accepted by the &quot;microsoft.graph.priceDisc&quot; action.")]
        public System.Object discount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;redemption&quot; parameter, which is accepted by the &quot;microsoft.graph.priceDisc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;redemption&quot; parameter, which is accepted by the &quot;microsoft.graph.priceDisc&quot; action.")]
        public System.Object redemption { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.priceDisc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.priceDisc&quot; action.")]
        public System.Object basis { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/priceDisc";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/priceMat</para>
    ///     <para type="description">The action &quot;microsoft.graph.priceMat&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_PriceMat", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_PriceMat : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.priceMat&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.priceMat&quot; action.")]
        public System.Object settlement { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.priceMat&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.priceMat&quot; action.")]
        public System.Object maturity { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;issue&quot; parameter, which is accepted by the &quot;microsoft.graph.priceMat&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;issue&quot; parameter, which is accepted by the &quot;microsoft.graph.priceMat&quot; action.")]
        public System.Object issue { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.priceMat&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.priceMat&quot; action.")]
        public System.Object rate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;yld&quot; parameter, which is accepted by the &quot;microsoft.graph.priceMat&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;yld&quot; parameter, which is accepted by the &quot;microsoft.graph.priceMat&quot; action.")]
        public System.Object yld { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.priceMat&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.priceMat&quot; action.")]
        public System.Object basis { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/priceMat";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/product</para>
    ///     <para type="description">The action &quot;microsoft.graph.product&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Product", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Product : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.product&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.product&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/product";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/proper</para>
    ///     <para type="description">The action &quot;microsoft.graph.proper&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Proper", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Proper : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.proper&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.proper&quot; action.")]
        public System.Object text { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/proper";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/pv</para>
    ///     <para type="description">The action &quot;microsoft.graph.pv&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Pv", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Pv : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.pv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.pv&quot; action.")]
        public System.Object rate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;nper&quot; parameter, which is accepted by the &quot;microsoft.graph.pv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;nper&quot; parameter, which is accepted by the &quot;microsoft.graph.pv&quot; action.")]
        public System.Object nper { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pmt&quot; parameter, which is accepted by the &quot;microsoft.graph.pv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;pmt&quot; parameter, which is accepted by the &quot;microsoft.graph.pv&quot; action.")]
        public System.Object pmt { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fv&quot; parameter, which is accepted by the &quot;microsoft.graph.pv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;fv&quot; parameter, which is accepted by the &quot;microsoft.graph.pv&quot; action.")]
        public System.Object fv { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;type&quot; parameter, which is accepted by the &quot;microsoft.graph.pv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;type&quot; parameter, which is accepted by the &quot;microsoft.graph.pv&quot; action.")]
        public System.Object type { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/pv";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/quartile_Exc</para>
    ///     <para type="description">The action &quot;microsoft.graph.quartile_Exc&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_QuartileExc", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_QuartileExc : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;array&quot; parameter, which is accepted by the &quot;microsoft.graph.quartile_Exc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;array&quot; parameter, which is accepted by the &quot;microsoft.graph.quartile_Exc&quot; action.")]
        public System.Object array { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;quart&quot; parameter, which is accepted by the &quot;microsoft.graph.quartile_Exc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;quart&quot; parameter, which is accepted by the &quot;microsoft.graph.quartile_Exc&quot; action.")]
        public System.Object quart { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/quartile_Exc";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/quartile_Inc</para>
    ///     <para type="description">The action &quot;microsoft.graph.quartile_Inc&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_QuartileInc", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_QuartileInc : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;array&quot; parameter, which is accepted by the &quot;microsoft.graph.quartile_Inc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;array&quot; parameter, which is accepted by the &quot;microsoft.graph.quartile_Inc&quot; action.")]
        public System.Object array { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;quart&quot; parameter, which is accepted by the &quot;microsoft.graph.quartile_Inc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;quart&quot; parameter, which is accepted by the &quot;microsoft.graph.quartile_Inc&quot; action.")]
        public System.Object quart { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/quartile_Inc";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/quotient</para>
    ///     <para type="description">The action &quot;microsoft.graph.quotient&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Quotient", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Quotient : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;numerator&quot; parameter, which is accepted by the &quot;microsoft.graph.quotient&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;numerator&quot; parameter, which is accepted by the &quot;microsoft.graph.quotient&quot; action.")]
        public System.Object numerator { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;denominator&quot; parameter, which is accepted by the &quot;microsoft.graph.quotient&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;denominator&quot; parameter, which is accepted by the &quot;microsoft.graph.quotient&quot; action.")]
        public System.Object denominator { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/quotient";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/radians</para>
    ///     <para type="description">The action &quot;microsoft.graph.radians&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Radians", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Radians : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;angle&quot; parameter, which is accepted by the &quot;microsoft.graph.radians&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;angle&quot; parameter, which is accepted by the &quot;microsoft.graph.radians&quot; action.")]
        public System.Object angle { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/radians";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/rand</para>
    ///     <para type="description">The action &quot;microsoft.graph.rand&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Rand", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Rand : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/rand";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/randBetween</para>
    ///     <para type="description">The action &quot;microsoft.graph.randBetween&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_RandBetween", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_RandBetween : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;bottom&quot; parameter, which is accepted by the &quot;microsoft.graph.randBetween&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;bottom&quot; parameter, which is accepted by the &quot;microsoft.graph.randBetween&quot; action.")]
        public System.Object bottom { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;top&quot; parameter, which is accepted by the &quot;microsoft.graph.randBetween&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;top&quot; parameter, which is accepted by the &quot;microsoft.graph.randBetween&quot; action.")]
        public System.Object top { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/randBetween";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/rank_Avg</para>
    ///     <para type="description">The action &quot;microsoft.graph.rank_Avg&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_RankAvg", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_RankAvg : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.rank_Avg&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.rank_Avg&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;ref&quot; parameter, which is accepted by the &quot;microsoft.graph.rank_Avg&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;ref&quot; parameter, which is accepted by the &quot;microsoft.graph.rank_Avg&quot; action.")]
        public System.Object @ref { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;order&quot; parameter, which is accepted by the &quot;microsoft.graph.rank_Avg&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;order&quot; parameter, which is accepted by the &quot;microsoft.graph.rank_Avg&quot; action.")]
        public System.Object order { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/rank_Avg";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/rank_Eq</para>
    ///     <para type="description">The action &quot;microsoft.graph.rank_Eq&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_RankEq", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_RankEq : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.rank_Eq&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.rank_Eq&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;ref&quot; parameter, which is accepted by the &quot;microsoft.graph.rank_Eq&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;ref&quot; parameter, which is accepted by the &quot;microsoft.graph.rank_Eq&quot; action.")]
        public System.Object @ref { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;order&quot; parameter, which is accepted by the &quot;microsoft.graph.rank_Eq&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;order&quot; parameter, which is accepted by the &quot;microsoft.graph.rank_Eq&quot; action.")]
        public System.Object order { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/rank_Eq";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/rate</para>
    ///     <para type="description">The action &quot;microsoft.graph.rate&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Rate", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Rate : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;nper&quot; parameter, which is accepted by the &quot;microsoft.graph.rate&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;nper&quot; parameter, which is accepted by the &quot;microsoft.graph.rate&quot; action.")]
        public System.Object nper { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pmt&quot; parameter, which is accepted by the &quot;microsoft.graph.rate&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;pmt&quot; parameter, which is accepted by the &quot;microsoft.graph.rate&quot; action.")]
        public System.Object pmt { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pv&quot; parameter, which is accepted by the &quot;microsoft.graph.rate&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;pv&quot; parameter, which is accepted by the &quot;microsoft.graph.rate&quot; action.")]
        public System.Object pv { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fv&quot; parameter, which is accepted by the &quot;microsoft.graph.rate&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;fv&quot; parameter, which is accepted by the &quot;microsoft.graph.rate&quot; action.")]
        public System.Object fv { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;type&quot; parameter, which is accepted by the &quot;microsoft.graph.rate&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;type&quot; parameter, which is accepted by the &quot;microsoft.graph.rate&quot; action.")]
        public System.Object type { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;guess&quot; parameter, which is accepted by the &quot;microsoft.graph.rate&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;guess&quot; parameter, which is accepted by the &quot;microsoft.graph.rate&quot; action.")]
        public System.Object guess { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/rate";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/received</para>
    ///     <para type="description">The action &quot;microsoft.graph.received&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Received", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Received : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.received&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.received&quot; action.")]
        public System.Object settlement { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.received&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.received&quot; action.")]
        public System.Object maturity { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;investment&quot; parameter, which is accepted by the &quot;microsoft.graph.received&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;investment&quot; parameter, which is accepted by the &quot;microsoft.graph.received&quot; action.")]
        public System.Object investment { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;discount&quot; parameter, which is accepted by the &quot;microsoft.graph.received&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;discount&quot; parameter, which is accepted by the &quot;microsoft.graph.received&quot; action.")]
        public System.Object discount { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.received&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.received&quot; action.")]
        public System.Object basis { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/received";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/replace</para>
    ///     <para type="description">The action &quot;microsoft.graph.replace&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Replace", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Replace : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;oldText&quot; parameter, which is accepted by the &quot;microsoft.graph.replace&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;oldText&quot; parameter, which is accepted by the &quot;microsoft.graph.replace&quot; action.")]
        public System.Object oldText { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;startNum&quot; parameter, which is accepted by the &quot;microsoft.graph.replace&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;startNum&quot; parameter, which is accepted by the &quot;microsoft.graph.replace&quot; action.")]
        public System.Object startNum { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;numChars&quot; parameter, which is accepted by the &quot;microsoft.graph.replace&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;numChars&quot; parameter, which is accepted by the &quot;microsoft.graph.replace&quot; action.")]
        public System.Object numChars { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;newText&quot; parameter, which is accepted by the &quot;microsoft.graph.replace&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;newText&quot; parameter, which is accepted by the &quot;microsoft.graph.replace&quot; action.")]
        public System.Object newText { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/replace";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/replaceB</para>
    ///     <para type="description">The action &quot;microsoft.graph.replaceB&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_ReplaceB", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_ReplaceB : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;oldText&quot; parameter, which is accepted by the &quot;microsoft.graph.replaceB&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;oldText&quot; parameter, which is accepted by the &quot;microsoft.graph.replaceB&quot; action.")]
        public System.Object oldText { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;startNum&quot; parameter, which is accepted by the &quot;microsoft.graph.replaceB&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;startNum&quot; parameter, which is accepted by the &quot;microsoft.graph.replaceB&quot; action.")]
        public System.Object startNum { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;numBytes&quot; parameter, which is accepted by the &quot;microsoft.graph.replaceB&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;numBytes&quot; parameter, which is accepted by the &quot;microsoft.graph.replaceB&quot; action.")]
        public System.Object numBytes { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;newText&quot; parameter, which is accepted by the &quot;microsoft.graph.replaceB&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;newText&quot; parameter, which is accepted by the &quot;microsoft.graph.replaceB&quot; action.")]
        public System.Object newText { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/replaceB";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/rept</para>
    ///     <para type="description">The action &quot;microsoft.graph.rept&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Rept", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Rept : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.rept&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.rept&quot; action.")]
        public System.Object text { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;numberTimes&quot; parameter, which is accepted by the &quot;microsoft.graph.rept&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;numberTimes&quot; parameter, which is accepted by the &quot;microsoft.graph.rept&quot; action.")]
        public System.Object numberTimes { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/rept";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/right</para>
    ///     <para type="description">The action &quot;microsoft.graph.right&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Right", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Right : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.right&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.right&quot; action.")]
        public System.Object text { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;numChars&quot; parameter, which is accepted by the &quot;microsoft.graph.right&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;numChars&quot; parameter, which is accepted by the &quot;microsoft.graph.right&quot; action.")]
        public System.Object numChars { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/right";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/rightb</para>
    ///     <para type="description">The action &quot;microsoft.graph.rightb&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Rightb", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Rightb : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.rightb&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.rightb&quot; action.")]
        public System.Object text { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;numBytes&quot; parameter, which is accepted by the &quot;microsoft.graph.rightb&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;numBytes&quot; parameter, which is accepted by the &quot;microsoft.graph.rightb&quot; action.")]
        public System.Object numBytes { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/rightb";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/roman</para>
    ///     <para type="description">The action &quot;microsoft.graph.roman&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Roman", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Roman : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.roman&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.roman&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;form&quot; parameter, which is accepted by the &quot;microsoft.graph.roman&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;form&quot; parameter, which is accepted by the &quot;microsoft.graph.roman&quot; action.")]
        public System.Object form { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/roman";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/round</para>
    ///     <para type="description">The action &quot;microsoft.graph.round&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Round", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Round : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.round&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.round&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;numDigits&quot; parameter, which is accepted by the &quot;microsoft.graph.round&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;numDigits&quot; parameter, which is accepted by the &quot;microsoft.graph.round&quot; action.")]
        public System.Object numDigits { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/round";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/roundDown</para>
    ///     <para type="description">The action &quot;microsoft.graph.roundDown&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_RoundDown", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_RoundDown : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.roundDown&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.roundDown&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;numDigits&quot; parameter, which is accepted by the &quot;microsoft.graph.roundDown&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;numDigits&quot; parameter, which is accepted by the &quot;microsoft.graph.roundDown&quot; action.")]
        public System.Object numDigits { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/roundDown";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/roundUp</para>
    ///     <para type="description">The action &quot;microsoft.graph.roundUp&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_RoundUp", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_RoundUp : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.roundUp&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.roundUp&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;numDigits&quot; parameter, which is accepted by the &quot;microsoft.graph.roundUp&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;numDigits&quot; parameter, which is accepted by the &quot;microsoft.graph.roundUp&quot; action.")]
        public System.Object numDigits { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/roundUp";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/rows</para>
    ///     <para type="description">The action &quot;microsoft.graph.rows&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Rows", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Rows : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;array&quot; parameter, which is accepted by the &quot;microsoft.graph.rows&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;array&quot; parameter, which is accepted by the &quot;microsoft.graph.rows&quot; action.")]
        public System.Object array { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/rows";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/rri</para>
    ///     <para type="description">The action &quot;microsoft.graph.rri&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Rri", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Rri : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;nper&quot; parameter, which is accepted by the &quot;microsoft.graph.rri&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;nper&quot; parameter, which is accepted by the &quot;microsoft.graph.rri&quot; action.")]
        public System.Object nper { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pv&quot; parameter, which is accepted by the &quot;microsoft.graph.rri&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;pv&quot; parameter, which is accepted by the &quot;microsoft.graph.rri&quot; action.")]
        public System.Object pv { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;fv&quot; parameter, which is accepted by the &quot;microsoft.graph.rri&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;fv&quot; parameter, which is accepted by the &quot;microsoft.graph.rri&quot; action.")]
        public System.Object fv { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/rri";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/sec</para>
    ///     <para type="description">The action &quot;microsoft.graph.sec&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Sec", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Sec : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.sec&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.sec&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/sec";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/sech</para>
    ///     <para type="description">The action &quot;microsoft.graph.sech&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Sech", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Sech : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.sech&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.sech&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/sech";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/second</para>
    ///     <para type="description">The action &quot;microsoft.graph.second&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Second", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Second : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;serialNumber&quot; parameter, which is accepted by the &quot;microsoft.graph.second&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;serialNumber&quot; parameter, which is accepted by the &quot;microsoft.graph.second&quot; action.")]
        public System.Object serialNumber { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/second";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/seriesSum</para>
    ///     <para type="description">The action &quot;microsoft.graph.seriesSum&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_SeriesSum", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_SeriesSum : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.seriesSum&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.seriesSum&quot; action.")]
        public System.Object x { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;n&quot; parameter, which is accepted by the &quot;microsoft.graph.seriesSum&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;n&quot; parameter, which is accepted by the &quot;microsoft.graph.seriesSum&quot; action.")]
        public System.Object n { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;m&quot; parameter, which is accepted by the &quot;microsoft.graph.seriesSum&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;m&quot; parameter, which is accepted by the &quot;microsoft.graph.seriesSum&quot; action.")]
        public System.Object m { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;coefficients&quot; parameter, which is accepted by the &quot;microsoft.graph.seriesSum&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;coefficients&quot; parameter, which is accepted by the &quot;microsoft.graph.seriesSum&quot; action.")]
        public System.Object coefficients { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/seriesSum";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/sheet</para>
    ///     <para type="description">The action &quot;microsoft.graph.sheet&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Sheet", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Sheet : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;value&quot; parameter, which is accepted by the &quot;microsoft.graph.sheet&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;value&quot; parameter, which is accepted by the &quot;microsoft.graph.sheet&quot; action.")]
        public System.Object value { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/sheet";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/sheets</para>
    ///     <para type="description">The action &quot;microsoft.graph.sheets&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Sheets", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Sheets : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;reference&quot; parameter, which is accepted by the &quot;microsoft.graph.sheets&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;reference&quot; parameter, which is accepted by the &quot;microsoft.graph.sheets&quot; action.")]
        public System.Object reference { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/sheets";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/sign</para>
    ///     <para type="description">The action &quot;microsoft.graph.sign&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Sign", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Sign : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.sign&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.sign&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/sign";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/sin</para>
    ///     <para type="description">The action &quot;microsoft.graph.sin&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Sin", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Sin : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.sin&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.sin&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/sin";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/sinh</para>
    ///     <para type="description">The action &quot;microsoft.graph.sinh&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Sinh", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Sinh : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.sinh&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.sinh&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/sinh";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/skew</para>
    ///     <para type="description">The action &quot;microsoft.graph.skew&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Skew", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Skew : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.skew&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.skew&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/skew";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/skew_p</para>
    ///     <para type="description">The action &quot;microsoft.graph.skew_p&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_SkewP", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_SkewP : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.skew_p&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.skew_p&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/skew_p";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/sln</para>
    ///     <para type="description">The action &quot;microsoft.graph.sln&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Sln", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Sln : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;cost&quot; parameter, which is accepted by the &quot;microsoft.graph.sln&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;cost&quot; parameter, which is accepted by the &quot;microsoft.graph.sln&quot; action.")]
        public System.Object cost { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;salvage&quot; parameter, which is accepted by the &quot;microsoft.graph.sln&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;salvage&quot; parameter, which is accepted by the &quot;microsoft.graph.sln&quot; action.")]
        public System.Object salvage { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;life&quot; parameter, which is accepted by the &quot;microsoft.graph.sln&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;life&quot; parameter, which is accepted by the &quot;microsoft.graph.sln&quot; action.")]
        public System.Object life { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/sln";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/small</para>
    ///     <para type="description">The action &quot;microsoft.graph.small&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Small", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Small : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;array&quot; parameter, which is accepted by the &quot;microsoft.graph.small&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;array&quot; parameter, which is accepted by the &quot;microsoft.graph.small&quot; action.")]
        public System.Object array { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;k&quot; parameter, which is accepted by the &quot;microsoft.graph.small&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;k&quot; parameter, which is accepted by the &quot;microsoft.graph.small&quot; action.")]
        public System.Object k { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/small";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/sqrt</para>
    ///     <para type="description">The action &quot;microsoft.graph.sqrt&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Sqrt", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Sqrt : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.sqrt&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.sqrt&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/sqrt";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/sqrtPi</para>
    ///     <para type="description">The action &quot;microsoft.graph.sqrtPi&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_SqrtPi", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_SqrtPi : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.sqrtPi&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.sqrtPi&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/sqrtPi";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/stDevA</para>
    ///     <para type="description">The action &quot;microsoft.graph.stDevA&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_StDevA", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_StDevA : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.stDevA&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.stDevA&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/stDevA";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/stDevPA</para>
    ///     <para type="description">The action &quot;microsoft.graph.stDevPA&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_StDevPA", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_StDevPA : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.stDevPA&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.stDevPA&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/stDevPA";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/stDev_P</para>
    ///     <para type="description">The action &quot;microsoft.graph.stDev_P&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_StDevP", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_StDevP : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.stDev_P&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.stDev_P&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/stDev_P";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/stDev_S</para>
    ///     <para type="description">The action &quot;microsoft.graph.stDev_S&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_StDevS", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_StDevS : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.stDev_S&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.stDev_S&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/stDev_S";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/standardize</para>
    ///     <para type="description">The action &quot;microsoft.graph.standardize&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Standardize", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Standardize : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.standardize&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.standardize&quot; action.")]
        public System.Object x { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;mean&quot; parameter, which is accepted by the &quot;microsoft.graph.standardize&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;mean&quot; parameter, which is accepted by the &quot;microsoft.graph.standardize&quot; action.")]
        public System.Object mean { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;standardDev&quot; parameter, which is accepted by the &quot;microsoft.graph.standardize&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;standardDev&quot; parameter, which is accepted by the &quot;microsoft.graph.standardize&quot; action.")]
        public System.Object standardDev { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/standardize";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/substitute</para>
    ///     <para type="description">The action &quot;microsoft.graph.substitute&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Substitute", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Substitute : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.substitute&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.substitute&quot; action.")]
        public System.Object text { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;oldText&quot; parameter, which is accepted by the &quot;microsoft.graph.substitute&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;oldText&quot; parameter, which is accepted by the &quot;microsoft.graph.substitute&quot; action.")]
        public System.Object oldText { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;newText&quot; parameter, which is accepted by the &quot;microsoft.graph.substitute&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;newText&quot; parameter, which is accepted by the &quot;microsoft.graph.substitute&quot; action.")]
        public System.Object newText { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;instanceNum&quot; parameter, which is accepted by the &quot;microsoft.graph.substitute&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;instanceNum&quot; parameter, which is accepted by the &quot;microsoft.graph.substitute&quot; action.")]
        public System.Object instanceNum { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/substitute";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/subtotal</para>
    ///     <para type="description">The action &quot;microsoft.graph.subtotal&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Subtotal", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Subtotal : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;functionNum&quot; parameter, which is accepted by the &quot;microsoft.graph.subtotal&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;functionNum&quot; parameter, which is accepted by the &quot;microsoft.graph.subtotal&quot; action.")]
        public System.Object functionNum { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.subtotal&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.subtotal&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/subtotal";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/sum</para>
    ///     <para type="description">The action &quot;microsoft.graph.sum&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Sum", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Sum : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.sum&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.sum&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/sum";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/sumIf</para>
    ///     <para type="description">The action &quot;microsoft.graph.sumIf&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_SumIf", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_SumIf : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;range&quot; parameter, which is accepted by the &quot;microsoft.graph.sumIf&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;range&quot; parameter, which is accepted by the &quot;microsoft.graph.sumIf&quot; action.")]
        public System.Object range { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;criteria&quot; parameter, which is accepted by the &quot;microsoft.graph.sumIf&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;criteria&quot; parameter, which is accepted by the &quot;microsoft.graph.sumIf&quot; action.")]
        public System.Object criteria { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sumRange&quot; parameter, which is accepted by the &quot;microsoft.graph.sumIf&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;sumRange&quot; parameter, which is accepted by the &quot;microsoft.graph.sumIf&quot; action.")]
        public System.Object sumRange { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/sumIf";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/sumIfs</para>
    ///     <para type="description">The action &quot;microsoft.graph.sumIfs&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_SumIfs", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_SumIfs : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;sumRange&quot; parameter, which is accepted by the &quot;microsoft.graph.sumIfs&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;sumRange&quot; parameter, which is accepted by the &quot;microsoft.graph.sumIfs&quot; action.")]
        public System.Object sumRange { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.sumIfs&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.sumIfs&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/sumIfs";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/sumSq</para>
    ///     <para type="description">The action &quot;microsoft.graph.sumSq&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_SumSq", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_SumSq : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.sumSq&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.sumSq&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/sumSq";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/syd</para>
    ///     <para type="description">The action &quot;microsoft.graph.syd&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Syd", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Syd : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;cost&quot; parameter, which is accepted by the &quot;microsoft.graph.syd&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;cost&quot; parameter, which is accepted by the &quot;microsoft.graph.syd&quot; action.")]
        public System.Object cost { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;salvage&quot; parameter, which is accepted by the &quot;microsoft.graph.syd&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;salvage&quot; parameter, which is accepted by the &quot;microsoft.graph.syd&quot; action.")]
        public System.Object salvage { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;life&quot; parameter, which is accepted by the &quot;microsoft.graph.syd&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;life&quot; parameter, which is accepted by the &quot;microsoft.graph.syd&quot; action.")]
        public System.Object life { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;per&quot; parameter, which is accepted by the &quot;microsoft.graph.syd&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;per&quot; parameter, which is accepted by the &quot;microsoft.graph.syd&quot; action.")]
        public System.Object per { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/syd";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/t</para>
    ///     <para type="description">The action &quot;microsoft.graph.t&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_T", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_T : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;value&quot; parameter, which is accepted by the &quot;microsoft.graph.t&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;value&quot; parameter, which is accepted by the &quot;microsoft.graph.t&quot; action.")]
        public System.Object value { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/t";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/tbillEq</para>
    ///     <para type="description">The action &quot;microsoft.graph.tbillEq&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_TbillEq", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_TbillEq : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.tbillEq&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.tbillEq&quot; action.")]
        public System.Object settlement { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.tbillEq&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.tbillEq&quot; action.")]
        public System.Object maturity { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;discount&quot; parameter, which is accepted by the &quot;microsoft.graph.tbillEq&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;discount&quot; parameter, which is accepted by the &quot;microsoft.graph.tbillEq&quot; action.")]
        public System.Object discount { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/tbillEq";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/tbillPrice</para>
    ///     <para type="description">The action &quot;microsoft.graph.tbillPrice&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_TbillPrice", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_TbillPrice : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.tbillPrice&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.tbillPrice&quot; action.")]
        public System.Object settlement { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.tbillPrice&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.tbillPrice&quot; action.")]
        public System.Object maturity { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;discount&quot; parameter, which is accepted by the &quot;microsoft.graph.tbillPrice&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;discount&quot; parameter, which is accepted by the &quot;microsoft.graph.tbillPrice&quot; action.")]
        public System.Object discount { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/tbillPrice";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/tbillYield</para>
    ///     <para type="description">The action &quot;microsoft.graph.tbillYield&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_TbillYield", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_TbillYield : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.tbillYield&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.tbillYield&quot; action.")]
        public System.Object settlement { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.tbillYield&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.tbillYield&quot; action.")]
        public System.Object maturity { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pr&quot; parameter, which is accepted by the &quot;microsoft.graph.tbillYield&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;pr&quot; parameter, which is accepted by the &quot;microsoft.graph.tbillYield&quot; action.")]
        public System.Object pr { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/tbillYield";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/t_Dist</para>
    ///     <para type="description">The action &quot;microsoft.graph.t_Dist&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_TDist", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_TDist : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.t_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.t_Dist&quot; action.")]
        public System.Object x { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;degFreedom&quot; parameter, which is accepted by the &quot;microsoft.graph.t_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;degFreedom&quot; parameter, which is accepted by the &quot;microsoft.graph.t_Dist&quot; action.")]
        public System.Object degFreedom { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;cumulative&quot; parameter, which is accepted by the &quot;microsoft.graph.t_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;cumulative&quot; parameter, which is accepted by the &quot;microsoft.graph.t_Dist&quot; action.")]
        public System.Object cumulative { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/t_Dist";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/t_Dist_2T</para>
    ///     <para type="description">The action &quot;microsoft.graph.t_Dist_2T&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_TDist2T", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_TDist2T : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.t_Dist_2T&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.t_Dist_2T&quot; action.")]
        public System.Object x { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;degFreedom&quot; parameter, which is accepted by the &quot;microsoft.graph.t_Dist_2T&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;degFreedom&quot; parameter, which is accepted by the &quot;microsoft.graph.t_Dist_2T&quot; action.")]
        public System.Object degFreedom { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/t_Dist_2T";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/t_Dist_RT</para>
    ///     <para type="description">The action &quot;microsoft.graph.t_Dist_RT&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_TDistRT", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_TDistRT : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.t_Dist_RT&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.t_Dist_RT&quot; action.")]
        public System.Object x { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;degFreedom&quot; parameter, which is accepted by the &quot;microsoft.graph.t_Dist_RT&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;degFreedom&quot; parameter, which is accepted by the &quot;microsoft.graph.t_Dist_RT&quot; action.")]
        public System.Object degFreedom { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/t_Dist_RT";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/t_Inv</para>
    ///     <para type="description">The action &quot;microsoft.graph.t_Inv&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_TInv", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_TInv : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;probability&quot; parameter, which is accepted by the &quot;microsoft.graph.t_Inv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;probability&quot; parameter, which is accepted by the &quot;microsoft.graph.t_Inv&quot; action.")]
        public System.Object probability { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;degFreedom&quot; parameter, which is accepted by the &quot;microsoft.graph.t_Inv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;degFreedom&quot; parameter, which is accepted by the &quot;microsoft.graph.t_Inv&quot; action.")]
        public System.Object degFreedom { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/t_Inv";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/t_Inv_2T</para>
    ///     <para type="description">The action &quot;microsoft.graph.t_Inv_2T&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_TInv2T", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_TInv2T : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;probability&quot; parameter, which is accepted by the &quot;microsoft.graph.t_Inv_2T&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;probability&quot; parameter, which is accepted by the &quot;microsoft.graph.t_Inv_2T&quot; action.")]
        public System.Object probability { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;degFreedom&quot; parameter, which is accepted by the &quot;microsoft.graph.t_Inv_2T&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;degFreedom&quot; parameter, which is accepted by the &quot;microsoft.graph.t_Inv_2T&quot; action.")]
        public System.Object degFreedom { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/t_Inv_2T";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/tan</para>
    ///     <para type="description">The action &quot;microsoft.graph.tan&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Tan", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Tan : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.tan&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.tan&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/tan";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/tanh</para>
    ///     <para type="description">The action &quot;microsoft.graph.tanh&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Tanh", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Tanh : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.tanh&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.tanh&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/tanh";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/text</para>
    ///     <para type="description">The action &quot;microsoft.graph.text&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Text", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Text : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;value&quot; parameter, which is accepted by the &quot;microsoft.graph.text&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;value&quot; parameter, which is accepted by the &quot;microsoft.graph.text&quot; action.")]
        public System.Object value { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;formatText&quot; parameter, which is accepted by the &quot;microsoft.graph.text&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;formatText&quot; parameter, which is accepted by the &quot;microsoft.graph.text&quot; action.")]
        public System.Object formatText { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/text";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/time</para>
    ///     <para type="description">The action &quot;microsoft.graph.time&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Time", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Time : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;hour&quot; parameter, which is accepted by the &quot;microsoft.graph.time&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;hour&quot; parameter, which is accepted by the &quot;microsoft.graph.time&quot; action.")]
        public System.Object hour { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;minute&quot; parameter, which is accepted by the &quot;microsoft.graph.time&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;minute&quot; parameter, which is accepted by the &quot;microsoft.graph.time&quot; action.")]
        public System.Object minute { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;second&quot; parameter, which is accepted by the &quot;microsoft.graph.time&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;second&quot; parameter, which is accepted by the &quot;microsoft.graph.time&quot; action.")]
        public System.Object second { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/time";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/timevalue</para>
    ///     <para type="description">The action &quot;microsoft.graph.timevalue&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Timevalue", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Timevalue : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;timeText&quot; parameter, which is accepted by the &quot;microsoft.graph.timevalue&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;timeText&quot; parameter, which is accepted by the &quot;microsoft.graph.timevalue&quot; action.")]
        public System.Object timeText { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/timevalue";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/today</para>
    ///     <para type="description">The action &quot;microsoft.graph.today&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Today", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Today : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/today";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/trim</para>
    ///     <para type="description">The action &quot;microsoft.graph.trim&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Trim", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Trim : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.trim&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.trim&quot; action.")]
        public System.Object text { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/trim";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/trimMean</para>
    ///     <para type="description">The action &quot;microsoft.graph.trimMean&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_TrimMean", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_TrimMean : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;array&quot; parameter, which is accepted by the &quot;microsoft.graph.trimMean&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;array&quot; parameter, which is accepted by the &quot;microsoft.graph.trimMean&quot; action.")]
        public System.Object array { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;percent&quot; parameter, which is accepted by the &quot;microsoft.graph.trimMean&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;percent&quot; parameter, which is accepted by the &quot;microsoft.graph.trimMean&quot; action.")]
        public System.Object percent { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/trimMean";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/true</para>
    ///     <para type="description">The action &quot;microsoft.graph.true&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_True", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_True : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/true";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/trunc</para>
    ///     <para type="description">The action &quot;microsoft.graph.trunc&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Trunc", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Trunc : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.trunc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.trunc&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;numDigits&quot; parameter, which is accepted by the &quot;microsoft.graph.trunc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;numDigits&quot; parameter, which is accepted by the &quot;microsoft.graph.trunc&quot; action.")]
        public System.Object numDigits { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/trunc";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/type</para>
    ///     <para type="description">The action &quot;microsoft.graph.type&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Type", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Type : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;value&quot; parameter, which is accepted by the &quot;microsoft.graph.type&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;value&quot; parameter, which is accepted by the &quot;microsoft.graph.type&quot; action.")]
        public System.Object value { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/type";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/usdollar</para>
    ///     <para type="description">The action &quot;microsoft.graph.usdollar&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Usdollar", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Usdollar : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.usdollar&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.usdollar&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;decimals&quot; parameter, which is accepted by the &quot;microsoft.graph.usdollar&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;decimals&quot; parameter, which is accepted by the &quot;microsoft.graph.usdollar&quot; action.")]
        public System.Object decimals { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/usdollar";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/unichar</para>
    ///     <para type="description">The action &quot;microsoft.graph.unichar&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Unichar", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Unichar : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.unichar&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;number&quot; parameter, which is accepted by the &quot;microsoft.graph.unichar&quot; action.")]
        public System.Object number { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/unichar";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/unicode</para>
    ///     <para type="description">The action &quot;microsoft.graph.unicode&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Unicode", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Unicode : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.unicode&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.unicode&quot; action.")]
        public System.Object text { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/unicode";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/upper</para>
    ///     <para type="description">The action &quot;microsoft.graph.upper&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Upper", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Upper : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.upper&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.upper&quot; action.")]
        public System.Object text { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/upper";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/vlookup</para>
    ///     <para type="description">The action &quot;microsoft.graph.vlookup&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Vlookup", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Vlookup : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;lookupValue&quot; parameter, which is accepted by the &quot;microsoft.graph.vlookup&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;lookupValue&quot; parameter, which is accepted by the &quot;microsoft.graph.vlookup&quot; action.")]
        public System.Object lookupValue { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;tableArray&quot; parameter, which is accepted by the &quot;microsoft.graph.vlookup&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;tableArray&quot; parameter, which is accepted by the &quot;microsoft.graph.vlookup&quot; action.")]
        public System.Object tableArray { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;colIndexNum&quot; parameter, which is accepted by the &quot;microsoft.graph.vlookup&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;colIndexNum&quot; parameter, which is accepted by the &quot;microsoft.graph.vlookup&quot; action.")]
        public System.Object colIndexNum { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rangeLookup&quot; parameter, which is accepted by the &quot;microsoft.graph.vlookup&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;rangeLookup&quot; parameter, which is accepted by the &quot;microsoft.graph.vlookup&quot; action.")]
        public System.Object rangeLookup { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/vlookup";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/value</para>
    ///     <para type="description">The action &quot;microsoft.graph.value&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Value", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Value : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.value&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;text&quot; parameter, which is accepted by the &quot;microsoft.graph.value&quot; action.")]
        public System.Object text { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/value";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/varA</para>
    ///     <para type="description">The action &quot;microsoft.graph.varA&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_VarA", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_VarA : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.varA&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.varA&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/varA";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/varPA</para>
    ///     <para type="description">The action &quot;microsoft.graph.varPA&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_VarPA", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_VarPA : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.varPA&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.varPA&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/varPA";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/var_P</para>
    ///     <para type="description">The action &quot;microsoft.graph.var_P&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_VarP", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_VarP : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.var_P&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.var_P&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/var_P";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/var_S</para>
    ///     <para type="description">The action &quot;microsoft.graph.var_S&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_VarS", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_VarS : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.var_S&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.var_S&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/var_S";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/vdb</para>
    ///     <para type="description">The action &quot;microsoft.graph.vdb&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Vdb", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Vdb : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;cost&quot; parameter, which is accepted by the &quot;microsoft.graph.vdb&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;cost&quot; parameter, which is accepted by the &quot;microsoft.graph.vdb&quot; action.")]
        public System.Object cost { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;salvage&quot; parameter, which is accepted by the &quot;microsoft.graph.vdb&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;salvage&quot; parameter, which is accepted by the &quot;microsoft.graph.vdb&quot; action.")]
        public System.Object salvage { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;life&quot; parameter, which is accepted by the &quot;microsoft.graph.vdb&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;life&quot; parameter, which is accepted by the &quot;microsoft.graph.vdb&quot; action.")]
        public System.Object life { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;startPeriod&quot; parameter, which is accepted by the &quot;microsoft.graph.vdb&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;startPeriod&quot; parameter, which is accepted by the &quot;microsoft.graph.vdb&quot; action.")]
        public System.Object startPeriod { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;endPeriod&quot; parameter, which is accepted by the &quot;microsoft.graph.vdb&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;endPeriod&quot; parameter, which is accepted by the &quot;microsoft.graph.vdb&quot; action.")]
        public System.Object endPeriod { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;factor&quot; parameter, which is accepted by the &quot;microsoft.graph.vdb&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;factor&quot; parameter, which is accepted by the &quot;microsoft.graph.vdb&quot; action.")]
        public System.Object factor { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;noSwitch&quot; parameter, which is accepted by the &quot;microsoft.graph.vdb&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;noSwitch&quot; parameter, which is accepted by the &quot;microsoft.graph.vdb&quot; action.")]
        public System.Object noSwitch { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/vdb";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/weekNum</para>
    ///     <para type="description">The action &quot;microsoft.graph.weekNum&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_WeekNum", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_WeekNum : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;serialNumber&quot; parameter, which is accepted by the &quot;microsoft.graph.weekNum&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;serialNumber&quot; parameter, which is accepted by the &quot;microsoft.graph.weekNum&quot; action.")]
        public System.Object serialNumber { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;returnType&quot; parameter, which is accepted by the &quot;microsoft.graph.weekNum&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;returnType&quot; parameter, which is accepted by the &quot;microsoft.graph.weekNum&quot; action.")]
        public System.Object returnType { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/weekNum";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/weekday</para>
    ///     <para type="description">The action &quot;microsoft.graph.weekday&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Weekday", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Weekday : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;serialNumber&quot; parameter, which is accepted by the &quot;microsoft.graph.weekday&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;serialNumber&quot; parameter, which is accepted by the &quot;microsoft.graph.weekday&quot; action.")]
        public System.Object serialNumber { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;returnType&quot; parameter, which is accepted by the &quot;microsoft.graph.weekday&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;returnType&quot; parameter, which is accepted by the &quot;microsoft.graph.weekday&quot; action.")]
        public System.Object returnType { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/weekday";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/weibull_Dist</para>
    ///     <para type="description">The action &quot;microsoft.graph.weibull_Dist&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_WeibullDist", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_WeibullDist : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.weibull_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.weibull_Dist&quot; action.")]
        public System.Object x { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;alpha&quot; parameter, which is accepted by the &quot;microsoft.graph.weibull_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;alpha&quot; parameter, which is accepted by the &quot;microsoft.graph.weibull_Dist&quot; action.")]
        public System.Object alpha { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;beta&quot; parameter, which is accepted by the &quot;microsoft.graph.weibull_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;beta&quot; parameter, which is accepted by the &quot;microsoft.graph.weibull_Dist&quot; action.")]
        public System.Object beta { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;cumulative&quot; parameter, which is accepted by the &quot;microsoft.graph.weibull_Dist&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;cumulative&quot; parameter, which is accepted by the &quot;microsoft.graph.weibull_Dist&quot; action.")]
        public System.Object cumulative { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/weibull_Dist";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/workDay</para>
    ///     <para type="description">The action &quot;microsoft.graph.workDay&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_WorkDay", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_WorkDay : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;startDate&quot; parameter, which is accepted by the &quot;microsoft.graph.workDay&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;startDate&quot; parameter, which is accepted by the &quot;microsoft.graph.workDay&quot; action.")]
        public System.Object startDate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;days&quot; parameter, which is accepted by the &quot;microsoft.graph.workDay&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;days&quot; parameter, which is accepted by the &quot;microsoft.graph.workDay&quot; action.")]
        public System.Object days { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;holidays&quot; parameter, which is accepted by the &quot;microsoft.graph.workDay&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;holidays&quot; parameter, which is accepted by the &quot;microsoft.graph.workDay&quot; action.")]
        public System.Object holidays { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/workDay";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/workDay_Intl</para>
    ///     <para type="description">The action &quot;microsoft.graph.workDay_Intl&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_WorkDayIntl", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_WorkDayIntl : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;startDate&quot; parameter, which is accepted by the &quot;microsoft.graph.workDay_Intl&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;startDate&quot; parameter, which is accepted by the &quot;microsoft.graph.workDay_Intl&quot; action.")]
        public System.Object startDate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;days&quot; parameter, which is accepted by the &quot;microsoft.graph.workDay_Intl&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;days&quot; parameter, which is accepted by the &quot;microsoft.graph.workDay_Intl&quot; action.")]
        public System.Object days { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;weekend&quot; parameter, which is accepted by the &quot;microsoft.graph.workDay_Intl&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;weekend&quot; parameter, which is accepted by the &quot;microsoft.graph.workDay_Intl&quot; action.")]
        public System.Object weekend { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;holidays&quot; parameter, which is accepted by the &quot;microsoft.graph.workDay_Intl&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;holidays&quot; parameter, which is accepted by the &quot;microsoft.graph.workDay_Intl&quot; action.")]
        public System.Object holidays { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/workDay_Intl";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/xirr</para>
    ///     <para type="description">The action &quot;microsoft.graph.xirr&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Xirr", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Xirr : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.xirr&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.xirr&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;dates&quot; parameter, which is accepted by the &quot;microsoft.graph.xirr&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;dates&quot; parameter, which is accepted by the &quot;microsoft.graph.xirr&quot; action.")]
        public System.Object dates { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;guess&quot; parameter, which is accepted by the &quot;microsoft.graph.xirr&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;guess&quot; parameter, which is accepted by the &quot;microsoft.graph.xirr&quot; action.")]
        public System.Object guess { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/xirr";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/xnpv</para>
    ///     <para type="description">The action &quot;microsoft.graph.xnpv&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Xnpv", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Xnpv : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.xnpv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.xnpv&quot; action.")]
        public System.Object rate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.xnpv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.xnpv&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;dates&quot; parameter, which is accepted by the &quot;microsoft.graph.xnpv&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;dates&quot; parameter, which is accepted by the &quot;microsoft.graph.xnpv&quot; action.")]
        public System.Object dates { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/xnpv";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/xor</para>
    ///     <para type="description">The action &quot;microsoft.graph.xor&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Xor", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Xor : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.xor&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;values&quot; parameter, which is accepted by the &quot;microsoft.graph.xor&quot; action.")]
        public System.Object values { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/xor";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/year</para>
    ///     <para type="description">The action &quot;microsoft.graph.year&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Year", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Year : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;serialNumber&quot; parameter, which is accepted by the &quot;microsoft.graph.year&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;serialNumber&quot; parameter, which is accepted by the &quot;microsoft.graph.year&quot; action.")]
        public System.Object serialNumber { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/year";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/yearFrac</para>
    ///     <para type="description">The action &quot;microsoft.graph.yearFrac&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_YearFrac", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_YearFrac : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;startDate&quot; parameter, which is accepted by the &quot;microsoft.graph.yearFrac&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;startDate&quot; parameter, which is accepted by the &quot;microsoft.graph.yearFrac&quot; action.")]
        public System.Object startDate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;endDate&quot; parameter, which is accepted by the &quot;microsoft.graph.yearFrac&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;endDate&quot; parameter, which is accepted by the &quot;microsoft.graph.yearFrac&quot; action.")]
        public System.Object endDate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.yearFrac&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.yearFrac&quot; action.")]
        public System.Object basis { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/yearFrac";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/yield</para>
    ///     <para type="description">The action &quot;microsoft.graph.yield&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_Yield", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_Yield : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.yield&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.yield&quot; action.")]
        public System.Object settlement { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.yield&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.yield&quot; action.")]
        public System.Object maturity { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.yield&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.yield&quot; action.")]
        public System.Object rate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pr&quot; parameter, which is accepted by the &quot;microsoft.graph.yield&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;pr&quot; parameter, which is accepted by the &quot;microsoft.graph.yield&quot; action.")]
        public System.Object pr { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;redemption&quot; parameter, which is accepted by the &quot;microsoft.graph.yield&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;redemption&quot; parameter, which is accepted by the &quot;microsoft.graph.yield&quot; action.")]
        public System.Object redemption { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;frequency&quot; parameter, which is accepted by the &quot;microsoft.graph.yield&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;frequency&quot; parameter, which is accepted by the &quot;microsoft.graph.yield&quot; action.")]
        public System.Object frequency { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.yield&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.yield&quot; action.")]
        public System.Object basis { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/yield";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/yieldDisc</para>
    ///     <para type="description">The action &quot;microsoft.graph.yieldDisc&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_YieldDisc", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_YieldDisc : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.yieldDisc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.yieldDisc&quot; action.")]
        public System.Object settlement { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.yieldDisc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.yieldDisc&quot; action.")]
        public System.Object maturity { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pr&quot; parameter, which is accepted by the &quot;microsoft.graph.yieldDisc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;pr&quot; parameter, which is accepted by the &quot;microsoft.graph.yieldDisc&quot; action.")]
        public System.Object pr { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;redemption&quot; parameter, which is accepted by the &quot;microsoft.graph.yieldDisc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;redemption&quot; parameter, which is accepted by the &quot;microsoft.graph.yieldDisc&quot; action.")]
        public System.Object redemption { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.yieldDisc&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.yieldDisc&quot; action.")]
        public System.Object basis { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/yieldDisc";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/yieldMat</para>
    ///     <para type="description">The action &quot;microsoft.graph.yieldMat&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_YieldMat", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_YieldMat : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.yieldMat&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;settlement&quot; parameter, which is accepted by the &quot;microsoft.graph.yieldMat&quot; action.")]
        public System.Object settlement { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.yieldMat&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;maturity&quot; parameter, which is accepted by the &quot;microsoft.graph.yieldMat&quot; action.")]
        public System.Object maturity { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;issue&quot; parameter, which is accepted by the &quot;microsoft.graph.yieldMat&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;issue&quot; parameter, which is accepted by the &quot;microsoft.graph.yieldMat&quot; action.")]
        public System.Object issue { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.yieldMat&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;rate&quot; parameter, which is accepted by the &quot;microsoft.graph.yieldMat&quot; action.")]
        public System.Object rate { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;pr&quot; parameter, which is accepted by the &quot;microsoft.graph.yieldMat&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;pr&quot; parameter, which is accepted by the &quot;microsoft.graph.yieldMat&quot; action.")]
        public System.Object pr { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.yieldMat&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;basis&quot; parameter, which is accepted by the &quot;microsoft.graph.yieldMat&quot; action.")]
        public System.Object basis { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/yieldMat";
        }
    }

    /// <summary>
    ///     <para type="description">POST ~/me/drive/special/{specialId}/workbook/functions/z_Test</para>
    ///     <para type="description">The action &quot;microsoft.graph.z_Test&quot;, which exists on the type &quot;microsoft.graph.workbookFunctions&quot;.</para>
    ///     <para type="description">This action returns a &quot;microsoft.graph.workbookFunctionResult&quot; object.</para>
    /// </summary>
    [Cmdlet("Invoke", "Me_Drive_Special_Workbook_Functions_ZTest", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.workbookFunctions")]
    public class Invoke_Me_Drive_Special_Workbook_Functions_ZTest : ActionCmdlet
    {
        /// <summary>
        ///     <para type="description">The &quot;array&quot; parameter, which is accepted by the &quot;microsoft.graph.z_Test&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;array&quot; parameter, which is accepted by the &quot;microsoft.graph.z_Test&quot; action.")]
        public System.Object array { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.z_Test&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;x&quot; parameter, which is accepted by the &quot;microsoft.graph.z_Test&quot; action.")]
        public System.Object x { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;sigma&quot; parameter, which is accepted by the &quot;microsoft.graph.z_Test&quot; action.</para>
        /// </summary>
        [ODataType("microsoft.graph.Json")]
        [Selectable]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;sigma&quot; parameter, which is accepted by the &quot;microsoft.graph.z_Test&quot; action.")]
        public System.Object sigma { get; set; }

        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.</para>
        /// </summary>
        [Selectable]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.driveItem&quot; object in the &quot;special&quot; collection.")]
        public System.String specialId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"me/drive/special/{specialId}/workbook/functions/z_Test";
        }
    }
}