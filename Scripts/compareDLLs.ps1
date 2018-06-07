<#
	Compares what files are in each folder.
	.SideIndicator is replaced with text for readability. 
	.SideIndicator is default => or <=
#>


$currentDLL = Get-ChildItem -Recurse -path "C:\Program Files (x86)\Common Files\HCSS"
$masterListDLL = Get-ChildItem -Recurse -path V:\alex.kwie\AutoInstallOCXDLL
if (diff $currentDLL $masterListDLL)
{
(Compare-Object -ReferenceObject $currentDLL -DifferenceObject $masterListDLL |
    ForEach-Object {
        $_.SideIndicator = $_.SideIndicator -replace '=>','Not in Prog Files' -replace '<=','Not in master list'
        $_ 
  } > V:\alex.kwie\Script\Reports\dllComparison.txt )
}
else 
{
"There are no missing or extra DLL / OCX !" > V:\alex.kwie\Script\Reports\dllComparison.txt
}