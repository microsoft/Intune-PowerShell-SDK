# Start the new PowerShell context
[CmdletBinding()]
param(
    [Parameter(Mandatory=$true)]
    [ValidateNotNullOrEmpty()]
    [string]$SdkDirectory
)

$moduleLocation = "$SdkDirectory\$($env:moduleName).$($env:moduleExtension)"

# Check that a build of the SDK exists
if (-Not (Test-Path "$moduleLocation" -PathType Leaf))
{
    throw "Cannot find '$moduleLocation'.  Run the 'build' command before running the module."
}

try {
    Write-Host 'Importing module in a new PowerShell context...'
    Write-Host 'NOTE: Type ''exit'' to return to the current context.' -f Yellow

    powershell -NoExit -Command {
        param(
            $module
        )

        try {
            (Get-Host).UI.RawUI.WindowTitle = "$module"
            (Get-Host).UI.RawUI.ForegroundColor = 'Cyan'
            (Get-Host).UI.RawUI.BackgroundColor = 'Black'

            Import-Module "$module"
            Connect-MSGraph
        } catch {
            Write-Error "Failed to initialize new PowerShell context: '$_'"
            exit
        }
    } -args $moduleLocation

    # Check that the special PowerShell context exited successfully
    if (-Not $?)
    {
        Write-Host "Child PowerShell context exited with error code '$LastExitCode'" -f Red
        Write-Host
    }
} catch {
    Write-Host "Failed to run child PowerShell context" -f Red
    Write-Host
} finally {
    # Restore the old settings
    (Get-Host).UI.RawUI.WindowTitle = $env:standardWindowTitle
    (Get-Host).UI.RawUI.ForegroundColor = $env:standardForegroundColor
    (Get-Host).UI.RawUI.BackgroundColor = $env:standardBackgroundColor
}
