<#
	Assign all files in directory to $Match, $NotMatch.
	For each object, report version info.
	But only those that are not 2018.1.
	Sort by FileVersion and FileName.
	$Match = FileVersions containing '2018'
	$NotMatch = File Versions not containing '2018'
#>


C:
cd C:\HeavyBid\BIN
$Match,$NotMatch = (dir *.exe | 
%{ $_.VersionInfo } | 
Where-Object {$_.FileVersion -NotMatch "^2018.1"} | 
Sort-Object FileVersion, FileName   ).Where({$_.FileVersion -like '2018*'},'Split')
@($Match,$NotMatch) > V:\alex.kwie\Script\Reports\oldExeServer.txt
