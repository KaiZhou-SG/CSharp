Function getNewFileNameFromLatestBkUpFileName
{
  param ([string[]] $existings, [string] $pgmToBkUp)

  if ($existings.Count -lt 1)
  {
    'no existing programs like ' + $pgmToBkUp
  }
  elseif ($existings.Count -eq 1)
  {
    $pgmToBkUp # return 
  }
  elseif ($existings.Count -gt 1)
  {

  }
}