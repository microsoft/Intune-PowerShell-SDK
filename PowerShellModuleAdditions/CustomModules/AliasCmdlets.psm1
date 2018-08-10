function Set-MSGraphAlias {
    [CmdletBinding()]
    param (
        [Parameter()]
        [ValidateNotNullOrEmpty()]
        [string]$Module = 'Intune',

        [Parameter()]
        [switch]$PassThru
    )

    $newcmds = Get-Command -Module $Module | ForEach-Object {@{
        Name = $_.Name
        Verb = $_.Verb
        Noun = $_.Noun
        NewNoun = $_.Noun
    }}
    $rep = [Ordered]@{
        ManagedDeviceMobileApp = "MDMA"
        ManagedAppRegistrations = "MAR"
        MediaContentRating = "MCR"
        DeviceCompliancePolicies = "DCP"
        DeviceCompliancePolicy = "DCP"
        DeviceAppManagement ="DAM"
        DeviceManagement = "DM"
        ManagedDevs = "MgDev"
        Status = "Stat"
        Device = "Dev"
        Configuration = "Cfg"
        Managed = "Mgd"
        Management = "Mgt"
        Compliance = "Cmp"
        Targeted = "Tgt"
        Target = "Tgt"
        Windows = "Win"
        TermsAndConditions = "TnC"
        Information = "Info"
        OperatingSystem = "OS"
        Object = "Obj"
        Protections = "Prot"
        Protection = "Prot"
        Policies = "Pol"
        Message  = "Msg"
        Template = "Tpl"
        Registrations = "Reg"
        Operations = "Op"
        Summaries = "Sum"
        Summary = "Sum"
        Default = "Def"
        Reference = "Ref"
        Security = "Sec"
        Availability = "Avail"
        Deployment = "Dep"
        Categories = "Cat"
        Mobile = "Mob"
        Scheduled = "Sched"
        Actions = "Act"
        Events = "Evt"
        Definitions = "Dfn"
        Software = "SW"
        Notification = "Notif"
        Connectors = "Conn"
        Workbook = "Wbk"
    }
    foreach ($c in $newcmds) {
        $c.newNoun = $c.Noun
        foreach ($k in $rep.Keys)
        {
            if ($c.Noun -match $k)
            {
                $c.NewNoun = $c.NewNoun -replace $k, $rep.$k
            }
        }
    }

    # Set aliases
    $newcmds | ForEach-Object {
        $oldName = $_.Name
        $newName = "$($_.Verb)-$($_.NewNoun)"

        Set-Alias -Name $newName -Value $oldName -Scope Global

        if ($PassThru) {
            $info = [PSCustomObject]@{
                Command = $oldName
                Alias = $newName
            }
            Write-Output $info
        }
    }
}