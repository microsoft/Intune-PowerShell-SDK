param (
    [string]$WorkingDirectory = "$(Get-Location)",
    [string]$OutputPath,
    [string]$Verbosity = 'minimal',
    [string]$AssemblyName
)

# Expand environment variables
$WorkingDirectory = ([System.Environment]::ExpandEnvironmentVariables($WorkingDirectory))
$OutputPath = ([System.Environment]::ExpandEnvironmentVariables($OutputPath))

# Make sure the dotnet command is installed
$dotnetCliVersion = Invoke-Expression 'dotnet --version'

# If dotnet is not installed, attempt to install it
if ($dotnetCliVersion.Contains('\n') -or [string]::IsNullOrWhitespace($dotnetCliVersion)) {
    & $env:dotnetInstallScript
}

# Compile the MSBuild arguments
$BuildArguments = @(
    "--configuration $($env:buildConfiguration)",
    "--verbosity $Verbosity"
)

# Set the output path if required
if (-Not [string]::IsNullOrWhiteSpace($OutputPath))
{
    $MSBuildArguments += "--output `"$OutputPath`""
}

# Set the assembly name if required
if (-Not [string]::IsNullOrWhiteSpace($AssemblyName))
{
    $BuildArguments += "/p:AssemblyName=$AssemblyName"
}

# Run MSBuild in the given working directory
Push-Location $WorkingDirectory
try {
    $command = "dotnet build $BuildArguments"
    Write-Host $command -f DarkCyan
    Invoke-Expression $command
    if (-Not $?)
    {
        throw "MSBuild exited with error code '$LastExitCode'"
    }
} finally {
    Pop-Location
}
