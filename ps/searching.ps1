$matched
$pathNewProgram = Read-Host 'please provide the path for the new programs'

Function getAllNamesOfNewPrograms($pathNewProgram)
{
  return Get-ChildItem $pathNewProgram
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
    if (!(Test-Path .\$name))
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


'fuc 2' 
$newPrograms = getAllNamesOfNewPrograms $pathNewProgram
'fuc 3 ' + $newPgmNames
$matched = lookForExistingPrograms $newPrograms

'fuc 4'
if ($matched)
{
  'matched'
}
else 
{
  'doesn''t match'
}
