# GetEffectivePermissions
Write-Host "Testing GetEffectivePermissions..."
$permissions = Invoke-DeviceManagement_GetEffectivePermissions -Scope *
if ($permissions.resourceActions.allowedResourceActions[0] -ne '*')
{
    throw "Expected to have admin permissions, but found '$permissions'"
}