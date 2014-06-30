using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdLambda00
{
    public class Program
    {
        internal static void Main(string[] args)
        {
            Company cpny = new Company();

            cpny.PrintSqr(11);
            Console.ReadKey();
        }
    }
}
