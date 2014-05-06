using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdPublicStaticVariables00
{
    class Program
    {
        static void Main(string[] args)
        {
            // You can change the public static value of another class.
            Apple.static_msg = "I want to change the public static string, may I? Yes you can.";
            // You can access but can't chage the public const value of another class.
            // Apple.const_msg = "I want to change the public const string, may I?";
            Console.WriteLine(Apple.static_msg);
            Console.WriteLine(Apple.const_msg + " You can access public const variable of another class," +
                " but you can't change it.");
            Console.Read();
        }
    }
}
