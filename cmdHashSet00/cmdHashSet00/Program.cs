using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdHashSet00
{
    class Program
    {
        internal static void Main(string[] args)
        {
            HashSet<int> intSet = new HashSet<int>();

            intSet.Add(1);
            intSet.Add(1);
            intSet.Add(1);
            intSet.Add(1);
            intSet.Add(2);

            foreach(object item in intSet)
            {
                Console.WriteLine(item.ToString()); // displays only 1 and 2 each once
            }

            Console.ReadKey();
        }
    }
}
