param([string] $pathNewProgram, [int] $count)

$pathNewProgram = Read-Host 'Please input the path here'

Function CountNewProgram ([string] $pathNewPgm, [int] $count)
{
  if (Test-Path $pathNewPgm)
  {
    $count = (Get-ChildItem $pathNewPgm).Count
    
    if ($count -gt 0)
    {
      'valid'
    }
    else 
    {
      'invalid'
    }
    

    $count
  }
  else 
  {
    'invalid'
  }
}

CountNewProgram $pathNewProgram
'outside, $count: ' + $count
