using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdInherit00
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            #region "Polymorphism"
            Animal animal = new Cat(); // Upper Cast
            Console.WriteLine(animal.Sound());

            animal = new Dog();
            Console.WriteLine(animal.Sound());

            animal = new Bird();
            Console.WriteLine(animal.Sound());

            #endregion
            

            Console.Read();
            return;
        }
    }
}
