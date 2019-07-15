# Table of Contents
- [Table of Contents](#Table-of-Contents)
- [Intune-PowerShell-SDK](#Intune-PowerShell-SDK)
- [Getting started](#Getting-started)
  - [One-time setup (PowerShell Gallery)](#One-time-setup-PowerShell-Gallery)
  - [One-time setup (GitHub)](#One-time-setup-GitHub)
  - [Before this module is used in your organization](#Before-this-module-is-used-in-your-organization)
  - [Each time you use the module](#Each-time-you-use-the-module)
  - [Discovering available commands](#Discovering-available-commands)
- [Example usage](#Example-usage)
  - [Retrieving objects](#Retrieving-objects)
  - [Creating objects](#Creating-objects)
  - [Modifying objects](#Modifying-objects)
  - [Deleting objects](#Deleting-objects)
  - [Calling functions and actions](#Calling-functions-and-actions)
  - [Tips and Tricks](#Tips-and-Tricks)
- [Notable features](#Notable-features)
- [Known issues and workarounds](#Known-issues-and-workarounds)

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

To authenticate with Microsoft Graph using a [PSCredential] object:
```PowerShell
# 1. Create the PSCredential object
$adminUPN = Read-Host -Prompt "Enter UPN"
$adminPwd = Read-Host -AsSecureString -Prompt "Enter password for $adminUPN"
$creds = New-Object System.Management.Automation.PSCredential ($adminUPN, $adminPwd)

# 2. Log in with these credentials
Connect-MSGraph -PSCredential $creds
```

To authenticate in a non-standard environment:
```PowerShell
# 1. Setup the environment
# For example, in a National Cloud environment, the following is required before logging in
Update-MSGraphEnvironment -AuthUrl 'https://login.microsoftonline.us/common' -GraphBaseUrl 'https://graph.microsoft.us' -GraphResourceId 'https://graph.microsoft.us' -SchemaVersion 'beta'

# 2. Log in
Connect-MSGraph

# 3. Use the cmdlets
# NOTE: If the schema version has been changed to something other than "v1.0" as in the above
#   "Update-MSGraphEnvironment" command, only "Invoke-MSGraphRequest" should be used to make calls,
#   because the standard cmdlets (e.g. "Get-IntuneMobileApp") have been generated based on the
#   "v1.0" schema, and can produce unexpected results when used with other schema versions
Invoke-MSGraphRequest -HttpMethod GET -Url 'deviceAppManagement/mobileApps'
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

# Example usage
## Retrieving objects
Get all Intune applications:
```PowerShell
Get-IntuneMobileApp
```

Get all Intune device configurations:
```PowerShell
Get-IntuneDeviceConfigurationPolicy
```

Get all Intune managed devices:
```PowerShell
Get-IntuneManagedDevice
```

Get a filtered list of applications and select only the "displayName" and "publisher" properties:
```PowerShell
# The filter string follows the same rules as specified in the OData v4.0 specification.
# Filter string construction rules: http://docs.oasis-open.org/odata/odata/v4.0/errata03/os/complete/abnf/odata-abnf-construction-rules.txt
Get-IntuneMobileApp -Select displayName, publisher -Filter "isof('microsoft.graph.webApp')"
```

## Creating objects
Create a web application:
```PowerShell
$bingWebApp = New-IntuneMobileApp -webApp -displayName 'Bing' -publisher 'Microsoft Corporation' -AppUrl 'https://www.bing.com'
```

## Modifying objects
Update the web application that we created in the '[Creating objects](#creating-objects)' section:
```PowerShell
$bingWebApp | Update-IntuneMobileApp -webApp -displayName 'Bing Search'
```

## Deleting objects
Delete the web application that we created in the '[Creating objects](#creating-objects)' section:
```PowerShell
$bingWebApp | Remove-IntuneMobileApp
```

## Calling functions and actions
Lock a managed device:
```PowerShell
# Get a device to lock
$allDevices = Get-IntuneManagedDevice
$deviceToLock = $allDevices[0]

# Lock this device
$deviceToLock | Invoke-IntuneManagedDeviceRemoteLock
```

## Tips and Tricks
 - Create TimeSpan objects using the [New-TimeSpan](https://docs.microsoft.com/en-us/powershell/module/microsoft.powershell.utility/new-timespan?view=powershell-6) cmdlet
 - Create DateTime or DateTimeOffset objects using the [Get-Date](https://docs.microsoft.com/en-us/powershell/module/Microsoft.PowerShell.Utility/Get-Date?view=powershell-6) cmdlet
 - If a parameter accepts an "Object" rather than a more specific type, use the documentation to identify what type of object it requires.  For example, if the documentation says that a parameter represents a property of type "microsoft.graph.mobileApp" or "microsoft.graph.deviceConfiguration", use the "New-MobileAppObject" or "New-DeviceConfigurationObject" cmdlets to create the respective objects.

# Notable features
- Standard PowerShell objects are used for input/output, meaning that all built-in PowerShell features/utilities/tricks work, including:
    - Piping of objects between cmdlets
    - Formatting of output: `Format-Table`, `Out-GridView`, `ConvertTo-Csv`, `ConvertTo-Json`, etc.
    - Getting help on usage: `Get-Help`
    - Visualizing input parameters: `Show-Command`
    - Using the 'tab' key to auto-complete or cycle through available options
- Documentation which is available in the schema is injected into the cmdlet documentation
- Auto-complete and validation on Enum parameters as well as some query parmeters (i.e. $select, $expand and $orderBy)
- Utility cmdlets for some common tasks
    - Getting the authentication token: `Connect-MSGraph`
    - Getting service metadata: `Get-MSGraphMetadata`
    - Paging: `Get-MSGraphNextPage` and `Get-MSGraphAllPages`
    - Changing environment settings, e.g. Graph schema version: `Update-MSGraphEnvironment -Schema beta -AppId 00000000-0000-0000-0000-000000000000`
    - Make arbitrary Graph calls using the `Invoke-MSGraph` cmdlet
- The PowerShell module can be generated for any valid Graph schema

# Known issues and workarounds
- Importing the `MSOnline` cmdlets before importing this `Intune` module will cause errors. Please use the `AzureAD` module instead, as the `MSOnline` module is deprecated.
  - If you absolutely must use the `MSOnline` module, it should be imported AFTER the `Intune` module. Note, however, that this is not officially supported.
- If downloaded from Github, the file "Microsoft.Intune.PowerShellGraphSDK.dll" may be blocked when a release is first downloaded.  This will stop the assembly from correctly loading (and you will see an error message if you try to import the module).
```PowerShell
Dir -Recurse $sdkDir | Unblock-File
```
- Cmdlets in this module are generated based on the "v1.0" version of the Graph schema. In order to access functionality in the "beta" schema you must change the schema version using the command below.  However, note that only the `Invoke-MSGraphRequest` cmdlet should be used to make calls to Graph.  This is because the difference in entities/properties between "beta" and "v1.0" (the schema that most cmdlets were generated from) can result in unexpected behavior.
```PowerShell
Update-MSGraphEnvironment -SchemaVersion 'beta'
```
