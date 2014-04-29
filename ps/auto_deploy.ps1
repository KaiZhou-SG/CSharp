# 2014-04-29 Zhou Kai writes this script to auto backup and 
# deploy the new programs to the existing folder

# define parameters and global variables
param([string] $pgm_path, [string[]] $newPgmNames)

$pathNewProgram # the path of the new programs
$countNewProgram # the count of the new programs
$continueOrNot = "invalid path, would you like to input the path again?, y / n"
$toContinue # user input
$bIsValid
$bMatch
$countNewProgram
$pathNewProgram = Read-Host 'where''s the new programs'

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
  return Get-ChildItem $pathNewProgram
}


Function lookForExistingPrograms([string[]] $newPgmNames)
{
  foreach ($name in $newPgmNames)
  {
    if (!(Test-Path .\$name))
    {
      $bMatch = $false
      $name + ' not found in current folder'
      return $false
    }
  }

  return $true
}

Function bkUpExistingPrograms([string[]] $newProgramNames)
{
  foreach ($pgmToBkup in $newProgramNames)
  {
    $existings = ls .\ | Where-Object{$_.Name -like $pgmToBkup + '*'}
    $existings | Sort-Object

  }
}

$bIsValid = validateNewProgramPath $pathNewProgram

if ($bIsValid)
{
  $bMatch = lookForExistingPrograms $pathNewProgram
  if ($bMatch)
  {

  }
}




