<#
	Compare the contents of both folders.
	Reports the Name, LastWriteTime, and FileSize of different files.
	If file is listed twice, that means the content is different.
	If it is listed once that means it doesn't exist in the other. 
#>

$hbBin = Get-ChildItem -path C:\HeavyBid\BIN\ -Recurse 
$hbWSbin = Get-ChildItem -path C:\HeavyBidWS\BIN\ -Recurse 
if (diff $hbBin $hbWSbin){
Compare-Object $hbBin $hbWSbin -PassThru -Property Name, Length | 
  Sort-Object Name | 
    Format-Table FullName, LastWriteTime, Length > W:\HBDaily\InstallAutomation\Script\Reports\DiffBetweenServWsBIN.txt
}
else 
{
"There are no differences between the server and workstation BIN folders!" > W:\HBDaily\InstallAutomation\Script\Reports\DiffBetweenServWsBIN.txt
}