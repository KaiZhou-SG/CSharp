<#
  2014-05-21 Zhou Kai writes this script.
  Requirements:
    Update the source files in the current folder to those from TeamCoherence
  Specifications:
    (1) The current directory, $dirCurrent is known (.\)
    (2) The directory of the copy synchronized with TC, $dirSource is known (C:\FreightMaster80\Standard\Transport85)
    (3) The source code files are those of .cs, .resx, .xcs, .xsd, .xss and .rdlc formats
    (4) The source code files under $dirCurrent are to be updated with those under $dirSource
    (5) If there're files under $dirSource but not $dirCurrent, copy them from $dirSource to $dirCurrent
    (6) If there're files under $dirCurrent but not $dirSource, do nothing
    (7) If any error occurs during the operation, print them out
  Design:
    (1) Loop through all the directories and sub-directories of $dirSource
    (2) In the loop, if a source code file with the is found, record its full path as $dirSourceItem
    (3) Based on $dirSourceItem and $dirCurrent, generate the $dirCurrentItem, which 
    (4) Following step (3), copy dir_FM83\subDir\foundFile.cs and paste to dir_CurrentDir\subDir\foundFile.cs
    (5) print error message if any error occurs
#>

# the path of the FM83 version
$fm83_path = 'C:\FreightMaster80\Standard\Transport83'

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

# get the current full path from the fm83 full path
function GetCurrentFullPath
{
  param([string] $FM83_found_path)


  # get the path part after "C:\FreightMaster80\Standard\Transport83"
  return $FM83_found_path.Substring($fm83_path.Length, $FM83_found_path.Length - $fm83_path.Length)
}

# loop through all FM83 files and replace the source files in the current path