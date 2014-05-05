using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdClone_Easy00
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Toy toyforCat = new Toy(1, "little toy", 10m);
            Cat catA = new Cat(1, "Miaomiao", 5.0m, toyforCat);
            Cat catB = (Cat)catA.Clone();

            Console.WriteLine("Hi, I'm catB, and my id is {0}, my name is {1}, and my weight is {2}, " +
                              "\nI have a toy, it's id is {3}, it's name is {4}, and it's price is {5}.",
                             catB.Id, catB.Name, catB.Weight, catB.Toy_.Id, catB.Toy_.Name, catB.Toy_.Price);
            Console.WriteLine("catA {0} catB.", ReferenceEquals(catA, catB) ? "reference_equals with" : "reference NOT equals with" );
            Console.WriteLine("catA's toy {0} catB's toy.", ReferenceEquals(catA.Toy_, catB.Toy_) ? "reference_equals with" : "reference NOT equals with");

            Console.Read();
            return;
        }
    }
}
