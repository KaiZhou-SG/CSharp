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

$num1 = 1
$num2 = 10
$num3 = 110

NumberToPerfix $num1
NumberToPerfix $num2
NumberToPerfix $num3
