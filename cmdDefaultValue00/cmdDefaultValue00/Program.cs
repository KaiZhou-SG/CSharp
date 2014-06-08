using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdDefaultValue00
{
    public class Program
    {
        internal static void Main(string[] args)
        {
            int integer = default(int);
            float f = default(float);
            double d = default(double);
            MyType mt = default(MyType);  // notice, the default value of a reference type is always null

            Console.ReadKey();
        }
    }

    public class MyType
    {
        public MyType()
        {
 
        }

        private int num1;
        private string hello;
        private float f;
        private enum en { stu1, stu2, stu3 };
    }
}
