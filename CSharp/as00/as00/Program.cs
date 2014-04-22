using System;

/// <summary>
/// This example shows to use the keyword 'as',
/// to convert nullable types.
/// The 'as' operator is like a cast operation. 
/// However, if the conversion isn't possible, 
/// as returns null instead of raising an exception.
/// </summary>

class csrefKeywordsOperators
{
    class Base
    {
        public override string ToString()
        {
            return "Base";
        }
    }
    class Derived : Base
    { }

    class Program
    {
        static void Main()
        {

            Derived d = new Derived();

            Base b = d as Base;
            if (b != null)
            {
                Console.WriteLine(b.ToString());
            }

            Console.In.Read();
        }
    }
}