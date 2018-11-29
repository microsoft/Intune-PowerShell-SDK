param(
    [Parameter(Mandatory = $false)]
    [ValidateNotNullOrEmpty()]
    [string]$ModuleName="$env:moduleName",

    [Parameter(Mandatory = $false)]
    [ValidateNotNullOrEmpty()]
    [string]$OutputDirectory="$env:sdkDir",

    [Parameter(Mandatory = $false)]
    [ValidateNotNullOrEmpty()]
    [switch]$IsFullOutput=$false
)

$OutputDirectory = $OutputDirectory | Resolve-Path
$modulePath = "$OutputDirectory\$ModuleName.psd1"

Push-Location $OutputDirectory

Import-Module $modulePath
$sdkCmdlets = ((Get-Command -Module Microsoft.Graph.Intune).Name | Sort-Object)
$cmdletCount = $sdkCmdlets.Count
Write-Host "$cmdletCount Intune specific cmdlets exported by $modulePath"

$sdkCmdletsList = @()
foreach ($sdkCmdlet in $sdkCmdlets)
{    
    $sdkCmdletHelp = (Get-Help $sdkCmdlet)
    $sdkCmdletInfo = new-object PSObject
    $sdkCmdletInfo | add-member -membertype NoteProperty -name "Name" -value $sdkCmdletHelp.Name
    $sdkCmdletInfo | add-member -membertype NoteProperty -name "Synopsis" -value $sdkCmdletHelp.Synopsis    
    if ($sdkCmdletHelp.Description)
    {        
        $sdkCmdletInfo | add-member -membertype NoteProperty -name "Graph-route" -value $sdkCmdletHelp.Description[0].Text.replace("`n","").replace("`r","") 
    }
    else
    {
        $sdkCmdletInfo | add-member -membertype NoteProperty -name "Graph-route" -value ""
    }    
    $sdkCmdletsList+=$sdkCmdletInfo
}

$sdkCmdletsList | Export-Csv -Path "$OutputDirectory\$ModuleName.cmdlets.csv" -NoTypeInformation
popd