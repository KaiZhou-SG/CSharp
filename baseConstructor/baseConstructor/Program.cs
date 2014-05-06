using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseConstructor
{
    public class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(1, "black", 2M);
            Square s = new Square(2, "white", 3M);

            Console.ReadKey();
        }
    }
}
