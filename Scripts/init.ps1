# Get init script directory
$env:IntunePowerShellSDKRepoRoot = Split-Path (Split-Path $script:MyInvocation.MyCommand.Path -Parent) -Parent

# Environment variables
$env:generatedDir = "$($env:IntunePowerShellSDKRepoRoot)\src"
$env:sdkDir = "$($env:generatedDir)\bin\Release"
$env:testDir = "$($env:IntunePowerShellSDKRepoRoot)\Tests"
$env:moduleName = 'IntunePreview'
$env:moduleExtension = 'psd1'
#$env:defaultGraphSchema = "$($env:IntunePowerShellSDKRepoRoot)\Test Graph Schemas\v1.0-20180406 - Intune.csdl"
# Remember the settings that will change when launching a child PowerShell context
$env:standardWindowTitle = (Get-Host).UI.RawUI.WindowTitle
$env:standardForegroundColor = (Get-Host).UI.RawUI.ForegroundColor
$env:standardBackgroundColor = (Get-Host).UI.RawUI.BackgroundColor

# Scripts
$env:buildScript = "$($env:IntunePowerShellSDKRepoRoot)\Scripts\build.ps1"
$env:runScript = "$($env:IntunePowerShellSDKRepoRoot)\Scripts\run.ps1"
$env:testScript = "$($env:IntunePowerShellSDKRepoRoot)\Scripts\test.ps1"

function global:SDKBuild {
    Write-Host "Building the SDK (i.e. building the generated cmdlets)..." -f Cyan
    Invoke-Expression "$env:buildScript -WorkingDirectory '$env:generatedDir' -OutputPath '$env:sdkDir' -Verbosity 'quiet'"
    Write-Host "Finished building the SDK" -f Cyan
    Write-Host
}

function global:SDKTest {
[alias("test")]
    param()

    Invoke-Expression "$env:testScript"
}

# Restore NuGet packages
nuget restore -Verbosity quiet

Write-Host "Initialized repository." -f Green
Write-Host "Available commands:" -f Yellow
Write-Host "    SDKBuild                 " -NoNewline -f Cyan; Write-Host ' | ' -NoNewline -f Gray; Write-Host "Builds the generated PowerShellSDK project" -f DarkCyan
Write-Host "    SDKTest  (or 'test')     " -NoNewline -f Cyan; Write-Host ' | ' -NoNewline -f Gray; Write-Host "Runs tests against the generated PowerShellSDK project" -f DarkCyan
Write-Host
