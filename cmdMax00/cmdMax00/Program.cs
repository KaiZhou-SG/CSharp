using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdMax00
{
    /// <summary>
    /// 2014-11-29 Zhou Kai writes this program to test the Max function to an IEnumable object
    /// </summary>
    public class Program
    {
        internal static void Main(string[] args)
        {
            List<int> lstInt = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<string> lstString = new List<string> { "abc", "abd", "bcc", "bbc", "abcd", "TheUK" };

            Program p = new Program();
            compareStringLength cs = new compareStringLength();
            
            Console.WriteLine("Max int: " + lstInt.Max(x=>x));
            Console.Write("String with max length: " +
                lstString.First(x=>x.Length == lstString.Max(y=>y.Length)));
            Console.WriteLine(", and its length is: " + lstString.Max(x => x.Length));

            Console.Read();
        }

    }

    public class compareStringLength : IComparable<string>
    {
        protected string currentString;
        public int CompareTo(string comparedTo)
        {
            if (comparedTo == null) { return -1; }
            if (this.currentString.Length < comparedTo.Length) { return -1; }
            else if (currentString.Length == comparedTo.Length) { return 0; }
            else { return 1; }
        }

    }
}
