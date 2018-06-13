function Get-LatestErrorDebugInfo {
    $myErrors = Get-AllErrorsDebugInfo
    if ($myErrors.Count -eq 0) {
        Write-Host 'No errors found'
    } elseif (($myErrors[0] -eq $null) -or ($myErrors[0] -eq '')) {
        Write-Warning 'No debugging information found for the most recent error'
    } else {
        $myErrors[0] | Write-Output
    }
}

function Get-AllErrorsDebugInfo {
    # If there are any errors that have not set a TargetObject, make sure to return some default object instead of null.
    # This will ensure that the index of the debug info returned will match up with the same entry in the global $error variable.
    $errorTargetObjects = $global:error | ForEach-Object {
        if ($_.TargetObject -ne $null) {
            $_.TargetObject
        } else {
            ''
        }
    }

    $errorTargetObjects | Write-Output
}

function Get-AllPages {
    [CmdletBinding(
        ConfirmImpact = 'Medium',
        DefaultParameterSetName = 'SearchResult'
    )]
    param (
        [Parameter(Mandatory = $true, ParameterSetName = 'NextLink', ValueFromPipelineByPropertyName = $true)]
        [ValidateNotNullOrEmpty()]
        [Alias('@odata.nextLink')]
        [string]$NextLink,

        [Parameter(Mandatory = $true, ParameterSetName = 'SearchResult', ValueFromPipeline = $true)]
        [ValidateNotNull()]
        [PSObject]$SearchResult
    )

    if ($PSCmdlet.ParameterSetName -eq 'SearchResult') {
        # Set the current page to the search result provided
        $page = $SearchResult

        # Extract the NextLink
        $currentNextLink = $page.'@odata.nextLink'

        # Output the items in the first page
        $values = $page.value
        if ($values) {
            $values | Write-Output
        }
    }

    while (-Not ([string]::IsNullOrWhiteSpace($currentNextLink)))
    {
        # Make the call to get the next page
        try {
            $page = Get-NextPage -NextLink $currentNextLink
        } catch {
            throw
        }

        # Extract the NextLink
        $currentNextLink = $page.'@odata.nextLink'

        # Output the items in the page
        $values = $page.value
        if ($values) {
            $values | Write-Output
        }
    }
}