# 2014-05-04 Zhou Kai writes this program to 
# create the new back up program name from the latest back up file name
# example, the latest back up file name is abc05.exe, 
# the new back up file name will be abc06.exe
# p.s. assume the file real name is abc

Function getNewFileNameFromLatestBkUpFileName
{
  param([string] $latestBkUpProgramName,  [string] $programRealName, [string] $newProgramName)

  $realName = $programRealName.Substring(0, $programRealName.IndexOf('.')) #exclude extension
  $lenRealName = $realName.Length
  $lenExtension = $programRealName.Length - $realName.Length - 1
  $formatName = $programRealName.Substring($realName.Length + 1, $lenExtension)
  $seqName = $latestBkUpProgramName.Substring($lenRealName, $latestBkUpProgramName.Length - $lenRealName - $lenExtension - 1)

  $newProgramName = $realName + ([int]$seqName + 1).ToString() + '.' + $formatName
  
}

# unit testing
getNewFileNameFromLatestBkUpFileName 'abc05.exe' 'abc.exe' 'x'