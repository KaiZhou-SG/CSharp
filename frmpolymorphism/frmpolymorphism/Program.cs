using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(3m);
            Shape s;
            s = c;
            s.SayName();
            Console.WriteLine("The area of the square is: {0}.", s.Area);
    
            decimal l = 1.0m, w = 2.0m;
            Square sq = new Square(l, w);
            s = sq;
            s.SayName();
            Console.WriteLine("The area of the square is: {0}.", s.Area);

            Console.Read();
        }
    }
}
