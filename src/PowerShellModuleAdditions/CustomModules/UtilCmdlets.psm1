[System.Diagnostics.CodeAnalysis.SuppressMessageAttribute('PSUseSingularNouns', '', Scope='Function', Target='Get-MSGraphAllPages')]
param()

function Get-MSGraphDebugInfo {
    $myErrors = Get-AllErrorsDebugInfo
    if ($myErrors.Count -eq 0) {
        Write-Information 'No errors found'
    } elseif (($null -eq $myErrors[0]) -or ('' -eq $myErrors[0])) {
        Write-Warning 'No debugging information found for the most recent error'
    } else {
        $myErrors[0] | Write-Output
    }
}

function Get-MSGraphAllPages {
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
            $page = Get-MSGraphNextPage -NextLink $currentNextLink
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