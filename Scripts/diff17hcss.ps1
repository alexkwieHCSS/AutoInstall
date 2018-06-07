<#
	Compares what files are in each folder.
	.SideIndicator is replaced with text for readability. 
	.SideIndicator is default => or <=
#>

$hb18hcss = Get-ChildItem -Recurse -path C:\HeavyBid\HCSS
$hb17hcss = Get-ChildItem -Recurse -path C:\HeavyBid2017\HCSS
if (diff $hb18hcss $hb17hcss ){
(Compare-Object -ReferenceObject $hb18hcss -DifferenceObject $hb17hcss |
    ForEach-Object {
        $_.SideIndicator = $_.SideIndicator -replace '=>','Not in 18' -replace '<=','Not in 17'
        $_
    } > V:\alex.kwie\Script\Reports\HCSSdiff.txt )
}
else 
{
"There are no differences between HB\HCSS and HB17\HCSS" > V:\alex.kwie\Script\Reports\HCSSdiff.txt 
}