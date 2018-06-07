<#
	Compare the contents of both folders.
	Reports the Name, LastWriteTime, and FileSize of different files.
	If file is listed twice, that means the content is different.
	If it is listed once that means it doesn't exist in the other. 
#>

$hb18bin = Get-ChildItem -path C:\HeavyBid\BIN\ -Recurse 
$hbWSbin = Get-ChildItem -path C:\HeavyBidWS\BIN\ -Recurse 
if (diff $hb18bin $hbWSbin){
Compare-Object $hb18bin $hbWSbin -PassThru -Property Name, Length | 
  Sort-Object Name | 
    Format-Table FullName, LastWriteTime, Length > V:\alex.kwie\Script\Reports\WSdifference.txt
}
else 
{
"There are no differences between the server and workstation BIN folders!" > V:\alex.kwie\Script\Reports\WSdifference.txt
}