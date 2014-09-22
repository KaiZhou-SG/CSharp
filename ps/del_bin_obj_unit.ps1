$dirCurrent = 'D:\worklog\static\fm85_20140922'
$lstItems = Get-ChildItem -Path $dirCurrent -Recurse | 
                          Where-Object {$_.PSIsContainer}
# $lstItems # for testing

foreach ($dirSubDir in $lstItems)
{
  $dirSubDir # for testing
  if ($dirSubDir.Name -eq 'bin' -or
      $dirSubDir.Name -eq 'obj') 
  {
    rd -Recurse $dirSubDir.FullName
  }
}