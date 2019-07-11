Import-Module (Join-Path -Path $PSScriptRoot -ChildPath 'UploadLobApp.psm1')

# Create the object that contains information about the app
$appToUpload = New-MobileAppObject `
    -iosLobApp `
    -displayName 'Test' `
    -description 'This is a test iOS LOB app' `
    -publisher 'IT Professional' `
    -bundleId '' `
    -applicableDeviceType (New-IosDeviceTypeObject -iPad $true -iPhoneAndIPod $true) `
    -minimumSupportedOperatingSystem (New-IosMinimumOperatingSystemObject -v9_0 $true) `
    -fileName 'test.ipa' `
    -buildNumber 'v1' -versionNumber 'v1' -expirationDateTime ((Get-Date).AddDays(90))

# Upload the app file with the app information
# !! Set $filePath to the path to your *.ipa file !!
$filePath = Join-Path -Path $PSScriptRoot -ChildPath 'test.ipa'
$createdApp = New-LobApp `
    -filePath $filePath `
    -mobileApp $appToUpload

Write-Output $createdApp