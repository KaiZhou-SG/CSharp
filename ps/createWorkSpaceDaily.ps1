<#
Create a workspace(a folder) every day when turning the PC on.
The workspace name relies on the date. For example,
if it's 2013-09-19 today, then the workspace name is "2013-09-19" .
If that workspace folder already exists, prompt it's ALREADY
THERE; otherwise, prompt that the workspace IS CREATED.
#>

# Get the workSpace name from Get-Date
$workSpaceName = Get-Date -Format "yyyy-MM-dd"
$workSpaceFullName = "D:\workLog\" + $workSpaceName

# Test if workSpace already exists
if(!(Test-Path D:\workLog))
{
  New-Item -Path D:\workLog -ItemType Directory
}

if (Test-Path $workSpaceFullName)
{
  "**********************************************************"
           $workSpaceFullName + " already exists."
  "**********************************************************"
}
else
{
  New-Item -Path "D:\workLog" -ItemType Directory -Name $workSpaceName

  "**********************************************************"
  "workSpace " + $workSpaceFullName + " is created for you"
  "have a good day~!"
  "**********************************************************"
}

# Create a ToDo.txt with default values, under the current workSpace
# Notice that in Powershell, `n means new-line in a string,
# but when writing to a txt file, `r`n is to change to a new-line
if (Test-Path $workSpaceFullName + "\ToDo.txt")
{
  "**************************************************************"
          $workSpaceFullName + "\ToDo.txt is already created."
  "**************************************************************"
}
else
{
    $default_value = "1. Get the latest codes from TC `r`n2. Make sure the codes can compile"
    New-Item -Path $workSpaceFullName -ItemType "file" -Name "ToDos.txt" -Value $default_value
}

# Pop up the workspace 
Explorer.exe $workSpaceFullName
#Explorer.exe D:\eBooks
#Open the home directory
Explorer.exe ~
Explorer.exe C:\FreightMaster80\
# execute firefox internet browser.
Start "C:\Program Files (x86)\Mozilla Firefox\Firefox.exe"