using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdNull00
{
    /// <summary>
    /// 2014-07-01 Zhou Kai writes this program to 
    /// test the executing order of a || statement
    /// </summary>
    public class Program
    {
        internal static void Main(string[] args)
        {
            Program nullvar = null;
            int num1 = 2, num2 = 1;
            if (num1 > num2 || nullvar.ToString().Equals("XYZ"))
            {
                Console.WriteLine("No null exception will occur, because the nullvar.ToString() is not executed.");
            }

            Console.ReadKey();
        }
    }
}
