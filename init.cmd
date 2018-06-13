@echo OFF
setlocal enableDelayedExpansion

echo Initializing repository in a new PowerShell context (type 'exit' to return to this context)
echo.

powershell -NoExit ./Scripts/init.ps1