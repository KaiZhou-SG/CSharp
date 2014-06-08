#unit test

function Get-Prefix
{
  param([string] $filename)

  $filename.Substring(0, 3)
}

$filename = '001TheEnglishWeSpeak'

Get-Prefix $filename