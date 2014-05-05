param([string[]] $arrList)

Function displayItems([string[]] $list)
{
  foreach ($i in $list)
  {
    'i = ' + $i
  }
}

displayItems 1,2,3,4,5