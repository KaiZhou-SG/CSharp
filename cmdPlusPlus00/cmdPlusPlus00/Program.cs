using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdPlusPlus00
{
    /// <summary>
    /// this program is to test prefix and postfix plus-plus
    /// </summary>
    public class Program
    {
        internal static void Main(string[] args)
        {
            int pre = 0, pos = 0;

            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine("pre = " + (++pre).ToString() + ", and pos = " + (pos++).ToString());
            }

            Console.ReadKey();
        }
    }
}
