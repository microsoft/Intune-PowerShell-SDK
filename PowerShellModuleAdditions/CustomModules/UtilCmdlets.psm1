[System.Diagnostics.CodeAnalysis.SuppressMessageAttribute('PSUseSingularNouns', '', Scope='Function', Target='Get-MSGraphAllPages')]
param()

function Get-MSGraphDebugInfo {
    if ($global:error.Count -eq 0) {
        Write-Information 'No errors found'
    } else {
        $myError = $global:error[0].TargetObject
        if (-not $myError) {
            Write-Warning 'No debugging information found for the most recent error'
        } else {
            $myError | Write-Output
        }
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