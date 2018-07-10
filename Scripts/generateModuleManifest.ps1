[CmdletBinding()]
param()

# Run this all in a new context
powershell.exe -Command {
    # Change to the directory
    Set-Location $env:sdkDir

    # Get the nested modules
    $nestedModulesRelativePaths = Get-ChildItem -Include '*.psm1', '*.ps1' -Recurse -File | Resolve-Path -Relative | ForEach-Object { $_.Substring(2) }

    # Maintain a list of all the cmdlets, functions and aliases to export
    $cmdlets = @()
    $functions = @()
    $aliases = @()

    # Create a single list of all modules
    $modulePaths = @()
    $modulePaths += "$($env:sdkAssemblyName).dll"
    $modulePaths += $nestedModulesRelativePaths

    foreach ($modulePath in $modulePaths) {
        Write-Host "Including in module: '$modulePath'"

        # Import the module
        Import-Module ".\$modulePath"

        # Get the last segment of the path
        $currentModuleName = $modulePath.Split('\')[-1]

        # Remove the file extension
        $currentModuleName = $currentModuleName.Remove($currentModuleName.LastIndexOf([char]'.'))

        # Get cmdlets
        $moduleCmdlets = Get-Command -Module $currentModuleName -CommandType Cmdlet
        $cmdlets += $moduleCmdlets.Name

        # Get functions
        $moduleFunctions = Get-Command -Module $currentModuleName -CommandType Function
        $functions += $moduleFunctions.Name

        # Get aliases
        $moduleAliases = Get-Command -Module $currentModuleName -CommandType Alias
        $aliases += $moduleAliases.Name
    }

    # Build the content of the generated manifest
    $generateManifestArgs = @{
        Path = "$($env:sdkDir)/$($env:moduleName).psd1"

        # START PrivateData.PSData
            # PreRelease version of the Intune PowerShell SDK
            # PreRelease = 'update20180702'

            # Tags applied to this module. These help with module discovery in online galleries.
            Tags = @(
                'Microsoft',
                'Microsoft Graph',
                'Graph',
                'Microsoft Intune',
                'Intune'
            )

            # Flag to indicate whether the module requires explicit user acceptance
            # RequireLicenseAcceptance = $true

            # A URL to the license for this module.
            LicenseUri = 'https://github.com/microsoftgraph/Intune-PowerShell-SDK-Code-Generator/blob/master/src/PowerShellGraphSDK/PowerShellModuleAdditions/LICENSE.txt'

            # A URL to the main website for this project.
            ProjectUri = 'https://github.com/MicrosoftGraph/Intune-PowerShell-SDK'

            # A URL to an icon representing this module.
            # IconUri = ''

            # ReleaseNotes of this module
            # ReleaseNotes = ''

            # External dependent modules of this module
            # ExternalModuleDependencies = ''
        # END PrivateData.PSData

        # Script module or binary module file associated with this manifest
        RootModule = 'Microsoft.Intune.PowerShellGraphSDK.dll'

        # Version number of this module.
        ModuleVersion = '6.1808.2'

        # ID used to uniquely identify this module
        GUID = 'A720591A-2D56-4570-B362-E15B84C4CD63'

        # Author of this module
        Author = 'Microsoft Corporation'

        # Company or vendor of this module
        CompanyName = 'Microsoft Corporation'

        # Copyright statement for this module
        Copyright = '(c) 2018 Microsoft. All rights reserved.'

        # Description of the functionality provided by this module
        Description = 'PowerShell SDK for Microsoft Intune Graph API'

        # Minimum version of the Windows PowerShell engine required by this module
        # PowerShellVersion = ''

        # Name of the Windows PowerShell host required by this module
        # PowerShellHostName = ''

        # Minimum version of the Windows PowerShell host required by this module
        # PowerShellHostVersion = ''

        # Minimum version of the .NET Framework required by this module
        # DotNetFrameworkVersion = ''

        # Minimum version of the common language runtime (CLR) required by this module
        # CLRVersion = ''

        # Processor architecture (None, X86, Amd64) required by this module
        # ProcessorArchitecture = ''

        # Modules that must be imported into the global environment prior to importing this module
        # RequiredModules = @()

        # Assemblies that must be loaded prior to importing this module
        # RequiredAssemblies = @()

        # Script files (.ps1) that are run in the caller's environment prior to importing this module
        # ScriptsToProcess = @()

        # Type files (.ps1xml) to be loaded when importing this module
        # TypesToProcess = @()

        # Format files (.ps1xml) to be loaded when importing this module
        # FormatsToProcess = @()

        # Functions to export from this module
        FunctionsToExport = $functions

        # Cmdlets to export from this module
        CmdletsToExport = $cmdlets

        # Variables to export from this module
        VariablesToExport = @()

        # Aliases to export from this module
        AliasesToExport = $aliases

        # List of all modules packaged with this module
        # ModuleList = @()

        # List of all files packaged with this module
        # FileList = @()

        # Private data to pass to the module specified in RootModule/ModuleToProcess
        # PrivateData = ''

        # HelpInfo URI of this module
        # HelpInfoURI = ''

        # Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
        # DefaultCommandPrefix = 'MSGraph'

        # Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
        NestedModules = $nestedModulesRelativePaths
    }

    New-ModuleManifest @generateManifestArgs
}