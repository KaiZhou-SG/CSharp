﻿<# 
  2014-04-29 Zhou Kai writes this script to test
  the variable scope of powershell

  don't define global variables in this edition
#>

Function add ($num1, $num2)
{
  $sum = $num1 + $num2
  'print inside the function ' + $sum # print the $sum, can print 30
  $num1
  $num2
  $sum
}

# invoke the defined function add
add 10 20
'print outside the function' + $sum # try printing the $sum here, ignored
$sum #ignored, no output
$num1 #igonred, no output
$num2 #igonred, no output

<#
  Conclusion: the parameter scope of a function is within the 
  function body
#>



