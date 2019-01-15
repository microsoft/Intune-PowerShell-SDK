Import-Module $env:testDir\LobApps\UploadLobApp.psm1

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

$filePath = "$env:testDir\LobApps\test.ipa"
# Upload the app file with the app information
# !! Replace 'test.ipa' with the path to your *.ipa file !!
$createdApp = New-LobApp `
    -filePath $filePath `
    -mobileApp $appToUpload

Write-Output $createdApp