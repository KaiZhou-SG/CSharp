<#
2014-06-01 Zhou Kai writes this script.
Use case:
(1) I have two folders A and B
(2) A has all .mp3 files and keeps adding from iTunes, B is empty at first
(3) I cut all .mp3 files I'm going to listen to from A into B
(4) I add a sequence number as a prefix of the files in B. e.g. 01TheEnglishWeSpeak20140530.mp3, 02TheEnglishWeSpeak20140531.mp3...
(5) Then when I finished listening to the files in B, I'll cut some files from A again
(6) When I paste the cut files in step (5), I want the sequence numbers to continue from the largest of the existing files in B
(7) As there're more than 100 files, so the format of the sequence number should be: 001, 010, 101...   
(8) Modify the file names in A is not considered, because iTunes will look into A and depends on the file names in A

Requirement analysis:
(1) Do not modify the file names in A
(2) A keeps growing as iTunes will download files to A
(3) B is empty at beginning, but it keeps growing while cutting files from A and paste them into B
(4) After pasting files into B, add a sequence number as the prefix, and the sequence number is also growing ascendly
(5) As there're more then 100 files, so the sequence number has and only has 3digits; e.g. 001, 010, 111 
(6) This script will put immediately under A
(7) When cutting files from A:
    (7.1) prompt the user how many files(N) are going to be transfered to B
    (7.2) sort all the files by "Date Modified" descendly
    (7.3) get file names(NAMESA) of the top N files
    (7.4) navigate to B, 
      (7.4.1) if there're files in B
        (7.4.1.1) sort all files by "Name" descendly
        (7.4.1.2) get the top 1 file "Name" and then get its prefix(PRE)  
        (7.4.1.3) cut the files in NAMESA and paste them one by one
        (7.4.1.4) the first one to paste has a prefix of PRE+1, the second has PRE+2... and so on
        (7.4.1.5) print success information
      (7.4.2) if there're no files in B
        (7.4.2.1) cut the files in NAMESA and paste them one by one
        (7.4.2.2) the first one to paste has a prefix of 001, the second has 002... and so on
        (7.4.2.3) print success information

Specifications:
(1) Put this script immediately under the folder where the target .mp3 files are
(2) Get the directory of this script, $dir_root
(3) Prompt the user to input the dir of listened files, $dir_listened
(4) Prompt the user to input the quantity of files (s)he wants to transfer, $file_count
(5) Test if $dir_root and $dir_listened exist, if either is false, show error message and return
(6) Test if $dir_root has more than $file_count files excludes the folder $dir_listened(if it's under $file_count)
(7) If (6) is false, show error message and return
(8) Sort the files by "Modified Date" descendly, and get the top $file_count file full names, $names_in_root
(9) Navigate to $dir_listened
      (9.1) if there're files in $dir_listened
        (9.1.1) sort all files by "Name" descendly
        (9.1.2) get the top 1 file "Name" and then get its prefix($pre_max_listened)  
        (9.1.3) cut the files in $names_in_root and paste them one by one
        (9.1.4) the first one to paste has a prefix of $pre_max_listened + 1, 
        the second has $pre_max_listened + 2... and so on
        (9.1.5) print success information
      (9.2) if there're no files in $dir_listened
        (9.2.1) cut the files in $names_in_root and paste them one by one
        (9.2.2) the first one to paste has a prefix of 001, the second has 002... and so on
        (9.2.3) print success information 
(10) Write a function GetPrefix, input a file name, output the 3-digit prefix
(11) Write a function PrefixToNumber, input the 3-digit string prefix, output a number without left-hand 0
(12) Write a function NumberToPrefix, input a number, output a 3-digit string prefix
(13) Write a function to get current directory
#>

#define global variables
$dir_root 
$dir_listened
$file_count
$file_names_in_root
$file_names_in_listened 
$num_max_listened 

function Get-ScriptDirectory
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

function Get-Prefix
{
  param([string] $filename)

  $filename.Substring(0, 3)
}

function PrefixToNumber
{
  param([string] $prefix)

  $index = 0 
  foreach ($the_digit in $prefix.ToCharArray())
  {
    if ($the_digit -eq '0')
    {
      $index = $index + 1
    }
    else 
    {
      break
    }
  }

  $num = $prefix.Substring($index, 3 - $index)
  $num # the return value
}

function NumberToPerfix
{
  param([int] $num)


  $prefix
  if ($num -lt 10) # 1 digit
  {
    $prefix = '00' + $num.ToString()
  }

  if ($num -lt 100 -and $num -gt 9) # 2 digits
  {
    $prefix = '0' + $num.ToString()
  }

  if ($num -gt 99) # 3 digits
  {
    $prefix = $num.ToString()
  }

  $prefix
}

function Test-Dirs
{
  param([string] $dir_root, [string] $dir_listened)

  $flag = $true

  if (!((Test-Path $dir_root) -and (Test-Path $dir_listened)))
  {
    $flag = $false
  }

  $flag 
}


# logic from here
$dir_root = Get-ScriptDirectory
$dir_listened = $dir_root + '\listened'

if (!(Test-Dirs $dir_root $dir_listened))
{
  $dir_root + ' or ' + $dir_listened + ' does not exist, please recheck.'
}
else
{
  $file_count = Read-Host 'How many files to copy?'
  $file_all_count = (Get-ChildItem $dir_root).Count 
  if ($file_all_count -lt $file_count)
  {
    'There''re not so many files in ' + $dir_root
  }
  else 
  {
    $file_names_in_root = 
    Get-ChildItem $dir_root -Exclude @('*.ps1', 'Listened') | 
                  Sort-Object LastWriteTime -Descending | 
                  Select-Object -First $file_count  

    if ((Get-ChildItem $dir_listened) -eq 0)
    {
      $num_max_listened = 0
    }
    else 
    {
      $latest_name_listened = Get-ChildItem $dir_listened |
                                Sort-Object Name -Descending |
                                Select-Object -First 1
      $latest_prefix_listened = Get-Prefix $latest_name_listened
      $num_max_listened = PrefixToNumber $latest_prefix_listened
    }

    foreach ($file_name in $file_names_in_root)
    {
      $num_max_listened = [int]$num_max_listened + 1
      $pre_tmp_string = NumberToPerfix $num_max_listened 
      $file_name = $file_name.Name
      
      Move-Item ($dir_root + '\' + $file_name) ($dir_listened + '\' + $pre_tmp_string + $file_name)
                
    }
  }
  
}




# logic ends
