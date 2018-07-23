param(
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string]$ModuleName,

    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string]$OutputDirectory,

    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string]$MainModuleRelativePath,

    [Parameter()]
    [string[]]$NestedModulesRelativePaths
)

$OutputDirectory = $OutputDirectory | Resolve-Path

# Maintain a list of all the cmdlets, functions and aliases to export
$cmdlets = @()
$functions = @()
$aliases = @()
$variables = @()

# Create a single list of all modules
$modulePaths = @()
$modulePaths += $MainModuleRelativePath
if ($NestedModulesRelativePaths) {
    $modulePaths += $NestedModulesRelativePaths
}

Push-Location $OutputDirectory
try {
    # Collect module information
    foreach ($modulePath in $modulePaths) {
        if (-Not $modulePath.StartsWith('.\')) {
            throw "Provided paths must start with '.\', but '$modulePath' does not"
        }
        if (-Not (Test-Path $modulePath)) {
            throw "Module not found at '$modulePath'. Does this path exist under '$OutputDirectory'?"
        }

        Write-Host "Including module: '$modulePath'"

        # Get the module's information
        $moduleInfo = Get-Module $modulePath -ListAvailable

        # Get cmdlets
        $cmdlets += [string[]]$moduleInfo.ExportedCmdlets.Keys

        # Get functions
        $functions += [string[]]$moduleInfo.ExportedFunctions.Keys

        # Get aliases
        $aliases += [string[]]$moduleInfo.ExportedAliases.Keys

        # Get Variables
        $variables += [string[]]$moduleInfo.ExportedVariables.Keys
    }
} finally {
    Pop-Location
}

# Build the content of the generated manifest
$generateManifestArgs = @{
    Path = "$OutputDirectory/$ModuleName.psd1"

    # START PrivateData.PSData        
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
        ProjectUri = 'https://github.com/Microsoft/Intune-PowerShell-SDK'

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
    ModuleVersion = '6.1808.20'

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
    VariablesToExport = $variables

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
    NestedModules = $NestedModulesRelativePaths
}

New-ModuleManifest @generateManifestArgs