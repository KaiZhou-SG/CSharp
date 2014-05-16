using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdDelegate00
{
    /// <summary>
    /// 2014-05-16 Zhou Kai writes this program to
    /// learn and practice the concepts of delegate
    /// </summary>
    internal class Program
    {
        // although this Main method is marked as 
        // public, but it cannot be invoked by 
        // AnotherClass, because its containing type
        // the Program class is marked as internal.
        internal /*public*/ static void Main(string[] args)
        {
            SaySomething delSay;
            Program p = new Program();
            
            delSay = p.say;
            delSay("Hello world!");
            Console.ReadKey();
        }

        private object say(object somethingToSay)
        {
            Console.WriteLine(somethingToSay.ToString());
            
            return somethingToSay;
        }

        private delegate object SaySomething(object something);
    }
}
