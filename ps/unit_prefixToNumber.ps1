#unit test

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

$prefix1 = '001'
$prefix2 = '010'
$prefix3 = '100'

PrefixToNumber $prefix1
PrefixToNumber $prefix2
PrefixToNumber $prefix3