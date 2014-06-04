# get the current full path from the fm83 full path
function GetCurrentFullPath
{
  param([string] $FM83_found_path)


  # get the path part after "C:\FreightMaster80\Standard\Transport83"
  return $FM83_found_path.Substring($fm83_path.Length, $FM83_found_path.Length - $fm83_path.Length)
}

$fm83_path = 'C:\FreightMaster80\Standard\Transport83'
$FM83_found_path = 'C:\FreightMaster80\Standard\Transport83\abc'

GetCurrentFullPath $FM83_found_path
