using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace cmdComparison00
{
    /// <summary>
    /// 2014-11-28 Zhou Kai creates this class, 
    /// to test the Sort function of the List class.
    /// </summary>
    public class CompareList
    {
        internal static int Compare(int n1, int n2)
        {
            if (n1 > n2) { return 1; }
            else if (n1 == n2) { return 0; }
            else { return -1; }
        }

        internal static int CompareString(string s1, string s2)
        {
            return Compare(s1.Length, s2.Length);
        }

        internal List<int> SortIntList(List<int> lstInt)
        {
            lstInt.Sort(Compare);

            return lstInt;
        }

        internal List<string> SortStringByLength(List<string> lstString)
        {
            lstString.Sort(CompareString);

            return lstString;
        }

    }
}
