# a function with a return value

param([int] $num1, [int] $num2)

Function Add([int] $num1, [int] $num2)
{
  return $num1 + $num2
}

$result = Add 1 2
'result = ' + $result

