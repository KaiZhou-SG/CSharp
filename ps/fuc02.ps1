param([double] $num1, [double] $num2)

Function AddDouble([double] $num1, [double] $num2)
{
  $num1 + $num2

  'inside $num1: ' + $num1
  'inside $num2: ' + $num2
}

AddDouble 1.1 2.2
'outside $num1: ' + $num1
'outside $num2: ' + $num2