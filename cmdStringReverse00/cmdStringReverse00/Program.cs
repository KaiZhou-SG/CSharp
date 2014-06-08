using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdStringReverse00
{
    public class Program
    {
        internal static void Main(string[] args)
        {
            StringFactory sf = new StringFactory();

            sf.SayReverse();

            Console.ReadKey();
        }
    }
}
