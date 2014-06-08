using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdStringReverse00
{
    /// <summary>
    /// 2014-06-04 Zhou Kai writes this class to try the
    /// String.Reverse() method, it's an extension method
    /// under the System.Linq; namespace.
    /// </summary>
    public class StringFactory
    {
        public void SayReverse()
        {
            string msg = "Hello, world!";

            Console.WriteLine(msg.Reverse()); // actual output: type information instead of reversed string value
            Console.WriteLine(msg.Reverse().ToArray()); // reversed string value
        }

    }
}
