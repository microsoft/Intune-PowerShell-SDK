param (
    [string]$BuildTargets = 'Restore;Rebuild',
    [string]$WorkingDirectory = "$(Get-Location)",
    [string]$OutputPath,
    [string]$MSBuildExe32 = '%ProgramFiles(x86)%\Microsoft Visual Studio\2017\BuildTools\MSBuild\15.0\Bin\MSBuild.exe',
    [string]$MSBuildExe64 = '%ProgramFiles%\Microsoft Visual Studio\2017\BuildTools\MSBuild\15.0\Bin\MSBuild.exe',
    [string]$Verbosity = 'minimal',
    [string]$AssemblyName,
    [string]$GraphSchema
)

# Expand environment variables
$WorkingDirectory = ([System.Environment]::ExpandEnvironmentVariables($WorkingDirectory))
$OutputPath = ([System.Environment]::ExpandEnvironmentVariables($OutputPath))
$MSBuildExe32 = ([System.Environment]::ExpandEnvironmentVariables($MSBuildExe32))
$MSBuildExe64 = ([System.Environment]::ExpandEnvironmentVariables($MSBuildExe64))
$GraphSchema = ([System.Environment]::ExpandEnvironmentVariables($GraphSchema))

# Get the MSBuild.exe path
$msBuildExe = $MSBuildExe32
if (-Not (Test-Path $msBuildExe)) {
    $msBuildExe = $MSBuildExe64
}

# Install MSBuild.exe if it doesn't exist
if (-Not (Test-Path $msBuildExe)) {
    Write-Host "VS Build Tools 2017 could not be found.  If the following installation fails, you can install it from 'https://visualstudio.microsoft.com/downloads/'" -ForegroundColor Yellow
    Invoke-Expression "$env:msbuildInstallScript"

    # Double check that MSBuild.exe now exists
    $msBuildExe = $MSBuildExe32
    if (-Not (Test-Path $msBuildExe)) {
        $msBuildExe = $MSBuildExe64
    }
    if (-Not (Test-Path $msBuildExe)) {
        Write-Host "MSBuild was not found at '$msBuildExe'" -ForegroundColor Red
        throw "Installation of VS Build Tools 2017 failed - please try to install it manually"
    }
}

# Compile the MSBuild arguments
$MSBuildArguments = @(
    "/p:Configuration=$($env:buildConfiguration)",
    "/t:$BuildTargets",
    "/p:UseSharedCompilation=false",
    "/nr:false",
    "/v:$Verbosity",
    "/ignore:.sln"
)

# Set the output path if required
if (-Not [string]::IsNullOrWhiteSpace($OutputPath))
{
    $MSBuildArguments += "/p:OutputPath=`"$OutputPath`""
}

# Set the assembly name if required
if (-Not [string]::IsNullOrWhiteSpace($AssemblyName))
{
    $MSBuildArguments += "/p:AssemblyName=$AssemblyName"
}

# Select the default graph schema if one was not provided
if ($GraphSchema)
{
    # Add the schema path to the MSBuild arguments if it is a valid path
    if (Test-Path $GraphSchema)
    {
        $MSBuildArguments += "/p:GraphSchemaPath=`"$GraphSchema`""
        Write-Host "MSBuild arguments: " -f Magenta
        $MSBuildArguments | ForEach-Object {
            Write-Host $_ -f Magenta
        }
    } else {
        throw "Unable to find Graph schema at '$GraphSchema' - provide a valid path to a schema file"
    }
}

# Run MSBuild in the given working directory
Push-Location $WorkingDirectory
try {
    $command = "`"$msBuildExe`" $MSBuildArguments"
    Write-Host $command -f DarkCyan
    & $msBuildExe $MSBuildArguments
    if (-Not $?)
    {
        throw "MSBuild exited with error code '$LastExitCode'"
    }
} finally {
    Pop-Location
}