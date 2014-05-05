using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trycatch00
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i >= 0; i--)
            {
                try
                {
                    System.Console.WriteLine("{0}", divide(i + 1, i));
                }
                catch (DivideByZeroException dbzEx)
                {
                    System.Console.WriteLine(dbzEx.Message);
                }
            }

            System.Console.Read();
        }

        static public decimal divide(decimal d1, decimal d2)
        {
            try
            {
                return (d1 / d2);
            }
            catch (DivideByZeroException dbzEx)
            {
                throw dbzEx;
            }
        }
    }



}
