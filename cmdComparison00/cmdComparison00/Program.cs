using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdComparison00
{
    public class Program
    {
        internal static void Main(string[] args)
        {
            CompareList c = new CompareList();
            List<int> lstInt = new List<int> { 1, 4, 2, 5, 2, 9 };
            c.SortIntList(lstInt);

            List<string> lstString = new List<string> { "abc", "bcd", "d", "dddefff", "adafasdfasf", "we" };
            c.SortStringByLength(lstString);

            foreach(int i in lstInt)
            {
                Console.Write(i + ", ");
            }
            
            Console.WriteLine(Environment.NewLine);

            foreach(string s in lstString)
            {
                Console.Write(s + ", ");
            }

            Console.Read();
        }
    }
}
