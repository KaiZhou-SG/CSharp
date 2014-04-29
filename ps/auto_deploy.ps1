# 2014-04-29 Zhou Kai writes this script to auto backup and 
# deploy the new programs to the existing folder

# define global variables
param([string] $pgm_path)

$pathNewProgram # the path of the new programs
$countNewProgram # the count of the new programs
$continueOrNot = "invalid path, would you like to input the path again?, y / n"
$toContinue # user input
$bIsValid
$countNewProgram
$pathNewProgram = Read-Host 'where''s the new programs'


Function validateNewProgramPath([string] $pgm_path)
{
  if (Test-Path $pgm_path)
  {
    $countNewProgram = (Get-ChildItem 'D:\workLog').Count
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

$bIsValid = validateNewProgramPath $pathNewProgram





