# PowerShellModuleAdditions
Allows the generated cmdlets to be augmented with custom hand-crafted cmdlets.

In order to add a new set of PowerShell cmdlets:
1. Add hand-crafted cmdlets to the 'CustomModules' folder in a '.psm1' file
    - Create subfolders to organize these '.psm1' files
2. Add the relative path of the new file as an entry at the bottom of the 'PowerShellGraphSDK.psd1' file in the 'NestedModules' array