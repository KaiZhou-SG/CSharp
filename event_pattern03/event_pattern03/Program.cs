using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using event_pattern03.event_pattern;

namespace event_pattern03
{
    public class Program
    {
        internal static void Main(string[] args)
        {
            Boss b = new Boss();
            for (int i = 0; i < 5; i++)
            {
                b.deductSalary(300);
            }

            Console.Read();

        }
    }
}
