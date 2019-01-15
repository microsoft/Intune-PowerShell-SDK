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
    $sdkCmdletInfo | add-member -membertype NoteProperty -name "Name-Length" -value $sdkCmdletHelp.Name.Length
    $sdkCmdletInfo | add-member -membertype NoteProperty -name "Synopsis" -value $sdkCmdletHelp.Synopsis    
    if ($sdkCmdletHelp.Description)
    {     
        $description = ""
        foreach($descriptionLine in $sdkCmdletHelp.Description)
        {
            $description += $descriptionLine.Text.replace("`n"," ").replace("`r"," ")
        }
        $sdkCmdletInfo | add-member -membertype NoteProperty -name "Description" -value $description
    }
    else
    {
        $sdkCmdletInfo | add-member -membertype NoteProperty -name "Description" -value ""
    }    
    $sdkCmdletsList+=$sdkCmdletInfo
}

$sdkCmdletsList | Export-Csv -Path "$OutputDirectory\$ModuleName.cmdlets.csv" -NoTypeInformation
popd