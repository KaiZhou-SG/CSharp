function GetCurrentItemFullPath
{
  param([string] $dirTargetItem)


  return ($dirCurrent + $dirTargetItem.Substring($dirTarget.Length, $dirTargetItem.Length - $dirTarget.Length))
}

#test case:

$dirTarget = 'C:\abcd'
$dirCurrent = 'D:\efg'
$dirTargetItem = 'C:\abcd\wxyz\abc.txt'

#expected output:
# 'D:\efg\wxyz\abc.txt'

GetCurrentItemFullPath $dirTargetItem

#unit test passed




