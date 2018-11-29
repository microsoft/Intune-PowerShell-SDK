function EncryptFile($sourceFile) {
    $bufferBlockSize = 1024 * 4
    $buffer = New-Object byte[] $bufferBlockSize
    $bytesRead = 0

    try {
        $aes = [System.Security.Cryptography.Aes]::Create()
        $initializationVector = $aes.IV

        $aesProvider = New-Object System.Security.Cryptography.AesCryptoServiceProvider
        $hmacSha256 = New-Object System.Security.Cryptography.HMACSHA256
        $aesProvider.GenerateKey()
        $hmacKey = $aesProvider.Key
        $hmacSha256.Key = $hmacKey
        $hmacLength = $hmacSha256.HashSize / 8

        # Create the stream that we will write to
        $targetStream = New-Object System.IO.MemoryStream

        # Add empty space for the hmac and initialization vector
        $targetStream.Write($buffer, 0, $hmacLength + $initializationVector.Length)

        # Create the Crypto stream
        $aesProvider.GenerateKey()
        $encryptionKey = $aesProvider.Key
        $encryptor = $aes.CreateEncryptor($encryptionKey, $initializationVector)
        $sourceStream = [System.IO.File]::Open($sourceFile, [System.IO.FileMode]::Open, [System.IO.FileAccess]::Read, [System.IO.FileShare]::Read)
        $cryptoStream = New-Object System.Security.Cryptography.CryptoStream -ArgumentList @($targetStream, $encryptor, [System.Security.Cryptography.CryptoStreamMode]::Write)

        # Write encrypted file
        while (($bytesRead = $sourceStream.Read($buffer, 0, $bufferBlockSize)) -gt 0) {
            $cryptoStream.Write($buffer, 0, $bytesRead)
            $cryptoStream.Flush()
        }
        $cryptoStream.FlushFinalBlock()

        # Write initialization vector
        $targetStream.Seek($hmacLength, [System.IO.SeekOrigin]::Begin) | Out-Null
        $targetStream.Write($initializationVector, 0, $initializationVector.Length)
        $targetStream.Seek($hmacLength, [System.IO.SeekOrigin]::Begin) | Out-Null

        # Create HMAC
        $hmac = $hmacSha256.ComputeHash($targetStream)

        # Write HMAC
        $targetStream.Seek(0, [System.IO.SeekOrigin]::Begin) | Out-Null
        $targetStream.Write($hmac, 0, $hmac.Length)

        # Create file digest
        $fileDigestAlgorithm = 'SHA256'
        $fileDigest = (Get-FileHash $sourceFile -Algorithm $fileDigestAlgorithm).Hash
        [byte[]]$fileDigestBytes = New-Object byte[] ($fileDigest.Length / 2) # 2 hexadecimal characters represents 1 byte here
        for ($i = 0; $i -lt $fileDigest.Length; $i += 2) {
            $fileDigestBytes[$i / 2] = [System.Convert]::ToByte($fileDigest.Substring($i, 2), 16)
        }

        # Return encrypted file and encryption info that can be sent to Intune
        $fileBytes = $targetStream.ToArray()
        return @{
            'file' = $fileBytes
            'info' = New-FileEncryptionInfoObject `
                -encryptionKey $encryptionKey `
                -macKey $hmacKey `
                -initializationVector $initializationVector `
                -mac $hmac `
                -profileIdentifier 'ProfileVersion1' `
                -fileDigest $fileDigestBytes `
                -fileDigestAlgorithm $fileDigestAlgorithm
        }
    }
    finally
    {
        if ($cryptoStream) { $cryptoStream.Dispose() }
        if ($sourceStream) { $sourceStream.Dispose() }
        if ($encryptor) { $encryptor.Dispose() }
        if ($targetStream) { $targetStream.Dispose() }
        if ($aes) { $aes.Dispose() }
    }
}

###################################################################################################

function WaitForFileProcessing($file, $stage) {
    $attempts = 6
    $waitTimeInSeconds = 1

    $result = $null
    while ($attempts -gt 0) {
        $result = $file | Get-IntuneMobileAppContentVersionFile

        if ($result.uploadState -like "$($stage)Success") {
            return $result
        } elseif ($result.uploadState -like "$($stage)Pending") {
            Start-Sleep $waitTimeInSeconds
            $attempts--
            $waitTimeInSeconds *= 2
        } else {
            throw "File processing for stage '$stage' was not successful: $($result.uploadState)"
        }
    }

    throw "File request timed out."
}

function WaitForAzureStorageRequest($file) {
    return WaitForFileProcessing -file $file -stage 'AzureStorageUriRequest'
}

function WaitForAzureFileCommitted($file) {
    return WaitForFileProcessing -file $file -stage 'CommitFile'
}

###################################################################################################

function UploadAzureStorageChunk($sasUri, $id, $body) {
    $uri = "$sasUri&comp=block&blockid=$id"
    $request = "PUT $uri"

    $iso = [System.Text.Encoding]::GetEncoding("iso-8859-1")
    $encodedBody = $iso.GetString($body)
    $headers = @{ "x-ms-blob-type" = "BlockBlob" }

    if ($logRequestUris) { Write-Host $request }
    if ($logHeaders) { WriteHeaders $headers }

    try {
        Invoke-WebRequest $uri -Method Put -Headers $headers -Body $encodedBody -UseBasicParsing | Out-Null
    } catch {
        Write-Host -ForegroundColor Red $request
        Write-Host -ForegroundColor Red $.Exception.Message
        throw
    }

}

function FinalizeAzureStorageUpload($sasUri, $ids) {
    $uri = "$sasUri&comp=blocklist"
    $request = "PUT $uri"

    $xml = '<?xml version="1.0" encoding="utf-8"?><BlockList>'
    foreach ($id in $ids) {
        $xml += "<Latest>$id</Latest>"
    }
    $xml += '</BlockList>'

    if ($logRequestUris) { Write-Host $request }
    if ($logContent) { Write-Host -ForegroundColor Gray $xml }

    try {
        Invoke-RestMethod $uri -Method Put -Body $xml | Out-Null
    } catch {
        Write-Host -ForegroundColor Red $request
        Write-Host -ForegroundColor Red $.Exception.Message
        throw
    }
}

function UploadFileToAzureStorage($sasUri, $bytes) {
    # Chunk size = 1 MiB
    $chunkSizeInBytes = 1024 * 1024

    # Read the whole file and find the total chunks.
    $chunks = [Math]::Ceiling($bytes.Length / $chunkSizeInBytes)

    # Upload each chunk.
    $ids = @()
    for ($chunk = 0; $chunk -lt $chunks; $chunk++) {
        $id = [System.Convert]::ToBase64String([System.Text.Encoding]::UTF8.GetBytes($chunk.ToString("0000")))
        $ids += $id

        $start = $chunk * $chunkSizeInBytes
        $end = [Math]::Min($start + $chunkSizeInBytes - 1, $bytes.Length - 1)
        $body = $bytes[$start..$end]

        Write-Progress -Activity "Uploading File to Azure Storage" -status "Uploading chunk $($chunk + 1) of $chunks" -percentComplete (($chunk + 1) / $chunks*100)
        UploadAzureStorageChunk -sasUri $sasUri -id $id -body $body
    }
    Write-Progress -Completed -Activity "Uploading File to Azure Storage"

    # Finalize the upload.
    FinalizeAzureStorageUpload -sasUri $sasUri -ids $ids
}

function script:ValidateMobileAppWithFile($file, $mobileApp) {
    # Get the mobileApp's OData type name
    $mobileAppTypeName = $mobileApp.'@odata.type'
    if (-not $mobileAppTypeName) {
        throw "There must be an '@odata.type' property on the mobileApp object."
    }

    # Validate the file based on the OData type of the app metadata object
    $androidAppTypeName = '#microsoft.graph.androidLobApp'
    $iosAppTypeName = '#microsoft.graph.iosLobApp'
    switch ($mobileAppTypeName) {
        $androidAppTypeName {
            # Make sure this is the right file type
            $expectedFileExtension = 'apk';
            if ($sourceFile.Extension -ne ".$expectedFileExtension") {
                throw "The file '$($sourceFile.Name)' is not a valid '*.$expectedFileExtension' file"
            }
        }
        $iosAppTypeName {
            # Make sure this is the right file type
            $expectedFileExtension = 'ipa';
            if ($sourceFile.Extension -ne ".$expectedFileExtension") {
                throw "The file '$($sourceFile.Name)' is not a valid '*.$expectedFileExtension' file"
            }

            # Check the expiration date/time
            if ([System.DateTimeOffset]::Now -gt $mobileApp.expirationDateTime) {
                throw "The file '$($sourceFile.Name)' has expired"
            }
        }
        default {
            throw "Unknown app type '$mobileAppTypeName'"
        }
    }
}

###################################################################################################

function New-LobApp {
    [CmdletBinding()]
    param(
        [ValidateNotNullOrEmpty()]
        [string]$filePath,

        [ValidateNotNull()]
        [PSObject]$mobileApp
    )

    try {
        Write-Host "Validating the file '$filePath'..." -ForegroundColor Yellow

        # Make sure the file exists
        if (-not (Test-Path -LiteralPath $filePath -PathType Leaf)) {
            throw "The file '$filePath' does not exist"
        }

        # Get the file
        $sourceFile = Get-Item $filePath

        # Validate the provided mobileApp
        Write-Host "Validating the provided mobileApp..." -ForegroundColor Yellow
        ValidateMobileAppWithFile -file $sourceFile -mobileApp $mobileApp

        # Post the app metadata to Intune
        $createdApp = $mobileApp | New-IntuneMobileApp

        # Create a new content version for this app
        Write-Host "Creating Content Version in Intune for the application..." -ForegroundColor Yellow
        $contentVersion = $createdApp | New-IntuneMobileAppContentVersion

        # Encrypt the file
        Write-Host "Encrypting the file '$($sourceFile.Name)'..." -ForegroundColor Yellow
        $encryptionResult = EncryptFile -sourceFile $sourceFile

        # Upload the file manifest to Intune
        Write-Host "Uploading the file's information to Intune..." -ForegroundColor Yellow
        $file = $contentVersion | New-IntuneMobileAppContentVersionFile `
            -name $sourceFile.Name `
            -size $sourceFile.Length `
            -sizeEncrypted $encryptionResult.file.Length

        # Wait for Azure Storage to get ready
        Write-Host "Waiting for the file's upload URI to be created..." -ForegroundColor Yellow
        $file = WaitForAzureStorageRequest -file $file

        # Upload the file to Azure Storage
        Write-Host "Uploading file to Azure Storage at '$($file.azureStorageUri)'..." -f Yellow
        UploadFileToAzureStorage -sasUri ($file.azureStorageUri) -bytes ($encryptionResult.file)

        # Commit file
        Write-Host "Asking Intune to commit the file that has been uploaded to Azure Storage..." -ForegroundColor Yellow
        $file | Invoke-IntuneMobileAppContentVersionFileCommit -fileEncryptionInfo $encryptionResult.info

        # Wait for Azure Storage to aknowledge the commit
        Write-Host "Waiting for Intune to process the commit file request..." -ForegroundColor Yellow
        $file = WaitForAzureFileCommitted -file $file

        # Tell Intune that this file is now the latest version of the app
        Write-Host "Telling Intune that the committed file is the latest version of this app..." -ForegroundColor Yellow
        $createdApp | Update-IntuneMobileApp -committedContentVersion $contentVersion.id

        # Return the file
        Write-Output $file

        Write-Host "Finished uploading app '$filePath'" -ForegroundColor Green
    } catch {
        # To ensure that all errors are terminating errors
        throw
    }
}

###################################################################################################

# Don't export helper functions
Export-ModuleMember -Function New-LobApp
