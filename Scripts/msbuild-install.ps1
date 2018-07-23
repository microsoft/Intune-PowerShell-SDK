$msBuildInstaller = ([System.Environment]::ExpandEnvironmentVariables("%TEMP%\vs_BuildTools.exe"))
Invoke-WebRequest -OutFile "$msBuildInstaller" "https://aka.ms/vs/15/release/vs_buildtools.exe"
$process = Start-Process -FilePath "$msBuildInstaller" -Verb RunAs -Wait -PassThru -ArgumentList "--add Microsoft.VisualStudio.Workload.MSBuildTools --add Microsoft.VisualStudio.Workload.NetCoreBuildTools --add Microsoft.VisualStudio.Workload.ManagedDesktopBuildTools --norestart --quiet --force"
if ($process.ExitCode -eq 0) {
    Write-Host "Done installing VS Build Tools" -ForegroundColor Green
    Write-Host "Installation may require a restart - please check by opening the 'Visual Studio Installer' application" -f Yellow
} else {
    # Failed to install - print an error on the command line
    throw "Failed to install VS Build Tools. Exit code: $($process.ExitCode)"
}