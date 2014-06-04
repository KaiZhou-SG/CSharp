using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdRealNumber00
{
    /// <summary>
    /// 2014-05-21 Zhou Kai writes this program to learn and practice the
    /// concpet of real-numbers in C#.
    /// There 3 types in C# to represent a real-number in real world.
    /// float -- suffix 'f' or 'F'
    /// double -- suffix 'd' or 'D', it's the default type for a real-number
    /// decimal -- suffix 'm' or 'M', it's a 128-bit data type. It has more precision and a smaller range, which makes it appropriate
    /// for financial and monetary calculations.
    /// </summary>
    public class Program
    {
        internal static void Main(string[] args)
        {
            float f1 = 0.111111f; // suffix with 'f'
            float f2 = 0.22222F; // suffix with 'F', it's also OK
            double d1 = 0.33333d; // suffix with 'd'
            double d2 = 0.44444D; // suffix with 'D'
            decimal dm1 = 0.55555m; // suffix with 'm'
            decimal dm2 = 0.66666M; // suffix with 'M'

            Console.WriteLine("{0}", f1);
            Console.WriteLine("{0:F1}", f2);
            Console.WriteLine("{0:F2}", d1);
            Console.WriteLine("{0:F3}", d2);
            Console.WriteLine("{0:E2}", dm1); // output currency format specifier
            Console.WriteLine("{0:C3}", dm2);

            Console.ReadKey();
        }
    }
}
