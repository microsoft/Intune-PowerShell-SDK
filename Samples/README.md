# Table of Contents
- [Table of Contents](#table-of-contents)
- [Intune-PowerShell-SDK](#intune-powershell-sdk)
- [Getting started](#getting-started)
    - [One-time setup (PowerShell Gallery)](#one-time-setup-powershell-gallery)
    - [One-time setup (GitHub)](#one-time-setup-github)
    - [Before this module is used in your organization](#before-this-module-is-used-in-your-organization)
    - [Each time you use the module](#each-time-you-use-the-module)    
    - [Discovering available commands](#discovering-available-commands)
- [Basics](#basics)
    - [List Objects](#list-objects)
    - [Bulk create objects](#bulk-create-objects)
    - [Filter objects](#filter-objects)
    - [Paging](#paging)
    - [Getting Extended Debug information](#getting-extended-debug-information)
- [Scenario Samples](#scenario-samples)
    - [Set Intune as MDM Authority](#set-intune-as-mdm-authority)
    - [Create group](#create-group)
    - [Publish iOS LOB Application](#publish-ios-lob-application)
    - [Create Compliance Policies and Assign it to an AAD Group](#create-compliance-policies-and-assign-it-to-an-AAD-Group)
        - [Create an iOS Compliance Policy](#create-an-iOS-compliance-policy)
        - [Create Android Compliance Policy](#create-android-compliance-policy)
        - [Create Windows 10 Compliance Policy](#create-windows-10-compliance-policy)
        - [Create MacOS Compliance Policy](#create-macos-compliance-policy)
    - [Create Configuration Policies and Assign it to an AAD Group](#create-configuration-policies-and-assign-it-to-an-AAD-Group)
        - [Create iOS Restriction Policy](#create-ios-restriction-policy)
        - [Create Android Restriction Policy](#create-android-restriction-policy)
    - [Create App Protection Polies and assign it to an AAD Group](#create-app-protection-policies-and-assign-it-to-an-AAD-Group)
        - [iOS App Protection Policy Creation](#ios-app-protection-policy-creation)
        - [Android App Protection Policy Creation](#android-app-protection-policy-creation)
    - [Visualize summary of apps by type](#visualize-summary-of-apps-by-type)

# Intune-PowerShell-SDK
This repository contains the source code for the PowerShell module which provides support for the Intune API through Microsoft Graph.

This project welcomes contributions and suggestions.  Most contributions require you to agree to a Contributor License Agreement (CLA) declaring that you have the right to, and actually do, grant us the rights to use your contribution. For details, visit https://cla.microsoft.com.

When you submit a pull request, a CLA-bot will automatically determine whether you need to provide a CLA and decorate the PR appropriately (e.g., label, comment). Simply follow the instructions provided by the bot. You will only need to do this once across all repos using our CLA.

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.

# Getting started
## One-time setup (PowerShell Gallery)
1. Install the Microsoft.Graph.Intune module from: https://www.powershellgallery.com/packages/Microsoft.Graph.Intune
```PowerShell
Install-Module -Name Microsoft.Graph.Intune
```
## One-time setup (GitHub)
1. Download the module from the [Releases](https://github.com/Microsoft/Intune-PowerShell-SDK/releases) tab in the GitHub repository.
2. The "drop\outputs\build\Release\net471" folder in the zip file contains the module.
    - If you are using Windows, extract the "net471" folder.  **You must have .NET 4.7.1 or higher installed**.    
3. The module manifest is the "Microsoft.Graph.Intune.psd1" file inside this folder.  This is the file you would refer to when importing the module.
4. Import the module:
```PowerShell
Import-Module $sdkDir/Microsoft.Graph.Intune.psd1
```
## Before this module is used in your organization
An admin user must provide consent for this app to be used in their organization.  This can be done with the following command:
```PowerShell
Connect-MSGraph -AdminConsent
```
## Each time you use the module
To authenticate with Microsoft Graph (this is not required when using CloudShell):
```PowerShell
Connect-MSGraph
```
To authenticate with Microsoft Graph using [System.Management.Automation.PSCredential]
```PowerShell
$adminUPN=Read-Host -Prompt "Enter UPN"
$adminPwd=Read-Host -AsSecureString -Prompt "Enter password for $adminUPN"
$creds = New-Object System.Management.Automation.PSCredential ($AdminUPN, $adminPwd)
$connection = Connect-MSGraph -PSCredential $creds
```

## Discovering available commands
Get the full list of available cmdlets:
```PowerShell
Get-Command -Module Microsoft.Graph.Intune
```
Get documentation on a particular cmdlet:
```PowerShell
Get-Help <cmdlet name>
```
Use a UI to see the parameter sets more easily:
```PowerShell
Show-Command <cmdlet name>
```
# Basics
## List Objects
Get all Intune applications:
```PowerShell
Get-IntuneMobileApp
```
## Filter objects
Use -Select to restrict properties to display:
```PowerShell
Get-IntuneMobileApp -Select displayName, publisher
```
Use -Filter to filter results:
```PowerShell
Get-IntuneMobileApp -Select displayName, publisher -Filter "contains(publisher, 'Microsoft')"
```
## Bulk create objects
Bulk create multiple webApp objects (they should appear in the Azure Portal)
```PowerShell
$createdApps = 'https://www.bing.com', 'https://developer.microsoft.com/graph', 'https://portal.azure.com' `
| ForEach-Object { `
    New-IntuneMobileApp `
        -webApp `
        -displayName $_ `
        -publisher 'IT Professional' `
        -appUrl $_ `
        -useManagedBrowser $false `
}
```
Display using GridView
```PowerShell
1..15 | ForEach-Object { `
    New-IntuneMobileApp `
        -webApp `
        -displayName "Bing #$_" `
        -publisher 'Microsoft' `
        -appUrl 'https://www.bing.com' `
        -useManagedBrowser ([bool]($_ % 2)) `
} | Out-GridView
```

Remove all webApps.
```PowerShell
# Remove all web apps
$appsToDelete = Get-IntuneMobileApp -Filter "isof('microsoft.graph.webApp')"
$appsToDelete | Remove-IntuneMobileApp
```

## Paging
Show paging of audit events (run this in a different window).
```PowerShell
# Audit events are accessible from the beta schema
Update-MSGraphEnvironment -SchemaVersion 'beta'
Connect-MSGraph

# Make the call to get audit events
$auditEvents = Invoke-MSGraphRequest -HttpMethod GET -Url 'deviceManagement/auditEvents'
$auditEvents # more than 1000 results, so they are wrapped in an object with the nextLink
$auditEvents.value | measure

# We can get the next page
$auditEvents2 = $auditEvents | Get-MSGraphNextPage
$auditEvents.value | measure # have to unwrap the results again

# Get all pages of audit events
$auditEvents = Invoke-MSGraphRequest -HttpMethod GET -Url 'deviceManagement/auditEvents' | Get-MSGraphAllPages

# Switch back to v1.0
Update-MSGraphEnvironment -SchemaVersion 'v1.0'
```
## Getting Extended Debug information
If for some reason, a cmdlet fails. Use Get-MSGraphInfo to get extended information. 
A sample failure is listed below:
```PowerShell
# Call that failed
Invoke-IntuneDeviceCompliancePolicyAssign : 500 Internal Server Error
{
  "error": {
    "code": "InternalError",
    "message": "{\r\n  \"_version\": 3,\r\n  \"Message\": \"An internal server error has occurred - Operation ID (for customer support): 00000000-0000-0000-0000-000000000000 - Activity ID: a02e4ad2-efdb-4ae0-8b36-7c990a228f21 -
Url: https://fef.msua06.manage.microsoft.com/StatelessDeviceConfigurationFEService/deviceManagement/deviceCompliancePolicies%28%27bc4c48a9-4120-4531-8870-f57767d43da4%27%29/microsoft.management.services.api.assign?api-version=2018
-06-29\",\r\n  \"CustomApiErrorPhrase\": \"\",\r\n  \"RetryAfter\": null,\r\n  \"ErrorSourceService\": \"\",\r\n  \"HttpHeaders\": \"{}\"\r\n}",
    "innerError": {
      "request-id": "a02e4ad2-efdb-4ae0-8b36-7c990a228f21",
      "date": "2018-11-28T21:44:56"
    }
  }
}
At line:1 char:1
+ Invoke-IntuneDeviceCompliancePolicyAssign   -deviceCompliancePolicyId ...
+ ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    + CategoryInfo          : ConnectionError: (@{Request=; Response=}:PSObject) [Invoke-IntuneDe...ncePolicyAssign], HttpRequestException
    + FullyQualifiedErrorId : PowerShellGraphSDK_HttpRequestError,Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets.Invoke_IntuneDeviceCompliancePolicyAssign

# Get Debug information
Get-MSGraphDebugInfo

Request
-------
@{HttpMethod=POST; URL=https://graph.microsoft.com/v1.0/deviceManagement/deviceCompliancePolicies/bc4c48a9-4120-4531-8870-f57767d43da4/assign; Headers=; Content={...

# Look into the Request
(Get-MSGraphDebugInfo).Request

HttpMethod URL                                                                                                                    Headers
---------- ---                                                                                                                    -------
POST       https://graph.microsoft.com/v1.0/deviceManagement/deviceCompliancePolicies/bc4c48a9-4120-4531-8870-f57767d43da4/assign @{Authorization=Bearer eyJ0eXAiOiJKV1QiLCJub25jZSI6IkFRQUJBQUFBQUFDNXVuYTBFVUZnVElGOEVsYXh0V2pUam...

# Look into the Response
(Get-MSGraphDebugInfo).Response

HttpStatusCode HttpStatusPhrase      Headers
-------------- ----------------      -------
           500 Internal Server Error @{Transfer-Encoding=chunked; request-id=a02e4ad2-efdb-4ae0-8b36-7c990a228f21; client-request-id=a02e4ad2-efdb-4ae0-8b36-7c990a228f21; x-ms-ags-diagnostic={"ServerInfo":{"DataCenter":"West Ce...

# Inspect the Response headers
(Get-MSGraphDebugInfo).Response.Headers

Transfer-Encoding         : chunked
request-id                : a02e4ad2-efdb-4ae0-8b36-7c990a228f21
client-request-id         : a02e4ad2-efdb-4ae0-8b36-7c990a228f21
x-ms-ags-diagnostic       : {"ServerInfo":{"DataCenter":"West Central US","Slice":"SliceC","Ring":"1","ScaleUnit":"001","Host":"AGSFE_IN_4","ADSiteName":"WCU"}}
Duration                  : 496.4757
Strict-Transport-Security : max-age=31536000
Cache-Control             : private
Date                      : Wed, 28 Nov 2018 21:44:55 GMT

```

# Scenario Samples
## Set Intune as MDM Authority
```PowerShell
#Checks if Intune already is th MDM Authority

$mdmAuth = (Invoke-MSGraphRequest -Url "https://graph.microsoft.com/v1.0/organization('$OrgId')?`$select=mobiledevicemanagementauthority" -HttpMethod Get -ErrorAction Stop).mobileDeviceManagementAuthority

#If not already set, sets Intune as MDM Authority
if($mdmAuth -notlike "intune")
{
    Write-Progress -Activity "Setter Intune som MDM Authority" -Status "..."
    $OrgID = (Invoke-MSGraphRequest -Url "https://graph.microsoft.com/v1.0/organization" -HttpMethod Get -ErrorAction Stop).value.id
    Invoke-MSGraphRequest -Url "https://graph.microsoft.com/v1.0/organization/$OrgID/setMobileDeviceManagementAuthority" -HttpMethod Post -ErrorAction Stop
}
```
## Create group
```PowerShell
New-AADGroup -description "This is a new group" `
    -displayName "Group01" `
    -mailEnabled $false -mailNickname "Group01" `
    -securityEnabled $true
```

## Upload iOS LOB Application
Load the Apps scenario module
```PowerShell
Import-Module '.\Apps\Microsoft.Graph.Intune.Apps.psd1'
```

Upload the iOS LOB app.
```PowerShell
# Upload an iOS Line-Of-Business app
$appToUpload = New-MobileAppObject `
    -iosLobApp `
    -displayName "Intune test iOS Lob App" `
    -description 'This is a test iOS LOB app' `
    -publisher 'Test Publisher' `
    -bundleId '' `
    -applicableDeviceType (New-IosDeviceTypeObject -iPad $true -iPhoneAndIPod $true) `
    -minimumSupportedOperatingSystem (New-IosMinimumOperatingSystemObject -v9_0 $true) `
    -fileName 'test.ipa' `
    -buildNumber 'v1' -versionNumber 'v1' -expirationDateTime ((Get-Date).AddDays(90))

# Upload the app file with the app information
$uploadedAppFile = New-LobApp -filePath '.\Apps\test.ipa' -mobileApp $appToUpload
```
## Create Compliance Policies and Assign it to an AAD Group
```PowerShell
# Search the AAD Group
$AADGroupId = (Get-Groups -Filter "displayName eq 'Intune POC Users'").id
```

### Create an iOS Compliance Policy
```PowerShell
$iOSCompliancePolicy = New-IntuneDeviceCompliancePolicy `
    -iosCompliancePolicy `
    -displayName "Chicago - iOS Compliance Policy" `
    -passcodeRequired $true `
    -passcodeMinimumLength 6 `
    -passcodeMinutesOfInactivityBeforeLock 15 `
    -securityBlockJailbrokenDevices $true `
    -scheduledActionsForRule `
        (New-DeviceComplianceScheduledActionForRuleObject -ruleName PasswordRequired `
            -scheduledActionConfigurations `
                (New-DeviceComplianceActionItemObject -gracePeriodHours 0 `
                -actionType block `
                -notificationTemplateId "" `
                )`
        )

# Assign the newly created compliance policy to the AAD Group
Invoke-IntuneDeviceCompliancePolicyAssign  -deviceCompliancePolicyId $iOSCompliancePolicy.id `
    -assignments `
        (New-DeviceCompliancePolicyAssignmentObject `
            -target `
                (New-DeviceAndAppManagementAssignmentTargetObject `
                    -groupAssignmentTarget `
                    -groupId "$AADGroupId" `
                ) `
        )
```

### Create Android Compliance Policy
```PowerShell
$androidCompliancePolicy = New-IntuneDeviceCompliancePolicy `
    -androidCompliancePolicy `
    -displayName "Chicago - Android Compliance Policy"  `
    -passwordRequired $true `
    -passwordMinimumLength 6 `
    -securityBlockJailbrokenDevices $true `
    -passwordMinutesOfInactivityBeforeLock 15 `
    -scheduledActionsForRule `
    (New-DeviceComplianceScheduledActionForRuleObject `
        -ruleName PasswordRequired `
        -scheduledActionConfigurations `
        (New-DeviceComplianceActionItemObject `
            -gracePeriodHours 0 `
            -actionType block `
            -notificationTemplateId "" `
        )`
    )

# Assign the newly created compliance policy to the AAD Group
Invoke-IntuneDeviceCompliancePolicyAssign -deviceCompliancePolicyId $androidCompliancePolicy.id `
    -assignments `
    (New-DeviceCompliancePolicyAssignmentObject `
        -target `
        (New-DeviceAndAppManagementAssignmentTargetObject `
            -groupAssignmentTarget `
            -groupId "$AADGroupId" `
        ) `
    )
```

### Create Windows 10 Compliance Policy
```PowerShell
$windows10CompliancePolicy = New-IntuneDeviceCompliancePolicy `
    -windows10CompliancePolicy `
    -displayName "Chicago - Windows 10 Compliance Policy" `
    -osMinimumVersion 10.0.16299 `
    -scheduledActionsForRule `
    (New-DeviceComplianceScheduledActionForRuleObject `
        -ruleName PasswordRequired `
        -scheduledActionConfigurations `
        (New-DeviceComplianceActionItemObject `
            -gracePeriodHours 0 `
            -actionType block `
            -notificationTemplateId "" `
        ) `
    )

# Assign the newly created compliance policy to the AAD Group
Invoke-IntuneDeviceCompliancePolicyAssign -deviceCompliancePolicyId $windows10CompliancePolicy.id `
    -assignments `
        (New-DeviceCompliancePolicyAssignmentObject `
            -target `
            (New-DeviceAndAppManagementAssignmentTargetObject `
                -groupAssignmentTarget `
                -groupId "$AADGroupId" `
            ) `
        )
```

### Create MacOS Compliance Policy
```PowerShell
$macOSCompliancePolicy = New-IntuneDeviceCompliancePolicy `
    -macOSCompliancePolicy `
    -displayName "Chicago - MacOS Compliance Policy" `
    -passwordRequired $true `
    -passwordBlockSimple $false `
    -passwordRequiredType deviceDefault `
    -scheduledActionsForRule `
    (New-DeviceComplianceScheduledActionForRuleObject `
        -ruleName PasswordRequired `
        -scheduledActionConfigurations `
        (New-DeviceComplianceActionItemObject `
            -gracePeriodHours 0 `
            -actionType block `
            -notificationTemplateId "" `
        ) `
    )

# Assign the newly created compliance policy to the AAD Group
Invoke-IntuneDeviceCompliancePolicyAssign -deviceCompliancePolicyId $macOSCompliancePolicy.id `
    -assignments `
    (New-DeviceCompliancePolicyAssignmentObject `
    -target `
        (New-DeviceAndAppManagementAssignmentTargetObject `
            -groupAssignmentTarget `
            -groupId "$AADGroupId" `
        )`
    )
```
## Create Configuration Policies and Assign it to an AAD Group
```PowerShell
# Search the AAD Group
$AADGroupId = (Get-Groups -Filter "displayName eq 'Intune POC Users'").id
```

### Create iOS Restriction Policy
```PowerShell
$iosGeneralDeviceConfiguration = New-IntuneDeviceConfigurationPolicy `
    -iosGeneralDeviceConfiguration `
    -displayName "Chicago - iOS Device Restriction Policy" `
    -iCloudBlockBackup $true `
    -iCloudBlockDocumentSync $true `
    -iCloudBlockPhotoStreamSync $true

# Assign the newly created configuration policy to the AAD Group
Invoke-IntuneDeviceConfigurationPolicyAssign -deviceConfigurationId $iosGeneralDeviceConfiguration.id `
    -assignments `
    (New-DeviceConfigurationAssignmentObject `
        -target `
        (New-DeviceAndAppManagementAssignmentTargetObject `
            -groupAssignmentTarget `
            -groupId "$AADGroupId" `
        ) `
    )
```

### Create Android Restriction Policy
```PowerShell
$androidGeneralDeviceConfiguration = New-IntuneDeviceConfigurationPolicy `
    -androidGeneralDeviceConfiguration `
    -displayName "Chicago - Android Device Restriction Policy" `
    -passwordRequired $true `
    -passwordRequiredType deviceDefault `
    -passwordMinimumLength 4

# Assign the newly created configuration policy to the AAD Group
Invoke-IntuneDeviceConfigurationPolicyAssign -deviceConfigurationId $androidGeneralDeviceConfiguration.id `
    -assignments `
        (New-DeviceConfigurationAssignmentObject `
        -target `
            (New-DeviceAndAppManagementAssignmentTargetObject `
                -groupAssignmentTarget -groupId "$AADGroupId" `
            ) `
        )

```
## Create App Protection Polies and assign it to an AAD Group
### iOS App Protection Policy Creation
```PowerShell
# Get the list of iOS managed mobileapp objects
$appsiOS = @()
$iosManagedAppProtectionApps = Get-IntuneMobileApp | ? { $_.appAvailability -eq "global" -and ($_.'@odata.type').contains("managedIOS") }
foreach($app in $iosManagedAppProtectionApps)
{
    $bundleId = $app.bundleId
    $appsiOS += (New-ManagedMobileAppObject -mobileAppIdentifier (New-MobileAppIdentifierObject -iosMobileAppIdentifier -bundleId "$bundleId"))
}

# Create the ios App Protection Policy
$iosManagedAppProtection = New-IntuneAppProtectionPolicy `
    -iosManagedAppProtection `
    -displayName "iOS MAM / APP Policy" `
    -periodOfflineBeforeAccessCheck (New-TimeSpan -Hours 12) `
    -periodOnlineBeforeAccessCheck (New-TimeSpan -Minutes 30)`
    -allowedInboundDataTransferSources managedApps `
    -allowedOutboundDataTransferDestinations managedApps `
    -allowedOutboundClipboardSharingLevel managedAppsWithPasteIn `
    -organizationalCredentialsRequired $false `
    -dataBackupBlocked $true `
    -managedBrowserToOpenLinksRequired $false `
    -deviceComplianceRequired $false `
    -saveAsBlocked $true `
    -periodOfflineBeforeWipeIsEnforced (New-TimeSpan -Days 30) `
    -pinRequired $true `
    -maximumPinRetries 5 `
    -simplePinBlocked $false `
    -minimumPinLength 4 `
    -pinCharacterSet numeric `
    -periodBeforePinReset (New-TimeSpan -Days 30) `
    -allowedDataStorageLocations @("oneDriveForBusiness","sharePoint") `
    -contactSyncBlocked $false `
    -printBlocked $true `
    -fingerprintBlocked $false `
    -disableAppPinIfDevicePinIsSet $false `
    -apps $appsiOS

# Assign ios App Protection Policy to the AAD Group
Invoke-IntuneAppProtectionPolicyIosAssign -iosManagedAppProtectionId $iosManagedAppProtection.id `
    -assignments `
    (New-TargetedManagedAppPolicyAssignmentObject `
            -target `
            (New-DeviceAndAppManagementAssignmentTargetObject `
            -groupAssignmentTarget -groupId "$AADGroupId" `
            ) `
    )
```
### Android App Protection Policy Creation
```PowerShell

# Get the list of Android managed mobileapp objects
$appsAndroid = @()
$AndroidAPPapps = Get-IntuneMobileApp | ? { $_.appAvailability -eq "global" -and ($_.'@odata.type').contains("managedAndroid") }
foreach($app in $AndroidAPPapps)
{
    $PackageId = $app.packageId
    $appsAndroid += (New-ManagedMobileAppObject -mobileAppIdentifier (New-MobileAppIdentifierObject -androidMobileAppIdentifier -packageId "$PackageId"))
}

# Create the Android App Protection Policy
$androidManagedAppProtectionPolicy = New-IntuneAppProtectionPolicy `
    -androidManagedAppProtection -displayName "Android MAM / APP Policy" `
    -periodOfflineBeforeAccessCheck (New-TimeSpan -Hours 12) `
    -periodOnlineBeforeAccessCheck (New-TimeSpan -Minutes 30)`
    -allowedInboundDataTransferSources managedApps `
    -allowedOutboundDataTransferDestinations managedApps `
    -allowedOutboundClipboardSharingLevel managedAppsWithPasteIn `
    -organizationalCredentialsRequired $false `
    -dataBackupBlocked $true `
    -managedBrowserToOpenLinksRequired $false `
    -deviceComplianceRequired $false `
    -saveAsBlocked $true `
    -periodOfflineBeforeWipeIsEnforced (New-TimeSpan -Days 30) `
    -pinRequired $true `
    -maximumPinRetries 5 `
    -simplePinBlocked $false `
    -minimumPinLength 4 `
    -pinCharacterSet numeric `
    -periodBeforePinReset (New-TimeSpan -Days 30) `
    -allowedDataStorageLocations @("oneDriveForBusiness","sharePoint") `
    -contactSyncBlocked $false `
    -printBlocked $true `
    -disableAppPinIfDevicePinIsSet $false `
    -screenCaptureBlocked $true `
    -apps $appsAndroid

# Assign Android App Protection Policy to the AAD Group
Invoke-IntuneAppProtectionPolicyAndroidAssign -androidManagedAppProtectionId $androidManagedAppProtectionPolicy.id `
    -assignments `
    (New-TargetedManagedAppPolicyAssignmentObject `
            -target `
            (New-DeviceAndAppManagementAssignmentTargetObject `
            -groupAssignmentTarget -groupId "$AADGroupId" `
            ) `
    )
```

## Visualize summary of apps by type

```PowerShell
# Get all apps
$apps = Get-IntuneMobileApp

# Group the apps by type
$appsGroupedByType = $apps | Group-Object -Property '@odata.type'

# Get the X axis and Y axis values for the graph (casting is required here)
[string[]]$XVals = $appsGroupedByType | ForEach-Object {$_.Name.Replace('#microsoft.graph.', '')}
[int[]]$YVals = $appsGroupedByType | ForEach-Object {$_.Count}

# Display the results
.\Apps\VisualizeData.ps1 `
    -Title 'Intune Apps by Type' `
    -ChartType 'Pie' `
    -XLabel 'App Type' -YLabel 'Number of Apps' `
    -XValues $XVals -YValues $YVals
```
