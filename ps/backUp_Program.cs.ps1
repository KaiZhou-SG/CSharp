<#
2014-05-28 Zhou Kai adds comments:
This program is used in this case:
  In a local copy, for debuging and testing, the Program.cs file
  in each project folder is modified with addtional debuging information.
  But when downloding a whole solution or a whole project folder from 
  TC, the Program.cs is overwritten, thus, the debugging information is lost.
  To keep the debugging information, this script makes a copy of
  the Program.cs file in every project folder, and name it as: Program_ZK.cs.

How to use this script?
  The user needs to put this script to the root folder of the whole solution dictionary,
  in order for it to look for every project folder to back up the Program.cs file.

#>
$subDirs = Get-ChildItem
foreach ($subDir in $subDirs)
{
  if (Test-Path($subDir.ToString()+"\Program.cs"))
  {
	Copy-Item ($subDir.ToString() + "\Program.cs") -Destination ($subDir.ToString() + "\Program_ZK.cs")
  }
}