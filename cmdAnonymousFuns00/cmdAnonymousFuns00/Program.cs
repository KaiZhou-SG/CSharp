using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdAnonymousFuns00
{
    /// <summary>
    /// 2014-08-05 Zhou Kai writes this program to learn and practice the concept of 
    /// anonymous functions and delegates.
    /// ref: http://msdn.microsoft.com/en-us/library/bb882516.aspx
    /// </summary>
    public class Program
    {
        private void saySomething(string s) { Console.WriteLine(s); }
        // define a delegate(including the function signature and return type)
        private delegate void delSaySomething(string s); 

        internal static void Main(string[] args)
        {
            Program pgm = new Program();

            pgm.demo();
            Console.ReadKey();
        }

        private void demo()
        {
            // first version, pass a named function to initialize a delegate(no concept of anonymous function)
            delSaySomething del = saySomething;
            del("I'm initialized by a named function");
            // second version, pass a delegate to initialize another delegate as anonymous function
            del = delegate(string s) { Console.WriteLine(s); };
            del("I'm initialized by a delegate, one kind of anonymous function.");
            // third version, pass a lambda expression as anonymous function
            del = (x) => Console.WriteLine(x);
            del("I'm initialized by a lambda, the other kind of anonymous function.");
        }
    }
}
