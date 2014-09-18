using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_principle01
{
    /// <summary>
    /// 2014-09-17 Zhou Kai adds this class: to test
    /// the practice of the first principle: isolate the 
    /// parts that vary from that stay the same.
    /// 
    /// Practice 1 ~ 3 demonstrates that as the 
    /// dynamic behaviors are separated from the 
    /// static properties, we are able to only inherit the 
    /// behaviors that we want.
    /// </summary>
    public class Program
    {
        internal static void Main(string[] args)
        {
            #region "Practice 1, define dog and cat as interface"
            // If define as 
            iBarkable animal = new Dog("Lao Wang", 0);
            iBarkable animal2 = new Cat("Lao Zhang", 1);
            iFlyable bird = new Bird("Lao Wu", 2);

            Console.WriteLine(animal.bark());
            Console.WriteLine(animal2.bark());
            Console.WriteLine(bird.fly());
            #endregion

            #region "Practice 2, define dog and cat as animal"
            // If define as animal, they don't have
            // interface function
            Animal animal3 = new Dog("Lao Wang", 0);
            Animal animal4 = new Cat("Lao Zhang", 1);
            Animal bird2 = new Bird("Lao Wu", 2);

            //Console.WriteLine(animal3.bark()); // compile error
            //Console.WriteLine(animal4.bark()); // compile error
            // 
            #endregion

            #region "Practice 3, define a dog as a flyable dog"
            FlyableDog dog = new FlyableDog("Flyable dog", 3);
            Console.WriteLine(dog.bark());
            Console.WriteLine(dog.fly());
            #endregion

            Console.Read();
        }
    }
}
