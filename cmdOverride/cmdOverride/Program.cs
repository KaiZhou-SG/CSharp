using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdOverride
{
    public class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple();
            Console.WriteLine(apple.SelfCheck());

            Console.ReadKey();
        }
    }
}
