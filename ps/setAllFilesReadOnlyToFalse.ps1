<# 
 2014-06-29 Zhou Kai writes this script to
 set all the sub-directories and their files' ReadOnly property
 to fasle under the same directory of this script.

 Design:
 (1) get the current directory
 (2) get all items under the current directory
 (3) set every item ReadOnly property value to false
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

$dirRoot = Get-ScriptDirectory  
$lstItems = Get-ChildItem -Recurse | Where-Object {!$_.PSIsContainer}

foreach ($item in $lstItems)
{
  Set-ItemProperty -path $item.FullName -Name IsReadOnly -Value $false
  #$item.FullName 
}