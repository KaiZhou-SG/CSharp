using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac000
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAXLENGTH = 5;
            string[] cities = { "Ezhou", "Wuhan", "Jilin", "London" };

            var homeTown =
                from c in cities
                where c.Length > MAXLENGTH
                select c;

            foreach (var s in homeTown)
            {
                Console.WriteLine(s.ToString());
            }

            ////////////////////////////////////////////////////////////////////////////
            int[] ints = { 10, 6, 3, 9, 7, 4, 2, 1, 8 };
            var result = ints.OrderBy(g => g);
            foreach (var i in result)
            {
                System.Console.Write(i + " ");
            }

            Console.Read();
        }
    }
}
