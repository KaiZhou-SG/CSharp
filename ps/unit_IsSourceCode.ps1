# all the valid file formats seeing as a source code file
$SourceCodeFormats = 'cs', 'resx', 'xcs', 'xsd', 'xss', 'rdlc'

# function to check if a file is a source code file
function IsSourceCode
{
  param([string] $fileName)
  # get the file format name
  $fileFormatName = $fileName.Substring($fileName.LastIndexOf('.') + 1, $fileName.Length - $fileName.LastIndexOf('.') - 1)
  foreach($tmp in $SourceCodeFormats)
  {
    if ($tmp.Equals($fileFormatName))
    {
      return $true
    }
  }

  return $false
}

$test_path = 'D:\workLog\2014-05-21\test.cs'
IsSourceCode $test_path