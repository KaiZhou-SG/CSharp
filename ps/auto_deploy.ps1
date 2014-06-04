# 2014-04-29 Zhou Kai writes this script to auto backup and 
# deploy the new programs to the existing folder

<#
2014-05-29 Zhou Kai adds documentations.
Requirements:
  When the programmers want to dispatch a bug fix or update the existing programs, they
  sometimes need to replace the existing programs with a new one.
  But before doing so, it's safer to back up the programs to be replaced first, by renaming 
  it.
  After renaming all the programs those are to be replaced, put all the new programs
  to the folder. And it's done.
  If something wrong, restore to the original status first, by deleting all the new programs 
  and rename back those programs those are renamed before.

Specifications:
  (1) The directory of the existing programs $current_dir is known
  (2) Put this script to $current_dir
  (3) Put all the new programs(with bug fixes or updates) to $pathNewProgram
  (4) Get all file names ($newProgramNames) of the new programs in $pathNewProgram
  (5) Try matching every file name in $newProgramNames to file names in $pathNewProgram
  (6) If some dismatch, prompt recheck, exit program
  (7) If all match, loop through every new programs in $newProgramNames
  (8) If the log.txt does not exist in $current_dir, create it, and write a date-time to it
  (9) For every $newProgram in $newPrograms, find all the files ($foundProgramNames)
  which the file name like $newProgram except the $newProgram has some postfixes
  (10) Sort $foundProgramNames by descending order, and the first element is the 
  latest time the program is re-named to, e.g. example10.exe is the 10th time
  the example.exe is renamed to
  (11) rename example.exe to example11.exe
  (12) copy the new example.exe from $pathNewProgram to $current_dir
  (13) write the operation to log
#>

# define and global variables
$pathNewProgram # the path of the new programs
$countNewProgram # the count of the new programs
$continueOrNot = "invalid path, would you like to input the path again?, y / n"
$toContinue # user input
$bIsValid
$bMatch
$countNewProgram
$pathNewProgram = Read-Host 'where''s the new programs'

function Get-ScriptDirectory
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

$current_dir = Get-ScriptDirectory

Function validateNewProgramPath([string] $pgm_path)
{
  if (Test-Path $pgm_path)
  {
    $countNewProgram = (Get-ChildItem $pgm_path).Count
    if ($countNewProgram -gt 0)
    {
      $bIsValid = $true
    }
    else 
    {
      $bIsValid = $false
    }
  }
  else 
  {
    $bIsValid = $false
  }

  return $bIsValid
}

Function getAllNamesOfNewPrograms($pathNewProgram)
{
  return  Get-ChildItem $pathNewProgram
}

Function lookForExistingPrograms([string[]] $newPgmNames)
{
  if ($newPgmNames.Count -eq 0)
  {
    $matched = $false
    return $matched
  }

  foreach ($name in $newPgmNames)
  {
    if (!(Test-Path $current_dir\$name))
    {
      $bMatch = $false
      $tmp = $name + ' not found in current folder' #tmp is used to absorb unnecessary outputs
      $matched = $false
      return $matched
    }
  }

  $matched = $true
  return $matched
}

Function getNewFileNameFromLatestBkUpFileName
{
  param([string] $latestBkUpProgramName,  [string] $programRealName, [string] $newProgramName)

  $realName = $programRealName.Substring(0, $programRealName.IndexOf('.'))
  $lenRealName = $realName.Length
  $lenExtension = $programRealName.Length - $realName.Length - 1
  $formatName = $programRealName.Substring($realName.Length + 1, $lenExtension)
  $seqName = $latestBkUpProgramName.Substring($lenRealName, $latestBkUpProgramName.Length - $lenRealName - $lenExtension - 1)
  
  $realName + ([int]$seqName + 1).ToString() + '.' + $formatName # the return value
  
}

Function bkUpExistingPrograms
{
  param ([string[]] $newProgramNames)
  
  foreach ($pgmToBkup in $newProgramNames)
  {
    $existings = ls $current_dir | Where-Object{$_.Name -like $pgmToBkup.Substring(0,$pgmToBkup.IndexOf('.'))  + '*'} #first index of .
    $existings = dealWithExistingProgramNames $existings
    if ($existings.Count -gt 1)
    {
      $ordered = $existings | Sort-Object -Descending
      $latestBkUpProgramName = $ordered[0]
      $programRealName = $pgmToBkup
      $newProgramName = ''
      $newProgramName = getNewFileNameFromLatestBkUpFileName $latestBkUpProgramName $programRealName $newProgramName
    }
    else 
    {
      $newProgramName = $pgmToBkup.Insert($pgmToBkup.IndexOf('.'), '1')
    }
    
    
    Rename-Item $current_dir\$pgmToBkup $current_dir\$newProgramName
    $log = $pgmToBkup + ' is renamed to ' + $newProgramName
    $log >> $current_dir\log.txt
  }
}

Function deployNewPrograms
{
  param ([string[]] $newProgramNames)
  $current_dir = Get-ScriptDirectory
  foreach ($pgmToBkup in $newProgramNames)
  {
    Copy-Item $pathNewProgram\$pgmToBkUp $current_dir

    $log = $pathNewProgram + '\' + $pgmToBkup + ' is copied to ' + $current_dir
    $log >> $current_dir\log.txt
  }
}

Function dealWithExistingProgramNames
{
  param ([string[]] $existingProgramNames)

  foreach ($item in $existingProgramNames)
  {
    if ($item.ToString().IndexOf('_') -ne $item.ToString().LastIndexOf('_'))
    {
        $item.ToString().Remove($item.ToString().LastIndexOf('_'), 1)
    }
    if ($item.ToString().IndexOf('_') -gt 2)
    {
        $item.ToString().Remove($item.ToString().LastIndexOf('_'), 1)
    }
    if ($item.ToString().IndexOf('.') -ne $item.ToString().LastIndexOf('.'))
    {
        $item.ToString().Remove($item.ToString().IndexOf('.'), 1)
    }
    $item.ToString().Replace('(', '')
    $item.ToString().Replace(')', '')
  }

  $existingProgramNames
}

#################################################################
# actual logic from here:
$bIsValid = validateNewProgramPath $pathNewProgram

if ($bIsValid)
{
    $newProgramNames = getAllNamesOfNewPrograms $pathNewProgram
    $bMatch = lookForExistingPrograms $newProgramNames
    if ($bMatch)
    {
      if (!(Test-Path $current_dir/log.txt))
      {
        new-item -ItemType file -Path $current_dir/log.txt 
      }
      # write log date 
      $log = "date-time: " + (Get-Date).ToString()
      $log >> $current_dir\log.txt
      bkUpExistingPrograms $newProgramNames
      deployNewPrograms $newProgramNames
    }
    else 
    {
      'Some of the new programs you provided do not exist in the current folder'
      'Are you going to add new programs to the current folder?'
      'If true, please copy the new programs to the current folder manually'
      'program exit'
    }
}
else 
{
  'Please check the path of the new programs'
}
# logic ends
##################################################################