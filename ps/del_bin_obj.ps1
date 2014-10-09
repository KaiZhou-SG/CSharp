<#
 2014-09-22 Zhou Kai writes this script to delete all bin, obj folders under 
 the folder where this script is put.

 1) get the full path of the script
 2) loop through all sub directories
   2.1) if the sub-dir is bin or obj, delete it

#>

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
$lstItems = Get-ChildItem -Path $dirCurrent -Recurse | 
                          Where-Object {$_.PSIsContainer}

foreach ($dirSubDir in $lstItems)
{
  $dirSubDir.Name
  if ($dirSubDir.Name -eq 'bin' -or
      $dirSubDir.Name -eq 'obj') 
  {
    $dirSubDir
    rd -Recurse $dirSubDir
  }
}
  

