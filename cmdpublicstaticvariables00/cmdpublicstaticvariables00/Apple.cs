using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdPublicStaticVariables00
{
    internal class Apple
    {
        public static string static_msg = "Hello, C# world!";
        public const string const_msg = "Hello, Dot NET Framework!";

        public Apple()
        {
            Console.Write("I'm constructed.");
        }
    }
}
