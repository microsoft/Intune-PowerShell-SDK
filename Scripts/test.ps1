# Check that a build of the SDK exists
if (-Not (Test-Path "$env:sdkDir"))
{
    throw "Cannot find a successful build of the SDK.  Run the 'build' command before running tests."
}

# Build the command to get and run test scripts
$getTestScriptsCommand = "`$testScripts = Get-ChildItem -Path '$env:testDir' -Recurse -Filter '*.ps1'"
$runTestScriptsCommand = @"
`$testScripts | ForEach-Object {
    Write-Host -f Yellow `"RUNNING: `"`$_.BaseName
    try {
        & `$_.FullName
    } catch {
        Write-Error `"Error: `"`$_
    }
    Write-Host -f Magenta `"COMPLETED: `"`$_.BaseName
    Write-Host
}
"@

# Get the commands
$commands = @(
    '(Get-Host).UI.RawUI.WindowTitle = "$env:moduleName"',
    '(Get-Host).UI.RawUI.ForegroundColor = ''Cyan''',
    '(Get-Host).UI.RawUI.BackgroundColor = ''Black''',
    'Import-Module "$env:sdkDir\$env:moduleName.$env:moduleExtension"',
    $getTestScriptsCommand,
    'Connect-MSGraph',
    $runTestScriptsCommand,
    'exit'
)

Write-Host
Write-Host 'Starting the test PowerShell context with the following commands:' -f Cyan
$commands | ForEach-Object { Write-Host "    $_" -f Cyan }
Write-Host

# Run the tests in a new PowerShell context
try {
    & powershell -NoExit -Command "& {$($commands -Join '; ')}"

    if (!$?)
    {
        throw "Tests failed"
    }
} catch {
    Write-Error "Error: '$_'"
} finally {
    # Restore the old settings
    (Get-Host).UI.RawUI.WindowTitle = $env:standardWindowTitle
    (Get-Host).UI.RawUI.ForegroundColor = $env:standardForegroundColor
    (Get-Host).UI.RawUI.BackgroundColor = $env:standardBackgroundColor

    exit
}