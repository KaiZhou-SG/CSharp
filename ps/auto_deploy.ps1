# 2014-04-29 Zhou Kai writes this script to auto backup and 
# deploy the new programs to the existing folder

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
  $tmp = '1 new programs are: ' + $newPgmNames
  if ($newPgmNames.Count -eq 0)
  {
    $matched = $false
    return $matched
  }

  foreach ($name in $newPgmNames)
  {
    $tmp = 'I am in the look to match'
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