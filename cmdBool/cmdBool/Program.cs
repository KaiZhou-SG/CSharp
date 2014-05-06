using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cmdBool
{
    /// <summary>
    /// 2014-02-02 Zhou Kai writes this program to learn the type: bool
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            bool bTrue = true;
            bool bFalse = false;

            Console.WriteLine("bTrue.ToString(): {0}", bTrue.ToString());
            Console.WriteLine("bFalse.ToString(): {0}", bFalse.ToString());

            Console.WriteLine("Convert.ToInt32(bTrue): {0}", Convert.ToInt32(bTrue));
            Console.WriteLine("Convert.ToInt32(bFalse): {0}", Convert.ToInt32(bFalse));

            Console.Read();
            return;
        }
    }
}
