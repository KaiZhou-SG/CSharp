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
        $Invocation.InvocationName.Substring(0,$Invocation.InvocationName.LastIndexOf('\'));
    }
}

Function bkUpExistingPrograms([string[]] $newProgramNames)
{
  $current_dir = Get-ScriptDirectory
  foreach ($pgmToBkup in $newProgramNames)
  {
    $tmp = $existings = ls $current_dir | Where-Object{$_.Name -like $pgmToBkup.Substring(0,$pgmToBkup.IndexOf('.'))  + '.*'} #first index of .
    return $existings | Sort-Object -Descending
  }
}

bkUpExistingPrograms fuc00.ps1,fuc01.ps1