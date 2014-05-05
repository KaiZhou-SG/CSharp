using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdPra00
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = new int();
            int n2 = new int();

            n1 = 10;
            if (object.ReferenceEquals(n1, n2))
            {
                Console.WriteLine("n1 reference equals with n2.");
            }
            else
            {
                Console.WriteLine("n1 reference deos not equal with n2."); 
            }

            n2 = 10;
            if (object.ReferenceEquals(n1, n2))
            {
                Console.WriteLine("n1 reference equals with n2.");
            }
            else
            {
                Console.WriteLine("n1 reference deos not equal with n2.");
            }

            n2 = n1;
            if (object.ReferenceEquals(n1, n2))
            {
                Console.WriteLine("n1 reference equals with n2.");
            }
            else
            {
                Console.WriteLine("n1 reference deos not equal with n2.");
            }

            Console.Read();
        }


    }
}
