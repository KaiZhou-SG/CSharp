using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdRound
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal deValue = 1.12345m;
            double doValue = 1.12345d;

            Console.WriteLine("Original: {0}, Round (x) = {1}, Round(x, 1) = {2}," + 
                              " Round(x, 2) = {3}, Round(x, 3) = {4}.", deValue, Math.Round(deValue), Math.Round(deValue, 1),
                              Math.Round(deValue, 2), Math.Round(deValue, 3));
            Console.WriteLine("Original: {0}, Round (x) = {1}, Round(x, 1) = {2}," +
                              " Round(x, 2) = {3}, Round(x, 3) = {4}.", doValue, Math.Round(doValue), Math.Round(doValue, 1),
                              Math.Round(doValue, 2), Math.Round(doValue, 3));
            Console.Read();
        }

    }
}
