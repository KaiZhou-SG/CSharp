<#
  2014-05-21 Zhou Kai writes this script.
  Requirements:
    Update the source files under current folder($dirCurrent) to those from CVS($dirTarget), after
	this updating, the status of $dirCurrent equals to $dirTarget 
  Specifications:
    (1) The current directory, $dirCurrent is the current working directory(where this script is put)
    (2) The directory of the copy synchronized with CVS, $dirTarget is keyed in by the user
    (3) The source code files are those of .cs, .resx, .xcs, .xsd, .xss and .rdlc formats
    (4) The source code files under $dirCurrent are to be updated to those under $dirTarget
    (5) If there're files under $dirTarget but not $dirCurrent, copy them from $dirTarget to $dirCurrent
    (6) If there're files under $dirCurrent but not $dirTarget, do nothing
    (7) If any error occurs during the operation, print them out
  Design:
    (1) Loop through all the directories and sub-directories of $dirTarget
    (2) In the loop, if a source code file is found, record its full path as $dirTargetItem
    (3) Based on $dirTarget, $dirTargetItem and $dirCurrent, generate the $dirCurrentItem(This step is the most difficult)
    (4) Following step (3), copy $dirTargetItem and paste to $dirCurrentItem
    (5) print error message if any error occurs
#>

# the path of the target codes
$dirTarget = Read-Host 'Please input the direction where the latest source codes are'

#get the full path of the .ps1 file
Function Get-ScriptDirectory
{
    $Invocation = (Get-Variable MyInvocation -Scope 1).Value;
    if($Invocation.PSScriptRoot)
    {
        $Invocation.PSScriptRoot;
    }
    Elseif($Invocation.MyCommand.Path)
    {
        Split-Path $Invocation.MyCommand.Path
    }
    else
    {
        $Invocation.InvocationName.Substring(0,$Invocation.InvocationName.LastIndexOf("\"));
    }
}
$dirCurrent = Get-ScriptDirectory

# all the valid file formats seeing as a source code file
$SourceCodeFormats = 'cs', 'resx', 'xcs', 'xsd', 'xss', 'rdlc'

# function to check if a file is a source code file
function IsSourceCode
{
  param([string] $fileName)
  # get the file format name
  $fileFormatName = $fileName.Substring($fileName.LastIndexOf('.') + 1, $fileName.Length - $fileName.LastIndexOf('.') - 1)
  foreach($tmp in $SourceCodeFormats)
  {
    if ($tmp.Equals($fileFormatName))
    {
      return $true
    }
  }

  return $false
}

#get the item path under $dirCurrent corresponding to the item under $dirTarget
#input: $dirTargetItem, the full path of the item under $dirTarget
#output: $dirCurrentItem, the full path of the item under $dirCurrent
function GetCurrentItemFullPath
{
  param([string] $dirTargetItem)

  return ($dirCurrent + $dirTargetItem.Substring($dirTarget.Length, $dirTargetItem.Length - $dirTarget.Length))
}

# the real logic begins here:
# loop through all $dirTarget files and replace the source files in the current path
foreach ($targetItem in Get-ChildItem -Recurse $dirTarget | select FullName)
{
  if (IsSourceCode $targetItem.FullName)
  {
    $dirCurrentItem = GetCurrentItemFullPath $targetItem.FullName
    $dirCurrentItem = $dirCurrentItem.Substring(0, $dirCurrentItem.LastIndexOf('\'))

    if (!(Test-Path $dirCurrentItem)) {New-item -ItemType directory -Path $dirCurrentItem}
    Copy-Item -Recurse -Force  $targetItem.FullName $dirCurrentItem

    $targetItem.FullName + ' moved to ' + $dirCurrentItem
  }
} 

'All succeeded'